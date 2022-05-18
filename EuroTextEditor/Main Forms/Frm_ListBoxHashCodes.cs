using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_ListBoxHashCodes : DockContent
    {
        private readonly MenuItem formMenuItem;

        //-------------------------------------------------------------------------------------------
        //  FORM EVENTS
        //-------------------------------------------------------------------------------------------
        public Frm_ListBoxHashCodes(MenuItem parentMainForm)
        {
            InitializeComponent();
            formMenuItem = parentMainForm;

            //Menu Item
            formMenuItem.Click += (se, ev) => { if (IsHidden) { Show(); formMenuItem.Checked = true; } };
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_ListBoxHashCodes_Shown(object sender, EventArgs e)
        {
            if (UserControl_HashCodesListView.ListView_HashCodes.Items.Count > 0)
            {
                UserControl_HashCodesListView.ListView_HashCodes.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_ListBoxHashCodes_VisibleChanged(object sender, EventArgs e)
        {
            if (IsHidden)
            {
                formMenuItem.Checked = false;
            }
        }

        //-------------------------------------------------------------------------------------------
        //  LISTBOX HASHCODES
        //-------------------------------------------------------------------------------------------
        private void ListView_HashCodes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (UserControl_HashCodesListView.ListView_HashCodes.SelectedItems.Count == 1)
            {
                CommonFunctions.EditHashCode(UserControl_HashCodesListView.ListView_HashCodes.SelectedItems[0]);
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
            if (UserControl_HashCodesListView.ListView_HashCodes.SelectedItems.Count == 1)
            {
                CommonFunctions.EditHashCode(UserControl_HashCodesListView.ListView_HashCodes.SelectedItems[0]);
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
                    string projectFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", frmTextFileName.ReturnValue + ".etf");
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
                    UserControl_HashCodesListView.ListView_HashCodes.BeginUpdate();
                    UserControl_HashCodesListView.ListView_HashCodes.Items.Add(new ListViewItem(new[] { frmTextFileName.ReturnValue, newTextFile.FirstCreated, newTextFile.CreatedBy, newTextFile.LastModified, newTextFile.LastModifiedBy }));
                    UserControl_HashCodesListView.ListView_HashCodes.EndUpdate();

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
            if (UserControl_HashCodesListView.ListView_HashCodes.SelectedItems.Count > 0)
            {
                List<string> itemsToDelete = new List<string>();
                foreach (ListViewItem Item in UserControl_HashCodesListView.ListView_HashCodes.SelectedItems)
                {
                    itemsToDelete.Add(Item.Text.ToString());
                }

                DialogResult answerQuestion = MessageBox.Show(CommonFunctions.MultipleDeletionMessage("Are you sure you want to delete HashCodes", itemsToDelete.ToArray()), "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answerQuestion == DialogResult.Yes)
                {
                    //Crate trash folder
                    string trashFolder = Path.Combine(GlobalVariables.WorkingDirectory, "Messages_Trash");
                    Directory.CreateDirectory(trashFolder);

                    foreach (ListViewItem itemToRemove in UserControl_HashCodesListView.ListView_HashCodes.SelectedItems)
                    {
                        //Remove EuroTextFile
                        string filePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", itemToRemove.Text + ".etf");
                        File.Move(filePath, Path.Combine(trashFolder, itemToRemove.Text + ".etf"));

                        //Remove item from listview
                        UserControl_HashCodesListView.ListView_HashCodes.BeginUpdate();
                        UserControl_HashCodesListView.ListView_HashCodes.Items.Remove(itemToRemove);
                        UserControl_HashCodesListView.ListView_HashCodes.EndUpdate();
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Rename_Click(object sender, EventArgs e)
        {
            if (UserControl_HashCodesListView.ListView_HashCodes.SelectedItems.Count == 1)
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
                        string newFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", frmTextFileName.ReturnValue + ".etf");

                        //Move file
                        if (File.Exists(newFilePath))
                        {
                            MessageBox.Show(string.Join("", "'", frmTextFileName.ReturnValue, "' already exists please use another name!"), "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string sourceFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", UserControl_HashCodesListView.ListView_HashCodes.SelectedItems[0].Text + ".etf");
                            File.Move(sourceFilePath, newFilePath);
                            UserControl_HashCodesListView.ListView_HashCodes.SelectedItems[0].Text = frmTextFileName.ReturnValue;
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
                    foreach (ListViewItem selectedItem in UserControl_HashCodesListView.ListView_HashCodes.SelectedItems)
                    {
                        string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", selectedItem.Text + ".etf");
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
            foreach (ListViewItem Item in UserControl_HashCodesListView.ListView_HashCodes.SelectedItems)
            {
                filesToModify.Add(Item.Text.ToString());
            }

            Frm_TextStore storeText = new Frm_TextStore(filesToModify.ToArray());
            storeText.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_SetColor_Click(object sender, EventArgs e)
        {
            if (UserControl_HashCodesListView.ColorPicker_HashCodes.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem itemToModify in UserControl_HashCodesListView.ListView_HashCodes.SelectedItems)
                {
                    itemToModify.BackColor = UserControl_HashCodesListView.ColorPicker_HashCodes.Color;

                    //Update TextFile
                    ETXML_Reader filesReader = new ETXML_Reader();
                    ETXML_Writter filesWriter = new ETXML_Writter();

                    string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", itemToModify.Text + ".etf");
                    if (File.Exists(textFilePath))
                    {
                        //Update property
                        EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);
                        textObjectData.RowColor = UserControl_HashCodesListView.ColorPicker_HashCodes.Color;

                        //Write file again
                        filesWriter.WriteTextFile(textFilePath, textObjectData);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_RemoveColor_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemToModify in UserControl_HashCodesListView.ListView_HashCodes.SelectedItems)
            {
                itemToModify.BackColor = SystemColors.Window;

                //Update TextFile
                ETXML_Reader filesReader = new ETXML_Reader();
                ETXML_Writter filesWriter = new ETXML_Writter();

                string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", itemToModify.Text + ".etf");
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
            CommonFunctions.LoadEuroTextFiles(UserControl_HashCodesListView.ListView_HashCodes);
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
