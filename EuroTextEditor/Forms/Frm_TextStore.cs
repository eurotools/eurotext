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

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextStore_Shown(object sender, EventArgs e)
        {
            ETXML_Reader filesReader = new ETXML_Reader();

            //Update ListView Control
            ListView_TextStore.BeginUpdate();
            for (int i = 0; i < textFilesToEdit.Length; i++)
            {
                //Read file
                string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", textFilesToEdit[i] + ".etf");
                if (File.Exists(textFilePath))
                {
                    EuroText_TextFile objText = filesReader.ReadTextFile(textFilePath);

                    //Create new item
                    ListViewItem item = new ListViewItem(new[] { Path.GetFileNameWithoutExtension(textFilePath), objText.OutputSection, objText.Group, "", });
                    item.SubItems.AddRange(objText.Messages.Values.ToArray());

                    //Add item to listview
                    ListView_TextStore.Items.Add(item);
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
            if (ListView_TextStore.SelectedItems.Count == 1)
            {
                ETXML_Reader filesReader = new ETXML_Reader();

                //Read text file and show the editor
                string textFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", ListView_TextStore.SelectedItems[0].SubItems[0].Text + ".etf");
                if (File.Exists(textFilePath))
                {
                    Frm_TextEditor textEditor = new Frm_TextEditor(textFilePath)
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
