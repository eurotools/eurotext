using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmTextSections : Form
    {
        private bool ModifiedFile = false;
        private EuroText_TextSections sectionsFileText;
        private readonly List<string> changesReg = new List<string>();

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmTextSections()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        //  FORM EVENTS
        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmTextSections_Load(object sender, System.EventArgs e)
        {
            ETXML_Reader projectFileReader = new ETXML_Reader();

            //Get Text Sections and levels
            string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            if (File.Exists(textSectionsFilePath))
            {
                sectionsFileText = projectFileReader.ReadTextSectionsFile(textSectionsFilePath);
                listView1.BeginUpdate();
                listView1.Items.Clear();
                foreach (KeyValuePair<string, string> textSectionItem in sectionsFileText.TextSections)
                {
                    listView1.Items.Add(new ListViewItem(new[] { textSectionItem.Key, textSectionItem.Value.ToString() }));
                }
                listView1.EndUpdate();

                //Select first item
                if (listView1.Items.Count > 0)
                {
                    listView1.Items[0].Selected = true;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmTextSections_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ModifiedFile)
            {
                DialogResult diagResult = MessageBox.Show("Are you sure you wish to quit without saving?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diagResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        //  Options
        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnAddSection_Click(object sender, System.EventArgs e)
        {
            using (FrmHashTableSelector hashTableSelector = new FrmHashTableSelector())
            {
                if (hashTableSelector.ShowDialog() == DialogResult.OK)
                {
                    ModifiedFile = true;
                    string textSection = hashTableSelector.cbxSectionSelector.SelectedItem.ToString();
                    string levelHashcode = hashTableSelector.cbxHashcodeSelector.SelectedItem.ToString();
                    listView1.Items.Add(new ListViewItem(new[] { textSection, levelHashcode }));
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected section?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ModifiedFile = true;
                listView1.SelectedItems[0].Remove();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnModify_Click(object sender, System.EventArgs e)
        {
            string TextSectionHashcode = listView1.SelectedItems[0].SubItems[0].Text;
            string LevelHashCode = listView1.SelectedItems[0].SubItems[1].Text;

            using (FrmHashTableSelector hashTableSelector = new FrmHashTableSelector(TextSectionHashcode, LevelHashCode))
            {
                if (hashTableSelector.ShowDialog() == DialogResult.OK)
                {
                    string textSection = hashTableSelector.cbxSectionSelector.SelectedItem.ToString();
                    string levelHashcode = hashTableSelector.cbxHashcodeSelector.SelectedItem.ToString();

                    listView1.SelectedItems[0].SubItems[0].Text = textSection;
                    listView1.SelectedItems[0].SubItems[1].Text = levelHashcode;

                    ModifiedFile = true;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Form options
        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            if (ModifiedFile)
            {
                //First of all, check no duplicated sections and levels
                List<string> userTextSections = new List<string>();
                List<string> userLevels = new List<string>();

                foreach (ListViewItem itemToCheck in listView1.Items)
                {
                    userTextSections.Add(itemToCheck.Text);
                    userLevels.Add(itemToCheck.SubItems[1].Text);
                }

                //Inform user if there are duplicated levles.
                if (userLevels.Count != userLevels.Distinct().Count())
                {
                    MessageBox.Show("There is more than one section with the same output level, fix it before save changes.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (userTextSections.Count != userTextSections.Distinct().Count())
                    {
                        MessageBox.Show("Duplicated text sections, fix it before save changes.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;

                        string SectionsFilepath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
                        if (File.Exists(SectionsFilepath))
                        {
                            sectionsFileText.TextSections.Clear();
                            foreach (ListViewItem rowToRead in listView1.Items)
                            {
                                string sectionLevel = rowToRead.SubItems[1].Text;
                                if (rowToRead.Index == 0)
                                {
                                    sectionLevel = "Output For All Levels";
                                }

                                int sectionText = Convert.ToInt32(Regex.Match(rowToRead.Text, @"\d+").Value);
                                sectionsFileText.TextSections.Add(sectionText.ToString(), sectionLevel);
                            }

                            ETXML_Writter filesWriter = new ETXML_Writter();
                            filesWriter.WriteTextSections(SectionsFilepath, sectionsFileText);

                            //Get sections to modify
                            Dictionary<string, string> TextSectionsToModify = new Dictionary<string, string>();
                            for (int i = 0; i < changesReg.Count; i++)
                            {
                                string previousTextSection = changesReg[i];
                                if (!previousTextSection.Equals(userTextSections[i]))
                                {
                                    TextSectionsToModify.Add(previousTextSection, userTextSections[i]);
                                }
                            }

                            //Update text files
                            if (TextSectionsToModify.Count > 0)
                            {
                                ETXML_Reader filesReader = new ETXML_Reader();
                                string[] textFilesToCheck = Directory.GetFiles(Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly);
                                for (int i = 0; i < textFilesToCheck.Length; i++)
                                {
                                    EuroText_TextFile textObj = filesReader.ReadTextFile(textFilesToCheck[i]);

                                    //Check for changes
                                    bool fileModified = false;
                                    foreach (KeyValuePair<string, string> sectionToCheck in TextSectionsToModify)
                                    {
                                        int positionToModify = Array.IndexOf(textObj.OutputSection, sectionToCheck.Key);
                                        if (positionToModify >= 0)
                                        {
                                            textObj.OutputSection[positionToModify] = sectionToCheck.Value;
                                            fileModified = true;
                                        }
                                    }

                                    //Write file again
                                    if (fileModified)
                                    {
                                        filesWriter.WriteTextFile(textFilesToCheck[i], textObj);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error, file not found: " + SectionsFilepath, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                ModifiedFile = false;
            }
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Context Menu
        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            BtnAddSection_Click(sender, e);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            BtnDelete_Click(sender, e);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemModify_Click(object sender, EventArgs e)
        {
            BtnModify_Click(sender, e);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemCopySectionName_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Clipboard.SetText(listView1.SelectedItems[0].Text);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemCopyHashCodeName_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Clipboard.SetText(listView1.SelectedItems[0].Text);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
