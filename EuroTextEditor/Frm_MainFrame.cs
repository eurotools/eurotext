using EuroTextEditor.Classes;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_MainFrame : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_MainFrame()
        {
            InitializeComponent();
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
        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-------------------------------------------------------------------------------------------
        //  LISTBOX HASHCODES
        //-------------------------------------------------------------------------------------------
        private void ListBox_HashCodes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListBox_HashCodes.SelectedItems.Count == 1)
            {
                string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", ListBox_HashCodes.SelectedItem.ToString() + ".etf");
                if (!File.Exists(textFilePath))
                {
                    DialogResult answer = MessageBox.Show(string.Join(" ", "", "Source file not found:", textFilePath, "\n\nDo you want to create it now?"), "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        //Create object
                        EuroText_TextFile newTextFile = new EuroText_TextFile();

                        //Write Object
                        ETXML_Writter filesWriter = new ETXML_Writter();
                        filesWriter.WriteTextFile(textFilePath, newTextFile);
                    }
                }

                //Show form
                if (File.Exists(textFilePath))
                {
                    Frm_TextEditor textEditor = new Frm_TextEditor(textFilePath)
                    {
                        Text = ListBox_HashCodes.SelectedItem.ToString()
                    };
                    textEditor.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_UpdateHashCodes_Click(object sender, EventArgs e)
        {
            //Get text files
            string[] filesToAdd = Directory.GetFiles(Path.Combine(GlobalVariables.WorkingDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly).Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();

            //Update control
            ListBox_HashCodes.BeginUpdate();
            ListBox_HashCodes.Items.Clear();
            ListBox_HashCodes.Items.AddRange(filesToAdd);
            ListBox_HashCodes.EndUpdate();
            listCollection = filesToAdd;

            //Update label
            Label_TotalHashCodes.Text = "Total: " + ListBox_HashCodes.Items.Count;
        }

        //-------------------------------------------------------------------------------------------
        //  LISTBOX TEXTGROUPS
        //-------------------------------------------------------------------------------------------
        private void ListBox_TextGroups_DoubleClick(object sender, EventArgs e)
        {
            if (ListBox_TextGroups.SelectedItems.Count == 1)
            {
                HashSet<string> hashCodesInThisGroup = new HashSet<string>();
                string groupToSearch = ListBox_TextGroups.SelectedItem.ToString();

                //Search hashcodes that are in this group
                for (int i = 0; i < ListBox_HashCodes.Items.Count; i++)
                {
                    //Get message text and ensure that the source file exists
                    string filePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", ListBox_HashCodes.Items[i].ToString() + ".etf");
                    if (File.Exists(filePath))
                    {
                        //Read object
                        ETXML_Reader filesReader = new ETXML_Reader();
                        EuroText_TextFile objText = filesReader.ReadTextFile(filePath);

                        //Add items
                        if (objText.Group.Equals(groupToSearch))
                        {
                            hashCodesInThisGroup.Add(ListBox_HashCodes.Items[i].ToString());
                        }
                    }
                }

                //Show form
                Frm_GroupsViewer groupsViewer = new Frm_GroupsViewer(hashCodesInThisGroup.ToArray())
                {
                    Text = groupToSearch
                };
                groupsViewer.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_CreateNewGroup_Click(object sender, EventArgs e)
        {
            using (Frm_InputBox newGroupForm = new Frm_InputBox("Create New", "Enter Name", ""))
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
                    if (!ListBox_TextGroups.Items.Contains(newGroupName))
                    {
                        ListBox_TextGroups.Items.Add(newGroupName);

                        //Get text file path
                        string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "Groups.txt");
                        if (File.Exists(textGroupsFilePath))
                        {
                            //Update txt
                            string[] clist = ListBox_TextGroups.Items.OfType<string>().ToArray();
                            File.WriteAllLines(textGroupsFilePath, clist);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The new group could not be added, a group with the same name already exists.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                Frm_SpreadsheetExporter exporterTask = new Frm_SpreadsheetExporter(this, GlobalVariables.CurrentProject.SpreadSheetsDirectory, Checkbox_FormatInfo.Checked, Checkbox_DataInfoSheet.Checked);
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
                        int sectionNum = Convert.ToInt32(Regex.Match(DataGridView_ExcelSheet.Rows[1].Cells[i].Value.ToString(), @"\d+").Value);
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
        internal string[] listCollection;
        private void Textbox_SearchBarHashCodes_TextChanged(object sender, EventArgs e)
        {
            //Update control
            ListBox_HashCodes.BeginUpdate();
            ListBox_HashCodes.Items.Clear();
            if (string.IsNullOrEmpty(Textbox_SearchBarHashCodes.Text.Trim()))
            {
                ListBox_HashCodes.Items.AddRange(listCollection.ToArray());
            }
            else
            {
                for (int i = 0; i < listCollection.Length; i++)
                {
                    if (listCollection[i].IndexOf(Textbox_SearchBarHashCodes.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        ListBox_HashCodes.Items.Add(listCollection[i]);
                    }
                }

            }
            ListBox_HashCodes.EndUpdate();

            //Update label
            Label_TotalHashCodes.Text = "Total: " + ListBox_HashCodes.Items.Count;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_SetGroup_Click(object sender, EventArgs e)
        {
            string[] availableGroups = ListBox_TextGroups.Items.OfType<string>().ToArray();

            //Show form
            Frm_SetTextGroup setGroup = new Frm_SetTextGroup(availableGroups);
            if (setGroup.ShowDialog() == DialogResult.OK)
            {
                //Get the group that use user has selected
                string selectedGroup = setGroup.selectedTextGroup;

                //Call reader lib
                ETXML_Reader filesReader = new ETXML_Reader();
                ETXML_Writter filesWriter = new ETXML_Writter();

                //Update all text files
                foreach (string selectedItem in ListBox_HashCodes.SelectedItems)
                {
                    string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", selectedItem + ".etf");
                    if (File.Exists(textFilePath))
                    {
                        //Update property
                        EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);
                        textObjectData.Group = selectedGroup;

                        //Write file again
                        filesWriter.WriteTextFile(textFilePath, textObjectData);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_TextStore_Click(object sender, EventArgs e)
        {
            string[] selectedFiles = ListBox_HashCodes.SelectedItems.OfType<string>().ToArray();

            Frm_TextStore storeText = new Frm_TextStore(selectedFiles);
            storeText.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_ExportHashCodes_Click(object sender, EventArgs e)
        {
            if (File.Exists(GlobalVariables.HashtablesAdminPath))
            {
                Queue<string> hashcodes = new Queue<string>();
                for (int i = 0; i < ListBox_HashCodes.Items.Count; i++)
                {
                    hashcodes.Enqueue(ListBox_HashCodes.Items[i].ToString());
                }

                while (hashcodes.Count > 0)
                {
                    string commandLine = "/A HT_Text";
                    for(int i = 0; i < 600; i++)
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

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_ProjectSettings_Click(object sender, EventArgs e)
        {
            Frm_ProjectForm projectSettings = new Frm_ProjectForm();
            projectSettings.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_CreateSection_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h")))
            {
                //Open selector
                Frm_HashCodesSelector selector = new Frm_HashCodesSelector("HT_File", true)
                {
                    Text = "Add New Text Section"
                };
                if (selector.ShowDialog() == DialogResult.OK)
                {
                    //Check if item exists
                    bool canAddNewSection = true;
                    foreach (ListViewItem itemToCheck in ListView_SectionsAndLevels.Items)
                    {
                        string levelName = itemToCheck.SubItems[1].Text;
                        if (levelName.Equals(selector.SelectedHashCode))
                        {
                            canAddNewSection = false;
                            break;
                        }
                    }

                    //Add item
                    if (canAddNewSection)
                    {
                        //Update control
                        GlobalVariables.CurrentProject.TextSectionsID++;
                        ListView_SectionsAndLevels.Items.Add(new ListViewItem(new[] { GlobalVariables.CurrentProject.TextSectionsID.ToString("00"), selector.SelectedHashCode }));

                        //Create or update the TextSections file
                        EuroText_TextSections sectionsFileText = new EuroText_TextSections();
                        string projectFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
                        if (File.Exists(projectFilePath))
                        {
                            ETXML_Reader projectFileReader = new ETXML_Reader();
                            sectionsFileText = projectFileReader.ReadTextSectionsFile(projectFilePath);
                        }

                        //Update dictionary and write file
                        foreach (ListViewItem itemToCheck in ListView_SectionsAndLevels.Items)
                        {
                            int sectionNum = Convert.ToInt32(itemToCheck.Text);
                            string levelName = itemToCheck.SubItems[1].Text;

                            if (!sectionsFileText.TextSections.ContainsKey(sectionNum))
                            {
                                sectionsFileText.TextSections.Add(sectionNum, levelName);
                            }
                        }

                        //Write file again
                        ETXML_Writter filesWriter = new ETXML_Writter();
                        filesWriter.WriteTextSections(projectFilePath, sectionsFileText);
                    }
                    else
                    {
                        MessageBox.Show("The selected section could not be added, a section with this level already exists.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_New_Click(object sender, EventArgs e)
        {
            Frm_InputBox newTextFile = new Frm_InputBox("Create New", "Enter Name", "");
            if (newTextFile.ShowDialog() == DialogResult.OK)
            {
                Match match = Regex.Match(newTextFile.ReturnValue, @"^[a-zA-Z0-9_]*$");
                if (match.Success)
                {

                }
                else
                {
                    MessageBox.Show("Label '" + newTextFile.ReturnValue + "' uses invalid characters, only numbers, digits and underscore characters are allowed.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
