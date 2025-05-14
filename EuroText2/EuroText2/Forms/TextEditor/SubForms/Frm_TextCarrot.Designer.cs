
namespace EuroText2
{
    partial class Frm_TextCarrot
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
            this.GroupBox_Percentage = new System.Windows.Forms.GroupBox();
            this.CheckBox_Variance = new System.Windows.Forms.CheckBox();
            this.Numeric_Percentage = new System.Windows.Forms.NumericUpDown();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.GroupBox_Percentage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Percentage)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_Percentage
            // 
            this.GroupBox_Percentage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Percentage.Controls.Add(this.CheckBox_Variance);
            this.GroupBox_Percentage.Controls.Add(this.Numeric_Percentage);
            this.GroupBox_Percentage.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Percentage.Name = "GroupBox_Percentage";
            this.GroupBox_Percentage.Size = new System.Drawing.Size(345, 115);
            this.GroupBox_Percentage.TabIndex = 2;
            this.GroupBox_Percentage.TabStop = false;
            // 
            // CheckBox_Variance
            // 
            this.CheckBox_Variance.AutoSize = true;
            this.CheckBox_Variance.Location = new System.Drawing.Point(6, 0);
            this.CheckBox_Variance.Name = "CheckBox_Variance";
            this.CheckBox_Variance.Size = new System.Drawing.Size(81, 17);
            this.CheckBox_Variance.TabIndex = 6;
            this.CheckBox_Variance.Text = "Percentage";
            this.CheckBox_Variance.UseVisualStyleBackColor = true;
            this.CheckBox_Variance.CheckStateChanged += new System.EventHandler(this.CheckBox_Variance_CheckStateChanged);
            // 
            // Numeric_Percentage
            // 
            this.Numeric_Percentage.Enabled = false;
            this.Numeric_Percentage.Location = new System.Drawing.Point(6, 23);
            this.Numeric_Percentage.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Numeric_Percentage.Name = "Numeric_Percentage";
            this.Numeric_Percentage.Size = new System.Drawing.Size(138, 20);
            this.Numeric_Percentage.TabIndex = 2;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(282, 136);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 6;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Location = new System.Drawing.Point(201, 136);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 5;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Frm_TextCarrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 171);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.GroupBox_Percentage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TextCarrot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Position Text Carrot";
            this.GroupBox_Percentage.ResumeLayout(false);
            this.GroupBox_Percentage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Percentage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBox_Percentage;
        private System.Windows.Forms.NumericUpDown Numeric_Percentage;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.CheckBox CheckBox_Variance;
    }
}