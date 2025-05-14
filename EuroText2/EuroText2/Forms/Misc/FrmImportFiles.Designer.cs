
namespace EuroText2
{
    partial class FrmImportFiles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportFiles));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSetFlags = new System.Windows.Forms.CheckBox();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxOutputGroup = new System.Windows.Forms.ComboBox();
            this.chkOverWriteGroup = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOutSections = new System.Windows.Forms.TextBox();
            this.chkOverwriteSections = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStartImport = new System.Windows.Forms.Button();
            this.chkOverwriteFiles = new System.Windows.Forms.CheckBox();
            this.chkListFilesToImport = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUncheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.grbxFilesToImport = new System.Windows.Forms.GroupBox();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemCopyName = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.grbxFilesToImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFileName.Location = new System.Drawing.Point(44, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(442, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(492, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 20);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkSetFlags);
            this.groupBox1.Controls.Add(this.txtFlags);
            this.groupBox1.Location = new System.Drawing.Point(244, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // chkSetFlags
            // 
            this.chkSetFlags.AutoSize = true;
            this.chkSetFlags.Location = new System.Drawing.Point(6, 0);
            this.chkSetFlags.Name = "chkSetFlags";
            this.chkSetFlags.Size = new System.Drawing.Size(99, 17);
            this.chkSetFlags.TabIndex = 1;
            this.chkSetFlags.Text = "Overwrite Flags";
            this.chkSetFlags.UseVisualStyleBackColor = true;
            this.chkSetFlags.CheckedChanged += new System.EventHandler(this.ChkSetFlags_CheckedChanged);
            // 
            // txtFlags
            // 
            this.txtFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlags.BackColor = System.Drawing.SystemColors.Window;
            this.txtFlags.Location = new System.Drawing.Point(6, 19);
            this.txtFlags.Name = "txtFlags";
            this.txtFlags.ReadOnly = true;
            this.txtFlags.Size = new System.Drawing.Size(260, 20);
            this.txtFlags.TabIndex = 0;
            this.txtFlags.Tag = "0";
            this.txtFlags.Click += new System.EventHandler(this.TxtFlags_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbxOutputGroup);
            this.groupBox2.Controls.Add(this.chkOverWriteGroup);
            this.groupBox2.Location = new System.Drawing.Point(244, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 54);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // cbxOutputGroup
            // 
            this.cbxOutputGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOutputGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutputGroup.FormattingEnabled = true;
            this.cbxOutputGroup.Location = new System.Drawing.Point(6, 23);
            this.cbxOutputGroup.Name = "cbxOutputGroup";
            this.cbxOutputGroup.Size = new System.Drawing.Size(260, 21);
            this.cbxOutputGroup.TabIndex = 3;
            // 
            // chkOverWriteGroup
            // 
            this.chkOverWriteGroup.AutoSize = true;
            this.chkOverWriteGroup.Location = new System.Drawing.Point(6, 0);
            this.chkOverWriteGroup.Name = "chkOverWriteGroup";
            this.chkOverWriteGroup.Size = new System.Drawing.Size(103, 17);
            this.chkOverWriteGroup.TabIndex = 2;
            this.chkOverWriteGroup.Text = "Overwrite Group";
            this.chkOverWriteGroup.UseVisualStyleBackColor = true;
            this.chkOverWriteGroup.CheckedChanged += new System.EventHandler(this.ChkOverWriteGroup_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtOutSections);
            this.groupBox3.Controls.Add(this.chkOverwriteSections);
            this.groupBox3.Location = new System.Drawing.Point(244, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 53);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // txtOutSections
            // 
            this.txtOutSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutSections.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutSections.Location = new System.Drawing.Point(6, 19);
            this.txtOutSections.Name = "txtOutSections";
            this.txtOutSections.ReadOnly = true;
            this.txtOutSections.Size = new System.Drawing.Size(260, 20);
            this.txtOutSections.TabIndex = 2;
            this.txtOutSections.Click += new System.EventHandler(this.TxtOutSections_Click);
            // 
            // chkOverwriteSections
            // 
            this.chkOverwriteSections.AutoSize = true;
            this.chkOverwriteSections.Location = new System.Drawing.Point(6, 0);
            this.chkOverwriteSections.Name = "chkOverwriteSections";
            this.chkOverwriteSections.Size = new System.Drawing.Size(115, 17);
            this.chkOverwriteSections.TabIndex = 4;
            this.chkOverwriteSections.Text = "Overwrite Sections";
            this.chkOverwriteSections.UseVisualStyleBackColor = true;
            this.chkOverwriteSections.CheckedChanged += new System.EventHandler(this.ChkOverwriteSections_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // btnStartImport
            // 
            this.btnStartImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartImport.Location = new System.Drawing.Point(441, 458);
            this.btnStartImport.Name = "btnStartImport";
            this.btnStartImport.Size = new System.Drawing.Size(75, 23);
            this.btnStartImport.TabIndex = 6;
            this.btnStartImport.Text = "Run Import";
            this.btnStartImport.UseVisualStyleBackColor = true;
            this.btnStartImport.Click += new System.EventHandler(this.BtnStartImport_Click);
            // 
            // chkOverwriteFiles
            // 
            this.chkOverwriteFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOverwriteFiles.AutoSize = true;
            this.chkOverwriteFiles.Location = new System.Drawing.Point(424, 214);
            this.chkOverwriteFiles.Name = "chkOverwriteFiles";
            this.chkOverwriteFiles.Size = new System.Drawing.Size(92, 17);
            this.chkOverwriteFiles.TabIndex = 7;
            this.chkOverwriteFiles.Text = "Overwrite files";
            this.chkOverwriteFiles.UseVisualStyleBackColor = true;
            // 
            // chkListFilesToImport
            // 
            this.chkListFilesToImport.CheckOnClick = true;
            this.chkListFilesToImport.ContextMenuStrip = this.contextMenuStrip1;
            this.chkListFilesToImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListFilesToImport.FormattingEnabled = true;
            this.chkListFilesToImport.HorizontalScrollbar = true;
            this.chkListFilesToImport.Location = new System.Drawing.Point(3, 16);
            this.chkListFilesToImport.Name = "chkListFilesToImport";
            this.chkListFilesToImport.Size = new System.Drawing.Size(220, 411);
            this.chkListFilesToImport.Sorted = true;
            this.chkListFilesToImport.TabIndex = 8;
            this.chkListFilesToImport.Click += new System.EventHandler(this.ChkListFilesToImport_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCheckAll,
            this.MenuItemUncheckAll,
            this.MenuItemInvert,
            this.toolStripSeparator1,
            this.MenuItemCopyName});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 120);
            // 
            // MenuItemCheckAll
            // 
            this.MenuItemCheckAll.Name = "MenuItemCheckAll";
            this.MenuItemCheckAll.Size = new System.Drawing.Size(180, 22);
            this.MenuItemCheckAll.Text = "Check All";
            this.MenuItemCheckAll.Click += new System.EventHandler(this.MenuItemCheckAll_Click);
            // 
            // MenuItemUncheckAll
            // 
            this.MenuItemUncheckAll.Name = "MenuItemUncheckAll";
            this.MenuItemUncheckAll.Size = new System.Drawing.Size(180, 22);
            this.MenuItemUncheckAll.Text = "Uncheck All";
            this.MenuItemUncheckAll.Click += new System.EventHandler(this.MenuItemUncheckAll_Click);
            // 
            // MenuItemInvert
            // 
            this.MenuItemInvert.Name = "MenuItemInvert";
            this.MenuItemInvert.Size = new System.Drawing.Size(180, 22);
            this.MenuItemInvert.Text = "Invert Selection";
            this.MenuItemInvert.Click += new System.EventHandler(this.MenuItemInvert_Click);
            // 
            // grbxFilesToImport
            // 
            this.grbxFilesToImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxFilesToImport.Controls.Add(this.chkListFilesToImport);
            this.grbxFilesToImport.Location = new System.Drawing.Point(12, 38);
            this.grbxFilesToImport.Name = "grbxFilesToImport";
            this.grbxFilesToImport.Size = new System.Drawing.Size(226, 430);
            this.grbxFilesToImport.TabIndex = 9;
            this.grbxFilesToImport.TabStop = false;
            this.grbxFilesToImport.Text = "Dialog Files";
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.Location = new System.Drawing.Point(12, 471);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(43, 13);
            this.lblTotalFiles.TabIndex = 10;
            this.lblTotalFiles.Text = "Total: 0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItemCopyName
            // 
            this.MenuItemCopyName.Name = "MenuItemCopyName";
            this.MenuItemCopyName.Size = new System.Drawing.Size(180, 22);
            this.MenuItemCopyName.Text = "Copy Name";
            this.MenuItemCopyName.Click += new System.EventHandler(this.MenuItemCopyName_Click);
            // 
            // FrmImportFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 493);
            this.Controls.Add(this.lblTotalFiles);
            this.Controls.Add(this.grbxFilesToImport);
            this.Controls.Add(this.chkOverwriteFiles);
            this.Controls.Add(this.btnStartImport);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportFiles";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Text Files";
            this.Load += new System.EventHandler(this.FrmImportFiles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grbxFilesToImport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSetFlags;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxOutputGroup;
        private System.Windows.Forms.CheckBox chkOverWriteGroup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOutSections;
        private System.Windows.Forms.CheckBox chkOverwriteSections;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnStartImport;
        private System.Windows.Forms.CheckBox chkOverwriteFiles;
        private System.Windows.Forms.CheckedListBox chkListFilesToImport;
        private System.Windows.Forms.GroupBox grbxFilesToImport;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCheckAll;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUncheckAll;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInvert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCopyName;
    }
}