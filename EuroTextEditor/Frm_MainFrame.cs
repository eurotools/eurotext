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

        //-------------------------------------------------------------------------------------------------------------------------------
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

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_MainFrame_Load(object sender, EventArgs e)
        {
            //Get Text Sections and levels
            string[] textSections = File.ReadAllLines(@"C: \Users\Jordi Martinez\Desktop\EuroTextEditor\SystemFiles\TextSections.txt");
            string[] outLevels = File.ReadAllLines(@"C: \Users\Jordi Martinez\Desktop\EuroTextEditor\SystemFiles\OutputLevels.txt");

            //Add text sections
            for (int i = 0; i < textSections.Length; i++)
            {
                ListView_SectionsAndLevels.Items.Add(textSections[i]);
            }

            //Add levels
            for (int i = 0; i < outLevels.Length; i++)
            {
                if (i < ListView_SectionsAndLevels.Items.Count)
                {
                    ListView_SectionsAndLevels.Items[i].SubItems.Add(outLevels[i]);
                }
            }

            //Get all groups
            string[] textGroup = File.ReadAllLines(@"C: \Users\Jordi Martinez\Desktop\EuroTextEditor\SystemFiles\Groups.txt");
            ListBox_TextGroups.BeginUpdate();
            ListBox_TextGroups.Items.AddRange(textGroup);
            ListBox_TextGroups.EndUpdate();
            Label_Total_Groups.Text = "Total: " + ListBox_TextGroups.Items.Count;

            //Get all text files
            string[] filesToCheck = Directory.GetFiles(@"C:\Users\Jordi Martinez\Desktop\EuroTextEditor\Messages", "*.txt", SearchOption.TopDirectoryOnly);
            ListBox_HashCodes.BeginUpdate();
            for (int i = 0; i < filesToCheck.Length; i++)
            {
                ListBox_HashCodes.Items.Add(Path.GetFileNameWithoutExtension(filesToCheck[i]));
            }
            ListBox_HashCodes.EndUpdate();
            Label_TotalHashCodes.Text = "Total: " + ListBox_HashCodes.Items.Count;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ListBox_HashCodes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListBox_HashCodes.SelectedItems.Count == 1)
            {
                string textFilePath = Path.Combine(@"C:\Users\Jordi Martinez\Desktop\EuroTextEditor\Messages", ListBox_HashCodes.SelectedItem.ToString() + ".txt");
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
        private void Button_Output_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Frm_Exporter exporterTask = new Frm_Exporter(this, SaveFileDialog.FileName, Checkbox_FormatInfo.Checked, Checkbox_DataInfoSheet.Checked);
                exporterTask.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_SetHashCodesDir_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                GlobalVariables.HashtablesFilePath = OpenFileDialog.FileName;
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
    }
}
