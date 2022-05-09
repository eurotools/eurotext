using System;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_TextEditor_Buttons : Form
    {
        public string ButtonsText = string.Empty;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_TextEditor_Buttons()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            TextBox[] ButtonsTextBoxes = new TextBox[] { Textbox_Button1, Textbox_Button2, Textbox_Button3, Textbox_Button4, Textbox_Button5, Textbox_Button6, Textbox_Button7, Textbox_Button8 };
            for (int i = 0; i < ButtonsTextBoxes.Length; i++)
            {
                if (!string.IsNullOrEmpty(ButtonsTextBoxes[i].Text))
                {
                    ButtonsText += string.Join("", "<N>  <B " + (i + 1) + "> ", ButtonsTextBoxes[i].Text.Trim());
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
