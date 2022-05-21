using System;
using System.IO;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_GroupsViewer : Form
    {
        private readonly string[] hashCodes;
        private readonly Frm_ListBoxHashCodes parentHashCodesForm;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_GroupsViewer(string[] hashCodesGroup, Frm_ListBoxHashCodes parentForm)
        {
            InitializeComponent();
            hashCodes = hashCodesGroup;
            parentHashCodesForm = parentForm;

            //Hide other menu options
            UserControl_HashCodes.MenuItem_New.Visible = false;
            UserControl_HashCodes.MenuItem_Delete.Visible = false;
            UserControl_HashCodes.MenuItem_Rename.Visible = false;
            UserControl_HashCodes.MenuItem_SetGroup.Visible = false;
            UserControl_HashCodes.MenuItem_Separator2.Visible = false;
            UserControl_HashCodes.MenuItem_Refresh.Visible = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_GroupsViewer_Shown(object sender, EventArgs e)
        {
            ETXML_Reader filesReader = new ETXML_Reader();

            //Update listbox
            UserControl_HashCodes.parentFormToSync = parentHashCodesForm;
            UserControl_HashCodes.ListView_HashCodes.BeginUpdate();
            for (int i = 0; i < hashCodes.Length; i++)
            {
                string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", hashCodes[i]);
                EuroText_TextFile objTextData = filesReader.ReadTextFile(textFilePath);

                //Update control
                ListViewItem HashCodeItem = UserControl_HashCodes.ListView_HashCodes.Items.Add(new ListViewItem(new[] { Path.GetFileNameWithoutExtension(hashCodes[i]).ToString(), objTextData.FirstCreated, objTextData.CreatedBy, objTextData.LastModified, objTextData.LastModifiedBy, CommonFunctions.GetFlagsLabels(objTextData.textFlags), objTextData.Notes }));
                HashCodeItem.BackColor = objTextData.RowColor;
            }
            UserControl_HashCodes.ListView_HashCodes.EndUpdate();
            UserControl_HashCodes.StatusLabel_TotalItems.Text = UserControl_HashCodes.ListView_HashCodes.Items.Count + " Items";
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
