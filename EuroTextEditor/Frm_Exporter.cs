using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Exporter : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        private readonly string outputFilePath;
        private readonly bool includeFormatInfoSheet;
        private readonly bool includeInfoSheet;
        private readonly Form parentMainFrame;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_Exporter(Frm_MainFrame parentForm, string outputFile, bool IncludeFormatInfo, bool includeInfo)
        {
            InitializeComponent();
            outputFilePath = outputFile;
            includeFormatInfoSheet = IncludeFormatInfo;
            includeInfoSheet = includeInfo;
            parentMainFrame = parentForm;
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
                ExcelWritters writters = new ExcelWritters();

                //Output groups and levels
                string[] outLevels = File.ReadAllLines(@"C: \Users\Jordi Martinez\Desktop\EuroTextEditor\SystemFiles\OutputLevels.txt");
                string[] textGroup = File.ReadAllLines(@"C: \Users\Jordi Martinez\Desktop\EuroTextEditor\SystemFiles\Groups.txt");
                string[] textSection = File.ReadAllLines(@"C: \Users\Jordi Martinez\Desktop\EuroTextEditor\SystemFiles\TextSections.txt");

                //Create sheet
                ISheet Messages = workbook.CreateSheet("Messages");
                writters.CreateMessagesSheet(Messages, workbook, outLevels, textGroup, textSection, e, BackgroundWorker);

                if (includeFormatInfoSheet)
                {
                    ISheet FormatInfo = workbook.CreateSheet("Format Info");
                    writters.CreateFormatInfoSheet(FormatInfo, workbook, e, BackgroundWorker);
                }

                ISheet Config = workbook.CreateSheet("Config");
                writters.CreateConfigSheet(Config, workbook);

                if (includeInfoSheet)
                {
                    ISheet DataInfo = workbook.CreateSheet("Data Info");
                    writters.CreateDataInfo(DataInfo, workbook, e, BackgroundWorker);
                }

                //Write file
                workbook.Write(fs);
                workbook.Close();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar_Status.Value = e.ProgressPercentage;
            Text = e.UserState.ToString();
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
