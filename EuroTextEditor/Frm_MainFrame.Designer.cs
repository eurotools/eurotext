
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainFrame));
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItem_File = new System.Windows.Forms.MenuItem();
            this.MenuItem_OpenProject = new System.Windows.Forms.MenuItem();
            this.MenuItem_NewProject = new System.Windows.Forms.MenuItem();
            this.MenuItem_Divider1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_RecentProjects = new System.Windows.Forms.MenuItem();
            this.MenuItem_RecentFiles = new System.Windows.Forms.MenuItem();
            this.MenuItem_Divider2 = new System.Windows.Forms.MenuItem();
            this.MenuItem_ResetSettings = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_TextGroupsForm = new System.Windows.Forms.MenuItem();
            this.MenuItem_TextSectionsForm = new System.Windows.Forms.MenuItem();
            this.MenuItem_HashCodesForm = new System.Windows.Forms.MenuItem();
            this.MenuItem_Help = new System.Windows.Forms.MenuItem();
            this.MenuItem_About = new System.Windows.Forms.MenuItem();
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
            this.Groupbox_Output.SuspendLayout();
            this.GroupBox_Misc.SuspendLayout();
            this.grbxTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_File,
            this.menuItem1,
            this.MenuItem_Help});
            // 
            // MenuItem_File
            // 
            this.MenuItem_File.Index = 0;
            this.MenuItem_File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_OpenProject,
            this.MenuItem_NewProject,
            this.MenuItem_Divider1,
            this.MenuItem_RecentProjects,
            this.MenuItem_Divider2,
            this.MenuItem_ResetSettings,
            this.menuItem2,
            this.MenuItem_Exit});
            this.MenuItem_File.Text = "File";
            // 
            // MenuItem_OpenProject
            // 
            this.MenuItem_OpenProject.Index = 0;
            this.MenuItem_OpenProject.Text = "Open Project";
            this.MenuItem_OpenProject.Click += new System.EventHandler(this.MenuItem_OpenProject_Click);
            // 
            // MenuItem_NewProject
            // 
            this.MenuItem_NewProject.Index = 1;
            this.MenuItem_NewProject.Text = "New Project";
            this.MenuItem_NewProject.Click += new System.EventHandler(this.MenuItem_NewProject_Click);
            // 
            // MenuItem_Divider1
            // 
            this.MenuItem_Divider1.Index = 2;
            this.MenuItem_Divider1.Text = "-";
            // 
            // MenuItem_RecentProjects
            // 
            this.MenuItem_RecentProjects.Index = 3;
            this.MenuItem_RecentProjects.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_RecentFiles});
            this.MenuItem_RecentProjects.Text = "Recent Projects";
            // 
            // MenuItem_RecentFiles
            // 
            this.MenuItem_RecentFiles.Index = 0;
            this.MenuItem_RecentFiles.Text = "";
            // 
            // MenuItem_Divider2
            // 
            this.MenuItem_Divider2.Index = 4;
            this.MenuItem_Divider2.Text = "-";
            // 
            // MenuItem_ResetSettings
            // 
            this.MenuItem_ResetSettings.Index = 5;
            this.MenuItem_ResetSettings.Text = "Reset Settings";
            this.MenuItem_ResetSettings.Click += new System.EventHandler(this.MenuItem_ResetSettings_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 6;
            this.menuItem2.Text = "-";
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Index = 7;
            this.MenuItem_Exit.Text = "Exit";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_TextGroupsForm,
            this.MenuItem_TextSectionsForm,
            this.MenuItem_HashCodesForm});
            this.menuItem1.Text = "Windows";
            // 
            // MenuItem_TextGroupsForm
            // 
            this.MenuItem_TextGroupsForm.Checked = true;
            this.MenuItem_TextGroupsForm.Index = 0;
            this.MenuItem_TextGroupsForm.Text = "Text Groups";
            this.MenuItem_TextGroupsForm.Click += new System.EventHandler(this.MenuItem_TextGroupsForm_Click);
            // 
            // MenuItem_TextSectionsForm
            // 
            this.MenuItem_TextSectionsForm.Checked = true;
            this.MenuItem_TextSectionsForm.Index = 1;
            this.MenuItem_TextSectionsForm.Text = "Text Sections";
            this.MenuItem_TextSectionsForm.Click += new System.EventHandler(this.MenuItem_TextSectionsForm_Click);
            // 
            // MenuItem_HashCodesForm
            // 
            this.MenuItem_HashCodesForm.Checked = true;
            this.MenuItem_HashCodesForm.Index = 2;
            this.MenuItem_HashCodesForm.Text = "HashCodes";
            this.MenuItem_HashCodesForm.Click += new System.EventHandler(this.MenuItem_HashCodesForm_Click);
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.Index = 2;
            this.MenuItem_Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_About});
            this.MenuItem_Help.Text = "Help";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Index = 0;
            this.MenuItem_About.Text = "About";
            this.MenuItem_About.Click += new System.EventHandler(this.MenuItem_About_Click);
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
            this.Groupbox_Output.Location = new System.Drawing.Point(781, 287);
            this.Groupbox_Output.Name = "Groupbox_Output";
            this.Groupbox_Output.Size = new System.Drawing.Size(166, 157);
            this.Groupbox_Output.TabIndex = 3;
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
            this.GroupBox_Misc.Location = new System.Drawing.Point(781, 0);
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
            this.dockPanel.Location = new System.Drawing.Point(0, 0);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(775, 644);
            this.dockPanel.TabIndex = 1;
            // 
            // grbxTools
            // 
            this.grbxTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxTools.Controls.Add(this.btnTrimStrings);
            this.grbxTools.Controls.Add(this.btnRemoveDoubleSpacing);
            this.grbxTools.Controls.Add(this.btnWordReplacing);
            this.grbxTools.Location = new System.Drawing.Point(781, 173);
            this.grbxTools.Name = "grbxTools";
            this.grbxTools.Size = new System.Drawing.Size(166, 108);
            this.grbxTools.TabIndex = 4;
            this.grbxTools.TabStop = false;
            this.grbxTools.Text = "Tools:";
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.MainMenu;
            this.Name = "Frm_MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EuroText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_MainFrame_FormClosing);
            this.Shown += new System.EventHandler(this.Frm_MainFrame_Shown);
            this.Groupbox_Output.ResumeLayout(false);
            this.Groupbox_Output.PerformLayout();
            this.GroupBox_Misc.ResumeLayout(false);
            this.grbxTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem MenuItem_File;
        private System.Windows.Forms.MenuItem MenuItem_OpenProject;
        private System.Windows.Forms.MenuItem MenuItem_NewProject;
        private System.Windows.Forms.MenuItem MenuItem_Help;
        private System.Windows.Forms.MenuItem MenuItem_About;
        private System.Windows.Forms.GroupBox Groupbox_Output;
        private System.Windows.Forms.Button Button_Output;
        private System.Windows.Forms.MenuItem MenuItem_Divider1;
        private System.Windows.Forms.MenuItem MenuItem_Divider2;
        private System.Windows.Forms.MenuItem MenuItem_Exit;
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
        protected internal System.Windows.Forms.MenuItem menuItem1;
        protected internal System.Windows.Forms.MenuItem MenuItem_TextGroupsForm;
        protected internal System.Windows.Forms.MenuItem MenuItem_TextSectionsForm;
        protected internal System.Windows.Forms.MenuItem MenuItem_HashCodesForm;
        private System.Windows.Forms.MenuItem MenuItem_ResetSettings;
        private System.Windows.Forms.MenuItem menuItem2;
        protected internal System.Windows.Forms.MenuItem MenuItem_RecentFiles;
        protected internal System.Windows.Forms.MenuItem MenuItem_RecentProjects;
        protected internal WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button Button_SpreadSheetExtractor;
        private System.Windows.Forms.Button Button_Searcher;
        protected internal System.Windows.Forms.CheckBox Checkbox_IncludeHashCodesWithNoSection;
        private System.Windows.Forms.GroupBox grbxTools;
        private System.Windows.Forms.Button btnTrimStrings;
        private System.Windows.Forms.Button btnRemoveDoubleSpacing;
        private System.Windows.Forms.Button btnWordReplacing;
    }
}

