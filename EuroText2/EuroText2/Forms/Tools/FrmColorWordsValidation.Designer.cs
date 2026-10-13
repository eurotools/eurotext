
namespace EuroText2
{
    partial class FrmColorWordsValidation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColorWordsValidation));
            this.grbxColours = new System.Windows.Forms.GroupBox();
            this.lbxColours = new System.Windows.Forms.ListBox();
            this.ctxMenuColors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxNewColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxRemoveColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxRenameColor = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlColour = new System.Windows.Forms.Panel();
            this.grbxLanguages = new System.Windows.Forms.GroupBox();
            this.lbxLanguages = new System.Windows.Forms.ListBox();
            this.grbxWords = new System.Windows.Forms.GroupBox();
            this.lbxWords = new System.Windows.Forms.ListBox();
            this.ctxMenuWords = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddWord = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveWord = new System.Windows.Forms.ToolStripMenuItem();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grbxColours.SuspendLayout();
            this.ctxMenuColors.SuspendLayout();
            this.grbxLanguages.SuspendLayout();
            this.grbxWords.SuspendLayout();
            this.ctxMenuWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxColours
            // 
            this.grbxColours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbxColours.Controls.Add(this.lbxColours);
            this.grbxColours.Location = new System.Drawing.Point(12, 12);
            this.grbxColours.Name = "grbxColours";
            this.grbxColours.Size = new System.Drawing.Size(180, 422);
            this.grbxColours.TabIndex = 0;
            this.grbxColours.TabStop = false;
            this.grbxColours.Text = "Colors";
            // 
            // lbxColours
            // 
            this.lbxColours.ContextMenuStrip = this.ctxMenuColors;
            this.lbxColours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxColours.FormattingEnabled = true;
            this.lbxColours.HorizontalScrollbar = true;
            this.lbxColours.Location = new System.Drawing.Point(3, 16);
            this.lbxColours.Name = "lbxColours";
            this.lbxColours.Size = new System.Drawing.Size(174, 403);
            this.lbxColours.TabIndex = 0;
            this.lbxColours.SelectedIndexChanged += new System.EventHandler(this.lbxColours_SelectedIndexChanged);
            // 
            // ctxMenuColors
            // 
            this.ctxMenuColors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxNewColor,
            this.ctxRemoveColor,
            this.ctxRenameColor});
            this.ctxMenuColors.Name = "ctxMenuColors";
            this.ctxMenuColors.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctxMenuColors.Size = new System.Drawing.Size(118, 70);
            // 
            // ctxNewColor
            // 
            this.ctxNewColor.Name = "ctxNewColor";
            this.ctxNewColor.Size = new System.Drawing.Size(117, 22);
            this.ctxNewColor.Text = "New";
            this.ctxNewColor.Click += new System.EventHandler(this.ctxNewColor_Click);
            // 
            // ctxRemoveColor
            // 
            this.ctxRemoveColor.Name = "ctxRemoveColor";
            this.ctxRemoveColor.Size = new System.Drawing.Size(117, 22);
            this.ctxRemoveColor.Text = "Remove";
            this.ctxRemoveColor.Click += new System.EventHandler(this.ctxRemoveColor_Click);
            // 
            // ctxRenameColor
            // 
            this.ctxRenameColor.Name = "ctxRenameColor";
            this.ctxRenameColor.Size = new System.Drawing.Size(117, 22);
            this.ctxRenameColor.Text = "Rename";
            this.ctxRenameColor.Click += new System.EventHandler(this.ctxRenameColor_Click);
            // 
            // pnlColour
            // 
            this.pnlColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColour.Location = new System.Drawing.Point(12, 440);
            this.pnlColour.Name = "pnlColour";
            this.pnlColour.Size = new System.Drawing.Size(180, 34);
            this.pnlColour.TabIndex = 1;
            this.pnlColour.Click += new System.EventHandler(this.pnlColour_Click);
            // 
            // grbxLanguages
            // 
            this.grbxLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbxLanguages.Controls.Add(this.lbxLanguages);
            this.grbxLanguages.Location = new System.Drawing.Point(198, 12);
            this.grbxLanguages.Name = "grbxLanguages";
            this.grbxLanguages.Size = new System.Drawing.Size(184, 462);
            this.grbxLanguages.TabIndex = 2;
            this.grbxLanguages.TabStop = false;
            this.grbxLanguages.Text = "Languages";
            // 
            // lbxLanguages
            // 
            this.lbxLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxLanguages.FormattingEnabled = true;
            this.lbxLanguages.HorizontalScrollbar = true;
            this.lbxLanguages.Location = new System.Drawing.Point(3, 16);
            this.lbxLanguages.Name = "lbxLanguages";
            this.lbxLanguages.Size = new System.Drawing.Size(178, 443);
            this.lbxLanguages.TabIndex = 1;
            this.lbxLanguages.SelectedIndexChanged += new System.EventHandler(this.lbxLanguages_SelectedIndexChanged);
            // 
            // grbxWords
            // 
            this.grbxWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxWords.Controls.Add(this.lbxWords);
            this.grbxWords.Location = new System.Drawing.Point(388, 12);
            this.grbxWords.Name = "grbxWords";
            this.grbxWords.Size = new System.Drawing.Size(213, 462);
            this.grbxWords.TabIndex = 3;
            this.grbxWords.TabStop = false;
            this.grbxWords.Text = "Words";
            // 
            // lbxWords
            // 
            this.lbxWords.ContextMenuStrip = this.ctxMenuWords;
            this.lbxWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxWords.FormattingEnabled = true;
            this.lbxWords.HorizontalScrollbar = true;
            this.lbxWords.Location = new System.Drawing.Point(3, 16);
            this.lbxWords.Name = "lbxWords";
            this.lbxWords.Size = new System.Drawing.Size(207, 443);
            this.lbxWords.Sorted = true;
            this.lbxWords.TabIndex = 1;
            // 
            // ctxMenuWords
            // 
            this.ctxMenuWords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddWord,
            this.btnRemoveWord});
            this.ctxMenuWords.Name = "ctxMenuColors";
            this.ctxMenuWords.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctxMenuWords.Size = new System.Drawing.Size(118, 48);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(117, 22);
            this.btnAddWord.Text = "Add";
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnRemoveWord
            // 
            this.btnRemoveWord.Name = "btnRemoveWord";
            this.btnRemoveWord.Size = new System.Drawing.Size(117, 22);
            this.btnRemoveWord.Text = "Remove";
            this.btnRemoveWord.Click += new System.EventHandler(this.btnRemoveWord_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidate.Location = new System.Drawing.Point(445, 480);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 5;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(526, 480);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmColorWordsValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 515);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.grbxWords);
            this.Controls.Add(this.grbxLanguages);
            this.Controls.Add(this.pnlColour);
            this.Controls.Add(this.grbxColours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmColorWordsValidation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Color Words Validation";
            this.Load += new System.EventHandler(this.FrmColorWordsValidation_Load);
            this.grbxColours.ResumeLayout(false);
            this.ctxMenuColors.ResumeLayout(false);
            this.grbxLanguages.ResumeLayout(false);
            this.grbxWords.ResumeLayout(false);
            this.ctxMenuWords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxColours;
        private System.Windows.Forms.ListBox lbxColours;
        private System.Windows.Forms.Panel pnlColour;
        private System.Windows.Forms.GroupBox grbxLanguages;
        private System.Windows.Forms.ListBox lbxLanguages;
        private System.Windows.Forms.GroupBox grbxWords;
        private System.Windows.Forms.ListBox lbxWords;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.ContextMenuStrip ctxMenuColors;
        private System.Windows.Forms.ToolStripMenuItem ctxNewColor;
        private System.Windows.Forms.ToolStripMenuItem ctxRemoveColor;
        private System.Windows.Forms.ToolStripMenuItem ctxRenameColor;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ContextMenuStrip ctxMenuWords;
        private System.Windows.Forms.ToolStripMenuItem btnAddWord;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveWord;
    }
}