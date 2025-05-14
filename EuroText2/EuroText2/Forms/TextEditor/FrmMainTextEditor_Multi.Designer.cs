
namespace EuroText2
{
    partial class FrmMainTextEditor_Multi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainTextEditor_Multi));
            this.GroupBox_Settings = new System.Windows.Forms.GroupBox();
            this.Textbox_OutputSections = new System.Windows.Forms.TextBox();
            this.Label_OutputSection = new System.Windows.Forms.Label();
            this.Combobox_Group = new System.Windows.Forms.ComboBox();
            this.Label_TextGroup = new System.Windows.Forms.Label();
            this.CheckBox_TextDead = new System.Windows.Forms.CheckBox();
            this.Numeric_MaxChars = new System.Windows.Forms.NumericUpDown();
            this.Label_MaxNumOfChars = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.GroupBox_FilesToBeModified = new System.Windows.Forms.GroupBox();
            this.ListBox_FilesToBeModified = new System.Windows.Forms.ListBox();
            this.grbxInfo = new System.Windows.Forms.GroupBox();
            this.cbxTone = new System.Windows.Forms.ComboBox();
            this.cbxTextContext = new System.Windows.Forms.ComboBox();
            this.lblContext = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.GroupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxChars)).BeginInit();
            this.GroupBox_FilesToBeModified.SuspendLayout();
            this.grbxInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.GroupBox_Settings.TabIndex = 13;
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
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(681, 468);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 12;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.Location = new System.Drawing.Point(600, 468);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 11;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // GroupBox_FilesToBeModified
            // 
            this.GroupBox_FilesToBeModified.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_FilesToBeModified.Controls.Add(this.ListBox_FilesToBeModified);
            this.GroupBox_FilesToBeModified.Location = new System.Drawing.Point(12, 112);
            this.GroupBox_FilesToBeModified.Name = "GroupBox_FilesToBeModified";
            this.GroupBox_FilesToBeModified.Size = new System.Drawing.Size(742, 350);
            this.GroupBox_FilesToBeModified.TabIndex = 10;
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
            this.ListBox_FilesToBeModified.Size = new System.Drawing.Size(736, 331);
            this.ListBox_FilesToBeModified.TabIndex = 0;
            // 
            // grbxInfo
            // 
            this.grbxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxInfo.Controls.Add(this.cbxTone);
            this.grbxInfo.Controls.Add(this.cbxTextContext);
            this.grbxInfo.Controls.Add(this.lblContext);
            this.grbxInfo.Controls.Add(this.lblGender);
            this.grbxInfo.Controls.Add(this.label1);
            this.grbxInfo.Controls.Add(this.cbxGender);
            this.grbxInfo.Location = new System.Drawing.Point(12, 62);
            this.grbxInfo.Name = "grbxInfo";
            this.grbxInfo.Size = new System.Drawing.Size(744, 44);
            this.grbxInfo.TabIndex = 16;
            this.grbxInfo.TabStop = false;
            this.grbxInfo.Text = "Info:";
            // 
            // cbxTone
            // 
            this.cbxTone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTone.FormattingEnabled = true;
            this.cbxTone.Location = new System.Drawing.Point(548, 14);
            this.cbxTone.Name = "cbxTone";
            this.cbxTone.Size = new System.Drawing.Size(149, 21);
            this.cbxTone.TabIndex = 13;
            // 
            // cbxTextContext
            // 
            this.cbxTextContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTextContext.FormattingEnabled = true;
            this.cbxTextContext.Location = new System.Drawing.Point(58, 14);
            this.cbxTextContext.Name = "cbxTextContext";
            this.cbxTextContext.Size = new System.Drawing.Size(149, 21);
            this.cbxTextContext.TabIndex = 9;
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Location = new System.Drawing.Point(6, 17);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(46, 13);
            this.lblContext.TabIndex = 8;
            this.lblContext.Text = "Context:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(225, 17);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(110, 13);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender / Voice Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tone:";
            // 
            // cbxGender
            // 
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(341, 14);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(149, 21);
            this.cbxGender.TabIndex = 11;
            // 
            // FrmMainTextEditor_Multi
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(768, 503);
            this.Controls.Add(this.grbxInfo);
            this.Controls.Add(this.GroupBox_Settings);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.GroupBox_FilesToBeModified);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMainTextEditor_Multi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Multiple HashCodes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainTextEditor_Multi_FormClosing);
            this.Load += new System.EventHandler(this.FrmMainTextEditor_Multi_Load);
            this.GroupBox_Settings.ResumeLayout(false);
            this.GroupBox_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxChars)).EndInit();
            this.GroupBox_FilesToBeModified.ResumeLayout(false);
            this.grbxInfo.ResumeLayout(false);
            this.grbxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Settings;
        protected internal System.Windows.Forms.TextBox Textbox_OutputSections;
        private System.Windows.Forms.Label Label_OutputSection;
        protected internal System.Windows.Forms.ComboBox Combobox_Group;
        private System.Windows.Forms.Label Label_TextGroup;
        protected internal System.Windows.Forms.CheckBox CheckBox_TextDead;
        protected internal System.Windows.Forms.NumericUpDown Numeric_MaxChars;
        private System.Windows.Forms.Label Label_MaxNumOfChars;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.GroupBox GroupBox_FilesToBeModified;
        private System.Windows.Forms.ListBox ListBox_FilesToBeModified;
        private System.Windows.Forms.GroupBox grbxInfo;
        private System.Windows.Forms.ComboBox cbxTone;
        private System.Windows.Forms.ComboBox cbxTextContext;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGender;
    }
}