
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
            this.Textbox_SearchBarHashCodes = new System.Windows.Forms.TextBox();
            this.ListBox_HashCodes = new System.Windows.Forms.ListBox();
            this.ContextMenu_HashCodes = new System.Windows.Forms.ContextMenu();
            this.MenuItem_Edit = new System.Windows.Forms.MenuItem();
            this.MenuItem_New = new System.Windows.Forms.MenuItem();
            this.MenuItem_Delete = new System.Windows.Forms.MenuItem();
            this.MenuItem_Rename = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.MenuItem_SetGroup = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_MultiEditor = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.MenuItem_Refresh = new System.Windows.Forms.MenuItem();
            this.GroupBox_Search = new System.Windows.Forms.GroupBox();
            this.GroupBox_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // Textbox_SearchBarHashCodes
            // 
            this.Textbox_SearchBarHashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_SearchBarHashCodes.Location = new System.Drawing.Point(6, 19);
            this.Textbox_SearchBarHashCodes.Name = "Textbox_SearchBarHashCodes";
            this.Textbox_SearchBarHashCodes.Size = new System.Drawing.Size(297, 20);
            this.Textbox_SearchBarHashCodes.TabIndex = 4;
            this.Textbox_SearchBarHashCodes.TextChanged += new System.EventHandler(this.Textbox_SearchBarHashCodes_TextChanged);
            // 
            // ListBox_HashCodes
            // 
            this.ListBox_HashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_HashCodes.FormattingEnabled = true;
            this.ListBox_HashCodes.HorizontalScrollbar = true;
            this.ListBox_HashCodes.Location = new System.Drawing.Point(0, 57);
            this.ListBox_HashCodes.Name = "ListBox_HashCodes";
            this.ListBox_HashCodes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox_HashCodes.Size = new System.Drawing.Size(309, 381);
            this.ListBox_HashCodes.Sorted = true;
            this.ListBox_HashCodes.TabIndex = 1;
            this.ListBox_HashCodes.ContextMenu = this.ContextMenu_HashCodes;
            this.ListBox_HashCodes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_HashCodes_MouseDoubleClick);
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
            this.menuItem1,
            this.MenuItem_MultiEditor,
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
            // menuItem1
            // 
            this.menuItem1.Index = 6;
            this.menuItem1.Text = "-";
            // 
            // MenuItem_MultiEditor
            // 
            this.MenuItem_MultiEditor.Index = 7;
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
            // GroupBox_Search
            // 
            this.GroupBox_Search.Controls.Add(this.Textbox_SearchBarHashCodes);
            this.GroupBox_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox_Search.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Search.Name = "GroupBox_Search";
            this.GroupBox_Search.Size = new System.Drawing.Size(309, 51);
            this.GroupBox_Search.TabIndex = 6;
            this.GroupBox_Search.TabStop = false;
            this.GroupBox_Search.Text = "Search";
            // 
            // Frm_ListBoxHashCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 448);
            this.Controls.Add(this.GroupBox_Search);
            this.Controls.Add(this.ListBox_HashCodes);
            this.Name = "Frm_ListBoxHashCodes";
            this.TabText = "HashCodes";
            this.Text = "HashCodes";
            this.Load += new System.EventHandler(this.Frm_ListBoxHashCodes_Load);
            this.GroupBox_Search.ResumeLayout(false);
            this.GroupBox_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Textbox_SearchBarHashCodes;
        protected internal System.Windows.Forms.ListBox ListBox_HashCodes;
        private System.Windows.Forms.ContextMenu ContextMenu_HashCodes;
        private System.Windows.Forms.MenuItem MenuItem_Edit;
        private System.Windows.Forms.MenuItem MenuItem_New;
        private System.Windows.Forms.MenuItem MenuItem_Delete;
        private System.Windows.Forms.MenuItem MenuItem_Rename;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem MenuItem_SetGroup;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem MenuItem_MultiEditor;
        private System.Windows.Forms.GroupBox GroupBox_Search;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem MenuItem_Refresh;
    }
}