
namespace EuroText2
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalGroups = new System.Windows.Forms.Label();
            this.lboxGroups = new System.Windows.Forms.ListBox();
            this.ContextMenu_Groups = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemGroups_New = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGroups_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGroups_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGroups_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnImportTextFiles = new System.Windows.Forms.Button();
            this.btnSectionsInspector = new System.Windows.Forms.Button();
            this.btnSetTextSections = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSpreadSheetsExtract = new System.Windows.Forms.Button();
            this.btnUpdateHashTable = new System.Windows.Forms.Button();
            this.btnProjectProperties = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProjectCompare = new System.Windows.Forms.Button();
            this.btnTranslations = new System.Windows.Forms.Button();
            this.btnFontBuilder = new System.Windows.Forms.Button();
            this.btnTrimStrings = new System.Windows.Forms.Button();
            this.btnRemoveDoubleSpacing = new System.Windows.Forms.Button();
            this.WordsReplace = new System.Windows.Forms.Button();
            this.Groupbox_Output = new System.Windows.Forms.GroupBox();
            this.Label_OutputName = new System.Windows.Forms.Label();
            this.Textbox_FileName = new System.Windows.Forms.TextBox();
            this.Checkbox_DataInfoSheet = new System.Windows.Forms.CheckBox();
            this.Checkbox_FormatInfo = new System.Windows.Forms.CheckBox();
            this.Button_Output = new System.Windows.Forms.Button();
            this.Checkbox_IncludeHashCodesWithNoSection = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalOutSections = new System.Windows.Forms.Label();
            this.lboxOutSections = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalHashCodes = new System.Windows.Forms.Label();
            this.lboxSectionTexts = new System.Windows.Forms.ListBox();
            this.ContextMenu_Texts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemTextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemTextNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextRename = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemTextEditCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextEditGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemTextCopyHashCode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemTextExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_OpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_NewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemProject_RecentProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemStrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grbxEnableTextPreview = new System.Windows.Forms.GroupBox();
            this.tabControlTextPreview = new System.Windows.Forms.TabControl();
            this.chkEnablePreview = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.ContextMenu_Groups.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Groupbox_Output.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.ContextMenu_Texts.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.grbxEnableTextPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblTotalGroups);
            this.groupBox1.Controls.Add(this.lboxGroups);
            this.groupBox1.Location = new System.Drawing.Point(2, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 618);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Groups";
            // 
            // lblTotalGroups
            // 
            this.lblTotalGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalGroups.AutoSize = true;
            this.lblTotalGroups.Location = new System.Drawing.Point(6, 598);
            this.lblTotalGroups.Name = "lblTotalGroups";
            this.lblTotalGroups.Size = new System.Drawing.Size(43, 13);
            this.lblTotalGroups.TabIndex = 1;
            this.lblTotalGroups.Text = "Total: 0";
            // 
            // lboxGroups
            // 
            this.lboxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxGroups.ContextMenuStrip = this.ContextMenu_Groups;
            this.lboxGroups.FormattingEnabled = true;
            this.lboxGroups.HorizontalScrollbar = true;
            this.lboxGroups.Location = new System.Drawing.Point(3, 16);
            this.lboxGroups.Name = "lboxGroups";
            this.lboxGroups.Size = new System.Drawing.Size(237, 576);
            this.lboxGroups.TabIndex = 0;
            this.lboxGroups.SelectedIndexChanged += new System.EventHandler(this.LboxGroups_SelectedIndexChanged);
            // 
            // ContextMenu_Groups
            // 
            this.ContextMenu_Groups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemGroups_New,
            this.MenuItemGroups_Rename,
            this.MenuItemGroups_Delete,
            this.MenuItemGroups_Refresh});
            this.ContextMenu_Groups.Name = "ContextMenu_Groups";
            this.ContextMenu_Groups.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenu_Groups.Size = new System.Drawing.Size(118, 92);
            // 
            // MenuItemGroups_New
            // 
            this.MenuItemGroups_New.Name = "MenuItemGroups_New";
            this.MenuItemGroups_New.Size = new System.Drawing.Size(117, 22);
            this.MenuItemGroups_New.Text = "New";
            this.MenuItemGroups_New.Click += new System.EventHandler(this.MenuItemGroups_New_Click);
            // 
            // MenuItemGroups_Rename
            // 
            this.MenuItemGroups_Rename.Name = "MenuItemGroups_Rename";
            this.MenuItemGroups_Rename.Size = new System.Drawing.Size(117, 22);
            this.MenuItemGroups_Rename.Text = "Rename";
            this.MenuItemGroups_Rename.Click += new System.EventHandler(this.MenuItemGroups_Rename_Click);
            // 
            // MenuItemGroups_Delete
            // 
            this.MenuItemGroups_Delete.Name = "MenuItemGroups_Delete";
            this.MenuItemGroups_Delete.Size = new System.Drawing.Size(117, 22);
            this.MenuItemGroups_Delete.Text = "Delete";
            this.MenuItemGroups_Delete.Click += new System.EventHandler(this.MenuItemGroups_Delete_Click);
            // 
            // MenuItemGroups_Refresh
            // 
            this.MenuItemGroups_Refresh.Name = "MenuItemGroups_Refresh";
            this.MenuItemGroups_Refresh.Size = new System.Drawing.Size(117, 22);
            this.MenuItemGroups_Refresh.Text = "Refresh";
            this.MenuItemGroups_Refresh.Click += new System.EventHandler(this.MenuItemGroups_Refresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnImportTextFiles);
            this.groupBox3.Controls.Add(this.btnSectionsInspector);
            this.groupBox3.Controls.Add(this.btnSetTextSections);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnSpreadSheetsExtract);
            this.groupBox3.Controls.Add(this.btnUpdateHashTable);
            this.groupBox3.Controls.Add(this.btnProjectProperties);
            this.groupBox3.Location = new System.Drawing.Point(772, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 224);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // btnImportTextFiles
            // 
            this.btnImportTextFiles.Location = new System.Drawing.Point(6, 193);
            this.btnImportTextFiles.Name = "btnImportTextFiles";
            this.btnImportTextFiles.Size = new System.Drawing.Size(154, 23);
            this.btnImportTextFiles.TabIndex = 6;
            this.btnImportTextFiles.Text = "Import Dialog Files";
            this.btnImportTextFiles.UseVisualStyleBackColor = true;
            this.btnImportTextFiles.Click += new System.EventHandler(this.BtnImportTextFiles_Click);
            // 
            // btnSectionsInspector
            // 
            this.btnSectionsInspector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSectionsInspector.Location = new System.Drawing.Point(6, 135);
            this.btnSectionsInspector.Name = "btnSectionsInspector";
            this.btnSectionsInspector.Size = new System.Drawing.Size(154, 23);
            this.btnSectionsInspector.TabIndex = 5;
            this.btnSectionsInspector.Text = "Sections Inspector";
            this.btnSectionsInspector.UseVisualStyleBackColor = true;
            this.btnSectionsInspector.Click += new System.EventHandler(this.BtnSectionsInspector_Click);
            // 
            // btnSetTextSections
            // 
            this.btnSetTextSections.Location = new System.Drawing.Point(6, 106);
            this.btnSetTextSections.Name = "btnSetTextSections";
            this.btnSetTextSections.Size = new System.Drawing.Size(154, 23);
            this.btnSetTextSections.TabIndex = 4;
            this.btnSetTextSections.Text = "Set Dialogs Sections";
            this.btnSetTextSections.UseVisualStyleBackColor = true;
            this.btnSetTextSections.Click += new System.EventHandler(this.BtnSetTextSections_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(6, 164);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnSpreadSheetsExtract
            // 
            this.btnSpreadSheetsExtract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpreadSheetsExtract.Location = new System.Drawing.Point(6, 77);
            this.btnSpreadSheetsExtract.Name = "btnSpreadSheetsExtract";
            this.btnSpreadSheetsExtract.Size = new System.Drawing.Size(154, 23);
            this.btnSpreadSheetsExtract.TabIndex = 2;
            this.btnSpreadSheetsExtract.Text = "SpreadSheets Extractor";
            this.btnSpreadSheetsExtract.UseVisualStyleBackColor = true;
            this.btnSpreadSheetsExtract.Click += new System.EventHandler(this.BtnSpreadSheetsExtract_Click);
            // 
            // btnUpdateHashTable
            // 
            this.btnUpdateHashTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateHashTable.Location = new System.Drawing.Point(6, 48);
            this.btnUpdateHashTable.Name = "btnUpdateHashTable";
            this.btnUpdateHashTable.Size = new System.Drawing.Size(154, 23);
            this.btnUpdateHashTable.TabIndex = 1;
            this.btnUpdateHashTable.Text = "Update HashTable";
            this.btnUpdateHashTable.UseVisualStyleBackColor = true;
            this.btnUpdateHashTable.Click += new System.EventHandler(this.BtnUpdateHashTable_Click);
            // 
            // btnProjectProperties
            // 
            this.btnProjectProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjectProperties.Location = new System.Drawing.Point(6, 19);
            this.btnProjectProperties.Name = "btnProjectProperties";
            this.btnProjectProperties.Size = new System.Drawing.Size(154, 23);
            this.btnProjectProperties.TabIndex = 0;
            this.btnProjectProperties.Text = "Properties";
            this.btnProjectProperties.UseVisualStyleBackColor = true;
            this.btnProjectProperties.Click += new System.EventHandler(this.BtnProjectProperties_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnProjectCompare);
            this.groupBox4.Controls.Add(this.btnTranslations);
            this.groupBox4.Controls.Add(this.btnFontBuilder);
            this.groupBox4.Controls.Add(this.btnTrimStrings);
            this.groupBox4.Controls.Add(this.btnRemoveDoubleSpacing);
            this.groupBox4.Controls.Add(this.WordsReplace);
            this.groupBox4.Location = new System.Drawing.Point(772, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 195);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tools";
            // 
            // btnProjectCompare
            // 
            this.btnProjectCompare.Location = new System.Drawing.Point(6, 164);
            this.btnProjectCompare.Name = "btnProjectCompare";
            this.btnProjectCompare.Size = new System.Drawing.Size(154, 23);
            this.btnProjectCompare.TabIndex = 5;
            this.btnProjectCompare.Text = "Project Comparison";
            this.btnProjectCompare.UseVisualStyleBackColor = true;
            this.btnProjectCompare.Click += new System.EventHandler(this.BtnProjectCompare_Click);
            // 
            // btnTranslations
            // 
            this.btnTranslations.Location = new System.Drawing.Point(6, 135);
            this.btnTranslations.Name = "btnTranslations";
            this.btnTranslations.Size = new System.Drawing.Size(154, 23);
            this.btnTranslations.TabIndex = 4;
            this.btnTranslations.Text = "Translations Manager";
            this.btnTranslations.UseVisualStyleBackColor = true;
            this.btnTranslations.Click += new System.EventHandler(this.BtnTranslations_Click);
            // 
            // btnFontBuilder
            // 
            this.btnFontBuilder.Location = new System.Drawing.Point(6, 106);
            this.btnFontBuilder.Name = "btnFontBuilder";
            this.btnFontBuilder.Size = new System.Drawing.Size(154, 23);
            this.btnFontBuilder.TabIndex = 3;
            this.btnFontBuilder.Text = "Font Builder";
            this.btnFontBuilder.UseVisualStyleBackColor = true;
            this.btnFontBuilder.Click += new System.EventHandler(this.BtnFontBuilder_Click);
            // 
            // btnTrimStrings
            // 
            this.btnTrimStrings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnRemoveDoubleSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDoubleSpacing.Location = new System.Drawing.Point(6, 48);
            this.btnRemoveDoubleSpacing.Name = "btnRemoveDoubleSpacing";
            this.btnRemoveDoubleSpacing.Size = new System.Drawing.Size(154, 23);
            this.btnRemoveDoubleSpacing.TabIndex = 1;
            this.btnRemoveDoubleSpacing.Text = "Remove Double-Spacing";
            this.btnRemoveDoubleSpacing.UseVisualStyleBackColor = true;
            this.btnRemoveDoubleSpacing.Click += new System.EventHandler(this.BtnRemoveDoubleSpacing_Click);
            // 
            // WordsReplace
            // 
            this.WordsReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WordsReplace.Location = new System.Drawing.Point(6, 19);
            this.WordsReplace.Name = "WordsReplace";
            this.WordsReplace.Size = new System.Drawing.Size(154, 23);
            this.WordsReplace.TabIndex = 0;
            this.WordsReplace.Text = "Word Replacing";
            this.WordsReplace.UseVisualStyleBackColor = true;
            this.WordsReplace.Click += new System.EventHandler(this.WordsReplace_Click);
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
            this.Groupbox_Output.Location = new System.Drawing.Point(772, 458);
            this.Groupbox_Output.Name = "Groupbox_Output";
            this.Groupbox_Output.Size = new System.Drawing.Size(166, 157);
            this.Groupbox_Output.TabIndex = 5;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lblTotalOutSections);
            this.groupBox2.Controls.Add(this.lboxOutSections);
            this.groupBox2.Location = new System.Drawing.Point(251, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 618);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Sections";
            // 
            // lblTotalOutSections
            // 
            this.lblTotalOutSections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalOutSections.AutoSize = true;
            this.lblTotalOutSections.Location = new System.Drawing.Point(6, 598);
            this.lblTotalOutSections.Name = "lblTotalOutSections";
            this.lblTotalOutSections.Size = new System.Drawing.Size(43, 13);
            this.lblTotalOutSections.TabIndex = 1;
            this.lblTotalOutSections.Text = "Total: 0";
            // 
            // lboxOutSections
            // 
            this.lboxOutSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxOutSections.FormattingEnabled = true;
            this.lboxOutSections.HorizontalScrollbar = true;
            this.lboxOutSections.Location = new System.Drawing.Point(3, 16);
            this.lboxOutSections.Name = "lboxOutSections";
            this.lboxOutSections.Size = new System.Drawing.Size(222, 576);
            this.lboxOutSections.Sorted = true;
            this.lboxOutSections.TabIndex = 0;
            this.lboxOutSections.SelectedIndexChanged += new System.EventHandler(this.LboxOutSections_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lblTotalHashCodes);
            this.groupBox5.Controls.Add(this.lboxSectionTexts);
            this.groupBox5.Location = new System.Drawing.Point(485, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(281, 428);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Section Dialogs";
            // 
            // lblTotalHashCodes
            // 
            this.lblTotalHashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalHashCodes.AutoSize = true;
            this.lblTotalHashCodes.Location = new System.Drawing.Point(6, 408);
            this.lblTotalHashCodes.Name = "lblTotalHashCodes";
            this.lblTotalHashCodes.Size = new System.Drawing.Size(43, 13);
            this.lblTotalHashCodes.TabIndex = 1;
            this.lblTotalHashCodes.Text = "Total: 0";
            // 
            // lboxSectionTexts
            // 
            this.lboxSectionTexts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxSectionTexts.ContextMenuStrip = this.ContextMenu_Texts;
            this.lboxSectionTexts.FormattingEnabled = true;
            this.lboxSectionTexts.HorizontalScrollbar = true;
            this.lboxSectionTexts.Location = new System.Drawing.Point(3, 16);
            this.lboxSectionTexts.Name = "lboxSectionTexts";
            this.lboxSectionTexts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxSectionTexts.Size = new System.Drawing.Size(275, 381);
            this.lboxSectionTexts.Sorted = true;
            this.lboxSectionTexts.TabIndex = 0;
            this.lboxSectionTexts.SelectedIndexChanged += new System.EventHandler(this.LboxSectionTexts_SelectedIndexChanged);
            this.lboxSectionTexts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LboxSectionTexts_MouseDoubleClick);
            // 
            // ContextMenu_Texts
            // 
            this.ContextMenu_Texts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTextEdit,
            this.toolStripSeparator2,
            this.MenuItemTextNew,
            this.MenuItemTextDelete,
            this.MenuItemTextRename,
            this.MenuItemTextSeparator1,
            this.MenuItemTextEditCategories,
            this.MenuItemTextEditGroups,
            this.MenuItemTextSeparator2,
            this.MenuItemTextCopyHashCode,
            this.MenuItemTextSeparator3,
            this.MenuItemTextExport});
            this.ContextMenu_Texts.Name = "ContextMenu_Texts";
            this.ContextMenu_Texts.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenu_Texts.Size = new System.Drawing.Size(161, 204);
            // 
            // MenuItemTextEdit
            // 
            this.MenuItemTextEdit.Name = "MenuItemTextEdit";
            this.MenuItemTextEdit.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextEdit.Text = "Edit";
            this.MenuItemTextEdit.Click += new System.EventHandler(this.MenuItemTextEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // MenuItemTextNew
            // 
            this.MenuItemTextNew.Name = "MenuItemTextNew";
            this.MenuItemTextNew.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextNew.Text = "New";
            this.MenuItemTextNew.Click += new System.EventHandler(this.MenuItemTextNew_Click);
            // 
            // MenuItemTextDelete
            // 
            this.MenuItemTextDelete.Name = "MenuItemTextDelete";
            this.MenuItemTextDelete.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextDelete.Text = "Delete";
            this.MenuItemTextDelete.Click += new System.EventHandler(this.MenuItemTextDelete_Click);
            // 
            // MenuItemTextRename
            // 
            this.MenuItemTextRename.Name = "MenuItemTextRename";
            this.MenuItemTextRename.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextRename.Text = "Rename";
            this.MenuItemTextRename.Click += new System.EventHandler(this.MenuItemTextRename_Click);
            // 
            // MenuItemTextSeparator1
            // 
            this.MenuItemTextSeparator1.Name = "MenuItemTextSeparator1";
            this.MenuItemTextSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // MenuItemTextEditCategories
            // 
            this.MenuItemTextEditCategories.Name = "MenuItemTextEditCategories";
            this.MenuItemTextEditCategories.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextEditCategories.Text = "Set Categories";
            this.MenuItemTextEditCategories.Click += new System.EventHandler(this.SetCategoriesToolStripMenuItem_Click);
            // 
            // MenuItemTextEditGroups
            // 
            this.MenuItemTextEditGroups.Name = "MenuItemTextEditGroups";
            this.MenuItemTextEditGroups.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextEditGroups.Text = "Set Text Group";
            this.MenuItemTextEditGroups.Click += new System.EventHandler(this.MenuItemTextEditGroups_Click);
            // 
            // MenuItemTextSeparator2
            // 
            this.MenuItemTextSeparator2.Name = "MenuItemTextSeparator2";
            this.MenuItemTextSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // MenuItemTextCopyHashCode
            // 
            this.MenuItemTextCopyHashCode.Name = "MenuItemTextCopyHashCode";
            this.MenuItemTextCopyHashCode.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextCopyHashCode.Text = "Copy HashCode";
            this.MenuItemTextCopyHashCode.Click += new System.EventHandler(this.MenuItemTextCopyHashCode_Click);
            // 
            // MenuItemTextSeparator3
            // 
            this.MenuItemTextSeparator3.Name = "MenuItemTextSeparator3";
            this.MenuItemTextSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // MenuItemTextExport
            // 
            this.MenuItemTextExport.Name = "MenuItemTextExport";
            this.MenuItemTextExport.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextExport.Text = "Export List";
            this.MenuItemTextExport.Click += new System.EventHandler(this.MenuItemTextExport_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItem_Help});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(950, 24);
            this.MainMenu.TabIndex = 8;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStrip_OpenProject,
            this.MenuItemStrip_NewProject,
            this.MenuItemStrip_Separator1,
            this.MenuItemProject_RecentProjects,
            this.MenuItemStrip_Separator2,
            this.MenuItemStrip_Exit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MenuItemFile.Text = "File";
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
            // MenuItemProject_RecentProjects
            // 
            this.MenuItemProject_RecentProjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentFilesToolStripMenuItem});
            this.MenuItemProject_RecentProjects.Name = "MenuItemProject_RecentProjects";
            this.MenuItemProject_RecentProjects.Size = new System.Drawing.Size(155, 22);
            this.MenuItemProject_RecentProjects.Text = "Recent Projects";
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
            // MenuItemStrip_Exit
            // 
            this.MenuItemStrip_Exit.Name = "MenuItemStrip_Exit";
            this.MenuItemStrip_Exit.Size = new System.Drawing.Size(155, 22);
            this.MenuItemStrip_Exit.Text = "Exit";
            this.MenuItemStrip_Exit.Click += new System.EventHandler(this.MenuItemStrip_Exit_Click);
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHelp_About});
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(44, 20);
            this.MenuItem_Help.Text = "Help";
            // 
            // MenuItemHelp_About
            // 
            this.MenuItemHelp_About.Name = "MenuItemHelp_About";
            this.MenuItemHelp_About.Size = new System.Drawing.Size(107, 22);
            this.MenuItemHelp_About.Text = "About";
            this.MenuItemHelp_About.Click += new System.EventHandler(this.MenuItemHelp_About_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "EuroText Project (*.etp)|*.etp";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text File|*.txt";
            // 
            // grbxEnableTextPreview
            // 
            this.grbxEnableTextPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxEnableTextPreview.Controls.Add(this.tabControlTextPreview);
            this.grbxEnableTextPreview.Controls.Add(this.chkEnablePreview);
            this.grbxEnableTextPreview.Location = new System.Drawing.Point(485, 461);
            this.grbxEnableTextPreview.Name = "grbxEnableTextPreview";
            this.grbxEnableTextPreview.Size = new System.Drawing.Size(281, 184);
            this.grbxEnableTextPreview.TabIndex = 9;
            this.grbxEnableTextPreview.TabStop = false;
            // 
            // tabControlTextPreview
            // 
            this.tabControlTextPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTextPreview.Location = new System.Drawing.Point(3, 16);
            this.tabControlTextPreview.Name = "tabControlTextPreview";
            this.tabControlTextPreview.SelectedIndex = 0;
            this.tabControlTextPreview.Size = new System.Drawing.Size(275, 165);
            this.tabControlTextPreview.TabIndex = 1;
            // 
            // chkEnablePreview
            // 
            this.chkEnablePreview.AutoSize = true;
            this.chkEnablePreview.Location = new System.Drawing.Point(6, 0);
            this.chkEnablePreview.Name = "chkEnablePreview";
            this.chkEnablePreview.Size = new System.Drawing.Size(119, 17);
            this.chkEnablePreview.TabIndex = 0;
            this.chkEnablePreview.Text = "Enable text preview";
            this.chkEnablePreview.UseVisualStyleBackColor = true;
            this.chkEnablePreview.CheckedChanged += new System.EventHandler(this.ChkEnablePreview_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 647);
            this.Controls.Add(this.grbxEnableTextPreview);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Groupbox_Output);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EuroText 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ContextMenu_Groups.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.Groupbox_Output.ResumeLayout(false);
            this.Groupbox_Output.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ContextMenu_Texts.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.grbxEnableTextPreview.ResumeLayout(false);
            this.grbxEnableTextPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSpreadSheetsExtract;
        private System.Windows.Forms.Button btnUpdateHashTable;
        private System.Windows.Forms.Button btnProjectProperties;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTrimStrings;
        private System.Windows.Forms.Button btnRemoveDoubleSpacing;
        private System.Windows.Forms.Button WordsReplace;
        private System.Windows.Forms.GroupBox Groupbox_Output;
        private System.Windows.Forms.Label Label_OutputName;
        protected internal System.Windows.Forms.TextBox Textbox_FileName;
        protected internal System.Windows.Forms.CheckBox Checkbox_DataInfoSheet;
        protected internal System.Windows.Forms.CheckBox Checkbox_FormatInfo;
        private System.Windows.Forms.Button Button_Output;
        protected internal System.Windows.Forms.CheckBox Checkbox_IncludeHashCodesWithNoSection;
        private System.Windows.Forms.Button btnSetTextSections;
        private System.Windows.Forms.ListBox lboxGroups;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lboxOutSections;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lboxSectionTexts;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Texts;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextEditCategories;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextDelete;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextRename;
        private System.Windows.Forms.ToolStripSeparator MenuItemTextSeparator1;
        private System.Windows.Forms.ToolStripSeparator MenuItemTextSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextCopyHashCode;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Groups;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGroups_New;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGroups_Rename;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGroups_Delete;
        private System.Windows.Forms.Button btnFontBuilder;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_OpenProject;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_NewProject;
        private System.Windows.Forms.ToolStripSeparator MenuItemStrip_Separator1;
        private System.Windows.Forms.ToolStripSeparator MenuItemStrip_Separator2;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        protected internal System.Windows.Forms.ToolStripMenuItem MenuItemProject_RecentProjects;
        protected internal System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp_About;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextEditGroups;
        private System.Windows.Forms.Button btnSectionsInspector;
        private System.Windows.Forms.Button btnImportTextFiles;
        private System.Windows.Forms.Button btnTranslations;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGroups_Refresh;
        private System.Windows.Forms.ToolStripSeparator MenuItemTextSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblTotalGroups;
        private System.Windows.Forms.Label lblTotalOutSections;
        private System.Windows.Forms.Label lblTotalHashCodes;
        private System.Windows.Forms.GroupBox grbxEnableTextPreview;
        private System.Windows.Forms.TabControl tabControlTextPreview;
        private System.Windows.Forms.CheckBox chkEnablePreview;
        private System.Windows.Forms.Button btnProjectCompare;
    }
}

