
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
            this.ListView_TextStore = new EuroTextEditor.Custom_Controls.ListView_ColumnSortingClick();
            this.Col_HashCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Section = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Audio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_English_US = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_English_UK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_German = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_French = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Spanish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Italian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Korean = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Japan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            "[All]",
            "English US",
            "English UK",
            "German",
            "French",
            "Spanish",
            "Italian",
            "Korean",
            "Japan"});
            this.Combobox_Section.Location = new System.Drawing.Point(76, 12);
            this.Combobox_Section.Name = "Combobox_Section";
            this.Combobox_Section.Size = new System.Drawing.Size(258, 21);
            this.Combobox_Section.TabIndex = 2;
            this.Combobox_Section.SelectionChangeCommitted += new System.EventHandler(this.Combobox_Section_SelectionChangeCommitted);
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
            this.Col_Audio,
            this.Col_English_US,
            this.Col_English_UK,
            this.Col_German,
            this.Col_French,
            this.Col_Spanish,
            this.Col_Italian,
            this.Col_Korean,
            this.Col_Japan});
            this.ListView_TextStore.FullRowSelect = true;
            this.ListView_TextStore.GridLines = true;
            this.ListView_TextStore.HideSelection = false;
            this.ListView_TextStore.Location = new System.Drawing.Point(12, 39);
            this.ListView_TextStore.Name = "ListView_TextStore";
            this.ListView_TextStore.Size = new System.Drawing.Size(1112, 487);
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
            // Col_English_US
            // 
            this.Col_English_US.Text = "English US";
            this.Col_English_US.Width = 150;
            // 
            // Col_English_UK
            // 
            this.Col_English_UK.Text = "English UK";
            this.Col_English_UK.Width = 150;
            // 
            // Col_German
            // 
            this.Col_German.Text = "German";
            this.Col_German.Width = 150;
            // 
            // Col_French
            // 
            this.Col_French.Text = "French";
            this.Col_French.Width = 150;
            // 
            // Col_Spanish
            // 
            this.Col_Spanish.Text = "Spanish";
            this.Col_Spanish.Width = 150;
            // 
            // Col_Italian
            // 
            this.Col_Italian.Text = "Italian";
            this.Col_Italian.Width = 150;
            // 
            // Col_Korean
            // 
            this.Col_Korean.Text = "Korean";
            this.Col_Korean.Width = 150;
            // 
            // Col_Japan
            // 
            this.Col_Japan.Text = "Japan";
            this.Col_Japan.Width = 150;
            // 
            // Frm_TextStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 538);
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
        private System.Windows.Forms.ColumnHeader Col_English_US;
        private System.Windows.Forms.ColumnHeader Col_English_UK;
        private System.Windows.Forms.ColumnHeader Col_German;
        private System.Windows.Forms.ColumnHeader Col_French;
        private System.Windows.Forms.ColumnHeader Col_Spanish;
        private System.Windows.Forms.ColumnHeader Col_Italian;
        private System.Windows.Forms.ColumnHeader Col_Korean;
        private System.Windows.Forms.ColumnHeader Col_Japan;
    }
}