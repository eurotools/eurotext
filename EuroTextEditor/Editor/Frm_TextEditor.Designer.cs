
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
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxChars)).BeginInit();
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
            this.Button_OK.Location = new System.Drawing.Point(598, 554);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 3;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.Location = new System.Drawing.Point(679, 554);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 4;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // TabControl_Messages
            // 
            this.TabControl_Messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Messages.Location = new System.Drawing.Point(12, 62);
            this.TabControl_Messages.Name = "TabControl_Messages";
            this.TabControl_Messages.SelectedIndex = 0;
            this.TabControl_Messages.Size = new System.Drawing.Size(742, 486);
            this.TabControl_Messages.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "This message has no languages defined";
            // 
            // Frm_TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 589);
            this.Controls.Add(this.TabControl_Messages);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}