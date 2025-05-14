using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmMain
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        // Output
        //-------------------------------------------------------------------------------------------------------------------------------
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

                    TimerForm TmrForm = new TimerForm();
                    void work(BackgroundWorker bw, DoWorkEventArgs f)
                    {
                        //Inform user
                        bw.ReportProgress(0, "Waiting");

                        //Start output
                        using (FileStream fs = new FileStream(outpuSpeadSheetsFilePath, FileMode.Create, FileAccess.Write))
                        {
                            IWorkbook workbook = new HSSFWorkbook();
                            ETXML_Reader projectFileReader = new ETXML_Reader();

                            //Create or update the TextSections file
                            EuroText_TextSections sectionsFileText = new EuroText_TextSections();
                            string projectFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
                            if (File.Exists(projectFilePath))
                            {
                                sectionsFileText = projectFileReader.ReadTextSectionsFile(projectFilePath);
                            }

                            //Create sheet
                            ISheet Messages = workbook.CreateSheet("Messages");
                            CreateMessagesSheet(bw, Messages, workbook, sectionsFileText.TextSections.Values.ToArray(), sectionsFileText.TextSections.Keys.ToArray(), Checkbox_IncludeHashCodesWithNoSection.Checked);

                            if (Checkbox_FormatInfo.Checked)
                            {
                                ISheet FormatInfo = workbook.CreateSheet("Format Info");
                                CreateFormatInfoSheet(FormatInfo, workbook);
                            }

                            ISheet Config = workbook.CreateSheet("Config");
                            CreateConfigSheet(Config, workbook);

                            if (Checkbox_DataInfoSheet.Checked)
                            {
                                ISheet DataInfo = workbook.CreateSheet("Data Info");
                                CreateDataInfo(bw, DataInfo, workbook);
                            }

                            //Write file
                            workbook.Write(fs);
                            workbook.Close();
                        }
                    }
                    TmrForm.SetWork(work);
                    TmrForm.ShowDialog();
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
    }
}
