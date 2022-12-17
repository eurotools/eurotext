using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_TextEditor_Multi : Form
    {
        private readonly string[] hashCodesNames;
        private bool PromptSave = true;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_TextEditor_Multi(string[] fileNames)
        {
            InitializeComponent();
            hashCodesNames = fileNames;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextEditor_Multi_Load(object sender, EventArgs e)
        {
            ListBox_FilesToBeModified.BeginUpdate();
            ListBox_FilesToBeModified.Items.AddRange(hashCodesNames);
            ListBox_FilesToBeModified.EndUpdate();

            //Update counter
            GroupBox_FilesToBeModified.Text = hashCodesNames.Length + " Files";

            ETXML_Reader filesReader = new ETXML_Reader();
            EuroText_TextFile objText = filesReader.ReadTextFile(Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", hashCodesNames[0] + ".etf"));
            EuroText_TextSections sectionsFileText = filesReader.ReadTextSectionsFile(Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf"));

            //Group and Output Section
            userControl_TextOptions1.Combobox_Group.SelectedItem = objText.Group;
            List<string> outputSections = new List<string>();
            for (int i = 0; i < objText.OutputSection.Length; i++)
            {
                if (sectionsFileText.TextSections.ContainsKey(objText.OutputSection[i]))
                {
                    outputSections.Add(sectionsFileText.TextSections[objText.OutputSection[i]]);
                }
            }
            userControl_TextOptions1.Textbox_OutputSections.Text = string.Join(";", outputSections.ToArray());

            //Others
            userControl_TextOptions1.CheckBox_TextDead.Checked = Convert.ToBoolean(objText.DeadText);
            userControl_TextOptions1.Numeric_MaxChars.Value = objText.MaxNumOfChars;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextEditor_Multi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PromptSave)
            {
                DialogResult diagResult = MessageBox.Show("Are you sure you wish to quit without saving?", "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diagResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            ETXML_Reader filesReader = new ETXML_Reader();
            string textSectionsFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "SystemFiles", "TextSections.etf");
            EuroText_TextSections sectionsFileText = filesReader.ReadTextSectionsFile(textSectionsFilePath);

            PromptSave = false;
            for (int i = 0; i < ListBox_FilesToBeModified.Items.Count; i++)
            {
                string filePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", ListBox_FilesToBeModified.Items[i] + ".etf");

                //New object

                EuroText_TextFile objText = filesReader.ReadTextFile(filePath);

                //Group and Output Section
                if (userControl_TextOptions1.Combobox_Group.SelectedItem != null)
                {
                    objText.Group = userControl_TextOptions1.Combobox_Group.SelectedItem.ToString();
                }

                //Others
                objText.DeadText = Convert.ToInt32(userControl_TextOptions1.CheckBox_TextDead.Checked);
                objText.MaxNumOfChars = (int)userControl_TextOptions1.Numeric_MaxChars.Value;
                string[] outputSections = userControl_TextOptions1.Textbox_OutputSections.Text.Split(';');
                objText.OutputSection = new string[outputSections.Length];
                for (int j = 0; j < outputSections.Length; j++)
                {
                    objText.OutputSection[j] = sectionsFileText.TextSections.FirstOrDefault(x => x.Value == outputSections[j]).Key;
                }

                //Update properties and listview
                objText.LastModified = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                objText.LastModifiedBy = GlobalVariables.EuroTextUser;

                ETXML_Writter filesWriter = new ETXML_Writter();
                filesWriter.WriteTextFile(filePath, objText);
            }
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
