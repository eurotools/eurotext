﻿using EuroTextEditor.Classes;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_ProjectForm : Form
    {
        private bool PromptToSave = true;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_ProjectForm()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_ProjectForm_Load(object sender, System.EventArgs e)
        {
            //Project settings
            Textbox_HashCodesDir.Text = GlobalVariables.CurrentProject.EuroLandHahCodesServPath;
            Textbox_MessagesDir.Text = GlobalVariables.CurrentProject.MessagesDirectory;
            Textbox_SpreadSheetsDir.Text = GlobalVariables.CurrentProject.SpreadSheetsDirectory;

            //Show all languages
            Listbox_Languages.BeginUpdate();
            Listbox_Languages.Items.AddRange(GlobalVariables.CurrentProject.Languages.ToArray());
            Listbox_Languages.EndUpdate();

            //Global Settings
            Textbox_HashTablesAdmin.Text = GlobalVariables.HashtablesAdminPath;
            Textbox_UserName.Text = GlobalVariables.EuroTextUser;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_ProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PromptToSave)
            {
                DialogResult messageAnswer = MessageBox.Show("Are you sure you wish to Quit Properties without saving?", "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageAnswer == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_MessagesDir_Click(object sender, System.EventArgs e)
        {
            folderBrowserDialog.Description = "Set messages folder.";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Textbox_MessagesDir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_SpreadSheetsDir_Click(object sender, System.EventArgs e)
        {
            folderBrowserDialog.Description = "Set spreadsheets output folder.";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Textbox_SpreadSheetsDir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_HashCodesDir_Click(object sender, System.EventArgs e)
        {
            folderBrowserDialog.Description = "Set hashcodes.h file folder.";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Textbox_HashCodesDir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_AddLanguage_Click(object sender, System.EventArgs e)
        {
            using (Frm_InputBox newGroupForm = new Frm_InputBox("New Language", "Enter the new language name.", ""))
            {
                if (newGroupForm.ShowDialog() == DialogResult.OK)
                {
                    if (!Listbox_Languages.Items.Contains(newGroupForm.ReturnValue) && !string.IsNullOrEmpty(newGroupForm.ReturnValue))
                    {
                        Listbox_Languages.Items.Add(newGroupForm.ReturnValue);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_DeleteLanguage_Click(object sender, System.EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = Listbox_Languages.SelectedItems;
            if (Listbox_Languages.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    Listbox_Languages.Items.Remove(selectedItems[i]);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Textbox_HashTablesAdmin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Textbox_HashTablesAdmin.Text = openFileDialog.FileName;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Textbox_UserName_DoubleClick(object sender, System.EventArgs e)
        {
            Textbox_UserName.Text = CommonFunctions.AskForUserName("");
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, System.EventArgs e)
        {
            //Update bool
            PromptToSave = false;

            //Update global variables
            GlobalVariables.CurrentProject.MessagesDirectory = Textbox_MessagesDir.Text;
            GlobalVariables.CurrentProject.SpreadSheetsDirectory = Textbox_SpreadSheetsDir.Text;
            GlobalVariables.CurrentProject.EuroLandHahCodesServPath = Textbox_HashCodesDir.Text;
            GlobalVariables.CurrentProject.Languages = Listbox_Languages.Items.OfType<string>().ToList();
            GlobalVariables.HashtablesAdminPath = Textbox_HashTablesAdmin.Text;
            GlobalVariables.EuroTextUser = Textbox_UserName.Text;

            //Update project file
            ETXML_Writter projectFileReader = new ETXML_Writter();
            projectFileReader.WriteProjectFile(Path.Combine(GlobalVariables.WorkingDirectory, "Project.etp"), GlobalVariables.CurrentProject);

            //Update application INI
            IniFile applicationIni = new IniFile(Path.Combine(Application.StartupPath, "EuroText.ini"));
            applicationIni.Write("HashTablesAdmin_Path", GlobalVariables.HashtablesAdminPath, "Settings");
            applicationIni.Write("UserName", GlobalVariables.EuroTextUser, "Misc");

            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}