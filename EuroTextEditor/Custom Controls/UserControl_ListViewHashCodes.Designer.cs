
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
            this.ContextMenu_HashCodes = new System.Windows.Forms.ContextMenu();
            this.MenuItem_Edit = new System.Windows.Forms.MenuItem();
            this.MenuItem_New = new System.Windows.Forms.MenuItem();
            this.MenuItem_Delete = new System.Windows.Forms.MenuItem();
            this.MenuItem_Rename = new System.Windows.Forms.MenuItem();
            this.MenuItem_Separator1 = new System.Windows.Forms.MenuItem();
            this.MenuItem_SetGroup = new System.Windows.Forms.MenuItem();
            this.MenuItem_MultiEditor = new System.Windows.Forms.MenuItem();
            this.MenuItem_Color = new System.Windows.Forms.MenuItem();
            this.MenuItem_RemoveColor = new System.Windows.Forms.MenuItem();
            this.MenuItem_SetColor = new System.Windows.Forms.MenuItem();
            this.MenuItem_EditNote = new System.Windows.Forms.MenuItem();
            this.MenuItem_Separator2 = new System.Windows.Forms.MenuItem();
            this.MenuItem_Refresh = new System.Windows.Forms.MenuItem();
            this.ColorPicker_HashCodes = new System.Windows.Forms.ColorDialog();
            this.ListView_HashCodes = new EuroTextEditor.Custom_Controls.ListView_ColumnSortingClick();
            this.Col_HashCodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_FirstCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_FirstCreatedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_LastModify = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_LastModifyBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Comments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.MenuItem_MultiEditor,
            this.MenuItem_Color,
            this.MenuItem_EditNote,
            this.MenuItem_Separator2,
            this.MenuItem_Refresh});
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
            // MenuItem_MultiEditor
            // 
            this.MenuItem_MultiEditor.Index = 6;
            this.MenuItem_MultiEditor.Text = "Multi Editor";
            this.MenuItem_MultiEditor.Click += new System.EventHandler(this.MenuItem_MultiEditor_Click);
            // 
            // MenuItem_Color
            // 
            this.MenuItem_Color.Index = 7;
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
            this.MenuItem_EditNote.Index = 8;
            this.MenuItem_EditNote.Text = "Edit Note";
            this.MenuItem_EditNote.Click += new System.EventHandler(this.MenuItem_EditNote_Click);
            // 
            // MenuItem_Separator2
            // 
            this.MenuItem_Separator2.Index = 9;
            this.MenuItem_Separator2.Text = "-";
            // 
            // MenuItem_Refresh
            // 
            this.MenuItem_Refresh.Index = 10;
            this.MenuItem_Refresh.Text = "Refresh";
            this.MenuItem_Refresh.Click += new System.EventHandler(this.MenuItem_Refresh_Click);
            // 
            // ListView_HashCodes
            // 
            this.ListView_HashCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_HashCodes,
            this.Col_FirstCreated,
            this.Col_FirstCreatedBy,
            this.Col_LastModify,
            this.Col_LastModifyBy,
            this.Col_Comments});
            this.ListView_HashCodes.ContextMenu = this.ContextMenu_HashCodes;
            this.ListView_HashCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_HashCodes.FullRowSelect = true;
            this.ListView_HashCodes.GridLines = true;
            this.ListView_HashCodes.HideSelection = false;
            this.ListView_HashCodes.Location = new System.Drawing.Point(0, 0);
            this.ListView_HashCodes.Name = "ListView_HashCodes";
            this.ListView_HashCodes.Size = new System.Drawing.Size(897, 519);
            this.ListView_HashCodes.TabIndex = 8;
            this.ListView_HashCodes.UseCompatibleStateImageBehavior = false;
            this.ListView_HashCodes.View = System.Windows.Forms.View.Details;
            this.ListView_HashCodes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_HashCodes_MouseDoubleClick);
            // 
            // Col_HashCodes
            // 
            this.Col_HashCodes.Text = "HashCode";
            this.Col_HashCodes.Width = 200;
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
            // Col_Comments
            // 
            this.Col_Comments.Text = "Notes";
            this.Col_Comments.Width = 250;
            // 
            // UserControl_ListViewHashCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListView_HashCodes);
            this.Name = "UserControl_ListViewHashCodes";
            this.Size = new System.Drawing.Size(897, 519);
            this.ResumeLayout(false);

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
    }
}
