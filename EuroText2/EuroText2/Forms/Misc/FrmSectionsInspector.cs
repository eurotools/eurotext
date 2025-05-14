using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmSectionsInspector : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmSectionsInspector()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmSectionsInspector_Load(object sender, EventArgs e)
        {
            ETXML_Reader projectFileReader = new ETXML_Reader();

            //Get Text Sections and levels
            string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            if (File.Exists(textSectionsFilePath))
            {
                EuroText_TextSections sectionsFileText = projectFileReader.ReadTextSectionsFile(textSectionsFilePath);
                listView1.BeginUpdate();
                listView1.Items.Clear();
                foreach (KeyValuePair<string, string> textSectionItem in sectionsFileText.TextSections)
                {
                    listView1.Items.Add(new ListViewItem(new[] { textSectionItem.Key, textSectionItem.Value.ToString() }));
                }
                listView1.EndUpdate();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                string selectedSection = listView1.SelectedItems[0].Text;
                string[] hashCodesInThisGroup = CommonFunctions.GetSectionHashcodes(string.Empty, selectedSection);

                //Update listbox
                lbxMessages.BeginUpdate();
                lbxMessages.Items.Clear();
                lbxMessages.Items.AddRange(hashCodesInThisGroup.ToArray());
                lblTotalMessages.Text = "Total Messages: " + hashCodesInThisGroup.Length;
                lbxMessages.EndUpdate();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Textbox_OutputSections_Click(object sender, EventArgs e)
        {
            FrmTextOutSection outForm = new FrmTextOutSection(Textbox_OutputSections.Text.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries));
            if (outForm.ShowDialog() == DialogResult.OK)
            {
                Textbox_OutputSections.Text = outForm.selectedSections;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void LbxMessages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lbxMessages.SelectedItem + ".etf");
            using (FrmMainTextEditor editor = new FrmMainTextEditor(textFilePath))
            {
                editor.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (lbxMessages.Items.Count > 0)
            {
                if (MessageBox.Show("Selected texts output sections will be replaced for the selected ones, this action can not be undone. Are you sure you want to proced?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] outputSections = Textbox_OutputSections.Text.Split(';');
                    ETXML_Reader filesReader = new ETXML_Reader();

                    EuroText_TextSections sectionsFileText = filesReader.ReadTextSectionsFile(Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf"));
                    for (int i = 0; i < lbxMessages.SelectedItems.Count; i++)
                    {
                        //Read text file
                        string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lbxMessages.SelectedItems[i] + ".etf");
                        EuroText_TextFile objText = filesReader.ReadTextFile(textFilePath);

                        //Update
                        objText.OutputSection = new string[outputSections.Length];
                        for (int j = 0; j < outputSections.Length; j++)
                        {
                            objText.OutputSection[j] = sectionsFileText.TextSections.FirstOrDefault(x => x.Value == outputSections[j]).Key;
                        }

                        //Update properties and listview
                        objText.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                        objText.LastModifiedBy = GlobalVariables.EuroTextUser;

                        ETXML_Writter filesWriter = new ETXML_Writter();
                        filesWriter.WriteTextFile(textFilePath, objText);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Sections Context Menu
        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemSectionCopy_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Clipboard.SetText(listView1.SelectedItems[0].Text);
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemSectionHCCopy_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Clipboard.SetText(listView1.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Text Context Menu
        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextEdit_Click(object sender, EventArgs e)
        {
            if (lbxMessages.SelectedItems.Count == 1)
            {
                LbxMessages_MouseDoubleClick(sender, null);
            }
            else if (lbxMessages.SelectedItems.Count > 1)
            {
                //Get all selected items
                List<string> fileNames = new List<string>();
                for (int i = 0; i < lbxMessages.SelectedItems.Count; i++)
                {
                    fileNames.Add(lbxMessages.SelectedItems[i].ToString());
                }

                //Show multi editor
                FrmMainTextEditor_Multi multiEditor = new FrmMainTextEditor_Multi(fileNames.ToArray());
                multiEditor.ShowDialog();
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextEditCategories_Click(object sender, EventArgs e)
        {
            if (lbxMessages.SelectedItems.Count > 0)
            {
                //Update TextFile
                string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lbxMessages.SelectedItem + ".etf");
                if (File.Exists(textFilePath))
                {
                    //Show flags selector
                    using (FrmSetCategories categoriesEditor = new FrmSetCategories(lbxMessages, 0))
                    {
                        categoriesEditor.ShowDialog();
                    }
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextEditGroups_Click(object sender, EventArgs e)
        {
            FrmMultSetGroup setGroup = new FrmMultSetGroup();
            if (setGroup.ShowDialog() == DialogResult.OK)
            {
                //Get the group that use user has selected
                string selectedGroup = setGroup.selectedTextGroup;

                //Call reader lib
                ETXML_Reader filesReader = new ETXML_Reader();
                ETXML_Writter filesWriter = new ETXML_Writter();

                for (int i = 0; i < lbxMessages.Items.Count; i++)
                {
                    string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lbxMessages.Items[i] + ".etf");
                    if (File.Exists(textFilePath))
                    {
                        //Update property
                        EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);
                        textObjectData.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                        textObjectData.LastModifiedBy = GlobalVariables.EuroTextUser;
                        textObjectData.Group = selectedGroup;

                        //Write file again
                        filesWriter.WriteTextFile(textFilePath, textObjectData);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextCopyHashCode_Click(object sender, EventArgs e)
        {
            if (lbxMessages.SelectedItems.Count == 1)
            {
                Clipboard.SetText(lbxMessages.SelectedItems[0].ToString());
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (string itemToWrite in lbxMessages.Items)
                    {
                        string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", itemToWrite + ".etf");
                        outputFile.WriteLine(textFilePath);
                    }
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
