using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmImportFiles : Form
    {
        private readonly Dictionary<string, string> fileMap = new Dictionary<string, string>();

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmImportFiles()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmImportFiles_Load(object sender, EventArgs e)
        {
            //Get all groups
            CommonFunctions.GroupsToCombobox(cbxOutputGroup);

            txtFlags.Enabled = chkSetFlags.Checked;
            cbxOutputGroup.Enabled = chkOverWriteGroup.Checked;
            txtOutSections.Enabled = chkOverwriteSections.Checked;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TxtOutSections_Click(object sender, EventArgs e)
        {
            FrmTextOutSection outForm = new FrmTextOutSection(txtOutSections.Text.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries));
            if (outForm.ShowDialog() == DialogResult.OK)
            {
                txtOutSections.Text = outForm.selectedSections;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ChkSetFlags_CheckedChanged(object sender, EventArgs e)
        {
            txtFlags.Enabled = chkSetFlags.Checked;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ChkOverWriteGroup_CheckedChanged(object sender, EventArgs e)
        {
            cbxOutputGroup.Enabled = chkOverWriteGroup.Checked;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ChkOverwriteSections_CheckedChanged(object sender, EventArgs e)
        {
            txtOutSections.Enabled = chkOverwriteSections.Checked;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;

                //Add files to list
                fileMap.Clear();
                string[] filePaths = File.ReadAllLines(txtFileName.Text);
                chkListFilesToImport.BeginUpdate();
                chkListFilesToImport.Items.Clear();
                foreach (string fullPath in filePaths)
                {
                    string fileName = Path.GetFileNameWithoutExtension(fullPath);
                    chkListFilesToImport.Items.Add(fileName);
                    fileMap[fileName] = fullPath;
                }
                chkListFilesToImport.EndUpdate();
                MenuItemCheckAll_Click(sender, e);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnStartImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileName.Text) || !File.Exists(txtFileName.Text))
            {
                MessageBox.Show("File not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int numOfFilesModified = 0;

                TimerForm TmrForm = new TimerForm();
                void work(BackgroundWorker bw, DoWorkEventArgs f)
                {
                    ETXML_Reader readerMethods = new ETXML_Reader();
                    ETXML_Writter writterMethods = new ETXML_Writter();

                    //Read sections
                    EuroText_TextSections sectionsFileText = null;
                    if (chkOverwriteSections.Checked)
                    {
                        string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
                        sectionsFileText = readerMethods.ReadTextSectionsFile(textSectionsFilePath);
                    }

                    //Read import file
                    int totalItemsToImport = chkListFilesToImport.CheckedItems.Count;
                    for (int index = 0; index < totalItemsToImport; index++)
                    {
                        string hashcodeName = chkListFilesToImport.CheckedItems[index].ToString();
                        string filePathToImport = fileMap[hashcodeName];
                        string newFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", Path.GetFileName(filePathToImport));

                        //Check if we have to replace or not the file
                        if (File.Exists(newFilePath))
                        {
                            if (chkOverwriteFiles.Checked)
                            {
                                File.Delete(newFilePath);
                            }
                            else
                            {
                                continue;
                            }
                        }

                        //Modify or just copy...
                        if (chkSetFlags.Checked || chkOverWriteGroup.Checked || chkOverwriteSections.Checked)
                        {
                            EuroText_TextFile textData = readerMethods.ReadTextFile(filePathToImport);
                            if (chkSetFlags.Checked)
                            {
                                textData.textFlags = int.Parse(txtFlags.Tag.ToString());
                            }
                            cbxOutputGroup.Invoke((MethodInvoker)delegate
                            {
                                if (chkOverWriteGroup.Checked && cbxOutputGroup.SelectedItem != null)
                                {
                                    textData.Group = cbxOutputGroup.SelectedItem.ToString();

                                }
                            });
                            if (chkOverwriteSections.Checked)
                            {
                                string[] outputSections = txtOutSections.Text.Split(';');
                                textData.OutputSection = new string[outputSections.Length];
                                for (int i = 0; i < outputSections.Length; i++)
                                {
                                    textData.OutputSection[i] = sectionsFileText.TextSections.FirstOrDefault(x => x.Value == outputSections[i]).Key;
                                }
                            }
                            writterMethods.WriteTextFile(newFilePath, textData);
                        }
                        else
                        {
                            File.Copy(filePathToImport, newFilePath);
                            numOfFilesModified++;
                        }

                        // Report progress
                        int progressPercentage = (int)((index + 1) * 100.0 / totalItemsToImport);
                        bw.ReportProgress(progressPercentage, Path.GetFileNameWithoutExtension(newFilePath));
                    }
                }
                TmrForm.SetWork(work);
                TmrForm.ShowDialog();

                //Inform User
                MessageBox.Show(string.Format("{0} Files has been modified.", numOfFilesModified), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TxtFlags_Click(object sender, EventArgs e)
        {
            int selectedFlags = int.Parse(txtFlags.Tag.ToString());
            using (FrmSetCategories setCategories = new FrmSetCategories(null, selectedFlags, false))
            {
                if (setCategories.ShowDialog() == DialogResult.OK)
                {
                    txtFlags.Tag = setCategories.selectedFlags;
                    txtFlags.Text = CommonFunctions.GetFlagsLabels(setCategories.selectedFlags);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Context menu
        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemCheckAll_Click(object sender, EventArgs e)
        {
            CommonFunctions.CheckListCheckAll(chkListFilesToImport);
            lblTotalFiles.Text = "Total: " + chkListFilesToImport.CheckedItems.Count;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemUncheckAll_Click(object sender, EventArgs e)
        {
            CommonFunctions.CheckListUncheckAll(chkListFilesToImport);
            lblTotalFiles.Text = "Total: " + chkListFilesToImport.CheckedItems.Count;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemInvert_Click(object sender, EventArgs e)
        {
            CommonFunctions.CheckListInvertSelection(chkListFilesToImport);
            lblTotalFiles.Text = "Total: " + chkListFilesToImport.CheckedItems.Count;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemCopyName_Click(object sender, EventArgs e)
        {
            if (chkListFilesToImport.SelectedItems.Count == 1)
            {
                Clipboard.SetText(chkListFilesToImport.SelectedItem.ToString());
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ChkListFilesToImport_Click(object sender, EventArgs e)
        {
            lblTotalFiles.Text = "Total: " + chkListFilesToImport.CheckedItems.Count;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
