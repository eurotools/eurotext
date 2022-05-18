using EuroTextEditor.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_MainFrame : Form
    {
        internal Frm_ListBoxHashCodes hashCodes;
        internal Frm_ListBox_TextSections textSections;
        internal Frm_ListBox_TextGroups textGroups;
        internal MostRecentFilesMenu RecentFilesMenu;

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
            applicationIni.Write("OutputFileName", Textbox_FileName.Text, "MainForm");

            //Dock conifg
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockSettingsMainForm.xml");
            dockPanel.SaveAsXml(configFile);
        }

        //-------------------------------------------------------------------------------------------
        //  MENU ITEM - FILE
        //-------------------------------------------------------------------------------------------
        private void MenuItem_OpenProject_Click(object sender, EventArgs e)
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
        internal void MenuItemFile_Recent_Click(int number, string filename)
        {
            if (Directory.Exists(filename))
            {
                //Update Global variable and restart
                GlobalVariables.WorkingDirectory = filename;

                //Restart application
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Project Directory Not Found " + filename, "EuroText Load Project Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RecentFilesMenu.RemoveFile(number);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_NewProject_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //Update Global variable and restart
                GlobalVariables.WorkingDirectory = FolderBrowserDialog.SelectedPath;

                //Create Folders
                Directory.CreateDirectory(Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles"));
                Directory.CreateDirectory(Path.Combine(GlobalVariables.WorkingDirectory, "Messages"));

                //Write file
                EuroText_ProjectFile projFile = new EuroText_ProjectFile();
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
        private void MenuItem_ResetSettings_Click(object sender, EventArgs e)
        {
            hashCodes.DockPanel = dockPanel;
            hashCodes.IsFloat = false;
            hashCodes.IsHidden = false;
            hashCodes.Pane = dockPanel.Panes[0];
            hashCodes.DockState = DockState.Document;

            textSections.DockPanel = dockPanel;
            textSections.IsFloat = false;
            textSections.IsHidden = false;
            textSections.Pane = dockPanel.Panes[0];
            textSections.DockState = DockState.DockLeft;

            textGroups.DockPanel = dockPanel;
            textGroups.IsFloat = false;
            textGroups.IsHidden = false;
            textGroups.Show(textSections.Pane, DockAlignment.Bottom, 0.5);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_About_Click(object sender, EventArgs e)
        {
            Frm_About aboutForm = new Frm_About();
            aboutForm.ShowDialog();
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
                    Frm_SpreadsheetExporter exporterTask = new Frm_SpreadsheetExporter(this, Path.Combine(GlobalVariables.CurrentProject.SpreadSheetsDirectory, fileName), Checkbox_FormatInfo.Checked, Checkbox_DataInfoSheet.Checked);
                    exporterTask.ShowDialog();
                }
                else
                {
                    MessageBox.Show("The output filename is empty.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The output directory does not exists.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                Frm_TextStore storeText = new Frm_TextStore(filesToModify.ToArray());
                storeText.ShowDialog();
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
                    MessageBox.Show("Could not find the HashTable Admin Tool, please set the file path under the project settings form.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_ProjectSettings_Click(object sender, EventArgs e)
        {
            Frm_ProjectForm projectSettings = new Frm_ProjectForm();
            projectSettings.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_SpreadSheetExtractor_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.FormIsOpened("Frm_SpreadSheets_Extractor"))
            {
                Frm_SpreadSheets_Extractor xlsExtractor = new Frm_SpreadSheets_Extractor();
                xlsExtractor.Show(dockPanel, DockState.DockBottom);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Searcher_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.FormIsOpened("Frm_Searcher"))
            {
                Frm_Searcher searchForm = new Frm_Searcher();
                searchForm.Show(dockPanel, DockState.DockBottom);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
