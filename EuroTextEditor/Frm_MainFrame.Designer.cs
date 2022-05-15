
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
            this.Button_ReadTable = new System.Windows.Forms.Button();
            this.DataGridView_ExcelSheet = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItem_File = new System.Windows.Forms.MenuItem();
            this.MenuItem_OpenProject = new System.Windows.Forms.MenuItem();
            this.MenuItem_NewProject = new System.Windows.Forms.MenuItem();
            this.MenuItem_Divider1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_RecentProjects = new System.Windows.Forms.MenuItem();
            this.MenuItem_Divider2 = new System.Windows.Forms.MenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.MenuItem();
            this.MenuItem_Help = new System.Windows.Forms.MenuItem();
            this.MenuItem_About = new System.Windows.Forms.MenuItem();
            this.Button_GetGroups = new System.Windows.Forms.Button();
            this.Button_GetMessages = new System.Windows.Forms.Button();
            this.Groupbox_Output = new System.Windows.Forms.GroupBox();
            this.Label_OutputName = new System.Windows.Forms.Label();
            this.Textbox_FileName = new System.Windows.Forms.TextBox();
            this.Checkbox_DataInfoSheet = new System.Windows.Forms.CheckBox();
            this.Checkbox_FormatInfo = new System.Windows.Forms.CheckBox();
            this.Button_Output = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.GroupBox_Testing = new System.Windows.Forms.GroupBox();
            this.Button_GetSections = new System.Windows.Forms.Button();
            this.Button_TextStore = new System.Windows.Forms.Button();
            this.GroupBox_Misc = new System.Windows.Forms.GroupBox();
            this.Button_ProjectSettings = new System.Windows.Forms.Button();
            this.Button_ExportHashCodes = new System.Windows.Forms.Button();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ExcelSheet)).BeginInit();
            this.Groupbox_Output.SuspendLayout();
            this.GroupBox_Testing.SuspendLayout();
            this.GroupBox_Misc.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_ReadTable
            // 
            this.Button_ReadTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ReadTable.Location = new System.Drawing.Point(6, 19);
            this.Button_ReadTable.Name = "Button_ReadTable";
            this.Button_ReadTable.Size = new System.Drawing.Size(152, 23);
            this.Button_ReadTable.TabIndex = 1;
            this.Button_ReadTable.Text = "Read Table";
            this.Button_ReadTable.UseVisualStyleBackColor = true;
            this.Button_ReadTable.Click += new System.EventHandler(this.ReadTable_Click);
            // 
            // DataGridView_ExcelSheet
            // 
            this.DataGridView_ExcelSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_ExcelSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ExcelSheet.Location = new System.Drawing.Point(6, 137);
            this.DataGridView_ExcelSheet.Name = "DataGridView_ExcelSheet";
            this.DataGridView_ExcelSheet.Size = new System.Drawing.Size(152, 199);
            this.DataGridView_ExcelSheet.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_File,
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
            this.MenuItem_RecentProjects.Text = "Recent Projects";
            // 
            // MenuItem_Divider2
            // 
            this.MenuItem_Divider2.Index = 4;
            this.MenuItem_Divider2.Text = "-";
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Index = 5;
            this.MenuItem_Exit.Text = "Exit";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.Index = 1;
            this.MenuItem_Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_About});
            this.MenuItem_Help.Text = "Help";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Index = 0;
            this.MenuItem_About.Text = "About";
            // 
            // Button_GetGroups
            // 
            this.Button_GetGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GetGroups.Location = new System.Drawing.Point(6, 48);
            this.Button_GetGroups.Name = "Button_GetGroups";
            this.Button_GetGroups.Size = new System.Drawing.Size(152, 23);
            this.Button_GetGroups.TabIndex = 5;
            this.Button_GetGroups.Text = "Get Text Groups";
            this.Button_GetGroups.UseVisualStyleBackColor = true;
            this.Button_GetGroups.Click += new System.EventHandler(this.Button_GetGroups_Click);
            // 
            // Button_GetMessages
            // 
            this.Button_GetMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GetMessages.Location = new System.Drawing.Point(6, 77);
            this.Button_GetMessages.Name = "Button_GetMessages";
            this.Button_GetMessages.Size = new System.Drawing.Size(152, 23);
            this.Button_GetMessages.TabIndex = 6;
            this.Button_GetMessages.Text = "Get Messages";
            this.Button_GetMessages.UseVisualStyleBackColor = true;
            this.Button_GetMessages.Click += new System.EventHandler(this.Button_GetMessages_Click);
            // 
            // Groupbox_Output
            // 
            this.Groupbox_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Groupbox_Output.Controls.Add(this.Label_OutputName);
            this.Groupbox_Output.Controls.Add(this.Textbox_FileName);
            this.Groupbox_Output.Controls.Add(this.Checkbox_DataInfoSheet);
            this.Groupbox_Output.Controls.Add(this.Checkbox_FormatInfo);
            this.Groupbox_Output.Controls.Add(this.Button_Output);
            this.Groupbox_Output.Location = new System.Drawing.Point(837, 119);
            this.Groupbox_Output.Name = "Groupbox_Output";
            this.Groupbox_Output.Size = new System.Drawing.Size(164, 136);
            this.Groupbox_Output.TabIndex = 8;
            this.Groupbox_Output.TabStop = false;
            this.Groupbox_Output.Text = "Output";
            // 
            // Label_OutputName
            // 
            this.Label_OutputName.AutoSize = true;
            this.Label_OutputName.Location = new System.Drawing.Point(6, 45);
            this.Label_OutputName.Name = "Label_OutputName";
            this.Label_OutputName.Size = new System.Drawing.Size(57, 13);
            this.Label_OutputName.TabIndex = 4;
            this.Label_OutputName.Text = "File Name:";
            // 
            // Textbox_FileName
            // 
            this.Textbox_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_FileName.Location = new System.Drawing.Point(6, 61);
            this.Textbox_FileName.Name = "Textbox_FileName";
            this.Textbox_FileName.Size = new System.Drawing.Size(152, 20);
            this.Textbox_FileName.TabIndex = 3;
            // 
            // Checkbox_DataInfoSheet
            // 
            this.Checkbox_DataInfoSheet.AutoSize = true;
            this.Checkbox_DataInfoSheet.Location = new System.Drawing.Point(6, 110);
            this.Checkbox_DataInfoSheet.Name = "Checkbox_DataInfoSheet";
            this.Checkbox_DataInfoSheet.Size = new System.Drawing.Size(139, 17);
            this.Checkbox_DataInfoSheet.TabIndex = 2;
            this.Checkbox_DataInfoSheet.Text = "Include Data Info Sheet";
            this.Checkbox_DataInfoSheet.UseVisualStyleBackColor = true;
            // 
            // Checkbox_FormatInfo
            // 
            this.Checkbox_FormatInfo.AutoSize = true;
            this.Checkbox_FormatInfo.Location = new System.Drawing.Point(6, 87);
            this.Checkbox_FormatInfo.Name = "Checkbox_FormatInfo";
            this.Checkbox_FormatInfo.Size = new System.Drawing.Size(148, 17);
            this.Checkbox_FormatInfo.TabIndex = 1;
            this.Checkbox_FormatInfo.Text = "Include Format Info Sheet";
            this.Checkbox_FormatInfo.UseVisualStyleBackColor = true;
            // 
            // Button_Output
            // 
            this.Button_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Output.Location = new System.Drawing.Point(6, 19);
            this.Button_Output.Name = "Button_Output";
            this.Button_Output.Size = new System.Drawing.Size(152, 23);
            this.Button_Output.TabIndex = 0;
            this.Button_Output.Text = "Generate SpreadSheet";
            this.Button_Output.UseVisualStyleBackColor = true;
            this.Button_Output.Click += new System.EventHandler(this.Button_Output_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "EuroText Project (*.etp)|*.etp";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls";
            // 
            // GroupBox_Testing
            // 
            this.GroupBox_Testing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Testing.Controls.Add(this.Button_GetSections);
            this.GroupBox_Testing.Controls.Add(this.Button_GetGroups);
            this.GroupBox_Testing.Controls.Add(this.Button_ReadTable);
            this.GroupBox_Testing.Controls.Add(this.Button_GetMessages);
            this.GroupBox_Testing.Controls.Add(this.DataGridView_ExcelSheet);
            this.GroupBox_Testing.Location = new System.Drawing.Point(837, 261);
            this.GroupBox_Testing.Name = "GroupBox_Testing";
            this.GroupBox_Testing.Size = new System.Drawing.Size(164, 342);
            this.GroupBox_Testing.TabIndex = 10;
            this.GroupBox_Testing.TabStop = false;
            this.GroupBox_Testing.Text = "Testing";
            this.GroupBox_Testing.Visible = false;
            // 
            // Button_GetSections
            // 
            this.Button_GetSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GetSections.Location = new System.Drawing.Point(6, 106);
            this.Button_GetSections.Name = "Button_GetSections";
            this.Button_GetSections.Size = new System.Drawing.Size(152, 23);
            this.Button_GetSections.TabIndex = 7;
            this.Button_GetSections.Text = "Get Text Sections";
            this.Button_GetSections.UseVisualStyleBackColor = true;
            this.Button_GetSections.Click += new System.EventHandler(this.Button_GetSections_Click);
            // 
            // Button_TextStore
            // 
            this.Button_TextStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_TextStore.Location = new System.Drawing.Point(6, 48);
            this.Button_TextStore.Name = "Button_TextStore";
            this.Button_TextStore.Size = new System.Drawing.Size(152, 23);
            this.Button_TextStore.TabIndex = 11;
            this.Button_TextStore.Text = "Multi Editor";
            this.Button_TextStore.UseVisualStyleBackColor = true;
            this.Button_TextStore.Click += new System.EventHandler(this.Button_TextStore_Click);
            // 
            // GroupBox_Misc
            // 
            this.GroupBox_Misc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Misc.Controls.Add(this.Button_ProjectSettings);
            this.GroupBox_Misc.Controls.Add(this.Button_ExportHashCodes);
            this.GroupBox_Misc.Controls.Add(this.Button_TextStore);
            this.GroupBox_Misc.Location = new System.Drawing.Point(837, 0);
            this.GroupBox_Misc.Name = "GroupBox_Misc";
            this.GroupBox_Misc.Size = new System.Drawing.Size(164, 113);
            this.GroupBox_Misc.TabIndex = 12;
            this.GroupBox_Misc.TabStop = false;
            this.GroupBox_Misc.Text = "Misc";
            // 
            // Button_ProjectSettings
            // 
            this.Button_ProjectSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ProjectSettings.Location = new System.Drawing.Point(6, 19);
            this.Button_ProjectSettings.Name = "Button_ProjectSettings";
            this.Button_ProjectSettings.Size = new System.Drawing.Size(152, 23);
            this.Button_ProjectSettings.TabIndex = 13;
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
            this.Button_ExportHashCodes.Size = new System.Drawing.Size(152, 23);
            this.Button_ExportHashCodes.TabIndex = 12;
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
            this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(0, 0);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(831, 615);
            this.dockPanel.TabIndex = 13;
            // 
            // Frm_MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 615);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.GroupBox_Misc);
            this.Controls.Add(this.GroupBox_Testing);
            this.Controls.Add(this.Groupbox_Output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.MainMenu;
            this.Name = "Frm_MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EuroText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_MainFrame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ExcelSheet)).EndInit();
            this.Groupbox_Output.ResumeLayout(false);
            this.Groupbox_Output.PerformLayout();
            this.GroupBox_Testing.ResumeLayout(false);
            this.GroupBox_Misc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_ReadTable;
        private System.Windows.Forms.DataGridView DataGridView_ExcelSheet;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem MenuItem_File;
        private System.Windows.Forms.MenuItem MenuItem_OpenProject;
        private System.Windows.Forms.MenuItem MenuItem_NewProject;
        private System.Windows.Forms.MenuItem MenuItem_RecentProjects;
        private System.Windows.Forms.MenuItem MenuItem_Help;
        private System.Windows.Forms.MenuItem MenuItem_About;
        private System.Windows.Forms.Button Button_GetGroups;
        private System.Windows.Forms.Button Button_GetMessages;
        private System.Windows.Forms.GroupBox Groupbox_Output;
        private System.Windows.Forms.Button Button_Output;
        private System.Windows.Forms.MenuItem MenuItem_Divider1;
        private System.Windows.Forms.MenuItem MenuItem_Divider2;
        private System.Windows.Forms.MenuItem MenuItem_Exit;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        protected internal System.Windows.Forms.CheckBox Checkbox_DataInfoSheet;
        protected internal System.Windows.Forms.CheckBox Checkbox_FormatInfo;
        private System.Windows.Forms.GroupBox GroupBox_Testing;
        private System.Windows.Forms.Button Button_TextStore;
        private System.Windows.Forms.GroupBox GroupBox_Misc;
        private System.Windows.Forms.Button Button_ExportHashCodes;
        private System.Windows.Forms.Button Button_ProjectSettings;
        private System.Windows.Forms.Button Button_GetSections;
        private System.Windows.Forms.Label Label_OutputName;
        protected internal System.Windows.Forms.TextBox Textbox_FileName;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
    }
}

