using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EuroTextEditor.Custom_Controls
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_ListViewHashCodes : UserControl
    {
        internal Frm_ListBoxHashCodes parentFormToSync;

        //-------------------------------------------------------------------------------------------
        //  FORM EVENTS
        //-------------------------------------------------------------------------------------------
        public UserControl_ListViewHashCodes()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void UserControl_ListViewHashCodes_Load(object sender, EventArgs e)
        {
            StatusLabel_TotalItems.Text = ListView_HashCodes.Items.Count + " Items";
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ListView_HashCodes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListView_HashCodes.SelectedItems.Count == 1)
            {
                CommonFunctions.EditHashCode(ListView_HashCodes.SelectedItems[0], parentFormToSync);
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  CONTEXT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_Edit_Click(object sender, EventArgs e)
        {
            if (ListView_HashCodes.SelectedItems.Count == 1)
            {
                CommonFunctions.EditHashCode(ListView_HashCodes.SelectedItems[0], parentFormToSync);
            }
            else if (ListView_HashCodes.SelectedItems.Count > 1)
            {
                //Get all selected items
                List<string> fileNames = new List<string>();
                for (int i = 0; i < ListView_HashCodes.SelectedItems.Count; i++)
                {
                    fileNames.Add(ListView_HashCodes.SelectedItems[i].Text);
                }

                //Show multi editor
                Frm_TextEditor_Multi multiEditor = new Frm_TextEditor_Multi(fileNames.ToArray());
                multiEditor.ShowDialog();
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_New_Click(object sender, EventArgs e)
        {
            Frm_InputBox frmTextFileName = new Frm_InputBox("Create New", "Enter Name", "");
            if (frmTextFileName.ShowDialog() == DialogResult.OK)
            {
                Match match = Regex.Match(frmTextFileName.ReturnValue, @"^[a-zA-Z0-9_]*$");
                if (match.Success)
                {
                    //Ensure that the hashcode contains the section
                    if (!frmTextFileName.ReturnValue.StartsWith("HT_Text_", StringComparison.OrdinalIgnoreCase))
                    {
                        frmTextFileName.ReturnValue = "HT_Text_" + frmTextFileName.ReturnValue;
                    }

                    //Get file path and create a new object
                    string projectFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", frmTextFileName.ReturnValue + ".etf");
                    EuroText_TextFile newTextFile = new EuroText_TextFile
                    {
                        FirstCreated = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                        CreatedBy = GlobalVariables.EuroTextUser,
                        LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                        LastModifiedBy = GlobalVariables.EuroTextUser
                    };

                    //Add languages to the text file.
                    for (int i = 0; i < GlobalVariables.CurrentProject.Languages.Count; i++)
                    {
                        string langaugeToAdd = GlobalVariables.CurrentProject.Languages[i];
                        newTextFile.Messages.Add(langaugeToAdd, string.Empty);
                    }

                    //Add item to the listbox
                    ListView_HashCodes.BeginUpdate();
                    ListView_HashCodes.Items.Add(new ListViewItem(new[] { frmTextFileName.ReturnValue, newTextFile.FirstCreated, newTextFile.CreatedBy, newTextFile.LastModified, newTextFile.LastModifiedBy }));
                    ListView_HashCodes.EndUpdate();

                    //Write file
                    ETXML_Writter filesWriter = new ETXML_Writter();
                    filesWriter.WriteTextFile(projectFilePath, newTextFile);
                }
                else
                {
                    MessageBox.Show("Label '" + frmTextFileName.ReturnValue + "' uses invalid characters, only numbers, digits and underscore characters are allowed.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Delete_Click(object sender, EventArgs e)
        {
            if (ListView_HashCodes.SelectedItems.Count > 0)
            {
                List<string> itemsToDelete = new List<string>();
                foreach (ListViewItem Item in ListView_HashCodes.SelectedItems)
                {
                    itemsToDelete.Add(Item.Text.ToString());
                }

                DialogResult answerQuestion = MessageBox.Show(CommonFunctions.MultipleDeletionMessage("Are you sure you want to delete HashCodes", itemsToDelete.ToArray()), "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answerQuestion == DialogResult.Yes)
                {
                    //Crate trash folder
                    string trashFolder = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages_Trash");
                    Directory.CreateDirectory(trashFolder);

                    foreach (ListViewItem itemToRemove in ListView_HashCodes.SelectedItems)
                    {
                        //Remove EuroTextFile
                        string filePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", itemToRemove.Text + ".etf");
                        File.Move(filePath, Path.Combine(trashFolder, itemToRemove.Text + ".etf"));

                        //Remove item from listview
                        ListView_HashCodes.BeginUpdate();
                        ListView_HashCodes.Items.Remove(itemToRemove);
                        ListView_HashCodes.EndUpdate();
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Rename_Click(object sender, EventArgs e)
        {
            if (ListView_HashCodes.SelectedItems.Count == 1)
            {
                Frm_InputBox frmTextFileName = new Frm_InputBox("Rename", "Enter New Name", "");
                if (frmTextFileName.ShowDialog() == DialogResult.OK)
                {
                    Match match = Regex.Match(frmTextFileName.ReturnValue, @"^[a-zA-Z0-9_]*$");
                    if (match.Success)
                    {
                        //Ensure that the hashcode contains the section
                        if (!frmTextFileName.ReturnValue.StartsWith("HT_Text_", StringComparison.OrdinalIgnoreCase))
                        {
                            frmTextFileName.ReturnValue = "HT_Text_" + frmTextFileName.ReturnValue;
                        }

                        //Get file path and create a new object
                        string newFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", frmTextFileName.ReturnValue + ".etf");

                        //Move file
                        if (File.Exists(newFilePath))
                        {
                            MessageBox.Show(string.Join("", "'", frmTextFileName.ReturnValue, "' already exists please use another name!"), "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string sourceFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", ListView_HashCodes.SelectedItems[0].Text + ".etf");
                            File.Move(sourceFilePath, newFilePath);
                            ListView_HashCodes.SelectedItems[0].Text = frmTextFileName.ReturnValue;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Label '" + frmTextFileName.ReturnValue + "' uses invalid characters, only numbers, digits and underscore characters are allowed.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_SetGroup_Click(object sender, EventArgs e)
        {
            string textGroupsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "Groups.txt");
            if (File.Exists(textGroupsFilePath))
            {
                string[] availableGroups = File.ReadAllLines(textGroupsFilePath);

                //Show form
                Frm_SetTextGroup setGroup = new Frm_SetTextGroup(availableGroups);
                if (setGroup.ShowDialog() == DialogResult.OK)
                {
                    //Get the group that use user has selected
                    string selectedGroup = setGroup.selectedTextGroup;

                    //Call reader lib
                    ETXML_Reader filesReader = new ETXML_Reader();
                    ETXML_Writter filesWriter = new ETXML_Writter();

                    //Update all text files
                    foreach (ListViewItem selectedItem in ListView_HashCodes.SelectedItems)
                    {
                        string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", selectedItem.Text + ".etf");
                        if (File.Exists(textFilePath))
                        {
                            //Update property
                            EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);
                            textObjectData.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                            textObjectData.LastModifiedBy = GlobalVariables.EuroTextUser;
                            textObjectData.Group = selectedGroup;

                            //Update listview
                            selectedItem.SubItems[3].Text = textObjectData.LastModified;
                            selectedItem.SubItems[4].Text = textObjectData.LastModifiedBy;

                            //Write file again
                            filesWriter.WriteTextFile(textFilePath, textObjectData);
                        }
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_MultiEditor_Click(object sender, EventArgs e)
        {
            List<string> filesToModify = new List<string>();
            foreach (ListViewItem Item in ListView_HashCodes.SelectedItems)
            {
                filesToModify.Add(Item.Text.ToString());
            }

            Frm_TextStore storeText = new Frm_TextStore(filesToModify.ToArray());
            storeText.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_SetColor_Click(object sender, EventArgs e)
        {
            if (ColorPicker_HashCodes.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem itemToModify in ListView_HashCodes.SelectedItems)
                {
                    itemToModify.BackColor = ColorPicker_HashCodes.Color;

                    //Sync listviews
                    if (parentFormToSync != null)
                    {
                        foreach (ListViewItem itemsToUpdate in parentFormToSync.UserControl_HashCodesListView.ListView_HashCodes.Items)
                        {
                            if (itemsToUpdate.Text.Equals(itemToModify.Text))
                            {
                                itemsToUpdate.BackColor = ColorPicker_HashCodes.Color;
                                break;
                            }
                        }
                    }

                    //Update TextFile
                    ETXML_Reader filesReader = new ETXML_Reader();
                    ETXML_Writter filesWriter = new ETXML_Writter();

                    string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", itemToModify.Text + ".etf");
                    if (File.Exists(textFilePath))
                    {
                        //Update property
                        EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);
                        textObjectData.RowColor = ColorPicker_HashCodes.Color;

                        //Write file again
                        filesWriter.WriteTextFile(textFilePath, textObjectData);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_RemoveColor_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemToModify in ListView_HashCodes.SelectedItems)
            {
                itemToModify.BackColor = SystemColors.Window;

                //Sync listviews
                if (parentFormToSync != null)
                {
                    foreach (ListViewItem itemsToUpdate in parentFormToSync.UserControl_HashCodesListView.ListView_HashCodes.Items)
                    {
                        if (itemsToUpdate.Text.Equals(itemToModify.Text))
                        {
                            itemsToUpdate.BackColor = SystemColors.Window;
                            break;
                        }
                    }
                }

                //Update TextFile
                ETXML_Reader filesReader = new ETXML_Reader();
                ETXML_Writter filesWriter = new ETXML_Writter();

                string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", itemToModify.Text + ".etf");
                if (File.Exists(textFilePath))
                {
                    //Update property
                    EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);
                    textObjectData.RowColor = SystemColors.Window;

                    //Write file again
                    filesWriter.WriteTextFile(textFilePath, textObjectData);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Refresh_Click(object sender, EventArgs e)
        {
            CommonFunctions.LoadEuroTextFiles(ListView_HashCodes);
            if (ListView_HashCodes.Items.Count > 0)
            {
                ListView_HashCodes.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_EditNote_Click(object sender, EventArgs e)
        {
            if (ListView_HashCodes.SelectedItems.Count == 1)
            {
                ListViewItem itemToModify = ListView_HashCodes.SelectedItems[0];

                //Show input dialog form
                Frm_InputBox inputText = new Frm_InputBox("Edit Note", "Enter note text", itemToModify.SubItems[6].Text);
                if (inputText.ShowDialog() == DialogResult.OK)
                {
                    //Update UI
                    itemToModify.SubItems[6].Text = inputText.ReturnValue;

                    //Sync listviews
                    if (parentFormToSync != null)
                    {
                        foreach (ListViewItem itemsToUpdate in parentFormToSync.UserControl_HashCodesListView.ListView_HashCodes.Items)
                        {
                            if (itemsToUpdate.Text.Equals(itemToModify.Text))
                            {
                                itemsToUpdate.SubItems[6].Text = inputText.ReturnValue;
                                break;
                            }
                        }
                    }

                    //Update TextFile
                    string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", itemToModify.Text + ".etf");
                    if (File.Exists(textFilePath))
                    {
                        ETXML_Reader filesReader = new ETXML_Reader();
                        ETXML_Writter filesWriter = new ETXML_Writter();

                        //Update property
                        EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);
                        textObjectData.Notes = inputText.ReturnValue;

                        //Write file again
                        filesWriter.WriteTextFile(textFilePath, textObjectData);
                    }
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ListView_HashCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusLabel_SelectedItems.Text = ListView_HashCodes.SelectedItems.Count + " Selected";
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_SelectAll_ButtonClick(object sender, EventArgs e)
        {
            ListView_HashCodes.BeginUpdate();
            for (int i = 0; i < ListView_HashCodes.Items.Count; i++)
            {
                ListView_HashCodes.Items[i].Selected = true;
            }
            ListView_HashCodes.EndUpdate();
            ListView_HashCodes.Focus();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_SelectNone_ButtonClick(object sender, EventArgs e)
        {
            ListView_HashCodes.SelectedItems.Clear();
            ListView_HashCodes.Focus();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_InvertSelection_ButtonClick(object sender, EventArgs e)
        {
            // Build a hashset of the currently selected indicies
            int[] selectedArray = new int[ListView_HashCodes.SelectedIndices.Count];
            HashSet<int> selected = new HashSet<int>();

            ListView_HashCodes.SelectedIndices.CopyTo(selectedArray, 0);
            selected.UnionWith(selectedArray);

            ListView_HashCodes.SelectedIndices.Clear();
            for (int i = 0; i < ListView_HashCodes.Items.Count; i++)
            {
                if (!selected.Contains(i))
                {
                    ListView_HashCodes.SelectedIndices.Add(i);
                }
            }

            ListView_HashCodes.Focus();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_CopyHashCode_Click(object sender, EventArgs e)
        {
            if (ListView_HashCodes.SelectedItems.Count == 1)
            {
                Clipboard.SetText(ListView_HashCodes.SelectedItems[0].Text);
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void MenuItem_Categories_Click(object sender, EventArgs e)
        {
            if (ListView_HashCodes.SelectedItems.Count > 0)
            {
                //Update TextFile
                string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", ListView_HashCodes.SelectedItems[0].Text + ".etf");
                if (File.Exists(textFilePath))
                {
                    ETXML_Reader filesReader = new ETXML_Reader();
                    ETXML_Writter filesWriter = new ETXML_Writter();

                    EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);

                    //Show flags selector
                    Frm_Categories categoriesEditor = new Frm_Categories(textObjectData.textFlags);
                    if (categoriesEditor.ShowDialog() == DialogResult.OK)
                    {
                        textObjectData.textFlags = categoriesEditor.selectedFlags;

                        foreach (ListViewItem textToUpdate in ListView_HashCodes.SelectedItems)
                        {
                            //Update UI
                            string flagsLabels = CommonFunctions.GetFlagsLabels(categoriesEditor.selectedFlags);
                            textToUpdate.SubItems[5].Text = flagsLabels;

                            //Sync listviews
                            if (parentFormToSync != null)
                            {
                                foreach (ListViewItem itemsToUpdate in parentFormToSync.UserControl_HashCodesListView.ListView_HashCodes.Items)
                                {
                                    if (itemsToUpdate.Text.Equals(textToUpdate.Text))
                                    {
                                        itemsToUpdate.SubItems[5].Text = flagsLabels;
                                        break;
                                    }
                                }
                            }

                            string filePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", textToUpdate.Text + ".etf");
                            if (File.Exists(filePath))
                            {
                                //Update property
                                EuroText_TextFile textObj = filesReader.ReadTextFile(filePath);
                                textObj.textFlags = categoriesEditor.selectedFlags;

                                //Write file again
                                filesWriter.WriteTextFile(filePath, textObj);
                            }
                        }
                    }
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
