
namespace EuroTextEditor.Forms.Editor
{
    partial class Frm_TextOutSection
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
            this.grbxOutputSections = new System.Windows.Forms.GroupBox();
            this.grbxAvailableOutSections = new System.Windows.Forms.GroupBox();
            this.lstbOutSections = new System.Windows.Forms.ListBox();
            this.btnRemoveSection = new System.Windows.Forms.Button();
            this.labelTotalOutSections = new System.Windows.Forms.Label();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.lstbAvailableOutSections = new System.Windows.Forms.ListBox();
            this.labTotalAvailable = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grbxOutputSections.SuspendLayout();
            this.grbxAvailableOutSections.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxOutputSections
            // 
            this.grbxOutputSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbxOutputSections.Controls.Add(this.labelTotalOutSections);
            this.grbxOutputSections.Controls.Add(this.btnRemoveSection);
            this.grbxOutputSections.Controls.Add(this.lstbOutSections);
            this.grbxOutputSections.Location = new System.Drawing.Point(12, 12);
            this.grbxOutputSections.Name = "grbxOutputSections";
            this.grbxOutputSections.Size = new System.Drawing.Size(279, 472);
            this.grbxOutputSections.TabIndex = 0;
            this.grbxOutputSections.TabStop = false;
            this.grbxOutputSections.Text = "Output Sections";
            // 
            // grbxAvailableOutSections
            // 
            this.grbxAvailableOutSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxAvailableOutSections.Controls.Add(this.labTotalAvailable);
            this.grbxAvailableOutSections.Controls.Add(this.lstbAvailableOutSections);
            this.grbxAvailableOutSections.Controls.Add(this.btnAddSection);
            this.grbxAvailableOutSections.Location = new System.Drawing.Point(297, 12);
            this.grbxAvailableOutSections.Name = "grbxAvailableOutSections";
            this.grbxAvailableOutSections.Size = new System.Drawing.Size(295, 443);
            this.grbxAvailableOutSections.TabIndex = 1;
            this.grbxAvailableOutSections.TabStop = false;
            this.grbxAvailableOutSections.Text = "Available Output Sections";
            // 
            // lstbOutSections
            // 
            this.lstbOutSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbOutSections.FormattingEnabled = true;
            this.lstbOutSections.HorizontalScrollbar = true;
            this.lstbOutSections.Location = new System.Drawing.Point(6, 48);
            this.lstbOutSections.Name = "lstbOutSections";
            this.lstbOutSections.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbOutSections.Size = new System.Drawing.Size(267, 394);
            this.lstbOutSections.TabIndex = 0;
            // 
            // btnRemoveSection
            // 
            this.btnRemoveSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSection.Location = new System.Drawing.Point(6, 19);
            this.btnRemoveSection.Name = "btnRemoveSection";
            this.btnRemoveSection.Size = new System.Drawing.Size(267, 23);
            this.btnRemoveSection.TabIndex = 1;
            this.btnRemoveSection.Text = "Remove Output Section >>>";
            this.btnRemoveSection.UseVisualStyleBackColor = true;
            this.btnRemoveSection.Click += new System.EventHandler(this.BtnRemoveSection_Click);
            // 
            // labelTotalOutSections
            // 
            this.labelTotalOutSections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalOutSections.AutoSize = true;
            this.labelTotalOutSections.Location = new System.Drawing.Point(6, 448);
            this.labelTotalOutSections.Name = "labelTotalOutSections";
            this.labelTotalOutSections.Size = new System.Drawing.Size(43, 13);
            this.labelTotalOutSections.TabIndex = 2;
            this.labelTotalOutSections.Text = "Total: 0";
            // 
            // btnAddSection
            // 
            this.btnAddSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSection.Location = new System.Drawing.Point(6, 19);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(283, 23);
            this.btnAddSection.TabIndex = 0;
            this.btnAddSection.Text = "<<< Add Output Section";
            this.btnAddSection.UseVisualStyleBackColor = true;
            this.btnAddSection.Click += new System.EventHandler(this.BtnAddSection_Click);
            // 
            // lstbAvailableOutSections
            // 
            this.lstbAvailableOutSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbAvailableOutSections.FormattingEnabled = true;
            this.lstbAvailableOutSections.HorizontalScrollbar = true;
            this.lstbAvailableOutSections.Location = new System.Drawing.Point(6, 48);
            this.lstbAvailableOutSections.Name = "lstbAvailableOutSections";
            this.lstbAvailableOutSections.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbAvailableOutSections.Size = new System.Drawing.Size(283, 368);
            this.lstbAvailableOutSections.TabIndex = 1;
            // 
            // labTotalAvailable
            // 
            this.labTotalAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labTotalAvailable.AutoSize = true;
            this.labTotalAvailable.Location = new System.Drawing.Point(6, 419);
            this.labTotalAvailable.Name = "labTotalAvailable";
            this.labTotalAvailable.Size = new System.Drawing.Size(43, 13);
            this.labTotalAvailable.TabIndex = 3;
            this.labTotalAvailable.Text = "Total: 0";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(518, 461);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(437, 461);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Frm_TextOutSection
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(604, 496);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbxAvailableOutSections);
            this.Controls.Add(this.grbxOutputSections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TextOutSection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Output Section";
            this.Load += new System.EventHandler(this.Frm_TextOutSection_Load);
            this.grbxOutputSections.ResumeLayout(false);
            this.grbxOutputSections.PerformLayout();
            this.grbxAvailableOutSections.ResumeLayout(false);
            this.grbxAvailableOutSections.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxOutputSections;
        private System.Windows.Forms.Label labelTotalOutSections;
        private System.Windows.Forms.Button btnRemoveSection;
        private System.Windows.Forms.ListBox lstbOutSections;
        private System.Windows.Forms.GroupBox grbxAvailableOutSections;
        private System.Windows.Forms.ListBox lstbAvailableOutSections;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Label labTotalAvailable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}