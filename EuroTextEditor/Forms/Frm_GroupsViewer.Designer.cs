
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
            this.ListBox_HashCodes = new System.Windows.Forms.ListBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Label_ItemsCount = new System.Windows.Forms.Label();
            this.Groupbox_hashCodes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Groupbox_hashCodes
            // 
            this.Groupbox_hashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Groupbox_hashCodes.Controls.Add(this.Label_ItemsCount);
            this.Groupbox_hashCodes.Controls.Add(this.ListBox_HashCodes);
            this.Groupbox_hashCodes.Location = new System.Drawing.Point(12, 12);
            this.Groupbox_hashCodes.Name = "Groupbox_hashCodes";
            this.Groupbox_hashCodes.Size = new System.Drawing.Size(511, 442);
            this.Groupbox_hashCodes.TabIndex = 0;
            this.Groupbox_hashCodes.TabStop = false;
            this.Groupbox_hashCodes.Text = "HashCodes In Group:";
            // 
            // ListBox_HashCodes
            // 
            this.ListBox_HashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_HashCodes.FormattingEnabled = true;
            this.ListBox_HashCodes.Location = new System.Drawing.Point(3, 16);
            this.ListBox_HashCodes.Name = "ListBox_HashCodes";
            this.ListBox_HashCodes.ScrollAlwaysVisible = true;
            this.ListBox_HashCodes.Size = new System.Drawing.Size(505, 394);
            this.ListBox_HashCodes.TabIndex = 0;
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_OK.Location = new System.Drawing.Point(224, 460);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Label_ItemsCount
            // 
            this.Label_ItemsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_ItemsCount.AutoSize = true;
            this.Label_ItemsCount.Location = new System.Drawing.Point(6, 417);
            this.Label_ItemsCount.Name = "Label_ItemsCount";
            this.Label_ItemsCount.Size = new System.Drawing.Size(43, 13);
            this.Label_ItemsCount.TabIndex = 1;
            this.Label_ItemsCount.Text = "Total: 0";
            // 
            // Frm_GroupsViewer
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 495);
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
            this.Groupbox_hashCodes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Groupbox_hashCodes;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.ListBox ListBox_HashCodes;
        private System.Windows.Forms.Label Label_ItemsCount;
    }
}