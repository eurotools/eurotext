﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
        private readonly List<string> changesReg = new List<string>();

        //------------------------------------------------------------------------------------------------------------------------------
        public Frm_ListBox_TextSections_Editor()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------
        //  FORM EVENTS
        //-------------------------------------------------------------------------------------------
        private void Frm_ListBox_TextSections_Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PromptSave)
            {
                DialogResult diagResult = MessageBox.Show("Are you sure you wish to quit without saving?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            string[] AvailableHashCodesSorted = AvailableHashCodes.OrderBy(v => v).ToArray();


            List<string> AvailableTextSections = new List<string>();
            for (int i = 8; i < 256; i++)
            {
                //memcard/savedata text
                if (i > 59 && i < 64)
                {
                    continue;
                }
                AvailableTextSections.Add("HT_TextSection" + i.ToString("00"));
            }


            string SectionsFilepath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            if (File.Exists(SectionsFilepath))
            {
                ETXML_Reader projectFileReader = new ETXML_Reader();
                sectionsFileText = projectFileReader.ReadTextSectionsFile(SectionsFilepath);

                ListView_TextSections.BeginUpdate();
                foreach (KeyValuePair<string, string> textsection in sectionsFileText.TextSections)
                {
                    changesReg.Add(textsection.Key);
                    ListViewItem itemData = ListView_TextSections.Items.Add(new ListViewItem(new[] { textsection.Key, textsection.Value }));
                    if (itemData.Index > 0)
                    {
                        ListView_TextSections.AddComboBoxCell(itemData.Index, 1, AvailableHashCodesSorted);
                        ListView_TextSections.AddComboBoxCell(itemData.Index, 0, AvailableTextSections.ToArray());
                    }
                }
                ListView_TextSections.EndUpdate();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  CONTEXT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_AddNewSection_Click(object sender, EventArgs e)
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
                    foreach (ListViewItem itemToCheck in ListView_TextSections.Items)
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
                        ListView_TextSections.Items.Add(new ListViewItem(new[] { textSectionName, selector.SelectedHashCode }));
                        changesReg.Add(textSectionName);
                    }
                    else
                    {
                        MessageBox.Show("The selected section could not be added, a section with this level already exists.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_DeleteTextSection_Click(object sender, EventArgs e)
        {
            List<string> itemsToDelete = new List<string>();
            foreach (ListViewItem Item in ListView_TextSections.SelectedItems)
            {
                itemsToDelete.Add(Item.Text.ToString());
            }

            DialogResult answerQuestion = MessageBox.Show(CommonFunctions.MultipleDeletionMessage("Are you sure you want to delete Text Sections", itemsToDelete.ToArray()), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answerQuestion == DialogResult.Yes)
            {
                ListView_TextSections.BeginUpdate();
                foreach (ListViewItem eachItem in ListView_TextSections.SelectedItems)
                {
                    ListView_TextSections.Items.Remove(eachItem);
                }
                ListView_TextSections.EndUpdate();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  FORM BUTTONS
        //-------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            //First of all, check no duplicated sections and levels
            List<string> userTextSections = new List<string>();
            List<string> userLevels = new List<string>();

            foreach (ListViewItem itemToCheck in ListView_TextSections.Items)
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
                        foreach (ListViewItem rowToRead in ListView_TextSections.Items)
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

                    PromptSave = false;
                    Close();
                }
            }
        }
    }

    //------------------------------------------------------------------------------------------------------------------------------
}
