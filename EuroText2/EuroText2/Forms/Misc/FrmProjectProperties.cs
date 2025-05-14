using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmProjectProperties : Form
    {
        private bool PromptToSave = true;

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmProjectProperties()
        {
            InitializeComponent();
        }


        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmProjectProperties_Load(object sender, System.EventArgs e)
        {
            //Read EuroText Project file
            ETXML_Reader projectFileReader = new ETXML_Reader();
            string projectFilePath = Path.Combine(GlobalVariables.WorkingDirectory, "Project.etp");
            if (File.Exists(projectFilePath))
            {
                //Read properties file
                GlobalVariables.CurrentProject = projectFileReader.ReadProjectFile(projectFilePath);
            }

            //Project settings
            Textbox_HashCodesDir.Text = GlobalVariables.CurrentProject.EuroLandHahCodesServPath;
            Textbox_MessagesDir.Text = GlobalVariables.CurrentProject.MessagesDirectory;
            Textbox_SpreadSheetsDir.Text = GlobalVariables.CurrentProject.SpreadSheetsDirectory;

            //Show all languages
            Listbox_Languages.BeginUpdate();
            Listbox_Languages.Items.AddRange(GlobalVariables.CurrentProject.Languages.ToArray());
            Listbox_Languages.EndUpdate();

            //Show all categories
            Listbox_Categories.BeginUpdate();
            string[] availableFlags = GlobalVariables.CurrentProject.Categories.ToArray();
            Listbox_Categories.Items.AddRange(availableFlags);
            Listbox_Categories.EndUpdate();
            CommonFunctions.AddArrayToCombobox(cbxUnusedTexts, availableFlags);
            if (GlobalVariables.CurrentProject.UnusedTextBit >= 0 && cbxUnusedTexts.Items.Count > 0)
            {
                cbxUnusedTexts.SelectedIndex = GlobalVariables.CurrentProject.UnusedTextBit;
            }

            //Show all tones
            lbxTone.BeginUpdate();
            lbxTone.Items.AddRange(GlobalVariables.CurrentProject.Tones.ToArray());
            lbxTone.EndUpdate();

            //Show all genders
            lbxGender.BeginUpdate();
            lbxGender.Items.AddRange(GlobalVariables.CurrentProject.Genders.ToArray());
            lbxGender.EndUpdate();

            //Show all contexts
            lbxContexts.BeginUpdate();
            lbxContexts.Items.AddRange(GlobalVariables.CurrentProject.Contexts.ToArray());
            lbxContexts.EndUpdate();

            //Global Settings
            Textbox_HashTablesAdmin.Text = GlobalVariables.HashtablesAdminPath;
            Textbox_UserName.Text = GlobalVariables.EuroTextUser;
        }


        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmProjectProperties_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PromptToSave)
            {
                DialogResult messageAnswer = MessageBox.Show("Are you sure you wish to Quit Properties without saving?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageAnswer == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_MessagesDir_Click(object sender, System.EventArgs e)
        {
            folderBrowserDialog.Description = "Set messages folder.";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //Ensure that the messages folder exists
                if (Directory.Exists(Path.Combine(folderBrowserDialog.SelectedPath, "Messages")))
                {
                    Textbox_MessagesDir.Text = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Messages folder not found under the selected path, please choose another path.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_SpreadSheetsDir_Click(object sender, System.EventArgs e)
        {
            folderBrowserDialog.Description = "Set spreadsheets output folder.";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Textbox_SpreadSheetsDir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_HashCodesDir_Click(object sender, System.EventArgs e)
        {
            folderBrowserDialog.Description = "Set hashcodes.h file folder.";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Textbox_HashCodesDir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Languages
        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_AddLanguage_Click(object sender, System.EventArgs e)
        {
            using (FrmInputBox newGroupForm = new FrmInputBox("New Language", "Enter the new language name.", ""))
            {
                if (newGroupForm.ShowDialog() == DialogResult.OK)
                {
                    if (!Listbox_Languages.Items.Contains(newGroupForm.ReturnValue) && !string.IsNullOrEmpty(newGroupForm.ReturnValue))
                    {
                        Listbox_Languages.Items.Add(newGroupForm.ReturnValue);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_DeleteLanguage_Click(object sender, System.EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = Listbox_Languages.SelectedItems;
            if (Listbox_Languages.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    Listbox_Languages.Items.Remove(selectedItems[i]);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Categories
        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_AddCategory_Click(object sender, System.EventArgs e)
        {
            using (FrmInputBox newGroupForm = new FrmInputBox("New Category", "Enter the new category name.", ""))
            {
                if (newGroupForm.ShowDialog() == DialogResult.OK)
                {
                    if (!Listbox_Categories.Items.Contains(newGroupForm.ReturnValue) && !string.IsNullOrEmpty(newGroupForm.ReturnValue))
                    {
                        Listbox_Categories.Items.Add(newGroupForm.ReturnValue);
                        cbxUnusedTexts.Items.Add(newGroupForm.ReturnValue);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_RemoveCategory_Click(object sender, System.EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = Listbox_Categories.SelectedItems;
            if (Listbox_Categories.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    Listbox_Categories.Items.Remove(selectedItems[i]);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Tones
        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnAddTone_Click(object sender, System.EventArgs e)
        {
            using (FrmInputBox newGroupForm = new FrmInputBox("New Tone", "Enter the new tone name.", ""))
            {
                if (newGroupForm.ShowDialog() == DialogResult.OK)
                {
                    if (!lbxTone.Items.Contains(newGroupForm.ReturnValue) && !string.IsNullOrEmpty(newGroupForm.ReturnValue))
                    {
                        lbxTone.Items.Add(newGroupForm.ReturnValue);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnDeleteTone_Click(object sender, System.EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = lbxTone.SelectedItems;
            if (lbxTone.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    lbxTone.Items.Remove(selectedItems[i]);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Gender
        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnAddGender_Click(object sender, System.EventArgs e)
        {
            using (FrmInputBox newGroupForm = new FrmInputBox("New Gender/Voice Type", "Enter the new gender/voice type name.", ""))
            {
                if (newGroupForm.ShowDialog() == DialogResult.OK)
                {
                    if (!lbxGender.Items.Contains(newGroupForm.ReturnValue) && !string.IsNullOrEmpty(newGroupForm.ReturnValue))
                    {
                        lbxGender.Items.Add(newGroupForm.ReturnValue);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnDeleteGender_Click(object sender, System.EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = lbxGender.SelectedItems;
            if (lbxGender.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    lbxGender.Items.Remove(selectedItems[i]);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Contexts
        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnAddContext_Click(object sender, System.EventArgs e)
        {
            using (FrmInputBox newGroupForm = new FrmInputBox("New Context", "Enter the new context name.", ""))
            {
                if (newGroupForm.ShowDialog() == DialogResult.OK)
                {
                    if (!lbxContexts.Items.Contains(newGroupForm.ReturnValue) && !string.IsNullOrEmpty(newGroupForm.ReturnValue))
                    {
                        lbxContexts.Items.Add(newGroupForm.ReturnValue);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnDeleteContext_Click(object sender, System.EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = lbxContexts.SelectedItems;
            if (lbxContexts.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    lbxContexts.Items.Remove(selectedItems[i]);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Misc
        //-------------------------------------------------------------------------------------------------------------------------------
        private void Textbox_HashTablesAdmin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Textbox_HashTablesAdmin.Text = openFileDialog.FileName;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Textbox_UserName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Textbox_UserName.Text = CommonFunctions.AskForUserName("");
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, System.EventArgs e)
        {
            //Update bool
            PromptToSave = false;

            //Update global variables
            GlobalVariables.CurrentProject.MessagesDirectory = Textbox_MessagesDir.Text;
            GlobalVariables.CurrentProject.SpreadSheetsDirectory = Textbox_SpreadSheetsDir.Text;
            GlobalVariables.CurrentProject.EuroLandHahCodesServPath = Textbox_HashCodesDir.Text;
            GlobalVariables.CurrentProject.UnusedTextBit = cbxUnusedTexts.SelectedIndex;
            GlobalVariables.CurrentProject.Languages = Listbox_Languages.Items.OfType<string>().ToList();
            GlobalVariables.CurrentProject.Categories = Listbox_Categories.Items.OfType<string>().ToList();
            GlobalVariables.CurrentProject.Tones = lbxTone.Items.OfType<string>().ToList();
            GlobalVariables.CurrentProject.Contexts = lbxContexts.Items.OfType<string>().ToList();
            GlobalVariables.CurrentProject.Genders = lbxGender.Items.OfType<string>().ToList();
            GlobalVariables.HashtablesAdminPath = Textbox_HashTablesAdmin.Text;
            GlobalVariables.EuroTextUser = Textbox_UserName.Text;

            //Update project file
            ETXML_Writter projectFileReader = new ETXML_Writter();
            projectFileReader.WriteProjectFile(Path.Combine(GlobalVariables.WorkingDirectory, "Project.etp"), GlobalVariables.CurrentProject);

            //Update application INI
            IniFile applicationIni = new IniFile(GlobalVariables.EuroTextIni);
            applicationIni.Write("HashTablesAdmin_Path", GlobalVariables.HashtablesAdminPath, "Settings");
            applicationIni.Write("UserName", GlobalVariables.EuroTextUser, "Misc");

            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
