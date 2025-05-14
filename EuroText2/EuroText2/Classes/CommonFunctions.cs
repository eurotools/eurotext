using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal static class CommonFunctions
    {
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
            ETXML_Reader filesReader = new ETXML_Reader();
            ConcurrentDictionary<string, byte> sectionsInThisGroup = new ConcurrentDictionary<string, byte>();

            //Get textsections
            string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            EuroText_TextSections sectionsFileText = filesReader.ReadTextSectionsFile(textSectionsFilePath);

            //Search hashcodes that are in this group
            string[] filesToAdd = Directory.GetFiles(Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly);
            Parallel.ForEach(filesToAdd, file =>
            {
                EuroText_TextFile objText = filesReader.ReadTextFile(file);

                if (objText.Group == groupToSearch)
                {
                    foreach (string outputSection in objText.OutputSection)
                    {
                        string sectionKey = outputSection;
                        if (string.IsNullOrEmpty(sectionKey))
                        {
                            sectionKey = "Not Set";
                        }

                        // Obtener nombre amigable
                        if (sectionsFileText.TextSections.TryGetValue(sectionKey, out string friendlyName))
                        {
                            sectionKey = friendlyName;
                        }

                        // Añadir si no existe
                        sectionsInThisGroup.TryAdd(sectionKey, 0);
                    }
                }
            });

            string[] result = sectionsInThisGroup.Keys.ToArray();
            Array.Sort(result);
            return result;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static string[] GetSectionHashcodes(string levelHashcode, string sectionHashcode = "")
        {
            ETXML_Reader filesReader = new ETXML_Reader();

            //Get section
            string hashcodeToCheck = sectionHashcode;
            if (!string.IsNullOrEmpty(levelHashcode))
            {
                string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
                EuroText_TextSections sectionsFileText = filesReader.ReadTextSectionsFile(textSectionsFilePath);
                hashcodeToCheck = sectionsFileText.TextSections.FirstOrDefault(x => x.Value == levelHashcode).Key;
            }

            //Search hashcodes that are in this group
            string[] filesToAdd = Directory.GetFiles(Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly);
            ConcurrentBag<string> hashCodesInThisGroup = new ConcurrentBag<string>();

            Parallel.ForEach(filesToAdd, file =>
            {
                EuroText_TextFile objText = filesReader.ReadTextFile(file);
                if (objText.OutputSection != null && objText.OutputSection.Contains(hashcodeToCheck))
                {
                    hashCodesInThisGroup.Add(Path.GetFileNameWithoutExtension(file));
                }
            });

            string[] result = hashCodesInThisGroup.Distinct().ToArray();
            Array.Sort(result);
            return result;
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
