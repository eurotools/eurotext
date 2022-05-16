using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_SearchResults : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_SearchResults(ListViewItem[] SearchResuls)
        {
            InitializeComponent();
            ListView_HashCodes.Items.AddRange(SearchResuls);
            GroupBox_Results.Text = SearchResuls.Length + " Items";
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
