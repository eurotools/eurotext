using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmFontBuilder : Form
    {
        private const int MAX_CHAR_ARRAY = 5000;
        private static readonly List<int> CharArray = new List<int>(MAX_CHAR_ARRAY);
        private static int CharCount = 0;

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmFontBuilder()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmFontBuilder_Load(object sender, EventArgs e)
        {
            cbxLanguage.BeginUpdate();
            cbxLanguage.Items.AddRange(GlobalVariables.CurrentProject.Languages.ToArray());
            if (cbxLanguage.Items.Count > 0)
            {
                cbxLanguage.SelectedIndex = 0;
            }
            cbxLanguage.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnBuildRanges_Click(object sender, EventArgs e)
        {
            txtResults.Clear();
            ClearCharList();

            TimerForm TmrForm = new TimerForm();
            void work(BackgroundWorker bw, DoWorkEventArgs f)
            {
                ETXML_Reader filesReader = new ETXML_Reader();

                //Get language
                string SelectedLanguage = string.Empty;
                cbxLanguage.Invoke((MethodInvoker)delegate
                {
                    SelectedLanguage = cbxLanguage.SelectedItem.ToString();
                });

                //Check characters
                string[] filesToAdd = Directory.GetFiles(Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly);
                for (int i = 0; i < filesToAdd.Length; i++)
                {
                    EuroText_TextFile objText = filesReader.ReadTextFile(filesToAdd[i]);
                    if (objText.Messages.ContainsKey(SelectedLanguage))
                    {
                        string cellValue = objText.Messages[SelectedLanguage];
                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            foreach (char c in cellValue)
                            {
                                AddCharToList(c);
                            }
                        }
                    }

                    // Report progress
                    int progressPercentage = (int)((i + 1) * 100.0 / filesToAdd.Length);
                    bw.ReportProgress(progressPercentage, Path.GetFileNameWithoutExtension(filesToAdd[i]));
                }

                //Display results
                SortCharList();
                txtResults.Invoke((MethodInvoker)delegate
                {
                    BuildFontRanges(txtResults);
                });
            }
            TmrForm.SetWork(work);
            TmrForm.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void AddCharToList(int theChar)
        {
            if (CharCount >= MAX_CHAR_ARRAY) return;
            if (CharArray.Contains(theChar)) return;

            CharArray.Add(theChar);
            CharCount++;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ClearCharList()
        {
            CharArray.Clear();
            CharCount = 0;

            string defaultChars = " 0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ`!£$%^&*()_+=-{}[]:;'@#~<>,.//?|\\\"";
            foreach (char c in defaultChars)
            {
                AddCharToList(c);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void SortCharList()
        {
            CharArray.Sort();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BuildFontRanges(TextBox outputText)
        {
            if (CharCount <= 0) return;

            int offset = 0;
            int xCnt = 0;
            while ((offset + xCnt) < CharCount)
            {
                while ((offset + xCnt + 1) < CharCount && CharArray[offset + xCnt] + 1 == CharArray[offset + xCnt + 1])
                {
                    xCnt++;
                }

                if (xCnt == 0)
                {
                    outputText.Text += CharArray[offset] + ", ";
                    offset++;
                }
                else
                {
                    outputText.Text += CharArray[offset] + "-" + CharArray[offset + xCnt] + ", ";
                    offset += xCnt + 1;
                }

                xCnt = 0;
            }
        }

    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
