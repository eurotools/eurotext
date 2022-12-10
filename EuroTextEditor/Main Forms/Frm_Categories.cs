using System;
using System.IO;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Categories : Form
    {
        private readonly ListView listControl;
        private readonly int filterFlags;
        private readonly bool modifyFiles;
        public int selectedFlags;
        internal Frm_ListBoxHashCodes parentFormToSync;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_Categories(ListView listViewControl, int userFilterFlags, Frm_ListBoxHashCodes formToSync, bool UpdateTextFiles = true)
        {
            InitializeComponent();
            listControl = listViewControl;
            modifyFiles = UpdateTextFiles;
            filterFlags = userFilterFlags;
            parentFormToSync = formToSync;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_Categories_Load(object sender, EventArgs e)
        {
            //Show labels
            for (int i = 0; i < 16; i++)
            {
                if (i < GlobalVariables.CurrentProject.Categories.Count)
                {
                    string controlText = "TextBox_Flag" + (i + 1);
                    if (GroupBox_Flags.Controls.ContainsKey(controlText))
                    {
                        if (GroupBox_Flags.Controls[controlText] is TextBox txtBox)
                        {
                            txtBox.Text = GlobalVariables.CurrentProject.Categories[i];
                        }
                    }
                }
            }

            //Initialize readers and check state var
            ETXML_Reader filesReader = new ETXML_Reader();
            CheckState defaultState = CheckState.Checked;

            if (listControl != null)
            {
                if (listControl.SelectedItems.Count > 1)
                {
                    defaultState = CheckState.Indeterminate;
                }

                //Read and check items
                for (int i = 0; i < listControl.SelectedItems.Count; i++)
                {
                    string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", listControl.SelectedItems[i].Text + ".etf");
                    if (File.Exists(textFilePath))
                    {
                        EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);
                        PrintFlags(defaultState, textObjectData.textFlags, listControl.SelectedItems.Count > 1);
                    }
                }
            }
            else
            {
                PrintFlags(defaultState, filterFlags, false);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void PrintFlags(CheckState defaultState, int flags, bool allowThreeStates)
        {
            for (int j = 0; j < 16; j++)
            {
                string controlText = "CheckBox_Flag" + (j + 1);
                if (GroupBox_Flags.Controls.ContainsKey(controlText) && GroupBox_Flags.Controls[controlText] is CheckBox chxBox)
                {
                    if (allowThreeStates)
                    {
                        chxBox.ThreeState = true;
                    }
                    if (((flags >> j) & 1) == 1)
                    {
                        chxBox.CheckState = defaultState;
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            //Update files and close
            if (modifyFiles)
            {
                ETXML_Writter filesWriter = new ETXML_Writter();
                ETXML_Reader filesReader = new ETXML_Reader();
                foreach (ListViewItem selectedItem in listControl.SelectedItems)
                {
                    string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", selectedItem.Text + ".etf");
                    if (File.Exists(textFilePath))
                    {
                        //Read file flags
                        EuroText_TextFile textObj = filesReader.ReadTextFile(textFilePath);

                        //Update Flags
                        GetFlags(ref textObj.textFlags);
                        selectedFlags = textObj.textFlags;

                        //Write file again
                        filesWriter.WriteTextFile(textFilePath, textObj);

                        //Update UI
                        string flagsLabels = CommonFunctions.GetFlagsLabels(textObj.textFlags);
                        selectedItem.SubItems[5].Text = flagsLabels;

                        //Sync listviews
                        if (parentFormToSync != null)
                        {
                            foreach (ListViewItem itemsToUpdate in parentFormToSync.UserControl_HashCodesListView.ListView_HashCodes.Items)
                            {
                                if (itemsToUpdate.Text.Equals(selectedItem.Text))
                                {
                                    itemsToUpdate.SubItems[5].Text = flagsLabels;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                GetFlags(ref selectedFlags);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void GetFlags(ref int flagsVariable)
        {
            //Check flag if was selected by the user
            for (int i = 0; i < 16; i++)
            {
                string controlText = "CheckBox_Flag" + (i + 1);
                if (GroupBox_Flags.Controls.ContainsKey(controlText))
                {
                    if (GroupBox_Flags.Controls[controlText] is CheckBox chxBox)
                    {
                        //Set this bit --ON--
                        if (chxBox.CheckState == CheckState.Checked)
                        {
                            flagsVariable |= (1 << i);
                        }

                        //Set this bit --OFF--
                        if (chxBox.CheckState == CheckState.Unchecked)
                        {
                            flagsVariable &= ~(1 << i);
                        }
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
