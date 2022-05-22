using System;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Categories : Form
    {
        private readonly int currentTextFlags;
        internal int selectedFlags;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_Categories(int textFlags)
        {
            InitializeComponent();
            currentTextFlags = textFlags;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_Categories_Load(object sender, EventArgs e)
        {
            //Show labels
            for (int i = 0; i < 16; i++)
            {
                if (i < GlobalVariables.CurrentProject.Categories.Count)
                {
                    string controlText = "TextBox_Flag" + (i + 1);
                    if (GroupBox_Flags.Controls.ContainsKey(controlText))
                    {
                        if (GroupBox_Flags.Controls[controlText] is TextBox txtBox)
                        {
                            txtBox.Text = GlobalVariables.CurrentProject.Categories[i];
                        }
                    }
                }
            }

            //Check flag if was selected by the user
            for (int i = 0; i < 16; i++)
            {
                if (Convert.ToBoolean((currentTextFlags >> i) & 1))
                {
                    string controlText = "CheckBox_Flag" + (i + 1);
                    if (GroupBox_Flags.Controls.ContainsKey(controlText))
                    {
                        if (GroupBox_Flags.Controls[controlText] is CheckBox chxBox)
                        {
                            chxBox.Checked = true;
                        }
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            //Check flag if was selected by the user
            selectedFlags = 0;
            for (int i = 0; i < 16; i++)
            {
                string controlText = "CheckBox_Flag" + (i + 1);
                if (GroupBox_Flags.Controls.ContainsKey(controlText))
                {
                    if (GroupBox_Flags.Controls[controlText] is CheckBox chxBox)
                    {
                        if (chxBox.Checked)
                        {
                            selectedFlags |= (1 << i);
                        }
                    }
                }
            }

            DialogResult = DialogResult.OK;
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
