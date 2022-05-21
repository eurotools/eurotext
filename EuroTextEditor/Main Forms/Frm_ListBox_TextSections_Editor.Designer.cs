
namespace EuroTextEditor
{
    partial class Frm_ListBox_TextSections_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListBox_TextSections_Editor));
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.ListView_TextSections = new EuroTextEditor.Custom_Controls.ListViewEx();
            this.Col_TextSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_OutputLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenu_TextSections = new System.Windows.Forms.ContextMenu();
            this.MenuItem_AddNewSection = new System.Windows.Forms.MenuItem();
            this.MenuItem_DeleteTextSection = new System.Windows.Forms.MenuItem();
            this.Label_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.Location = new System.Drawing.Point(265, 442);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(346, 442);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 2;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // ListView_TextSections
            // 
            this.ListView_TextSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_TextSections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_TextSection,
            this.Col_OutputLevel});
            this.ListView_TextSections.ContextMenu = this.ContextMenu_TextSections;
            this.ListView_TextSections.FullRowSelect = true;
            this.ListView_TextSections.GridLines = true;
            this.ListView_TextSections.HideSelection = false;
            this.ListView_TextSections.Location = new System.Drawing.Point(12, 25);
            this.ListView_TextSections.Name = "ListView_TextSections";
            this.ListView_TextSections.Size = new System.Drawing.Size(409, 411);
            this.ListView_TextSections.TabIndex = 3;
            this.ListView_TextSections.UseCompatibleStateImageBehavior = false;
            this.ListView_TextSections.View = System.Windows.Forms.View.Details;
            // 
            // Col_TextSection
            // 
            this.Col_TextSection.Text = "Text Section";
            this.Col_TextSection.Width = 200;
            // 
            // Col_OutputLevel
            // 
            this.Col_OutputLevel.Text = "Output Level";
            this.Col_OutputLevel.Width = 200;
            // 
            // ContextMenu_TextSections
            // 
            this.ContextMenu_TextSections.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_AddNewSection,
            this.MenuItem_DeleteTextSection});
            // 
            // MenuItem_AddNewSection
            // 
            this.MenuItem_AddNewSection.Index = 0;
            this.MenuItem_AddNewSection.Text = "Add New Section";
            this.MenuItem_AddNewSection.Click += new System.EventHandler(this.MenuItem_AddNewSection_Click);
            // 
            // MenuItem_DeleteTextSection
            // 
            this.MenuItem_DeleteTextSection.Index = 1;
            this.MenuItem_DeleteTextSection.Text = "Remove Text Section";
            this.MenuItem_DeleteTextSection.Click += new System.EventHandler(this.MenuItem_DeleteTextSection_Click);
            // 
            // Label_Info
            // 
            this.Label_Info.AutoSize = true;
            this.Label_Info.Location = new System.Drawing.Point(12, 9);
            this.Label_Info.Name = "Label_Info";
            this.Label_Info.Size = new System.Drawing.Size(385, 13);
            this.Label_Info.TabIndex = 4;
            this.Label_Info.Text = "Click on the cells to modify the value, only the output level cells can be modifi" +
    "ed.";
            // 
            // Frm_ListBox_TextSections_Editor
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(433, 477);
            this.Controls.Add(this.Label_Info);
            this.Controls.Add(this.ListView_TextSections);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ListBox_TextSections_Editor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text Sections Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ListBox_TextSections_Editor_FormClosing);
            this.Load += new System.EventHandler(this.Frm_ListBox_TextSections_Editor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
        private Custom_Controls.ListViewEx ListView_TextSections;
        private System.Windows.Forms.ColumnHeader Col_TextSection;
        private System.Windows.Forms.ColumnHeader Col_OutputLevel;
        private System.Windows.Forms.ContextMenu ContextMenu_TextSections;
        private System.Windows.Forms.MenuItem MenuItem_AddNewSection;
        private System.Windows.Forms.MenuItem MenuItem_DeleteTextSection;
        private System.Windows.Forms.Label Label_Info;
    }
}