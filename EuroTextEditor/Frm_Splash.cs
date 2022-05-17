using EuroTextEditor.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Splash : Form
    {
        private readonly Frm_MainFrame mainform;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_Splash(Frm_MainFrame mainFrame)
        {
            InitializeComponent();
            mainform = mainFrame;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_Splash_Load(object sender, EventArgs e)
        {
            Label_Version.Parent = pictureBox1;
            Label_Version.BackColor = Color.Transparent;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_Splash_Shown(object sender, EventArgs e)
        {
            //Check for ini file
            string iniFilePath = Path.Combine(Application.StartupPath, "EuroText.ini");
            if (File.Exists(iniFilePath))
            {
                //Read ini file
                IniFile euroTextIni = new IniFile(iniFilePath);
                GlobalVariables.EuroTextUser = euroTextIni.Read("UserName", "Misc");
                GlobalVariables.WorkingDirectory = euroTextIni.Read("Last_Project_Opened", "Misc");
                GlobalVariables.HashtablesAdminPath = euroTextIni.Read("HashTablesAdmin_Path", "Settings");
                mainform.Textbox_FileName.Text = euroTextIni.Read("OutputFileName", "MainForm");
                string tempVar = euroTextIni.Read("includeDataInfoSheet", "MainForm");
                if (!string.IsNullOrEmpty(tempVar))
                {
                    mainform.Checkbox_DataInfoSheet.Checked = Convert.ToBoolean(tempVar);
                }
                tempVar = euroTextIni.Read("includeFormatInfoSheet", "MainForm");
                if (!string.IsNullOrEmpty(tempVar))
                {
                    mainform.Checkbox_FormatInfo.Checked = Convert.ToBoolean(tempVar);
                }

                //Read EuroText Project file
                ETXML_Reader projectFileReader = new ETXML_Reader();
                string projectFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Project.etp");
                if (File.Exists(projectFilePath))
                {
                    //Read properties file
                    GlobalVariables.CurrentProject = projectFileReader.ReadProjectFile(projectFilePath);

                    //Update form text
                    mainform.Text = "EuroText: \"" + GlobalVariables.WorkingDirectory + "\"";

                    //Get text files
                    CommonFunctions.LoadEuroTextFiles(mainform.hashCodes.UserControl_HashCodesListView.ListView_HashCodes);
                    mainform.textGroups.ReadTextGroups();
                    mainform.textSections.LoadTextSections();
                }
                else
                {
                    MessageBox.Show(string.Join(" ", "Project Not Found", GlobalVariables.WorkingDirectory), "EuroText Load Project Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Start timer
            TimerSplash.Start();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
