using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_ListBox_TextSections : DockContent
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_ListBox_TextSections()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------
        //  FORM EVENTS
        //-------------------------------------------------------------------------------------------
        private void Frm_ListBox_TextSections_Load(object sender, System.EventArgs e)
        {
            ETXML_Reader projectFileReader = new ETXML_Reader();

            //Get Text Sections and levels
            string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            if (File.Exists(textSectionsFilePath))
            {
                EuroText_TextSections sectionsFileText = projectFileReader.ReadTextSectionsFile(textSectionsFilePath);
                ListView_SectionsAndLevels.BeginUpdate();
                foreach (KeyValuePair<string, string> textSectionItem in sectionsFileText.TextSections)
                {
                    ListView_SectionsAndLevels.Items.Add(new ListViewItem(new[] { textSectionItem.Key, textSectionItem.Value.ToString() }));
                }
                ListView_SectionsAndLevels.EndUpdate();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  CONTEXT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_NewSection_Click(object sender, System.EventArgs e)
        {
            if (File.Exists(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h")))
            {
                //Open selector
                Frm_HashCodesSelector selector = new Frm_HashCodesSelector("HT_File", true)
                {
                    Text = "Add New Text Section"
                };
                if (selector.ShowDialog() == DialogResult.OK)
                {
                    //Check if item exists
                    bool canAddNewSection = true;
                    foreach (ListViewItem itemToCheck in ListView_SectionsAndLevels.Items)
                    {
                        string levelName = itemToCheck.SubItems[1].Text;
                        if (levelName.Equals(selector.SelectedHashCode))
                        {
                            canAddNewSection = false;
                            break;
                        }
                    }

                    //Add item
                    if (canAddNewSection)
                    {
                        //Update control
                        GlobalVariables.CurrentProject.TextSectionsID++;
                        string textSectionName = "HT_TextSection" + GlobalVariables.CurrentProject.TextSectionsID.ToString("00");
                        ListView_SectionsAndLevels.Items.Add(new ListViewItem(new[] { textSectionName, selector.SelectedHashCode }));

                        //Create or update the TextSections file
                        EuroText_TextSections sectionsFileText = new EuroText_TextSections();
                        string projectFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
                        if (File.Exists(projectFilePath))
                        {
                            ETXML_Reader projectFileReader = new ETXML_Reader();
                            sectionsFileText = projectFileReader.ReadTextSectionsFile(projectFilePath);
                        }

                        //Update dictionary and write file
                        foreach (ListViewItem itemToCheck in ListView_SectionsAndLevels.Items)
                        {
                            string sectionNum = itemToCheck.Text;
                            string levelName = itemToCheck.SubItems[1].Text;

                            if (!sectionsFileText.TextSections.ContainsKey(sectionNum))
                            {
                                sectionsFileText.TextSections.Add(sectionNum, levelName);
                            }
                        }

                        //Write file again
                        ETXML_Writter filesWriter = new ETXML_Writter();
                        filesWriter.WriteTextSections(projectFilePath, sectionsFileText);
                    }
                    else
                    {
                        MessageBox.Show("The selected section could not be added, a section with this level already exists.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
