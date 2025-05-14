
namespace EuroText2
{
    partial class FrmToolTrim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmToolTrim));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ContextMenuCheckList = new System.Windows.Forms.ContextMenu();
            this.MenuItem_CheckAll = new System.Windows.Forms.MenuItem();
            this.MenuItem_UncheckAll = new System.Windows.Forms.MenuItem();
            this.grbxOptions = new System.Windows.Forms.GroupBox();
            this.chckTrimEnd = new System.Windows.Forms.CheckBox();
            this.chckTrimStart = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ContextMenu = this.ContextMenuCheckList;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 25);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(301, 304);
            this.checkedListBox1.TabIndex = 5;
            // 
            // ContextMenuCheckList
            // 
            this.ContextMenuCheckList.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem_CheckAll,
            this.MenuItem_UncheckAll});
            // 
            // MenuItem_CheckAll
            // 
            this.MenuItem_CheckAll.Index = 0;
            this.MenuItem_CheckAll.Text = "Check All";
            this.MenuItem_CheckAll.Click += new System.EventHandler(this.MenuItem_CheckAll_Click);
            // 
            // MenuItem_UncheckAll
            // 
            this.MenuItem_UncheckAll.Index = 1;
            this.MenuItem_UncheckAll.Text = "Uncheck All";
            this.MenuItem_UncheckAll.Click += new System.EventHandler(this.MenuItem_UncheckAll_Click);
            // 
            // grbxOptions
            // 
            this.grbxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxOptions.Controls.Add(this.chckTrimEnd);
            this.grbxOptions.Controls.Add(this.chckTrimStart);
            this.grbxOptions.Location = new System.Drawing.Point(12, 340);
            this.grbxOptions.Name = "grbxOptions";
            this.grbxOptions.Size = new System.Drawing.Size(301, 42);
            this.grbxOptions.TabIndex = 9;
            this.grbxOptions.TabStop = false;
            this.grbxOptions.Text = "Options:";
            // 
            // chckTrimEnd
            // 
            this.chckTrimEnd.AutoSize = true;
            this.chckTrimEnd.Checked = true;
            this.chckTrimEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckTrimEnd.Location = new System.Drawing.Point(92, 19);
            this.chckTrimEnd.Name = "chckTrimEnd";
            this.chckTrimEnd.Size = new System.Drawing.Size(68, 17);
            this.chckTrimEnd.TabIndex = 1;
            this.chckTrimEnd.Text = "Trim End";
            this.chckTrimEnd.UseVisualStyleBackColor = true;
            // 
            // chckTrimStart
            // 
            this.chckTrimStart.AutoSize = true;
            this.chckTrimStart.Checked = true;
            this.chckTrimStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckTrimStart.Location = new System.Drawing.Point(6, 19);
            this.chckTrimStart.Name = "chckTrimStart";
            this.chckTrimStart.Size = new System.Drawing.Size(71, 17);
            this.chckTrimStart.TabIndex = 0;
            this.chckTrimStart.Text = "Trim Start";
            this.chckTrimStart.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(238, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(157, 388);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apply To The Following Languages:";
            // 
            // FrmToolTrim
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(325, 421);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.grbxOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmToolTrim";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trim Strings";
            this.Load += new System.EventHandler(this.FrmToolTrim_Load);
            this.grbxOptions.ResumeLayout(false);
            this.grbxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ContextMenu ContextMenuCheckList;
        private System.Windows.Forms.MenuItem MenuItem_CheckAll;
        private System.Windows.Forms.MenuItem MenuItem_UncheckAll;
        private System.Windows.Forms.GroupBox grbxOptions;
        private System.Windows.Forms.CheckBox chckTrimEnd;
        private System.Windows.Forms.CheckBox chckTrimStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
    }
}