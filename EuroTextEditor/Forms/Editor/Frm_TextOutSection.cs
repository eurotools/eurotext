using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EuroTextEditor.Forms.Editor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_TextOutSection : Form
    {
        private readonly string[] outputSections;
        internal string selectedSections = string.Empty;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_TextOutSection(string[] currentOutputSections)
        {
            InitializeComponent();
            outputSections = currentOutputSections;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextOutSection_Load(object sender, EventArgs e)
        {
            //Get all output levels and sections
            string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            if (File.Exists(textSectionsFilePath))
            {
                //Read file
                ETXML_Reader projectFileReader = new ETXML_Reader();
                EuroText_TextSections sectionsFileText = projectFileReader.ReadTextSectionsFile(textSectionsFilePath);

                //Add sections to list and count them
                lstbAvailableOutSections.BeginUpdate();
                lstbAvailableOutSections.Items.AddRange(sectionsFileText.TextSections.Values.ToArray());
                lstbAvailableOutSections.EndUpdate();
                labTotalAvailable.Text = string.Format("Total: {0}", sectionsFileText.TextSections.Values.Count - 1);
            }

            //Add current output levels
            lstbOutSections.BeginUpdate();
            lstbOutSections.Items.AddRange(outputSections);
            lstbOutSections.EndUpdate();
            labelTotalOutSections.Text = string.Format("Total: {0}", lstbOutSections.Items.Count);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnRemoveSection_Click(object sender, EventArgs e)
        {
            if (lstbOutSections.SelectedItems.Count > 0)
            {
                ListBox.SelectedObjectCollection selectedItems = lstbOutSections.SelectedItems;
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    lstbOutSections.Items.Remove(selectedItems[i]);
                }
                labelTotalOutSections.Text = string.Format("Total: {0}", lstbOutSections.Items.Count);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnAddSection_Click(object sender, EventArgs e)
        {
            if (lstbAvailableOutSections.SelectedItems.Count > 0 && lstbOutSections.FindString("Output For All Levels") == ListBox.NoMatches)
            {
                bool outputForAll = false;
                ListBox.SelectedObjectCollection selectedItems = lstbAvailableOutSections.SelectedItems;

                //If the user selects the first one, we don't need the other ones.
                for (int i = 0; i < selectedItems.Count; i++)
                {
                    if (((string)selectedItems[i]).Equals("Output For All Levels", StringComparison.OrdinalIgnoreCase))
                    {
                        lstbOutSections.Items.Clear();
                        lstbOutSections.Items.Add(selectedItems[i]);
                        outputForAll = true;
                        break;
                    }
                }

                //Add selected sections
                if (!outputForAll)
                {
                    for (int i = 0; i < selectedItems.Count; i++)
                    {
                        if (lstbOutSections.FindString((string)selectedItems[i]) == ListBox.NoMatches)
                        {
                            lstbOutSections.Items.Add(selectedItems[i]);
                        }
                    }
                }
                labelTotalOutSections.Text = string.Format("Total: {0}", lstbOutSections.Items.Count);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (lstbOutSections.Items.Count > 1)
            {
                selectedSections = string.Join(";", lstbOutSections.Items.Cast<string>().ToArray());
            }
            else if (lstbOutSections.Items.Count == 1)
            {
                selectedSections = lstbOutSections.Items[0].ToString();
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
