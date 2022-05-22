using System;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_ShakeyText : Form
    {
        public string fadeInEffect = string.Empty;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_ShakeyText()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CheckBox_Variance_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBox_Variance.Checked)
            {
                Numeric_Variance.Enabled = true;
                CheckBox_Speed.Enabled = true;
            }
            else
            {
                Numeric_Variance.Enabled = false;
                CheckBox_Speed.Enabled = false;
                CheckBox_Speed.Checked = false;
                Numeric_Speed.Enabled = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (CheckBox_Variance.Checked && CheckBox_Speed.Checked)
            {
                fadeInEffect = string.Join("", "<ST ", Numeric_Variance.Value, ", ", Numeric_Speed.Value, ">");
            }
            else if (CheckBox_Variance.Checked)
            {
                fadeInEffect = string.Join("", "<ST ", Numeric_Variance.Value, ">");
            }
            else
            {
                fadeInEffect = "<ST>";
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
