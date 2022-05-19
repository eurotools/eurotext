using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_ListBox_TextSections_Editor : Form
    {
        private bool PromptSave = true;
        private EuroText_TextSections sectionsFileText;

        //------------------------------------------------------------------------------------------------------------------------------
        public Frm_ListBox_TextSections_Editor()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------------------------------------------------------
        private void Frm_ListBox_TextSections_Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PromptSave)
            {
                DialogResult diagResult = MessageBox.Show("Are you sure you wish to quit without saving?", "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diagResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------
        private void Frm_ListBox_TextSections_Editor_Load(object sender, EventArgs e)
        {

            HashSet<string> AvailableHashCodes = CommonFunctions.ReadHashTableSection(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h"), "HT_File_");

            string SectionsFilepath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            if (File.Exists(SectionsFilepath))
            {
                ETXML_Reader projectFileReader = new ETXML_Reader();
                sectionsFileText = projectFileReader.ReadTextSectionsFile(SectionsFilepath);

                foreach(var textsection in sectionsFileText.TextSections)
                {
                    DataGridViewComboBoxCell comboCell = new DataGridViewComboBoxCell();
                    comboCell.Items.Clear();
                    comboCell.Sorted = true;
                    comboCell.Items.AddRange(AvailableHashCodes.ToArray());
                    if (AvailableHashCodes.Contains(textsection.Value))
                    {
                        comboCell.Value = textsection.Value;
                    }

                    int index = DataGridView_Editor.Rows.Add(textsection.Key, "");
                    DataGridView_Editor[1, index] = comboCell;
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            string SectionsFilepath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            if (File.Exists(SectionsFilepath))
            {
                sectionsFileText.TextSections.Clear();
                foreach (DataGridViewRow rowToRead in DataGridView_Editor.Rows)
                {
                    string sectionLevel = "**Undefined**";
                    if (rowToRead.Index == 0)
                    {
                        sectionLevel = "Output For All Levels";
                    }

                    if (((DataGridViewComboBoxCell)rowToRead.Cells[1]).Value != null)
                    {
                        sectionLevel = ((DataGridViewComboBoxCell)rowToRead.Cells[1]).Value.ToString();
                    }

                    int sectionText = Convert.ToInt32(Regex.Match(rowToRead.Cells[0].Value.ToString(), @"\d+").Value);
                    sectionsFileText.TextSections.Add(sectionText.ToString(), sectionLevel);
                }

                ETXML_Writter filesWriter = new ETXML_Writter();
                filesWriter.WriteTextSections(SectionsFilepath, sectionsFileText);
            }
            else
            {
                MessageBox.Show("Error, file not found: " + SectionsFilepath, "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PromptSave = false;
            Close();
        }
    }

    //------------------------------------------------------------------------------------------------------------------------------
}
