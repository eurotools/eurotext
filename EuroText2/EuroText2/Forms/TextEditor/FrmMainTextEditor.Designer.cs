
namespace EuroText2
{
    partial class FrmMainTextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainTextEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemStrip_ResetSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemStrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Windows = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox_Settings = new System.Windows.Forms.GroupBox();
            this.cbxTone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbxTextContext = new System.Windows.Forms.ComboBox();
            this.lblContext = new System.Windows.Forms.Label();
            this.Textbox_OutputSections = new System.Windows.Forms.TextBox();
            this.Label_OutputSection = new System.Windows.Forms.Label();
            this.Combobox_Group = new System.Windows.Forms.ComboBox();
            this.Label_TextGroup = new System.Windows.Forms.Label();
            this.CheckBox_TextDead = new System.Windows.Forms.CheckBox();
            this.Numeric_MaxChars = new System.Windows.Forms.NumericUpDown();
            this.Label_MaxNumOfChars = new System.Windows.Forms.Label();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.grbxInfo = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.GroupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxChars)).BeginInit();
            this.grbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStrip_File,
            this.MenuItemStrip_Windows});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemStrip_File
            // 
            this.MenuItemStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStrip_Save,
            this.MenuItemStrip_Separator1,
            this.MenuItemStrip_ResetSettings,
            this.MenuItemStrip_Separator2,
            this.MenuItemStrip_Exit});
            this.MenuItemStrip_File.Name = "MenuItemStrip_File";
            this.MenuItemStrip_File.Size = new System.Drawing.Size(37, 20);
            this.MenuItemStrip_File.Text = "File";
            // 
            // MenuItemStrip_Save
            // 
            this.MenuItemStrip_Save.Name = "MenuItemStrip_Save";
            this.MenuItemStrip_Save.Size = new System.Drawing.Size(147, 22);
            this.MenuItemStrip_Save.Text = "Save";
            this.MenuItemStrip_Save.Click += new System.EventHandler(this.MenuItemStrip_Save_Click);
            // 
            // MenuItemStrip_Separator1
            // 
            this.MenuItemStrip_Separator1.Name = "MenuItemStrip_Separator1";
            this.MenuItemStrip_Separator1.Size = new System.Drawing.Size(144, 6);
            // 
            // MenuItemStrip_ResetSettings
            // 
            this.MenuItemStrip_ResetSettings.Name = "MenuItemStrip_ResetSettings";
            this.MenuItemStrip_ResetSettings.Size = new System.Drawing.Size(147, 22);
            this.MenuItemStrip_ResetSettings.Text = "Reset Settings";
            this.MenuItemStrip_ResetSettings.Click += new System.EventHandler(this.MenuItemStrip_ResetSettings_Click);
            // 
            // MenuItemStrip_Separator2
            // 
            this.MenuItemStrip_Separator2.Name = "MenuItemStrip_Separator2";
            this.MenuItemStrip_Separator2.Size = new System.Drawing.Size(144, 6);
            // 
            // MenuItemStrip_Exit
            // 
            this.MenuItemStrip_Exit.Name = "MenuItemStrip_Exit";
            this.MenuItemStrip_Exit.Size = new System.Drawing.Size(147, 22);
            this.MenuItemStrip_Exit.Text = "Exit";
            this.MenuItemStrip_Exit.Click += new System.EventHandler(this.MenuItemStrip_Exit_Click);
            // 
            // MenuItemStrip_Windows
            // 
            this.MenuItemStrip_Windows.Name = "MenuItemStrip_Windows";
            this.MenuItemStrip_Windows.Size = new System.Drawing.Size(68, 20);
            this.MenuItemStrip_Windows.Text = "Windows";
            this.MenuItemStrip_Windows.DropDownOpening += new System.EventHandler(this.MenuItemStrip_Windows_DropDownOpening);
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
            this.GroupBox_Settings.Location = new System.Drawing.Point(12, 27);
            this.GroupBox_Settings.Name = "GroupBox_Settings";
            this.GroupBox_Settings.Size = new System.Drawing.Size(746, 43);
            this.GroupBox_Settings.TabIndex = 9;
            this.GroupBox_Settings.TabStop = false;
            this.GroupBox_Settings.Text = "Settings:";
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
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(225, 17);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(110, 13);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender / Voice Type:";
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
            // Textbox_OutputSections
            // 
            this.Textbox_OutputSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_OutputSections.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_OutputSections.Location = new System.Drawing.Point(557, 13);
            this.Textbox_OutputSections.Name = "Textbox_OutputSections";
            this.Textbox_OutputSections.ReadOnly = true;
            this.Textbox_OutputSections.Size = new System.Drawing.Size(183, 20);
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
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(12, 125);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(746, 382);
            this.dockPanel.TabIndex = 11;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.Location = new System.Drawing.Point(683, 513);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 13;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Location = new System.Drawing.Point(602, 513);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 12;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
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
            this.grbxInfo.Location = new System.Drawing.Point(12, 76);
            this.grbxInfo.Name = "grbxInfo";
            this.grbxInfo.Size = new System.Drawing.Size(746, 43);
            this.grbxInfo.TabIndex = 15;
            this.grbxInfo.TabStop = false;
            this.grbxInfo.Text = "Info:";
            // 
            // FrmMainTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 548);
            this.Controls.Add(this.grbxInfo);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.GroupBox_Settings);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Messages Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainTextEditor_FormClosing);
            this.Load += new System.EventHandler(this.FrmMainTextEditor_Load);
            this.Shown += new System.EventHandler(this.FrmMainTextEditor_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBox_Settings.ResumeLayout(false);
            this.GroupBox_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxChars)).EndInit();
            this.grbxInfo.ResumeLayout(false);
            this.grbxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_Save;
        private System.Windows.Forms.ToolStripSeparator MenuItemStrip_Separator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_ResetSettings;
        private System.Windows.Forms.ToolStripSeparator MenuItemStrip_Separator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_Windows;
        private System.Windows.Forms.GroupBox GroupBox_Settings;
        protected internal System.Windows.Forms.TextBox Textbox_OutputSections;
        private System.Windows.Forms.Label Label_OutputSection;
        protected internal System.Windows.Forms.ComboBox Combobox_Group;
        private System.Windows.Forms.Label Label_TextGroup;
        protected internal System.Windows.Forms.CheckBox CheckBox_TextDead;
        protected internal System.Windows.Forms.NumericUpDown Numeric_MaxChars;
        private System.Windows.Forms.Label Label_MaxNumOfChars;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.ComboBox cbxTextContext;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbxTone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbxInfo;
    }
}