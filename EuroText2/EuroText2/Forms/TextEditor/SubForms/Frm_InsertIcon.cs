using System;
using System.IO;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_InsertIcon : Form
    {
        public string SelectedIcon = string.Empty;
        private readonly string defaultSection = "";
        private readonly bool forceHashTableSection = false;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_InsertIcon(string section, bool forceSection = false)
        {
            InitializeComponent();
            defaultSection = section;
            forceHashTableSection = forceSection;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_InsertIcon_Load(object sender, EventArgs e)
        {
            HashCodesControl.LoadHashCodesSections(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h"));
            HashCodesControl.DefaultSection = defaultSection;
            HashCodesControl.ForceHashTableSection = forceHashTableSection;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            //Get the selected hashcode
            if (HashCodesControl.Combobox_HashCodes.SelectedItem != null)
            {
                if (CheckBox_SpecifyWidthAndHeight.Checked)
                {
                    SelectedIcon = string.Join("", "<I ", HashCodesControl.Combobox_HashCodes.SelectedItem.ToString(), ", ", Numeric_Width.Value, ", ", Numeric_Height.Value, ">");
                }
                else
                {
                    SelectedIcon = string.Join("", "<I ", HashCodesControl.Combobox_HashCodes.SelectedItem.ToString(), ">");
                }
            }

            //Close form and send OK Result
            DialogResult = DialogResult.OK;
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            //Close form and send Cancel Result
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CheckBox_SpecifyWidthAndHeight_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_SpecifyWidthAndHeight.Checked)
            {
                Numeric_Height.Enabled = true;
                Numeric_Width.Enabled = true;
            }
            else
            {
                Numeric_Height.Enabled = false;
                Numeric_Width.Enabled = false;
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
