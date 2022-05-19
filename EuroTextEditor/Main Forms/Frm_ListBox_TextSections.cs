using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_ListBox_TextSections : DockContent
    {
        private readonly MenuItem formMenuItem;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_ListBox_TextSections(MenuItem parentMainForm)
        {
            InitializeComponent();
            formMenuItem = parentMainForm;

            //Menu Item
            formMenuItem.Click += (se, ev) => { if (IsHidden) { Show(); formMenuItem.Checked = true; } };
        }

        //-------------------------------------------------------------------------------------------
        //  FORM EVENTS
        //-------------------------------------------------------------------------------------------
        private void Frm_ListBox_TextSections_VisibleChanged(object sender, System.EventArgs e)
        {
            if (IsHidden)
            {
                formMenuItem.Checked = false;
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

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Refresh_Click(object sender, System.EventArgs e)
        {
            LoadTextSections();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ListView_SectionsAndLevels_DoubleClick(object sender, System.EventArgs e)
        {
            if (ListView_SectionsAndLevels.SelectedItems.Count == 1)
            {
                ETXML_Reader filesReader = new ETXML_Reader();
                HashSet<string> hashCodesInThisGroup = new HashSet<string>();
                string selectedSection = ListView_SectionsAndLevels.SelectedItems[0].Text;

                //Search hashcodes that are in this group
                string[] filesToAdd = Directory.GetFiles(Path.Combine(GlobalVariables.WorkingDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly);
                for (int i = 0; i < filesToAdd.Length; i++)
                {
                    //Get message text and ensure that the source file exists
                    if (File.Exists(filesToAdd[i]))
                    {
                        //Read object
                        EuroText_TextFile objText = filesReader.ReadTextFile(filesToAdd[i]);

                        //Add items
                        if (objText.OutputSection.Equals(selectedSection, System.StringComparison.OrdinalIgnoreCase))
                        {
                            hashCodesInThisGroup.Add(Path.GetFileName(filesToAdd[i]));
                        }
                    }
                }

                //Show form
                Frm_GroupsViewer groupsViewer = new Frm_GroupsViewer(hashCodesInThisGroup.ToArray())
                {
                    Text = selectedSection
                };
                groupsViewer.ShowDialog();
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  FUNCTIONS
        //-------------------------------------------------------------------------------------------
        internal void LoadTextSections()
        {
            ETXML_Reader projectFileReader = new ETXML_Reader();

            //Get Text Sections and levels
            string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            if (File.Exists(textSectionsFilePath))
            {
                EuroText_TextSections sectionsFileText = projectFileReader.ReadTextSectionsFile(textSectionsFilePath);
                ListView_SectionsAndLevels.BeginUpdate();
                ListView_SectionsAndLevels.Items.Clear();
                foreach (KeyValuePair<string, string> textSectionItem in sectionsFileText.TextSections)
                {
                    ListView_SectionsAndLevels.Items.Add(new ListViewItem(new[] { textSectionItem.Key, textSectionItem.Value.ToString() }));
                }
                ListView_SectionsAndLevels.EndUpdate();
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
