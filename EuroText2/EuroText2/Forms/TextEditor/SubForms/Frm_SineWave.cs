using System;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_SineWave : Form
    {
        public string fadeInEffect = string.Empty;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_SineWave()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CheckBox_Amplitude_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBox_Amplitude.Checked)
            {
                Numeric_Amplitude.Enabled = true;
                CheckBox_Frequency.Enabled = true;
            }
            else
            {
                Numeric_Amplitude.Enabled = false;
                CheckBox_Frequency.Enabled = false;
                CheckBox_Frequency.Checked = false;
                Numeric_Frequency.Enabled = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CheckBox_Frequency_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Frequency.Checked)
            {
                Numeric_Frequency.Enabled = true;
            }
            else
            {
                Numeric_Frequency.Enabled = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (CheckBox_Amplitude.Checked && CheckBox_Frequency.Checked)
            {
                fadeInEffect = string.Join("", "<SW ", Numeric_Amplitude.Value, ", ", Numeric_Frequency.Value, ">");
            }
            else if (CheckBox_Amplitude.Checked)
            {
                fadeInEffect = string.Join("", "<SW ", Numeric_Amplitude.Value, ">");
            }
            else
            {
                fadeInEffect = "<SW>";
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
