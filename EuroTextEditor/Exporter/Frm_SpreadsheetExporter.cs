using EuroTextEditor.Classes;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_SpreadsheetExporter : Frm_Exporter
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        private readonly string outputFilePath;
        private readonly bool includeFormatInfoSheet;
        private readonly bool includeInfoSheet;
        private readonly bool includeHashCodesNoSection;
        private readonly Form parentMainFrame;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_SpreadsheetExporter(Frm_MainFrame parentForm, string outputFile, bool IncludeFormatInfo, bool includeInfo, bool IncludeHashCodesNoSection)
        {
            InitializeComponent();
            outputFilePath = outputFile;
            includeFormatInfoSheet = IncludeFormatInfo;
            includeInfoSheet = includeInfo;
            parentMainFrame = parentForm;
            includeHashCodesNoSection = IncludeHashCodesNoSection;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_Exporter_Shown(object sender, EventArgs e)
        {
            //Hide parent
            parentMainFrame.Hide();

            //Start output
            if (!BackgroundWorker.IsBusy)
            {
                BackgroundWorker.RunWorkerAsync();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Inform user
            BackgroundWorker.ReportProgress(0, "Waiting");

            //Start output
            using (FileStream fs = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
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
                CreateMessagesSheet(Messages, workbook, sectionsFileText.TextSections.Values.ToArray(), sectionsFileText.TextSections.Keys.ToArray(), includeHashCodesNoSection);

                if (includeFormatInfoSheet)
                {
                    ISheet FormatInfo = workbook.CreateSheet("Format Info");
                    CreateFormatInfoSheet(FormatInfo, workbook);
                }

                ISheet Config = workbook.CreateSheet("Config");
                CreateConfigSheet(Config, workbook);

                if (includeInfoSheet)
                {
                    ISheet DataInfo = workbook.CreateSheet("Data Info");
                    CreateDataInfo(DataInfo, workbook);
                }

                //Write file
                workbook.Write(fs);
                workbook.Close();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Text = e.UserState.ToString();
            ProgressBar_Status.Value = e.ProgressPercentage;
            if (!IsDisposed && Environment.OSVersion.Version >= new Version(6, 1))
            {
                TaskbarProgress.SetValue(Handle, e.ProgressPercentage, ProgressBar_Status.Maximum);
                TaskbarProgress.SetState(Handle, TaskbarProgress.TaskbarStates.Normal);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Remove output file
            if (e.Cancelled)
            {
                if (File.Exists(outputFilePath))
                {
                    File.Delete(outputFilePath);
                }
            }

            //Show parent
            parentMainFrame.Show();
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_Exporter_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If outputting cancel 
            if (BackgroundWorker.IsBusy)
            {
                e.Cancel = true;
                DialogResult response = MessageBox.Show("Are you sure you want to cancel the output?", "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    BackgroundWorker.CancelAsync();
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
