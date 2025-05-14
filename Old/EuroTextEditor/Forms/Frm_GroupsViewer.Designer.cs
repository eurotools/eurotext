
namespace EuroTextEditor
{
    partial class Frm_GroupsViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GroupsViewer));
            this.Groupbox_hashCodes = new System.Windows.Forms.GroupBox();
            this.UserControl_HashCodes = new EuroTextEditor.Custom_Controls.UserControl_ListViewHashCodes();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Groupbox_hashCodes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Groupbox_hashCodes
            // 
            this.Groupbox_hashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Groupbox_hashCodes.Controls.Add(this.UserControl_HashCodes);
            this.Groupbox_hashCodes.Location = new System.Drawing.Point(12, 12);
            this.Groupbox_hashCodes.Name = "Groupbox_hashCodes";
            this.Groupbox_hashCodes.Size = new System.Drawing.Size(758, 485);
            this.Groupbox_hashCodes.TabIndex = 0;
            this.Groupbox_hashCodes.TabStop = false;
            this.Groupbox_hashCodes.Text = "HashCodes";
            // 
            // UserControl_HashCodes
            // 
            this.UserControl_HashCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl_HashCodes.Location = new System.Drawing.Point(3, 16);
            this.UserControl_HashCodes.Name = "UserControl_HashCodes";
            this.UserControl_HashCodes.ShowFilters = false;
            this.UserControl_HashCodes.Size = new System.Drawing.Size(752, 466);
            this.UserControl_HashCodes.TabIndex = 2;
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_OK.Location = new System.Drawing.Point(347, 503);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Frm_GroupsViewer
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 538);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Groupbox_hashCodes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_GroupsViewer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_GroupsViewer";
            this.Shown += new System.EventHandler(this.Frm_GroupsViewer_Shown);
            this.Groupbox_hashCodes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Groupbox_hashCodes;
        private System.Windows.Forms.Button Button_OK;
        private Custom_Controls.UserControl_ListViewHashCodes UserControl_HashCodes;
    }
}