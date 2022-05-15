using System;
using System.Data;
using System.IO;
using System.Linq;
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
        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_ListBoxHashCodes()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------
        //  FORM EVENTS
        //-------------------------------------------------------------------------------------------
        private void Frm_ListBoxHashCodes_Load(object sender, EventArgs e)
        {
            //Get text files
            string[] filesToAdd = Directory.GetFiles(Path.Combine(GlobalVariables.WorkingDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly).Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();

            //Update control
            ListBox_HashCodes.BeginUpdate();
            ListBox_HashCodes.Items.AddRange(filesToAdd);
            ListBox_HashCodes.EndUpdate();
            listCollection = filesToAdd;
        }

        //-------------------------------------------------------------------------------------------
        //  LISTBOX HASHCODES
        //-------------------------------------------------------------------------------------------
        private void ListBox_HashCodes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditTextHashCode();
        }

        //-------------------------------------------------------------------------------------------
        //  CONTEXT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_Edit_Click(object sender, EventArgs e)
        {
            EditTextHashCode();
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

                    //Add item to the listbox
                    ListBox_HashCodes.BeginUpdate();
                    ListBox_HashCodes.Items.Add(frmTextFileName.ReturnValue);
                    ListBox_HashCodes.EndUpdate();
                    listCollection = ListBox_HashCodes.Items.OfType<string>().ToArray();

                    //Get file path and create a new object
                    string projectFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", frmTextFileName.ReturnValue + ".etf");
                    EuroText_TextFile newTextFile = new EuroText_TextFile();

                    //Add languages to the text file.
                    for (int i = 0; i < GlobalVariables.CurrentProject.Languages.Count; i++)
                    {
                        string langaugeToAdd = GlobalVariables.CurrentProject.Languages[i];
                        newTextFile.Messages.Add(langaugeToAdd, string.Empty);
                    }

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
            if (ListBox_HashCodes.SelectedItems.Count > 0)
            {
                string[] itemsToDelete = ListBox_HashCodes.SelectedItems.OfType<string>().ToArray();

                DialogResult answerQuestion = MessageBox.Show(CommonFunctions.MultipleDeletionMessage("Are you sure you want to delete HashCodes", itemsToDelete), "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answerQuestion == DialogResult.Yes)
                {
                    //Crate trash folder
                    string trashFolder = Path.Combine(GlobalVariables.WorkingDirectory, "Messages_Trash");
                    Directory.CreateDirectory(trashFolder);

                    ListBox.SelectedObjectCollection selectedItems = ListBox_HashCodes.SelectedItems;
                    if (ListBox_HashCodes.SelectedIndex != -1)
                    {
                        ListBox_HashCodes.BeginUpdate();
                        for (int i = selectedItems.Count - 1; i >= 0; i--)
                        {
                            string filePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", selectedItems[i] + ".etf");
                            File.Move(filePath, Path.Combine(trashFolder, selectedItems[i] + ".etf"));
                            ListBox_HashCodes.Items.Remove(selectedItems[i]);
                        }
                        ListBox_HashCodes.EndUpdate();
                        listCollection = ListBox_HashCodes.Items.OfType<string>().ToArray();
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Rename_Click(object sender, EventArgs e)
        {
            if (ListBox_HashCodes.SelectedItems.Count == 1)
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
                        string sourceFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", ListBox_HashCodes.SelectedItem + ".etf");
                        string newFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", frmTextFileName.ReturnValue + ".etf");

                        //Move file
                        if (File.Exists(newFilePath))
                        {
                            MessageBox.Show(string.Join("", "'", frmTextFileName.ReturnValue, "' already exists please use another name!"), "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            File.Move(sourceFilePath, newFilePath);
                            ListBox_HashCodes.Items[ListBox_HashCodes.SelectedIndex] = frmTextFileName.ReturnValue;
                            listCollection = ListBox_HashCodes.Items.OfType<string>().ToArray();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Label '" + frmTextFileName.ReturnValue + "' uses invalid characters, only numbers, digits and underscore characters are allowed.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                    foreach (string selectedItem in ListBox_HashCodes.SelectedItems)
                    {
                        string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", selectedItem + ".etf");
                        if (File.Exists(textFilePath))
                        {
                            //Update property
                            EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);
                            textObjectData.Group = selectedGroup;

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
            string[] selectedFiles = ListBox_HashCodes.SelectedItems.OfType<string>().ToArray();

            Frm_TextStore storeText = new Frm_TextStore(selectedFiles);
            storeText.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal string[] listCollection;
        private void Textbox_SearchBarHashCodes_TextChanged(object sender, EventArgs e)
        {
            //Update control
            ListBox_HashCodes.BeginUpdate();
            ListBox_HashCodes.Items.Clear();
            if (string.IsNullOrEmpty(Textbox_SearchBarHashCodes.Text.Trim()))
            {
                ListBox_HashCodes.Items.AddRange(listCollection.ToArray());
            }
            else
            {
                for (int i = 0; i < listCollection.Length; i++)
                {
                    if (listCollection[i].IndexOf(Textbox_SearchBarHashCodes.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        ListBox_HashCodes.Items.Add(listCollection[i]);
                    }
                }

            }
            ListBox_HashCodes.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------
        //  FUNCTIONS
        //-------------------------------------------------------------------------------------------
        private void EditTextHashCode()
        {
            if (ListBox_HashCodes.SelectedItems.Count == 1)
            {
                string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", ListBox_HashCodes.SelectedItem.ToString() + ".etf");
                if (!File.Exists(textFilePath))
                {
                    DialogResult answer = MessageBox.Show(string.Join(" ", "", "Source file not found:", textFilePath, "\n\nDo you want to create it now?"), "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        //Create object
                        EuroText_TextFile newTextFile = new EuroText_TextFile();

                        //Write Object
                        ETXML_Writter filesWriter = new ETXML_Writter();
                        filesWriter.WriteTextFile(textFilePath, newTextFile);
                    }
                }

                //Show form
                if (File.Exists(textFilePath))
                {
                    Frm_TextEditor textEditor = new Frm_TextEditor(textFilePath)
                    {
                        Text = ListBox_HashCodes.SelectedItem.ToString()
                    };
                    textEditor.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Refresh_Click(object sender, EventArgs e)
        {
            //Get text files
            string[] filesToAdd = Directory.GetFiles(Path.Combine(GlobalVariables.WorkingDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly).Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();

            //Update control
            ListBox_HashCodes.BeginUpdate();
            ListBox_HashCodes.Items.Clear();
            ListBox_HashCodes.Items.AddRange(filesToAdd);
            ListBox_HashCodes.EndUpdate();
            listCollection = filesToAdd;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
