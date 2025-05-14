using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmToolRemoveMultiWhitespaces : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmToolRemoveMultiWhitespaces()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmToolRemoveMultiWhitespaces_Load(object sender, EventArgs e)
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
                        Regex regex = new Regex(" {2,}");

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
                                        string prevString = objTextData.Messages[lang];
                                        objTextData.Messages[lang] = regex.Replace(objTextData.Messages[lang], match =>
                                        {
                                            // No reemplazar si está precedido por ">" y seguido por "<B"
                                            int index = match.Index;
                                            string fullText = objTextData.Messages[lang];

                                            // Asegura que no estamos en el borde de la cadena
                                            if (index >= 1 && index + match.Length + 1 < fullText.Length)
                                            {
                                                string before = fullText.Substring(index - 1, 1); // ">"
                                                string after = fullText.Substring(index + match.Length, 2); // "<B"
                                                if (before == ">" && after == "<B")
                                                {
                                                    return match.Value; // conservalo tal cual
                                                }
                                            }

                                            return " "; // reemplazar por un solo espacio
                                        });

                                        //Check if needs to be saved.
                                        if (!prevString.Equals(objTextData.Messages[lang]))
                                        {
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
