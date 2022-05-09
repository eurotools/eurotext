using EuroTextEditor.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
                GlobalVariables.WorkingDirectory = euroTextIni.Read("Last_Project_Opened", "Misc");

                //Read project
                string projectFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Project.ini");
                if (File.Exists(projectFilePath))
                {
                    //Read properties file
                    IniFile projectFile = new IniFile(projectFilePath);
                    GlobalVariables.HashtablesFilePath = projectFile.Read("filePath", "HashTables");
                    mainform.Text = "EuroText: \"" + GlobalVariables.WorkingDirectory + "\"";

                    //Get Text Sections and levels
                    string[] textSections = File.ReadAllLines(Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.txt"));
                    string[] outLevels = File.ReadAllLines(Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "OutputLevels.txt"));

                    //Add text sections
                    for (int i = 0; i < textSections.Length; i++)
                    {
                        mainform.ListView_SectionsAndLevels.Items.Add(textSections[i]);
                    }

                    //Add levels
                    for (int i = 0; i < outLevels.Length; i++)
                    {
                        if (i < mainform.ListView_SectionsAndLevels.Items.Count)
                        {
                            mainform.ListView_SectionsAndLevels.Items[i].SubItems.Add(outLevels[i]);
                        }
                    }

                    //Get all groups
                    string[] textGroup = File.ReadAllLines(Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "Groups.txt"));
                    mainform.ListBox_TextGroups.BeginUpdate();
                    mainform.ListBox_TextGroups.Items.AddRange(textGroup);
                    mainform.ListBox_TextGroups.EndUpdate();
                    mainform.Label_Total_Groups.Text = "Total: " + mainform.ListBox_TextGroups.Items.Count;

                    //Get all hashcodes
                    HashSet<string> availableHashCodes = CommonFunctions.ReadHashTableSection(GlobalVariables.HashtablesFilePath, "HT_Text_");
                    mainform.ListBox_HashCodes.BeginUpdate();
                    mainform.ListBox_HashCodes.Items.AddRange(availableHashCodes.ToArray());
                    mainform.ListBox_HashCodes.EndUpdate();
                    mainform.Label_TotalHashCodes.Text = "Total: " + mainform.ListBox_HashCodes.Items.Count;
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
