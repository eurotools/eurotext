﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroTextEditor.Tools
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Tool_ReplaceWords : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_Tool_ReplaceWords()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_Tool_ReplaceWords_Load(object sender, EventArgs e)
        {
            foreach (string language in GlobalVariables.CurrentProject.Languages)
            {
                checkedListBox1.Items.Add(language);
            }
        }

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
                }
            }
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