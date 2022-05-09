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
        private EXText objText;

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
            EXText_Reader filesReader = new EXText_Reader();
            objText = filesReader.ReadEXTextFile(filePath);

            //Language
            Textbox_EnglishUS.Textbox.Text = objText.TextLanguage[0];
            Textbox_EnglishUK.Textbox.Text = objText.TextLanguage[1];
            Textbox_German.Textbox.Text = objText.TextLanguage[2];
            Textbox_French.Textbox.Text = objText.TextLanguage[3];
            Textbox_Spanish.Textbox.Text = objText.TextLanguage[4];
            Textbox_Italian.Textbox.Text = objText.TextLanguage[5];
            Textbox_Korean.Textbox.Text = objText.TextLanguage[6];
            Textbox_Japan.Textbox.Text = objText.TextLanguage[7];

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
            objText.TextLanguage[0] = Textbox_EnglishUS.Textbox.Text;
            objText.TextLanguage[1] = Textbox_EnglishUK.Textbox.Text;
            objText.TextLanguage[2] = Textbox_German.Textbox.Text;
            objText.TextLanguage[3] = Textbox_French.Textbox.Text;
            objText.TextLanguage[4] = Textbox_Spanish.Textbox.Text;
            objText.TextLanguage[5] = Textbox_Italian.Textbox.Text;
            objText.TextLanguage[6] = Textbox_Korean.Textbox.Text;
            objText.TextLanguage[7] = Textbox_Japan.Textbox.Text;

            //Group and Output Section
            objText.Group = Combobox_Group.SelectedItem.ToString();
            objText.OutputSection = Combobox_OutputSection.SelectedItem.ToString();

            //Others
            objText.DeadText = Convert.ToInt32(CheckBox_TextDead);
            objText.MaxNumOfChars = (int)Numeric_MaxChars.Value;

            EXText_Writer filesWriter = new EXText_Writer();
            filesWriter.EXTextObjectToTextFile(objText, filePath);

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
