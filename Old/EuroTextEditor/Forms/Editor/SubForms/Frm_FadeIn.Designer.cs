
namespace EuroTextEditor
{
    partial class Frm_FadeIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FadeIn));
            this.GroupBox_Duration = new System.Windows.Forms.GroupBox();
            this.Checkbox_Duration = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBox_WaitDelay = new System.Windows.Forms.CheckBox();
            this.Numeric_WaitDelay = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Duration = new System.Windows.Forms.NumericUpDown();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.GroupBox_Duration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WaitDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Duration)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_Duration
            // 
            this.GroupBox_Duration.Controls.Add(this.Checkbox_Duration);
            this.GroupBox_Duration.Controls.Add(this.groupBox1);
            this.GroupBox_Duration.Controls.Add(this.Numeric_Duration);
            this.GroupBox_Duration.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Duration.Name = "GroupBox_Duration";
            this.GroupBox_Duration.Size = new System.Drawing.Size(345, 114);
            this.GroupBox_Duration.TabIndex = 0;
            this.GroupBox_Duration.TabStop = false;
            // 
            // Checkbox_Duration
            // 
            this.Checkbox_Duration.AutoSize = true;
            this.Checkbox_Duration.Location = new System.Drawing.Point(6, 0);
            this.Checkbox_Duration.Name = "Checkbox_Duration";
            this.Checkbox_Duration.Size = new System.Drawing.Size(66, 17);
            this.Checkbox_Duration.TabIndex = 6;
            this.Checkbox_Duration.Text = "Duration";
            this.Checkbox_Duration.UseVisualStyleBackColor = true;
            this.Checkbox_Duration.CheckedChanged += new System.EventHandler(this.Checkbox_Duration_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CheckBox_WaitDelay);
            this.groupBox1.Controls.Add(this.Numeric_WaitDelay);
            this.groupBox1.Location = new System.Drawing.Point(6, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // CheckBox_WaitDelay
            // 
            this.CheckBox_WaitDelay.AutoSize = true;
            this.CheckBox_WaitDelay.Location = new System.Drawing.Point(6, 0);
            this.CheckBox_WaitDelay.Name = "CheckBox_WaitDelay";
            this.CheckBox_WaitDelay.Size = new System.Drawing.Size(78, 17);
            this.CheckBox_WaitDelay.TabIndex = 1;
            this.CheckBox_WaitDelay.Text = "Wait Delay";
            this.CheckBox_WaitDelay.UseVisualStyleBackColor = true;
            this.CheckBox_WaitDelay.CheckedChanged += new System.EventHandler(this.CheckBox_WaitDelay_CheckedChanged);
            // 
            // Numeric_WaitDelay
            // 
            this.Numeric_WaitDelay.Enabled = false;
            this.Numeric_WaitDelay.Location = new System.Drawing.Point(6, 23);
            this.Numeric_WaitDelay.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Numeric_WaitDelay.Name = "Numeric_WaitDelay";
            this.Numeric_WaitDelay.Size = new System.Drawing.Size(138, 20);
            this.Numeric_WaitDelay.TabIndex = 4;
            // 
            // Numeric_Duration
            // 
            this.Numeric_Duration.Enabled = false;
            this.Numeric_Duration.Location = new System.Drawing.Point(6, 23);
            this.Numeric_Duration.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Numeric_Duration.Name = "Numeric_Duration";
            this.Numeric_Duration.Size = new System.Drawing.Size(138, 20);
            this.Numeric_Duration.TabIndex = 2;
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.Location = new System.Drawing.Point(201, 136);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(282, 136);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 2;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Frm_FadeIn
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_FadeIn";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fade In";
            this.GroupBox_Duration.ResumeLayout(false);
            this.GroupBox_Duration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_WaitDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Duration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Duration;
        private System.Windows.Forms.CheckBox Checkbox_Duration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckBox_WaitDelay;
        private System.Windows.Forms.NumericUpDown Numeric_WaitDelay;
        private System.Windows.Forms.NumericUpDown Numeric_Duration;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
    }
}