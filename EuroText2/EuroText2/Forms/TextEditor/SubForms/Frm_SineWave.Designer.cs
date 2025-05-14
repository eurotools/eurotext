
namespace EuroText2
{
    partial class Frm_SineWave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SineWave));
            this.CheckBox_Amplitude = new System.Windows.Forms.CheckBox();
            this.GroupBox_Duration = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBox_Frequency = new System.Windows.Forms.CheckBox();
            this.Numeric_Frequency = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Amplitude = new System.Windows.Forms.NumericUpDown();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.GroupBox_Duration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amplitude)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBox_Amplitude
            // 
            this.CheckBox_Amplitude.AutoSize = true;
            this.CheckBox_Amplitude.Location = new System.Drawing.Point(6, 0);
            this.CheckBox_Amplitude.Name = "CheckBox_Amplitude";
            this.CheckBox_Amplitude.Size = new System.Drawing.Size(72, 17);
            this.CheckBox_Amplitude.TabIndex = 6;
            this.CheckBox_Amplitude.Text = "Amplitude";
            this.CheckBox_Amplitude.UseVisualStyleBackColor = true;
            this.CheckBox_Amplitude.CheckStateChanged += new System.EventHandler(this.CheckBox_Amplitude_CheckStateChanged);
            // 
            // GroupBox_Duration
            // 
            this.GroupBox_Duration.Controls.Add(this.CheckBox_Amplitude);
            this.GroupBox_Duration.Controls.Add(this.groupBox1);
            this.GroupBox_Duration.Controls.Add(this.Numeric_Amplitude);
            this.GroupBox_Duration.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Duration.Name = "GroupBox_Duration";
            this.GroupBox_Duration.Size = new System.Drawing.Size(345, 114);
            this.GroupBox_Duration.TabIndex = 1;
            this.GroupBox_Duration.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CheckBox_Frequency);
            this.groupBox1.Controls.Add(this.Numeric_Frequency);
            this.groupBox1.Location = new System.Drawing.Point(6, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // CheckBox_Frequency
            // 
            this.CheckBox_Frequency.AutoSize = true;
            this.CheckBox_Frequency.Location = new System.Drawing.Point(6, 0);
            this.CheckBox_Frequency.Name = "CheckBox_Frequency";
            this.CheckBox_Frequency.Size = new System.Drawing.Size(76, 17);
            this.CheckBox_Frequency.TabIndex = 1;
            this.CheckBox_Frequency.Text = "Frequency";
            this.CheckBox_Frequency.UseVisualStyleBackColor = true;
            this.CheckBox_Frequency.CheckedChanged += new System.EventHandler(this.CheckBox_Frequency_CheckedChanged);
            // 
            // Numeric_Frequency
            // 
            this.Numeric_Frequency.Enabled = false;
            this.Numeric_Frequency.Location = new System.Drawing.Point(6, 23);
            this.Numeric_Frequency.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Numeric_Frequency.Name = "Numeric_Frequency";
            this.Numeric_Frequency.Size = new System.Drawing.Size(138, 20);
            this.Numeric_Frequency.TabIndex = 4;
            // 
            // Numeric_Amplitude
            // 
            this.Numeric_Amplitude.Enabled = false;
            this.Numeric_Amplitude.Location = new System.Drawing.Point(6, 23);
            this.Numeric_Amplitude.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Numeric_Amplitude.Name = "Numeric_Amplitude";
            this.Numeric_Amplitude.Size = new System.Drawing.Size(138, 20);
            this.Numeric_Amplitude.TabIndex = 2;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(282, 136);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 4;
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
            this.Button_OK.TabIndex = 3;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Frm_SineWave
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(369, 171);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.GroupBox_Duration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SineWave";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sine Wave";
            this.GroupBox_Duration.ResumeLayout(false);
            this.GroupBox_Duration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Amplitude)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_Amplitude;
        private System.Windows.Forms.GroupBox GroupBox_Duration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckBox_Frequency;
        private System.Windows.Forms.NumericUpDown Numeric_Frequency;
        private System.Windows.Forms.NumericUpDown Numeric_Amplitude;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
    }
}