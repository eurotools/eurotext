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
    public partial class FrmProjectsCompare : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmProjectsCompare()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmProjectsCompare_Load(object sender, EventArgs e)
        {
            CommonFunctions.AddLanguagesToPreviewControl(tabControlProjectFiles);
            CommonFunctions.AddLanguagesToPreviewControl(tabControlExternalProject);

            //Add languages
            chkLanguages.BeginUpdate();
            chkLanguages.Items.AddRange(GlobalVariables.CurrentProject.Languages.ToArray());
            chkLanguages.EndUpdate();

            //Get all groups
            CommonFunctions.GroupsToCombobox(cbxOutputGroup);

            txtFlags.Enabled = chkSetFlags.Checked;
            cbxOutputGroup.Enabled = chkOverWriteGroup.Checked;
            txtOutSections.Enabled = chkOverwriteSections.Checked;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Exclude_Click(object sender, EventArgs e)
        {
            if (tabControlResults.SelectedIndex == 0)
            {
                RemoveSelectedItems(lbxFoundFiles);
            }
            else
            {
                RemoveSelectedItems(lbxNotFoundFiles);
            }
            UpdateTotalFiles();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ExportToList_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(saveFileDialog.FileName))
                {
                    //Get control
                    ListBox listControl = lbxFoundFiles;
                    if (tabControlResults.SelectedIndex == 1)
                    {
                        listControl = lbxNotFoundFiles;
                    }

                    //Save list
                    foreach (string itemToWrite in lbxFoundFiles.Items)
                    {
                        string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", itemToWrite + ".etf");
                        outputFile.WriteLine(textFilePath);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemCopyName_Click(object sender, EventArgs e)
        {
            //Get control
            ListBox listControl = lbxFoundFiles;
            if (tabControlResults.SelectedIndex == 1)
            {
                listControl = lbxNotFoundFiles;
            }

            if (listControl.SelectedItems.Count == 1)
            {
                Clipboard.SetText(listControl.SelectedItems[0].ToString());
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnProjectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtProjectToCheck.Text = folderBrowserDialog.SelectedPath;
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
        private void TabControlProjectFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonFunctions.SyncTabsSelection(tabControlProjectFiles, tabControlExternalProject);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TabControlExternalProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonFunctions.SyncTabsSelection(tabControlExternalProject, tabControlProjectFiles);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TabControlResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalFiles();
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
        private void TxtOutSections_Click(object sender, EventArgs e)
        {
            FrmTextOutSection outForm = new FrmTextOutSection(txtOutSections.Text.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries));
            if (outForm.ShowDialog() == DialogResult.OK)
            {
                txtOutSections.Text = outForm.selectedSections;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnRun_Click(object sender, EventArgs e)
        {
            TimerForm TmrForm = new TimerForm();
            void work(BackgroundWorker bw, DoWorkEventArgs f)
            {
                string[] myFiles = Directory.GetFiles(Path.Combine(GlobalVariables.WorkingDirectory, "Messages"), "*.etf", SearchOption.AllDirectories);
                string[] otherFiles = Directory.GetFiles(Path.Combine(txtProjectToCheck.Text, "Messages"), "*.etf", SearchOption.AllDirectories);

                ETXML_Reader readFiles = new ETXML_Reader();

                // Crear diccionario con nombre del archivo como clave y ruta completa como valor
                Dictionary<string, string> myFileDict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                foreach (string file in myFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    if (!myFileDict.ContainsKey(fileName))
                    {
                        myFileDict[fileName] = file;
                    }
                }

                for (int i = 0; i < otherFiles.Length; i++)
                {
                    string fileName = Path.GetFileNameWithoutExtension(otherFiles[i]);
                    if (myFileDict.TryGetValue(fileName, out string myFilePath))
                    {
                        EuroText_TextFile otherProjectFile = readFiles.ReadTextFile(otherFiles[i]);
                        EuroText_TextFile myFile = readFiles.ReadTextFile(myFilePath);

                        foreach (KeyValuePair<string, string> myMessages in myFile.Messages)
                        {
                            if (otherProjectFile.Messages.ContainsKey(myMessages.Key) && IsItemChecked(chkLanguages, myMessages.Key))
                            {
                                if (!otherProjectFile.Messages[myMessages.Key].Trim().Equals(myMessages.Value.Trim(), StringComparison.OrdinalIgnoreCase))
                                {
                                    lbxFoundFiles.Invoke((MethodInvoker)delegate
                                    {
                                        lbxFoundFiles.Items.Add(fileName);
                                    });
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        lbxFoundFiles.Invoke((MethodInvoker)delegate
                        {
                            lbxNotFoundFiles.Items.Add(fileName);
                        });
                    }

                    // Report progress
                    int progressPercentage = (int)((i + 1) * 100.0 / otherFiles.Length);
                    bw.ReportProgress(progressPercentage, Path.GetFileNameWithoutExtension(otherFiles[i]));

                    //Update count
                    tabControlResults.Invoke((MethodInvoker)delegate
                    {
                        UpdateTotalFiles();
                    });
                }
            }
            TmrForm.SetWork(work);
            TmrForm.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void LbxFoundFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxFoundFiles.SelectedItems.Count != 1) return;

            //My file
            string filePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", lbxFoundFiles.SelectedItems[0] + ".etf");
            if (File.Exists(filePath))
            {
                CommonFunctions.PreviewTextFile(tabControlProjectFiles, filePath);
            }

            //External file
            string externalFile = Path.Combine(txtProjectToCheck.Text, "Messages", lbxFoundFiles.SelectedItems[0] + ".etf");
            if (File.Exists(externalFile))
            {
                CommonFunctions.PreviewTextFile(tabControlExternalProject, externalFile);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void LbxNotFoundFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxNotFoundFiles.SelectedItems.Count != 1) return;

            //My file
            string filePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", lbxNotFoundFiles.SelectedItems[0] + ".etf");
            if (File.Exists(filePath))
            {
                CommonFunctions.PreviewTextFile(tabControlProjectFiles, filePath);
            }

            //External file
            string externalFile = Path.Combine(txtProjectToCheck.Text, "Messages", lbxNotFoundFiles.SelectedItems[0] + ".etf");
            if (File.Exists(externalFile))
            {
                CommonFunctions.PreviewTextFile(tabControlExternalProject, externalFile);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Helper methods
        //-------------------------------------------------------------------------------------------------------------------------------
        private void UpdateTotalFiles()
        {
            if (tabControlResults.SelectedIndex == 0)
            {
                lblTotalFiles.Text = "Total: " + lbxFoundFiles.Items.Count;
            }
            else
            {
                lblTotalFiles.Text = "Total: " + lbxNotFoundFiles.Items.Count;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnImportSelection_Click(object sender, EventArgs e)
        {
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

                //Get control
                ListBox listControl = lbxFoundFiles;
                tabControlResults.Invoke((MethodInvoker)delegate
                {
                    if (tabControlResults.SelectedIndex == 1)
                    {
                        listControl = lbxNotFoundFiles;
                    }
                });

                //Read import file
                int totalItemsToImport = 0;
                listControl.Invoke((MethodInvoker)delegate
                {
                    totalItemsToImport = listControl.SelectedItems.Count;
                });

                for (int index = 0; index < totalItemsToImport; index++)
                {
                    string hashcodeName = listControl.SelectedItems[index].ToString();
                    string filePathToImport = Path.Combine(txtProjectToCheck.Text, "Messages", hashcodeName + ".etf");
                    string newFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Messages", hashcodeName + ".etf");

                    //Check if we have to replace or not the file
                    if (File.Exists(newFilePath))
                    {
                        File.Delete(newFilePath);
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
                    }

                    // Report progress
                    int progressPercentage = (int)((index + 1) * 100.0 / totalItemsToImport);
                    bw.ReportProgress(progressPercentage, Path.GetFileNameWithoutExtension(newFilePath));
                }

                //Remove selection
                listControl.Invoke((MethodInvoker)delegate
                {
                    RemoveSelectedItems(listControl);
                });

                //Update totals
                tabControlResults.Invoke((MethodInvoker)delegate
                {
                    UpdateTotalFiles();
                });
            }
            TmrForm.SetWork(work);
            TmrForm.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void RemoveSelectedItems(ListBox listBox)
        {
            // Crear una lista temporal para evitar modificar la colección mientras se itera
            List<object> itemsToRemove = new List<object>();

            foreach (object selectedItem in listBox.SelectedItems)
            {
                itemsToRemove.Add(selectedItem);
            }

            // Eliminar los ítems seleccionados
            foreach (object item in itemsToRemove)
            {
                listBox.Items.Remove(item);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private bool IsItemChecked(CheckedListBox checklistBox, string itemName)
        {
            for (int i = 0; i < checklistBox.Items.Count; i++)
            {
                if (checklistBox.Items[i].ToString() == itemName)
                {
                    return checklistBox.GetItemChecked(i);
                }
            }

            return false;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
