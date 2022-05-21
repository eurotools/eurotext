using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_TextOutputSections : Form
    {
        private readonly string[] outputSections;
        internal string selectedSections = string.Empty;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_TextOutputSections(string[] currentOutputSections)
        {
            InitializeComponent();
            outputSections = currentOutputSections;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextOutputSections_Load(object sender, EventArgs e)
        {
            ListBox_OutputSections.BeginUpdate();
            ListBox_OutputSections.Items.AddRange(outputSections);
            ListBox_OutputSections.EndUpdate();

            //Get all output levels and sections
            string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            if (File.Exists(textSectionsFilePath))
            {
                ETXML_Reader projectFileReader = new ETXML_Reader();
                EuroText_TextSections sectionsFileText = projectFileReader.ReadTextSectionsFile(textSectionsFilePath);
                ComboBox_AvailableSections.DataSource = new BindingSource(sectionsFileText.TextSections, null);
                ComboBox_AvailableSections.DisplayMember = "Value";
                ComboBox_AvailableSections.ValueMember = "Value";
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_DeleteItems_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = ListBox_OutputSections.SelectedItems;
            if (ListBox_OutputSections.SelectedIndex != -1)
            {
                ListBox_OutputSections.BeginUpdate();
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    ListBox_OutputSections.Items.Remove(selectedItems[i]);
                }
                ListBox_OutputSections.EndUpdate();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_AddSection_Click(object sender, EventArgs e)
        {
            ListBox_OutputSections.BeginUpdate();
            ListBox_OutputSections.Items.Add(ComboBox_AvailableSections.SelectedValue);
            ListBox_OutputSections.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            bool includeInAllSections = false;
            List<string> sectionsToMerge = new List<string>();
            for(int i = 0; i <ListBox_OutputSections.Items.Count; i++)
            {
                string currentItem = ListBox_OutputSections.Items[i].ToString();
                if (currentItem.Equals("Output For All Levels", StringComparison.OrdinalIgnoreCase))
                {
                    selectedSections = "Output For All Levels";
                    includeInAllSections = true;
                }
                sectionsToMerge.Add(currentItem);
            }
            
            if (!includeInAllSections)
            {
                selectedSections = string.Join(";", sectionsToMerge);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
