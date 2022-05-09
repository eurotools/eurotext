using System;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_GroupsViewer : Form
    {
        private readonly string[] hashCodes;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_GroupsViewer(string[] hashCodesGroup)
        {
            InitializeComponent();
            hashCodes = hashCodesGroup;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_GroupsViewer_Shown(object sender, EventArgs e)
        {
            //Update listbox
            ListBox_HashCodes.BeginUpdate();
            ListBox_HashCodes.Items.AddRange(hashCodes);
            ListBox_HashCodes.EndUpdate();

            //Update total
            Label_ItemsCount.Text = string.Join(" ", "Total:", ListBox_HashCodes.Items.Count);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
