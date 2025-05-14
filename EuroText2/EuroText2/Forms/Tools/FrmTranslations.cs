using ExcelDataReader;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmTranslations : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmTranslations()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmTranslations_Load(object sender, EventArgs e)
        {
            var languagesArray = GlobalVariables.CurrentProject.Languages.ToArray();
            //Add all languages
            cbxExportBaseLanguage.BeginUpdate();
            cbxExportBaseLanguage.Items.AddRange(languagesArray);
            if (languagesArray.Length > 0)
            {
                cbxExportBaseLanguage.SelectedIndex = 0;
            }
            cbxExportBaseLanguage.EndUpdate();

            cbxExportLanguageTranslation.BeginUpdate();
            cbxExportLanguageTranslation.Items.AddRange(languagesArray);
            if (languagesArray.Length > 0)
            {
                cbxExportLanguageTranslation.SelectedIndex = 0;
            }
            cbxExportLanguageTranslation.EndUpdate();

            //Add all groups
            string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextGroups.etf");
            if (File.Exists(textGroupsFilePath))
            {
                ETXML_Reader projectFileReader = new ETXML_Reader();
                EuroText_TextGroups textGroupsData = projectFileReader.ReadTextGroupsFile(textGroupsFilePath);

                chkExportGroups.BeginUpdate();
                chkExportGroups.Items.Clear();
                chkExportGroups.Items.AddRange(textGroupsData.TextGroups.ToArray());
                chkExportGroups.EndUpdate();
            }
            MenuItemExportGroupsCheckAll_Click(sender, e);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnExportFilePath_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtExportFilePath.Text = saveFileDialog1.FileName;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Context Menu Groups
        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemExportGroupsCheckAll_Click(object sender, EventArgs e)
        {
            CommonFunctions.CheckListCheckAll(chkExportGroups);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemExportGroupsInvert_Click(object sender, EventArgs e)
        {
            CommonFunctions.CheckListInvertSelection(chkExportGroups);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemExportGroupsUnCheckAll_Click(object sender, EventArgs e)
        {
            CommonFunctions.CheckListUncheckAll(chkExportGroups);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TxtExportFlags_Click(object sender, EventArgs e)
        {
            int selectedFlags = int.Parse(txtExportFlags.Tag.ToString());
            using (FrmSetCategories setCategories = new FrmSetCategories(null, selectedFlags, false))
            {
                if (setCategories.ShowDialog() == DialogResult.OK)
                {
                    txtExportFlags.Tag = setCategories.selectedFlags;
                    txtExportFlags.Text = CommonFunctions.GetFlagsLabels(setCategories.selectedFlags);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnRun_Click(object sender, EventArgs e)
        {
            if (cbxExportBaseLanguage.SelectedItem != null && cbxExportLanguageTranslation.SelectedItem != null)
            {
                int stringsToTranslate = 0;

                TimerForm TmrForm = new TimerForm();
                void work(BackgroundWorker bw, DoWorkEventArgs f)
                {
                    //Get languages
                    string BaseLanguage = string.Empty;
                    cbxExportBaseLanguage.Invoke((MethodInvoker)delegate
                    {
                        BaseLanguage = cbxExportBaseLanguage.SelectedItem.ToString();
                    });

                    string TranslationLanguage = string.Empty;
                    cbxExportLanguageTranslation.Invoke((MethodInvoker)delegate
                    {
                        TranslationLanguage = cbxExportLanguageTranslation.SelectedItem.ToString();
                    });

                    // Crear libro y hoja
                    IWorkbook workbook = new HSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet(TranslationLanguage);

                    // Estilo para ajustar texto en columna 1
                    ICellStyle wrapTextStyle = workbook.CreateCellStyle();
                    wrapTextStyle.WrapText = true;

                    // Estilo de encabezado en negrita
                    ICellStyle headerStyle = workbook.CreateCellStyle();
                    IFont boldFont = workbook.CreateFont();
                    boldFont.IsBold = true;
                    headerStyle.SetFont(boldFont);

                    // Crear encabezado
                    IRow headerRow = sheet.CreateRow(0);
                    headerRow.CreateCell(0).SetCellValue("Hashcode");
                    headerRow.GetCell(0).CellStyle = headerStyle;

                    headerRow.CreateCell(1).SetCellValue(BaseLanguage);
                    headerRow.GetCell(1).CellStyle = headerStyle;

                    headerRow.CreateCell(2).SetCellValue(TranslationLanguage);
                    headerRow.GetCell(2).CellStyle = headerStyle;

                    // Obtener archivos
                    ETXML_Reader readerMethods = new ETXML_Reader();
                    string textFilesDirectory = Path.Combine(GlobalVariables.WorkingDirectory, "Messages");
                    string[] dialogsTexts = Directory.GetFiles(textFilesDirectory, "*.etf", SearchOption.AllDirectories);
                    Array.Sort(dialogsTexts);

                    int rowIndex = 1;
                    for (int i = 0; i < dialogsTexts.Length; i++)
                    {
                        bool addItem = true;
                        EuroText_TextFile objTextData = readerMethods.ReadTextFile(dialogsTexts[i]);

                        // check flags
                        int flags = int.Parse(txtExportFlags.Tag.ToString());
                        if (flags > 0)
                        {
                            for (int flagBit = 0; flagBit < 16; flagBit++)
                            {
                                if (Convert.ToBoolean((flags >> flagBit) & 1) && !Convert.ToBoolean((objTextData.textFlags >> flagBit) & 1))
                                {
                                    addItem = false;
                                }
                            }
                        }

                        //Exclude texts with flag unused
                        if (chkExcludeUnused.Checked)
                        {
                            if (CommonFunctions.GetFlag((uint)objTextData.textFlags, (byte)(GlobalVariables.CurrentProject.UnusedTextBit - 1)))
                            {
                                addItem = false;
                            }
                        }

                        // write data
                        if (addItem && IsGroupChecked(objTextData.Group))
                        {
                            IRow row = sheet.CreateRow(rowIndex);

                            ICell cell0 = row.CreateCell(0);
                            cell0.SetCellValue(Path.GetFileNameWithoutExtension(dialogsTexts[i]));

                            ICell cell1 = row.CreateCell(1);
                            cell1.SetCellValue(objTextData.Messages[BaseLanguage]);
                            cell1.CellStyle = wrapTextStyle;

                            ICell cell2 = row.CreateCell(2);
                            if (chkAddStrings.Checked)
                            {
                                cell2.SetCellValue(objTextData.Messages[TranslationLanguage]);
                            }
                            else
                            {
                                cell2.SetCellValue(string.Empty);
                            }

                            rowIndex++;
                            stringsToTranslate++;
                        }

                        // Report progress
                        int progressPercentage = (int)((i + 1) * 100.0 / dialogsTexts.Length);
                        bw.ReportProgress(progressPercentage, Path.GetFileNameWithoutExtension(dialogsTexts[i]));
                    }

                    // Set width
                    sheet.AutoSizeColumn(0); // Hashcode
                    sheet.SetColumnWidth(1, PixelsToExcelWidth(450)); // BaseLanguage
                    sheet.SetColumnWidth(2, PixelsToExcelWidth(450)); // Translation

                    // save file
                    using (FileStream fs = new FileStream(txtExportFilePath.Text, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(fs);
                    }

                    workbook.Close();
                }
                TmrForm.SetWork(work);
                TmrForm.ShowDialog();

                MessageBox.Show(string.Join(" ", stringsToTranslate, "strings has been writted for translating."), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private int PixelsToExcelWidth(int WidthPixels)
        {
            int columnWidthPixels = WidthPixels;
            int columnWidthUnits = (int)((columnWidthPixels - 5) / 7.0 * 256);

            return columnWidthUnits;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private bool IsGroupChecked(string text)
        {
            foreach (var checkedItem in chkExportGroups.CheckedItems)
            {
                if (checkedItem.ToString() == text)
                {
                    return true;
                }
            }
            return false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Import Translation
        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnImportFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImportFile.Text = openFileDialog1.FileName;

                //Display sheet
                using (FileStream stream = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    // Auto-detect format, supports:
                    //  - Binary Excel files (2.0-2003 format; *.xls)
                    //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var conf = new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true // <- esto usa la primera fila como encabezados
                            }
                        };

                        DataSet result = reader.AsDataSet(conf);
                        DataGridView_ExcelSheet.DataSource = result.Tables[0];
                    }

                    //Show settings
                    txtBaseLanguage.Text = DataGridView_ExcelSheet.Columns[1].HeaderText;
                    txtTranslationLanguage.Text = DataGridView_ExcelSheet.Columns[2].HeaderText;
                    txtHashcodesCount.Text = DataGridView_ExcelSheet.Rows.Count.ToString();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TxtSetOffFlags_Click(object sender, EventArgs e)
        {
            int selectedFlags = int.Parse(txtSetOffFlags.Tag.ToString());
            using (FrmSetCategories setCategories = new FrmSetCategories(null, selectedFlags, false))
            {
                if (setCategories.ShowDialog() == DialogResult.OK)
                {
                    txtSetOffFlags.Tag = setCategories.selectedFlags;
                    txtSetOffFlags.Text = CommonFunctions.GetFlagsLabels(setCategories.selectedFlags);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnImport_Click(object sender, EventArgs e)
        {
            string TranslationLanguage = txtTranslationLanguage.Text;
            int NewFlags = int.Parse(txtSetOffFlags.Tag.ToString());

            int ModifiedFiles = 0;
            int StringsToUpdate = DataGridView_ExcelSheet.Rows.Count;
            if (StringsToUpdate > 0)
            {
                TimerForm TmrForm = new TimerForm();
                void work(BackgroundWorker bw, DoWorkEventArgs f)
                {
                    ETXML_Reader xmlReaderFile = new ETXML_Reader();
                    ETXML_Writter xmlWritterFile = new ETXML_Writter();

                    for (int i = 0; i < StringsToUpdate; i++)
                    {
                        string fileHashCode = DataGridView_ExcelSheet.Rows[i].Cells[0].Value.ToString();
                        string textToUpdate = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", fileHashCode + ".etf");

                        if (File.Exists(textToUpdate))
                        {
                            //Update message
                            EuroText_TextFile textObjData = xmlReaderFile.ReadTextFile(textToUpdate);
                            if (textObjData.Messages.ContainsKey(TranslationLanguage))
                            {
                                bool RewriteFile = false;

                                string translatedMessage = DataGridView_ExcelSheet.Rows[i].Cells[2].Value.ToString();
                                if (!translatedMessage.Equals(textObjData.Messages[TranslationLanguage]))
                                {
                                    textObjData.Messages[TranslationLanguage] = translatedMessage;
                                    RewriteFile = true;
                                }

                                //Write file again if string is different
                                if (RewriteFile)
                                {
                                    //Update flags
                                    if (NewFlags > 0)
                                    {
                                        for (int j = 0; j < 16; j++)
                                        {
                                            if (((NewFlags >> j) & 1) == 1)
                                            {
                                                //Set bit off
                                                textObjData.textFlags &= ~(1 << j);
                                            }
                                        }
                                    }

                                    //Save file
                                    xmlWritterFile.WriteTextFile(textToUpdate, textObjData);
                                    ModifiedFiles++;
                                }
                            }

                            // Report progress
                            int progressPercentage = (int)((i + 1) * 100.0 / StringsToUpdate);
                            bw.ReportProgress(progressPercentage, Path.GetFileNameWithoutExtension(textToUpdate));
                        }
                    }
                }
                TmrForm.SetWork(work);
                TmrForm.ShowDialog();

                MessageBox.Show(string.Join(" ", ModifiedFiles, "strings updated successfully."), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
