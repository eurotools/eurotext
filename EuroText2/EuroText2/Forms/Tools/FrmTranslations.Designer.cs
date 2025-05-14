
namespace EuroText2
{
    partial class FrmTranslations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTranslations));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageExport = new System.Windows.Forms.TabPage();
            this.chkExcludeUnused = new System.Windows.Forms.CheckBox();
            this.chkAddStrings = new System.Windows.Forms.CheckBox();
            this.grbxExportTranslate = new System.Windows.Forms.GroupBox();
            this.cbxExportLanguageTranslation = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.grbxExportFlags = new System.Windows.Forms.GroupBox();
            this.txtExportFlags = new System.Windows.Forms.TextBox();
            this.grbxExportGroups = new System.Windows.Forms.GroupBox();
            this.chkExportGroups = new System.Windows.Forms.CheckedListBox();
            this.contextExportMenuGroups = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemExportGroupsCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExportGroupsInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExportGroupsUnCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.grbxExportLanguages = new System.Windows.Forms.GroupBox();
            this.cbxExportBaseLanguage = new System.Windows.Forms.ComboBox();
            this.btnExportFilePath = new System.Windows.Forms.Button();
            this.txtExportFilePath = new System.Windows.Forms.TextBox();
            this.lblExportTextFile = new System.Windows.Forms.Label();
            this.tabPageImport = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSetOffFlags = new System.Windows.Forms.TextBox();
            this.DataGridView_ExcelSheet = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.grbxFileOptions = new System.Windows.Forms.GroupBox();
            this.txtHashcodesCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTranslationLanguage = new System.Windows.Forms.TextBox();
            this.lblImportTranslation = new System.Windows.Forms.Label();
            this.txtBaseLanguage = new System.Windows.Forms.TextBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.btnImportFile = new System.Windows.Forms.Button();
            this.txtImportFile = new System.Windows.Forms.TextBox();
            this.lblImportFile = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPageExport.SuspendLayout();
            this.grbxExportTranslate.SuspendLayout();
            this.grbxExportFlags.SuspendLayout();
            this.grbxExportGroups.SuspendLayout();
            this.contextExportMenuGroups.SuspendLayout();
            this.grbxExportLanguages.SuspendLayout();
            this.tabPageImport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ExcelSheet)).BeginInit();
            this.grbxFileOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageExport);
            this.tabControl1.Controls.Add(this.tabPageImport);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageExport
            // 
            this.tabPageExport.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageExport.Controls.Add(this.chkExcludeUnused);
            this.tabPageExport.Controls.Add(this.chkAddStrings);
            this.tabPageExport.Controls.Add(this.grbxExportTranslate);
            this.tabPageExport.Controls.Add(this.btnRun);
            this.tabPageExport.Controls.Add(this.grbxExportFlags);
            this.tabPageExport.Controls.Add(this.grbxExportGroups);
            this.tabPageExport.Controls.Add(this.grbxExportLanguages);
            this.tabPageExport.Controls.Add(this.btnExportFilePath);
            this.tabPageExport.Controls.Add(this.txtExportFilePath);
            this.tabPageExport.Controls.Add(this.lblExportTextFile);
            this.tabPageExport.Location = new System.Drawing.Point(4, 22);
            this.tabPageExport.Name = "tabPageExport";
            this.tabPageExport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExport.Size = new System.Drawing.Size(432, 463);
            this.tabPageExport.TabIndex = 0;
            this.tabPageExport.Text = "Export for translate";
            // 
            // chkExcludeUnused
            // 
            this.chkExcludeUnused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExcludeUnused.AutoSize = true;
            this.chkExcludeUnused.Location = new System.Drawing.Point(318, 179);
            this.chkExcludeUnused.Name = "chkExcludeUnused";
            this.chkExcludeUnused.Size = new System.Drawing.Size(106, 17);
            this.chkExcludeUnused.TabIndex = 9;
            this.chkExcludeUnused.Text = "Exclude UnUsed";
            this.chkExcludeUnused.UseVisualStyleBackColor = true;
            // 
            // chkAddStrings
            // 
            this.chkAddStrings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAddStrings.AutoSize = true;
            this.chkAddStrings.Location = new System.Drawing.Point(297, 156);
            this.chkAddStrings.Name = "chkAddStrings";
            this.chkAddStrings.Size = new System.Drawing.Size(127, 17);
            this.chkAddStrings.TabIndex = 8;
            this.chkAddStrings.Text = "Add strings for review";
            this.chkAddStrings.UseVisualStyleBackColor = true;
            // 
            // grbxExportTranslate
            // 
            this.grbxExportTranslate.Controls.Add(this.cbxExportLanguageTranslation);
            this.grbxExportTranslate.Location = new System.Drawing.Point(224, 94);
            this.grbxExportTranslate.Name = "grbxExportTranslate";
            this.grbxExportTranslate.Size = new System.Drawing.Size(200, 56);
            this.grbxExportTranslate.TabIndex = 5;
            this.grbxExportTranslate.TabStop = false;
            this.grbxExportTranslate.Text = "Language To Translate";
            // 
            // cbxExportLanguageTranslation
            // 
            this.cbxExportLanguageTranslation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExportLanguageTranslation.FormattingEnabled = true;
            this.cbxExportLanguageTranslation.Location = new System.Drawing.Point(6, 19);
            this.cbxExportLanguageTranslation.Name = "cbxExportLanguageTranslation";
            this.cbxExportLanguageTranslation.Size = new System.Drawing.Size(188, 21);
            this.cbxExportLanguageTranslation.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(349, 437);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Export";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // grbxExportFlags
            // 
            this.grbxExportFlags.Controls.Add(this.txtExportFlags);
            this.grbxExportFlags.Location = new System.Drawing.Point(6, 378);
            this.grbxExportFlags.Name = "grbxExportFlags";
            this.grbxExportFlags.Size = new System.Drawing.Size(418, 53);
            this.grbxExportFlags.TabIndex = 6;
            this.grbxExportFlags.TabStop = false;
            this.grbxExportFlags.Text = "Filter Flags:";
            // 
            // txtExportFlags
            // 
            this.txtExportFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExportFlags.BackColor = System.Drawing.SystemColors.Window;
            this.txtExportFlags.Location = new System.Drawing.Point(6, 19);
            this.txtExportFlags.Name = "txtExportFlags";
            this.txtExportFlags.ReadOnly = true;
            this.txtExportFlags.Size = new System.Drawing.Size(406, 20);
            this.txtExportFlags.TabIndex = 0;
            this.txtExportFlags.Tag = "0";
            this.txtExportFlags.Click += new System.EventHandler(this.TxtExportFlags_Click);
            // 
            // grbxExportGroups
            // 
            this.grbxExportGroups.Controls.Add(this.chkExportGroups);
            this.grbxExportGroups.Location = new System.Drawing.Point(6, 32);
            this.grbxExportGroups.Name = "grbxExportGroups";
            this.grbxExportGroups.Size = new System.Drawing.Size(212, 340);
            this.grbxExportGroups.TabIndex = 3;
            this.grbxExportGroups.TabStop = false;
            this.grbxExportGroups.Text = "Groups To Include";
            // 
            // chkExportGroups
            // 
            this.chkExportGroups.CheckOnClick = true;
            this.chkExportGroups.ContextMenuStrip = this.contextExportMenuGroups;
            this.chkExportGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkExportGroups.FormattingEnabled = true;
            this.chkExportGroups.Location = new System.Drawing.Point(3, 16);
            this.chkExportGroups.Name = "chkExportGroups";
            this.chkExportGroups.Size = new System.Drawing.Size(206, 321);
            this.chkExportGroups.TabIndex = 4;
            // 
            // contextExportMenuGroups
            // 
            this.contextExportMenuGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExportGroupsCheckAll,
            this.MenuItemExportGroupsInvert,
            this.MenuItemExportGroupsUnCheckAll});
            this.contextExportMenuGroups.Name = "contextMenuLanguages";
            this.contextExportMenuGroups.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextExportMenuGroups.Size = new System.Drawing.Size(156, 70);
            // 
            // MenuItemExportGroupsCheckAll
            // 
            this.MenuItemExportGroupsCheckAll.Name = "MenuItemExportGroupsCheckAll";
            this.MenuItemExportGroupsCheckAll.Size = new System.Drawing.Size(155, 22);
            this.MenuItemExportGroupsCheckAll.Text = "Check All";
            this.MenuItemExportGroupsCheckAll.Click += new System.EventHandler(this.MenuItemExportGroupsCheckAll_Click);
            // 
            // MenuItemExportGroupsInvert
            // 
            this.MenuItemExportGroupsInvert.Name = "MenuItemExportGroupsInvert";
            this.MenuItemExportGroupsInvert.Size = new System.Drawing.Size(155, 22);
            this.MenuItemExportGroupsInvert.Text = "Invert Selection";
            this.MenuItemExportGroupsInvert.Click += new System.EventHandler(this.MenuItemExportGroupsInvert_Click);
            // 
            // MenuItemExportGroupsUnCheckAll
            // 
            this.MenuItemExportGroupsUnCheckAll.Name = "MenuItemExportGroupsUnCheckAll";
            this.MenuItemExportGroupsUnCheckAll.Size = new System.Drawing.Size(155, 22);
            this.MenuItemExportGroupsUnCheckAll.Text = "Uncheck All";
            this.MenuItemExportGroupsUnCheckAll.Click += new System.EventHandler(this.MenuItemExportGroupsUnCheckAll_Click);
            // 
            // grbxExportLanguages
            // 
            this.grbxExportLanguages.Controls.Add(this.cbxExportBaseLanguage);
            this.grbxExportLanguages.Location = new System.Drawing.Point(224, 32);
            this.grbxExportLanguages.Name = "grbxExportLanguages";
            this.grbxExportLanguages.Size = new System.Drawing.Size(200, 56);
            this.grbxExportLanguages.TabIndex = 4;
            this.grbxExportLanguages.TabStop = false;
            this.grbxExportLanguages.Text = "Reference Language";
            // 
            // cbxExportBaseLanguage
            // 
            this.cbxExportBaseLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExportBaseLanguage.FormattingEnabled = true;
            this.cbxExportBaseLanguage.Location = new System.Drawing.Point(6, 19);
            this.cbxExportBaseLanguage.Name = "cbxExportBaseLanguage";
            this.cbxExportBaseLanguage.Size = new System.Drawing.Size(188, 21);
            this.cbxExportBaseLanguage.TabIndex = 1;
            // 
            // btnExportFilePath
            // 
            this.btnExportFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportFilePath.Location = new System.Drawing.Point(400, 6);
            this.btnExportFilePath.Name = "btnExportFilePath";
            this.btnExportFilePath.Size = new System.Drawing.Size(24, 20);
            this.btnExportFilePath.TabIndex = 2;
            this.btnExportFilePath.Text = "...";
            this.btnExportFilePath.UseVisualStyleBackColor = true;
            this.btnExportFilePath.Click += new System.EventHandler(this.BtnExportFilePath_Click);
            // 
            // txtExportFilePath
            // 
            this.txtExportFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExportFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.txtExportFilePath.Location = new System.Drawing.Point(65, 6);
            this.txtExportFilePath.Name = "txtExportFilePath";
            this.txtExportFilePath.ReadOnly = true;
            this.txtExportFilePath.Size = new System.Drawing.Size(329, 20);
            this.txtExportFilePath.TabIndex = 1;
            // 
            // lblExportTextFile
            // 
            this.lblExportTextFile.AutoSize = true;
            this.lblExportTextFile.Location = new System.Drawing.Point(8, 9);
            this.lblExportTextFile.Name = "lblExportTextFile";
            this.lblExportTextFile.Size = new System.Drawing.Size(51, 13);
            this.lblExportTextFile.TabIndex = 0;
            this.lblExportTextFile.Text = "File Path:";
            // 
            // tabPageImport
            // 
            this.tabPageImport.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageImport.Controls.Add(this.groupBox1);
            this.tabPageImport.Controls.Add(this.DataGridView_ExcelSheet);
            this.tabPageImport.Controls.Add(this.btnImport);
            this.tabPageImport.Controls.Add(this.grbxFileOptions);
            this.tabPageImport.Controls.Add(this.btnImportFile);
            this.tabPageImport.Controls.Add(this.txtImportFile);
            this.tabPageImport.Controls.Add(this.lblImportFile);
            this.tabPageImport.Location = new System.Drawing.Point(4, 22);
            this.tabPageImport.Name = "tabPageImport";
            this.tabPageImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImport.Size = new System.Drawing.Size(432, 463);
            this.tabPageImport.TabIndex = 1;
            this.tabPageImport.Text = "Import translation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSetOffFlags);
            this.groupBox1.Location = new System.Drawing.Point(8, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 53);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Off Flags:";
            // 
            // txtSetOffFlags
            // 
            this.txtSetOffFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSetOffFlags.BackColor = System.Drawing.SystemColors.Window;
            this.txtSetOffFlags.Location = new System.Drawing.Point(6, 19);
            this.txtSetOffFlags.Name = "txtSetOffFlags";
            this.txtSetOffFlags.ReadOnly = true;
            this.txtSetOffFlags.Size = new System.Drawing.Size(404, 20);
            this.txtSetOffFlags.TabIndex = 0;
            this.txtSetOffFlags.Tag = "0";
            this.txtSetOffFlags.Click += new System.EventHandler(this.TxtSetOffFlags_Click);
            // 
            // DataGridView_ExcelSheet
            // 
            this.DataGridView_ExcelSheet.AllowUserToAddRows = false;
            this.DataGridView_ExcelSheet.AllowUserToDeleteRows = false;
            this.DataGridView_ExcelSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_ExcelSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ExcelSheet.Location = new System.Drawing.Point(8, 209);
            this.DataGridView_ExcelSheet.Name = "DataGridView_ExcelSheet";
            this.DataGridView_ExcelSheet.ReadOnly = true;
            this.DataGridView_ExcelSheet.Size = new System.Drawing.Size(416, 222);
            this.DataGridView_ExcelSheet.TabIndex = 15;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(349, 437);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // grbxFileOptions
            // 
            this.grbxFileOptions.Controls.Add(this.txtHashcodesCount);
            this.grbxFileOptions.Controls.Add(this.label1);
            this.grbxFileOptions.Controls.Add(this.txtTranslationLanguage);
            this.grbxFileOptions.Controls.Add(this.lblImportTranslation);
            this.grbxFileOptions.Controls.Add(this.txtBaseLanguage);
            this.grbxFileOptions.Controls.Add(this.lblLanguage);
            this.grbxFileOptions.Location = new System.Drawing.Point(8, 32);
            this.grbxFileOptions.Name = "grbxFileOptions";
            this.grbxFileOptions.Size = new System.Drawing.Size(416, 112);
            this.grbxFileOptions.TabIndex = 6;
            this.grbxFileOptions.TabStop = false;
            this.grbxFileOptions.Text = "File Settings";
            // 
            // txtHashcodesCount
            // 
            this.txtHashcodesCount.BackColor = System.Drawing.SystemColors.Window;
            this.txtHashcodesCount.Location = new System.Drawing.Point(121, 71);
            this.txtHashcodesCount.Name = "txtHashcodesCount";
            this.txtHashcodesCount.ReadOnly = true;
            this.txtHashcodesCount.Size = new System.Drawing.Size(128, 20);
            this.txtHashcodesCount.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hashcodes Count:";
            // 
            // txtTranslationLanguage
            // 
            this.txtTranslationLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.txtTranslationLanguage.Location = new System.Drawing.Point(121, 45);
            this.txtTranslationLanguage.Name = "txtTranslationLanguage";
            this.txtTranslationLanguage.ReadOnly = true;
            this.txtTranslationLanguage.Size = new System.Drawing.Size(128, 20);
            this.txtTranslationLanguage.TabIndex = 3;
            // 
            // lblImportTranslation
            // 
            this.lblImportTranslation.AutoSize = true;
            this.lblImportTranslation.Location = new System.Drawing.Point(6, 48);
            this.lblImportTranslation.Name = "lblImportTranslation";
            this.lblImportTranslation.Size = new System.Drawing.Size(109, 13);
            this.lblImportTranslation.TabIndex = 2;
            this.lblImportTranslation.Text = "Translation language:";
            // 
            // txtBaseLanguage
            // 
            this.txtBaseLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.txtBaseLanguage.Location = new System.Drawing.Point(121, 19);
            this.txtBaseLanguage.Name = "txtBaseLanguage";
            this.txtBaseLanguage.ReadOnly = true;
            this.txtBaseLanguage.Size = new System.Drawing.Size(128, 20);
            this.txtBaseLanguage.TabIndex = 1;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(34, 22);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(81, 13);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Base language:";
            // 
            // btnImportFile
            // 
            this.btnImportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportFile.Location = new System.Drawing.Point(400, 6);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(24, 20);
            this.btnImportFile.TabIndex = 5;
            this.btnImportFile.Text = "...";
            this.btnImportFile.UseVisualStyleBackColor = true;
            this.btnImportFile.Click += new System.EventHandler(this.BtnImportFile_Click);
            // 
            // txtImportFile
            // 
            this.txtImportFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImportFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtImportFile.Location = new System.Drawing.Point(65, 6);
            this.txtImportFile.Name = "txtImportFile";
            this.txtImportFile.ReadOnly = true;
            this.txtImportFile.Size = new System.Drawing.Size(329, 20);
            this.txtImportFile.TabIndex = 4;
            // 
            // lblImportFile
            // 
            this.lblImportFile.AutoSize = true;
            this.lblImportFile.Location = new System.Drawing.Point(8, 9);
            this.lblImportFile.Name = "lblImportFile";
            this.lblImportFile.Size = new System.Drawing.Size(51, 13);
            this.lblImportFile.TabIndex = 3;
            this.lblImportFile.Text = "File Path:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 Workbook (*.xls)|*.xls";
            // 
            // FrmTranslations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 489);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTranslations";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Translation Manager";
            this.Load += new System.EventHandler(this.FrmTranslations_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageExport.ResumeLayout(false);
            this.tabPageExport.PerformLayout();
            this.grbxExportTranslate.ResumeLayout(false);
            this.grbxExportFlags.ResumeLayout(false);
            this.grbxExportFlags.PerformLayout();
            this.grbxExportGroups.ResumeLayout(false);
            this.contextExportMenuGroups.ResumeLayout(false);
            this.grbxExportLanguages.ResumeLayout(false);
            this.tabPageImport.ResumeLayout(false);
            this.tabPageImport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ExcelSheet)).EndInit();
            this.grbxFileOptions.ResumeLayout(false);
            this.grbxFileOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageExport;
        private System.Windows.Forms.TabPage tabPageImport;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox grbxExportFlags;
        private System.Windows.Forms.TextBox txtExportFlags;
        private System.Windows.Forms.GroupBox grbxExportGroups;
        private System.Windows.Forms.CheckedListBox chkExportGroups;
        private System.Windows.Forms.GroupBox grbxExportLanguages;
        private System.Windows.Forms.Button btnExportFilePath;
        private System.Windows.Forms.TextBox txtExportFilePath;
        private System.Windows.Forms.Label lblExportTextFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextExportMenuGroups;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExportGroupsCheckAll;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExportGroupsInvert;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExportGroupsUnCheckAll;
        private System.Windows.Forms.GroupBox grbxExportTranslate;
        private System.Windows.Forms.ComboBox cbxExportLanguageTranslation;
        private System.Windows.Forms.ComboBox cbxExportBaseLanguage;
        private System.Windows.Forms.Button btnImportFile;
        private System.Windows.Forms.TextBox txtImportFile;
        private System.Windows.Forms.Label lblImportFile;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox grbxFileOptions;
        private System.Windows.Forms.TextBox txtHashcodesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTranslationLanguage;
        private System.Windows.Forms.Label lblImportTranslation;
        private System.Windows.Forms.TextBox txtBaseLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView DataGridView_ExcelSheet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSetOffFlags;
        private System.Windows.Forms.CheckBox chkAddStrings;
        private System.Windows.Forms.CheckBox chkExcludeUnused;
    }
}