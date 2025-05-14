using System;
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
        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_ListBox_TextSections()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------
        //  CONTEXT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_Refresh_Click(object sender, System.EventArgs e)
        {
            LoadTextSections();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_EditSections_Click(object sender, System.EventArgs e)
        {
            Frm_ListBox_TextSections_Editor textSectionsEditor = new Frm_ListBox_TextSections_Editor();
            if (textSectionsEditor.ShowDialog() == DialogResult.OK)
            {
                LoadTextSections();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_SectionName_Click(object sender, System.EventArgs e)
        {
            if (ListView_SectionsAndLevels.SelectedItems.Count == 1)
            {
                Clipboard.SetText(ListView_SectionsAndLevels.SelectedItems[0].Text);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ApplyFilter_Click(object sender, EventArgs e)
        {
            if (ListView_SectionsAndLevels.SelectedItems.Count > 0)
            {
                string selectedTextSection = ListView_SectionsAndLevels.SelectedItems[0].Text;

                Frm_MainFrame mainFrame = (Frm_MainFrame)Application.OpenForms[nameof(Frm_MainFrame)];
                if (mainFrame != null)
                {
                    mainFrame.hashCodes.UserControl_HashCodesListView.LoadEuroTextFiles(-1, selectedTextSection);
                }
            }
        }

        //-------------------------------------------------------------------------------------------
        //  LISTVIEW
        //-------------------------------------------------------------------------------------------
        private void ListView_SectionsAndLevels_DoubleClick(object sender, System.EventArgs e)
        {
            if (ListView_SectionsAndLevels.SelectedItems.Count == 1)
            {
                ETXML_Reader filesReader = new ETXML_Reader();
                HashSet<string> hashCodesInThisGroup = new HashSet<string>();
                string selectedSection = ListView_SectionsAndLevels.SelectedItems[0].Text;

                //Search hashcodes that are in this group
                string[] filesToAdd = Directory.GetFiles(Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly);
                for (int i = 0; i < filesToAdd.Length; i++)
                {
                    //Get message text and ensure that the source file exists
                    if (File.Exists(filesToAdd[i]))
                    {
                        //Read object
                        EuroText_TextFile objText = filesReader.ReadTextFile(filesToAdd[i]);

                        //Add items
                        if (Array.IndexOf(objText.OutputSection, selectedSection) >= 0)
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

                //Select first item
                if (ListView_SectionsAndLevels.Items.Count > 0)
                {
                    ListView_SectionsAndLevels.Items[0].Selected = true;
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
