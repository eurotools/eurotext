
namespace EuroTextEditor
{
    partial class Frm_MainFrame
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainFrame));
            this.Groupbox_Output = new System.Windows.Forms.GroupBox();
            this.Label_OutputName = new System.Windows.Forms.Label();
            this.Textbox_FileName = new System.Windows.Forms.TextBox();
            this.Checkbox_DataInfoSheet = new System.Windows.Forms.CheckBox();
            this.Checkbox_FormatInfo = new System.Windows.Forms.CheckBox();
            this.Button_Output = new System.Windows.Forms.Button();
            this.Checkbox_IncludeHashCodesWithNoSection = new System.Windows.Forms.CheckBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Button_TextStore = new System.Windows.Forms.Button();
            this.GroupBox_Misc = new System.Windows.Forms.GroupBox();
            this.Button_Searcher = new System.Windows.Forms.Button();
            this.Button_SpreadSheetExtractor = new System.Windows.Forms.Button();
            this.Button_ProjectSettings = new System.Windows.Forms.Button();
            this.Button_ExportHashCodes = new System.Windows.Forms.Button();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.grbxTools = new System.Windows.Forms.GroupBox();
            this.btnTrimStrings = new System.Windows.Forms.Button();
            this.btnRemoveDoubleSpacing = new System.Windows.Forms.Button();
            this.btnWordReplacing = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuItemStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_OpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_NewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemStrip_RecentProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemStrip_ResetSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemStrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Windows = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_TextGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_TextSections = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_HashCodes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Groupbox_Output.SuspendLayout();
            this.GroupBox_Misc.SuspendLayout();
            this.grbxTools.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Groupbox_Output
            // 
            this.Groupbox_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Groupbox_Output.Controls.Add(this.Label_OutputName);
            this.Groupbox_Output.Controls.Add(this.Textbox_FileName);
            this.Groupbox_Output.Controls.Add(this.Checkbox_DataInfoSheet);
            this.Groupbox_Output.Controls.Add(this.Checkbox_FormatInfo);
            this.Groupbox_Output.Controls.Add(this.Button_Output);
            this.Groupbox_Output.Controls.Add(this.Checkbox_IncludeHashCodesWithNoSection);
            this.Groupbox_Output.Location = new System.Drawing.Point(781, 314);
            this.Groupbox_Output.Name = "Groupbox_Output";
            this.Groupbox_Output.Size = new System.Drawing.Size(166, 157);
            this.Groupbox_Output.TabIndex = 4;
            this.Groupbox_Output.TabStop = false;
            this.Groupbox_Output.Text = "Output";
            // 
            // Label_OutputName
            // 
            this.Label_OutputName.AutoSize = true;
            this.Label_OutputName.Location = new System.Drawing.Point(6, 45);
            this.Label_OutputName.Name = "Label_OutputName";
            this.Label_OutputName.Size = new System.Drawing.Size(57, 13);
            this.Label_OutputName.TabIndex = 1;
            this.Label_OutputName.Text = "File Name:";
            // 
            // Textbox_FileName
            // 
            this.Textbox_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_FileName.Location = new System.Drawing.Point(6, 61);
            this.Textbox_FileName.Name = "Textbox_FileName";
            this.Textbox_FileName.Size = new System.Drawing.Size(154, 20);
            this.Textbox_FileName.TabIndex = 2;
            // 
            // Checkbox_DataInfoSheet
            // 
            this.Checkbox_DataInfoSheet.AutoSize = true;
            this.Checkbox_DataInfoSheet.Location = new System.Drawing.Point(6, 110);
            this.Checkbox_DataInfoSheet.Name = "Checkbox_DataInfoSheet";
            this.Checkbox_DataInfoSheet.Size = new System.Drawing.Size(139, 17);
            this.Checkbox_DataInfoSheet.TabIndex = 4;
            this.Checkbox_DataInfoSheet.Text = "Include Data Info Sheet";
            this.Checkbox_DataInfoSheet.UseVisualStyleBackColor = true;
            // 
            // Checkbox_FormatInfo
            // 
            this.Checkbox_FormatInfo.AutoSize = true;
            this.Checkbox_FormatInfo.Location = new System.Drawing.Point(6, 87);
            this.Checkbox_FormatInfo.Name = "Checkbox_FormatInfo";
            this.Checkbox_FormatInfo.Size = new System.Drawing.Size(148, 17);
            this.Checkbox_FormatInfo.TabIndex = 3;
            this.Checkbox_FormatInfo.Text = "Include Format Info Sheet";
            this.Checkbox_FormatInfo.UseVisualStyleBackColor = true;
            // 
            // Button_Output
            // 
            this.Button_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Output.Location = new System.Drawing.Point(6, 19);
            this.Button_Output.Name = "Button_Output";
            this.Button_Output.Size = new System.Drawing.Size(154, 23);
            this.Button_Output.TabIndex = 0;
            this.Button_Output.Text = "Generate SpreadSheet";
            this.Button_Output.UseVisualStyleBackColor = true;
            this.Button_Output.Click += new System.EventHandler(this.Button_Output_Click);
            // 
            // Checkbox_IncludeHashCodesWithNoSection
            // 
            this.Checkbox_IncludeHashCodesWithNoSection.AutoSize = true;
            this.Checkbox_IncludeHashCodesWithNoSection.Location = new System.Drawing.Point(6, 133);
            this.Checkbox_IncludeHashCodesWithNoSection.Name = "Checkbox_IncludeHashCodesWithNoSection";
            this.Checkbox_IncludeHashCodesWithNoSection.Size = new System.Drawing.Size(159, 17);
            this.Checkbox_IncludeHashCodesWithNoSection.TabIndex = 5;
            this.Checkbox_IncludeHashCodesWithNoSection.Text = "Incl non-section HashCodes";
            this.Checkbox_IncludeHashCodesWithNoSection.UseVisualStyleBackColor = true;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "EuroText Project (*.etp)|*.etp";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls";
            // 
            // Button_TextStore
            // 
            this.Button_TextStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_TextStore.Location = new System.Drawing.Point(6, 48);
            this.Button_TextStore.Name = "Button_TextStore";
            this.Button_TextStore.Size = new System.Drawing.Size(154, 23);
            this.Button_TextStore.TabIndex = 1;
            this.Button_TextStore.Text = "Multi Editor";
            this.Button_TextStore.UseVisualStyleBackColor = true;
            this.Button_TextStore.Click += new System.EventHandler(this.Button_TextStore_Click);
            // 
            // GroupBox_Misc
            // 
            this.GroupBox_Misc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Misc.Controls.Add(this.Button_Searcher);
            this.GroupBox_Misc.Controls.Add(this.Button_SpreadSheetExtractor);
            this.GroupBox_Misc.Controls.Add(this.Button_ProjectSettings);
            this.GroupBox_Misc.Controls.Add(this.Button_ExportHashCodes);
            this.GroupBox_Misc.Controls.Add(this.Button_TextStore);
            this.GroupBox_Misc.Location = new System.Drawing.Point(781, 27);
            this.GroupBox_Misc.Name = "GroupBox_Misc";
            this.GroupBox_Misc.Size = new System.Drawing.Size(166, 167);
            this.GroupBox_Misc.TabIndex = 2;
            this.GroupBox_Misc.TabStop = false;
            this.GroupBox_Misc.Text = "Misc";
            // 
            // Button_Searcher
            // 
            this.Button_Searcher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Searcher.Location = new System.Drawing.Point(6, 135);
            this.Button_Searcher.Name = "Button_Searcher";
            this.Button_Searcher.Size = new System.Drawing.Size(154, 23);
            this.Button_Searcher.TabIndex = 4;
            this.Button_Searcher.Text = "Searcher";
            this.Button_Searcher.UseVisualStyleBackColor = true;
            this.Button_Searcher.Click += new System.EventHandler(this.Button_Searcher_Click);
            // 
            // Button_SpreadSheetExtractor
            // 
            this.Button_SpreadSheetExtractor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SpreadSheetExtractor.Location = new System.Drawing.Point(6, 106);
            this.Button_SpreadSheetExtractor.Name = "Button_SpreadSheetExtractor";
            this.Button_SpreadSheetExtractor.Size = new System.Drawing.Size(154, 23);
            this.Button_SpreadSheetExtractor.TabIndex = 3;
            this.Button_SpreadSheetExtractor.Text = "SpreadSheets Extractor";
            this.Button_SpreadSheetExtractor.UseVisualStyleBackColor = true;
            this.Button_SpreadSheetExtractor.Click += new System.EventHandler(this.Button_SpreadSheetExtractor_Click);
            // 
            // Button_ProjectSettings
            // 
            this.Button_ProjectSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ProjectSettings.Location = new System.Drawing.Point(6, 19);
            this.Button_ProjectSettings.Name = "Button_ProjectSettings";
            this.Button_ProjectSettings.Size = new System.Drawing.Size(154, 23);
            this.Button_ProjectSettings.TabIndex = 0;
            this.Button_ProjectSettings.Text = "Project Settings";
            this.Button_ProjectSettings.UseVisualStyleBackColor = true;
            this.Button_ProjectSettings.Click += new System.EventHandler(this.Button_ProjectSettings_Click);
            // 
            // Button_ExportHashCodes
            // 
            this.Button_ExportHashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ExportHashCodes.Location = new System.Drawing.Point(6, 77);
            this.Button_ExportHashCodes.Name = "Button_ExportHashCodes";
            this.Button_ExportHashCodes.Size = new System.Drawing.Size(154, 23);
            this.Button_ExportHashCodes.TabIndex = 2;
            this.Button_ExportHashCodes.Text = "Update HashTable";
            this.Button_ExportHashCodes.UseVisualStyleBackColor = true;
            this.Button_ExportHashCodes.Click += new System.EventHandler(this.Button_ExportHashCodes_Click);
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(0, 27);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(775, 617);
            this.dockPanel.TabIndex = 1;
            // 
            // grbxTools
            // 
            this.grbxTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxTools.Controls.Add(this.btnTrimStrings);
            this.grbxTools.Controls.Add(this.btnRemoveDoubleSpacing);
            this.grbxTools.Controls.Add(this.btnWordReplacing);
            this.grbxTools.Location = new System.Drawing.Point(781, 200);
            this.grbxTools.Name = "grbxTools";
            this.grbxTools.Size = new System.Drawing.Size(166, 108);
            this.grbxTools.TabIndex = 3;
            this.grbxTools.TabStop = false;
            this.grbxTools.Text = "Tools";
            // 
            // btnTrimStrings
            // 
            this.btnTrimStrings.Location = new System.Drawing.Point(6, 77);
            this.btnTrimStrings.Name = "btnTrimStrings";
            this.btnTrimStrings.Size = new System.Drawing.Size(154, 23);
            this.btnTrimStrings.TabIndex = 2;
            this.btnTrimStrings.Text = "Trim Strings";
            this.btnTrimStrings.UseVisualStyleBackColor = true;
            this.btnTrimStrings.Click += new System.EventHandler(this.BtnTrimStrings_Click);
            // 
            // btnRemoveDoubleSpacing
            // 
            this.btnRemoveDoubleSpacing.Location = new System.Drawing.Point(6, 48);
            this.btnRemoveDoubleSpacing.Name = "btnRemoveDoubleSpacing";
            this.btnRemoveDoubleSpacing.Size = new System.Drawing.Size(154, 23);
            this.btnRemoveDoubleSpacing.TabIndex = 1;
            this.btnRemoveDoubleSpacing.Text = "Remove Double-Spacing";
            this.btnRemoveDoubleSpacing.UseVisualStyleBackColor = true;
            this.btnRemoveDoubleSpacing.Click += new System.EventHandler(this.BtnRemoveDoubleSpacing_Click);
            // 
            // btnWordReplacing
            // 
            this.btnWordReplacing.Location = new System.Drawing.Point(6, 19);
            this.btnWordReplacing.Name = "btnWordReplacing";
            this.btnWordReplacing.Size = new System.Drawing.Size(154, 23);
            this.btnWordReplacing.TabIndex = 0;
            this.btnWordReplacing.Text = "Word Replacing";
            this.btnWordReplacing.UseVisualStyleBackColor = true;
            this.btnWordReplacing.Click += new System.EventHandler(this.BtnWordReplacing_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStrip_File,
            this.MenuItemStrip_Windows,
            this.MenuItemStrip_Help});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(959, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // MenuItemStrip_File
            // 
            this.MenuItemStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStrip_OpenProject,
            this.MenuItemStrip_NewProject,
            this.MenuItemStrip_Separator1,
            this.MenuItemStrip_RecentProjects,
            this.MenuItemStrip_Separator2,
            this.MenuItemStrip_ResetSettings,
            this.MenuItemStrip_Separator3,
            this.MenuItemStrip_Exit});
            this.MenuItemStrip_File.Name = "MenuItemStrip_File";
            this.MenuItemStrip_File.Size = new System.Drawing.Size(37, 20);
            this.MenuItemStrip_File.Text = "File";
            // 
            // MenuItemStrip_OpenProject
            // 
            this.MenuItemStrip_OpenProject.Name = "MenuItemStrip_OpenProject";
            this.MenuItemStrip_OpenProject.Size = new System.Drawing.Size(155, 22);
            this.MenuItemStrip_OpenProject.Text = "Open Project";
            this.MenuItemStrip_OpenProject.Click += new System.EventHandler(this.MenuItemStrip_OpenProject_Click);
            // 
            // MenuItemStrip_NewProject
            // 
            this.MenuItemStrip_NewProject.Name = "MenuItemStrip_NewProject";
            this.MenuItemStrip_NewProject.Size = new System.Drawing.Size(155, 22);
            this.MenuItemStrip_NewProject.Text = "New Project";
            this.MenuItemStrip_NewProject.Click += new System.EventHandler(this.MenuItemStrip_NewProject_Click);
            // 
            // MenuItemStrip_Separator1
            // 
            this.MenuItemStrip_Separator1.Name = "MenuItemStrip_Separator1";
            this.MenuItemStrip_Separator1.Size = new System.Drawing.Size(152, 6);
            // 
            // MenuItemStrip_RecentProjects
            // 
            this.MenuItemStrip_RecentProjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentFilesToolStripMenuItem});
            this.MenuItemStrip_RecentProjects.Name = "MenuItemStrip_RecentProjects";
            this.MenuItemStrip_RecentProjects.Size = new System.Drawing.Size(155, 22);
            this.MenuItemStrip_RecentProjects.Text = "Recent Projects";
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent Files";
            // 
            // MenuItemStrip_Separator2
            // 
            this.MenuItemStrip_Separator2.Name = "MenuItemStrip_Separator2";
            this.MenuItemStrip_Separator2.Size = new System.Drawing.Size(152, 6);
            // 
            // MenuItemStrip_ResetSettings
            // 
            this.MenuItemStrip_ResetSettings.Name = "MenuItemStrip_ResetSettings";
            this.MenuItemStrip_ResetSettings.Size = new System.Drawing.Size(155, 22);
            this.MenuItemStrip_ResetSettings.Text = "Reset Settings";
            this.MenuItemStrip_ResetSettings.Click += new System.EventHandler(this.MenuItemStrip_ResetSettings_Click);
            // 
            // MenuItemStrip_Separator3
            // 
            this.MenuItemStrip_Separator3.Name = "MenuItemStrip_Separator3";
            this.MenuItemStrip_Separator3.Size = new System.Drawing.Size(152, 6);
            // 
            // MenuItemStrip_Exit
            // 
            this.MenuItemStrip_Exit.Name = "MenuItemStrip_Exit";
            this.MenuItemStrip_Exit.Size = new System.Drawing.Size(155, 22);
            this.MenuItemStrip_Exit.Text = "Exit";
            this.MenuItemStrip_Exit.Click += new System.EventHandler(this.MenuItemStrip_Exit_Click);
            // 
            // MenuItemStrip_Windows
            // 
            this.MenuItemStrip_Windows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStrip_TextGroups,
            this.MenuItemStrip_TextSections,
            this.MenuItemStrip_HashCodes});
            this.MenuItemStrip_Windows.Name = "MenuItemStrip_Windows";
            this.MenuItemStrip_Windows.Size = new System.Drawing.Size(68, 20);
            this.MenuItemStrip_Windows.Text = "Windows";
            this.MenuItemStrip_Windows.DropDownOpening += new System.EventHandler(this.MenuItemStrip_Windows_DropDownOpening);
            // 
            // MenuItemStrip_TextGroups
            // 
            this.MenuItemStrip_TextGroups.CheckOnClick = true;
            this.MenuItemStrip_TextGroups.Name = "MenuItemStrip_TextGroups";
            this.MenuItemStrip_TextGroups.Size = new System.Drawing.Size(142, 22);
            this.MenuItemStrip_TextGroups.Text = "Text Groups";
            this.MenuItemStrip_TextGroups.Click += new System.EventHandler(this.MenuItemStrip_TextGroups_Click);
            // 
            // MenuItemStrip_TextSections
            // 
            this.MenuItemStrip_TextSections.CheckOnClick = true;
            this.MenuItemStrip_TextSections.Name = "MenuItemStrip_TextSections";
            this.MenuItemStrip_TextSections.Size = new System.Drawing.Size(142, 22);
            this.MenuItemStrip_TextSections.Text = "Text Sections";
            this.MenuItemStrip_TextSections.Click += new System.EventHandler(this.MenuItemStrip_TextSections_Click);
            // 
            // MenuItemStrip_HashCodes
            // 
            this.MenuItemStrip_HashCodes.CheckOnClick = true;
            this.MenuItemStrip_HashCodes.Name = "MenuItemStrip_HashCodes";
            this.MenuItemStrip_HashCodes.Size = new System.Drawing.Size(142, 22);
            this.MenuItemStrip_HashCodes.Text = "HashCodes";
            this.MenuItemStrip_HashCodes.Click += new System.EventHandler(this.MenuItemStrip_HashCodes_Click);
            // 
            // MenuItemStrip_Help
            // 
            this.MenuItemStrip_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStrip_About});
            this.MenuItemStrip_Help.Name = "MenuItemStrip_Help";
            this.MenuItemStrip_Help.Size = new System.Drawing.Size(44, 20);
            this.MenuItemStrip_Help.Text = "Help";
            // 
            // MenuItemStrip_About
            // 
            this.MenuItemStrip_About.Name = "MenuItemStrip_About";
            this.MenuItemStrip_About.Size = new System.Drawing.Size(107, 22);
            this.MenuItemStrip_About.Text = "About";
            this.MenuItemStrip_About.Click += new System.EventHandler(this.MenuItemStrip_About_Click);
            // 
            // Frm_MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 644);
            this.Controls.Add(this.grbxTools);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.GroupBox_Misc);
            this.Controls.Add(this.Groupbox_Output);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Frm_MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EuroText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_MainFrame_FormClosing);
            this.Shown += new System.EventHandler(this.Frm_MainFrame_Shown);
            this.Groupbox_Output.ResumeLayout(false);
            this.Groupbox_Output.PerformLayout();
            this.GroupBox_Misc.ResumeLayout(false);
            this.grbxTools.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Groupbox_Output;
        private System.Windows.Forms.Button Button_Output;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        protected internal System.Windows.Forms.CheckBox Checkbox_DataInfoSheet;
        protected internal System.Windows.Forms.CheckBox Checkbox_FormatInfo;
        private System.Windows.Forms.Button Button_TextStore;
        private System.Windows.Forms.GroupBox GroupBox_Misc;
        private System.Windows.Forms.Button Button_ExportHashCodes;
        private System.Windows.Forms.Button Button_ProjectSettings;
        private System.Windows.Forms.Label Label_OutputName;
        protected internal System.Windows.Forms.TextBox Textbox_FileName;
        protected internal WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button Button_SpreadSheetExtractor;
        private System.Windows.Forms.Button Button_Searcher;
        protected internal System.Windows.Forms.CheckBox Checkbox_IncludeHashCodesWithNoSection;
        private System.Windows.Forms.GroupBox grbxTools;
        private System.Windows.Forms.Button btnTrimStrings;
        private System.Windows.Forms.Button btnRemoveDoubleSpacing;
        private System.Windows.Forms.Button btnWordReplacing;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_OpenProject;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_NewProject;
        private System.Windows.Forms.ToolStripSeparator MenuItemStrip_Separator1;
        private System.Windows.Forms.ToolStripSeparator MenuItemStrip_Separator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_ResetSettings;
        private System.Windows.Forms.ToolStripSeparator MenuItemStrip_Separator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_Windows;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_TextGroups;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_TextSections;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_HashCodes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_About;
        protected internal System.Windows.Forms.ToolStripMenuItem MenuItemStrip_RecentProjects;
        protected internal System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
    }
}

