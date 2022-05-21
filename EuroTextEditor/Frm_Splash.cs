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
            //Initialize forms
            mainform.hashCodes = new Frm_ListBoxHashCodes(mainform.MenuItem_HashCodesForm);
            mainform.textSections = new Frm_ListBox_TextSections(mainform.MenuItem_TextSectionsForm, mainform.hashCodes);
            mainform.textGroups = new Frm_ListBox_TextGroups(mainform.MenuItem_TextGroupsForm, mainform.hashCodes);

            //Check for ini file
            if (File.Exists(GlobalVariables.EuroTextIni))
            {
                //Read ini file
                IniFile euroTextIni = new IniFile(GlobalVariables.EuroTextIni);
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
                tempVar = euroTextIni.Read("includeNoSectionedHashCodes", "MainForm");
                if (!string.IsNullOrEmpty(tempVar))
                {
                    mainform.Checkbox_IncludeHashCodesWithNoSection.Checked = Convert.ToBoolean(tempVar);
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
                    mainform.Text = "EuroText: \"" + GlobalVariables.WorkingDirectory + "\"";

                    //Load content
                    CommonFunctions.LoadEuroTextFiles(mainform.hashCodes.UserControl_HashCodesListView.ListView_HashCodes);
                    mainform.textGroups.ReadTextGroups();
                    mainform.textSections.LoadTextSections();
                }
                else
                {
                    MessageBox.Show(string.Join(" ", "Project Not Found", GlobalVariables.WorkingDirectory), "EuroText Load Project Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Show/dock forms
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockSettingsMainForm.xml");
            if (File.Exists(configFile))
            {
                DeserializeDockContent _deserializeDockContent = new DeserializeDockContent(DeserializeDockContent);
                mainform.dockPanel.LoadFromXml(configFile, _deserializeDockContent);
            }
            else
            {
                mainform.hashCodes.Show(mainform.dockPanel, DockState.Document);
                mainform.textSections.Show(mainform.dockPanel, DockState.DockLeft);
                mainform.textGroups.Show(mainform.textSections.Pane, DockAlignment.Bottom, 0.5);
            }

            //Update menus
            mainform.MenuItem_TextGroupsForm.Checked = !mainform.textGroups.IsHidden;
            mainform.MenuItem_TextSectionsForm.Checked = !mainform.textSections.IsHidden;
            mainform.MenuItem_HashCodesForm.Checked = !mainform.hashCodes.IsHidden;

            //Get recent files
            mainform.RecentFilesMenu = new MruStripMenuInline(mainform.MenuItem_RecentProjects, mainform.MenuItem_RecentFiles, new MostRecentFilesMenu.ClickedHandler(mainform.MenuItemFile_Recent_Click), GlobalVariables.EuroTextIni, 5);
            mainform.RecentFilesMenu.LoadFromIniFile();

            //Start timer
            TimerSplash.Start();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private IDockContent DeserializeDockContent(string persistString)
        {
            if (persistString == typeof(Frm_ListBoxHashCodes).ToString())
            {
                return mainform.hashCodes;
            }
            if (persistString == typeof(Frm_ListBox_TextSections).ToString())
            {
                return mainform.textSections;
            }
            if (persistString == typeof(Frm_ListBox_TextGroups).ToString())
            {
                return mainform.textGroups;
            }
            if (persistString == typeof(Frm_SpreadSheets_Extractor).ToString())
            {
                return new Frm_SpreadSheets_Extractor();
            }
            if (persistString == typeof(Frm_Searcher).ToString())
            {
                return new Frm_Searcher(mainform.hashCodes);
            }
            return null;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
