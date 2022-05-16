
namespace EuroTextEditor
{
    partial class Frm_ListBoxHashCodes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListBoxHashCodes));
            this.ContextMenu_HashCodes = new System.Windows.Forms.ContextMenu();
            this.MenuItem_Edit = new System.Windows.Forms.MenuItem();
            this.MenuItem_New = new System.Windows.Forms.MenuItem();
            this.MenuItem_Delete = new System.Windows.Forms.MenuItem();
            this.MenuItem_Rename = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.MenuItem_SetGroup = new System.Windows.Forms.MenuItem();
            this.MenuItem_MultiEditor = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.MenuItem_Refresh = new System.Windows.Forms.MenuItem();
            this.ListView_HashCodes = new System.Windows.Forms.ListView();
            this.Col_HashCodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_FirstCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_FirstCreatedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_LastModify = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_LastModifyBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Textbox_SearchBarHashCodes = new System.Windows.Forms.TextBox();
            this.GroupBox_Search = new System.Windows.Forms.GroupBox();
            this.CheckBox_ExactMatch = new System.Windows.Forms.CheckBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.MenuItem_Color = new System.Windows.Forms.MenuItem();
            this.MenuItem_RemoveColor = new System.Windows.Forms.MenuItem();
            this.MenuItem_SetColor = new System.Windows.Forms.MenuItem();
            this.GroupBox_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenu_HashCodes
            // 
            this.ContextMenu_HashCodes.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_Edit,
            this.MenuItem_New,
            this.MenuItem_Delete,
            this.MenuItem_Rename,
            this.menuItem4,
            this.MenuItem_SetGroup,
            this.MenuItem_MultiEditor,
            this.MenuItem_Color,
            this.menuItem2,
            this.MenuItem_Refresh});
            // 
            // MenuItem_Edit
            // 
            this.MenuItem_Edit.Index = 0;
            this.MenuItem_Edit.Text = "Edit";
            this.MenuItem_Edit.Click += new System.EventHandler(this.MenuItem_Edit_Click);
            // 
            // MenuItem_New
            // 
            this.MenuItem_New.Index = 1;
            this.MenuItem_New.Text = "New";
            this.MenuItem_New.Click += new System.EventHandler(this.MenuItem_New_Click);
            // 
            // MenuItem_Delete
            // 
            this.MenuItem_Delete.Index = 2;
            this.MenuItem_Delete.Text = "Delete";
            this.MenuItem_Delete.Click += new System.EventHandler(this.MenuItem_Delete_Click);
            // 
            // MenuItem_Rename
            // 
            this.MenuItem_Rename.Index = 3;
            this.MenuItem_Rename.Text = "Rename";
            this.MenuItem_Rename.Click += new System.EventHandler(this.MenuItem_Rename_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.Text = "-";
            // 
            // MenuItem_SetGroup
            // 
            this.MenuItem_SetGroup.Index = 5;
            this.MenuItem_SetGroup.Text = "Set Group";
            this.MenuItem_SetGroup.Click += new System.EventHandler(this.MenuItem_SetGroup_Click);
            // 
            // MenuItem_MultiEditor
            // 
            this.MenuItem_MultiEditor.Index = 6;
            this.MenuItem_MultiEditor.Text = "Multi Editor";
            this.MenuItem_MultiEditor.Click += new System.EventHandler(this.MenuItem_MultiEditor_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 8;
            this.menuItem2.Text = "-";
            // 
            // MenuItem_Refresh
            // 
            this.MenuItem_Refresh.Index = 9;
            this.MenuItem_Refresh.Text = "Refresh";
            this.MenuItem_Refresh.Click += new System.EventHandler(this.MenuItem_Refresh_Click);
            // 
            // ListView_HashCodes
            // 
            this.ListView_HashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_HashCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_HashCodes,
            this.Col_FirstCreated,
            this.Col_FirstCreatedBy,
            this.Col_LastModify,
            this.Col_LastModifyBy});
            this.ListView_HashCodes.ContextMenu = this.ContextMenu_HashCodes;
            this.ListView_HashCodes.FullRowSelect = true;
            this.ListView_HashCodes.GridLines = true;
            this.ListView_HashCodes.HideSelection = false;
            this.ListView_HashCodes.Location = new System.Drawing.Point(0, 57);
            this.ListView_HashCodes.Name = "ListView_HashCodes";
            this.ListView_HashCodes.Size = new System.Drawing.Size(378, 421);
            this.ListView_HashCodes.TabIndex = 7;
            this.ListView_HashCodes.UseCompatibleStateImageBehavior = false;
            this.ListView_HashCodes.View = System.Windows.Forms.View.Details;
            this.ListView_HashCodes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_HashCodes_MouseDoubleClick);
            // 
            // Col_HashCodes
            // 
            this.Col_HashCodes.Text = "HashCode";
            this.Col_HashCodes.Width = 200;
            // 
            // Col_FirstCreated
            // 
            this.Col_FirstCreated.Text = "First Created";
            this.Col_FirstCreated.Width = 130;
            // 
            // Col_FirstCreatedBy
            // 
            this.Col_FirstCreatedBy.Text = "Created By";
            this.Col_FirstCreatedBy.Width = 130;
            // 
            // Col_LastModify
            // 
            this.Col_LastModify.Text = "Last Modify";
            this.Col_LastModify.Width = 130;
            // 
            // Col_LastModifyBy
            // 
            this.Col_LastModifyBy.Text = "Last Modify By";
            this.Col_LastModifyBy.Width = 130;
            // 
            // Textbox_SearchBarHashCodes
            // 
            this.Textbox_SearchBarHashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_SearchBarHashCodes.Location = new System.Drawing.Point(6, 19);
            this.Textbox_SearchBarHashCodes.Name = "Textbox_SearchBarHashCodes";
            this.Textbox_SearchBarHashCodes.Size = new System.Drawing.Size(219, 20);
            this.Textbox_SearchBarHashCodes.TabIndex = 4;
            // 
            // GroupBox_Search
            // 
            this.GroupBox_Search.Controls.Add(this.CheckBox_ExactMatch);
            this.GroupBox_Search.Controls.Add(this.Button_Search);
            this.GroupBox_Search.Controls.Add(this.Textbox_SearchBarHashCodes);
            this.GroupBox_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox_Search.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Search.Name = "GroupBox_Search";
            this.GroupBox_Search.Size = new System.Drawing.Size(378, 51);
            this.GroupBox_Search.TabIndex = 6;
            this.GroupBox_Search.TabStop = false;
            this.GroupBox_Search.Text = "Search";
            // 
            // CheckBox_ExactMatch
            // 
            this.CheckBox_ExactMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBox_ExactMatch.AutoSize = true;
            this.CheckBox_ExactMatch.Location = new System.Drawing.Point(231, 21);
            this.CheckBox_ExactMatch.Name = "CheckBox_ExactMatch";
            this.CheckBox_ExactMatch.Size = new System.Drawing.Size(86, 17);
            this.CheckBox_ExactMatch.TabIndex = 6;
            this.CheckBox_ExactMatch.Text = "Exact Match";
            this.CheckBox_ExactMatch.UseVisualStyleBackColor = true;
            // 
            // Button_Search
            // 
            this.Button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Search.Location = new System.Drawing.Point(323, 17);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(49, 23);
            this.Button_Search.TabIndex = 5;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // MenuItem_Color
            // 
            this.MenuItem_Color.Index = 7;
            this.MenuItem_Color.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_RemoveColor,
            this.MenuItem_SetColor});
            this.MenuItem_Color.Text = "Color";
            // 
            // MenuItem_RemoveColor
            // 
            this.MenuItem_RemoveColor.Index = 0;
            this.MenuItem_RemoveColor.Text = "Remove";
            this.MenuItem_RemoveColor.Click += new System.EventHandler(this.MenuItem_RemoveColor_Click);
            // 
            // MenuItem_SetColor
            // 
            this.MenuItem_SetColor.Index = 1;
            this.MenuItem_SetColor.Text = "Set Color";
            this.MenuItem_SetColor.Click += new System.EventHandler(this.MenuItem_SetColor_Click);
            // 
            // Frm_ListBoxHashCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 478);
            this.Controls.Add(this.ListView_HashCodes);
            this.Controls.Add(this.GroupBox_Search);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ListBoxHashCodes";
            this.TabText = "HashCodes";
            this.Text = "HashCodes";
            this.Shown += new System.EventHandler(this.Frm_ListBoxHashCodes_Shown);
            this.VisibleChanged += new System.EventHandler(this.Frm_ListBoxHashCodes_VisibleChanged);
            this.GroupBox_Search.ResumeLayout(false);
            this.GroupBox_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenu ContextMenu_HashCodes;
        private System.Windows.Forms.MenuItem MenuItem_Edit;
        private System.Windows.Forms.MenuItem MenuItem_New;
        private System.Windows.Forms.MenuItem MenuItem_Delete;
        private System.Windows.Forms.MenuItem MenuItem_Rename;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem MenuItem_SetGroup;
        private System.Windows.Forms.MenuItem MenuItem_MultiEditor;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem MenuItem_Refresh;
        private System.Windows.Forms.ColumnHeader Col_HashCodes;
        private System.Windows.Forms.ColumnHeader Col_FirstCreated;
        private System.Windows.Forms.ColumnHeader Col_FirstCreatedBy;
        private System.Windows.Forms.ColumnHeader Col_LastModify;
        private System.Windows.Forms.ColumnHeader Col_LastModifyBy;
        protected internal System.Windows.Forms.ListView ListView_HashCodes;
        private System.Windows.Forms.TextBox Textbox_SearchBarHashCodes;
        private System.Windows.Forms.GroupBox GroupBox_Search;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.CheckBox CheckBox_ExactMatch;
        private System.Windows.Forms.MenuItem MenuItem_Color;
        private System.Windows.Forms.MenuItem MenuItem_RemoveColor;
        private System.Windows.Forms.MenuItem MenuItem_SetColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}