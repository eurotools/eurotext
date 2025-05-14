using System;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmInputBox : Form
    {
        internal string ReturnValue = string.Empty;

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmInputBox(string TitleText, string MessageToShow, string defaultResponse)
        {
            InitializeComponent();
            Text = TitleText;
            Label_Text.Text = MessageToShow;
            Textbox_Answer.Text = defaultResponse;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            ReturnValue = Textbox_Answer.Text.Trim();
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