using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Searcher : DockContent
    {
        //-------------------------------------------------------------------------------------------
        //  FORM EVENTS
        //-------------------------------------------------------------------------------------------
        public Frm_Searcher()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_Searcher_Load(object sender, EventArgs e)
        {
            //Add languages
            Combobox_LookIn.BeginUpdate();
            Combobox_LookIn.Items.Add("All");
            Combobox_LookIn.Items.AddRange(GlobalVariables.CurrentProject.Languages.ToArray());
            Combobox_LookIn.EndUpdate();
            Combobox_LookIn.SelectedIndex = 0;

            //Select first item
            Combobox_LookField.SelectedIndex = 0;

            //Hide other context menu items
            UserControl_HashCodesTable.MenuItem_Color.Visible = false;
            UserControl_HashCodesTable.MenuItem_EditNote.Visible = false;
            UserControl_HashCodesTable.MenuItem_MultiEditor.Visible = false;
            UserControl_HashCodesTable.MenuItem_New.Visible = false;
            UserControl_HashCodesTable.MenuItem_Refresh.Visible = false;
            UserControl_HashCodesTable.MenuItem_Delete.Visible = false;
            UserControl_HashCodesTable.MenuItem_Rename.Visible = false;
            UserControl_HashCodesTable.MenuItem_Separator1.Visible = false;
            UserControl_HashCodesTable.MenuItem_Separator2.Visible = false;
        }

        //-------------------------------------------------------------------------------------------
        //  MAIN BUTTONS
        //-------------------------------------------------------------------------------------------
        private void Button_Search_Click(object sender, EventArgs e)
        {
            if (!AsyncWorker.IsBusy)
            {
                if (UserControl_HashCodesTable.ListView_HashCodes.Items.Count > 0)
                {
                    UserControl_HashCodesTable.ListView_HashCodes.Items.Clear();
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
                MessageBox.Show("There is a search in progress, please wait until finishes or stop it before starting a new search.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UserControl_HashCodesTable.ListView_HashCodes.Items.Clear();
                Textbox_LookFor.Clear();
                Label_NumberOfItems.Text = "0 Items";
            }
        }

        //-------------------------------------------------------------------------------------------
        //  BACKGROUND WORKER
        //-------------------------------------------------------------------------------------------
        private void AsyncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string query = Textbox_LookFor.Text;

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
            string[] textMessages = Directory.GetFiles(Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly);
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

                if (mode == 1)
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
                                        UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                        {
                                            ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                            addedItem.BackColor = objTextData.RowColor;
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
                                        UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                        {
                                            ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                            addedItem.BackColor = objTextData.RowColor;
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
                                        UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                        {
                                            ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                            addedItem.BackColor = objTextData.RowColor;
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
                                        UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                        {
                                            ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                            addedItem.BackColor = objTextData.RowColor;
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
                                        UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                        {
                                            ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                            addedItem.BackColor = objTextData.RowColor;
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
                                        UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                        {
                                            ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                            addedItem.BackColor = objTextData.RowColor;
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
                                        UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                        {
                                            ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                            addedItem.BackColor = objTextData.RowColor;
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
                                        UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                        {
                                            ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                            addedItem.BackColor = objTextData.RowColor;
                                        });
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (fullMatch)
                    {
                        if (caseSensitive)
                        {
                            if (fileName.Equals(query))
                            {
                                UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                {
                                    ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                    addedItem.BackColor = objTextData.RowColor;
                                });
                            }
                        }
                        else
                        {
                            if (fileName.Equals(query, StringComparison.OrdinalIgnoreCase))
                            {
                                UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                {
                                    ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                    addedItem.BackColor = objTextData.RowColor;
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
                                UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                {
                                    ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                    addedItem.BackColor = objTextData.RowColor;
                                });
                            }
                        }
                        else
                        {
                            if (fileName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                UserControl_HashCodesTable.ListView_HashCodes.Invoke((MethodInvoker)delegate
                                {
                                    ListViewItem addedItem = UserControl_HashCodesTable.ListView_HashCodes.Items.Add(new ListViewItem(new[] { fileName, objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, objTextData.Notes }));
                                    addedItem.BackColor = objTextData.RowColor;
                                });
                            }
                        }
                    }
                }

                Label_NumberOfItems.Text = UserControl_HashCodesTable.ListView_HashCodes.Items.Count + " Items";
            }

        }

        //-------------------------------------------------------------------------------------------------------------------------------
    }
}
