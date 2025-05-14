
namespace EuroText2
{
    partial class Frm_Fountain
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
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.GroupBox_Duration = new System.Windows.Forms.GroupBox();
            this.CheckBox_MinDuration = new System.Windows.Forms.CheckBox();
            this.Numeric_MinDuration = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBox_MaxDuration = new System.Windows.Forms.CheckBox();
            this.Numeric_MaxDuration = new System.Windows.Forms.NumericUpDown();
            this.GroupBox_Duration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MinDuration)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(282, 136);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 7;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Location = new System.Drawing.Point(201, 136);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 6;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // GroupBox_Duration
            // 
            this.GroupBox_Duration.Controls.Add(this.CheckBox_MinDuration);
            this.GroupBox_Duration.Controls.Add(this.Numeric_MinDuration);
            this.GroupBox_Duration.Location = new System.Drawing.Point(6, 49);
            this.GroupBox_Duration.Name = "GroupBox_Duration";
            this.GroupBox_Duration.Size = new System.Drawing.Size(333, 62);
            this.GroupBox_Duration.TabIndex = 5;
            this.GroupBox_Duration.TabStop = false;
            // 
            // CheckBox_MinDuration
            // 
            this.CheckBox_MinDuration.AutoSize = true;
            this.CheckBox_MinDuration.Location = new System.Drawing.Point(6, 0);
            this.CheckBox_MinDuration.Name = "CheckBox_MinDuration";
            this.CheckBox_MinDuration.Size = new System.Drawing.Size(86, 17);
            this.CheckBox_MinDuration.TabIndex = 6;
            this.CheckBox_MinDuration.Text = "Min Duration";
            this.CheckBox_MinDuration.UseVisualStyleBackColor = true;
            this.CheckBox_MinDuration.CheckStateChanged += new System.EventHandler(this.CheckBox_MinDuration_CheckStateChanged);
            // 
            // Numeric_MinDuration
            // 
            this.Numeric_MinDuration.Enabled = false;
            this.Numeric_MinDuration.Location = new System.Drawing.Point(6, 23);
            this.Numeric_MinDuration.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Numeric_MinDuration.Name = "Numeric_MinDuration";
            this.Numeric_MinDuration.Size = new System.Drawing.Size(138, 20);
            this.Numeric_MinDuration.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CheckBox_MaxDuration);
            this.groupBox1.Controls.Add(this.Numeric_MaxDuration);
            this.groupBox1.Controls.Add(this.GroupBox_Duration);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // CheckBox_MaxDuration
            // 
            this.CheckBox_MaxDuration.AutoSize = true;
            this.CheckBox_MaxDuration.Location = new System.Drawing.Point(6, 0);
            this.CheckBox_MaxDuration.Name = "CheckBox_MaxDuration";
            this.CheckBox_MaxDuration.Size = new System.Drawing.Size(89, 17);
            this.CheckBox_MaxDuration.TabIndex = 1;
            this.CheckBox_MaxDuration.Text = "Max Duration";
            this.CheckBox_MaxDuration.UseVisualStyleBackColor = true;
            this.CheckBox_MaxDuration.CheckedChanged += new System.EventHandler(this.CheckBox_MaxDuration_CheckedChanged);
            // 
            // Numeric_MaxDuration
            // 
            this.Numeric_MaxDuration.Enabled = false;
            this.Numeric_MaxDuration.Location = new System.Drawing.Point(6, 23);
            this.Numeric_MaxDuration.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Numeric_MaxDuration.Name = "Numeric_MaxDuration";
            this.Numeric_MaxDuration.Size = new System.Drawing.Size(138, 20);
            this.Numeric_MaxDuration.TabIndex = 4;
            // 
            // Frm_Fountain
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(369, 171);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Fountain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fountain";
            this.GroupBox_Duration.ResumeLayout(false);
            this.GroupBox_Duration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MinDuration)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_MaxDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.GroupBox GroupBox_Duration;
        private System.Windows.Forms.CheckBox CheckBox_MinDuration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckBox_MaxDuration;
        private System.Windows.Forms.NumericUpDown Numeric_MaxDuration;
        private System.Windows.Forms.NumericUpDown Numeric_MinDuration;
    }
}