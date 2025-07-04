﻿using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmSpreadsheetsExtractor : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmSpreadsheetsExtractor()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
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

                        // The result of each spreadsheet is in result.Tables
                        DataGridView_ExcelSheet.DataSource = result.Tables[0];
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
                    MessageBox.Show(string.Join(" ", "Finished, readed", textGroupObj.TextGroups.Count, "text groups"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_GetMessages_Click(object sender, EventArgs e)
        {
            if (DataGridView_ExcelSheet.Rows.Count > 0 && FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                int writtedFilesCount = 0;

                TimerForm TmrForm = new TimerForm();
                void work(BackgroundWorker bw, DoWorkEventArgs f)
                {
                    Dictionary<string, int> Markers = new Dictionary<string, int>();
                    for (int i = 0; i < DataGridView_ExcelSheet.Columns.Count; i++)
                    {
                        string cellValue = DataGridView_ExcelSheet.Rows[2].Cells[i].Value.ToString();
                        if (cellValue.StartsWith("MARKER_"))
                        {
                            Markers.Add(cellValue, i);
                        }
                    }

                    int rowsToSkip = 0;
                    int index = 0;
                    string currentGroup = string.Empty;
                    ETXML_Writter filesWriter = new ETXML_Writter();

                    foreach (DataGridViewRow rowToInspect in DataGridView_ExcelSheet.Rows)
                    {
                        if (rowsToSkip > 3)
                        {
                            if (!string.IsNullOrEmpty(rowToInspect.Cells[0].Value.ToString()))
                            {
                                currentGroup = rowToInspect.Cells[0].Value.ToString();
                            }

                            //Create a text object
                            EuroText_TextFile textObj = new EuroText_TextFile
                            {
                                FirstCreated = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                                CreatedBy = GlobalVariables.EuroTextUser,
                                LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                                LastModifiedBy = GlobalVariables.EuroTextUser,
                                Group = currentGroup,
                                textFlags = int.Parse(txtOutputFlags.Tag.ToString())
                            };

                            //Convert values
                            if (Markers["MARKER_HASHCODE"] > 2)
                            {
                                string MaxNumsChar = rowToInspect.Cells[1].Value.ToString();
                                string textIsDead = rowToInspect.Cells[2].Value.ToString();
                                if (!string.IsNullOrEmpty(MaxNumsChar))
                                {
                                    textObj.MaxNumOfChars = Convert.ToInt32(MaxNumsChar);
                                }
                                if (!string.IsNullOrEmpty(textIsDead))
                                {
                                    textObj.DeadText = Convert.ToInt32(textIsDead);
                                }
                            }

                            //Get text content
                            foreach (KeyValuePair<string, int> markerObj in Markers)
                            {
                                switch (markerObj.Key)
                                {
                                    case "MARKER_HASHCODE":
                                        textObj.HashCode = rowToInspect.Cells[markerObj.Value].Value.ToString();
                                        break;
                                    case "MARKER_LANGUAGE_START":
                                        int startPosition = markerObj.Value + 1;
                                        int numOfLanguages = Markers["MARKER_LANGUAGE_END"] - (startPosition + 1);
                                        for (int i = 0; i < numOfLanguages; i++)
                                        {
                                            string languageName = DataGridView_ExcelSheet.Rows[1].Cells[startPosition + i].Value.ToString();
                                            string languageValue = rowToInspect.Cells[startPosition + i].Value.ToString();
                                            textObj.Messages.Add(languageName, languageValue);
                                        }
                                        break;
                                    case "MARKER_LEVEL_START":
                                        startPosition = markerObj.Value + 1;
                                        int numOfLevels = Markers["MARKER_LEVEL_END"] - (startPosition + 1);
                                        List<string> outputSections = new List<string>();
                                        for (int i = 0; i < numOfLevels; i++)
                                        {
                                            string value = rowToInspect.Cells[startPosition + i].Value.ToString();
                                            if (!string.IsNullOrEmpty(value))
                                            {
                                                outputSections.Add(DataGridView_ExcelSheet.Rows[1].Cells[startPosition + i].Value.ToString());
                                            }
                                        }
                                        textObj.OutputSection = outputSections.ToArray();
                                        break;
                                }
                            }

                            //Calculate file path
                            string filePath = Path.Combine(FolderBrowserDialog.SelectedPath, textObj.HashCode + ".etf");
                            if (!string.IsNullOrEmpty(textObj.HashCode))
                            {
                                if (File.Exists(filePath))
                                {
                                    MessageBox.Show(string.Join("", "Duplicated file: ", textObj.HashCode), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    filesWriter.WriteTextFile(filePath, textObj);
                                    writtedFilesCount++;
                                }
                            }

                            // Report progress
                            index++;
                            int progressPercentage = (int)((index + 1) * 100.0 / DataGridView_ExcelSheet.Rows.Count);
                            bw.ReportProgress(progressPercentage, Path.GetFileNameWithoutExtension(filePath));
                        }
                        rowsToSkip++;
                    }
                }
                TmrForm.SetWork(work);
                TmrForm.ShowDialog();

                //Inform
                MessageBox.Show(string.Join(" ", "Finished, writted", writtedFilesCount, "text files"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    //Inform
                    MessageBox.Show(string.Join(" ", "Finished, readed", textSectionsDemo.TextSections.Count, "text sections"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TxtOutputFlags_Click(object sender, EventArgs e)
        {
            int selectedFlags = int.Parse(txtOutputFlags.Tag.ToString());
            using (FrmSetCategories setCategories = new FrmSetCategories(null, selectedFlags, false))
            {
                if (setCategories.ShowDialog() == DialogResult.OK)
                {
                    txtOutputFlags.Tag = setCategories.selectedFlags;
                    txtOutputFlags.Text = CommonFunctions.GetFlagsLabels(setCategories.selectedFlags);
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
