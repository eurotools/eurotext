
namespace EuroTextEditor
{
    partial class Frm_TextEditor_Multi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TextEditor_Multi));
            this.GroupBox_FilesToBeModified = new System.Windows.Forms.GroupBox();
            this.ListBox_FilesToBeModified = new System.Windows.Forms.ListBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.GroupBox_Settings = new System.Windows.Forms.GroupBox();
            this.Textbox_OutputSections = new System.Windows.Forms.TextBox();
            this.Label_OutputSection = new System.Windows.Forms.Label();
            this.Combobox_Group = new System.Windows.Forms.ComboBox();
            this.Label_TextGroup = new System.Windows.Forms.Label();
            this.CheckBox_TextDead = new System.Windows.Forms.CheckBox();
            this.Numeric_MaxChars = new System.Windows.Forms.NumericUpDown();
            this.Label_MaxNumOfChars = new System.Windows.Forms.Label();
            this.GroupBox_FilesToBeModified.SuspendLayout();
            this.GroupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxChars)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_FilesToBeModified
            // 
            this.GroupBox_FilesToBeModified.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_FilesToBeModified.Controls.Add(this.ListBox_FilesToBeModified);
            this.GroupBox_FilesToBeModified.Location = new System.Drawing.Point(12, 62);
            this.GroupBox_FilesToBeModified.Name = "GroupBox_FilesToBeModified";
            this.GroupBox_FilesToBeModified.Size = new System.Drawing.Size(744, 400);
            this.GroupBox_FilesToBeModified.TabIndex = 1;
            this.GroupBox_FilesToBeModified.TabStop = false;
            this.GroupBox_FilesToBeModified.Text = "Files To Be Modified";
            // 
            // ListBox_FilesToBeModified
            // 
            this.ListBox_FilesToBeModified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_FilesToBeModified.FormattingEnabled = true;
            this.ListBox_FilesToBeModified.Location = new System.Drawing.Point(3, 16);
            this.ListBox_FilesToBeModified.Name = "ListBox_FilesToBeModified";
            this.ListBox_FilesToBeModified.ScrollAlwaysVisible = true;
            this.ListBox_FilesToBeModified.Size = new System.Drawing.Size(738, 381);
            this.ListBox_FilesToBeModified.TabIndex = 0;
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.Location = new System.Drawing.Point(600, 468);
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
            this.Button_Cancel.Location = new System.Drawing.Point(681, 468);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 3;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // GroupBox_Settings
            // 
            this.GroupBox_Settings.Controls.Add(this.Textbox_OutputSections);
            this.GroupBox_Settings.Controls.Add(this.Label_OutputSection);
            this.GroupBox_Settings.Controls.Add(this.Combobox_Group);
            this.GroupBox_Settings.Controls.Add(this.Label_TextGroup);
            this.GroupBox_Settings.Controls.Add(this.CheckBox_TextDead);
            this.GroupBox_Settings.Controls.Add(this.Numeric_MaxChars);
            this.GroupBox_Settings.Controls.Add(this.Label_MaxNumOfChars);
            this.GroupBox_Settings.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Settings.Name = "GroupBox_Settings";
            this.GroupBox_Settings.Size = new System.Drawing.Size(744, 44);
            this.GroupBox_Settings.TabIndex = 9;
            this.GroupBox_Settings.TabStop = false;
            this.GroupBox_Settings.Text = "Settings:";
            // 
            // Textbox_OutputSections
            // 
            this.Textbox_OutputSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_OutputSections.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_OutputSections.Location = new System.Drawing.Point(557, 13);
            this.Textbox_OutputSections.Name = "Textbox_OutputSections";
            this.Textbox_OutputSections.ReadOnly = true;
            this.Textbox_OutputSections.Size = new System.Drawing.Size(181, 20);
            this.Textbox_OutputSections.TabIndex = 7;
            this.Textbox_OutputSections.Click += new System.EventHandler(this.Textbox_OutputSections_Click);
            // 
            // Label_OutputSection
            // 
            this.Label_OutputSection.AutoSize = true;
            this.Label_OutputSection.Location = new System.Drawing.Point(470, 16);
            this.Label_OutputSection.Name = "Label_OutputSection";
            this.Label_OutputSection.Size = new System.Drawing.Size(81, 13);
            this.Label_OutputSection.TabIndex = 5;
            this.Label_OutputSection.Text = "Output Section:";
            // 
            // Combobox_Group
            // 
            this.Combobox_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Group.FormattingEnabled = true;
            this.Combobox_Group.Location = new System.Drawing.Point(315, 13);
            this.Combobox_Group.Name = "Combobox_Group";
            this.Combobox_Group.Size = new System.Drawing.Size(149, 21);
            this.Combobox_Group.TabIndex = 4;
            // 
            // Label_TextGroup
            // 
            this.Label_TextGroup.AutoSize = true;
            this.Label_TextGroup.Location = new System.Drawing.Point(270, 16);
            this.Label_TextGroup.Name = "Label_TextGroup";
            this.Label_TextGroup.Size = new System.Drawing.Size(39, 13);
            this.Label_TextGroup.TabIndex = 3;
            this.Label_TextGroup.Text = "Group:";
            // 
            // CheckBox_TextDead
            // 
            this.CheckBox_TextDead.AutoSize = true;
            this.CheckBox_TextDead.Location = new System.Drawing.Point(182, 15);
            this.CheckBox_TextDead.Name = "CheckBox_TextDead";
            this.CheckBox_TextDead.Size = new System.Drawing.Size(82, 17);
            this.CheckBox_TextDead.TabIndex = 2;
            this.CheckBox_TextDead.Text = "Dead Text?";
            this.CheckBox_TextDead.UseVisualStyleBackColor = true;
            // 
            // Numeric_MaxChars
            // 
            this.Numeric_MaxChars.Location = new System.Drawing.Point(111, 14);
            this.Numeric_MaxChars.Name = "Numeric_MaxChars";
            this.Numeric_MaxChars.Size = new System.Drawing.Size(65, 20);
            this.Numeric_MaxChars.TabIndex = 1;
            // 
            // Label_MaxNumOfChars
            // 
            this.Label_MaxNumOfChars.AutoSize = true;
            this.Label_MaxNumOfChars.Location = new System.Drawing.Point(6, 16);
            this.Label_MaxNumOfChars.Name = "Label_MaxNumOfChars";
            this.Label_MaxNumOfChars.Size = new System.Drawing.Size(99, 13);
            this.Label_MaxNumOfChars.TabIndex = 0;
            this.Label_MaxNumOfChars.Text = "Max Num Of Chars:";
            // 
            // Frm_TextEditor_Multi
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(768, 503);
            this.Controls.Add(this.GroupBox_Settings);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.GroupBox_FilesToBeModified);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_TextEditor_Multi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Multiple HashCodes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_TextEditor_Multi_FormClosing);
            this.Load += new System.EventHandler(this.Frm_TextEditor_Multi_Load);
            this.GroupBox_FilesToBeModified.ResumeLayout(false);
            this.GroupBox_Settings.ResumeLayout(false);
            this.GroupBox_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxChars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_FilesToBeModified;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.ListBox ListBox_FilesToBeModified;
        private System.Windows.Forms.GroupBox GroupBox_Settings;
        protected internal System.Windows.Forms.TextBox Textbox_OutputSections;
        private System.Windows.Forms.Label Label_OutputSection;
        protected internal System.Windows.Forms.ComboBox Combobox_Group;
        private System.Windows.Forms.Label Label_TextGroup;
        protected internal System.Windows.Forms.CheckBox CheckBox_TextDead;
        protected internal System.Windows.Forms.NumericUpDown Numeric_MaxChars;
        private System.Windows.Forms.Label Label_MaxNumOfChars;
    }
}