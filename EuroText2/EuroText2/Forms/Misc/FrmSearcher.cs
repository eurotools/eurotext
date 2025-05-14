using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmSearcher : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmSearcher()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmSearcher_Load(object sender, EventArgs e)
        {
            //Add languages
            Combobox_LookIn.BeginUpdate();
            Combobox_LookIn.Items.Add("All");
            Combobox_LookIn.Items.AddRange(GlobalVariables.CurrentProject.Languages.ToArray());
            Combobox_LookIn.EndUpdate();
            Combobox_LookIn.SelectedIndex = 0;

            //Select first item
            Combobox_LookField.SelectedIndex = 0;

            //Read ini file
            IniFile euroTextIni = new IniFile(GlobalVariables.EuroTextIni);
            Textbox_LookFor.Text = euroTextIni.Read("LastSearch", "Searcher");
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        //  MAIN BUTTONS
        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Search_Click(object sender, EventArgs e)
        {
            IniFile applicationIni = new IniFile(GlobalVariables.EuroTextIni);
            applicationIni.Write("LastSearch", Textbox_LookFor.Text.Trim(), "Searcher");

            if (!AsyncWorker.IsBusy)
            {
                if (lboxResults.Items.Count > 0)
                {
                    lboxResults.Items.Clear();
                }
                AsyncWorker.RunWorkerAsync();
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_StopSearch_Click(object sender, EventArgs e)
        {
            if (AsyncWorker.IsBusy)
            {
                AsyncWorker.CancelAsync();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_NewSearch_Click(object sender, EventArgs e)
        {
            if (AsyncWorker.IsBusy)
            {
                MessageBox.Show("There is a search in progress, please wait until finishes or stop it before starting a new search.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lboxResults.Items.Clear();
                Textbox_LookFor.Clear();
                lblSearchResults.Text = "0 Items";
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // BACKGROUND WORKER
        //-------------------------------------------------------------------------------------------------------------------------------
        private void AsyncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string query = Textbox_LookFor.Text.Trim();

            //Section to search
            string language = string.Empty;
            Combobox_LookIn.Invoke((MethodInvoker)delegate
            {
                language = Combobox_LookIn.SelectedItem.ToString();
            });

            int mode = 0;
            Combobox_LookField.Invoke((MethodInvoker)delegate
            {
                mode = Combobox_LookField.SelectedIndex;
            });

            //Chars options
            bool fullMatch = CheckBox_WholeWord.Checked;
            bool caseSensitive = CheckBox_MatchCase.Checked;

            //Call reader lib
            ETXML_Reader filesReader = new ETXML_Reader();

            //Get text messages 
            string messagesDirectory = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages");
            if (Directory.Exists(messagesDirectory))
            {
                string[] textMessages = Directory.GetFiles(messagesDirectory, "*.etf", SearchOption.TopDirectoryOnly);
                for (int i = 0; i < textMessages.Length; i++)
                {
                    //Check if we have to stop
                    if (AsyncWorker.CancellationPending)
                    {
                        break;
                    }

                    //Search for matches
                    string fileName = Path.GetFileNameWithoutExtension(textMessages[i]);
                    EuroText_TextFile objTextData = filesReader.ReadTextFile(textMessages[i]);

                    if (mode == 0) //Hash-Codes
                    {
                        if (fullMatch)
                        {
                            if (caseSensitive)
                            {
                                if (fileName.Equals(query))
                                {
                                    lboxResults.Invoke((MethodInvoker)delegate
                                    {
                                        lboxResults.Items.Add(fileName);
                                    });
                                }
                            }
                            else
                            {
                                if (fileName.Equals(query, StringComparison.OrdinalIgnoreCase))
                                {
                                    lboxResults.Invoke((MethodInvoker)delegate
                                    {
                                        lboxResults.Items.Add(fileName);
                                    });
                                }
                            }
                        }
                        else
                        {
                            if (caseSensitive)
                            {
                                if (fileName.Contains(query))
                                {
                                    lboxResults.Invoke((MethodInvoker)delegate
                                    {
                                        lboxResults.Items.Add(fileName);
                                    });
                                }
                            }
                            else
                            {
                                if (fileName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    lboxResults.Invoke((MethodInvoker)delegate
                                    {
                                        lboxResults.Items.Add(fileName);
                                    });
                                }
                            }
                        }
                    }
                    else if (mode == 1) //File Content
                    {
                        if (fullMatch)
                        {
                            if (caseSensitive)
                            {
                                if (language.Equals("All"))
                                {
                                    foreach (KeyValuePair<string, string> languageData in objTextData.Messages)
                                    {
                                        if (languageData.Value.Equals(query))
                                        {
                                            lboxResults.Invoke((MethodInvoker)delegate
                                            {
                                                lboxResults.Items.Add(fileName);
                                            });
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    if (objTextData.Messages.ContainsKey(language))
                                    {
                                        if (objTextData.Messages[language].Equals(query))
                                        {
                                            lboxResults.Invoke((MethodInvoker)delegate
                                            {
                                                lboxResults.Items.Add(fileName);
                                            });
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (language.Equals("All"))
                                {
                                    foreach (KeyValuePair<string, string> languageData in objTextData.Messages)
                                    {
                                        if (languageData.Value.Equals(query, StringComparison.OrdinalIgnoreCase))
                                        {
                                            lboxResults.Invoke((MethodInvoker)delegate
                                            {
                                                lboxResults.Items.Add(fileName);
                                            });
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    if (objTextData.Messages.ContainsKey(language))
                                    {
                                        if (objTextData.Messages[language].Equals(query, StringComparison.OrdinalIgnoreCase))
                                        {
                                            lboxResults.Invoke((MethodInvoker)delegate
                                            {
                                                lboxResults.Items.Add(fileName);
                                            });
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (caseSensitive)
                            {
                                if (language.Equals("All"))
                                {
                                    foreach (KeyValuePair<string, string> languageData in objTextData.Messages)
                                    {
                                        if (languageData.Value.Contains(query))
                                        {
                                            lboxResults.Invoke((MethodInvoker)delegate
                                            {
                                                lboxResults.Items.Add(fileName);
                                            });
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    if (objTextData.Messages.ContainsKey(language))
                                    {
                                        if (objTextData.Messages[language].Contains(query))
                                        {
                                            lboxResults.Invoke((MethodInvoker)delegate
                                            {
                                                lboxResults.Items.Add(fileName);
                                            });
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (language.Equals("All"))
                                {
                                    foreach (KeyValuePair<string, string> languageData in objTextData.Messages)
                                    {
                                        if (languageData.Value.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                                        {
                                            lboxResults.Invoke((MethodInvoker)delegate
                                            {
                                                lboxResults.Items.Add(fileName);
                                            });
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    if (objTextData.Messages.ContainsKey(language))
                                    {
                                        if (objTextData.Messages[language].IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                                        {
                                            lboxResults.Invoke((MethodInvoker)delegate
                                            {
                                                lboxResults.Items.Add(fileName);
                                            });
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (mode == 2) //Categories
                    {
                        string[] categories = CommonFunctions.GetFlagsLabels(objTextData.textFlags).Split('|');
                        if (fullMatch)
                        {
                            if (caseSensitive)
                            {
                                for (int j = 0; j < categories.Length; j++)
                                {
                                    if (categories[j].Equals(query))
                                    {
                                        lboxResults.Invoke((MethodInvoker)delegate
                                        {
                                            lboxResults.Items.Add(fileName);
                                        });
                                    }
                                }
                            }
                            else
                            {
                                for (int j = 0; j < categories.Length; j++)
                                {
                                    if (categories[j].Equals(query, StringComparison.OrdinalIgnoreCase))
                                    {
                                        lboxResults.Invoke((MethodInvoker)delegate
                                        {
                                            lboxResults.Items.Add(fileName);
                                        });
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (caseSensitive)
                            {
                                for (int j = 0; j < categories.Length; j++)
                                {
                                    if (categories[j].Contains(query))
                                    {
                                        lboxResults.Invoke((MethodInvoker)delegate
                                        {
                                            lboxResults.Items.Add(fileName);
                                        });
                                    }
                                }
                            }
                            else
                            {
                                for (int j = 0; j < categories.Length; j++)
                                {
                                    if (categories[j].IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                                    {
                                        lboxResults.Invoke((MethodInvoker)delegate
                                        {
                                            lboxResults.Items.Add(fileName);
                                        });
                                    }
                                }
                            }
                        }
                    }

                    //Update label
                    lboxResults.Invoke((MethodInvoker)delegate
                    {
                        lblSearchResults.Text = lboxResults.Items.Count + " Items";
                    });
                }
            }
            else
            {
                MessageBox.Show("Messages directory has not been found: " + messagesDirectory, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void LboxResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lboxResults.SelectedItem + ".etf");
            if (File.Exists(textFilePath))
            {
                using (FrmMainTextEditor editor = new FrmMainTextEditor(textFilePath))
                {
                    editor.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Context Menu
        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextEdit_Click(object sender, EventArgs e)
        {
            if (lboxResults.SelectedItems.Count == 1)
            {
                string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lboxResults.SelectedItem + ".etf");
                if (File.Exists(textFilePath))
                {
                    using (FrmMainTextEditor editor = new FrmMainTextEditor(textFilePath))
                    {
                        editor.ShowDialog();
                    }
                }
            }
            else if (lboxResults.SelectedItems.Count > 1)
            {
                //Get all selected items
                List<string> fileNames = new List<string>();
                for (int i = 0; i < lboxResults.SelectedItems.Count; i++)
                {
                    fileNames.Add(lboxResults.SelectedItems[i].ToString());
                }

                //Show multi editor
                FrmMainTextEditor_Multi multiEditor = new FrmMainTextEditor_Multi(fileNames.ToArray());
                multiEditor.ShowDialog();
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextEditCategories_Click(object sender, EventArgs e)
        {
            if (lboxResults.SelectedItems.Count > 0)
            {
                //Update TextFile
                string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lboxResults.SelectedItem + ".etf");
                if (File.Exists(textFilePath))
                {
                    //Show flags selector
                    using (FrmSetCategories categoriesEditor = new FrmSetCategories(lboxResults, 0))
                    {
                        categoriesEditor.ShowDialog();
                    }
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextEditGroups_Click(object sender, EventArgs e)
        {
            FrmMultSetGroup setGroup = new FrmMultSetGroup();
            if (setGroup.ShowDialog() == DialogResult.OK)
            {
                //Get the group that use user has selected
                string selectedGroup = setGroup.selectedTextGroup;

                //Call reader lib
                ETXML_Reader filesReader = new ETXML_Reader();
                ETXML_Writter filesWriter = new ETXML_Writter();

                for (int i = 0; i < lboxResults.Items.Count; i++)
                {
                    string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lboxResults.Items[i] + ".etf");
                    if (File.Exists(textFilePath))
                    {
                        //Update property
                        EuroText_TextFile textObjectData = filesReader.ReadTextFile(textFilePath);
                        textObjectData.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                        textObjectData.LastModifiedBy = GlobalVariables.EuroTextUser;
                        textObjectData.Group = selectedGroup;

                        //Write file again
                        filesWriter.WriteTextFile(textFilePath, textObjectData);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextCopyHashCode_Click(object sender, EventArgs e)
        {
            if (lboxResults.SelectedItems.Count == 1)
            {
                Clipboard.SetText(lboxResults.SelectedItem.ToString());
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemTextExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (string itemToWrite in lboxResults.Items)
                    {
                        string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", itemToWrite + ".etf");
                        outputFile.WriteLine(textFilePath);
                    }
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
