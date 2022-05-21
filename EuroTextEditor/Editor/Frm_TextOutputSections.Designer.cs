
namespace EuroTextEditor
{
    partial class Frm_TextOutputSections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TextOutputSections));
            this.GroupBox_OutputSections = new System.Windows.Forms.GroupBox();
            this.ListBox_OutputSections = new System.Windows.Forms.ListBox();
            this.ContextMenu_OutputSections = new System.Windows.Forms.ContextMenu();
            this.MenuItem_DeleteItems = new System.Windows.Forms.MenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_AddSection = new System.Windows.Forms.Button();
            this.ComboBox_AvailableSections = new System.Windows.Forms.ComboBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.GroupBox_OutputSections.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_OutputSections
            // 
            this.GroupBox_OutputSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_OutputSections.Controls.Add(this.ListBox_OutputSections);
            this.GroupBox_OutputSections.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_OutputSections.Name = "GroupBox_OutputSections";
            this.GroupBox_OutputSections.Size = new System.Drawing.Size(271, 344);
            this.GroupBox_OutputSections.TabIndex = 0;
            this.GroupBox_OutputSections.TabStop = false;
            this.GroupBox_OutputSections.Text = "Output_Sections";
            // 
            // ListBox_OutputSections
            // 
            this.ListBox_OutputSections.ContextMenu = this.ContextMenu_OutputSections;
            this.ListBox_OutputSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_OutputSections.FormattingEnabled = true;
            this.ListBox_OutputSections.Location = new System.Drawing.Point(3, 16);
            this.ListBox_OutputSections.Name = "ListBox_OutputSections";
            this.ListBox_OutputSections.Size = new System.Drawing.Size(265, 325);
            this.ListBox_OutputSections.TabIndex = 0;
            // 
            // ContextMenu_OutputSections
            // 
            this.ContextMenu_OutputSections.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_DeleteItems});
            // 
            // MenuItem_DeleteItems
            // 
            this.MenuItem_DeleteItems.Index = 0;
            this.MenuItem_DeleteItems.Text = "Delete";
            this.MenuItem_DeleteItems.Click += new System.EventHandler(this.MenuItem_DeleteItems_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Button_AddSection);
            this.groupBox2.Controls.Add(this.ComboBox_AvailableSections);
            this.groupBox2.Location = new System.Drawing.Point(12, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Sections";
            // 
            // Button_AddSection
            // 
            this.Button_AddSection.Location = new System.Drawing.Point(192, 17);
            this.Button_AddSection.Name = "Button_AddSection";
            this.Button_AddSection.Size = new System.Drawing.Size(75, 23);
            this.Button_AddSection.TabIndex = 1;
            this.Button_AddSection.Text = "Add Section";
            this.Button_AddSection.UseVisualStyleBackColor = true;
            this.Button_AddSection.Click += new System.EventHandler(this.Button_AddSection_Click);
            // 
            // ComboBox_AvailableSections
            // 
            this.ComboBox_AvailableSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_AvailableSections.FormattingEnabled = true;
            this.ComboBox_AvailableSections.Location = new System.Drawing.Point(6, 19);
            this.ComboBox_AvailableSections.Name = "ComboBox_AvailableSections";
            this.ComboBox_AvailableSections.Size = new System.Drawing.Size(180, 21);
            this.ComboBox_AvailableSections.TabIndex = 0;
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Location = new System.Drawing.Point(127, 419);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 2;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(208, 419);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 3;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Frm_TextOutputSections
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(295, 454);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox_OutputSections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TextOutputSections";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Output Sections";
            this.Load += new System.EventHandler(this.Frm_TextOutputSections_Load);
            this.GroupBox_OutputSections.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_OutputSections;
        private System.Windows.Forms.ListBox ListBox_OutputSections;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_AddSection;
        private System.Windows.Forms.ComboBox ComboBox_AvailableSections;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.ContextMenu ContextMenu_OutputSections;
        private System.Windows.Forms.MenuItem MenuItem_DeleteItems;
    }
}