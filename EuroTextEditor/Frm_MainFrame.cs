using EuroTextEditor.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_MainFrame : Form
    {
        internal readonly Frm_ListBoxHashCodes hashCodes;
        internal readonly Frm_ListBox_TextSections textSections;
        internal readonly Frm_ListBox_TextGroups textGroups;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_MainFrame()
        {
            InitializeComponent();

            //Initialize forms
            hashCodes = new Frm_ListBoxHashCodes(MenuItem_HashCodesForm);
            textSections = new Frm_ListBox_TextSections(MenuItem_TextSectionsForm);
            textGroups = new Frm_ListBox_TextGroups(MenuItem_TextGroupsForm);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_MainFrame_Shown(object sender, EventArgs e)
        {
            //Show forms
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockSettingsMainForm.xml");
            if (File.Exists(configFile))
            {
                DeserializeDockContent _deserializeDockContent = new DeserializeDockContent(DeserializeDockContent);
                dockPanel.LoadFromXml(configFile, _deserializeDockContent);
            }
            else
            {
                hashCodes.Show(dockPanel, DockState.Document);
                textSections.Show(dockPanel, DockState.DockLeft);
                textGroups.Show(textSections.Pane, DockAlignment.Bottom, 0.5);
            }

            //Update menus
            if (textGroups != null && textGroups.IsHidden)
            {
                MenuItem_TextGroupsForm.Checked = false;
            }
            if (textSections != null && textSections.IsHidden)
            {
                MenuItem_TextSectionsForm.Checked = false;
            }
            if (hashCodes != null && hashCodes.IsHidden)
            {
                MenuItem_HashCodesForm.Checked = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private IDockContent DeserializeDockContent(string persistString)
        {
            if (persistString == typeof(Frm_ListBoxHashCodes).ToString())
            {
                return hashCodes;
            }
            if (persistString == typeof(Frm_ListBox_TextSections).ToString())
            {
                return textSections;
            }
            if (persistString == typeof(Frm_ListBox_TextGroups).ToString())
            {
                return textGroups;
            }
            return null;
        }

        //-------------------------------------------------------------------------------------------
        //  MAINFORM
        //-------------------------------------------------------------------------------------------
        private void Frm_MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application INI
            IniFile applicationIni = new IniFile(Path.Combine(Application.StartupPath, "EuroText.ini"));
            applicationIni.Write("UserName", GlobalVariables.EuroTextUser, "Misc");
            applicationIni.Write("Last_Project_Opened", GlobalVariables.WorkingDirectory, "Misc");
            applicationIni.Write("HashTablesAdmin_Path", GlobalVariables.HashtablesAdminPath, "Settings");
            applicationIni.Write("includeDataInfoSheet", Checkbox_DataInfoSheet.Checked.ToString(), "MainForm");
            applicationIni.Write("includeFormatInfoSheet", Checkbox_FormatInfo.Checked.ToString(), "MainForm");
            applicationIni.Write("OutputFileName", Textbox_FileName.Text, "MainForm");

            //Dock conifg
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockSettingsMainForm.xml");
            dockPanel.SaveAsXml(configFile);
        }

        //-------------------------------------------------------------------------------------------
        //  MENU ITEM - FILE
        //-------------------------------------------------------------------------------------------
        private void MenuItem_OpenProject_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Update Global variable and restart
                GlobalVariables.WorkingDirectory = Path.GetDirectoryName(OpenFileDialog.FileName);

                //Restart application
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_NewProject_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ResetSettings_Click(object sender, EventArgs e)
        {
            hashCodes.DockPanel = dockPanel;
            hashCodes.IsFloat = false;
            hashCodes.IsHidden = false;
            hashCodes.Pane = dockPanel.Panes[0];
            hashCodes.DockState = DockState.Document;

            textSections.DockPanel = dockPanel;
            textSections.IsFloat = false;
            textSections.IsHidden = false;
            textSections.Pane = dockPanel.Panes[0];
            textSections.DockState = DockState.DockLeft;

            textGroups.DockPanel = dockPanel;
            textGroups.IsFloat = false;
            textGroups.IsHidden = false;
            textGroups.Show(textSections.Pane, DockAlignment.Bottom, 0.5);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-------------------------------------------------------------------------------------------
        //  OPTIONS SECTION
        //-------------------------------------------------------------------------------------------
        private void Button_Output_Click(object sender, EventArgs e)
        {
            //Ensure that the last output filepath still exists
            if (Directory.Exists(GlobalVariables.CurrentProject.SpreadSheetsDirectory))
            {
                Frm_SpreadsheetExporter exporterTask = new Frm_SpreadsheetExporter(this, Path.Combine(GlobalVariables.CurrentProject.SpreadSheetsDirectory, Textbox_FileName.Text), Checkbox_FormatInfo.Checked, Checkbox_DataInfoSheet.Checked);
                exporterTask.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_TextStore_Click(object sender, EventArgs e)
        {
            if (hashCodes != null && !hashCodes.IsHidden)
            {
                List<string> filesToModify = new List<string>();
                foreach (ListViewItem Item in hashCodes.UserControl_HashCodesListView.ListView_HashCodes.SelectedItems)
                {
                    filesToModify.Add(Item.Text.ToString());
                }

                Frm_TextStore storeText = new Frm_TextStore(filesToModify.ToArray());
                storeText.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_ExportHashCodes_Click(object sender, EventArgs e)
        {
            if (hashCodes != null && !hashCodes.IsHidden)
            {
                if (File.Exists(GlobalVariables.HashtablesAdminPath))
                {
                    Queue<string> hashcodes = new Queue<string>();
                    for (int i = 0; i < hashCodes.UserControl_HashCodesListView.ListView_HashCodes.Items.Count; i++)
                    {
                        hashcodes.Enqueue(hashCodes.UserControl_HashCodesListView.ListView_HashCodes.Items[i].Text.ToString());
                    }

                    while (hashcodes.Count > 0)
                    {
                        string commandLine = "/A HT_Text";
                        for (int i = 0; i < 600; i++)
                        {
                            if (hashcodes.Count > 0)
                            {
                                commandLine = commandLine + " " + hashcodes.Dequeue();
                            }
                            else
                            {
                                break;
                            }
                        }

                        //Run HT_Admin
                        Process HtAdmin = new Process();
                        HtAdmin.StartInfo.FileName = GlobalVariables.HashtablesAdminPath;
                        HtAdmin.StartInfo.Arguments = commandLine;
                        HtAdmin.Start();
                        HtAdmin.WaitForExit();
                    }
                }
                else
                {
                    MessageBox.Show("Could not find the HashTable Admin Tool, please set the file path under the project settings form.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_ProjectSettings_Click(object sender, EventArgs e)
        {
            Frm_ProjectForm projectSettings = new Frm_ProjectForm();
            projectSettings.ShowDialog();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
