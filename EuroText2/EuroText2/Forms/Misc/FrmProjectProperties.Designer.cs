
namespace EuroText2
{
    partial class FrmProjectProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectProperties));
            this.Button_RemoveCategory = new System.Windows.Forms.Button();
            this.Button_AddCategory = new System.Windows.Forms.Button();
            this.Listbox_Categories = new System.Windows.Forms.ListBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Groupbox_Misc = new System.Windows.Forms.GroupBox();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Textbox_UserName = new System.Windows.Forms.TextBox();
            this.Textbox_HashTablesAdmin = new System.Windows.Forms.TextBox();
            this.Label_HashTableAdmin = new System.Windows.Forms.Label();
            this.Button_DeleteLanguage = new System.Windows.Forms.Button();
            this.Button_AddLanguage = new System.Windows.Forms.Button();
            this.Listbox_Languages = new System.Windows.Forms.ListBox();
            this.GroupBox_SpreadSheetsDir = new System.Windows.Forms.GroupBox();
            this.Button_SpreadSheetsDir = new System.Windows.Forms.Button();
            this.Textbox_SpreadSheetsDir = new System.Windows.Forms.TextBox();
            this.GroupBox_MessagesDir = new System.Windows.Forms.GroupBox();
            this.Button_MessagesDir = new System.Windows.Forms.Button();
            this.Textbox_MessagesDir = new System.Windows.Forms.TextBox();
            this.Label_MessagesFolder = new System.Windows.Forms.Label();
            this.GroupBox_HashCodesDir = new System.Windows.Forms.GroupBox();
            this.Button_HashCodesDir = new System.Windows.Forms.Button();
            this.Textbox_HashCodesDir = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLanguages = new System.Windows.Forms.TabPage();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.tabPageTone = new System.Windows.Forms.TabPage();
            this.btnDeleteTone = new System.Windows.Forms.Button();
            this.btnAddTone = new System.Windows.Forms.Button();
            this.lbxTone = new System.Windows.Forms.ListBox();
            this.tabPageVoiceTypes = new System.Windows.Forms.TabPage();
            this.lbxGender = new System.Windows.Forms.ListBox();
            this.btnDeleteGender = new System.Windows.Forms.Button();
            this.btnAddGender = new System.Windows.Forms.Button();
            this.tabPageContext = new System.Windows.Forms.TabPage();
            this.lbxContexts = new System.Windows.Forms.ListBox();
            this.btnDeleteContext = new System.Windows.Forms.Button();
            this.btnAddContext = new System.Windows.Forms.Button();
            this.lblUnusedBit = new System.Windows.Forms.Label();
            this.cbxUnusedTexts = new System.Windows.Forms.ComboBox();
            this.Groupbox_Misc.SuspendLayout();
            this.GroupBox_SpreadSheetsDir.SuspendLayout();
            this.GroupBox_MessagesDir.SuspendLayout();
            this.GroupBox_HashCodesDir.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLanguages.SuspendLayout();
            this.tabPageCategories.SuspendLayout();
            this.tabPageTone.SuspendLayout();
            this.tabPageVoiceTypes.SuspendLayout();
            this.tabPageContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_RemoveCategory
            // 
            this.Button_RemoveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_RemoveCategory.Location = new System.Drawing.Point(84, 255);
            this.Button_RemoveCategory.Name = "Button_RemoveCategory";
            this.Button_RemoveCategory.Size = new System.Drawing.Size(75, 23);
            this.Button_RemoveCategory.TabIndex = 2;
            this.Button_RemoveCategory.Text = "Delete";
            this.Button_RemoveCategory.UseVisualStyleBackColor = true;
            this.Button_RemoveCategory.Click += new System.EventHandler(this.Button_RemoveCategory_Click);
            // 
            // Button_AddCategory
            // 
            this.Button_AddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_AddCategory.Location = new System.Drawing.Point(3, 255);
            this.Button_AddCategory.Name = "Button_AddCategory";
            this.Button_AddCategory.Size = new System.Drawing.Size(75, 23);
            this.Button_AddCategory.TabIndex = 1;
            this.Button_AddCategory.Text = "Add";
            this.Button_AddCategory.UseVisualStyleBackColor = true;
            this.Button_AddCategory.Click += new System.EventHandler(this.Button_AddCategory_Click);
            // 
            // Listbox_Categories
            // 
            this.Listbox_Categories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listbox_Categories.FormattingEnabled = true;
            this.Listbox_Categories.Location = new System.Drawing.Point(3, 3);
            this.Listbox_Categories.Name = "Listbox_Categories";
            this.Listbox_Categories.Size = new System.Drawing.Size(470, 238);
            this.Listbox_Categories.TabIndex = 0;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(427, 565);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 17;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.Location = new System.Drawing.Point(346, 565);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 16;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Groupbox_Misc
            // 
            this.Groupbox_Misc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Groupbox_Misc.Controls.Add(this.Label_Username);
            this.Groupbox_Misc.Controls.Add(this.Textbox_UserName);
            this.Groupbox_Misc.Controls.Add(this.Textbox_HashTablesAdmin);
            this.Groupbox_Misc.Controls.Add(this.Label_HashTableAdmin);
            this.Groupbox_Misc.Location = new System.Drawing.Point(12, 487);
            this.Groupbox_Misc.Name = "Groupbox_Misc";
            this.Groupbox_Misc.Size = new System.Drawing.Size(490, 72);
            this.Groupbox_Misc.TabIndex = 15;
            this.Groupbox_Misc.TabStop = false;
            this.Groupbox_Misc.Text = "Misc";
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Location = new System.Drawing.Point(67, 48);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(58, 13);
            this.Label_Username.TabIndex = 3;
            this.Label_Username.Text = "Username:";
            // 
            // Textbox_UserName
            // 
            this.Textbox_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_UserName.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_UserName.Location = new System.Drawing.Point(131, 45);
            this.Textbox_UserName.Name = "Textbox_UserName";
            this.Textbox_UserName.ReadOnly = true;
            this.Textbox_UserName.Size = new System.Drawing.Size(353, 20);
            this.Textbox_UserName.TabIndex = 2;
            this.Textbox_UserName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Textbox_UserName_MouseDoubleClick);
            // 
            // Textbox_HashTablesAdmin
            // 
            this.Textbox_HashTablesAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_HashTablesAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_HashTablesAdmin.Location = new System.Drawing.Point(131, 19);
            this.Textbox_HashTablesAdmin.Name = "Textbox_HashTablesAdmin";
            this.Textbox_HashTablesAdmin.ReadOnly = true;
            this.Textbox_HashTablesAdmin.Size = new System.Drawing.Size(353, 20);
            this.Textbox_HashTablesAdmin.TabIndex = 1;
            this.Textbox_HashTablesAdmin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Textbox_HashTablesAdmin_MouseDoubleClick);
            // 
            // Label_HashTableAdmin
            // 
            this.Label_HashTableAdmin.AutoSize = true;
            this.Label_HashTableAdmin.Location = new System.Drawing.Point(6, 22);
            this.Label_HashTableAdmin.Name = "Label_HashTableAdmin";
            this.Label_HashTableAdmin.Size = new System.Drawing.Size(119, 13);
            this.Label_HashTableAdmin.TabIndex = 0;
            this.Label_HashTableAdmin.Text = "HashTable Admin Path:";
            // 
            // Button_DeleteLanguage
            // 
            this.Button_DeleteLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_DeleteLanguage.Location = new System.Drawing.Point(84, 255);
            this.Button_DeleteLanguage.Name = "Button_DeleteLanguage";
            this.Button_DeleteLanguage.Size = new System.Drawing.Size(75, 23);
            this.Button_DeleteLanguage.TabIndex = 2;
            this.Button_DeleteLanguage.Text = "Delete";
            this.Button_DeleteLanguage.UseVisualStyleBackColor = true;
            this.Button_DeleteLanguage.Click += new System.EventHandler(this.Button_DeleteLanguage_Click);
            // 
            // Button_AddLanguage
            // 
            this.Button_AddLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_AddLanguage.Location = new System.Drawing.Point(3, 255);
            this.Button_AddLanguage.Name = "Button_AddLanguage";
            this.Button_AddLanguage.Size = new System.Drawing.Size(75, 23);
            this.Button_AddLanguage.TabIndex = 1;
            this.Button_AddLanguage.Text = "Add";
            this.Button_AddLanguage.UseVisualStyleBackColor = true;
            this.Button_AddLanguage.Click += new System.EventHandler(this.Button_AddLanguage_Click);
            // 
            // Listbox_Languages
            // 
            this.Listbox_Languages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listbox_Languages.FormattingEnabled = true;
            this.Listbox_Languages.Location = new System.Drawing.Point(3, 3);
            this.Listbox_Languages.Name = "Listbox_Languages";
            this.Listbox_Languages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Listbox_Languages.Size = new System.Drawing.Size(470, 238);
            this.Listbox_Languages.TabIndex = 0;
            // 
            // GroupBox_SpreadSheetsDir
            // 
            this.GroupBox_SpreadSheetsDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_SpreadSheetsDir.Controls.Add(this.Button_SpreadSheetsDir);
            this.GroupBox_SpreadSheetsDir.Controls.Add(this.Textbox_SpreadSheetsDir);
            this.GroupBox_SpreadSheetsDir.Location = new System.Drawing.Point(12, 65);
            this.GroupBox_SpreadSheetsDir.Name = "GroupBox_SpreadSheetsDir";
            this.GroupBox_SpreadSheetsDir.Size = new System.Drawing.Size(490, 47);
            this.GroupBox_SpreadSheetsDir.TabIndex = 13;
            this.GroupBox_SpreadSheetsDir.TabStop = false;
            this.GroupBox_SpreadSheetsDir.Text = "SpreadSheets Directory";
            // 
            // Button_SpreadSheetsDir
            // 
            this.Button_SpreadSheetsDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SpreadSheetsDir.Location = new System.Drawing.Point(409, 17);
            this.Button_SpreadSheetsDir.Name = "Button_SpreadSheetsDir";
            this.Button_SpreadSheetsDir.Size = new System.Drawing.Size(75, 23);
            this.Button_SpreadSheetsDir.TabIndex = 5;
            this.Button_SpreadSheetsDir.Text = "Set Folder";
            this.Button_SpreadSheetsDir.UseVisualStyleBackColor = true;
            this.Button_SpreadSheetsDir.Click += new System.EventHandler(this.Button_SpreadSheetsDir_Click);
            // 
            // Textbox_SpreadSheetsDir
            // 
            this.Textbox_SpreadSheetsDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_SpreadSheetsDir.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_SpreadSheetsDir.Location = new System.Drawing.Point(6, 19);
            this.Textbox_SpreadSheetsDir.Name = "Textbox_SpreadSheetsDir";
            this.Textbox_SpreadSheetsDir.ReadOnly = true;
            this.Textbox_SpreadSheetsDir.Size = new System.Drawing.Size(317, 20);
            this.Textbox_SpreadSheetsDir.TabIndex = 3;
            // 
            // GroupBox_MessagesDir
            // 
            this.GroupBox_MessagesDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_MessagesDir.Controls.Add(this.Button_MessagesDir);
            this.GroupBox_MessagesDir.Controls.Add(this.Textbox_MessagesDir);
            this.GroupBox_MessagesDir.Controls.Add(this.Label_MessagesFolder);
            this.GroupBox_MessagesDir.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_MessagesDir.Name = "GroupBox_MessagesDir";
            this.GroupBox_MessagesDir.Size = new System.Drawing.Size(490, 47);
            this.GroupBox_MessagesDir.TabIndex = 12;
            this.GroupBox_MessagesDir.TabStop = false;
            this.GroupBox_MessagesDir.Text = "Messages Directory";
            // 
            // Button_MessagesDir
            // 
            this.Button_MessagesDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_MessagesDir.Location = new System.Drawing.Point(409, 17);
            this.Button_MessagesDir.Name = "Button_MessagesDir";
            this.Button_MessagesDir.Size = new System.Drawing.Size(75, 23);
            this.Button_MessagesDir.TabIndex = 2;
            this.Button_MessagesDir.Text = "Set Folder";
            this.Button_MessagesDir.UseVisualStyleBackColor = true;
            this.Button_MessagesDir.Click += new System.EventHandler(this.Button_MessagesDir_Click);
            // 
            // Textbox_MessagesDir
            // 
            this.Textbox_MessagesDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_MessagesDir.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_MessagesDir.Location = new System.Drawing.Point(6, 19);
            this.Textbox_MessagesDir.Name = "Textbox_MessagesDir";
            this.Textbox_MessagesDir.ReadOnly = true;
            this.Textbox_MessagesDir.Size = new System.Drawing.Size(317, 20);
            this.Textbox_MessagesDir.TabIndex = 0;
            // 
            // Label_MessagesFolder
            // 
            this.Label_MessagesFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_MessagesFolder.AutoSize = true;
            this.Label_MessagesFolder.Location = new System.Drawing.Point(329, 22);
            this.Label_MessagesFolder.Name = "Label_MessagesFolder";
            this.Label_MessagesFolder.Size = new System.Drawing.Size(74, 13);
            this.Label_MessagesFolder.TabIndex = 1;
            this.Label_MessagesFolder.Text = "+ \\Messages\\";
            // 
            // GroupBox_HashCodesDir
            // 
            this.GroupBox_HashCodesDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_HashCodesDir.Controls.Add(this.Button_HashCodesDir);
            this.GroupBox_HashCodesDir.Controls.Add(this.Textbox_HashCodesDir);
            this.GroupBox_HashCodesDir.Location = new System.Drawing.Point(12, 118);
            this.GroupBox_HashCodesDir.Name = "GroupBox_HashCodesDir";
            this.GroupBox_HashCodesDir.Size = new System.Drawing.Size(490, 47);
            this.GroupBox_HashCodesDir.TabIndex = 19;
            this.GroupBox_HashCodesDir.TabStop = false;
            this.GroupBox_HashCodesDir.Text = "EuroLand HashCodes Server Path";
            // 
            // Button_HashCodesDir
            // 
            this.Button_HashCodesDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_HashCodesDir.Location = new System.Drawing.Point(409, 17);
            this.Button_HashCodesDir.Name = "Button_HashCodesDir";
            this.Button_HashCodesDir.Size = new System.Drawing.Size(75, 23);
            this.Button_HashCodesDir.TabIndex = 5;
            this.Button_HashCodesDir.Text = "Set Folder";
            this.Button_HashCodesDir.UseVisualStyleBackColor = true;
            this.Button_HashCodesDir.Click += new System.EventHandler(this.Button_HashCodesDir_Click);
            // 
            // Textbox_HashCodesDir
            // 
            this.Textbox_HashCodesDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_HashCodesDir.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_HashCodesDir.Location = new System.Drawing.Point(6, 19);
            this.Textbox_HashCodesDir.Name = "Textbox_HashCodesDir";
            this.Textbox_HashCodesDir.ReadOnly = true;
            this.Textbox_HashCodesDir.Size = new System.Drawing.Size(317, 20);
            this.Textbox_HashCodesDir.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLanguages);
            this.tabControl1.Controls.Add(this.tabPageCategories);
            this.tabControl1.Controls.Add(this.tabPageTone);
            this.tabControl1.Controls.Add(this.tabPageVoiceTypes);
            this.tabControl1.Controls.Add(this.tabPageContext);
            this.tabControl1.Location = new System.Drawing.Point(12, 171);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 310);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPageLanguages
            // 
            this.tabPageLanguages.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageLanguages.Controls.Add(this.Button_DeleteLanguage);
            this.tabPageLanguages.Controls.Add(this.Listbox_Languages);
            this.tabPageLanguages.Controls.Add(this.Button_AddLanguage);
            this.tabPageLanguages.Location = new System.Drawing.Point(4, 22);
            this.tabPageLanguages.Name = "tabPageLanguages";
            this.tabPageLanguages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLanguages.Size = new System.Drawing.Size(482, 284);
            this.tabPageLanguages.TabIndex = 0;
            this.tabPageLanguages.Text = "Languages";
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCategories.Controls.Add(this.cbxUnusedTexts);
            this.tabPageCategories.Controls.Add(this.lblUnusedBit);
            this.tabPageCategories.Controls.Add(this.Listbox_Categories);
            this.tabPageCategories.Controls.Add(this.Button_RemoveCategory);
            this.tabPageCategories.Controls.Add(this.Button_AddCategory);
            this.tabPageCategories.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategories.Size = new System.Drawing.Size(482, 284);
            this.tabPageCategories.TabIndex = 1;
            this.tabPageCategories.Text = "Categories";
            // 
            // tabPageTone
            // 
            this.tabPageTone.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTone.Controls.Add(this.btnDeleteTone);
            this.tabPageTone.Controls.Add(this.btnAddTone);
            this.tabPageTone.Controls.Add(this.lbxTone);
            this.tabPageTone.Location = new System.Drawing.Point(4, 22);
            this.tabPageTone.Name = "tabPageTone";
            this.tabPageTone.Size = new System.Drawing.Size(482, 284);
            this.tabPageTone.TabIndex = 2;
            this.tabPageTone.Text = "Tones";
            // 
            // btnDeleteTone
            // 
            this.btnDeleteTone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteTone.Location = new System.Drawing.Point(84, 255);
            this.btnDeleteTone.Name = "btnDeleteTone";
            this.btnDeleteTone.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTone.TabIndex = 4;
            this.btnDeleteTone.Text = "Delete";
            this.btnDeleteTone.UseVisualStyleBackColor = true;
            this.btnDeleteTone.Click += new System.EventHandler(this.BtnDeleteTone_Click);
            // 
            // btnAddTone
            // 
            this.btnAddTone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTone.Location = new System.Drawing.Point(3, 255);
            this.btnAddTone.Name = "btnAddTone";
            this.btnAddTone.Size = new System.Drawing.Size(75, 23);
            this.btnAddTone.TabIndex = 3;
            this.btnAddTone.Text = "Add";
            this.btnAddTone.UseVisualStyleBackColor = true;
            this.btnAddTone.Click += new System.EventHandler(this.BtnAddTone_Click);
            // 
            // lbxTone
            // 
            this.lbxTone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxTone.FormattingEnabled = true;
            this.lbxTone.Location = new System.Drawing.Point(3, 3);
            this.lbxTone.Name = "lbxTone";
            this.lbxTone.Size = new System.Drawing.Size(470, 238);
            this.lbxTone.TabIndex = 1;
            // 
            // tabPageVoiceTypes
            // 
            this.tabPageVoiceTypes.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageVoiceTypes.Controls.Add(this.lbxGender);
            this.tabPageVoiceTypes.Controls.Add(this.btnDeleteGender);
            this.tabPageVoiceTypes.Controls.Add(this.btnAddGender);
            this.tabPageVoiceTypes.Location = new System.Drawing.Point(4, 22);
            this.tabPageVoiceTypes.Name = "tabPageVoiceTypes";
            this.tabPageVoiceTypes.Size = new System.Drawing.Size(482, 284);
            this.tabPageVoiceTypes.TabIndex = 3;
            this.tabPageVoiceTypes.Text = "Genders / Voice Types";
            // 
            // lbxGender
            // 
            this.lbxGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxGender.FormattingEnabled = true;
            this.lbxGender.Location = new System.Drawing.Point(3, 3);
            this.lbxGender.Name = "lbxGender";
            this.lbxGender.Size = new System.Drawing.Size(470, 238);
            this.lbxGender.TabIndex = 7;
            // 
            // btnDeleteGender
            // 
            this.btnDeleteGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteGender.Location = new System.Drawing.Point(84, 255);
            this.btnDeleteGender.Name = "btnDeleteGender";
            this.btnDeleteGender.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGender.TabIndex = 6;
            this.btnDeleteGender.Text = "Delete";
            this.btnDeleteGender.UseVisualStyleBackColor = true;
            this.btnDeleteGender.Click += new System.EventHandler(this.BtnDeleteGender_Click);
            // 
            // btnAddGender
            // 
            this.btnAddGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddGender.Location = new System.Drawing.Point(3, 255);
            this.btnAddGender.Name = "btnAddGender";
            this.btnAddGender.Size = new System.Drawing.Size(75, 23);
            this.btnAddGender.TabIndex = 5;
            this.btnAddGender.Text = "Add";
            this.btnAddGender.UseVisualStyleBackColor = true;
            this.btnAddGender.Click += new System.EventHandler(this.BtnAddGender_Click);
            // 
            // tabPageContext
            // 
            this.tabPageContext.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageContext.Controls.Add(this.lbxContexts);
            this.tabPageContext.Controls.Add(this.btnDeleteContext);
            this.tabPageContext.Controls.Add(this.btnAddContext);
            this.tabPageContext.Location = new System.Drawing.Point(4, 22);
            this.tabPageContext.Name = "tabPageContext";
            this.tabPageContext.Size = new System.Drawing.Size(482, 284);
            this.tabPageContext.TabIndex = 4;
            this.tabPageContext.Text = "Contexts";
            // 
            // lbxContexts
            // 
            this.lbxContexts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxContexts.FormattingEnabled = true;
            this.lbxContexts.Location = new System.Drawing.Point(3, 3);
            this.lbxContexts.Name = "lbxContexts";
            this.lbxContexts.Size = new System.Drawing.Size(470, 238);
            this.lbxContexts.TabIndex = 9;
            // 
            // btnDeleteContext
            // 
            this.btnDeleteContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteContext.Location = new System.Drawing.Point(84, 255);
            this.btnDeleteContext.Name = "btnDeleteContext";
            this.btnDeleteContext.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteContext.TabIndex = 8;
            this.btnDeleteContext.Text = "Delete";
            this.btnDeleteContext.UseVisualStyleBackColor = true;
            this.btnDeleteContext.Click += new System.EventHandler(this.BtnDeleteContext_Click);
            // 
            // btnAddContext
            // 
            this.btnAddContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddContext.Location = new System.Drawing.Point(3, 255);
            this.btnAddContext.Name = "btnAddContext";
            this.btnAddContext.Size = new System.Drawing.Size(75, 23);
            this.btnAddContext.TabIndex = 7;
            this.btnAddContext.Text = "Add";
            this.btnAddContext.UseVisualStyleBackColor = true;
            this.btnAddContext.Click += new System.EventHandler(this.BtnAddContext_Click);
            // 
            // lblUnusedBit
            // 
            this.lblUnusedBit.AutoSize = true;
            this.lblUnusedBit.Location = new System.Drawing.Point(192, 260);
            this.lblUnusedBit.Name = "lblUnusedBit";
            this.lblUnusedBit.Size = new System.Drawing.Size(130, 13);
            this.lblUnusedBit.TabIndex = 3;
            this.lblUnusedBit.Text = "Category for unused texts:";
            // 
            // cbxUnusedTexts
            // 
            this.cbxUnusedTexts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnusedTexts.FormattingEnabled = true;
            this.cbxUnusedTexts.Location = new System.Drawing.Point(328, 257);
            this.cbxUnusedTexts.Name = "cbxUnusedTexts";
            this.cbxUnusedTexts.Size = new System.Drawing.Size(145, 21);
            this.cbxUnusedTexts.TabIndex = 4;
            // 
            // FrmProjectProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.GroupBox_HashCodesDir);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Groupbox_Misc);
            this.Controls.Add(this.GroupBox_SpreadSheetsDir);
            this.Controls.Add(this.GroupBox_MessagesDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProjectProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProjectProperties_FormClosing);
            this.Load += new System.EventHandler(this.FrmProjectProperties_Load);
            this.Groupbox_Misc.ResumeLayout(false);
            this.Groupbox_Misc.PerformLayout();
            this.GroupBox_SpreadSheetsDir.ResumeLayout(false);
            this.GroupBox_SpreadSheetsDir.PerformLayout();
            this.GroupBox_MessagesDir.ResumeLayout(false);
            this.GroupBox_MessagesDir.PerformLayout();
            this.GroupBox_HashCodesDir.ResumeLayout(false);
            this.GroupBox_HashCodesDir.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLanguages.ResumeLayout(false);
            this.tabPageCategories.ResumeLayout(false);
            this.tabPageCategories.PerformLayout();
            this.tabPageTone.ResumeLayout(false);
            this.tabPageVoiceTypes.ResumeLayout(false);
            this.tabPageContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_RemoveCategory;
        private System.Windows.Forms.Button Button_AddCategory;
        private System.Windows.Forms.ListBox Listbox_Categories;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.GroupBox Groupbox_Misc;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.TextBox Textbox_UserName;
        private System.Windows.Forms.TextBox Textbox_HashTablesAdmin;
        private System.Windows.Forms.Label Label_HashTableAdmin;
        private System.Windows.Forms.Button Button_DeleteLanguage;
        private System.Windows.Forms.Button Button_AddLanguage;
        private System.Windows.Forms.ListBox Listbox_Languages;
        private System.Windows.Forms.GroupBox GroupBox_SpreadSheetsDir;
        private System.Windows.Forms.Button Button_SpreadSheetsDir;
        private System.Windows.Forms.TextBox Textbox_SpreadSheetsDir;
        private System.Windows.Forms.GroupBox GroupBox_MessagesDir;
        private System.Windows.Forms.Button Button_MessagesDir;
        private System.Windows.Forms.TextBox Textbox_MessagesDir;
        private System.Windows.Forms.Label Label_MessagesFolder;
        private System.Windows.Forms.GroupBox GroupBox_HashCodesDir;
        private System.Windows.Forms.Button Button_HashCodesDir;
        private System.Windows.Forms.TextBox Textbox_HashCodesDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLanguages;
        private System.Windows.Forms.TabPage tabPageCategories;
        private System.Windows.Forms.TabPage tabPageTone;
        private System.Windows.Forms.Button btnDeleteTone;
        private System.Windows.Forms.Button btnAddTone;
        private System.Windows.Forms.ListBox lbxTone;
        private System.Windows.Forms.TabPage tabPageVoiceTypes;
        private System.Windows.Forms.ListBox lbxGender;
        private System.Windows.Forms.Button btnDeleteGender;
        private System.Windows.Forms.Button btnAddGender;
        private System.Windows.Forms.TabPage tabPageContext;
        private System.Windows.Forms.ListBox lbxContexts;
        private System.Windows.Forms.Button btnDeleteContext;
        private System.Windows.Forms.Button btnAddContext;
        private System.Windows.Forms.ComboBox cbxUnusedTexts;
        private System.Windows.Forms.Label lblUnusedBit;
    }
}