using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmToolTrim : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmToolTrim()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmToolTrim_Load(object sender, EventArgs e)
        {
            foreach (string language in GlobalVariables.CurrentProject.Languages)
            {
                checkedListBox1.Items.Add(language);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnOK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?\nThis action can not be undone.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int numOfFilesModified = 0;

                TimerForm TmrForm = new TimerForm();
                void work(BackgroundWorker bw, DoWorkEventArgs f)
                {
                    //Get text files
                    string messagesFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages");
                    if (Directory.Exists(messagesFilePath))
                    {
                        string[] filesToAdd = Directory.GetFiles(messagesFilePath, "*.etf", SearchOption.TopDirectoryOnly);
                        ETXML_Reader filesReader = new ETXML_Reader();
                        ETXML_Writter filesWriter = new ETXML_Writter();

                        for (int i = 0; i < filesToAdd.Length; i++)
                        {
                            //Add item if required
                            EuroText_TextFile objTextData = filesReader.ReadTextFile(filesToAdd[i]);
                            bool saveFile = false;

                            for (int itemIndex = 0; itemIndex < checkedListBox1.Items.Count; itemIndex++)
                            {
                                if (checkedListBox1.GetItemChecked(itemIndex))
                                {
                                    string lang = checkedListBox1.Items[itemIndex].ToString();
                                    if (objTextData.Messages.ContainsKey(lang) && !string.IsNullOrEmpty(objTextData.Messages[lang]))
                                    {
                                        if (objTextData.Messages[lang].StartsWith(" ") && chckTrimStart.Checked)
                                        {
                                            objTextData.Messages[lang] = objTextData.Messages[lang].TrimStart();
                                            saveFile = true;
                                        }
                                        if (objTextData.Messages[lang].EndsWith(" ") && chckTrimEnd.Checked)
                                        {
                                            objTextData.Messages[lang] = objTextData.Messages[lang].TrimEnd();
                                            saveFile = true;
                                        }
                                    }
                                }
                            }

                            //Save file if required
                            if (saveFile)
                            {
                                filesWriter.WriteTextFile(filesToAdd[i], objTextData);
                                numOfFilesModified++;
                            }

                            // Report progress
                            int progressPercentage = (int)((i + 1) * 100.0 / filesToAdd.Length);
                            bw.ReportProgress(progressPercentage, Path.GetFileNameWithoutExtension(filesToAdd[i]));
                        }
                    }
                }
                TmrForm.SetWork(work);
                TmrForm.ShowDialog();

                //Inform User
                MessageBox.Show(string.Format("{0} Files has been modified.", numOfFilesModified), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_CheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_UncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
