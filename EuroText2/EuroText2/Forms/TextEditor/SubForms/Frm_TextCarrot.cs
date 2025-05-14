using System;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_TextCarrot : Form
    {
        public string carrotText = string.Empty;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_TextCarrot()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CheckBox_Variance_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBox_Variance.Checked)
            {
                Numeric_Percentage.Enabled = true;
            }
            else
            {
                Numeric_Percentage.Enabled = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (CheckBox_Variance.Checked)
            {
                carrotText = string.Join("", "<PC 2, ", Numeric_Percentage.Value, ">");
            }
            else
            {
                carrotText = "<PC 1>";
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
