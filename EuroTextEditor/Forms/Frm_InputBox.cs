using System;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_InputBox : Form
    {
        internal string ReturnValue = string.Empty;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_InputBox(string TitleText, string MessageToShow, string defaultResponse)
        {
            InitializeComponent();
            Text = TitleText;
            Label_Text.Text = MessageToShow;
            Textbox_Answer.Text = defaultResponse;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            ReturnValue = Textbox_Answer.Text;
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
