using EuroTextEditor.Classes;
using EuroTextEditor.Custom_Controls;
using EuroTextEditor.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_MainFrame : Form
    {
        internal MostRecentFilesMenu RecentFilesMenu;
        internal List<DockContent> m_DockForms = new List<DockContent>();

        //Initialize forms
        internal Frm_ListBox_TextSections textSections = new Frm_ListBox_TextSections();
        internal Frm_ListBox_TextGroups textGroups = new Frm_ListBox_TextGroups();
        internal Frm_ListBoxHashCodes hashCodes = new Frm_ListBoxHashCodes();
        internal Frm_SpreadSheets_Extractor xlsExtractor = new Frm_SpreadSheets_Extractor();
        internal Frm_Searcher searchForm = new Frm_Searcher();

        //Global vars
        private bool ResetSettingsOnExit;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_MainFrame()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_MainFrame_Shown(object sender, EventArgs e)
        {
            //Recen files
            if (string.IsNullOrEmpty(GlobalVariables.WorkingDirectory))
            {
                GroupBox_Misc.Enabled = false;
                Groupbox_Output.Enabled = false;
            }
            else
            {
                RecentFilesMenu.AddFile(GlobalVariables.WorkingDirectory);
                RecentFilesMenu.SaveToIniFile();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  MAINFORM
        //-------------------------------------------------------------------------------------------
        private void Frm_MainFrame_FormClosing(object sender, FormClosingEventArgs e)
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

            //Save all listviews state
            foreach (Form dockForm in m_DockForms)
            {
                SaveListViewConfig(dockForm);
            }

            //Save Dock Panels status
            dockPanel.SaveAsXml("ET\\Dock Settings.xml");

            //Close all forms
            foreach (Form dockForm in m_DockForms)
            {
                dockForm.Close();
            }

            //Reset Settings
            if (ResetSettingsOnExit)
            {
                File.Delete("ET\\Dock Settings.xml");
                foreach (Form dockForm in m_DockForms)
                {
                    File.Delete(GetConfigFile(dockForm));
                }
            }
        }

        //-------------------------------------------------------------------------------------------
        //  MENU ITEM - FILE
        //-------------------------------------------------------------------------------------------        
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
        private void MenuItemStrip_ResetSettings_Click(object sender, EventArgs e)
        {
            ResetSettingsOnExit = true;
            Close();
            Application.Restart();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemStrip_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemStrip_About_Click(object sender, EventArgs e)
        {
            using (Frm_About aboutForm = new Frm_About())
            {
                aboutForm.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  OPTIONS SECTION
        //-------------------------------------------------------------------------------------------
        private void Button_Output_Click(object sender, EventArgs e)
        {
            //Ensure that the last output filepath still exists
            if (Directory.Exists(GlobalVariables.CurrentProject.SpreadSheetsDirectory))
            {
                if (!string.IsNullOrEmpty(Textbox_FileName.Text))
                {
                    //Add extension if required
                    string fileName = Textbox_FileName.Text;
                    if (!fileName.EndsWith(".xls"))
                    {
                        fileName += ".xls";
                    }

                    //Start output
                    string outpuSpeadSheetsFilePath = Path.Combine(GlobalVariables.CurrentProject.SpreadSheetsDirectory, fileName);
                    Frm_SpreadsheetExporter exporterTask = new Frm_SpreadsheetExporter(this, outpuSpeadSheetsFilePath, Checkbox_FormatInfo.Checked, Checkbox_DataInfoSheet.Checked, Checkbox_IncludeHashCodesWithNoSection.Checked);
                    exporterTask.ShowDialog();
                }
                else
                {
                    MessageBox.Show("The output filename is empty.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The output directory does not exists.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_TextStore_Click(object sender, EventArgs e)
        {
            if (hashCodes != null && !hashCodes.IsHidden)
            {
                List<string> filesToModify = new List<string>();
                foreach (ListViewItem Item in hashCodes.UserControl_HashCodesListView.ListView_HashCodes.SelectedItems)
                {
                    filesToModify.Add(Item.Text.ToString());
                }

                //Show form
                using (Frm_TextStore storeText = new Frm_TextStore(filesToModify.ToArray()))
                {
                    storeText.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_ExportHashCodes_Click(object sender, EventArgs e)
        {
            if (hashCodes != null && !hashCodes.IsHidden)
            {
                if (File.Exists(GlobalVariables.HashtablesAdminPath))
                {
                    Queue<string> hashcodes = new Queue<string>();
                    for (int i = 0; i < hashCodes.UserControl_HashCodesListView.ListView_HashCodes.Items.Count; i++)
                    {
                        hashcodes.Enqueue(hashCodes.UserControl_HashCodesListView.ListView_HashCodes.Items[i].Text.ToString());
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
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_ProjectSettings_Click(object sender, EventArgs e)
        {
            using (Frm_ProjectForm projectSettings = new Frm_ProjectForm())
            {
                projectSettings.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_SpreadSheetExtractor_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.FormIsOpened("Frm_SpreadSheets_Extractor"))
            {
                xlsExtractor.Show(dockPanel, DockState.Float);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Searcher_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.FormIsOpened("Frm_Searcher"))
            {
                searchForm.Show(dockPanel, DockState.Float);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal IDockContent DeserializeDockContent(string persistString)
        {
            foreach (DockContent dockForm in m_DockForms)
            {
                if (persistString == dockForm.GetType().ToString())
                {
                    return dockForm;
                }
            }
            return null;
        }

        //-------------------------------------------------------------------------------------------
        //  MAIN MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItemStrip_Windows_DropDownOpening(object sender, EventArgs e)
        {
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemStrip_TextGroups_Click(object sender, EventArgs e)
        {
            textGroups.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemStrip_TextSections_Click(object sender, EventArgs e)
        {
            textSections.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemStrip_HashCodes_Click(object sender, EventArgs e)
        {
            hashCodes.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }

        private void MenuItem_TextGroupsForm_Click(object sender, EventArgs e)
        {
            textGroups.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_TextSectionsForm_Click(object sender, EventArgs e)
        {
            textSections.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_HashCodesForm_Click(object sender, EventArgs e)
        {
            hashCodes.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnTrimStrings_Click(object sender, EventArgs e)
        {
            using (Frm_Tool_Trim stringsTrim = new Frm_Tool_Trim())
            {
                stringsTrim.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnRemoveDoubleSpacing_Click(object sender, EventArgs e)
        {
            using (Frm_Tool_RemoveMultiWhitespaces removeWhiteSpaces = new Frm_Tool_RemoveMultiWhitespaces())
            {
                removeWhiteSpaces.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnWordReplacing_Click(object sender, EventArgs e)
        {
            using (Frm_Tool_ReplaceWords replaceWords = new Frm_Tool_ReplaceWords())
            {
                replaceWords.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void UpdateWindowMenuChecks()
        {
            MenuItemStrip_TextGroups.Checked = textGroups.DockState != DockState.Hidden;
            MenuItemStrip_TextSections.Checked = textSections.DockState != DockState.Hidden;
            MenuItemStrip_HashCodes.Checked = hashCodes.DockState != DockState.Hidden;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private string GetConfigFile(Form f) => "ET\\" + f.Name + ".ini";

        //-------------------------------------------------------------------------------------------------------------------------------
        private void SaveListViewConfig(Form f)
        {
            string contents = "";
            foreach (Control control in (ArrangedElementCollection)f.Controls)
            {
                if (control is ListView listView1)
                {
                    contents += listView1.Name;
                    for (int i = 0; i < listView1.Columns.Count; ++i)
                    {
                        contents = contents + " " + listView1.Columns[i].Width;
                    }
                    contents += "\n";
                }
                if (control is ListView_ColumnSortingClick listView2)
                {
                    contents += listView2.Name;
                    for (int i = 0; i < listView2.Columns.Count; ++i)
                    {
                        contents = contents + " " + listView2.Columns[i].Width;
                    }
                    contents += "\n";
                }
            }
            File.WriteAllText(GetConfigFile(f), contents);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void LoadListViewConfig(Form frm)
        {
            string filePath = GetConfigFile(frm);
            if (File.Exists(filePath))
            {
                string[] fileContent = File.ReadAllLines(filePath);
                foreach (string line in fileContent)
                {
                    string[] lineData = line.Split(' ');
                    Control[] formControls = frm.Controls.Find(lineData[0], false);
                    if (formControls.Length == 1)
                    {
                        ListView listView = (ListView)formControls[0];
                        if (listView.Columns.Count == lineData.Length - 1)
                        {
                            for (int i = 0; i < listView.Columns.Count; ++i)
                            {
                                listView.Columns[i].Width = Convert.ToInt32(lineData[1 + i]);
                            }
                        }
                    }
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
