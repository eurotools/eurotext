
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
            this.MenuItem_Help = new System.Windows.Forms.MenuItem();
            this.MenuItem_About = new System.Windows.Forms.MenuItem();
            this.Label_TotalHashCodes = new System.Windows.Forms.Label();
            this.ListBox_HashCodes = new System.Windows.Forms.ListBox();
            this.ContextMenu_HashCodes = new System.Windows.Forms.ContextMenu();
            this.MenuItem_Edit = new System.Windows.Forms.MenuItem();
            this.MenuItem_New = new System.Windows.Forms.MenuItem();
            this.MenuItem_Delete = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.MenuItem_SetGroup = new System.Windows.Forms.MenuItem();
            this.Button_UpdateHashCodes = new System.Windows.Forms.Button();
            this.Button_GetGroups = new System.Windows.Forms.Button();
            this.Button_GetMessages = new System.Windows.Forms.Button();
            this.ListView_SectionsAndLevels = new System.Windows.Forms.ListView();
            this.Col_TextSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_OutputLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Groupbox_Output = new System.Windows.Forms.GroupBox();
            this.Checkbox_DataInfoSheet = new System.Windows.Forms.CheckBox();
            this.Checkbox_FormatInfo = new System.Windows.Forms.CheckBox();
            this.Button_Output = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Checkbox_SortByDate = new System.Windows.Forms.CheckBox();
            this.Textbox_SearchBarHashCodes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_GetSections = new System.Windows.Forms.Button();
            this.Button_TextStore = new System.Windows.Forms.Button();
            this.GroupBox_Misc = new System.Windows.Forms.GroupBox();
            this.Button_ProjectSettings = new System.Windows.Forms.Button();
            this.Button_ExportHashCodes = new System.Windows.Forms.Button();
            this.GroupBox_TextSection = new System.Windows.Forms.GroupBox();
            this.Label_TotalSections = new System.Windows.Forms.Label();
            this.Button_CreateSection = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ExcelSheet)).BeginInit();
            this.GroupBox_TextGroups.SuspendLayout();
            this.Groupbox_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox_Misc.SuspendLayout();
            this.GroupBox_TextSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.DataGridView_ExcelSheet.Location = new System.Drawing.Point(6, 135);
            this.DataGridView_ExcelSheet.Name = "DataGridView_ExcelSheet";
            this.DataGridView_ExcelSheet.Size = new System.Drawing.Size(152, 216);
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
            this.GroupBox_TextGroups.Size = new System.Drawing.Size(267, 603);
            this.GroupBox_TextGroups.TabIndex = 3;
            this.GroupBox_TextGroups.TabStop = false;
            this.GroupBox_TextGroups.Text = "Text Groups";
            // 
            // Label_Total_Groups
            // 
            this.Label_Total_Groups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Total_Groups.AutoSize = true;
            this.Label_Total_Groups.Location = new System.Drawing.Point(6, 581);
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
            this.Button_CreateNewGroup.Size = new System.Drawing.Size(255, 23);
            this.Button_CreateNewGroup.TabIndex = 4;
            this.Button_CreateNewGroup.Text = "Create New Group";
            this.Button_CreateNewGroup.UseVisualStyleBackColor = true;
            this.Button_CreateNewGroup.Click += new System.EventHandler(this.Button_CreateNewGroup_Click);
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
            this.ListBox_TextGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox_TextGroups.Size = new System.Drawing.Size(255, 524);
            this.ListBox_TextGroups.TabIndex = 0;
            this.ListBox_TextGroups.DoubleClick += new System.EventHandler(this.ListBox_TextGroups_DoubleClick);
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
            // Label_TotalHashCodes
            // 
            this.Label_TotalHashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_TotalHashCodes.AutoSize = true;
            this.Label_TotalHashCodes.Location = new System.Drawing.Point(6, 581);
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
            this.ListBox_HashCodes.ContextMenu = this.ContextMenu_HashCodes;
            this.ListBox_HashCodes.FormattingEnabled = true;
            this.ListBox_HashCodes.HorizontalScrollbar = true;
            this.ListBox_HashCodes.Location = new System.Drawing.Point(6, 87);
            this.ListBox_HashCodes.Name = "ListBox_HashCodes";
            this.ListBox_HashCodes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox_HashCodes.Size = new System.Drawing.Size(279, 459);
            this.ListBox_HashCodes.TabIndex = 1;
            this.ListBox_HashCodes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_HashCodes_MouseDoubleClick);
            // 
            // ContextMenu_HashCodes
            // 
            this.ContextMenu_HashCodes.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_Edit,
            this.MenuItem_New,
            this.MenuItem_Delete,
            this.menuItem3,
            this.menuItem4,
            this.MenuItem_SetGroup});
            // 
            // MenuItem_Edit
            // 
            this.MenuItem_Edit.Index = 0;
            this.MenuItem_Edit.Text = "Edit";
            // 
            // MenuItem_New
            // 
            this.MenuItem_New.Index = 1;
            this.MenuItem_New.Text = "New";
            this.MenuItem_New.Click += new System.EventHandler(this.MenuItem_New_Click);
            // 
            // MenuItem_Delete
            // 
            this.MenuItem_Delete.Index = 2;
            this.MenuItem_Delete.Text = "Delete";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "Rename";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.Text = "-";
            // 
            // MenuItem_SetGroup
            // 
            this.MenuItem_SetGroup.Index = 5;
            this.MenuItem_SetGroup.Text = "Set Group";
            this.MenuItem_SetGroup.Click += new System.EventHandler(this.MenuItem_SetGroup_Click);
            // 
            // Button_UpdateHashCodes
            // 
            this.Button_UpdateHashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_UpdateHashCodes.Location = new System.Drawing.Point(6, 19);
            this.Button_UpdateHashCodes.Name = "Button_UpdateHashCodes";
            this.Button_UpdateHashCodes.Size = new System.Drawing.Size(279, 23);
            this.Button_UpdateHashCodes.TabIndex = 0;
            this.Button_UpdateHashCodes.Text = "Refresh List";
            this.Button_UpdateHashCodes.UseVisualStyleBackColor = true;
            this.Button_UpdateHashCodes.Click += new System.EventHandler(this.Button_UpdateHashCodes_Click);
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
            // ListView_SectionsAndLevels
            // 
            this.ListView_SectionsAndLevels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_SectionsAndLevels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_TextSection,
            this.Col_OutputLevel});
            this.ListView_SectionsAndLevels.FullRowSelect = true;
            this.ListView_SectionsAndLevels.GridLines = true;
            this.ListView_SectionsAndLevels.HideSelection = false;
            this.ListView_SectionsAndLevels.Location = new System.Drawing.Point(6, 48);
            this.ListView_SectionsAndLevels.Name = "ListView_SectionsAndLevels";
            this.ListView_SectionsAndLevels.Size = new System.Drawing.Size(232, 525);
            this.ListView_SectionsAndLevels.TabIndex = 0;
            this.ListView_SectionsAndLevels.UseCompatibleStateImageBehavior = false;
            this.ListView_SectionsAndLevels.View = System.Windows.Forms.View.Details;
            // 
            // Col_TextSection
            // 
            this.Col_TextSection.Text = "Num";
            this.Col_TextSection.Width = 40;
            // 
            // Col_OutputLevel
            // 
            this.Col_OutputLevel.Text = "Level";
            this.Col_OutputLevel.Width = 180;
            // 
            // Groupbox_Output
            // 
            this.Groupbox_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Groupbox_Output.Controls.Add(this.Checkbox_DataInfoSheet);
            this.Groupbox_Output.Controls.Add(this.Checkbox_FormatInfo);
            this.Groupbox_Output.Controls.Add(this.Button_Output);
            this.Groupbox_Output.Location = new System.Drawing.Point(828, 0);
            this.Groupbox_Output.Name = "Groupbox_Output";
            this.Groupbox_Output.Size = new System.Drawing.Size(164, 97);
            this.Groupbox_Output.TabIndex = 8;
            this.Groupbox_Output.TabStop = false;
            this.Groupbox_Output.Text = "Output";
            // 
            // Checkbox_DataInfoSheet
            // 
            this.Checkbox_DataInfoSheet.AutoSize = true;
            this.Checkbox_DataInfoSheet.Location = new System.Drawing.Point(6, 71);
            this.Checkbox_DataInfoSheet.Name = "Checkbox_DataInfoSheet";
            this.Checkbox_DataInfoSheet.Size = new System.Drawing.Size(139, 17);
            this.Checkbox_DataInfoSheet.TabIndex = 2;
            this.Checkbox_DataInfoSheet.Text = "Include Data Info Sheet";
            this.Checkbox_DataInfoSheet.UseVisualStyleBackColor = true;
            // 
            // Checkbox_FormatInfo
            // 
            this.Checkbox_FormatInfo.AutoSize = true;
            this.Checkbox_FormatInfo.Location = new System.Drawing.Point(6, 48);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GroupBox_TextGroups);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(562, 603);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Checkbox_SortByDate);
            this.groupBox1.Controls.Add(this.Textbox_SearchBarHashCodes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Label_TotalHashCodes);
            this.groupBox1.Controls.Add(this.Button_UpdateHashCodes);
            this.groupBox1.Controls.Add(this.ListBox_HashCodes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 603);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HashCodes";
            // 
            // Checkbox_SortByDate
            // 
            this.Checkbox_SortByDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Checkbox_SortByDate.AutoSize = true;
            this.Checkbox_SortByDate.Location = new System.Drawing.Point(6, 556);
            this.Checkbox_SortByDate.Name = "Checkbox_SortByDate";
            this.Checkbox_SortByDate.Size = new System.Drawing.Size(91, 17);
            this.Checkbox_SortByDate.TabIndex = 5;
            this.Checkbox_SortByDate.Text = "Sort by Date?";
            this.Checkbox_SortByDate.UseVisualStyleBackColor = true;
            // 
            // Textbox_SearchBarHashCodes
            // 
            this.Textbox_SearchBarHashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_SearchBarHashCodes.Location = new System.Drawing.Point(6, 61);
            this.Textbox_SearchBarHashCodes.Name = "Textbox_SearchBarHashCodes";
            this.Textbox_SearchBarHashCodes.Size = new System.Drawing.Size(279, 20);
            this.Textbox_SearchBarHashCodes.TabIndex = 4;
            this.Textbox_SearchBarHashCodes.TextChanged += new System.EventHandler(this.Textbox_SearchBarHashCodes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "EuroText Project (*.etp)|*.etp";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Button_GetSections);
            this.groupBox2.Controls.Add(this.Button_GetGroups);
            this.groupBox2.Controls.Add(this.Button_ReadTable);
            this.groupBox2.Controls.Add(this.Button_GetMessages);
            this.groupBox2.Controls.Add(this.DataGridView_ExcelSheet);
            this.groupBox2.Location = new System.Drawing.Point(828, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 357);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testing";
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
            this.GroupBox_Misc.Location = new System.Drawing.Point(828, 103);
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
            // GroupBox_TextSection
            // 
            this.GroupBox_TextSection.Controls.Add(this.Label_TotalSections);
            this.GroupBox_TextSection.Controls.Add(this.Button_CreateSection);
            this.GroupBox_TextSection.Controls.Add(this.ListView_SectionsAndLevels);
            this.GroupBox_TextSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_TextSection.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_TextSection.Name = "GroupBox_TextSection";
            this.GroupBox_TextSection.Size = new System.Drawing.Size(244, 603);
            this.GroupBox_TextSection.TabIndex = 13;
            this.GroupBox_TextSection.TabStop = false;
            this.GroupBox_TextSection.Text = "Text Section";
            // 
            // Label_TotalSections
            // 
            this.Label_TotalSections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_TotalSections.AutoSize = true;
            this.Label_TotalSections.Location = new System.Drawing.Point(6, 581);
            this.Label_TotalSections.Name = "Label_TotalSections";
            this.Label_TotalSections.Size = new System.Drawing.Size(43, 13);
            this.Label_TotalSections.TabIndex = 2;
            this.Label_TotalSections.Text = "Total: 0";
            // 
            // Button_CreateSection
            // 
            this.Button_CreateSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_CreateSection.Location = new System.Drawing.Point(6, 19);
            this.Button_CreateSection.Name = "Button_CreateSection";
            this.Button_CreateSection.Size = new System.Drawing.Size(232, 23);
            this.Button_CreateSection.TabIndex = 1;
            this.Button_CreateSection.Text = "Create New Section";
            this.Button_CreateSection.UseVisualStyleBackColor = true;
            this.Button_CreateSection.Click += new System.EventHandler(this.Button_CreateSection_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(12, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.GroupBox_TextSection);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(810, 603);
            this.splitContainer2.SplitterDistance = 244;
            this.splitContainer2.TabIndex = 14;
            // 
            // Frm_MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 615);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.GroupBox_Misc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Groupbox_Output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.MainMenu;
            this.Name = "Frm_MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EuroText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_MainFrame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ExcelSheet)).EndInit();
            this.GroupBox_TextGroups.ResumeLayout(false);
            this.GroupBox_TextGroups.PerformLayout();
            this.Groupbox_Output.ResumeLayout(false);
            this.Groupbox_Output.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.GroupBox_Misc.ResumeLayout(false);
            this.GroupBox_TextSection.ResumeLayout(false);
            this.GroupBox_TextSection.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_ReadTable;
        private System.Windows.Forms.DataGridView DataGridView_ExcelSheet;
        private System.Windows.Forms.GroupBox GroupBox_TextGroups;
        private System.Windows.Forms.Button Button_CreateNewGroup;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem MenuItem_File;
        private System.Windows.Forms.MenuItem MenuItem_OpenProject;
        private System.Windows.Forms.MenuItem MenuItem_NewProject;
        private System.Windows.Forms.MenuItem MenuItem_RecentProjects;
        private System.Windows.Forms.MenuItem MenuItem_Help;
        private System.Windows.Forms.MenuItem MenuItem_About;
        private System.Windows.Forms.Button Button_UpdateHashCodes;
        private System.Windows.Forms.Button Button_GetGroups;
        private System.Windows.Forms.Button Button_GetMessages;
        private System.Windows.Forms.ColumnHeader Col_OutputLevel;
        private System.Windows.Forms.ColumnHeader Col_TextSection;
        private System.Windows.Forms.GroupBox Groupbox_Output;
        private System.Windows.Forms.Button Button_Output;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuItem MenuItem_Divider1;
        private System.Windows.Forms.MenuItem MenuItem_Divider2;
        private System.Windows.Forms.MenuItem MenuItem_Exit;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        protected internal System.Windows.Forms.Label Label_Total_Groups;
        protected internal System.Windows.Forms.ListBox ListBox_TextGroups;
        protected internal System.Windows.Forms.Label Label_TotalHashCodes;
        protected internal System.Windows.Forms.ListBox ListBox_HashCodes;
        protected internal System.Windows.Forms.ListView ListView_SectionsAndLevels;
        protected internal System.Windows.Forms.CheckBox Checkbox_DataInfoSheet;
        protected internal System.Windows.Forms.CheckBox Checkbox_FormatInfo;
        private System.Windows.Forms.ContextMenu ContextMenu_HashCodes;
        private System.Windows.Forms.MenuItem MenuItem_Edit;
        private System.Windows.Forms.MenuItem MenuItem_SetGroup;
        private System.Windows.Forms.MenuItem MenuItem_Delete;
        private System.Windows.Forms.MenuItem MenuItem_New;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Textbox_SearchBarHashCodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_TextStore;
        private System.Windows.Forms.GroupBox GroupBox_Misc;
        private System.Windows.Forms.Button Button_ExportHashCodes;
        private System.Windows.Forms.Button Button_ProjectSettings;
        private System.Windows.Forms.CheckBox Checkbox_SortByDate;
        private System.Windows.Forms.Button Button_GetSections;
        private System.Windows.Forms.GroupBox GroupBox_TextSection;
        private System.Windows.Forms.Button Button_CreateSection;
        private System.Windows.Forms.SplitContainer splitContainer2;
        protected internal System.Windows.Forms.Label Label_TotalSections;
    }
}

