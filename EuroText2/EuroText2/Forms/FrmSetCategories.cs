﻿using System;
using System.IO;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmSetCategories : Form
    {
        private readonly ListBox listControl;
        private readonly int filterFlags;
        private readonly bool modifyFiles;
        public int selectedFlags;

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmSetCategories(ListBox listViewControl, int userFilterFlags, bool UpdateTextFiles = true)
        {
            InitializeComponent();
            listControl = listViewControl;
            modifyFiles = UpdateTextFiles;
            filterFlags = userFilterFlags;
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
                    string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", listControl.SelectedItems[i] + ".etf");
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
                foreach (string selectedItem in listControl.SelectedItems)
                {
                    string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", selectedItem + ".etf");
                    if (File.Exists(textFilePath))
                    {
                        //Read file flags
                        EuroText_TextFile textObj = filesReader.ReadTextFile(textFilePath);

                        //Update Flags
                        GetFlags(ref textObj.textFlags);
                        selectedFlags = textObj.textFlags;

                        //Write file again
                        filesWriter.WriteTextFile(textFilePath, textObj);
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
