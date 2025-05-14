
namespace EuroText2
{
    partial class FrmSectionsInspector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSectionsInspector));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHashCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemSectionCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSectionHCCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalMessages = new System.Windows.Forms.Label();
            this.lbxMessages = new System.Windows.Forms.ListBox();
            this.ContextMenu_Texts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemTextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemTextEditCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextEditGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemTextCopyHashCode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemTextExport = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.Textbox_OutputSections = new System.Windows.Forms.TextBox();
            this.Label_OutputSection = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ContextMenu_Texts.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 583);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Sections";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColSection,
            this.ColHashCode});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(330, 564);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // ColSection
            // 
            this.ColSection.Text = "Section";
            this.ColSection.Width = 150;
            // 
            // ColHashCode
            // 
            this.ColHashCode.Text = "HashCode";
            this.ColHashCode.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSectionCopy,
            this.MenuItemSectionHCCopy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 48);
            // 
            // MenuItemSectionCopy
            // 
            this.MenuItemSectionCopy.Name = "MenuItemSectionCopy";
            this.MenuItemSectionCopy.Size = new System.Drawing.Size(160, 22);
            this.MenuItemSectionCopy.Text = "Copy Section";
            this.MenuItemSectionCopy.Click += new System.EventHandler(this.MenuItemSectionCopy_Click);
            // 
            // MenuItemSectionHCCopy
            // 
            this.MenuItemSectionHCCopy.Name = "MenuItemSectionHCCopy";
            this.MenuItemSectionHCCopy.Size = new System.Drawing.Size(160, 22);
            this.MenuItemSectionHCCopy.Text = "Copy HashCode";
            this.MenuItemSectionHCCopy.Click += new System.EventHandler(this.MenuItemSectionHCCopy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblTotalMessages);
            this.groupBox2.Controls.Add(this.lbxMessages);
            this.groupBox2.Location = new System.Drawing.Point(354, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 500);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Messages in Section";
            // 
            // lblTotalMessages
            // 
            this.lblTotalMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalMessages.AutoSize = true;
            this.lblTotalMessages.Location = new System.Drawing.Point(6, 478);
            this.lblTotalMessages.Name = "lblTotalMessages";
            this.lblTotalMessages.Size = new System.Drawing.Size(94, 13);
            this.lblTotalMessages.TabIndex = 1;
            this.lblTotalMessages.Text = "Total Messages: 0";
            // 
            // lbxMessages
            // 
            this.lbxMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxMessages.ContextMenuStrip = this.ContextMenu_Texts;
            this.lbxMessages.FormattingEnabled = true;
            this.lbxMessages.HorizontalScrollbar = true;
            this.lbxMessages.Location = new System.Drawing.Point(3, 16);
            this.lbxMessages.Name = "lbxMessages";
            this.lbxMessages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxMessages.Size = new System.Drawing.Size(338, 459);
            this.lbxMessages.Sorted = true;
            this.lbxMessages.TabIndex = 0;
            this.lbxMessages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbxMessages_MouseDoubleClick);
            // 
            // ContextMenu_Texts
            // 
            this.ContextMenu_Texts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTextEdit,
            this.toolStripSeparator2,
            this.MenuItemTextEditCategories,
            this.MenuItemTextEditGroups,
            this.MenuItemTextSeparator2,
            this.MenuItemTextCopyHashCode,
            this.MenuItemTextSeparator3,
            this.MenuItemTextExport});
            this.ContextMenu_Texts.Name = "ContextMenu_Texts";
            this.ContextMenu_Texts.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ContextMenu_Texts.Size = new System.Drawing.Size(161, 132);
            // 
            // MenuItemTextEdit
            // 
            this.MenuItemTextEdit.Name = "MenuItemTextEdit";
            this.MenuItemTextEdit.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextEdit.Text = "Edit";
            this.MenuItemTextEdit.Click += new System.EventHandler(this.MenuItemTextEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // MenuItemTextEditCategories
            // 
            this.MenuItemTextEditCategories.Name = "MenuItemTextEditCategories";
            this.MenuItemTextEditCategories.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextEditCategories.Text = "Set Categories";
            this.MenuItemTextEditCategories.Click += new System.EventHandler(this.MenuItemTextEditCategories_Click);
            // 
            // MenuItemTextEditGroups
            // 
            this.MenuItemTextEditGroups.Name = "MenuItemTextEditGroups";
            this.MenuItemTextEditGroups.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextEditGroups.Text = "Set Text Group";
            this.MenuItemTextEditGroups.Click += new System.EventHandler(this.MenuItemTextEditGroups_Click);
            // 
            // MenuItemTextSeparator2
            // 
            this.MenuItemTextSeparator2.Name = "MenuItemTextSeparator2";
            this.MenuItemTextSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // MenuItemTextCopyHashCode
            // 
            this.MenuItemTextCopyHashCode.Name = "MenuItemTextCopyHashCode";
            this.MenuItemTextCopyHashCode.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextCopyHashCode.Text = "Copy HashCode";
            this.MenuItemTextCopyHashCode.Click += new System.EventHandler(this.MenuItemTextCopyHashCode_Click);
            // 
            // MenuItemTextSeparator3
            // 
            this.MenuItemTextSeparator3.Name = "MenuItemTextSeparator3";
            this.MenuItemTextSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // MenuItemTextExport
            // 
            this.MenuItemTextExport.Name = "MenuItemTextExport";
            this.MenuItemTextExport.Size = new System.Drawing.Size(160, 22);
            this.MenuItemTextExport.Text = "Export List";
            this.MenuItemTextExport.Click += new System.EventHandler(this.MenuItemTextExport_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnOk);
            this.groupBox3.Controls.Add(this.Textbox_OutputSections);
            this.groupBox3.Controls.Add(this.Label_OutputSection);
            this.groupBox3.Location = new System.Drawing.Point(354, 518);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Re-Assign To Section";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(263, 45);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // Textbox_OutputSections
            // 
            this.Textbox_OutputSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_OutputSections.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_OutputSections.Location = new System.Drawing.Point(93, 19);
            this.Textbox_OutputSections.Name = "Textbox_OutputSections";
            this.Textbox_OutputSections.ReadOnly = true;
            this.Textbox_OutputSections.Size = new System.Drawing.Size(245, 20);
            this.Textbox_OutputSections.TabIndex = 9;
            this.Textbox_OutputSections.Click += new System.EventHandler(this.Textbox_OutputSections_Click);
            // 
            // Label_OutputSection
            // 
            this.Label_OutputSection.AutoSize = true;
            this.Label_OutputSection.Location = new System.Drawing.Point(6, 22);
            this.Label_OutputSection.Name = "Label_OutputSection";
            this.Label_OutputSection.Size = new System.Drawing.Size(81, 13);
            this.Label_OutputSection.TabIndex = 8;
            this.Label_OutputSection.Text = "Output Section:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text File|*.txt";
            // 
            // FrmSectionsInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 607);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSectionsInspector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text Sections Inspector";
            this.Load += new System.EventHandler(this.FrmSectionsInspector_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ContextMenu_Texts.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxMessages;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOk;
        protected internal System.Windows.Forms.TextBox Textbox_OutputSections;
        private System.Windows.Forms.Label Label_OutputSection;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColSection;
        private System.Windows.Forms.ColumnHeader ColHashCode;
        private System.Windows.Forms.Label lblTotalMessages;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSectionCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSectionHCCopy;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Texts;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextEditCategories;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextEditGroups;
        private System.Windows.Forms.ToolStripSeparator MenuItemTextSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextCopyHashCode;
        private System.Windows.Forms.ToolStripSeparator MenuItemTextSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTextExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}