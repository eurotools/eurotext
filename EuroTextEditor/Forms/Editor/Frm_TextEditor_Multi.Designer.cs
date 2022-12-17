
namespace EuroTextEditor
{
    partial class Frm_TextEditor_Multi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TextEditor_Multi));
            this.GroupBox_FilesToBeModified = new System.Windows.Forms.GroupBox();
            this.ListBox_FilesToBeModified = new System.Windows.Forms.ListBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.userControl_TextOptions1 = new EuroTextEditor.Custom_Controls.UserControl_TextOptions();
            this.GroupBox_FilesToBeModified.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_FilesToBeModified
            // 
            this.GroupBox_FilesToBeModified.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_FilesToBeModified.Controls.Add(this.ListBox_FilesToBeModified);
            this.GroupBox_FilesToBeModified.Location = new System.Drawing.Point(12, 62);
            this.GroupBox_FilesToBeModified.Name = "GroupBox_FilesToBeModified";
            this.GroupBox_FilesToBeModified.Size = new System.Drawing.Size(744, 400);
            this.GroupBox_FilesToBeModified.TabIndex = 1;
            this.GroupBox_FilesToBeModified.TabStop = false;
            this.GroupBox_FilesToBeModified.Text = "Files To Be Modified";
            // 
            // ListBox_FilesToBeModified
            // 
            this.ListBox_FilesToBeModified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_FilesToBeModified.FormattingEnabled = true;
            this.ListBox_FilesToBeModified.Location = new System.Drawing.Point(3, 16);
            this.ListBox_FilesToBeModified.Name = "ListBox_FilesToBeModified";
            this.ListBox_FilesToBeModified.ScrollAlwaysVisible = true;
            this.ListBox_FilesToBeModified.Size = new System.Drawing.Size(738, 381);
            this.ListBox_FilesToBeModified.TabIndex = 0;
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.Location = new System.Drawing.Point(600, 468);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 2;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(681, 468);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 3;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // userControl_TextOptions1
            // 
            this.userControl_TextOptions1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl_TextOptions1.Location = new System.Drawing.Point(12, 12);
            this.userControl_TextOptions1.Name = "userControl_TextOptions1";
            this.userControl_TextOptions1.Size = new System.Drawing.Size(745, 44);
            this.userControl_TextOptions1.TabIndex = 0;
            // 
            // Frm_TextEditor_Multi
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(768, 503);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.GroupBox_FilesToBeModified);
            this.Controls.Add(this.userControl_TextOptions1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_TextEditor_Multi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Multiple HashCodes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_TextEditor_Multi_FormClosing);
            this.Load += new System.EventHandler(this.Frm_TextEditor_Multi_Load);
            this.GroupBox_FilesToBeModified.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls.UserControl_TextOptions userControl_TextOptions1;
        private System.Windows.Forms.GroupBox GroupBox_FilesToBeModified;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.ListBox ListBox_FilesToBeModified;
    }
}