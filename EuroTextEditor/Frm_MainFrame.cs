using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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
        //  MENU ITEM - FILE
        //-------------------------------------------------------------------------------------------
        private void MenuItem_OpenProject_Click(object sender, EventArgs e)
        {

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
        //  MENU ITEM - SETTINGS
        //-------------------------------------------------------------------------------------------
        private void MenuItem_SetHashCodesDir_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                GlobalVariables.HashtablesFilePath = OpenFileDialog.FileName;
            }
        }

        //-------------------------------------------------------------------------------------------
        //  LISTBOX HASHCODES
        //-------------------------------------------------------------------------------------------
        private void ListBox_HashCodes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListBox_HashCodes.SelectedItems.Count == 1)
            {
                string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", ListBox_HashCodes.SelectedItem.ToString() + ".txt");
                if (!File.Exists(textFilePath))
                {
                    DialogResult answer = MessageBox.Show(string.Join(" ", "", "Source file not found:", textFilePath, "\n\nDo you want to create it now?"), "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        //Create object
                        EXText newTextFile = new EXText();

                        //Write Object
                        EXText_Writer filesWriter = new EXText_Writer();
                        filesWriter.EXTextObjectToTextFile(newTextFile, textFilePath);
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
            if (File.Exists(GlobalVariables.HashtablesFilePath))
            {
                //Get hashcodes
                string hashTableSection = "HT_Text_";
                HashSet<string> AvailableHashCodes = CommonFunctions.ReadHashTableSection(GlobalVariables.HashtablesFilePath, hashTableSection);

                //Update control
                ListBox_HashCodes.BeginUpdate();
                ListBox_HashCodes.Items.Clear();
                ListBox_HashCodes.Items.AddRange(AvailableHashCodes.ToArray());
                ListBox_HashCodes.EndUpdate();

                //Update label
                Label_TotalHashCodes.Text = "Total: " + ListBox_HashCodes.Items.Count;
            }
            else
            {
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    string filePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", ListBox_HashCodes.Items[i].ToString() + ".txt");
                    if (File.Exists(filePath))
                    {
                        //Read object
                        EXText_Reader filesReader = new EXText_Reader();
                        EXText objText = filesReader.ReadEXTextFile(filePath);

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

        }

        //-------------------------------------------------------------------------------------------
        //  OPTIONS SECTION
        //-------------------------------------------------------------------------------------------
        private void Button_Output_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Frm_Exporter exporterTask = new Frm_Exporter(this, SaveFileDialog.FileName, Checkbox_FormatInfo.Checked, Checkbox_DataInfoSheet.Checked);
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
                string[] Languages = new string[] { "English US", "English UK", "German", "French", "Spanish", "Italian", "Korean", "Japan" };
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
                                EXText textobj = new EXText
                                {
                                    Group = TextGroup,
                                    DeadText = Convert.ToInt32(row.Cells[2].Value.ToString().Equals("1")),
                                    HashCode = row.Cells[3].Value.ToString()
                                };

                                //Check if there is a char limitation
                                if (!string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                                {
                                    textobj.MaxNumOfChars = Convert.ToInt32(row.Cells[1].Value);
                                }

                                //Get text in all languages
                                for (int i = 0; i < textobj.TextLanguage.Length; i++)
                                {
                                    textobj.TextLanguage[i] = row.Cells[5 + i].Value.ToString();
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
                                string textFilePath = Path.Combine(@"C:\Users\Jordi Martinez\Desktop\EuroTextEditor\Messages\", textobj.HashCode.Trim() + ".txt");
                                using (StreamWriter sw = File.CreateText(textFilePath))
                                {
                                    sw.WriteLine("#Parameters");
                                    if (textobj.MaxNumOfChars > 0)
                                    {
                                        sw.WriteLine("MaxNumOfChars " + textobj.MaxNumOfChars);
                                    }
                                    if (textobj.DeadText > 0)
                                    {
                                        sw.WriteLine("DeadText " + textobj.DeadText);
                                    }
                                    sw.WriteLine("Group " + textobj.Group);
                                    sw.WriteLine("OutputSection " + textobj.OutputSection);
                                    sw.WriteLine("#END");
                                    sw.WriteLine(string.Empty);
                                    for (int i = 0; i < textobj.TextLanguage.Length; i++)
                                    {
                                        if (textobj.TextLanguage[i].Length > 0)
                                        {
                                            sw.WriteLine("#" + Languages[i]);
                                            sw.WriteLine(textobj.TextLanguage[i]);
                                            sw.WriteLine("#END");
                                            sw.WriteLine(string.Empty);
                                        }
                                    }
                                }
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

    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
