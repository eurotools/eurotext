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
    public partial class Frm_TextEditor : Form
    {
        private readonly string filePath;
        private EuroText_TextFile objText;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_TextEditor(string textFilePath)
        {
            InitializeComponent();
            filePath = textFilePath;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_TextEditor_Load(object sender, EventArgs e)
        {
            //Get all groups
            string[] textGroup = File.ReadAllLines(@"C:\Users\Jordi Martinez\Desktop\EuroTextEditor\SystemFiles\Groups.txt");
            Combobox_Group.Items.AddRange(textGroup);
            if (Combobox_Group.Items.Count > 0)
            {
                Combobox_Group.SelectedIndex = 0;
            }

            //Get all output levels and sections
            string[] outLevels = File.ReadAllLines(@"C:\Users\Jordi Martinez\Desktop\EuroTextEditor\SystemFiles\OutputLevels.txt");
            string[] outSections = File.ReadAllLines(@"C:\Users\Jordi Martinez\Desktop\EuroTextEditor\SystemFiles\TextSections.txt");
            Dictionary<string, string> sectionsAndLevels = new Dictionary<string, string> { { "", "" } };
            for (int i = 0; i < outSections.Length; i++)
            {
                sectionsAndLevels.Add(outLevels[i], outSections[i]);
            }
            Combobox_OutputSection.DataSource = new BindingSource(sectionsAndLevels, null);
            Combobox_OutputSection.DisplayMember = "Key";
            Combobox_OutputSection.ValueMember = "Value";

            //New object
            ETXML_Reader filesReader = new ETXML_Reader();
            objText = filesReader.ReadTextFile(filePath);

            if (GlobalVariables.CurrentProject.Languages.Count > 0)
            {
                foreach (string languageMessage in GlobalVariables.CurrentProject.Languages)
                {
                    UserControl_TextEditor langEditor = new UserControl_TextEditor();
                    langEditor.Textbox.Text = objText.Messages[languageMessage];

                    TabPage LangaugeTab = new TabPage
                    {
                        Text = languageMessage,
                        Name = "TabPage_" + languageMessage
                    };
                    LangaugeTab.Controls.Add(langEditor);
                    langEditor.Dock = DockStyle.Fill;
                    TabControl_Messages.TabPages.Add(LangaugeTab);
                }
            }
            else
            {
                TabControl_Messages.Visible = false;
            }


            //Group and Output Section
            Combobox_Group.SelectedItem = objText.Group;
            Combobox_OutputSection.SelectedValue = objText.OutputSection;

            //Others
            CheckBox_TextDead.Checked = Convert.ToBoolean(objText.DeadText);
            Numeric_MaxChars.Value = objText.MaxNumOfChars;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            //Update text
            foreach (TabPage tabInfo in TabControl_Messages.TabPages)
            {
                //Get message data
                string language = tabInfo.Text;
                string messageData = tabInfo.Controls.Cast<UserControl_TextEditor>().First().Textbox.Text;

                //Update controls
                objText.Messages[language] = messageData;
            }

            //Group and Output Section
            if (Combobox_Group.SelectedItem != null)
            {
                objText.Group = Combobox_Group.SelectedItem.ToString();
            }
            if (Combobox_OutputSection.SelectedValue != null)
            {
                objText.OutputSection = Combobox_OutputSection.SelectedValue.ToString();
            }

            //Others
            objText.DeadText = Convert.ToInt32(CheckBox_TextDead.Checked);
            objText.MaxNumOfChars = (int)Numeric_MaxChars.Value;

            ETXML_Writter filesWriter = new ETXML_Writter();
            filesWriter.WriteTextFile(filePath, objText);

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
