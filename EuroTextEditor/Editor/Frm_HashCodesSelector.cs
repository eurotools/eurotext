using System;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_HashCodesSelector : Form
    {
        public string SelectedHashCode = string.Empty;
        private readonly string defaultSection = "";
        private readonly bool forceHashTableSection = false;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_HashCodesSelector(string section, bool forceSection = false)
        {
            InitializeComponent();
            defaultSection = section;
            forceHashTableSection = forceSection;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_HashCodesSelector_Load(object sender, EventArgs e)
        {
            HashCodesControl.LoadHashCodesSections(GlobalVariables.HashtablesFilePath);
            HashCodesControl.DefaultSection = defaultSection;
            HashCodesControl.ForceHashTableSection = forceHashTableSection;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            //Get the selected hashcode
            if (HashCodesControl.Combobox_HashCodes.SelectedItem != null)
            {
                SelectedHashCode = HashCodesControl.Combobox_HashCodes.SelectedItem.ToString();
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
    }
    //-------------------------------------------------------------------------------------------------------------------------------
}
