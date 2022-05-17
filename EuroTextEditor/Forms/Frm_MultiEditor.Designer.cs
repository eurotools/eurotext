
namespace EuroTextEditor
{
    partial class Frm_TextStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TextStore));
            this.Label_Language = new System.Windows.Forms.Label();
            this.Combobox_Section = new System.Windows.Forms.ComboBox();
            this.ContextMenu_MultiEditor = new System.Windows.Forms.ContextMenu();
            this.MenuItem_Edit = new System.Windows.Forms.MenuItem();
            this.MenuItem_SetGroup = new System.Windows.Forms.MenuItem();
            this.ListView_TextStore = new EuroTextEditor.Custom_Controls.ListView_ColumnSortingClick();
            this.Col_HashCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Section = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Audio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuItem_SetSection = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // Label_Language
            // 
            this.Label_Language.AutoSize = true;
            this.Label_Language.Location = new System.Drawing.Point(12, 15);
            this.Label_Language.Name = "Label_Language";
            this.Label_Language.Size = new System.Drawing.Size(58, 13);
            this.Label_Language.TabIndex = 1;
            this.Label_Language.Text = "Language:";
            // 
            // Combobox_Section
            // 
            this.Combobox_Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Section.FormattingEnabled = true;
            this.Combobox_Section.Items.AddRange(new object[] {
            "[All]"});
            this.Combobox_Section.Location = new System.Drawing.Point(76, 12);
            this.Combobox_Section.Name = "Combobox_Section";
            this.Combobox_Section.Size = new System.Drawing.Size(258, 21);
            this.Combobox_Section.TabIndex = 2;
            this.Combobox_Section.SelectionChangeCommitted += new System.EventHandler(this.Combobox_Section_SelectionChangeCommitted);
            // 
            // ContextMenu_MultiEditor
            // 
            this.ContextMenu_MultiEditor.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_Edit,
            this.menuItem2,
            this.MenuItem_SetGroup,
            this.MenuItem_SetSection});
            // 
            // MenuItem_Edit
            // 
            this.MenuItem_Edit.Index = 0;
            this.MenuItem_Edit.Text = "Edit";
            this.MenuItem_Edit.Click += new System.EventHandler(this.MenuItem_Edit_Click);
            // 
            // MenuItem_SetGroup
            // 
            this.MenuItem_SetGroup.Index = 2;
            this.MenuItem_SetGroup.Text = "Set Group";
            this.MenuItem_SetGroup.Click += new System.EventHandler(this.MenuItem_SetGroup_Click);
            // 
            // ListView_TextStore
            // 
            this.ListView_TextStore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_TextStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_HashCode,
            this.Col_Section,
            this.Col_Group,
            this.Col_Audio});
            this.ListView_TextStore.ContextMenu = this.ContextMenu_MultiEditor;
            this.ListView_TextStore.FullRowSelect = true;
            this.ListView_TextStore.GridLines = true;
            this.ListView_TextStore.HideSelection = false;
            this.ListView_TextStore.Location = new System.Drawing.Point(12, 39);
            this.ListView_TextStore.Name = "ListView_TextStore";
            this.ListView_TextStore.Size = new System.Drawing.Size(586, 466);
            this.ListView_TextStore.TabIndex = 5;
            this.ListView_TextStore.UseCompatibleStateImageBehavior = false;
            this.ListView_TextStore.View = System.Windows.Forms.View.Details;
            this.ListView_TextStore.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_TextStore_MouseDoubleClick);
            // 
            // Col_HashCode
            // 
            this.Col_HashCode.Text = "HashCode";
            this.Col_HashCode.Width = 120;
            // 
            // Col_Section
            // 
            this.Col_Section.Text = "Section";
            // 
            // Col_Group
            // 
            this.Col_Group.Text = "Group";
            // 
            // Col_Audio
            // 
            this.Col_Audio.Text = "Audio";
            // 
            // MenuItem_SetSection
            // 
            this.MenuItem_SetSection.Index = 3;
            this.MenuItem_SetSection.Text = "Set Section";
            this.MenuItem_SetSection.Click += new System.EventHandler(this.MenuItem_SetSection_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // Frm_TextStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 517);
            this.Controls.Add(this.ListView_TextStore);
            this.Controls.Add(this.Combobox_Section);
            this.Controls.Add(this.Label_Language);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_TextStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EuroText Multi Editor";
            this.Shown += new System.EventHandler(this.Frm_TextStore_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Language;
        private System.Windows.Forms.ComboBox Combobox_Section;
        private Custom_Controls.ListView_ColumnSortingClick ListView_TextStore;
        private System.Windows.Forms.ColumnHeader Col_HashCode;
        private System.Windows.Forms.ColumnHeader Col_Section;
        private System.Windows.Forms.ColumnHeader Col_Group;
        private System.Windows.Forms.ColumnHeader Col_Audio;
        private System.Windows.Forms.ContextMenu ContextMenu_MultiEditor;
        private System.Windows.Forms.MenuItem MenuItem_Edit;
        private System.Windows.Forms.MenuItem MenuItem_SetGroup;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem MenuItem_SetSection;
    }
}