namespace EuroText2
{
    partial class Frm_DynamicIcon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Label_What = new System.Windows.Forms.Label();
            this.Numeric_What = new System.Windows.Forms.NumericUpDown();
            this.Label_Objective1 = new System.Windows.Forms.Label();
            this.Numeric_Objective1 = new System.Windows.Forms.NumericUpDown();
            this.Label_Objective2 = new System.Windows.Forms.Label();
            this.Numeric_Objective2 = new System.Windows.Forms.NumericUpDown();
            this.CheckBox_Size = new System.Windows.Forms.CheckBox();
            this.Label_Width = new System.Windows.Forms.Label();
            this.Numeric_Width = new System.Windows.Forms.NumericUpDown();
            this.Label_Height = new System.Windows.Forms.Label();
            this.Numeric_Height = new System.Windows.Forms.NumericUpDown();
            this.Label_Help = new System.Windows.Forms.Label();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_What)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Objective1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Objective2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Height)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_What
            // 
            this.Label_What.AutoSize = true;
            this.Label_What.Location = new System.Drawing.Point(12, 15);
            this.Label_What.Name = "Label_What";
            this.Label_What.Size = new System.Drawing.Size(36, 13);
            this.Label_What.TabIndex = 0;
            this.Label_What.Text = "What:";
            // 
            // Numeric_What
            // 
            this.Numeric_What.Location = new System.Drawing.Point(174, 13);
            this.Numeric_What.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            this.Numeric_What.Name = "Numeric_What";
            this.Numeric_What.Size = new System.Drawing.Size(90, 20);
            this.Numeric_What.TabIndex = 1;
            this.Numeric_What.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Label_Objective1
            // 
            this.Label_Objective1.AutoSize = true;
            this.Label_Objective1.Location = new System.Drawing.Point(12, 41);
            this.Label_Objective1.Name = "Label_Objective1";
            this.Label_Objective1.Size = new System.Drawing.Size(151, 13);
            this.Label_Objective1.TabIndex = 2;
            this.Label_Objective1.Text = "Icon hash objective ID (0-9):";
            // 
            // Numeric_Objective1
            // 
            this.Numeric_Objective1.Location = new System.Drawing.Point(174, 39);
            this.Numeric_Objective1.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            this.Numeric_Objective1.Name = "Numeric_Objective1";
            this.Numeric_Objective1.Size = new System.Drawing.Size(90, 20);
            this.Numeric_Objective1.TabIndex = 3;
            // 
            // Label_Objective2
            // 
            this.Label_Objective2.AutoSize = true;
            this.Label_Objective2.Location = new System.Drawing.Point(12, 67);
            this.Label_Objective2.Name = "Label_Objective2";
            this.Label_Objective2.Size = new System.Drawing.Size(147, 13);
            this.Label_Objective2.TabIndex = 4;
            this.Label_Objective2.Text = "File hash objective ID (0-9):";
            // 
            // Numeric_Objective2
            // 
            this.Numeric_Objective2.Location = new System.Drawing.Point(174, 65);
            this.Numeric_Objective2.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            this.Numeric_Objective2.Name = "Numeric_Objective2";
            this.Numeric_Objective2.Size = new System.Drawing.Size(90, 20);
            this.Numeric_Objective2.TabIndex = 5;
            this.Numeric_Objective2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CheckBox_Size
            // 
            this.CheckBox_Size.AutoSize = true;
            this.CheckBox_Size.Location = new System.Drawing.Point(15, 98);
            this.CheckBox_Size.Name = "CheckBox_Size";
            this.CheckBox_Size.Size = new System.Drawing.Size(112, 17);
            this.CheckBox_Size.TabIndex = 6;
            this.CheckBox_Size.Text = "Custom icon size";
            this.CheckBox_Size.UseVisualStyleBackColor = true;
            this.CheckBox_Size.CheckedChanged += new System.EventHandler(this.CheckBox_Size_CheckedChanged);
            // 
            // Label_Width
            // 
            this.Label_Width.AutoSize = true;
            this.Label_Width.Location = new System.Drawing.Point(12, 126);
            this.Label_Width.Name = "Label_Width";
            this.Label_Width.Size = new System.Drawing.Size(38, 13);
            this.Label_Width.TabIndex = 7;
            this.Label_Width.Text = "Width:";
            // 
            // Numeric_Width
            // 
            this.Numeric_Width.Location = new System.Drawing.Point(56, 124);
            this.Numeric_Width.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            this.Numeric_Width.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.Numeric_Width.Name = "Numeric_Width";
            this.Numeric_Width.Size = new System.Drawing.Size(74, 20);
            this.Numeric_Width.TabIndex = 8;
            this.Numeric_Width.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Location = new System.Drawing.Point(143, 126);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(41, 13);
            this.Label_Height.TabIndex = 9;
            this.Label_Height.Text = "Height:";
            // 
            // Numeric_Height
            // 
            this.Numeric_Height.Location = new System.Drawing.Point(190, 124);
            this.Numeric_Height.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            this.Numeric_Height.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.Numeric_Height.Name = "Numeric_Height";
            this.Numeric_Height.Size = new System.Drawing.Size(74, 20);
            this.Numeric_Height.TabIndex = 10;
            this.Numeric_Height.Value = new decimal(new int[] { 32, 0, 0, 0 });
            // 
            // Label_Help
            // 
            this.Label_Help.Location = new System.Drawing.Point(12, 157);
            this.Label_Help.Name = "Label_Help";
            this.Label_Help.Size = new System.Drawing.Size(252, 31);
            this.Label_Help.TabIndex = 11;
            this.Label_Help.Text = "Known format: What 1 inserts an icon using the two objective variables.";
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(108, 199);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 12;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(189, 199);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 13;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Frm_DynamicIcon
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(276, 234);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Label_Help);
            this.Controls.Add(this.Numeric_Height);
            this.Controls.Add(this.Label_Height);
            this.Controls.Add(this.Numeric_Width);
            this.Controls.Add(this.Label_Width);
            this.Controls.Add(this.CheckBox_Size);
            this.Controls.Add(this.Numeric_Objective2);
            this.Controls.Add(this.Label_Objective2);
            this.Controls.Add(this.Numeric_Objective1);
            this.Controls.Add(this.Label_Objective1);
            this.Controls.Add(this.Numeric_What);
            this.Controls.Add(this.Label_What);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DynamicIcon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dynamic Icon";
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_What)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Objective1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Objective2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Label_What;
        private System.Windows.Forms.NumericUpDown Numeric_What;
        private System.Windows.Forms.Label Label_Objective1;
        private System.Windows.Forms.NumericUpDown Numeric_Objective1;
        private System.Windows.Forms.Label Label_Objective2;
        private System.Windows.Forms.NumericUpDown Numeric_Objective2;
        private System.Windows.Forms.CheckBox CheckBox_Size;
        private System.Windows.Forms.Label Label_Width;
        private System.Windows.Forms.NumericUpDown Numeric_Width;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.NumericUpDown Numeric_Height;
        private System.Windows.Forms.Label Label_Help;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
    }
}
