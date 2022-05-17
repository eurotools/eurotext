
namespace EuroTextEditor
{
    partial class Frm_ListBoxHashCodes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListBoxHashCodes));
            this.Textbox_SearchBarHashCodes = new System.Windows.Forms.TextBox();
            this.GroupBox_Search = new System.Windows.Forms.GroupBox();
            this.CheckBox_ExactMatch = new System.Windows.Forms.CheckBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.UserControl_HashCodesListView = new EuroTextEditor.Custom_Controls.UserControl_ListViewHashCodes();
            this.GroupBox_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // Textbox_SearchBarHashCodes
            // 
            this.Textbox_SearchBarHashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_SearchBarHashCodes.Location = new System.Drawing.Point(6, 19);
            this.Textbox_SearchBarHashCodes.Name = "Textbox_SearchBarHashCodes";
            this.Textbox_SearchBarHashCodes.Size = new System.Drawing.Size(219, 20);
            this.Textbox_SearchBarHashCodes.TabIndex = 4;
            // 
            // GroupBox_Search
            // 
            this.GroupBox_Search.Controls.Add(this.CheckBox_ExactMatch);
            this.GroupBox_Search.Controls.Add(this.Button_Search);
            this.GroupBox_Search.Controls.Add(this.Textbox_SearchBarHashCodes);
            this.GroupBox_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox_Search.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Search.Name = "GroupBox_Search";
            this.GroupBox_Search.Size = new System.Drawing.Size(378, 51);
            this.GroupBox_Search.TabIndex = 6;
            this.GroupBox_Search.TabStop = false;
            this.GroupBox_Search.Text = "Search";
            // 
            // CheckBox_ExactMatch
            // 
            this.CheckBox_ExactMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBox_ExactMatch.AutoSize = true;
            this.CheckBox_ExactMatch.Location = new System.Drawing.Point(231, 21);
            this.CheckBox_ExactMatch.Name = "CheckBox_ExactMatch";
            this.CheckBox_ExactMatch.Size = new System.Drawing.Size(86, 17);
            this.CheckBox_ExactMatch.TabIndex = 6;
            this.CheckBox_ExactMatch.Text = "Exact Match";
            this.CheckBox_ExactMatch.UseVisualStyleBackColor = true;
            // 
            // Button_Search
            // 
            this.Button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Search.Location = new System.Drawing.Point(323, 17);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(49, 23);
            this.Button_Search.TabIndex = 5;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // UserControl_HashCodesListView
            // 
            this.UserControl_HashCodesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserControl_HashCodesListView.Location = new System.Drawing.Point(0, 57);
            this.UserControl_HashCodesListView.Name = "UserControl_HashCodesListView";
            this.UserControl_HashCodesListView.Size = new System.Drawing.Size(378, 421);
            this.UserControl_HashCodesListView.TabIndex = 7;
            // 
            // Frm_ListBoxHashCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 478);
            this.Controls.Add(this.UserControl_HashCodesListView);
            this.Controls.Add(this.GroupBox_Search);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ListBoxHashCodes";
            this.TabText = "HashCodes";
            this.Text = "HashCodes";
            this.Shown += new System.EventHandler(this.Frm_ListBoxHashCodes_Shown);
            this.VisibleChanged += new System.EventHandler(this.Frm_ListBoxHashCodes_VisibleChanged);
            this.GroupBox_Search.ResumeLayout(false);
            this.GroupBox_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Textbox_SearchBarHashCodes;
        private System.Windows.Forms.GroupBox GroupBox_Search;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.CheckBox CheckBox_ExactMatch;
        protected internal Custom_Controls.UserControl_ListViewHashCodes UserControl_HashCodesListView;
    }
}