using System;
using System.Windows.Forms;

namespace EuroText2
{
    public partial class Frm_DynamicIcon : Form
    {
        public string DynamicIconText { get; private set; }

        public Frm_DynamicIcon()
        {
            DynamicIconText = string.Empty;
            InitializeComponent();
            UpdateSizeState();
        }

        private void CheckBox_Size_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeState();
        }

        private void UpdateSizeState()
        {
            Numeric_Width.Enabled = CheckBox_Size.Checked;
            Numeric_Height.Enabled = CheckBox_Size.Checked;
            Label_Width.Enabled = CheckBox_Size.Checked;
            Label_Height.Enabled = CheckBox_Size.Checked;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            DynamicIconText = string.Format("<DC {0} {1} {2}", Numeric_What.Value, Numeric_Objective1.Value, Numeric_Objective2.Value);
            if (CheckBox_Size.Checked)
            {
                DynamicIconText += string.Format(" {0} {1}", Numeric_Width.Value, Numeric_Height.Value);
            }
            DynamicIconText += ">";
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
