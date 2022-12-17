
namespace EuroTextEditor
{
    partial class Frm_ListBox_TextSections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListBox_TextSections));
            this.ContextMenu_TextSections = new System.Windows.Forms.ContextMenu();
            this.MenuItem_Refresh = new System.Windows.Forms.MenuItem();
            this.MenuItem_Separator1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_EditSections = new System.Windows.Forms.MenuItem();
            this.ListView_SectionsAndLevels = new EuroTextEditor.Custom_Controls.ListView_ColumnSortingClick();
            this.Col_TextSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_OutputLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_SectionName = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // ContextMenu_TextSections
            // 
            this.ContextMenu_TextSections.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_Refresh,
            this.MenuItem_Separator1,
            this.MenuItem_EditSections,
            this.menuItem1,
            this.MenuItem_SectionName});
            // 
            // MenuItem_Refresh
            // 
            this.MenuItem_Refresh.Index = 0;
            this.MenuItem_Refresh.Text = "Refresh";
            this.MenuItem_Refresh.Click += new System.EventHandler(this.MenuItem_Refresh_Click);
            // 
            // MenuItem_Separator1
            // 
            this.MenuItem_Separator1.Index = 1;
            this.MenuItem_Separator1.Text = "-";
            // 
            // MenuItem_EditSections
            // 
            this.MenuItem_EditSections.Index = 2;
            this.MenuItem_EditSections.Text = "Edit Sections";
            this.MenuItem_EditSections.Click += new System.EventHandler(this.MenuItem_EditSections_Click);
            // 
            // ListView_SectionsAndLevels
            // 
            this.ListView_SectionsAndLevels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_TextSection,
            this.Col_OutputLevel});
            this.ListView_SectionsAndLevels.ContextMenu = this.ContextMenu_TextSections;
            this.ListView_SectionsAndLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_SectionsAndLevels.FullRowSelect = true;
            this.ListView_SectionsAndLevels.GridLines = true;
            this.ListView_SectionsAndLevels.HideSelection = false;
            this.ListView_SectionsAndLevels.Location = new System.Drawing.Point(0, 0);
            this.ListView_SectionsAndLevels.Name = "ListView_SectionsAndLevels";
            this.ListView_SectionsAndLevels.Size = new System.Drawing.Size(353, 374);
            this.ListView_SectionsAndLevels.TabIndex = 0;
            this.ListView_SectionsAndLevels.UseCompatibleStateImageBehavior = false;
            this.ListView_SectionsAndLevels.View = System.Windows.Forms.View.Details;
            this.ListView_SectionsAndLevels.DoubleClick += new System.EventHandler(this.ListView_SectionsAndLevels_DoubleClick);
            // 
            // Col_TextSection
            // 
            this.Col_TextSection.Text = "Num";
            this.Col_TextSection.Width = 110;
            // 
            // Col_OutputLevel
            // 
            this.Col_OutputLevel.Text = "Level";
            this.Col_OutputLevel.Width = 180;
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.Text = "-";
            // 
            // MenuItem_SectionName
            // 
            this.MenuItem_SectionName.Index = 4;
            this.MenuItem_SectionName.Text = "Copy Section Name";
            this.MenuItem_SectionName.Click += new System.EventHandler(this.MenuItem_SectionName_Click);
            // 
            // Frm_ListBox_TextSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 374);
            this.Controls.Add(this.ListView_SectionsAndLevels);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ListBox_TextSections";
            this.TabText = "Text Sections";
            this.Text = "Text Sections";
            this.ResumeLayout(false);

        }

        #endregion
        protected internal EuroTextEditor.Custom_Controls.ListView_ColumnSortingClick ListView_SectionsAndLevels;
        private System.Windows.Forms.ColumnHeader Col_TextSection;
        private System.Windows.Forms.ColumnHeader Col_OutputLevel;
        private System.Windows.Forms.ContextMenu ContextMenu_TextSections;
        private System.Windows.Forms.MenuItem MenuItem_Refresh;
        private System.Windows.Forms.MenuItem MenuItem_Separator1;
        private System.Windows.Forms.MenuItem MenuItem_EditSections;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem MenuItem_SectionName;
    }
}