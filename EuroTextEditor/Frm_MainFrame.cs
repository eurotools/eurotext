using EuroTextEditor.Classes;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_MainFrame : Form
    {
        internal readonly Frm_ListBoxHashCodes hashCodes;
        internal readonly Frm_ListBox_TextSections textSections;
        internal readonly Frm_ListBox_TextGroups textGroups;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_MainFrame()
        {
            InitializeComponent();

            //Initialize forms
            hashCodes = new Frm_ListBoxHashCodes(MenuItem_HashCodesForm);
            textSections = new Frm_ListBox_TextSections(MenuItem_TextSectionsForm);
            textGroups = new Frm_ListBox_TextGroups(MenuItem_TextGroupsForm);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_MainFrame_Shown(object sender, EventArgs e)
        {
            //Show forms
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockSettingsMainForm.xml");
            if (File.Exists(configFile))
            {
                DeserializeDockContent _deserializeDockContent = new DeserializeDockContent(DeserializeDockContent);
                dockPanel.LoadFromXml(configFile, _deserializeDockContent);
            }
            else
            {
                hashCodes.Show(dockPanel, DockState.Document);
                textSections.Show(dockPanel, DockState.DockLeft);
                textGroups.Show(textSections.Pane, DockAlignment.Bottom, 0.5);
            }

            //Update menus
            if (textGroups != null && textGroups.IsHidden)
            {
                MenuItem_TextGroupsForm.Checked = false;
            }
            if (textSections != null && textSections.IsHidden)
            {
                MenuItem_TextSectionsForm.Checked = false;
            }
            if (hashCodes != null && hashCodes.IsHidden)
            {
                MenuItem_HashCodesForm.Checked = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private IDockContent DeserializeDockContent(string persistString)
        {
            if (persistString == typeof(Frm_ListBoxHashCodes).ToString())
            {
                return hashCodes;
            }
            if (persistString == typeof(Frm_ListBox_TextSections).ToString())
            {
                return textSections;
            }
            if (persistString == typeof(Frm_ListBox_TextGroups).ToString())
            {
                return textGroups;
            }
            return null;
        }

        //-------------------------------------------------------------------------------------------
        //  MAINFORM
        //-------------------------------------------------------------------------------------------
        private void Frm_MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application INI
            IniFile applicationIni = new IniFile(Path.Combine(Application.StartupPath, "EuroText.ini"));
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
        private void MenuItem_NewProject_Click(object sender, EventArgs e)
        {

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

        //-------------------------------------------------------------------------------------------
        //  OPTIONS SECTION
        //-------------------------------------------------------------------------------------------
        private void Button_Output_Click(object sender, EventArgs e)
        {
            //Ensure that the last output filepath still exists
            if (Directory.Exists(GlobalVariables.CurrentProject.SpreadSheetsDirectory))
            {
                Frm_SpreadsheetExporter exporterTask = new Frm_SpreadsheetExporter(this, Path.Combine(GlobalVariables.CurrentProject.SpreadSheetsDirectory, Textbox_FileName.Text), Checkbox_FormatInfo.Checked, Checkbox_DataInfoSheet.Checked);
                exporterTask.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  BETA/TEST BUTTONS
        //-------------------------------------------------------------------------------------------
        private void ReadTable_Click(object sender, EventArgs e)
        {
            using (var stream = File.Open(@"X:\Sphinx\Grafix\Spreadsheets\SphinxText.xls", FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet();

                    DataGridView_ExcelSheet.DataSource = result.Tables[0];

                    // The result of each spreadsheet is in result.Tables
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_GetGroups_Click(object sender, EventArgs e)
        {
            if (DataGridView_ExcelSheet.Rows.Count > 0)
            {
                int rowNumber = 0;
                string groupName = string.Empty;
                HashSet<string> GroupHashCodes = new HashSet<string>();

                //Start reading control
                foreach (DataGridViewRow row in DataGridView_ExcelSheet.Rows)
                {
                    if (rowNumber > 3 && row.Cells.Count > 0)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string currentGroup = row.Cells[0].Value.ToString();

                            //Found a new group
                            if (!string.IsNullOrEmpty(currentGroup) && !currentGroup.Equals(groupName))
                            {
                                groupName = row.Cells[0].Value.ToString();
                                GroupHashCodes.Add(groupName);
                            }
                        }
                    }

                    //Increment lines count
                    rowNumber++;
                }

                File.WriteAllLines(@"C:\Users\Jordi Martinez\Desktop\EuroTextEditor\SystemFiles\Groups.txt", GroupHashCodes);

                //Inform
                MessageBox.Show(string.Join(" ", "Finished, readed", rowNumber, "lines"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_GetMessages_Click(object sender, EventArgs e)
        {
            if (DataGridView_ExcelSheet.Rows.Count > 0)
            {
                int rowNumber = 0;
                string TextGroup = string.Empty;
                ETXML_Writter filesWriter = new ETXML_Writter();

                foreach (DataGridViewRow row in DataGridView_ExcelSheet.Rows)
                {
                    if (rowNumber > 3 && row.Cells.Count > 2)
                    {
                        if (row.Cells[3].Value != null)
                        {
                            //Get text group
                            if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                            {
                                TextGroup = row.Cells[0].Value.ToString();
                            }

                            //Get Message info
                            string TextHashCode = row.Cells[3].Value.ToString();
                            if (TextHashCode.StartsWith("HT_Text_"))
                            {
                                //Get basic parameters
                                EuroText_TextFile textobj = new EuroText_TextFile
                                {
                                    Group = TextGroup,
                                    DeadText = Convert.ToInt32(row.Cells[2].Value.ToString().Equals("1")),
                                };

                                string HashCode = row.Cells[3].Value.ToString();

                                //Check if there is a char limitation
                                if (!string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                                {
                                    textobj.MaxNumOfChars = Convert.ToInt32(row.Cells[1].Value);
                                }

                                //Get text in all languages
                                for (int i = 0; i < GlobalVariables.CurrentProject.Languages.Count; i++)
                                {
                                    string languages = DataGridView_ExcelSheet.Rows[1].Cells[5 + i].Value.ToString();
                                    string languageData = row.Cells[5 + i].Value.ToString();

                                    textobj.Messages.Add(languages, languageData);
                                }

                                //Get output section
                                for (int i = 0; i < 52; i++)
                                {
                                    if (row.Cells[15 + i].Value.ToString().Equals("1"))
                                    {
                                        textobj.OutputSection = DataGridView_ExcelSheet.Rows[1].Cells[15 + i].Value.ToString();
                                    }
                                }

                                //Print EXText to text file
                                string textFilePath = Path.Combine(@"C:\Users\Jordi Martinez\Desktop\EuroTextEditor\Messages\", HashCode + ".etf");
                                filesWriter.WriteTextFile(textFilePath, textobj);
                            }
                        }
                    }

                    //Increment lines count
                    rowNumber++;
                }

                //Inform
                MessageBox.Show(string.Join(" ", "Finished, readed", rowNumber, "lines"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_GetSections_Click(object sender, EventArgs e)
        {
            if (DataGridView_ExcelSheet.Rows.Count > 0)
            {
                ETXML_Writter filesWriter = new ETXML_Writter();
                EuroText_TextSections textSectionsDemo = new EuroText_TextSections();

                bool InsideMarkerLevelStart = false;
                DataGridViewRow formatRow = DataGridView_ExcelSheet.Rows[2];
                for (int i = 0; i < formatRow.Cells.Count; i++)
                {
                    if (formatRow.Cells[i].Value.Equals("MARKER_LEVEL_END"))
                    {
                        break;
                    }
                    if (InsideMarkerLevelStart)
                    {
                        string sectionName = DataGridView_ExcelSheet.Rows[0].Cells[i].Value.ToString();
                        string sectionNum = Regex.Match(DataGridView_ExcelSheet.Rows[1].Cells[i].Value.ToString(), @"\d+").Value;
                        textSectionsDemo.TextSections.Add(sectionNum, sectionName);
                    }
                    if (formatRow.Cells[i].Value.Equals("MARKER_LEVEL_START"))
                    {
                        InsideMarkerLevelStart = true;
                    }
                }

                //Write file
                string filePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
                filesWriter.WriteTextSections(filePath, textSectionsDemo);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_TextStore_Click(object sender, EventArgs e)
        {
            if (hashCodes != null && !hashCodes.IsHidden)
            {
                List<string> filesToModify = new List<string>();
                foreach (ListViewItem Item in hashCodes.ListView_HashCodes.SelectedItems)
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
                    for (int i = 0; i < hashCodes.ListView_HashCodes.Items.Count; i++)
                    {
                        hashcodes.Enqueue(hashCodes.ListView_HashCodes.Items[i].Text.ToString());
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
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
