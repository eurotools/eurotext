using System;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Fountain : Form
    {
        public string fountainEffect = string.Empty;

        public Frm_Fountain()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CheckBox_MinDuration_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBox_MinDuration.Checked)
            {
                Numeric_MinDuration.Enabled = true;
            }
            else
            {
                Numeric_MinDuration.Enabled = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CheckBox_MaxDuration_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_MaxDuration.Checked)
            {
                Numeric_MaxDuration.Enabled = true;
                CheckBox_MinDuration.Enabled = true;
            }
            else
            {
                Numeric_MaxDuration.Enabled = false;
                CheckBox_MinDuration.Enabled = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (CheckBox_MinDuration.Checked && CheckBox_MaxDuration.Checked)
            {
                fountainEffect = string.Join("", "<FTN ", Numeric_MaxDuration.Value, ", ", Numeric_MinDuration.Value, ">");
            }
            else if (CheckBox_MaxDuration.Checked)
            {
                fountainEffect = string.Join("", "<FTN ", Numeric_MaxDuration.Value, ">");
            }
            else
            {
                fountainEffect = "<FTN>";
            }

            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {

        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
