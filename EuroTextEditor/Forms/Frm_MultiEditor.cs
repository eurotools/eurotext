using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_TextStore : Form
    {
        private readonly string[] textFilesToEdit;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_TextStore(string[] filesToModify)
        {
            InitializeComponent();
            Combobox_Section.SelectedIndex = 0;
            textFilesToEdit = filesToModify;
        }

        //-------------------------------------------------------------------------------------------
        //  FORM EVENTS
        //-------------------------------------------------------------------------------------------
        private void Frm_TextStore_Shown(object sender, EventArgs e)
        {
            ETXML_Reader filesReader = new ETXML_Reader();

            //Add languages to the combobox
            Combobox_Section.BeginUpdate();
            Combobox_Section.Items.AddRange(GlobalVariables.CurrentProject.Languages.ToArray());
            Combobox_Section.EndUpdate();

            //Add columns to the listview
            ListView_TextStore.BeginUpdate();
            for (int i = 0; i < GlobalVariables.CurrentProject.Languages.Count; i++)
            {
                ColumnHeader newCol = ListView_TextStore.Columns.Add(GlobalVariables.CurrentProject.Languages[i]);
                newCol.Width = 150;
            }

            //Update ListView Control
            for (int i = 0; i < textFilesToEdit.Length; i++)
            {
                //Read file
                string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", textFilesToEdit[i] + ".etf");
                if (File.Exists(textFilePath))
                {
                    EuroText_TextFile objText = filesReader.ReadTextFile(textFilePath);

                    //Create new item
                    ListViewItem item = new ListViewItem(new[] { Path.GetFileNameWithoutExtension(textFilePath), objText.OutputSection, objText.Group, "", });
                    for (int j = 0; j < GlobalVariables.CurrentProject.Languages.Count; j++)
                    {
                        string language = GlobalVariables.CurrentProject.Languages[j];
                        if (objText.Messages.ContainsKey(language))
                        {
                            item.SubItems.Add(objText.Messages[language]);
                        }
                    }

                    //Add item to listview
                    ListView_TextStore.Items.Add(item);
                    item.BackColor = objText.RowColor;
                }
            }
            ListView_TextStore.EndUpdate();

            //Resize columns
            if (ListView_TextStore.Items.Count > 0)
            {
                ListView_TextStore.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                ListView_TextStore.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                ListView_TextStore.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Combobox_Section_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedIndex = Combobox_Section.SelectedIndex - 1;
            for (int i = 0; i < 8; i++)
            {
                int size = 150;
                bool autoResize = false;

                //Check if user wants to see only one column or not
                if (Combobox_Section.SelectedIndex > 0)
                {
                    if (i != selectedIndex)
                    {
                        size = 0;
                    }
                    else
                    {
                        autoResize = true;
                    }
                }

                //Resize column
                ListView_TextStore.Columns[i + 4].Width = size;
                if (autoResize)
                {
                    ListView_TextStore.Columns[i + 4].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ListView_TextStore_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditTextObjects();
        }

        //-------------------------------------------------------------------------------------------
        //  CONTEXT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_Edit_Click(object sender, EventArgs e)
        {
            EditTextObjects();
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
                    foreach (ListViewItem selectedItem in ListView_TextStore.SelectedItems)
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
        private void MenuItem_SetSection_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------
        //  FUNCTIONS
        //-------------------------------------------------------------------------------------------
        private void EditTextObjects()
        {
            if (ListView_TextStore.SelectedItems.Count == 1)
            {
                ETXML_Reader filesReader = new ETXML_Reader();

                //Read text file and show the editor
                string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", ListView_TextStore.SelectedItems[0].SubItems[0].Text + ".etf");
                if (File.Exists(textFilePath))
                {
                    Frm_TextEditor textEditor = new Frm_TextEditor(textFilePath, ListView_TextStore.SelectedItems[0])
                    {
                        Text = ListView_TextStore.SelectedItems[0].SubItems[0].Text
                    };
                    textEditor.ShowDialog();
                }

                //Read file
                EuroText_TextFile objText = filesReader.ReadTextFile(textFilePath);

                //Create new item
                ListView_TextStore.BeginUpdate();
                ListView_TextStore.SelectedItems[0].SubItems.Clear();
                ListView_TextStore.SelectedItems[0].Text = Path.GetFileNameWithoutExtension(textFilePath);
                ListView_TextStore.SelectedItems[0].SubItems.AddRange(new[] { objText.OutputSection, objText.Group, "", });
                ListView_TextStore.SelectedItems[0].SubItems.AddRange(objText.Messages.Values.ToArray());
                ListView_TextStore.EndUpdate();
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
