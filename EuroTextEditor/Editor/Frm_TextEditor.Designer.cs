
namespace EuroTextEditor
{
    partial class Frm_TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TextEditor));
            this.GroupBox_Settings = new System.Windows.Forms.GroupBox();
            this.Combobox_OutputSection = new System.Windows.Forms.ComboBox();
            this.Label_OutputSection = new System.Windows.Forms.Label();
            this.Combobox_Group = new System.Windows.Forms.ComboBox();
            this.Label_TextGroup = new System.Windows.Forms.Label();
            this.CheckBox_TextDead = new System.Windows.Forms.CheckBox();
            this.Numeric_MaxChars = new System.Windows.Forms.NumericUpDown();
            this.Label_MaxNumOfChars = new System.Windows.Forms.Label();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.TabControl_Messages = new System.Windows.Forms.TabControl();
            this.TabPage_EnglishUS = new System.Windows.Forms.TabPage();
            this.Textbox_EnglishUS = new EuroTextEditor.UserControl_TextEditor();
            this.TabPage_EnglishUK = new System.Windows.Forms.TabPage();
            this.Textbox_EnglishUK = new EuroTextEditor.UserControl_TextEditor();
            this.TabPage_German = new System.Windows.Forms.TabPage();
            this.Textbox_German = new EuroTextEditor.UserControl_TextEditor();
            this.TabPage_French = new System.Windows.Forms.TabPage();
            this.Textbox_French = new EuroTextEditor.UserControl_TextEditor();
            this.TabPage_Spanish = new System.Windows.Forms.TabPage();
            this.Textbox_Spanish = new EuroTextEditor.UserControl_TextEditor();
            this.TabPage_Italian = new System.Windows.Forms.TabPage();
            this.Textbox_Italian = new EuroTextEditor.UserControl_TextEditor();
            this.TabPage_Korean = new System.Windows.Forms.TabPage();
            this.Textbox_Korean = new EuroTextEditor.UserControl_TextEditor();
            this.TabPage_Japan = new System.Windows.Forms.TabPage();
            this.Textbox_Japan = new EuroTextEditor.UserControl_TextEditor();
            this.GroupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxChars)).BeginInit();
            this.TabControl_Messages.SuspendLayout();
            this.TabPage_EnglishUS.SuspendLayout();
            this.TabPage_EnglishUK.SuspendLayout();
            this.TabPage_German.SuspendLayout();
            this.TabPage_French.SuspendLayout();
            this.TabPage_Spanish.SuspendLayout();
            this.TabPage_Italian.SuspendLayout();
            this.TabPage_Korean.SuspendLayout();
            this.TabPage_Japan.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Settings
            // 
            this.GroupBox_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Settings.Controls.Add(this.Combobox_OutputSection);
            this.GroupBox_Settings.Controls.Add(this.Label_OutputSection);
            this.GroupBox_Settings.Controls.Add(this.Combobox_Group);
            this.GroupBox_Settings.Controls.Add(this.Label_TextGroup);
            this.GroupBox_Settings.Controls.Add(this.CheckBox_TextDead);
            this.GroupBox_Settings.Controls.Add(this.Numeric_MaxChars);
            this.GroupBox_Settings.Controls.Add(this.Label_MaxNumOfChars);
            this.GroupBox_Settings.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Settings.Name = "GroupBox_Settings";
            this.GroupBox_Settings.Size = new System.Drawing.Size(742, 44);
            this.GroupBox_Settings.TabIndex = 0;
            this.GroupBox_Settings.TabStop = false;
            this.GroupBox_Settings.Text = "Settings:";
            // 
            // Combobox_OutputSection
            // 
            this.Combobox_OutputSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_OutputSection.FormattingEnabled = true;
            this.Combobox_OutputSection.Items.AddRange(new object[] {
            ""});
            this.Combobox_OutputSection.Location = new System.Drawing.Point(557, 13);
            this.Combobox_OutputSection.Name = "Combobox_OutputSection";
            this.Combobox_OutputSection.Size = new System.Drawing.Size(179, 21);
            this.Combobox_OutputSection.TabIndex = 6;
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
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Location = new System.Drawing.Point(598, 503);
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
            this.Button_Cancel.Location = new System.Drawing.Point(679, 503);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 3;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // TabControl_Messages
            // 
            this.TabControl_Messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Messages.Controls.Add(this.TabPage_EnglishUS);
            this.TabControl_Messages.Controls.Add(this.TabPage_EnglishUK);
            this.TabControl_Messages.Controls.Add(this.TabPage_German);
            this.TabControl_Messages.Controls.Add(this.TabPage_French);
            this.TabControl_Messages.Controls.Add(this.TabPage_Spanish);
            this.TabControl_Messages.Controls.Add(this.TabPage_Italian);
            this.TabControl_Messages.Controls.Add(this.TabPage_Korean);
            this.TabControl_Messages.Controls.Add(this.TabPage_Japan);
            this.TabControl_Messages.Location = new System.Drawing.Point(12, 62);
            this.TabControl_Messages.Name = "TabControl_Messages";
            this.TabControl_Messages.SelectedIndex = 0;
            this.TabControl_Messages.Size = new System.Drawing.Size(742, 435);
            this.TabControl_Messages.TabIndex = 1;
            // 
            // TabPage_EnglishUS
            // 
            this.TabPage_EnglishUS.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_EnglishUS.Controls.Add(this.Textbox_EnglishUS);
            this.TabPage_EnglishUS.Location = new System.Drawing.Point(4, 22);
            this.TabPage_EnglishUS.Name = "TabPage_EnglishUS";
            this.TabPage_EnglishUS.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_EnglishUS.Size = new System.Drawing.Size(734, 409);
            this.TabPage_EnglishUS.TabIndex = 0;
            this.TabPage_EnglishUS.Text = "English US";
            // 
            // Textbox_EnglishUS
            // 
            this.Textbox_EnglishUS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox_EnglishUS.Location = new System.Drawing.Point(3, 3);
            this.Textbox_EnglishUS.Name = "Textbox_EnglishUS";
            this.Textbox_EnglishUS.Size = new System.Drawing.Size(728, 403);
            this.Textbox_EnglishUS.TabIndex = 0;
            // 
            // TabPage_EnglishUK
            // 
            this.TabPage_EnglishUK.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_EnglishUK.Controls.Add(this.Textbox_EnglishUK);
            this.TabPage_EnglishUK.Location = new System.Drawing.Point(4, 22);
            this.TabPage_EnglishUK.Name = "TabPage_EnglishUK";
            this.TabPage_EnglishUK.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_EnglishUK.Size = new System.Drawing.Size(734, 409);
            this.TabPage_EnglishUK.TabIndex = 1;
            this.TabPage_EnglishUK.Text = "English UK";
            // 
            // Textbox_EnglishUK
            // 
            this.Textbox_EnglishUK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox_EnglishUK.Location = new System.Drawing.Point(3, 3);
            this.Textbox_EnglishUK.Name = "Textbox_EnglishUK";
            this.Textbox_EnglishUK.Size = new System.Drawing.Size(728, 403);
            this.Textbox_EnglishUK.TabIndex = 1;
            // 
            // TabPage_German
            // 
            this.TabPage_German.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_German.Controls.Add(this.Textbox_German);
            this.TabPage_German.Location = new System.Drawing.Point(4, 22);
            this.TabPage_German.Name = "TabPage_German";
            this.TabPage_German.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_German.Size = new System.Drawing.Size(734, 409);
            this.TabPage_German.TabIndex = 2;
            this.TabPage_German.Text = "German";
            // 
            // Textbox_German
            // 
            this.Textbox_German.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox_German.Location = new System.Drawing.Point(3, 3);
            this.Textbox_German.Name = "Textbox_German";
            this.Textbox_German.Size = new System.Drawing.Size(728, 403);
            this.Textbox_German.TabIndex = 2;
            // 
            // TabPage_French
            // 
            this.TabPage_French.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_French.Controls.Add(this.Textbox_French);
            this.TabPage_French.Location = new System.Drawing.Point(4, 22);
            this.TabPage_French.Name = "TabPage_French";
            this.TabPage_French.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_French.Size = new System.Drawing.Size(734, 409);
            this.TabPage_French.TabIndex = 3;
            this.TabPage_French.Text = "French";
            // 
            // Textbox_French
            // 
            this.Textbox_French.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox_French.Location = new System.Drawing.Point(3, 3);
            this.Textbox_French.Name = "Textbox_French";
            this.Textbox_French.Size = new System.Drawing.Size(728, 403);
            this.Textbox_French.TabIndex = 2;
            // 
            // TabPage_Spanish
            // 
            this.TabPage_Spanish.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_Spanish.Controls.Add(this.Textbox_Spanish);
            this.TabPage_Spanish.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Spanish.Name = "TabPage_Spanish";
            this.TabPage_Spanish.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Spanish.Size = new System.Drawing.Size(734, 409);
            this.TabPage_Spanish.TabIndex = 4;
            this.TabPage_Spanish.Text = "Spanish";
            // 
            // Textbox_Spanish
            // 
            this.Textbox_Spanish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox_Spanish.Location = new System.Drawing.Point(3, 3);
            this.Textbox_Spanish.Name = "Textbox_Spanish";
            this.Textbox_Spanish.Size = new System.Drawing.Size(728, 403);
            this.Textbox_Spanish.TabIndex = 2;
            // 
            // TabPage_Italian
            // 
            this.TabPage_Italian.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_Italian.Controls.Add(this.Textbox_Italian);
            this.TabPage_Italian.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Italian.Name = "TabPage_Italian";
            this.TabPage_Italian.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Italian.Size = new System.Drawing.Size(734, 409);
            this.TabPage_Italian.TabIndex = 5;
            this.TabPage_Italian.Text = "Italian";
            // 
            // Textbox_Italian
            // 
            this.Textbox_Italian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox_Italian.Location = new System.Drawing.Point(3, 3);
            this.Textbox_Italian.Name = "Textbox_Italian";
            this.Textbox_Italian.Size = new System.Drawing.Size(728, 403);
            this.Textbox_Italian.TabIndex = 2;
            // 
            // TabPage_Korean
            // 
            this.TabPage_Korean.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_Korean.Controls.Add(this.Textbox_Korean);
            this.TabPage_Korean.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Korean.Name = "TabPage_Korean";
            this.TabPage_Korean.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Korean.Size = new System.Drawing.Size(734, 409);
            this.TabPage_Korean.TabIndex = 6;
            this.TabPage_Korean.Text = "Korean";
            // 
            // Textbox_Korean
            // 
            this.Textbox_Korean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox_Korean.Location = new System.Drawing.Point(3, 3);
            this.Textbox_Korean.Name = "Textbox_Korean";
            this.Textbox_Korean.Size = new System.Drawing.Size(728, 403);
            this.Textbox_Korean.TabIndex = 2;
            // 
            // TabPage_Japan
            // 
            this.TabPage_Japan.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_Japan.Controls.Add(this.Textbox_Japan);
            this.TabPage_Japan.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Japan.Name = "TabPage_Japan";
            this.TabPage_Japan.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Japan.Size = new System.Drawing.Size(734, 409);
            this.TabPage_Japan.TabIndex = 7;
            this.TabPage_Japan.Text = "Japan";
            // 
            // Textbox_Japan
            // 
            this.Textbox_Japan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox_Japan.Location = new System.Drawing.Point(3, 3);
            this.Textbox_Japan.Name = "Textbox_Japan";
            this.Textbox_Japan.Size = new System.Drawing.Size(728, 403);
            this.Textbox_Japan.TabIndex = 2;
            // 
            // Frm_TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 538);
            this.Controls.Add(this.TabControl_Messages);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.GroupBox_Settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TextEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Messages Editor";
            this.Load += new System.EventHandler(this.Frm_TextEditor_Load);
            this.GroupBox_Settings.ResumeLayout(false);
            this.GroupBox_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxChars)).EndInit();
            this.TabControl_Messages.ResumeLayout(false);
            this.TabPage_EnglishUS.ResumeLayout(false);
            this.TabPage_EnglishUK.ResumeLayout(false);
            this.TabPage_German.ResumeLayout(false);
            this.TabPage_French.ResumeLayout(false);
            this.TabPage_Spanish.ResumeLayout(false);
            this.TabPage_Italian.ResumeLayout(false);
            this.TabPage_Korean.ResumeLayout(false);
            this.TabPage_Japan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBox_Settings;
        private System.Windows.Forms.ComboBox Combobox_OutputSection;
        private System.Windows.Forms.Label Label_OutputSection;
        private System.Windows.Forms.ComboBox Combobox_Group;
        private System.Windows.Forms.Label Label_TextGroup;
        private System.Windows.Forms.CheckBox CheckBox_TextDead;
        private System.Windows.Forms.NumericUpDown Numeric_MaxChars;
        private System.Windows.Forms.Label Label_MaxNumOfChars;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.TabControl TabControl_Messages;
        private System.Windows.Forms.TabPage TabPage_EnglishUS;
        private System.Windows.Forms.TabPage TabPage_EnglishUK;
        private UserControl_TextEditor Textbox_EnglishUS;
        private UserControl_TextEditor Textbox_EnglishUK;
        private System.Windows.Forms.TabPage TabPage_German;
        private UserControl_TextEditor Textbox_German;
        private System.Windows.Forms.TabPage TabPage_French;
        private UserControl_TextEditor Textbox_French;
        private System.Windows.Forms.TabPage TabPage_Spanish;
        private UserControl_TextEditor Textbox_Spanish;
        private System.Windows.Forms.TabPage TabPage_Italian;
        private UserControl_TextEditor Textbox_Italian;
        private System.Windows.Forms.TabPage TabPage_Korean;
        private UserControl_TextEditor Textbox_Korean;
        private System.Windows.Forms.TabPage TabPage_Japan;
        private UserControl_TextEditor Textbox_Japan;
    }
}