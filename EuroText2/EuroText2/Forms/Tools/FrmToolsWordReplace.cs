using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmToolsWordReplace : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmToolsWordReplace()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        //  FORM EVENTS
        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmToolsWordReplace_Load(object sender, EventArgs e)
        {
            foreach (string language in GlobalVariables.CurrentProject.Languages)
            {
                checkedListBox1.Items.Add(language);
            }

            //Read ini file
            IniFile euroTextIni = new IniFile(GlobalVariables.EuroTextIni);
            TextBoxOriginal.Text = euroTextIni.Read("OriginalString", "WordsReplacing");
            TextboxReplacement.Text = euroTextIni.Read("ReplacementString", "WordsReplacing");
            if (bool.TryParse(euroTextIni.Read("IgnoreCase", "WordsReplacing").Trim(), out bool status))
            {
                ChckOrdinalIgnore.Checked = status;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmToolsWordReplace_FormClosing(object sender, FormClosingEventArgs e)
        {
            IniFile applicationIni = new IniFile(GlobalVariables.EuroTextIni);
            applicationIni.Write("OriginalString", TextBoxOriginal.Text, "WordsReplacing");
            applicationIni.Write("ReplacementString", TextboxReplacement.Text, "WordsReplacing");
            applicationIni.Write("IgnoreCase", ChckOrdinalIgnore.Checked.ToString(), "WordsReplacing");
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        //  FORM BUTTONS
        //-------------------------------------------------------------------------------------------------------------------------------
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?\nThis action can not be undone.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Get text files
                string messagesFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages");
                if (Directory.Exists(messagesFilePath))
                {
                    string[] filesToAdd = Directory.GetFiles(messagesFilePath, "*.etf", SearchOption.TopDirectoryOnly);
                    ETXML_Reader filesReader = new ETXML_Reader();
                    ETXML_Writter filesWriter = new ETXML_Writter();

                    int numOfFilesModified = 0;
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
                                    if (ChckOrdinalIgnore.Checked)
                                    {
                                        if (objTextData.Messages[lang].IndexOf(TextBoxOriginal.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                                        {
                                            objTextData.Messages[lang] = Regex.Replace(objTextData.Messages[lang], TextBoxOriginal.Text, TextboxReplacement.Text, RegexOptions.IgnoreCase);
                                            saveFile = true;
                                        }
                                    }
                                    else if (objTextData.Messages[lang].Contains(TextBoxOriginal.Text))
                                    {
                                        objTextData.Messages[lang] = objTextData.Messages[lang].Replace(TextBoxOriginal.Text, TextboxReplacement.Text);
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
                    }

                    //Inform User
                    MessageBox.Show(string.Format("{0} Files has been modified.", numOfFilesModified), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        //  CONTEXT MENU
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
