namespace EuroText2
{
    partial class Frm_TextEffectAssistant
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Label_Description = new System.Windows.Forms.Label();
            this.CheckBox_Parameter1 = new System.Windows.Forms.CheckBox();
            this.Numeric_Parameter1 = new System.Windows.Forms.NumericUpDown();
            this.CheckBox_Parameter2 = new System.Windows.Forms.CheckBox();
            this.Numeric_Parameter2 = new System.Windows.Forms.NumericUpDown();
            this.CheckBox_Parameter3 = new System.Windows.Forms.CheckBox();
            this.Numeric_Parameter3 = new System.Windows.Forms.NumericUpDown();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Parameter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Parameter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Parameter3)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Description
            // 
            this.Label_Description.Location = new System.Drawing.Point(12, 9);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(360, 35);
            this.Label_Description.TabIndex = 0;
            this.Label_Description.Text = "Effect description";
            // 
            // CheckBox_Parameter1
            // 
            this.CheckBox_Parameter1.AutoSize = true;
            this.CheckBox_Parameter1.Location = new System.Drawing.Point(15, 52);
            this.CheckBox_Parameter1.Name = "CheckBox_Parameter1";
            this.CheckBox_Parameter1.Size = new System.Drawing.Size(80, 17);
            this.CheckBox_Parameter1.TabIndex = 1;
            this.CheckBox_Parameter1.Text = "Parameter:";
            this.CheckBox_Parameter1.UseVisualStyleBackColor = true;
            this.CheckBox_Parameter1.CheckedChanged += new System.EventHandler(this.Parameter_CheckedChanged);
            // 
            // Numeric_Parameter1
            // 
            this.Numeric_Parameter1.Location = new System.Drawing.Point(252, 51);
            this.Numeric_Parameter1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.Numeric_Parameter1.Name = "Numeric_Parameter1";
            this.Numeric_Parameter1.Size = new System.Drawing.Size(120, 20);
            this.Numeric_Parameter1.TabIndex = 2;
            // 
            // CheckBox_Parameter2
            // 
            this.CheckBox_Parameter2.AutoSize = true;
            this.CheckBox_Parameter2.Location = new System.Drawing.Point(15, 78);
            this.CheckBox_Parameter2.Name = "CheckBox_Parameter2";
            this.CheckBox_Parameter2.Size = new System.Drawing.Size(80, 17);
            this.CheckBox_Parameter2.TabIndex = 3;
            this.CheckBox_Parameter2.Text = "Parameter:";
            this.CheckBox_Parameter2.UseVisualStyleBackColor = true;
            this.CheckBox_Parameter2.CheckedChanged += new System.EventHandler(this.Parameter_CheckedChanged);
            // 
            // Numeric_Parameter2
            // 
            this.Numeric_Parameter2.Location = new System.Drawing.Point(252, 77);
            this.Numeric_Parameter2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.Numeric_Parameter2.Name = "Numeric_Parameter2";
            this.Numeric_Parameter2.Size = new System.Drawing.Size(120, 20);
            this.Numeric_Parameter2.TabIndex = 4;
            // 
            // CheckBox_Parameter3
            // 
            this.CheckBox_Parameter3.AutoSize = true;
            this.CheckBox_Parameter3.Location = new System.Drawing.Point(15, 104);
            this.CheckBox_Parameter3.Name = "CheckBox_Parameter3";
            this.CheckBox_Parameter3.Size = new System.Drawing.Size(80, 17);
            this.CheckBox_Parameter3.TabIndex = 5;
            this.CheckBox_Parameter3.Text = "Parameter:";
            this.CheckBox_Parameter3.UseVisualStyleBackColor = true;
            this.CheckBox_Parameter3.CheckedChanged += new System.EventHandler(this.Parameter_CheckedChanged);
            // 
            // Numeric_Parameter3
            // 
            this.Numeric_Parameter3.Location = new System.Drawing.Point(252, 103);
            this.Numeric_Parameter3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.Numeric_Parameter3.Name = "Numeric_Parameter3";
            this.Numeric_Parameter3.Size = new System.Drawing.Size(120, 20);
            this.Numeric_Parameter3.TabIndex = 6;
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(216, 139);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 7;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(297, 139);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 8;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Frm_TextEffectAssistant
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(384, 174);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Numeric_Parameter3);
            this.Controls.Add(this.CheckBox_Parameter3);
            this.Controls.Add(this.Numeric_Parameter2);
            this.Controls.Add(this.CheckBox_Parameter2);
            this.Controls.Add(this.Numeric_Parameter1);
            this.Controls.Add(this.CheckBox_Parameter1);
            this.Controls.Add(this.Label_Description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TextEffectAssistant";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text Effect";
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Parameter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Parameter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Parameter3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.CheckBox CheckBox_Parameter1;
        private System.Windows.Forms.NumericUpDown Numeric_Parameter1;
        private System.Windows.Forms.CheckBox CheckBox_Parameter2;
        private System.Windows.Forms.NumericUpDown Numeric_Parameter2;
        private System.Windows.Forms.CheckBox CheckBox_Parameter3;
        private System.Windows.Forms.NumericUpDown Numeric_Parameter3;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
    }
}
