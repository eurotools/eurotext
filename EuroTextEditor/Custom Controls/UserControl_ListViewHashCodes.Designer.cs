
namespace EuroTextEditor.Custom_Controls
{
    partial class UserControl_ListViewHashCodes
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ListViewHashCodes));
            this.ContextMenu_HashCodes = new System.Windows.Forms.ContextMenu();
            this.MenuItem_Edit = new System.Windows.Forms.MenuItem();
            this.MenuItem_New = new System.Windows.Forms.MenuItem();
            this.MenuItem_Delete = new System.Windows.Forms.MenuItem();
            this.MenuItem_Rename = new System.Windows.Forms.MenuItem();
            this.MenuItem_Separator1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_SetGroup = new System.Windows.Forms.MenuItem();
            this.MenuItem_Categories = new System.Windows.Forms.MenuItem();
            this.MenuItem_MultiEditor = new System.Windows.Forms.MenuItem();
            this.MenuItem_Color = new System.Windows.Forms.MenuItem();
            this.MenuItem_RemoveColor = new System.Windows.Forms.MenuItem();
            this.MenuItem_SetColor = new System.Windows.Forms.MenuItem();
            this.MenuItem_EditNote = new System.Windows.Forms.MenuItem();
            this.MenuItem_Separator2 = new System.Windows.Forms.MenuItem();
            this.MenuItem_Refresh = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_CopyHashCode = new System.Windows.Forms.MenuItem();
            this.ColorPicker_HashCodes = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel_TotalItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_SelectedItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolButton_SelectAll = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolButton_SelectNone = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolButton_InvertSelection = new System.Windows.Forms.ToolStripSplitButton();
            this.groupBox_Filters = new System.Windows.Forms.GroupBox();
            this.radioBtnContains = new System.Windows.Forms.RadioButton();
            this.radOnlySpecified = new System.Windows.Forms.RadioButton();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btn_ApplyFilters = new System.Windows.Forms.Button();
            this.txtFilters = new System.Windows.Forms.TextBox();
            this.ListView_HashCodes = new EuroTextEditor.Custom_Controls.ListView_ColumnSortingClick();
            this.Col_HashCodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_FirstCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_FirstCreatedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_LastModify = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_LastModifyBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Categories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Comments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            this.groupBox_Filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenu_HashCodes
            // 
            this.ContextMenu_HashCodes.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_Edit,
            this.MenuItem_New,
            this.MenuItem_Delete,
            this.MenuItem_Rename,
            this.MenuItem_Separator1,
            this.MenuItem_SetGroup,
            this.MenuItem_Categories,
            this.MenuItem_MultiEditor,
            this.MenuItem_Color,
            this.MenuItem_EditNote,
            this.MenuItem_Separator2,
            this.MenuItem_Refresh,
            this.menuItem1,
            this.MenuItem_CopyHashCode});
            // 
            // MenuItem_Edit
            // 
            this.MenuItem_Edit.Index = 0;
            this.MenuItem_Edit.Text = "Edit";
            this.MenuItem_Edit.Click += new System.EventHandler(this.MenuItem_Edit_Click);
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
            this.MenuItem_Delete.Click += new System.EventHandler(this.MenuItem_Delete_Click);
            // 
            // MenuItem_Rename
            // 
            this.MenuItem_Rename.Index = 3;
            this.MenuItem_Rename.Text = "Rename";
            this.MenuItem_Rename.Click += new System.EventHandler(this.MenuItem_Rename_Click);
            // 
            // MenuItem_Separator1
            // 
            this.MenuItem_Separator1.Index = 4;
            this.MenuItem_Separator1.Text = "-";
            // 
            // MenuItem_SetGroup
            // 
            this.MenuItem_SetGroup.Index = 5;
            this.MenuItem_SetGroup.Text = "Set Group";
            this.MenuItem_SetGroup.Visible = false;
            this.MenuItem_SetGroup.Click += new System.EventHandler(this.MenuItem_SetGroup_Click);
            // 
            // MenuItem_Categories
            // 
            this.MenuItem_Categories.Index = 6;
            this.MenuItem_Categories.Text = "Set Categories";
            this.MenuItem_Categories.Click += new System.EventHandler(this.MenuItem_Categories_Click);
            // 
            // MenuItem_MultiEditor
            // 
            this.MenuItem_MultiEditor.Index = 7;
            this.MenuItem_MultiEditor.Text = "Multi Editor";
            this.MenuItem_MultiEditor.Click += new System.EventHandler(this.MenuItem_MultiEditor_Click);
            // 
            // MenuItem_Color
            // 
            this.MenuItem_Color.Index = 8;
            this.MenuItem_Color.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_RemoveColor,
            this.MenuItem_SetColor});
            this.MenuItem_Color.Text = "Color";
            // 
            // MenuItem_RemoveColor
            // 
            this.MenuItem_RemoveColor.Index = 0;
            this.MenuItem_RemoveColor.Text = "Remove";
            this.MenuItem_RemoveColor.Click += new System.EventHandler(this.MenuItem_RemoveColor_Click);
            // 
            // MenuItem_SetColor
            // 
            this.MenuItem_SetColor.Index = 1;
            this.MenuItem_SetColor.Text = "Set Color";
            this.MenuItem_SetColor.Click += new System.EventHandler(this.MenuItem_SetColor_Click);
            // 
            // MenuItem_EditNote
            // 
            this.MenuItem_EditNote.Index = 9;
            this.MenuItem_EditNote.Text = "Edit Note";
            this.MenuItem_EditNote.Click += new System.EventHandler(this.MenuItem_EditNote_Click);
            // 
            // MenuItem_Separator2
            // 
            this.MenuItem_Separator2.Index = 10;
            this.MenuItem_Separator2.Text = "-";
            // 
            // MenuItem_Refresh
            // 
            this.MenuItem_Refresh.Index = 11;
            this.MenuItem_Refresh.Text = "Refresh";
            this.MenuItem_Refresh.Click += new System.EventHandler(this.MenuItem_Refresh_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 12;
            this.menuItem1.Text = "-";
            // 
            // MenuItem_CopyHashCode
            // 
            this.MenuItem_CopyHashCode.Index = 13;
            this.MenuItem_CopyHashCode.Text = "Copy HashCode";
            this.MenuItem_CopyHashCode.Click += new System.EventHandler(this.MenuItem_CopyHashCode_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel_TotalItems,
            this.StatusLabel_SelectedItems,
            this.ToolButton_SelectAll,
            this.ToolButton_SelectNone,
            this.ToolButton_InvertSelection});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel_TotalItems
            // 
            this.StatusLabel_TotalItems.Name = "StatusLabel_TotalItems";
            this.StatusLabel_TotalItems.Size = new System.Drawing.Size(45, 17);
            this.StatusLabel_TotalItems.Text = "0 Items";
            // 
            // StatusLabel_SelectedItems
            // 
            this.StatusLabel_SelectedItems.Name = "StatusLabel_SelectedItems";
            this.StatusLabel_SelectedItems.Size = new System.Drawing.Size(60, 17);
            this.StatusLabel_SelectedItems.Text = "0 Selected";
            // 
            // ToolButton_SelectAll
            // 
            this.ToolButton_SelectAll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolButton_SelectAll.DropDownButtonWidth = 0;
            this.ToolButton_SelectAll.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_SelectAll.Image")));
            this.ToolButton_SelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_SelectAll.Name = "ToolButton_SelectAll";
            this.ToolButton_SelectAll.Size = new System.Drawing.Size(76, 20);
            this.ToolButton_SelectAll.Text = "Select All";
            this.ToolButton_SelectAll.ButtonClick += new System.EventHandler(this.ToolButton_SelectAll_ButtonClick);
            // 
            // ToolButton_SelectNone
            // 
            this.ToolButton_SelectNone.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolButton_SelectNone.DropDownButtonWidth = 0;
            this.ToolButton_SelectNone.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_SelectNone.Image")));
            this.ToolButton_SelectNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_SelectNone.Name = "ToolButton_SelectNone";
            this.ToolButton_SelectNone.Size = new System.Drawing.Size(91, 20);
            this.ToolButton_SelectNone.Text = "Select None";
            this.ToolButton_SelectNone.ButtonClick += new System.EventHandler(this.ToolButton_SelectNone_ButtonClick);
            // 
            // ToolButton_InvertSelection
            // 
            this.ToolButton_InvertSelection.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolButton_InvertSelection.DropDownButtonWidth = 0;
            this.ToolButton_InvertSelection.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_InvertSelection.Image")));
            this.ToolButton_InvertSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_InvertSelection.Name = "ToolButton_InvertSelection";
            this.ToolButton_InvertSelection.Size = new System.Drawing.Size(109, 20);
            this.ToolButton_InvertSelection.Text = "Invert Selection";
            this.ToolButton_InvertSelection.ButtonClick += new System.EventHandler(this.ToolButton_InvertSelection_ButtonClick);
            // 
            // groupBox_Filters
            // 
            this.groupBox_Filters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Filters.Controls.Add(this.radioBtnContains);
            this.groupBox_Filters.Controls.Add(this.radOnlySpecified);
            this.groupBox_Filters.Controls.Add(this.btnShowAll);
            this.groupBox_Filters.Controls.Add(this.btn_ApplyFilters);
            this.groupBox_Filters.Controls.Add(this.txtFilters);
            this.groupBox_Filters.Location = new System.Drawing.Point(3, 427);
            this.groupBox_Filters.Name = "groupBox_Filters";
            this.groupBox_Filters.Size = new System.Drawing.Size(594, 70);
            this.groupBox_Filters.TabIndex = 11;
            this.groupBox_Filters.TabStop = false;
            this.groupBox_Filters.Text = "Filters";
            // 
            // radioBtnContains
            // 
            this.radioBtnContains.AutoSize = true;
            this.radioBtnContains.Checked = true;
            this.radioBtnContains.Location = new System.Drawing.Point(6, 45);
            this.radioBtnContains.Name = "radioBtnContains";
            this.radioBtnContains.Size = new System.Drawing.Size(144, 17);
            this.radioBtnContains.TabIndex = 3;
            this.radioBtnContains.TabStop = true;
            this.radioBtnContains.Text = "Contains Filter Categories";
            this.radioBtnContains.UseVisualStyleBackColor = true;
            this.radioBtnContains.Click += new System.EventHandler(this.RadioBtnContains_Click);
            // 
            // radOnlySpecified
            // 
            this.radOnlySpecified.AutoSize = true;
            this.radOnlySpecified.Location = new System.Drawing.Point(156, 45);
            this.radOnlySpecified.Name = "radOnlySpecified";
            this.radOnlySpecified.Size = new System.Drawing.Size(151, 17);
            this.radOnlySpecified.TabIndex = 4;
            this.radOnlySpecified.Text = "ONLY specified categories";
            this.radOnlySpecified.UseVisualStyleBackColor = true;
            this.radOnlySpecified.Click += new System.EventHandler(this.RadOnlySpecified_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.Location = new System.Drawing.Point(513, 17);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // btn_ApplyFilters
            // 
            this.btn_ApplyFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ApplyFilters.Location = new System.Drawing.Point(432, 17);
            this.btn_ApplyFilters.Name = "btn_ApplyFilters";
            this.btn_ApplyFilters.Size = new System.Drawing.Size(75, 23);
            this.btn_ApplyFilters.TabIndex = 1;
            this.btn_ApplyFilters.Text = "Apply";
            this.btn_ApplyFilters.UseVisualStyleBackColor = true;
            this.btn_ApplyFilters.Click += new System.EventHandler(this.Btn_ApplyFilters_Click);
            // 
            // txtFilters
            // 
            this.txtFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilters.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilters.Location = new System.Drawing.Point(6, 19);
            this.txtFilters.Name = "txtFilters";
            this.txtFilters.ReadOnly = true;
            this.txtFilters.Size = new System.Drawing.Size(420, 20);
            this.txtFilters.TabIndex = 0;
            this.txtFilters.Click += new System.EventHandler(this.TxtFilters_Click);
            // 
            // ListView_HashCodes
            // 
            this.ListView_HashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_HashCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_HashCodes,
            this.Col_FirstCreated,
            this.Col_FirstCreatedBy,
            this.Col_LastModify,
            this.Col_LastModifyBy,
            this.Col_Categories,
            this.Col_Comments});
            this.ListView_HashCodes.ContextMenu = this.ContextMenu_HashCodes;
            this.ListView_HashCodes.FullRowSelect = true;
            this.ListView_HashCodes.GridLines = true;
            this.ListView_HashCodes.HideSelection = false;
            this.ListView_HashCodes.Location = new System.Drawing.Point(0, 0);
            this.ListView_HashCodes.Name = "ListView_HashCodes";
            this.ListView_HashCodes.Size = new System.Drawing.Size(600, 421);
            this.ListView_HashCodes.TabIndex = 8;
            this.ListView_HashCodes.UseCompatibleStateImageBehavior = false;
            this.ListView_HashCodes.View = System.Windows.Forms.View.Details;
            this.ListView_HashCodes.SelectedIndexChanged += new System.EventHandler(this.ListView_HashCodes_SelectedIndexChanged);
            this.ListView_HashCodes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_HashCodes_MouseDoubleClick);
            // 
            // Col_HashCodes
            // 
            this.Col_HashCodes.Text = "HashCode";
            this.Col_HashCodes.Width = 400;
            // 
            // Col_FirstCreated
            // 
            this.Col_FirstCreated.Text = "First Created";
            this.Col_FirstCreated.Width = 120;
            // 
            // Col_FirstCreatedBy
            // 
            this.Col_FirstCreatedBy.Text = "Created By";
            this.Col_FirstCreatedBy.Width = 100;
            // 
            // Col_LastModify
            // 
            this.Col_LastModify.Text = "Last Modify";
            this.Col_LastModify.Width = 120;
            // 
            // Col_LastModifyBy
            // 
            this.Col_LastModifyBy.Text = "Last Modify By";
            this.Col_LastModifyBy.Width = 100;
            // 
            // Col_Categories
            // 
            this.Col_Categories.Text = "Categories";
            this.Col_Categories.Width = 200;
            // 
            // Col_Comments
            // 
            this.Col_Comments.Text = "Notes";
            this.Col_Comments.Width = 250;
            // 
            // UserControl_ListViewHashCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Filters);
            this.Controls.Add(this.ListView_HashCodes);
            this.Controls.Add(this.statusStrip1);
            this.Name = "UserControl_ListViewHashCodes";
            this.Size = new System.Drawing.Size(600, 522);
            this.Load += new System.EventHandler(this.UserControl_ListViewHashCodes_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_Filters.ResumeLayout(false);
            this.groupBox_Filters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal ListView_ColumnSortingClick ListView_HashCodes;
        private System.Windows.Forms.ColumnHeader Col_HashCodes;
        private System.Windows.Forms.ColumnHeader Col_FirstCreated;
        private System.Windows.Forms.ColumnHeader Col_FirstCreatedBy;
        private System.Windows.Forms.ColumnHeader Col_LastModify;
        private System.Windows.Forms.ColumnHeader Col_LastModifyBy;
        protected internal System.Windows.Forms.ColorDialog ColorPicker_HashCodes;
        protected internal System.Windows.Forms.ContextMenu ContextMenu_HashCodes;
        protected internal System.Windows.Forms.MenuItem MenuItem_Edit;
        protected internal System.Windows.Forms.MenuItem MenuItem_New;
        protected internal System.Windows.Forms.MenuItem MenuItem_Delete;
        protected internal System.Windows.Forms.MenuItem MenuItem_Rename;
        protected internal System.Windows.Forms.MenuItem MenuItem_Separator1;
        protected internal System.Windows.Forms.MenuItem MenuItem_SetGroup;
        protected internal System.Windows.Forms.MenuItem MenuItem_MultiEditor;
        protected internal System.Windows.Forms.MenuItem MenuItem_Color;
        protected internal System.Windows.Forms.MenuItem MenuItem_RemoveColor;
        protected internal System.Windows.Forms.MenuItem MenuItem_SetColor;
        protected internal System.Windows.Forms.MenuItem MenuItem_Separator2;
        protected internal System.Windows.Forms.MenuItem MenuItem_Refresh;
        private System.Windows.Forms.ColumnHeader Col_Comments;
        protected internal System.Windows.Forms.MenuItem MenuItem_EditNote;
        private System.Windows.Forms.StatusStrip statusStrip1;
        protected internal System.Windows.Forms.ToolStripStatusLabel StatusLabel_TotalItems;
        protected internal System.Windows.Forms.ToolStripStatusLabel StatusLabel_SelectedItems;
        protected internal System.Windows.Forms.ToolStripSplitButton ToolButton_SelectAll;
        protected internal System.Windows.Forms.ToolStripSplitButton ToolButton_SelectNone;
        protected internal System.Windows.Forms.ToolStripSplitButton ToolButton_InvertSelection;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem MenuItem_CopyHashCode;
        private System.Windows.Forms.MenuItem MenuItem_Categories;
        private System.Windows.Forms.ColumnHeader Col_Categories;
        private System.Windows.Forms.GroupBox groupBox_Filters;
        private System.Windows.Forms.Button btn_ApplyFilters;
        private System.Windows.Forms.Button btnShowAll;
        protected internal System.Windows.Forms.TextBox txtFilters;
        private System.Windows.Forms.RadioButton radioBtnContains;
        private System.Windows.Forms.RadioButton radOnlySpecified;
    }
}
