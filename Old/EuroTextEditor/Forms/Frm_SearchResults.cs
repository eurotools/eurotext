using System;
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
            UserControl_HashCodes.ListView_HashCodes.Items.AddRange(SearchResuls);
            GroupBox_Results.Text = SearchResuls.Length + " Items";

            //Hide other menu options
            UserControl_HashCodes.MenuItem_Color.Visible = false;
            UserControl_HashCodes.MenuItem_New.Visible = false;
            UserControl_HashCodes.MenuItem_Delete.Visible = false;
            UserControl_HashCodes.MenuItem_Rename.Visible = false;
            UserControl_HashCodes.MenuItem_Separator1.Visible = false;
            UserControl_HashCodes.MenuItem_SetGroup.Visible = false;
            UserControl_HashCodes.MenuItem_Separator2.Visible = false;
            UserControl_HashCodes.MenuItem_Refresh.Visible = false;
            UserControl_HashCodes.MenuItem_EditNote.Visible = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ListView_HashCodes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (UserControl_HashCodes.ListView_HashCodes.SelectedItems.Count == 1)
            {
                CommonFunctions.EditHashCode(UserControl_HashCodes.ListView_HashCodes.SelectedItems[0], null);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
