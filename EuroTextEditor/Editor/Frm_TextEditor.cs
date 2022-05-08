using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_TextEditor : Form
    {
        private readonly string filePath;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_TextEditor(string textFilePath)
        {
            InitializeComponent();
            filePath = textFilePath;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
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
            EXText_Reader rest = new EXText_Reader();
            EXText objText = rest.ReadEXTextFile(filePath);

            //Language
            Textbox_EnglishUS.Textbox.Text = objText.TextLanguage[0];
            Textbox_EnglishUK.Textbox.Text = objText.TextLanguage[1];
            Textbox_German.Textbox.Text = objText.TextLanguage[2];
            Textbox_French.Textbox.Text = objText.TextLanguage[3];
            Textbox_Spanish.Textbox.Text = objText.TextLanguage[4];
            Textbox_Italian.Textbox.Text = objText.TextLanguage[5];
            Textbox_Korean.Textbox.Text = objText.TextLanguage[6];
            Textbox_Japan.Textbox.Text = objText.TextLanguage[7];

            //Group
            Combobox_Group.SelectedItem = objText.Group;
            Combobox_OutputSection.SelectedValue = objText.OutputSection;
        }
    }
    //-------------------------------------------------------------------------------------------------------------------------------
}
