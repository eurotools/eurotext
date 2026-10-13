
namespace EuroText2
{
    partial class FrmCheckExitMarkers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckExitMarkers));
            this.grbxTextGroups = new System.Windows.Forms.GroupBox();
            this.chkTextGroups = new System.Windows.Forms.CheckedListBox();
            this.ContextGroupsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxGroupsSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxGroupsSelectNone = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxGroupsInvertSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.grbxStringsToCheck = new System.Windows.Forms.GroupBox();
            this.lbxForReview = new System.Windows.Forms.ListBox();
            this.lblForReviewCount = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblTotalGroups = new System.Windows.Forms.Label();
            this.grbxTextGroups.SuspendLayout();
            this.ContextGroupsList.SuspendLayout();
            this.grbxStringsToCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxTextGroups
            // 
            this.grbxTextGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbxTextGroups.Controls.Add(this.chkTextGroups);
            this.grbxTextGroups.Location = new System.Drawing.Point(12, 12);
            this.grbxTextGroups.Name = "grbxTextGroups";
            this.grbxTextGroups.Size = new System.Drawing.Size(200, 565);
            this.grbxTextGroups.TabIndex = 0;
            this.grbxTextGroups.TabStop = false;
            this.grbxTextGroups.Text = "Text Groups";
            // 
            // chkTextGroups
            // 
            this.chkTextGroups.CheckOnClick = true;
            this.chkTextGroups.ContextMenuStrip = this.ContextGroupsList;
            this.chkTextGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTextGroups.FormattingEnabled = true;
            this.chkTextGroups.Location = new System.Drawing.Point(3, 16);
            this.chkTextGroups.Name = "chkTextGroups";
            this.chkTextGroups.Size = new System.Drawing.Size(194, 546);
            this.chkTextGroups.TabIndex = 0;
            // 
            // ContextGroupsList
            // 
            this.ContextGroupsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxGroupsSelectAll,
            this.ctxGroupsSelectNone,
            this.ctxGroupsInvertSelect});
            this.ContextGroupsList.Name = "ContextGroupsList";
            this.ContextGroupsList.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextGroupsList.Size = new System.Drawing.Size(156, 70);
            // 
            // ctxGroupsSelectAll
            // 
            this.ctxGroupsSelectAll.Name = "ctxGroupsSelectAll";
            this.ctxGroupsSelectAll.Size = new System.Drawing.Size(155, 22);
            this.ctxGroupsSelectAll.Text = "Select All";
            this.ctxGroupsSelectAll.Click += new System.EventHandler(this.ctxGroupsSelectAll_Click);
            // 
            // ctxGroupsSelectNone
            // 
            this.ctxGroupsSelectNone.Name = "ctxGroupsSelectNone";
            this.ctxGroupsSelectNone.Size = new System.Drawing.Size(155, 22);
            this.ctxGroupsSelectNone.Text = "Select None";
            this.ctxGroupsSelectNone.Click += new System.EventHandler(this.ctxGroupsSelectNone_Click);
            // 
            // ctxGroupsInvertSelect
            // 
            this.ctxGroupsInvertSelect.Name = "ctxGroupsInvertSelect";
            this.ctxGroupsInvertSelect.Size = new System.Drawing.Size(155, 22);
            this.ctxGroupsInvertSelect.Text = "Invert Selection";
            this.ctxGroupsInvertSelect.Click += new System.EventHandler(this.ctxGroupsInvertSelect_Click);
            // 
            // grbxStringsToCheck
            // 
            this.grbxStringsToCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxStringsToCheck.Controls.Add(this.lbxForReview);
            this.grbxStringsToCheck.Location = new System.Drawing.Point(215, 12);
            this.grbxStringsToCheck.Name = "grbxStringsToCheck";
            this.grbxStringsToCheck.Size = new System.Drawing.Size(395, 536);
            this.grbxStringsToCheck.TabIndex = 1;
            this.grbxStringsToCheck.TabStop = false;
            this.grbxStringsToCheck.Text = "Strings to check";
            // 
            // lbxForReview
            // 
            this.lbxForReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxForReview.FormattingEnabled = true;
            this.lbxForReview.HorizontalScrollbar = true;
            this.lbxForReview.Location = new System.Drawing.Point(3, 16);
            this.lbxForReview.Name = "lbxForReview";
            this.lbxForReview.Size = new System.Drawing.Size(389, 517);
            this.lbxForReview.Sorted = true;
            this.lbxForReview.TabIndex = 0;
            this.lbxForReview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxForReview_MouseDoubleClick);
            // 
            // lblForReviewCount
            // 
            this.lblForReviewCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblForReviewCount.AutoSize = true;
            this.lblForReviewCount.Location = new System.Drawing.Point(218, 551);
            this.lblForReviewCount.Name = "lblForReviewCount";
            this.lblForReviewCount.Size = new System.Drawing.Size(43, 13);
            this.lblForReviewCount.TabIndex = 2;
            this.lblForReviewCount.Text = "Total: 0";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(512, 567);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(98, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run check";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblTotalGroups
            // 
            this.lblTotalGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalGroups.AutoSize = true;
            this.lblTotalGroups.Location = new System.Drawing.Point(12, 580);
            this.lblTotalGroups.Name = "lblTotalGroups";
            this.lblTotalGroups.Size = new System.Drawing.Size(43, 13);
            this.lblTotalGroups.TabIndex = 4;
            this.lblTotalGroups.Text = "Total: 0";
            // 
            // FrmCheckExitMarkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 602);
            this.Controls.Add(this.lblTotalGroups);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblForReviewCount);
            this.Controls.Add(this.grbxStringsToCheck);
            this.Controls.Add(this.grbxTextGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheckExitMarkers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check Exit Markers";
            this.Load += new System.EventHandler(this.FrmCheckExitMarkers_Load);
            this.grbxTextGroups.ResumeLayout(false);
            this.ContextGroupsList.ResumeLayout(false);
            this.grbxStringsToCheck.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxTextGroups;
        private System.Windows.Forms.CheckedListBox chkTextGroups;
        private System.Windows.Forms.GroupBox grbxStringsToCheck;
        private System.Windows.Forms.ListBox lbxForReview;
        private System.Windows.Forms.Label lblForReviewCount;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblTotalGroups;
        private System.Windows.Forms.ContextMenuStrip ContextGroupsList;
        private System.Windows.Forms.ToolStripMenuItem ctxGroupsSelectAll;
        private System.Windows.Forms.ToolStripMenuItem ctxGroupsSelectNone;
        private System.Windows.Forms.ToolStripMenuItem ctxGroupsInvertSelect;
    }
}