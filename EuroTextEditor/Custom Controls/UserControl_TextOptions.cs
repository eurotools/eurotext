using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EuroTextEditor.Custom_Controls
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_TextOptions : UserControl
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControl_TextOptions()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void UserControl_TextOptions_Load(object sender, EventArgs e)
        {
            //Get all groups
            string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextGroups.etf");
            if (File.Exists(textGroupsFilePath))
            {
                ETXML_Reader projectFileReader = new ETXML_Reader();
                EuroText_TextGroups textGroupsData = projectFileReader.ReadTextGroupsFile(textGroupsFilePath);
                Combobox_Group.BeginUpdate();
                Combobox_Group.Items.Add("");
                Combobox_Group.Items.AddRange(textGroupsData.TextGroups.ToArray());
                Combobox_Group.EndUpdate();
                if (Combobox_Group.Items.Count > 0)
                {
                    Combobox_Group.SelectedIndex = 0;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Textbox_OutputSections_Click(object sender, EventArgs e)
        {
            Frm_TextOutputSections outputSectionsEditor = new Frm_TextOutputSections(Textbox_OutputSections.Text.Split(';'));
            if (outputSectionsEditor.ShowDialog() == DialogResult.OK)
            {
                Textbox_OutputSections.Text = outputSectionsEditor.selectedSections;
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
