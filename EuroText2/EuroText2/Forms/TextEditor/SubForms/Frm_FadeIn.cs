using System;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_FadeIn : Form
    {
        public string fadeInEffect = string.Empty;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_FadeIn()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Checkbox_Duration_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox_Duration.Checked)
            {
                Numeric_Duration.Enabled = true;
                CheckBox_WaitDelay.Enabled = true;
            }
            else
            {
                Numeric_Duration.Enabled = false;
                CheckBox_WaitDelay.Enabled = false;
                CheckBox_WaitDelay.Checked = false;
                Numeric_WaitDelay.Enabled = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CheckBox_WaitDelay_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_WaitDelay.Checked)
            {
                Numeric_WaitDelay.Enabled = true;
            }
            else
            {
                Numeric_WaitDelay.Enabled = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (Checkbox_Duration.Checked && CheckBox_WaitDelay.Checked)
            {
                fadeInEffect = string.Join("", "<FI ", Numeric_Duration.Value, ", ", Numeric_WaitDelay.Value, ">");
            }
            else if (Checkbox_Duration.Checked)
            {
                fadeInEffect = string.Join("", "<FI ", Numeric_Duration.Value, ">");
            }
            else
            {
                fadeInEffect = "<FI>";
            }

            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
