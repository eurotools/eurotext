using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmMain : Form
    {
        internal MostRecentFilesMenu RecentFilesMenu;

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmMain()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        //  MAINFORM
        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Recen files
            if (string.IsNullOrEmpty(GlobalVariables.WorkingDirectory))
            {
                Groupbox_Output.Enabled = false;
            }
            else
            {
                RecentFilesMenu.AddFile(GlobalVariables.WorkingDirectory);
                RecentFilesMenu.SaveToIniFile();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application INI
            IniFile applicationIni = new IniFile(GlobalVariables.EuroTextIni);
            applicationIni.Write("UserName", GlobalVariables.EuroTextUser, "Misc");
            applicationIni.Write("Last_Project_Opened", GlobalVariables.WorkingDirectory, "Misc");
            applicationIni.Write("HashTablesAdmin_Path", GlobalVariables.HashtablesAdminPath, "Settings");
            applicationIni.Write("includeDataInfoSheet", Checkbox_DataInfoSheet.Checked.ToString(), "MainForm");
            applicationIni.Write("includeFormatInfoSheet", Checkbox_FormatInfo.Checked.ToString(), "MainForm");
            applicationIni.Write("includeNoSectionedHashCodes", Checkbox_IncludeHashCodesWithNoSection.Checked.ToString(), "MainForm");
            applicationIni.Write("OutputFileName", Textbox_FileName.Text, "MainForm");
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void MenuItemFile_Recent_Click(int number, string filename)
        {
            if (Directory.Exists(filename))
            {
                //Update Global variable and restart
                GlobalVariables.WorkingDirectory = filename;

                //Restart application
                Application.Restart();
            }
            else
            {
                MessageBox.Show(string.Format("Project Directory Not Found {0}", filename), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                RecentFilesMenu.RemoveFile(number);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // MENU ITEM - FILE
        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemStrip_OpenProject_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Update Global variable and restart
                GlobalVariables.WorkingDirectory = Path.GetDirectoryName(OpenFileDialog.FileName);

                //Restart application
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemStrip_NewProject_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //Update Global variable and restart
                GlobalVariables.WorkingDirectory = FolderBrowserDialog.SelectedPath;

                //Create Folders
                string outputDirectory = Path.Combine(GlobalVariables.WorkingDirectory, "Output");
                Directory.CreateDirectory(outputDirectory);
                Directory.CreateDirectory(Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles"));
                Directory.CreateDirectory(Path.Combine(GlobalVariables.WorkingDirectory, "Messages"));

                //Write file
                EuroText_ProjectFile projFile = new EuroText_ProjectFile
                {
                    MessagesDirectory = GlobalVariables.WorkingDirectory,
                    SpreadSheetsDirectory = outputDirectory
                };

                ETXML_Writter filesWriter = new ETXML_Writter();
                filesWriter.WriteProjectFile(Path.Combine(GlobalVariables.WorkingDirectory, "Project.etp"), projFile);

                //Ask for userName if required
                if (string.IsNullOrEmpty(GlobalVariables.EuroTextUser))
                {
                    GlobalVariables.EuroTextUser = CommonFunctions.AskForUserName("MyName");
                }

                //Restart application
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemStrip_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Menu Item Help
        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemHelp_About_Click(object sender, EventArgs e)
        {
            using (FrmAbout aboutForm = new FrmAbout())
            {
                aboutForm.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Controls
        //-------------------------------------------------------------------------------------------------------------------------------
        private void LboxGroups_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lboxGroups.SelectedItem != null)
            {
                string selectedGroup = lboxGroups.SelectedItem.ToString();
                string[] currentGroupSections = CommonFunctions.GetGroupSections(selectedGroup);

                //Clear items
                lboxSectionTexts.BeginUpdate();
                lboxSectionTexts.Items.Clear();
                lboxSectionTexts.EndUpdate();
                lblTotalHashCodes.Text = "Total: " + lboxSectionTexts.Items.Count;

                //Add new items
                lboxOutSections.BeginUpdate();
                lboxOutSections.Items.Clear();
                lboxOutSections.Items.AddRange(currentGroupSections);
                lboxOutSections.EndUpdate();
                lblTotalOutSections.Text = "Total: " + lboxOutSections.Items.Count;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void LboxOutSections_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            lboxSectionTexts.BeginUpdate();
            lboxSectionTexts.Items.Clear();

            //Add items
            if (lboxOutSections.SelectedItem != null)
            {
                lboxSectionTexts.Items.Clear();

                string currentSection = lboxOutSections.SelectedItem.ToString();
                string[] currentGroupHashcodes = CommonFunctions.GetSectionHashcodes(currentSection);
                lboxSectionTexts.Items.AddRange(currentGroupHashcodes);

                lblTotalHashCodes.Text = "Total: " + lboxSectionTexts.Items.Count;
            }

            lboxSectionTexts.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Misc Section
        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnProjectProperties_Click(object sender, System.EventArgs e)
        {
            FrmProjectProperties frmProjProperties = new FrmProjectProperties();
            frmProjProperties.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnUpdateHashTable_Click(object sender, System.EventArgs e)
        {
            if (File.Exists(GlobalVariables.HashtablesAdminPath))
            {
                Queue<string> hashcodes = new Queue<string>();

                string[] availableTexts = Directory.GetFiles(Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages"), "*.etf", SearchOption.AllDirectories);
                for (int i = 0; i < availableTexts.Length; i++)
                {
                    hashcodes.Enqueue(Path.GetFileNameWithoutExtension(availableTexts[i]));
                }

                while (hashcodes.Count > 0)
                {
                    string commandLine = "/A HT_Text";
                    for (int i = 0; i < 600; i++)
                    {
                        if (hashcodes.Count > 0)
                        {
                            commandLine = commandLine + " " + hashcodes.Dequeue();
                        }
                        else
                        {
                            break;
                        }
                    }

                    //Run HT_Admin
                    Process HtAdmin = new Process();
                    HtAdmin.StartInfo.FileName = GlobalVariables.HashtablesAdminPath;
                    HtAdmin.StartInfo.Arguments = commandLine;
                    HtAdmin.Start();
                    HtAdmin.WaitForExit();
                }
            }
            else
            {
                MessageBox.Show("Could not find the HashTable Admin Tool, please set the file path under the project settings form.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnSpreadSheetsExtract_Click(object sender, System.EventArgs e)
        {
            FrmSpreadsheetsExtractor frmSpreadSheetExtract = new FrmSpreadsheetsExtractor();
            frmSpreadSheetExtract.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnSetTextSections_Click(object sender, System.EventArgs e)
        {
            using (FrmTextSections sections = new FrmTextSections())
            {
                sections.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnSectionsInspector_Click(object sender, EventArgs e)
        {
            using (FrmSectionsInspector sectionsInspector = new FrmSectionsInspector())
            {
                sectionsInspector.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnSearch_Click(object sender, System.EventArgs e)
        {
            using (FrmSearcher searcherForm = new FrmSearcher())
            {
                searcherForm.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnImportTextFiles_Click(object sender, EventArgs e)
        {
            using (FrmImportFiles importTextFiles = new FrmImportFiles())
            {
                importTextFiles.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Tools
        //-------------------------------------------------------------------------------------------------------------------------------
        private void WordsReplace_Click(object sender, System.EventArgs e)
        {
            using (FrmToolsWordReplace replaceWords = new FrmToolsWordReplace())
            {
                replaceWords.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnRemoveDoubleSpacing_Click(object sender, System.EventArgs e)
        {
            using (FrmToolRemoveMultiWhitespaces removeWhiteSpaces = new FrmToolRemoveMultiWhitespaces())
            {
                removeWhiteSpaces.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnTrimStrings_Click(object sender, System.EventArgs e)
        {
            using (FrmToolTrim stringsTrim = new FrmToolTrim())
            {
                stringsTrim.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnFontBuilder_Click(object sender, EventArgs e)
        {
            using (FrmFontBuilder fontBUilder = new FrmFontBuilder())
            {
                fontBUilder.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnTranslations_Click(object sender, EventArgs e)
        {
            using (FrmTranslations translationsManager = new FrmTranslations())
            {
                translationsManager.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnProjectCompare_Click(object sender, EventArgs e)
        {
            using (FrmProjectsCompare comparer = new FrmProjectsCompare())
            {
                comparer.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Context Menu Groups
        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemGroups_New_Click(object sender, EventArgs e)
        {
            using (FrmInputBox newGroupForm = new FrmInputBox("Create New", "Enter Name", ""))
            {
                if (newGroupForm.ShowDialog() == DialogResult.OK)
                {
                    //Format the name
                    string newGroupName = newGroupForm.ReturnValue.ToUpper().Trim();
                    if (!newGroupName.StartsWith("M_"))
                    {
                        newGroupName = string.Join("", "M_", newGroupName);
                    }

                    //Add the group to the list
                    if (!lboxGroups.Items.Contains(newGroupName))
                    {
                        lboxGroups.Items.Add(newGroupName);

                        //Get text file path
                        string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextGroups.etf");
                        if (File.Exists(textGroupsFilePath))
                        {
                            ETXML_Reader projectFileReader = new ETXML_Reader();
                            EuroText_TextGroups textGroupsData = projectFileReader.ReadTextGroupsFile(textGroupsFilePath);
                            textGroupsData.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                            textGroupsData.LastModifiedBy = GlobalVariables.EuroTextUser;
                            textGroupsData.TextGroups = lboxGroups.Items.OfType<string>().ToList();

                            //Write file
                            ETXML_Writter filesWriter = new ETXML_Writter();
                            filesWriter.WriteTextGroups(textGroupsFilePath, textGroupsData);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The new group could not be added, a group with the same name already exists.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    lblTotalGroups.Text = "Total: " + lboxGroups.Items.Count;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemGroups_Rename_Click(object sender, EventArgs e)
        {
            if (lboxGroups.SelectedItems.Count == 1)
            {
                string currentName = lboxGroups.SelectedItem.ToString();
                using (FrmInputBox renameGroupForm = new FrmInputBox("Rename Group", "Enter New Name", currentName))
                {
                    if (renameGroupForm.ShowDialog() == DialogResult.OK)
                    {
                        //Format the name
                        string newGroupName = renameGroupForm.ReturnValue.ToUpper().Trim();
                        if (!newGroupName.StartsWith("M_"))
                        {
                            newGroupName = string.Join("", "M_", newGroupName);
                        }

                        //Add the group to the list
                        if (!lboxGroups.Items.Contains(newGroupName))
                        {
                            ETXML_Reader filesReader = new ETXML_Reader();
                            ETXML_Writter filesWritter = new ETXML_Writter();

                            int selectedIndex = lboxGroups.SelectedIndex;

                            //Update Texts
                            string[] availableTexts = Directory.GetFiles(Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages"), "*.etf", SearchOption.AllDirectories);
                            for (int i = 0; i < availableTexts.Length; i++)
                            {
                                EuroText_TextFile textFileData = filesReader.ReadTextFile(availableTexts[i]);
                                if (textFileData.Group.Equals(lboxGroups.Items[selectedIndex]))
                                {
                                    textFileData.Group = newGroupName;
                                    filesWritter.WriteTextFile(availableTexts[i], textFileData);
                                }
                            }
                            lboxGroups.Items[selectedIndex] = newGroupName;

                            //Get text file path
                            string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextGroups.etf");
                            if (File.Exists(textGroupsFilePath))
                            {
                                EuroText_TextGroups textGroupsData = filesReader.ReadTextGroupsFile(textGroupsFilePath);
                                textGroupsData.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                                textGroupsData.LastModifiedBy = GlobalVariables.EuroTextUser;
                                textGroupsData.TextGroups = lboxGroups.Items.OfType<string>().ToList();

                                //Write file
                                filesWritter.WriteTextGroups(textGroupsFilePath, textGroupsData);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The new group name already exists. Choose a different name.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemGroups_Delete_Click(object sender, EventArgs e)
        {
            string[] itemsToDelete = lboxGroups.SelectedItems.OfType<string>().ToArray();
            DialogResult answerQuestion = MessageBox.Show(CommonFunctions.MultipleDeletionMessage("Are you sure you want to delete Groups", itemsToDelete), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answerQuestion == DialogResult.Yes)
            {
                if (lboxGroups.SelectedItems.Count > 0)
                {
                    SelectedObjectCollection selectedItems = lboxGroups.SelectedItems;
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        lboxGroups.Items.Remove(selectedItems[i]);
                    }

                    //Get text file path
                    string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextGroups.etf");
                    if (File.Exists(textGroupsFilePath))
                    {
                        ETXML_Reader projectFileReader = new ETXML_Reader();
                        EuroText_TextGroups textGroupsData = projectFileReader.ReadTextGroupsFile(textGroupsFilePath);
                        textGroupsData.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                        textGroupsData.LastModifiedBy = GlobalVariables.EuroTextUser;
                        textGroupsData.TextGroups = lboxGroups.Items.OfType<string>().ToList();

                        //Write file
                        ETXML_Writter filesWriter = new ETXML_Writter();
                        filesWriter.WriteTextGroups(textGroupsFilePath, textGroupsData);
                    }

                    lblTotalGroups.Text = "Total: " + lboxGroups.Items.Count;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemGroups_Refresh_Click(object sender, EventArgs e)
        {
            lboxSectionTexts.Items.Clear();
            lboxOutSections.Items.Clear();
            lblTotalOutSections.Text = "Total: " + lboxOutSections.Items.Count;
            lblTotalHashCodes.Text = "Total: " + lboxSectionTexts.Items.Count;
            ReadTextGroups();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Context Menu Texts
        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextEdit_Click(object sender, System.EventArgs e)
        {
            if (lboxSectionTexts.SelectedItems.Count == 1)
            {
                LboxSectionTexts_MouseDoubleClick(sender, null);
            }
            else if (lboxSectionTexts.SelectedItems.Count > 1)
            {
                //Get all selected items
                List<string> fileNames = new List<string>();
                for (int i = 0; i < lboxSectionTexts.SelectedItems.Count; i++)
                {
                    fileNames.Add(lboxSectionTexts.SelectedItems[i].ToString());
                }

                //Show multi editor
                FrmMainTextEditor_Multi multiEditor = new FrmMainTextEditor_Multi(fileNames.ToArray());
                multiEditor.ShowDialog();
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextNew_Click(object sender, System.EventArgs e)
        {
            FrmInputBox frmTextFileName = new FrmInputBox("Create New", "Enter Name", "");
            if (frmTextFileName.ShowDialog() == DialogResult.OK)
            {
                Match match = Regex.Match(frmTextFileName.ReturnValue, @"^[a-zA-Z0-9_]*$");
                if (match.Success)
                {
                    //Ensure that the hashcode contains the section
                    if (!frmTextFileName.ReturnValue.StartsWith("HT_Text_", StringComparison.OrdinalIgnoreCase))
                    {
                        frmTextFileName.ReturnValue = "HT_Text_" + frmTextFileName.ReturnValue;
                    }

                    //Get file path and create a new object
                    string projectFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", frmTextFileName.ReturnValue + ".etf");
                    EuroText_TextFile newTextFile = new EuroText_TextFile
                    {
                        FirstCreated = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                        CreatedBy = GlobalVariables.EuroTextUser,
                        LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                        LastModifiedBy = GlobalVariables.EuroTextUser
                    };

                    //Add languages to the text file.
                    for (int i = 0; i < GlobalVariables.CurrentProject.Languages.Count; i++)
                    {
                        string langaugeToAdd = GlobalVariables.CurrentProject.Languages[i];
                        newTextFile.Messages.Add(langaugeToAdd, string.Empty);
                    }

                    //Write file
                    ETXML_Writter filesWriter = new ETXML_Writter();
                    filesWriter.WriteTextFile(projectFilePath, newTextFile);

                    //Add item to the listbox
                    lboxSectionTexts.ClearSelected();
                    int newItemText = lboxSectionTexts.Items.Add(frmTextFileName.ReturnValue);
                    lboxSectionTexts.SelectedIndex = newItemText;

                    //Open file
                    LboxSectionTexts_MouseDoubleClick(sender, null);
                }
                else
                {
                    MessageBox.Show("Label '" + frmTextFileName.ReturnValue + "' uses invalid characters, only numbers, digits and underscore characters are allowed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextDelete_Click(object sender, System.EventArgs e)
        {
            if (lboxSectionTexts.SelectedItems.Count > 0)
            {
                List<string> itemsToDelete = new List<string>();
                foreach (string textName in lboxSectionTexts.SelectedItems)
                {
                    itemsToDelete.Add(textName);
                }

                DialogResult answerQuestion = MessageBox.Show(CommonFunctions.MultipleDeletionMessage("Are you sure you want to delete HashCodes", itemsToDelete.ToArray()), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answerQuestion == DialogResult.Yes)
                {
                    //Crate trash folder
                    string trashFolder = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages_Trash");
                    Directory.CreateDirectory(trashFolder);

                    foreach (string itemToRemove in itemsToDelete)
                    {
                        //Remove EuroTextFile
                        string filePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", itemToRemove + ".etf");
                        File.Move(filePath, Path.Combine(trashFolder, itemToRemove + ".etf"));
                    }
                    UpdateTextsListbox();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextRename_Click(object sender, System.EventArgs e)
        {
            if (lboxSectionTexts.SelectedItems.Count == 1)
            {
                FrmInputBox frmTextFileName = new FrmInputBox("Rename", "Enter New Name", "");
                if (frmTextFileName.ShowDialog() == DialogResult.OK)
                {
                    Match match = Regex.Match(frmTextFileName.ReturnValue, @"^[a-zA-Z0-9_]*$");
                    if (match.Success)
                    {
                        //Ensure that the hashcode contains the section
                        if (!frmTextFileName.ReturnValue.StartsWith("HT_Text_", StringComparison.OrdinalIgnoreCase))
                        {
                            frmTextFileName.ReturnValue = "HT_Text_" + frmTextFileName.ReturnValue;
                        }

                        //Get file path and create a new object
                        string newFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", frmTextFileName.ReturnValue + ".etf");

                        //Move file
                        if (File.Exists(newFilePath))
                        {
                            MessageBox.Show(string.Join("", "'", frmTextFileName.ReturnValue, "' already exists please use another name!"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string sourceFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lboxSectionTexts.SelectedItems[0] + ".etf");
                            File.Move(sourceFilePath, newFilePath);
                            UpdateTextsListbox();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Label '" + frmTextFileName.ReturnValue + "' uses invalid characters, only numbers, digits and underscore characters are allowed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void SetCategoriesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (lboxSectionTexts.SelectedItems.Count > 0)
            {
                //Update TextFile
                string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lboxSectionTexts.SelectedItem + ".etf");
                if (File.Exists(textFilePath))
                {
                    //Show flags selector
                    using (FrmSetCategories categoriesEditor = new FrmSetCategories(lboxSectionTexts, 0))
                    {
                        categoriesEditor.ShowDialog();
                    }
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextEditGroups_Click(object sender, EventArgs e)
        {
            FrmMultSetGroup setGroup = new FrmMultSetGroup();
            if (setGroup.ShowDialog() == DialogResult.OK)
            {
                //Get the group that use user has selected
                string selectedGroup = setGroup.selectedTextGroup;

                //Call reader lib
                ETXML_Reader filesReader = new ETXML_Reader();
                ETXML_Writter filesWriter = new ETXML_Writter();

                for (int i = 0; i < lboxSectionTexts.Items.Count; i++)
                {
                    string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lboxSectionTexts.Items[i] + ".etf");
                    if (File.Exists(textFilePath))
                    {
                        //Update property
                        EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);
                        textObjectData.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                        textObjectData.LastModifiedBy = GlobalVariables.EuroTextUser;
                        textObjectData.Group = selectedGroup;

                        //Write file again
                        filesWriter.WriteTextFile(textFilePath, textObjectData);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextCopyHashCode_Click(object sender, System.EventArgs e)
        {
            if (lboxSectionTexts.SelectedItems.Count == 1)
            {
                Clipboard.SetText(lboxSectionTexts.SelectedItems[0].ToString());
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (string itemToWrite in lboxSectionTexts.Items)
                    {
                        string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", itemToWrite + ".etf");
                        outputFile.WriteLine(textFilePath);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Methods
        //-------------------------------------------------------------------------------------------------------------------------------
        internal void ReadTextGroups()
        {
            //Get text file path
            string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextGroups.etf");
            if (File.Exists(textGroupsFilePath))
            {
                ETXML_Reader projectFileReader = new ETXML_Reader();
                EuroText_TextGroups textGroupsData = projectFileReader.ReadTextGroupsFile(textGroupsFilePath);

                lboxGroups.BeginUpdate();
                lboxGroups.Items.Clear();
                lboxGroups.Items.AddRange(textGroupsData.TextGroups.ToArray());
                lboxGroups.EndUpdate();

                lblTotalGroups.Text = "Total: " + lboxGroups.Items.Count;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void UpdateTextsListbox()
        {
            //Save previous selection
            object outputSection = lboxOutSections.SelectedItem;

            //Update list again
            LboxGroups_SelectedIndexChanged(null, null);


            lboxOutSections.SelectedItem = outputSection;
            LboxOutSections_SelectedIndexChanged(null, null);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void LboxSectionTexts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lboxSectionTexts.SelectedItem + ".etf");
            if (File.Exists(textFilePath))
            {
                using (FrmMainTextEditor editor = new FrmMainTextEditor(textFilePath))
                {
                    editor.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ChkEnablePreview_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnablePreview.Checked)
            {
                CommonFunctions.AddLanguagesToPreviewControl(tabControlTextPreview);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void LboxSectionTexts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxSectionTexts.SelectedItems.Count != 1 || !chkEnablePreview.Checked) return;

            string filePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", lboxSectionTexts.SelectedItems[0] + ".etf");
            CommonFunctions.PreviewTextFile(tabControlTextPreview, filePath);
        }

    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
