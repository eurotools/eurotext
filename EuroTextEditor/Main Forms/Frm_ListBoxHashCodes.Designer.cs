
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
            this.UserControl_HashCodesListView = new EuroTextEditor.Custom_Controls.UserControl_ListViewHashCodes();
            this.SuspendLayout();
            // 
            // UserControl_HashCodesListView
            // 
            this.UserControl_HashCodesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl_HashCodesListView.Location = new System.Drawing.Point(0, 0);
            this.UserControl_HashCodesListView.Name = "UserControl_HashCodesListView";
            this.UserControl_HashCodesListView.Size = new System.Drawing.Size(378, 478);
            this.UserControl_HashCodesListView.TabIndex = 7;
            // 
            // Frm_ListBoxHashCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 478);
            this.Controls.Add(this.UserControl_HashCodesListView);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ListBoxHashCodes";
            this.TabText = "HashCodes";
            this.Text = "HashCodes";
            this.Shown += new System.EventHandler(this.Frm_ListBoxHashCodes_Shown);
            this.VisibleChanged += new System.EventHandler(this.Frm_ListBoxHashCodes_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
        protected internal Custom_Controls.UserControl_ListViewHashCodes UserControl_HashCodesListView;
    }
}