
namespace EuroText2
{
    partial class FrmProjectsCompare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectsCompare));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProjectFolder = new System.Windows.Forms.Button();
            this.txtProjectToCheck = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.grbxResults = new System.Windows.Forms.GroupBox();
            this.tabControlResults = new System.Windows.Forms.TabControl();
            this.tabPageFoundFiles = new System.Windows.Forms.TabPage();
            this.lbxFoundFiles = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Exclude = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ExportToList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCopyName = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageMissingFiles = new System.Windows.Forms.TabPage();
            this.lbxNotFoundFiles = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControlProjectFiles = new System.Windows.Forms.TabControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControlExternalProject = new System.Windows.Forms.TabControl();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtOutSections = new System.Windows.Forms.TextBox();
            this.chkOverwriteSections = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbxOutputGroup = new System.Windows.Forms.ComboBox();
            this.chkOverWriteGroup = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkSetFlags = new System.Windows.Forms.CheckBox();
            this.txtFlags = new System.Windows.Forms.TextBox();
            this.btnImportSelection = new System.Windows.Forms.Button();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.grbxOptions = new System.Windows.Forms.GroupBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grbxCheckLanguages = new System.Windows.Forms.GroupBox();
            this.chkLanguages = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.grbxResults.SuspendLayout();
            this.tabControlResults.SuspendLayout();
            this.tabPageFoundFiles.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPageMissingFiles.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grbxOptions.SuspendLayout();
            this.grbxCheckLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnProjectFolder);
            this.groupBox1.Controls.Add(this.txtProjectToCheck);
            this.groupBox1.Location = new System.Drawing.Point(357, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compare with project:";
            // 
            // btnProjectFolder
            // 
            this.btnProjectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjectFolder.Location = new System.Drawing.Point(426, 18);
            this.btnProjectFolder.Name = "btnProjectFolder";
            this.btnProjectFolder.Size = new System.Drawing.Size(24, 20);
            this.btnProjectFolder.TabIndex = 1;
            this.btnProjectFolder.Text = "...";
            this.btnProjectFolder.UseVisualStyleBackColor = true;
            this.btnProjectFolder.Click += new System.EventHandler(this.BtnProjectFolder_Click);
            // 
            // txtProjectToCheck
            // 
            this.txtProjectToCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectToCheck.BackColor = System.Drawing.SystemColors.Window;
            this.txtProjectToCheck.Location = new System.Drawing.Point(6, 19);
            this.txtProjectToCheck.Name = "txtProjectToCheck";
            this.txtProjectToCheck.ReadOnly = true;
            this.txtProjectToCheck.Size = new System.Drawing.Size(414, 20);
            this.txtProjectToCheck.TabIndex = 0;
            // 
            // grbxResults
            // 
            this.grbxResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbxResults.Controls.Add(this.tabControlResults);
            this.grbxResults.Location = new System.Drawing.Point(12, 12);
            this.grbxResults.Name = "grbxResults";
            this.grbxResults.Size = new System.Drawing.Size(336, 655);
            this.grbxResults.TabIndex = 1;
            this.grbxResults.TabStop = false;
            this.grbxResults.Text = "Results";
            // 
            // tabControlResults
            // 
            this.tabControlResults.Controls.Add(this.tabPageFoundFiles);
            this.tabControlResults.Controls.Add(this.tabPageMissingFiles);
            this.tabControlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlResults.Location = new System.Drawing.Point(3, 16);
            this.tabControlResults.Name = "tabControlResults";
            this.tabControlResults.SelectedIndex = 0;
            this.tabControlResults.Size = new System.Drawing.Size(330, 636);
            this.tabControlResults.TabIndex = 0;
            this.tabControlResults.SelectedIndexChanged += new System.EventHandler(this.TabControlResults_SelectedIndexChanged);
            // 
            // tabPageFoundFiles
            // 
            this.tabPageFoundFiles.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFoundFiles.Controls.Add(this.lbxFoundFiles);
            this.tabPageFoundFiles.Location = new System.Drawing.Point(4, 22);
            this.tabPageFoundFiles.Name = "tabPageFoundFiles";
            this.tabPageFoundFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFoundFiles.Size = new System.Drawing.Size(322, 610);
            this.tabPageFoundFiles.TabIndex = 0;
            this.tabPageFoundFiles.Text = "Found Files";
            // 
            // lbxFoundFiles
            // 
            this.lbxFoundFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.lbxFoundFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxFoundFiles.FormattingEnabled = true;
            this.lbxFoundFiles.HorizontalScrollbar = true;
            this.lbxFoundFiles.Location = new System.Drawing.Point(3, 3);
            this.lbxFoundFiles.Name = "lbxFoundFiles";
            this.lbxFoundFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxFoundFiles.Size = new System.Drawing.Size(316, 604);
            this.lbxFoundFiles.Sorted = true;
            this.lbxFoundFiles.TabIndex = 0;
            this.lbxFoundFiles.SelectedIndexChanged += new System.EventHandler(this.LbxFoundFiles_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Exclude,
            this.MenuItem_ExportToList,
            this.MenuItemCopyName});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 70);
            // 
            // MenuItem_Exclude
            // 
            this.MenuItem_Exclude.Name = "MenuItem_Exclude";
            this.MenuItem_Exclude.Size = new System.Drawing.Size(139, 22);
            this.MenuItem_Exclude.Text = "Exclude";
            this.MenuItem_Exclude.Click += new System.EventHandler(this.MenuItem_Exclude_Click);
            // 
            // MenuItem_ExportToList
            // 
            this.MenuItem_ExportToList.Name = "MenuItem_ExportToList";
            this.MenuItem_ExportToList.Size = new System.Drawing.Size(139, 22);
            this.MenuItem_ExportToList.Text = "Export to list";
            this.MenuItem_ExportToList.Click += new System.EventHandler(this.MenuItem_ExportToList_Click);
            // 
            // MenuItemCopyName
            // 
            this.MenuItemCopyName.Name = "MenuItemCopyName";
            this.MenuItemCopyName.Size = new System.Drawing.Size(139, 22);
            this.MenuItemCopyName.Text = "Copy name";
            this.MenuItemCopyName.Click += new System.EventHandler(this.MenuItemCopyName_Click);
            // 
            // tabPageMissingFiles
            // 
            this.tabPageMissingFiles.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMissingFiles.Controls.Add(this.lbxNotFoundFiles);
            this.tabPageMissingFiles.Location = new System.Drawing.Point(4, 22);
            this.tabPageMissingFiles.Name = "tabPageMissingFiles";
            this.tabPageMissingFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMissingFiles.Size = new System.Drawing.Size(322, 610);
            this.tabPageMissingFiles.TabIndex = 1;
            this.tabPageMissingFiles.Text = "Missing Files";
            // 
            // lbxNotFoundFiles
            // 
            this.lbxNotFoundFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.lbxNotFoundFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxNotFoundFiles.FormattingEnabled = true;
            this.lbxNotFoundFiles.HorizontalScrollbar = true;
            this.lbxNotFoundFiles.Location = new System.Drawing.Point(3, 3);
            this.lbxNotFoundFiles.Name = "lbxNotFoundFiles";
            this.lbxNotFoundFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxNotFoundFiles.Size = new System.Drawing.Size(316, 604);
            this.lbxNotFoundFiles.Sorted = true;
            this.lbxNotFoundFiles.TabIndex = 1;
            this.lbxNotFoundFiles.SelectedIndexChanged += new System.EventHandler(this.LbxNotFoundFiles_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControlProjectFiles);
            this.groupBox2.Location = new System.Drawing.Point(354, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File in current project";
            // 
            // tabControlProjectFiles
            // 
            this.tabControlProjectFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProjectFiles.Location = new System.Drawing.Point(3, 16);
            this.tabControlProjectFiles.Name = "tabControlProjectFiles";
            this.tabControlProjectFiles.SelectedIndex = 0;
            this.tabControlProjectFiles.Size = new System.Drawing.Size(453, 151);
            this.tabControlProjectFiles.TabIndex = 0;
            this.tabControlProjectFiles.SelectedIndexChanged += new System.EventHandler(this.TabControlProjectFiles_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tabControlExternalProject);
            this.groupBox3.Location = new System.Drawing.Point(354, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 170);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File in external project";
            // 
            // tabControlExternalProject
            // 
            this.tabControlExternalProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlExternalProject.Location = new System.Drawing.Point(3, 16);
            this.tabControlExternalProject.Name = "tabControlExternalProject";
            this.tabControlExternalProject.SelectedIndex = 0;
            this.tabControlExternalProject.Size = new System.Drawing.Size(453, 151);
            this.tabControlExternalProject.TabIndex = 0;
            this.tabControlExternalProject.SelectedIndexChanged += new System.EventHandler(this.TabControlExternalProject_SelectedIndexChanged);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(110, 206);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtOutSections);
            this.groupBox4.Controls.Add(this.chkOverwriteSections);
            this.groupBox4.Location = new System.Drawing.Point(6, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 53);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // txtOutSections
            // 
            this.txtOutSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutSections.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutSections.Location = new System.Drawing.Point(6, 19);
            this.txtOutSections.Name = "txtOutSections";
            this.txtOutSections.ReadOnly = true;
            this.txtOutSections.Size = new System.Drawing.Size(238, 20);
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
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.cbxOutputGroup);
            this.groupBox5.Controls.Add(this.chkOverWriteGroup);
            this.groupBox5.Location = new System.Drawing.Point(6, 76);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 54);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            // 
            // cbxOutputGroup
            // 
            this.cbxOutputGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOutputGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutputGroup.FormattingEnabled = true;
            this.cbxOutputGroup.Location = new System.Drawing.Point(6, 23);
            this.cbxOutputGroup.Name = "cbxOutputGroup";
            this.cbxOutputGroup.Size = new System.Drawing.Size(238, 21);
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
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.chkSetFlags);
            this.groupBox6.Controls.Add(this.txtFlags);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 51);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
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
            this.txtFlags.Size = new System.Drawing.Size(238, 20);
            this.txtFlags.TabIndex = 0;
            this.txtFlags.Tag = "0";
            this.txtFlags.Click += new System.EventHandler(this.TxtFlags_Click);
            // 
            // btnImportSelection
            // 
            this.btnImportSelection.Location = new System.Drawing.Point(6, 195);
            this.btnImportSelection.Name = "btnImportSelection";
            this.btnImportSelection.Size = new System.Drawing.Size(117, 23);
            this.btnImportSelection.TabIndex = 9;
            this.btnImportSelection.Text = "Import selection";
            this.btnImportSelection.UseVisualStyleBackColor = true;
            this.btnImportSelection.Click += new System.EventHandler(this.BtnImportSelection_Click);
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.Location = new System.Drawing.Point(12, 670);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(43, 13);
            this.lblTotalFiles.TabIndex = 10;
            this.lblTotalFiles.Text = "Total: 0";
            // 
            // grbxOptions
            // 
            this.grbxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxOptions.Controls.Add(this.groupBox6);
            this.grbxOptions.Controls.Add(this.groupBox5);
            this.grbxOptions.Controls.Add(this.btnImportSelection);
            this.grbxOptions.Controls.Add(this.groupBox4);
            this.grbxOptions.Location = new System.Drawing.Point(551, 417);
            this.grbxOptions.Name = "grbxOptions";
            this.grbxOptions.Size = new System.Drawing.Size(262, 246);
            this.grbxOptions.TabIndex = 11;
            this.grbxOptions.TabStop = false;
            this.grbxOptions.Text = "Options";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text File|*.txt";
            // 
            // grbxCheckLanguages
            // 
            this.grbxCheckLanguages.Controls.Add(this.chkLanguages);
            this.grbxCheckLanguages.Controls.Add(this.btnRun);
            this.grbxCheckLanguages.Location = new System.Drawing.Point(354, 420);
            this.grbxCheckLanguages.Name = "grbxCheckLanguages";
            this.grbxCheckLanguages.Size = new System.Drawing.Size(191, 247);
            this.grbxCheckLanguages.TabIndex = 12;
            this.grbxCheckLanguages.TabStop = false;
            this.grbxCheckLanguages.Text = "Languages to check";
            // 
            // chkLanguages
            // 
            this.chkLanguages.CheckOnClick = true;
            this.chkLanguages.FormattingEnabled = true;
            this.chkLanguages.Location = new System.Drawing.Point(6, 16);
            this.chkLanguages.Name = "chkLanguages";
            this.chkLanguages.Size = new System.Drawing.Size(179, 184);
            this.chkLanguages.TabIndex = 6;
            // 
            // FrmProjectsCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 692);
            this.Controls.Add(this.grbxCheckLanguages);
            this.Controls.Add(this.grbxOptions);
            this.Controls.Add(this.lblTotalFiles);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbxResults);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProjectsCompare";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projects Compare";
            this.Load += new System.EventHandler(this.FrmProjectsCompare_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbxResults.ResumeLayout(false);
            this.tabControlResults.ResumeLayout(false);
            this.tabPageFoundFiles.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPageMissingFiles.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.grbxOptions.ResumeLayout(false);
            this.grbxCheckLanguages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProjectFolder;
        private System.Windows.Forms.TextBox txtProjectToCheck;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox grbxResults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControlProjectFiles;
        private System.Windows.Forms.TabControl tabControlExternalProject;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtOutSections;
        private System.Windows.Forms.CheckBox chkOverwriteSections;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbxOutputGroup;
        private System.Windows.Forms.CheckBox chkOverWriteGroup;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkSetFlags;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.Button btnImportSelection;
        private System.Windows.Forms.TabControl tabControlResults;
        private System.Windows.Forms.TabPage tabPageFoundFiles;
        private System.Windows.Forms.ListBox lbxFoundFiles;
        private System.Windows.Forms.TabPage tabPageMissingFiles;
        private System.Windows.Forms.ListBox lbxNotFoundFiles;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.GroupBox grbxOptions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exclude;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ExportToList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox grbxCheckLanguages;
        private System.Windows.Forms.CheckedListBox chkLanguages;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCopyName;
    }
}