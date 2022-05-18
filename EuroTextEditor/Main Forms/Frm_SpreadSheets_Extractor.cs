using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_SpreadSheets_Extractor : DockContent
    {
        public Frm_SpreadSheets_Extractor()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------
        //  BETA/TEST BUTTONS
        //-------------------------------------------------------------------------------------------
        private void Button_ReadTable_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = File.Open(OpenFileDialog.FileName, FileMode.Open, FileAccess.Read))
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
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_GetGroups_Click(object sender, EventArgs e)
        {
            if (DataGridView_ExcelSheet.Rows.Count > 0)
            {
                int rowNumber = 0;
                string groupName = string.Empty;

                EuroText_TextGroups textGroupObj = new EuroText_TextGroups();

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
                                if (!textGroupObj.TextGroups.Contains(groupName))
                                {
                                    textGroupObj.TextGroups.Add(groupName);
                                }
                            }
                        }
                    }

                    //Increment lines count
                    rowNumber++;
                }

                SaveFileDialog.InitialDirectory = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles");
                SaveFileDialog.FileName = "TextGroups";
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ETXML_Writter filesWriter = new ETXML_Writter();
                    filesWriter.WriteTextGroups(SaveFileDialog.FileName, textGroupObj);

                    //Inform
                    MessageBox.Show(string.Join(" ", "Finished, readed", rowNumber, "lines"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

                List<string> spreadSheetsLanguages = new List<string>();
                int startSection = 50;
                int endSections = 90;

                //Get the count of the levels defined in the spreadsheet
                for (int i = 0; i < DataGridView_ExcelSheet.Rows[2].Cells.Count; i++)
                {
                    if (DataGridView_ExcelSheet.Rows[2].Cells[i].Value.Equals("MARKER_LEVEL_START"))
                    {
                        startSection = i + 1;
                    }
                    if (DataGridView_ExcelSheet.Rows[2].Cells[i].Value.Equals("MARKER_LEVEL_END"))
                    {
                        endSections = i;
                    }
                }

                //Get languages
                bool readingLanguages = false;
                for (int i = 0; i < DataGridView_ExcelSheet.Rows[2].Cells.Count; i++)
                {
                    if (readingLanguages)
                    {
                        string currentLanguage = DataGridView_ExcelSheet.Rows[1].Cells[i].Value.ToString();
                        if (!string.IsNullOrEmpty(currentLanguage))
                        {
                            spreadSheetsLanguages.Add(currentLanguage);
                        }
                    }
                    if (DataGridView_ExcelSheet.Rows[2].Cells[i].Value.Equals("MARKER_LANGUAGE_START"))
                    {
                        readingLanguages = true;
                    }
                    if (DataGridView_ExcelSheet.Rows[2].Cells[i].Value.Equals("MARKER_LANGUAGE_END"))
                    {
                        break;
                    }
                }

                //Write file
                FolderBrowserDialog.SelectedPath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages");
                if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
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
                                        FirstCreated = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                                        CreatedBy = GlobalVariables.EuroTextUser,
                                        LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                                        LastModifiedBy = GlobalVariables.EuroTextUser,
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
                                    for (int i = 0; i < spreadSheetsLanguages.Count; i++)
                                    {
                                        string languages = spreadSheetsLanguages[i];
                                        string languageData = row.Cells[5 + i].Value.ToString();

                                        textobj.Messages.Add(languages, languageData);
                                    }

                                    //Get output section
                                    for (int i = 0; i < endSections - startSection; i++)
                                    {
                                        if (row.Cells[startSection + i].Value.ToString().Equals("1"))
                                        {
                                            textobj.OutputSection = DataGridView_ExcelSheet.Rows[1].Cells[15 + i].Value.ToString();
                                        }
                                    }

                                    //Print EXText to text file
                                    string textFilePath = Path.Combine(FolderBrowserDialog.SelectedPath, HashCode + ".etf");
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
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_GetSections_Click(object sender, EventArgs e)
        {
            if (DataGridView_ExcelSheet.Rows.Count > 0)
            {

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
                SaveFileDialog.InitialDirectory = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles");
                SaveFileDialog.FileName = "TextSections";
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ETXML_Writter filesWriter = new ETXML_Writter();
                    filesWriter.WriteTextSections(SaveFileDialog.FileName, textSectionsDemo);
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
