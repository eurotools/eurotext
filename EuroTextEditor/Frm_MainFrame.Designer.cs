
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
            this.GroupBox_TextGroups = new System.Windows.Forms.GroupBox();
            this.Label_Total_Groups = new System.Windows.Forms.Label();
            this.Button_CreateNewGroup = new System.Windows.Forms.Button();
            this.ListBox_TextGroups = new System.Windows.Forms.ListBox();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItem_File = new System.Windows.Forms.MenuItem();
            this.MenuItem_OpenProject = new System.Windows.Forms.MenuItem();
            this.MenuItem_NewProject = new System.Windows.Forms.MenuItem();
            this.MenuItem_Divider1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_RecentProjects = new System.Windows.Forms.MenuItem();
            this.MenuItem_Divider2 = new System.Windows.Forms.MenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.MenuItem();
            this.MenuItem_Settings = new System.Windows.Forms.MenuItem();
            this.MenuItem_SetHashCodesDir = new System.Windows.Forms.MenuItem();
            this.MenuItem_Help = new System.Windows.Forms.MenuItem();
            this.MenuItem_About = new System.Windows.Forms.MenuItem();
            this.GroupBox_HashCodes = new System.Windows.Forms.GroupBox();
            this.Label_TotalHashCodes = new System.Windows.Forms.Label();
            this.ListBox_HashCodes = new System.Windows.Forms.ListBox();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_GetGroups = new System.Windows.Forms.Button();
            this.Button_GetMessages = new System.Windows.Forms.Button();
            this.Button_WriteTest = new System.Windows.Forms.Button();
            this.ListView_SectionsAndLevels = new System.Windows.Forms.ListView();
            this.Col_TextSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_OutputLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Groupbox_Output = new System.Windows.Forms.GroupBox();
            this.Button_Output = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ExcelSheet)).BeginInit();
            this.GroupBox_TextGroups.SuspendLayout();
            this.GroupBox_HashCodes.SuspendLayout();
            this.Groupbox_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_ReadTable
            // 
            this.Button_ReadTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ReadTable.Location = new System.Drawing.Point(938, 527);
            this.Button_ReadTable.Name = "Button_ReadTable";
            this.Button_ReadTable.Size = new System.Drawing.Size(75, 23);
            this.Button_ReadTable.TabIndex = 1;
            this.Button_ReadTable.Text = "Read Table";
            this.Button_ReadTable.UseVisualStyleBackColor = true;
            this.Button_ReadTable.Click += new System.EventHandler(this.ReadTable_Click);
            // 
            // DataGridView_ExcelSheet
            // 
            this.DataGridView_ExcelSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_ExcelSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ExcelSheet.Location = new System.Drawing.Point(849, 565);
            this.DataGridView_ExcelSheet.Name = "DataGridView_ExcelSheet";
            this.DataGridView_ExcelSheet.Size = new System.Drawing.Size(164, 38);
            this.DataGridView_ExcelSheet.TabIndex = 2;
            // 
            // GroupBox_TextGroups
            // 
            this.GroupBox_TextGroups.Controls.Add(this.Label_Total_Groups);
            this.GroupBox_TextGroups.Controls.Add(this.Button_CreateNewGroup);
            this.GroupBox_TextGroups.Controls.Add(this.ListBox_TextGroups);
            this.GroupBox_TextGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_TextGroups.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_TextGroups.Name = "GroupBox_TextGroups";
            this.GroupBox_TextGroups.Size = new System.Drawing.Size(252, 615);
            this.GroupBox_TextGroups.TabIndex = 3;
            this.GroupBox_TextGroups.TabStop = false;
            this.GroupBox_TextGroups.Text = "Text Groups:";
            // 
            // Label_Total_Groups
            // 
            this.Label_Total_Groups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Total_Groups.AutoSize = true;
            this.Label_Total_Groups.Location = new System.Drawing.Point(6, 593);
            this.Label_Total_Groups.Name = "Label_Total_Groups";
            this.Label_Total_Groups.Size = new System.Drawing.Size(43, 13);
            this.Label_Total_Groups.TabIndex = 5;
            this.Label_Total_Groups.Text = "Total: 0";
            // 
            // Button_CreateNewGroup
            // 
            this.Button_CreateNewGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_CreateNewGroup.Location = new System.Drawing.Point(6, 19);
            this.Button_CreateNewGroup.Name = "Button_CreateNewGroup";
            this.Button_CreateNewGroup.Size = new System.Drawing.Size(240, 23);
            this.Button_CreateNewGroup.TabIndex = 4;
            this.Button_CreateNewGroup.Text = "Create New Group";
            this.Button_CreateNewGroup.UseVisualStyleBackColor = true;
            // 
            // ListBox_TextGroups
            // 
            this.ListBox_TextGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_TextGroups.FormattingEnabled = true;
            this.ListBox_TextGroups.HorizontalScrollbar = true;
            this.ListBox_TextGroups.Location = new System.Drawing.Point(6, 48);
            this.ListBox_TextGroups.Name = "ListBox_TextGroups";
            this.ListBox_TextGroups.Size = new System.Drawing.Size(240, 537);
            this.ListBox_TextGroups.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_File,
            this.MenuItem_Settings,
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
            // 
            // MenuItem_NewProject
            // 
            this.MenuItem_NewProject.Index = 1;
            this.MenuItem_NewProject.Text = "New Project";
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
            // MenuItem_Settings
            // 
            this.MenuItem_Settings.Index = 1;
            this.MenuItem_Settings.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_SetHashCodesDir});
            this.MenuItem_Settings.Text = "Settings";
            // 
            // MenuItem_SetHashCodesDir
            // 
            this.MenuItem_SetHashCodesDir.Index = 0;
            this.MenuItem_SetHashCodesDir.Text = "Set HashCodes File";
            this.MenuItem_SetHashCodesDir.Click += new System.EventHandler(this.MenuItem_SetHashCodesDir_Click);
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
            // 
            // GroupBox_HashCodes
            // 
            this.GroupBox_HashCodes.Controls.Add(this.Label_TotalHashCodes);
            this.GroupBox_HashCodes.Controls.Add(this.ListBox_HashCodes);
            this.GroupBox_HashCodes.Controls.Add(this.Button_Update);
            this.GroupBox_HashCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_HashCodes.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_HashCodes.Name = "GroupBox_HashCodes";
            this.GroupBox_HashCodes.Size = new System.Drawing.Size(272, 615);
            this.GroupBox_HashCodes.TabIndex = 4;
            this.GroupBox_HashCodes.TabStop = false;
            this.GroupBox_HashCodes.Text = "HashCodes:";
            // 
            // Label_TotalHashCodes
            // 
            this.Label_TotalHashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_TotalHashCodes.AutoSize = true;
            this.Label_TotalHashCodes.Location = new System.Drawing.Point(6, 593);
            this.Label_TotalHashCodes.Name = "Label_TotalHashCodes";
            this.Label_TotalHashCodes.Size = new System.Drawing.Size(43, 13);
            this.Label_TotalHashCodes.TabIndex = 2;
            this.Label_TotalHashCodes.Text = "Total: 0";
            // 
            // ListBox_HashCodes
            // 
            this.ListBox_HashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_HashCodes.FormattingEnabled = true;
            this.ListBox_HashCodes.HorizontalScrollbar = true;
            this.ListBox_HashCodes.Location = new System.Drawing.Point(6, 48);
            this.ListBox_HashCodes.Name = "ListBox_HashCodes";
            this.ListBox_HashCodes.Size = new System.Drawing.Size(260, 537);
            this.ListBox_HashCodes.TabIndex = 1;
            this.ListBox_HashCodes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_HashCodes_MouseDoubleClick);
            // 
            // Button_Update
            // 
            this.Button_Update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Update.Location = new System.Drawing.Point(6, 19);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(260, 23);
            this.Button_Update.TabIndex = 0;
            this.Button_Update.Text = "Update HashCodes List";
            this.Button_Update.UseVisualStyleBackColor = true;
            // 
            // Button_GetGroups
            // 
            this.Button_GetGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GetGroups.Location = new System.Drawing.Point(941, 498);
            this.Button_GetGroups.Name = "Button_GetGroups";
            this.Button_GetGroups.Size = new System.Drawing.Size(72, 23);
            this.Button_GetGroups.TabIndex = 5;
            this.Button_GetGroups.Text = "Get Groups";
            this.Button_GetGroups.UseVisualStyleBackColor = true;
            this.Button_GetGroups.Click += new System.EventHandler(this.Button_GetGroups_Click);
            // 
            // Button_GetMessages
            // 
            this.Button_GetMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GetMessages.Location = new System.Drawing.Point(849, 527);
            this.Button_GetMessages.Name = "Button_GetMessages";
            this.Button_GetMessages.Size = new System.Drawing.Size(86, 23);
            this.Button_GetMessages.TabIndex = 6;
            this.Button_GetMessages.Text = "Get Messages";
            this.Button_GetMessages.UseVisualStyleBackColor = true;
            this.Button_GetMessages.Click += new System.EventHandler(this.Button_GetMessages_Click);
            // 
            // Button_WriteTest
            // 
            this.Button_WriteTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_WriteTest.Location = new System.Drawing.Point(849, 498);
            this.Button_WriteTest.Name = "Button_WriteTest";
            this.Button_WriteTest.Size = new System.Drawing.Size(86, 23);
            this.Button_WriteTest.TabIndex = 7;
            this.Button_WriteTest.Text = "Write Test";
            this.Button_WriteTest.UseVisualStyleBackColor = true;
            this.Button_WriteTest.Click += new System.EventHandler(this.Button_WriteTest_Click);
            // 
            // ListView_SectionsAndLevels
            // 
            this.ListView_SectionsAndLevels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_TextSection,
            this.Col_OutputLevel});
            this.ListView_SectionsAndLevels.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListView_SectionsAndLevels.FullRowSelect = true;
            this.ListView_SectionsAndLevels.GridLines = true;
            this.ListView_SectionsAndLevels.HideSelection = false;
            this.ListView_SectionsAndLevels.Location = new System.Drawing.Point(0, 0);
            this.ListView_SectionsAndLevels.Name = "ListView_SectionsAndLevels";
            this.ListView_SectionsAndLevels.Size = new System.Drawing.Size(309, 615);
            this.ListView_SectionsAndLevels.TabIndex = 0;
            this.ListView_SectionsAndLevels.UseCompatibleStateImageBehavior = false;
            this.ListView_SectionsAndLevels.View = System.Windows.Forms.View.Details;
            // 
            // Col_TextSection
            // 
            this.Col_TextSection.Text = "Text Section";
            this.Col_TextSection.Width = 146;
            // 
            // Col_OutputLevel
            // 
            this.Col_OutputLevel.Text = "Level";
            this.Col_OutputLevel.Width = 153;
            // 
            // Groupbox_Output
            // 
            this.Groupbox_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Groupbox_Output.Controls.Add(this.Button_Output);
            this.Groupbox_Output.Location = new System.Drawing.Point(849, 0);
            this.Groupbox_Output.Name = "Groupbox_Output";
            this.Groupbox_Output.Size = new System.Drawing.Size(164, 82);
            this.Groupbox_Output.TabIndex = 8;
            this.Groupbox_Output.TabStop = false;
            this.Groupbox_Output.Text = "Options:";
            // 
            // Button_Output
            // 
            this.Button_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Output.Location = new System.Drawing.Point(6, 19);
            this.Button_Output.Name = "Button_Output";
            this.Button_Output.Size = new System.Drawing.Size(152, 23);
            this.Button_Output.TabIndex = 0;
            this.Button_Output.Text = "Output SpreadSheet";
            this.Button_Output.UseVisualStyleBackColor = true;
            this.Button_Output.Click += new System.EventHandler(this.Button_Output_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(315, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GroupBox_TextGroups);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GroupBox_HashCodes);
            this.splitContainer1.Size = new System.Drawing.Size(528, 615);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 9;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Header files (*.h)|*.h|All files (*.*)|*.*";
            // 
            // Frm_MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 615);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Groupbox_Output);
            this.Controls.Add(this.ListView_SectionsAndLevels);
            this.Controls.Add(this.Button_GetGroups);
            this.Controls.Add(this.Button_WriteTest);
            this.Controls.Add(this.Button_GetMessages);
            this.Controls.Add(this.DataGridView_ExcelSheet);
            this.Controls.Add(this.Button_ReadTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.MainMenu;
            this.Name = "Frm_MainFrame";
            this.Text = "EuroText Editor";
            this.Load += new System.EventHandler(this.Frm_MainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ExcelSheet)).EndInit();
            this.GroupBox_TextGroups.ResumeLayout(false);
            this.GroupBox_TextGroups.PerformLayout();
            this.GroupBox_HashCodes.ResumeLayout(false);
            this.GroupBox_HashCodes.PerformLayout();
            this.Groupbox_Output.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_ReadTable;
        private System.Windows.Forms.DataGridView DataGridView_ExcelSheet;
        private System.Windows.Forms.GroupBox GroupBox_TextGroups;
        private System.Windows.Forms.Label Label_Total_Groups;
        private System.Windows.Forms.Button Button_CreateNewGroup;
        private System.Windows.Forms.ListBox ListBox_TextGroups;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem MenuItem_File;
        private System.Windows.Forms.MenuItem MenuItem_OpenProject;
        private System.Windows.Forms.MenuItem MenuItem_NewProject;
        private System.Windows.Forms.MenuItem MenuItem_RecentProjects;
        private System.Windows.Forms.MenuItem MenuItem_Help;
        private System.Windows.Forms.MenuItem MenuItem_About;
        private System.Windows.Forms.GroupBox GroupBox_HashCodes;
        private System.Windows.Forms.Label Label_TotalHashCodes;
        private System.Windows.Forms.ListBox ListBox_HashCodes;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button Button_GetGroups;
        private System.Windows.Forms.Button Button_GetMessages;
        private System.Windows.Forms.Button Button_WriteTest;
        private System.Windows.Forms.ListView ListView_SectionsAndLevels;
        private System.Windows.Forms.ColumnHeader Col_OutputLevel;
        private System.Windows.Forms.ColumnHeader Col_TextSection;
        private System.Windows.Forms.GroupBox Groupbox_Output;
        private System.Windows.Forms.Button Button_Output;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuItem MenuItem_Divider1;
        private System.Windows.Forms.MenuItem MenuItem_Divider2;
        private System.Windows.Forms.MenuItem MenuItem_Exit;
        private System.Windows.Forms.MenuItem MenuItem_Settings;
        private System.Windows.Forms.MenuItem MenuItem_SetHashCodesDir;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}

