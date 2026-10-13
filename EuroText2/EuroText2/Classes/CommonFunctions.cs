using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal static class CommonFunctions
    {
        private sealed class TextIndexEntry
        {
            internal string HashCode;
            internal string Group;
            internal string[] OutputSections;
        }

        private sealed class TextSectionIndex
        {
            internal string FilePath;
            internal DateTime LastWriteUtc;
            internal Dictionary<string, string> ByCode;
            internal Dictionary<string, string> ByLabel;
        }

        private static readonly object TextIndexSync = new object();
        private static string TextIndexDirectory = string.Empty;
        private static TextIndexEntry[] TextIndexEntries;
        private static Dictionary<string, string[]> GroupSectionIndex;
        private static Dictionary<string, string[]> SectionHashCodeIndex;
        private static FileSystemWatcher TextIndexWatcher;
        private static TextSectionIndex CachedTextSections;

        //-------------------------------------------------------------------------------------------------------------------------------
        //  USERNAME
        //-------------------------------------------------------------------------------------------------------------------------------
        internal static string AskForUserName(string defaultName)
        {
            string inputUserName = defaultName;

            do
            {
                FrmInputBox textInfo = new FrmInputBox("Enter UserName.", "Please enter your username.", "");
                if (textInfo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    inputUserName = textInfo.ReturnValue;
                }
            } while (string.IsNullOrEmpty(inputUserName));

            return inputUserName;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        //  Text Files
        //-------------------------------------------------------------------------------------------------------------------------------
        internal static string[] GetGroupSections(string groupToSearch)
        {
            TextSectionIndex sections = GetTextSectionIndex();
            GetTextIndex();

            if (!GroupSectionIndex.TryGetValue(groupToSearch, out string[] sectionCodes))
            {
                return new string[0];
            }

            string[] array = new string[sectionCodes.Length];
            for (int i = 0; i < sectionCodes.Length; i++)
            {
                string section = sectionCodes[i];
                array[i] = string.IsNullOrEmpty(section)
                    ? "Not Set"
                    : (sections.ByCode.TryGetValue(section, out string friendly) ? friendly : section);
            }
            Array.Sort(array);
            return array;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static string[] GetSectionHashcodes(string OutputSectionLabel, string OutputSectionHashCode = "")
        {
            string sectionHashCode = OutputSectionHashCode;
            if (!string.IsNullOrEmpty(OutputSectionLabel) && !OutputSectionLabel.Equals("Not Set", StringComparison.OrdinalIgnoreCase))
            {
                GetTextSectionIndex().ByLabel.TryGetValue(OutputSectionLabel, out sectionHashCode);
            }

            GetTextIndex();
            return SectionHashCodeIndex.TryGetValue(sectionHashCode ?? string.Empty, out string[] hashCodes)
                ? (string[])hashCodes.Clone()
                : new string[0];
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void InvalidateTextIndex()
        {
            lock (TextIndexSync)
            {
                TextIndexEntries = null;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void UpdateTextIndex(string filePath, string group, string[] outputSections)
        {
            TextIndexEntry entry = new TextIndexEntry
            {
                HashCode = Path.GetFileNameWithoutExtension(filePath),
                Group = group ?? string.Empty,
                OutputSections = outputSections == null
                    ? new string[0]
                    : outputSections.Where(section => !string.IsNullOrEmpty(section)).ToArray()
            };

            lock (TextIndexSync)
            {
                UpdateTextIndexEntry(entry, Path.GetDirectoryName(filePath));
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void InvalidateTextSectionsIndex()
        {
            lock (TextIndexSync)
            {
                CachedTextSections = null;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void WarmTextFilterIndex()
        {
            Task.Run(() =>
            {
                try
                {
                    GetTextSectionIndex();
                    GetTextIndex();
                }
                catch
                {
                    // A normal filter request will retry and surface any real file error.
                }
            });
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private static TextSectionIndex GetTextSectionIndex()
        {
            string filePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            DateTime lastWriteUtc = File.GetLastWriteTimeUtc(filePath);

            lock (TextIndexSync)
            {
                if (CachedTextSections != null &&
                    string.Equals(CachedTextSections.FilePath, filePath, StringComparison.OrdinalIgnoreCase) &&
                    CachedTextSections.LastWriteUtc == lastWriteUtc)
                {
                    return CachedTextSections;
                }

                EuroText_TextSections source = new ETXML_Reader().ReadTextSectionsFile(filePath);
                Dictionary<string, string> byLabel = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                foreach (KeyValuePair<string, string> section in source.TextSections)
                {
                    if (!byLabel.ContainsKey(section.Value))
                    {
                        byLabel.Add(section.Value, section.Key);
                    }
                }

                CachedTextSections = new TextSectionIndex
                {
                    FilePath = filePath,
                    LastWriteUtc = lastWriteUtc,
                    ByCode = new Dictionary<string, string>(source.TextSections, StringComparer.OrdinalIgnoreCase),
                    ByLabel = byLabel
                };
                return CachedTextSections;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private static TextIndexEntry[] GetTextIndex()
        {
            string messagesPath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages");
            lock (TextIndexSync)
            {
                if (TextIndexEntries != null && string.Equals(TextIndexDirectory, messagesPath, StringComparison.OrdinalIgnoreCase))
                {
                    return TextIndexEntries;
                }

                string[] files = Directory.GetFiles(messagesPath, "*.etf", SearchOption.TopDirectoryOnly);
                Array.Sort(files, StringComparer.OrdinalIgnoreCase);

                TextIndexEntry[] entries = new TextIndexEntry[files.Length];
                Parallel.For(
                    0,
                    files.Length,
                    new ParallelOptions { MaxDegreeOfParallelism = Math.Min(Environment.ProcessorCount, 8) },
                    i => entries[i] = ReadTextIndexEntry(files[i]));

                TextIndexDirectory = messagesPath;
                TextIndexEntries = entries;
                BuildFilterLookups(entries);
                ConfigureTextIndexWatcher(messagesPath);
                return TextIndexEntries;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private static void BuildFilterLookups(TextIndexEntry[] entries)
        {
            Dictionary<string, HashSet<string>> groups = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
            Dictionary<string, List<string>> sections = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

            foreach (TextIndexEntry entry in entries)
            {
                if (!groups.TryGetValue(entry.Group ?? string.Empty, out HashSet<string> groupSections))
                {
                    groupSections = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                    groups.Add(entry.Group ?? string.Empty, groupSections);
                }

                string[] outputSections = entry.OutputSections.Length == 0 ? new[] { string.Empty } : entry.OutputSections;
                foreach (string section in outputSections)
                {
                    string sectionKey = section ?? string.Empty;
                    groupSections.Add(sectionKey);

                    if (!sections.TryGetValue(sectionKey, out List<string> hashCodes))
                    {
                        hashCodes = new List<string>();
                        sections.Add(sectionKey, hashCodes);
                    }
                    hashCodes.Add(entry.HashCode);
                }
            }

            GroupSectionIndex = groups.ToDictionary(
                item => item.Key,
                item => item.Value.OrderBy(value => value, StringComparer.OrdinalIgnoreCase).ToArray(),
                StringComparer.OrdinalIgnoreCase);

            SectionHashCodeIndex = sections.ToDictionary(
                item => item.Key,
                item => item.Value.OrderBy(value => value, StringComparer.OrdinalIgnoreCase).ToArray(),
                StringComparer.OrdinalIgnoreCase);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private static void UpdateTextIndexEntry(TextIndexEntry entry, string directory)
        {
            if (TextIndexEntries == null || !string.Equals(TextIndexDirectory, directory, StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            int existingIndex = Array.FindIndex(
                TextIndexEntries,
                item => string.Equals(item.HashCode, entry.HashCode, StringComparison.OrdinalIgnoreCase));

            if (existingIndex >= 0)
            {
                TextIndexEntries[existingIndex] = entry;
            }
            else
            {
                Array.Resize(ref TextIndexEntries, TextIndexEntries.Length + 1);
                TextIndexEntries[TextIndexEntries.Length - 1] = entry;
            }

            BuildFilterLookups(TextIndexEntries);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private static void RefreshTextIndexFile(string filePath)
        {
            try
            {
                TextIndexEntry entry = ReadTextIndexEntry(filePath);
                lock (TextIndexSync)
                {
                    UpdateTextIndexEntry(entry, Path.GetDirectoryName(filePath));
                }
            }
            catch
            {
                // A second Changed event normally follows while an external writer finishes.
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private static void RemoveTextIndexFile(string filePath)
        {
            lock (TextIndexSync)
            {
                if (TextIndexEntries == null ||
                    !string.Equals(TextIndexDirectory, Path.GetDirectoryName(filePath), StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                string hashCode = Path.GetFileNameWithoutExtension(filePath);
                TextIndexEntries = TextIndexEntries
                    .Where(item => !string.Equals(item.HashCode, hashCode, StringComparison.OrdinalIgnoreCase))
                    .ToArray();
                BuildFilterLookups(TextIndexEntries);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private static TextIndexEntry ReadTextIndexEntry(string filePath)
        {
            TextIndexEntry entry = new TextIndexEntry
            {
                HashCode = Path.GetFileNameWithoutExtension(filePath),
                Group = string.Empty,
                OutputSections = new string[0]
            };

            XmlReaderSettings settings = new XmlReaderSettings
            {
                IgnoreComments = true,
                IgnoreWhitespace = true,
                DtdProcessing = DtdProcessing.Prohibit
            };

            using (XmlReader reader = XmlReader.Create(filePath, settings))
            {
                while (!reader.EOF)
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "Group")
                        {
                            entry.Group = reader.ReadElementContentAsString();
                            continue;
                        }
                        if (reader.Name == "OutputSection")
                        {
                            entry.OutputSections = reader.ReadElementContentAsString()
                                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                            return entry;
                        }
                    }

                    reader.Read();
                }
            }

            return entry;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private static void ConfigureTextIndexWatcher(string messagesPath)
        {
            if (TextIndexWatcher != null)
            {
                TextIndexWatcher.Dispose();
                TextIndexWatcher = null;
            }

            try
            {
                TextIndexWatcher = new FileSystemWatcher(messagesPath, "*.etf")
                {
                    NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.Size,
                    IncludeSubdirectories = false,
                    EnableRaisingEvents = true
                };
                TextIndexWatcher.Changed += (sender, e) => RefreshTextIndexFile(e.FullPath);
                TextIndexWatcher.Created += (sender, e) => RefreshTextIndexFile(e.FullPath);
                TextIndexWatcher.Deleted += (sender, e) => RemoveTextIndexFile(e.FullPath);
                TextIndexWatcher.Renamed += (sender, e) =>
                {
                    RemoveTextIndexFile(e.OldFullPath);
                    RefreshTextIndexFile(e.FullPath);
                };
            }
            catch
            {
                // Explicit invalidation in ETXML_Writter still keeps application edits current.
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static string[] ReadTextGroups()
        {
            string[] TextGroups = null;

            //Get text file path
            string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextGroups.etf");
            if (File.Exists(textGroupsFilePath))
            {
                ETXML_Reader projectFileReader = new ETXML_Reader();
                EuroText_TextGroups textGroupsData = projectFileReader.ReadTextGroupsFile(textGroupsFilePath);
                TextGroups = textGroupsData.TextGroups.ToArray();
            }

            return TextGroups;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        //  HASHTABLES
        //-------------------------------------------------------------------------------------------------------------------------------
        internal static HashSet<string> ReadHashTableSection(string hashTableFilePath, string hashTableSection)
        {
            HashSet<string> AvailableHashCodes = new HashSet<string>();
            using (StreamReader file = new StreamReader(hashTableFilePath))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    if (ln.Contains(hashTableSection))
                    {
                        Match regexMatch = Regex.Match(ln, @"#define\s(\w+)");
                        if (regexMatch.Length > 0)
                        {
                            AvailableHashCodes.Add(regexMatch.Groups[1].Value);
                        }
                    }
                }
                file.Close();
            }

            return AvailableHashCodes;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        //  FLAGS
        //-------------------------------------------------------------------------------------------------------------------------------
        internal static string GetFlagsLabels(int flags)
        {
            string flagsLabels = string.Empty;
            for (int i = 0; i < 16; i++)
            {
                if (Convert.ToBoolean((flags >> i) & 1))
                {
                    string label = string.Empty;
                    if (i < GlobalVariables.CurrentProject.Categories.Count)
                    {
                        label = GlobalVariables.CurrentProject.Categories[i];
                    }
                    flagsLabels += label + " | ";
                }
            }

            return flagsLabels.Trim().TrimEnd('|').Trim();
        }

        //-------------------------------------------------------------------------------------------
        //  MULTIPLE DELETION
        //-------------------------------------------------------------------------------------------
        internal static string MultipleDeletionMessage(string messageToShow, string[] itemsToDelete)
        {
            int maxItemsToShow = 33;

            //Create message to inform user
            string filesListToDelete = messageToShow + Environment.NewLine + Environment.NewLine;
            int numItems = Math.Min(maxItemsToShow, itemsToDelete.Length);
            for (int i = 0; i < numItems; i++)
            {
                filesListToDelete += "'" + itemsToDelete[i] + "'" + Environment.NewLine;
            }
            if (itemsToDelete.Length > maxItemsToShow)
            {
                filesListToDelete += "Plus Some More ....." + Environment.NewLine;
                filesListToDelete += "............" + Environment.NewLine;
            }
            filesListToDelete += Environment.NewLine + "Total Files: " + itemsToDelete.Length;
            return filesListToDelete;
        }

        //-------------------------------------------------------------------------------------------
        //  CHECKLISTBOX
        //-------------------------------------------------------------------------------------------
        internal static void CheckListCheckAll(CheckedListBox WichList)
        {
            for (int i = 0; i < WichList.Items.Count; i++)
            {
                WichList.SetItemChecked(i, true);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void CheckListInvertSelection(CheckedListBox WichList)
        {
            for (int i = 0; i < WichList.Items.Count; i++)
            {
                bool isChecked = WichList.GetItemChecked(i);
                WichList.SetItemChecked(i, !isChecked);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void CheckListUncheckAll(CheckedListBox WichList)
        {
            for (int i = 0; i < WichList.Items.Count; i++)
            {
                WichList.SetItemChecked(i, false);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Generic
        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void AddLanguagesToPreviewControl(TabControl WhichControl)
        {
            WhichControl.TabPages.Clear();
            for (int i = 0; i < GlobalVariables.CurrentProject.Languages.Count; i++)
            {
                WhichControl.TabPages.Add(GlobalVariables.CurrentProject.Languages[i]);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void PreviewTextFile(TabControl WhichControl, string FilePath)
        {
            EuroText_TextFile textObjData = new ETXML_Reader().ReadTextFile(FilePath);

            foreach (TabPage tabPage in WhichControl.TabPages)
            {
                string text = textObjData.Messages.TryGetValue(tabPage.Text, out string msg) ? msg : string.Empty;
                TextBox textBox = tabPage.Controls.OfType<TextBox>().FirstOrDefault();

                if (textBox == null)
                {
                    textBox = new TextBox
                    {
                        Multiline = true,
                        Dock = DockStyle.Fill,
                        ReadOnly = true,
                        BackColor = System.Drawing.SystemColors.Window
                    };
                    tabPage.Controls.Add(textBox);
                }

                textBox.Text = text;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void SyncTabsSelection(TabControl tab1, TabControl tab2)
        {
            if (tab1.SelectedIndex >= 0 && tab1.SelectedIndex < tab2.TabPages.Count)
            {
                tab2.SelectedIndex = tab1.SelectedIndex;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void GroupsToCombobox(ComboBox WhichControl)
        {
            //Get all groups
            string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextGroups.etf");
            if (File.Exists(textGroupsFilePath))
            {
                //Read file
                ETXML_Reader projectFileReader = new ETXML_Reader();
                EuroText_TextGroups textGroupsData = projectFileReader.ReadTextGroupsFile(textGroupsFilePath);

                AddArrayToCombobox(WhichControl, textGroupsData.TextGroups.ToArray());
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static void AddArrayToCombobox(ComboBox WhichControl, string[] itemsToAdd)
        {
            WhichControl.BeginUpdate();
            WhichControl.Items.Add("");
            WhichControl.Items.AddRange(itemsToAdd);
            WhichControl.EndUpdate();

            //Select first item
            if (WhichControl.Items.Count > 0)
            {
                WhichControl.SelectedIndex = 0;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static bool GetFlag(uint flags, byte bitPosition)
        {
            return ((1 << (bitPosition & 0x1f)) & flags) != 0;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
