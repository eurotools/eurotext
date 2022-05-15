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

                    //Get Text Sections and levels
                    /* string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
                     if (File.Exists(textSectionsFilePath))
                     {
                         EuroText_TextSections sectionsFileText = projectFileReader.ReadTextSectionsFile(textSectionsFilePath);
                         mainform.ListView_SectionsAndLevels.BeginUpdate();
                         foreach (KeyValuePair<string, string> textSectionItem in sectionsFileText.TextSections)
                         {
                             mainform.ListView_SectionsAndLevels.Items.Add(new ListViewItem(new[] { textSectionItem.Key, textSectionItem.Value.ToString() }));
                         }
                         mainform.ListView_SectionsAndLevels.EndUpdate();
                         mainform.Label_TotalSections.Text = "Total: " + mainform.ListView_SectionsAndLevels.Items.Count;
                     }

                     //Get all groups
                     string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "Groups.txt");
                     if (File.Exists(textGroupsFilePath))
                     {
                         string[] textGroup = File.ReadAllLines(textGroupsFilePath);
                         mainform.ListBox_TextGroups.BeginUpdate();
                         mainform.ListBox_TextGroups.Items.AddRange(textGroup);
                         mainform.ListBox_TextGroups.EndUpdate();
                         mainform.Label_Total_Groups.Text = "Total: " + mainform.ListBox_TextGroups.Items.Count;
                     }

                     //Get text files
                     string[] filesToAdd = Directory.GetFiles(Path.Combine(GlobalVariables.WorkingDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly).Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();

                     //Update control
                     mainform.ListBox_HashCodes.BeginUpdate();
                     mainform.ListBox_HashCodes.Items.AddRange(filesToAdd);
                     mainform.ListBox_HashCodes.EndUpdate();
                     mainform.listCollection = filesToAdd;

                     //Update label
                     mainform.Label_TotalHashCodes.Text = "Total: " + mainform.ListBox_HashCodes.Items.Count;*/
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
