using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmSplash : Form
    {
        private readonly FrmMain mainform;

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmSplash(FrmMain mainFrame)
        {
            InitializeComponent();
            mainform = mainFrame;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmSplash_Load(object sender, EventArgs e)
        {
            Label_Version.Parent = pictureBox1;
            Label_Version.BackColor = Color.Transparent;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmSplash_Shown(object sender, EventArgs e)
        {
            //Check for ini file
            if (File.Exists(GlobalVariables.EuroTextIni))
            {
                //Read ini file
                IniFile euroTextIni = new IniFile(GlobalVariables.EuroTextIni);
                GlobalVariables.EuroTextUser = euroTextIni.Read("UserName", "Misc");
                GlobalVariables.WorkingDirectory = euroTextIni.Read("Last_Project_Opened", "Misc");
                GlobalVariables.HashtablesAdminPath = euroTextIni.Read("HashTablesAdmin_Path", "Settings");
                mainform.Textbox_FileName.Text = euroTextIni.Read("OutputFileName", "MainForm");

                if (bool.TryParse(euroTextIni.Read("includeDataInfoSheet", "MainForm").Trim(), out bool checkStatus))
                {
                    mainform.Checkbox_DataInfoSheet.Checked = checkStatus;
                }
                if (bool.TryParse(euroTextIni.Read("includeFormatInfoSheet", "MainForm").Trim(), out checkStatus))
                {
                    mainform.Checkbox_FormatInfo.Checked = checkStatus;
                }
                if (bool.TryParse(euroTextIni.Read("includeNoSectionedHashCodes", "MainForm").Trim(), out checkStatus))
                {
                    mainform.Checkbox_IncludeHashCodesWithNoSection.Checked = checkStatus;
                }

                //Ask for userName if required
                if (string.IsNullOrEmpty(GlobalVariables.EuroTextUser))
                {
                    GlobalVariables.EuroTextUser = CommonFunctions.AskForUserName("MyName");
                }

                //Read EuroText Project file
                ETXML_Reader projectFileReader = new ETXML_Reader();
                string projectFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Project.etp");
                if (File.Exists(projectFilePath))
                {
                    //Read properties file
                    GlobalVariables.CurrentProject = projectFileReader.ReadProjectFile(projectFilePath);

                    //Update form text
                    mainform.Text = string.Format("EuroText2: \"{0}\"", GlobalVariables.WorkingDirectory);

                    mainform.ReadTextGroups();
                }
                else
                {
                    MessageBox.Show(string.Join(" ", "Project Not Found", GlobalVariables.WorkingDirectory), "EuroText Load Project Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Get recent files
                mainform.RecentFilesMenu = new MruStripMenuInline(mainform.MenuItemProject_RecentProjects, mainform.recentFilesToolStripMenuItem, new MostRecentFilesMenu.ClickedHandler(mainform.MenuItemFile_Recent_Click), GlobalVariables.EuroTextIni, 5);
                mainform.RecentFilesMenu.LoadFromIniFile();
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
