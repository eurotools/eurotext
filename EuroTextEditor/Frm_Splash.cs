using EuroTextEditor.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

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
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
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
                    mainform.Text = string.Format("EuroText: \"{0}\"", GlobalVariables.WorkingDirectory);

                    //Load content
                    mainform.textGroups.ReadTextGroups();
                    mainform.textSections.LoadTextSections();
                    mainform.hashCodes.UserControl_HashCodesListView.LoadEuroTextFiles();
                }
                else
                {
                    MessageBox.Show(string.Join(" ", "Project Not Found", GlobalVariables.WorkingDirectory), "EuroText Load Project Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //Get recent files
            mainform.RecentFilesMenu = new MruStripMenuInline(mainform.MenuItemStrip_RecentProjects, mainform.recentFilesToolStripMenuItem, new MostRecentFilesMenu.ClickedHandler(mainform.MenuItemFile_Recent_Click), GlobalVariables.EuroTextIni, 5);
            mainform.RecentFilesMenu.LoadFromIniFile();

            //Add forms to the list
            mainform.m_DockForms.Add(mainform.textSections);
            mainform.m_DockForms.Add(mainform.textGroups);
            mainform.m_DockForms.Add(mainform.hashCodes);
            mainform.m_DockForms.Add(mainform.xlsExtractor);
            mainform.m_DockForms.Add(mainform.searchForm);

            //Load Panels State
            if (!File.Exists("ET\\Dock Settings.xml"))
            {
                File.Copy("ET\\Default Dock Settings.xml", "ET\\Dock Settings.xml", true);
                File.SetAttributes("ET\\Dock Settings.xml", FileAttributes.Normal);
            }
            mainform.dockPanel.LoadFromXml("ET\\Dock Settings.xml", new DeserializeDockContent(mainform.DeserializeDockContent));

            //Load last state listview
            foreach (Form dockForm in mainform.m_DockForms)
            {
                mainform.LoadListViewConfig(dockForm);
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
