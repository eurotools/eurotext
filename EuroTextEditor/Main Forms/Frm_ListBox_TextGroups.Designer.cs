
namespace EuroTextEditor
{
    partial class Frm_ListBox_TextGroups
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
            this.ListBox_TextGroups = new System.Windows.Forms.ListBox();
            this.ContextMenu_TextGroups = new System.Windows.Forms.ContextMenu();
            this.MenuItem_NewGroup = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // ListBox_TextGroups
            // 
            this.ListBox_TextGroups.ContextMenu = this.ContextMenu_TextGroups;
            this.ListBox_TextGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_TextGroups.FormattingEnabled = true;
            this.ListBox_TextGroups.HorizontalScrollbar = true;
            this.ListBox_TextGroups.Location = new System.Drawing.Point(0, 0);
            this.ListBox_TextGroups.Name = "ListBox_TextGroups";
            this.ListBox_TextGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox_TextGroups.Size = new System.Drawing.Size(270, 395);
            this.ListBox_TextGroups.TabIndex = 0;
            this.ListBox_TextGroups.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_TextGroups_MouseDoubleClick);
            // 
            // ContextMenu_TextGroups
            // 
            this.ContextMenu_TextGroups.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_NewGroup});
            // 
            // MenuItem_NewGroup
            // 
            this.MenuItem_NewGroup.Index = 0;
            this.MenuItem_NewGroup.Text = "Create New Group";
            this.MenuItem_NewGroup.Click += new System.EventHandler(this.MenuItem_NewGroup_Click);
            // 
            // Frm_ListBox_TextGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 395);
            this.Controls.Add(this.ListBox_TextGroups);
            this.Name = "Frm_ListBox_TextGroups";
            this.TabText = "Text Groups";
            this.Text = "Text Groups";
            this.Load += new System.EventHandler(this.Frm_ListBox_TextGroups_Load);
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.ListBox ListBox_TextGroups;
        private System.Windows.Forms.ContextMenu ContextMenu_TextGroups;
        private System.Windows.Forms.MenuItem MenuItem_NewGroup;
    }
}