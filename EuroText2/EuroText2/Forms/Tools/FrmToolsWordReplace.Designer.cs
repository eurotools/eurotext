﻿
namespace EuroText2
{
    partial class FrmToolsWordReplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmToolsWordReplace));
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ContextMenuCheckList = new System.Windows.Forms.ContextMenu();
            this.MenuItem_CheckAll = new System.Windows.Forms.MenuItem();
            this.MenuItem_UncheckAll = new System.Windows.Forms.MenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChckOrdinalIgnore = new System.Windows.Forms.CheckBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.TextboxReplacement = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxOriginal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Apply To The Following Languages:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ContextMenu = this.ContextMenuCheckList;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 149);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(355, 289);
            this.checkedListBox1.TabIndex = 13;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ChckOrdinalIgnore);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 40);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // ChckOrdinalIgnore
            // 
            this.ChckOrdinalIgnore.AutoSize = true;
            this.ChckOrdinalIgnore.Location = new System.Drawing.Point(6, 19);
            this.ChckOrdinalIgnore.Name = "ChckOrdinalIgnore";
            this.ChckOrdinalIgnore.Size = new System.Drawing.Size(83, 17);
            this.ChckOrdinalIgnore.TabIndex = 0;
            this.ChckOrdinalIgnore.Text = "Ignore Case";
            this.ChckOrdinalIgnore.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(292, 443);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 20;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOk.Location = new System.Drawing.Point(211, 443);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 19;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // TextboxReplacement
            // 
            this.TextboxReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextboxReplacement.Location = new System.Drawing.Point(12, 65);
            this.TextboxReplacement.Name = "TextboxReplacement";
            this.TextboxReplacement.Size = new System.Drawing.Size(355, 20);
            this.TextboxReplacement.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Replacement String:";
            // 
            // TextBoxOriginal
            // 
            this.TextBoxOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxOriginal.Location = new System.Drawing.Point(12, 26);
            this.TextBoxOriginal.Name = "TextBoxOriginal";
            this.TextBoxOriginal.Size = new System.Drawing.Size(355, 20);
            this.TextBoxOriginal.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Original String:";
            // 
            // FrmToolsWordReplace
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(379, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.TextboxReplacement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxOriginal);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmToolsWordReplace";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace Words";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmToolsWordReplace_FormClosing);
            this.Load += new System.EventHandler(this.FrmToolsWordReplace_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ContextMenu ContextMenuCheckList;
        private System.Windows.Forms.MenuItem MenuItem_CheckAll;
        private System.Windows.Forms.MenuItem MenuItem_UncheckAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChckOrdinalIgnore;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.TextBox TextboxReplacement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxOriginal;
        private System.Windows.Forms.Label label2;
    }
}