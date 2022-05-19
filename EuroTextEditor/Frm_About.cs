using System;
using System.Windows.Forms;

namespace EuroTextEditor
{
    public partial class Frm_About : Form
    {
        public Frm_About()
        {
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
