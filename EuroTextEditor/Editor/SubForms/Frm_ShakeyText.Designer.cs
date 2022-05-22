
namespace EuroTextEditor
{
    partial class Frm_ShakeyText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ShakeyText));
            this.CheckBox_Variance = new System.Windows.Forms.CheckBox();
            this.GroupBox_Duration = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBox_Speed = new System.Windows.Forms.CheckBox();
            this.Numeric_Speed = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Variance = new System.Windows.Forms.NumericUpDown();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.GroupBox_Duration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Variance)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBox_Variance
            // 
            this.CheckBox_Variance.AutoSize = true;
            this.CheckBox_Variance.Location = new System.Drawing.Point(6, 0);
            this.CheckBox_Variance.Name = "CheckBox_Variance";
            this.CheckBox_Variance.Size = new System.Drawing.Size(68, 17);
            this.CheckBox_Variance.TabIndex = 6;
            this.CheckBox_Variance.Text = "Variance";
            this.CheckBox_Variance.UseVisualStyleBackColor = true;
            this.CheckBox_Variance.CheckStateChanged += new System.EventHandler(this.CheckBox_Variance_CheckStateChanged);
            // 
            // GroupBox_Duration
            // 
            this.GroupBox_Duration.Controls.Add(this.CheckBox_Variance);
            this.GroupBox_Duration.Controls.Add(this.groupBox1);
            this.GroupBox_Duration.Controls.Add(this.Numeric_Variance);
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
            this.groupBox1.Controls.Add(this.CheckBox_Speed);
            this.groupBox1.Controls.Add(this.Numeric_Speed);
            this.groupBox1.Location = new System.Drawing.Point(6, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // CheckBox_Speed
            // 
            this.CheckBox_Speed.AutoSize = true;
            this.CheckBox_Speed.Location = new System.Drawing.Point(6, 0);
            this.CheckBox_Speed.Name = "CheckBox_Speed";
            this.CheckBox_Speed.Size = new System.Drawing.Size(57, 17);
            this.CheckBox_Speed.TabIndex = 1;
            this.CheckBox_Speed.Text = "Speed";
            this.CheckBox_Speed.UseVisualStyleBackColor = true;
            // 
            // Numeric_Speed
            // 
            this.Numeric_Speed.Enabled = false;
            this.Numeric_Speed.Location = new System.Drawing.Point(6, 23);
            this.Numeric_Speed.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Numeric_Speed.Name = "Numeric_Speed";
            this.Numeric_Speed.Size = new System.Drawing.Size(138, 20);
            this.Numeric_Speed.TabIndex = 4;
            // 
            // Numeric_Variance
            // 
            this.Numeric_Variance.Enabled = false;
            this.Numeric_Variance.Location = new System.Drawing.Point(6, 23);
            this.Numeric_Variance.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Numeric_Variance.Name = "Numeric_Variance";
            this.Numeric_Variance.Size = new System.Drawing.Size(138, 20);
            this.Numeric_Variance.TabIndex = 2;
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
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.Location = new System.Drawing.Point(201, 136);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 3;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Frm_ShakeyText
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
            this.Name = "Frm_ShakeyText";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shakey Text";
            this.GroupBox_Duration.ResumeLayout(false);
            this.GroupBox_Duration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Variance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_Variance;
        private System.Windows.Forms.GroupBox GroupBox_Duration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckBox_Speed;
        private System.Windows.Forms.NumericUpDown Numeric_Speed;
        private System.Windows.Forms.NumericUpDown Numeric_Variance;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
    }
}