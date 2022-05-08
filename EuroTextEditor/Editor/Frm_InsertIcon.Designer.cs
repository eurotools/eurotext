
namespace EuroTextEditor
{
    partial class Frm_InsertIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InsertIcon));
            this.GroupBox_SpecifyWidth = new System.Windows.Forms.GroupBox();
            this.Numeric_Height = new System.Windows.Forms.NumericUpDown();
            this.Label_Height = new System.Windows.Forms.Label();
            this.Numeric_Width = new System.Windows.Forms.NumericUpDown();
            this.Label_Width = new System.Windows.Forms.Label();
            this.CheckBox_SpecifyWidthAndHeight = new System.Windows.Forms.CheckBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.OpenFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.HashCodesControl = new EuroTextEditor.Editor.UserControl_HashCodesSelector();
            this.GroupBox_SpecifyWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Width)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_SpecifyWidth
            // 
            this.GroupBox_SpecifyWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_SpecifyWidth.Controls.Add(this.Numeric_Height);
            this.GroupBox_SpecifyWidth.Controls.Add(this.Label_Height);
            this.GroupBox_SpecifyWidth.Controls.Add(this.Numeric_Width);
            this.GroupBox_SpecifyWidth.Controls.Add(this.Label_Width);
            this.GroupBox_SpecifyWidth.Controls.Add(this.CheckBox_SpecifyWidthAndHeight);
            this.GroupBox_SpecifyWidth.Location = new System.Drawing.Point(12, 156);
            this.GroupBox_SpecifyWidth.Name = "GroupBox_SpecifyWidth";
            this.GroupBox_SpecifyWidth.Size = new System.Drawing.Size(441, 53);
            this.GroupBox_SpecifyWidth.TabIndex = 7;
            this.GroupBox_SpecifyWidth.TabStop = false;
            // 
            // Numeric_Height
            // 
            this.Numeric_Height.Enabled = false;
            this.Numeric_Height.Location = new System.Drawing.Point(312, 19);
            this.Numeric_Height.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Numeric_Height.Name = "Numeric_Height";
            this.Numeric_Height.Size = new System.Drawing.Size(120, 20);
            this.Numeric_Height.TabIndex = 4;
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Location = new System.Drawing.Point(222, 21);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(84, 13);
            this.Label_Height.TabIndex = 3;
            this.Label_Height.Text = "Width (in pixels):";
            // 
            // Numeric_Width
            // 
            this.Numeric_Width.Enabled = false;
            this.Numeric_Width.Location = new System.Drawing.Point(96, 19);
            this.Numeric_Width.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Numeric_Width.Name = "Numeric_Width";
            this.Numeric_Width.Size = new System.Drawing.Size(120, 20);
            this.Numeric_Width.TabIndex = 2;
            // 
            // Label_Width
            // 
            this.Label_Width.AutoSize = true;
            this.Label_Width.Location = new System.Drawing.Point(6, 21);
            this.Label_Width.Name = "Label_Width";
            this.Label_Width.Size = new System.Drawing.Size(84, 13);
            this.Label_Width.TabIndex = 1;
            this.Label_Width.Text = "Width (in pixels):";
            // 
            // CheckBox_SpecifyWidthAndHeight
            // 
            this.CheckBox_SpecifyWidthAndHeight.AutoSize = true;
            this.CheckBox_SpecifyWidthAndHeight.Location = new System.Drawing.Point(9, 0);
            this.CheckBox_SpecifyWidthAndHeight.Name = "CheckBox_SpecifyWidthAndHeight";
            this.CheckBox_SpecifyWidthAndHeight.Size = new System.Drawing.Size(128, 17);
            this.CheckBox_SpecifyWidthAndHeight.TabIndex = 0;
            this.CheckBox_SpecifyWidthAndHeight.Text = "Set Width and Height";
            this.CheckBox_SpecifyWidthAndHeight.UseVisualStyleBackColor = true;
            this.CheckBox_SpecifyWidthAndHeight.CheckedChanged += new System.EventHandler(this.CheckBox_SpecifyWidthAndHeight_CheckedChanged);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(378, 215);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 9;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.Location = new System.Drawing.Point(297, 215);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 8;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // OpenFileDiag
            // 
            this.OpenFileDiag.Filter = "h files (*.h)|*.h";
            this.OpenFileDiag.ShowReadOnly = true;
            // 
            // HashCodesControl
            // 
            this.HashCodesControl.Location = new System.Drawing.Point(12, 11);
            this.HashCodesControl.Name = "HashCodesControl";
            this.HashCodesControl.Size = new System.Drawing.Size(441, 139);
            this.HashCodesControl.TabIndex = 10;
            // 
            // Frm_InsertIcon
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(465, 250);
            this.Controls.Add(this.HashCodesControl);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.GroupBox_SpecifyWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_InsertIcon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert Icon";
            this.Load += new System.EventHandler(this.Frm_InsertIcon_Load);
            this.GroupBox_SpecifyWidth.ResumeLayout(false);
            this.GroupBox_SpecifyWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Width)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBox_SpecifyWidth;
        private System.Windows.Forms.NumericUpDown Numeric_Width;
        private System.Windows.Forms.Label Label_Width;
        private System.Windows.Forms.CheckBox CheckBox_SpecifyWidthAndHeight;
        private System.Windows.Forms.NumericUpDown Numeric_Height;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.OpenFileDialog OpenFileDiag;
        private Editor.UserControl_HashCodesSelector HashCodesControl;
    }
}