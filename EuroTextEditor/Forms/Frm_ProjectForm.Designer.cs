
namespace EuroTextEditor
{
    partial class Frm_ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProjectForm));
            this.GroupBox_MessagesDir = new System.Windows.Forms.GroupBox();
            this.Button_MessagesDir = new System.Windows.Forms.Button();
            this.Textbox_MessagesDir = new System.Windows.Forms.TextBox();
            this.Label_MessagesFolder = new System.Windows.Forms.Label();
            this.GroupBox_SpreadSheetsDir = new System.Windows.Forms.GroupBox();
            this.Button_SpreadSheetsDir = new System.Windows.Forms.Button();
            this.Textbox_SpreadSheetsDir = new System.Windows.Forms.TextBox();
            this.GroupBox_HashCodesDir = new System.Windows.Forms.GroupBox();
            this.Button_HashCodesDir = new System.Windows.Forms.Button();
            this.Textbox_HashCodesDir = new System.Windows.Forms.TextBox();
            this.GroupBox_Languages = new System.Windows.Forms.GroupBox();
            this.Button_DeleteLanguage = new System.Windows.Forms.Button();
            this.Button_AddLanguage = new System.Windows.Forms.Button();
            this.Listbox_Languages = new System.Windows.Forms.ListBox();
            this.Groupbox_Misc = new System.Windows.Forms.GroupBox();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Textbox_UserName = new System.Windows.Forms.TextBox();
            this.Textbox_HashTablesAdmin = new System.Windows.Forms.TextBox();
            this.Label_HashTableAdmin = new System.Windows.Forms.Label();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox_MessagesDir.SuspendLayout();
            this.GroupBox_SpreadSheetsDir.SuspendLayout();
            this.GroupBox_HashCodesDir.SuspendLayout();
            this.GroupBox_Languages.SuspendLayout();
            this.Groupbox_Misc.SuspendLayout();
            this.SuspendLayout();
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
            this.GroupBox_MessagesDir.Size = new System.Drawing.Size(521, 47);
            this.GroupBox_MessagesDir.TabIndex = 0;
            this.GroupBox_MessagesDir.TabStop = false;
            this.GroupBox_MessagesDir.Text = "Messages Directory";
            // 
            // Button_MessagesDir
            // 
            this.Button_MessagesDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_MessagesDir.Location = new System.Drawing.Point(440, 17);
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
            this.Textbox_MessagesDir.Size = new System.Drawing.Size(348, 20);
            this.Textbox_MessagesDir.TabIndex = 0;
            // 
            // Label_MessagesFolder
            // 
            this.Label_MessagesFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_MessagesFolder.AutoSize = true;
            this.Label_MessagesFolder.Location = new System.Drawing.Point(360, 22);
            this.Label_MessagesFolder.Name = "Label_MessagesFolder";
            this.Label_MessagesFolder.Size = new System.Drawing.Size(74, 13);
            this.Label_MessagesFolder.TabIndex = 1;
            this.Label_MessagesFolder.Text = "+ \\Messages\\";
            // 
            // GroupBox_SpreadSheetsDir
            // 
            this.GroupBox_SpreadSheetsDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_SpreadSheetsDir.Controls.Add(this.Button_SpreadSheetsDir);
            this.GroupBox_SpreadSheetsDir.Controls.Add(this.Textbox_SpreadSheetsDir);
            this.GroupBox_SpreadSheetsDir.Location = new System.Drawing.Point(12, 65);
            this.GroupBox_SpreadSheetsDir.Name = "GroupBox_SpreadSheetsDir";
            this.GroupBox_SpreadSheetsDir.Size = new System.Drawing.Size(521, 47);
            this.GroupBox_SpreadSheetsDir.TabIndex = 1;
            this.GroupBox_SpreadSheetsDir.TabStop = false;
            this.GroupBox_SpreadSheetsDir.Text = "SpreadSheets Directory";
            // 
            // Button_SpreadSheetsDir
            // 
            this.Button_SpreadSheetsDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SpreadSheetsDir.Location = new System.Drawing.Point(440, 17);
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
            this.Textbox_SpreadSheetsDir.Size = new System.Drawing.Size(348, 20);
            this.Textbox_SpreadSheetsDir.TabIndex = 3;
            // 
            // GroupBox_HashCodesDir
            // 
            this.GroupBox_HashCodesDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_HashCodesDir.Controls.Add(this.Button_HashCodesDir);
            this.GroupBox_HashCodesDir.Controls.Add(this.Textbox_HashCodesDir);
            this.GroupBox_HashCodesDir.Location = new System.Drawing.Point(12, 118);
            this.GroupBox_HashCodesDir.Name = "GroupBox_HashCodesDir";
            this.GroupBox_HashCodesDir.Size = new System.Drawing.Size(521, 47);
            this.GroupBox_HashCodesDir.TabIndex = 6;
            this.GroupBox_HashCodesDir.TabStop = false;
            this.GroupBox_HashCodesDir.Text = "EuroLand HashCodes Server Path";
            // 
            // Button_HashCodesDir
            // 
            this.Button_HashCodesDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_HashCodesDir.Location = new System.Drawing.Point(440, 17);
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
            this.Textbox_HashCodesDir.Size = new System.Drawing.Size(348, 20);
            this.Textbox_HashCodesDir.TabIndex = 3;
            // 
            // GroupBox_Languages
            // 
            this.GroupBox_Languages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Languages.Controls.Add(this.Button_DeleteLanguage);
            this.GroupBox_Languages.Controls.Add(this.Button_AddLanguage);
            this.GroupBox_Languages.Controls.Add(this.Listbox_Languages);
            this.GroupBox_Languages.Location = new System.Drawing.Point(12, 171);
            this.GroupBox_Languages.Name = "GroupBox_Languages";
            this.GroupBox_Languages.Size = new System.Drawing.Size(521, 247);
            this.GroupBox_Languages.TabIndex = 7;
            this.GroupBox_Languages.TabStop = false;
            this.GroupBox_Languages.Text = "Languages";
            // 
            // Button_DeleteLanguage
            // 
            this.Button_DeleteLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_DeleteLanguage.Location = new System.Drawing.Point(131, 218);
            this.Button_DeleteLanguage.Name = "Button_DeleteLanguage";
            this.Button_DeleteLanguage.Size = new System.Drawing.Size(99, 23);
            this.Button_DeleteLanguage.TabIndex = 2;
            this.Button_DeleteLanguage.Text = "Delete Language";
            this.Button_DeleteLanguage.UseVisualStyleBackColor = true;
            this.Button_DeleteLanguage.Click += new System.EventHandler(this.Button_DeleteLanguage_Click);
            // 
            // Button_AddLanguage
            // 
            this.Button_AddLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_AddLanguage.Location = new System.Drawing.Point(6, 218);
            this.Button_AddLanguage.Name = "Button_AddLanguage";
            this.Button_AddLanguage.Size = new System.Drawing.Size(119, 23);
            this.Button_AddLanguage.TabIndex = 1;
            this.Button_AddLanguage.Text = "Add New Language";
            this.Button_AddLanguage.UseVisualStyleBackColor = true;
            this.Button_AddLanguage.Click += new System.EventHandler(this.Button_AddLanguage_Click);
            // 
            // Listbox_Languages
            // 
            this.Listbox_Languages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listbox_Languages.FormattingEnabled = true;
            this.Listbox_Languages.Location = new System.Drawing.Point(6, 19);
            this.Listbox_Languages.Name = "Listbox_Languages";
            this.Listbox_Languages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Listbox_Languages.Size = new System.Drawing.Size(509, 186);
            this.Listbox_Languages.TabIndex = 0;
            // 
            // Groupbox_Misc
            // 
            this.Groupbox_Misc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Groupbox_Misc.Controls.Add(this.Label_Username);
            this.Groupbox_Misc.Controls.Add(this.Textbox_UserName);
            this.Groupbox_Misc.Controls.Add(this.Textbox_HashTablesAdmin);
            this.Groupbox_Misc.Controls.Add(this.Label_HashTableAdmin);
            this.Groupbox_Misc.Location = new System.Drawing.Point(12, 424);
            this.Groupbox_Misc.Name = "Groupbox_Misc";
            this.Groupbox_Misc.Size = new System.Drawing.Size(521, 72);
            this.Groupbox_Misc.TabIndex = 8;
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
            this.Textbox_UserName.Size = new System.Drawing.Size(384, 20);
            this.Textbox_UserName.TabIndex = 2;
            this.Textbox_UserName.DoubleClick += new System.EventHandler(this.Textbox_UserName_DoubleClick);
            // 
            // Textbox_HashTablesAdmin
            // 
            this.Textbox_HashTablesAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_HashTablesAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_HashTablesAdmin.Location = new System.Drawing.Point(131, 19);
            this.Textbox_HashTablesAdmin.Name = "Textbox_HashTablesAdmin";
            this.Textbox_HashTablesAdmin.ReadOnly = true;
            this.Textbox_HashTablesAdmin.Size = new System.Drawing.Size(384, 20);
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
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.Location = new System.Drawing.Point(377, 502);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 9;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(458, 502);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 10;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
            // 
            // Frm_ProjectForm
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(545, 537);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Groupbox_Misc);
            this.Controls.Add(this.GroupBox_Languages);
            this.Controls.Add(this.GroupBox_HashCodesDir);
            this.Controls.Add(this.GroupBox_SpreadSheetsDir);
            this.Controls.Add(this.GroupBox_MessagesDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ProjectForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Properties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ProjectForm_FormClosing);
            this.Load += new System.EventHandler(this.Frm_ProjectForm_Load);
            this.GroupBox_MessagesDir.ResumeLayout(false);
            this.GroupBox_MessagesDir.PerformLayout();
            this.GroupBox_SpreadSheetsDir.ResumeLayout(false);
            this.GroupBox_SpreadSheetsDir.PerformLayout();
            this.GroupBox_HashCodesDir.ResumeLayout(false);
            this.GroupBox_HashCodesDir.PerformLayout();
            this.GroupBox_Languages.ResumeLayout(false);
            this.Groupbox_Misc.ResumeLayout(false);
            this.Groupbox_Misc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_MessagesDir;
        private System.Windows.Forms.Button Button_MessagesDir;
        private System.Windows.Forms.TextBox Textbox_MessagesDir;
        private System.Windows.Forms.Label Label_MessagesFolder;
        private System.Windows.Forms.GroupBox GroupBox_SpreadSheetsDir;
        private System.Windows.Forms.Button Button_SpreadSheetsDir;
        private System.Windows.Forms.TextBox Textbox_SpreadSheetsDir;
        private System.Windows.Forms.GroupBox GroupBox_HashCodesDir;
        private System.Windows.Forms.Button Button_HashCodesDir;
        private System.Windows.Forms.TextBox Textbox_HashCodesDir;
        private System.Windows.Forms.GroupBox GroupBox_Languages;
        private System.Windows.Forms.ListBox Listbox_Languages;
        private System.Windows.Forms.GroupBox Groupbox_Misc;
        private System.Windows.Forms.TextBox Textbox_HashTablesAdmin;
        private System.Windows.Forms.Label Label_HashTableAdmin;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_DeleteLanguage;
        private System.Windows.Forms.Button Button_AddLanguage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.TextBox Textbox_UserName;
    }
}