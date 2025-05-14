
namespace EuroText2
{
    partial class FrmTextSections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTextSections));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHashCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemCopySectionName = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCopyHashCodeName = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbxOptions = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.grbxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColSection,
            this.ColHashCode});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(314, 368);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColSection
            // 
            this.ColSection.Text = "Section";
            this.ColSection.Width = 150;
            // 
            // ColHashCode
            // 
            this.ColHashCode.Text = "HashCode";
            this.ColHashCode.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdd,
            this.MenuItemDelete,
            this.MenuItemModify,
            this.MenuItemSeparator1,
            this.MenuItemCopySectionName,
            this.MenuItemCopyHashCodeName});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 120);
            // 
            // MenuItemAdd
            // 
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.Size = new System.Drawing.Size(160, 22);
            this.MenuItemAdd.Text = "Add";
            this.MenuItemAdd.Click += new System.EventHandler(this.MenuItemAdd_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.Size = new System.Drawing.Size(160, 22);
            this.MenuItemDelete.Text = "Delete";
            this.MenuItemDelete.Click += new System.EventHandler(this.MenuItemDelete_Click);
            // 
            // MenuItemModify
            // 
            this.MenuItemModify.Name = "MenuItemModify";
            this.MenuItemModify.Size = new System.Drawing.Size(160, 22);
            this.MenuItemModify.Text = "Modify";
            this.MenuItemModify.Click += new System.EventHandler(this.MenuItemModify_Click);
            // 
            // MenuItemSeparator1
            // 
            this.MenuItemSeparator1.Name = "MenuItemSeparator1";
            this.MenuItemSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // MenuItemCopySectionName
            // 
            this.MenuItemCopySectionName.Name = "MenuItemCopySectionName";
            this.MenuItemCopySectionName.Size = new System.Drawing.Size(160, 22);
            this.MenuItemCopySectionName.Text = "Copy Name";
            this.MenuItemCopySectionName.Click += new System.EventHandler(this.MenuItemCopySectionName_Click);
            // 
            // MenuItemCopyHashCodeName
            // 
            this.MenuItemCopyHashCodeName.Name = "MenuItemCopyHashCodeName";
            this.MenuItemCopyHashCodeName.Size = new System.Drawing.Size(160, 22);
            this.MenuItemCopyHashCodeName.Text = "Copy HashCode";
            this.MenuItemCopyHashCodeName.Click += new System.EventHandler(this.MenuItemCopyHashCodeName_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(273, 386);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(354, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // grbxOptions
            // 
            this.grbxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxOptions.Controls.Add(this.btnModify);
            this.grbxOptions.Controls.Add(this.btnDelete);
            this.grbxOptions.Controls.Add(this.btnAddSection);
            this.grbxOptions.Location = new System.Drawing.Point(332, 12);
            this.grbxOptions.Name = "grbxOptions";
            this.grbxOptions.Size = new System.Drawing.Size(97, 116);
            this.grbxOptions.TabIndex = 3;
            this.grbxOptions.TabStop = false;
            this.grbxOptions.Text = "Options";
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Location = new System.Drawing.Point(6, 77);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(85, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify...";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(6, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAddSection
            // 
            this.btnAddSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSection.Location = new System.Drawing.Point(6, 19);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(85, 23);
            this.btnAddSection.TabIndex = 0;
            this.btnAddSection.Text = "Add";
            this.btnAddSection.UseVisualStyleBackColor = true;
            this.btnAddSection.Click += new System.EventHandler(this.BtnAddSection_Click);
            // 
            // FrmTextSections
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(441, 421);
            this.Controls.Add(this.grbxOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTextSections";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dialogs Sections";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTextSections_FormClosing);
            this.Load += new System.EventHandler(this.FrmTextSections_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grbxOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbxOptions;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.ColumnHeader ColSection;
        private System.Windows.Forms.ColumnHeader ColHashCode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem MenuItemModify;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCopySectionName;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCopyHashCodeName;
    }
}