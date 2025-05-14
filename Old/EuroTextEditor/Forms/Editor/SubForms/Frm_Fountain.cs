using System;
using System.Windows.Forms;

namespace EuroTextEditor.Editor.SubForms
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Fountain : Form
    {
        public Frm_Fountain()
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
        private void CheckBox_Speed_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Speed.Checked)
            {
                Numeric_Speed.Enabled = true;
            }
            else
            {
                Numeric_Speed.Enabled = false;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {

        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
