using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EuroText2
{
    public enum TextEffectAssistantMode
    {
        Teletype,
        TeletypeFade,
        CircularText,
        RisingText,
        RandomFontColour
    }

    public partial class Frm_TextEffectAssistant : Form
    {
        private readonly TextEffectAssistantMode effectMode;

        public string EffectText { get; private set; }
        public string EndText { get; private set; }

        public Frm_TextEffectAssistant(TextEffectAssistantMode mode)
        {
            effectMode = mode;
            EffectText = string.Empty;
            EndText = string.Empty;
            InitializeComponent();
            ConfigureAssistant();
        }

        private void ConfigureAssistant()
        {
            CheckBox_Parameter1.Visible = false;
            CheckBox_Parameter2.Visible = false;
            CheckBox_Parameter3.Visible = false;
            Numeric_Parameter1.Visible = false;
            Numeric_Parameter2.Visible = false;
            Numeric_Parameter3.Visible = false;

            switch (effectMode)
            {
                case TextEffectAssistantMode.Teletype:
                    Text = "Teletype Text";
                    Label_Description.Text = "Teletypes the selected text. The numeric value is optional.";
                    ConfigureParameter(CheckBox_Parameter1, Numeric_Parameter1, "Value:", 20);
                    break;
                case TextEffectAssistantMode.TeletypeFade:
                    Text = "Teletype and Fade";
                    Label_Description.Text = "Teletypes the selected text while fading it onto the screen.";
                    break;
                case TextEffectAssistantMode.CircularText:
                    Text = "Circular Text";
                    Label_Description.Text = "Circles the selected text. Defaults: frequency 2, speed 35, radius 6.";
                    ConfigureParameter(CheckBox_Parameter1, Numeric_Parameter1, "Frequency:", 2);
                    ConfigureParameter(CheckBox_Parameter2, Numeric_Parameter2, "Speed:", 35);
                    ConfigureParameter(CheckBox_Parameter3, Numeric_Parameter3, "Radius:", 6);
                    break;
                case TextEffectAssistantMode.RisingText:
                    Text = "Rising Text";
                    Label_Description.Text = "Makes the selected text fall into position from the top of the screen.";
                    ConfigureParameter(CheckBox_Parameter1, Numeric_Parameter1, "Speed:", 120);
                    break;
                case TextEffectAssistantMode.RandomFontColour:
                    Text = "Random Font Colour";
                    Label_Description.Text = "Changes the font colour randomly at the optional flash rate.";
                    ConfigureParameter(CheckBox_Parameter1, Numeric_Parameter1, "Flash rate:", 30);
                    break;
            }

            UpdateParameterState();
        }

        private static void ConfigureParameter(CheckBox checkBox, NumericUpDown numeric, string text, decimal value)
        {
            checkBox.Text = text;
            checkBox.Visible = true;
            numeric.Value = value;
            numeric.Visible = true;
        }

        private void Parameter_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == CheckBox_Parameter1 && !CheckBox_Parameter1.Checked)
            {
                CheckBox_Parameter2.Checked = false;
                CheckBox_Parameter3.Checked = false;
            }
            else if (sender == CheckBox_Parameter2 && !CheckBox_Parameter2.Checked)
            {
                CheckBox_Parameter3.Checked = false;
            }

            UpdateParameterState();
        }

        private void UpdateParameterState()
        {
            Numeric_Parameter1.Enabled = CheckBox_Parameter1.Checked;
            CheckBox_Parameter2.Enabled = CheckBox_Parameter1.Checked;
            Numeric_Parameter2.Enabled = CheckBox_Parameter2.Checked;
            CheckBox_Parameter3.Enabled = CheckBox_Parameter2.Checked;
            Numeric_Parameter3.Enabled = CheckBox_Parameter3.Checked;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            string tag;
            switch (effectMode)
            {
                case TextEffectAssistantMode.Teletype:
                    tag = "TT";
                    break;
                case TextEffectAssistantMode.TeletypeFade:
                    tag = "TTF";
                    break;
                case TextEffectAssistantMode.CircularText:
                    tag = "CT";
                    break;
                case TextEffectAssistantMode.RisingText:
                    tag = "RT";
                    break;
                default:
                    tag = "RFC";
                    break;
            }

            List<string> parameters = new List<string>();
            if (CheckBox_Parameter1.Visible && CheckBox_Parameter1.Checked)
            {
                parameters.Add(Numeric_Parameter1.Value.ToString("0"));
            }
            if (CheckBox_Parameter2.Visible && CheckBox_Parameter2.Checked)
            {
                parameters.Add(Numeric_Parameter2.Value.ToString("0"));
            }
            if (CheckBox_Parameter3.Visible && CheckBox_Parameter3.Checked)
            {
                parameters.Add(Numeric_Parameter3.Value.ToString("0"));
            }

            EffectText = parameters.Count == 0
                ? "<" + tag + ">"
                : "<" + tag + " " + string.Join(",", parameters.ToArray()) + ">";
            EndText = "<END " + tag + ">";
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
