﻿
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
            this.ListView_SectionsAndLevels = new System.Windows.Forms.ListView();
            this.Col_TextSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_OutputLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenu_TextSections = new System.Windows.Forms.ContextMenu();
            this.MenuItem_NewSection = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
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
            this.ListView_SectionsAndLevels.Size = new System.Drawing.Size(270, 395);
            this.ListView_SectionsAndLevels.TabIndex = 0;
            this.ListView_SectionsAndLevels.UseCompatibleStateImageBehavior = false;
            this.ListView_SectionsAndLevels.View = System.Windows.Forms.View.Details;
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
            // ContextMenu_TextSections
            // 
            this.ContextMenu_TextSections.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_NewSection});
            // 
            // MenuItem_NewSection
            // 
            this.MenuItem_NewSection.Index = 0;
            this.MenuItem_NewSection.Text = "Create New Section";
            this.MenuItem_NewSection.Click += new System.EventHandler(this.MenuItem_NewSection_Click);
            // 
            // Frm_ListBox_TextSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 395);
            this.Controls.Add(this.ListView_SectionsAndLevels);
            this.Name = "Frm_ListBox_TextSections";
            this.TabText = "Text Sections";
            this.Text = "Text Sections";
            this.Load += new System.EventHandler(this.Frm_ListBox_TextSections_Load);
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.ListView ListView_SectionsAndLevels;
        private System.Windows.Forms.ColumnHeader Col_TextSection;
        private System.Windows.Forms.ColumnHeader Col_OutputLevel;
        private System.Windows.Forms.ContextMenu ContextMenu_TextSections;
        private System.Windows.Forms.MenuItem MenuItem_NewSection;
    }
}