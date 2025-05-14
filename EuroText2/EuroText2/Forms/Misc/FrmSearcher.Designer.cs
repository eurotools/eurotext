
namespace EuroText2
{
    partial class FrmSearcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearcher));
            this.Button_NewSearch = new System.Windows.Forms.Button();
            this.Button_StopSearch = new System.Windows.Forms.Button();
            this.Button_Search = new System.Windows.Forms.Button();
            this.CheckBox_WholeWord = new System.Windows.Forms.CheckBox();
            this.CheckBox_MatchCase = new System.Windows.Forms.CheckBox();
            this.Textbox_LookFor = new System.Windows.Forms.TextBox();
            this.Combobox_LookField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_LookFor = new System.Windows.Forms.Label();
            this.Combobox_LookIn = new System.Windows.Forms.ComboBox();
            this.Label_LookIn = new System.Windows.Forms.Label();
            this.ContextMenu_Texts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemTextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemTextEditCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextEditGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemTextCopyHashCode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTextSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemTextExport = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSearchResults = new System.Windows.Forms.ToolStripStatusLabel();
            this.AsyncWorker = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lboxResults = new System.Windows.Forms.ListBox();
            this.ContextMenu_Texts.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_NewSearch
            // 
            this.Button_NewSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_NewSearch.Location = new System.Drawing.Point(459, 65);
            this.Button_NewSearch.Name = "Button_NewSearch";
            this.Button_NewSearch.Size = new System.Drawing.Size(75, 23);
            this.Button_NewSearch.TabIndex = 21;
            this.Button_NewSearch.Text = "New Search";
            this.Button_NewSearch.UseVisualStyleBackColor = true;
            this.Button_NewSearch.Click += new System.EventHandler(this.Button_NewSearch_Click);
            // 
            // Button_StopSearch
            // 
            this.Button_StopSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_StopSearch.Location = new System.Drawing.Point(459, 39);
            this.Button_StopSearch.Name = "Button_StopSearch";
            this.Button_StopSearch.Size = new System.Drawing.Size(75, 23);
            this.Button_StopSearch.TabIndex = 20;
            this.Button_StopSearch.Text = "Stop";
            this.Button_StopSearch.UseVisualStyleBackColor = true;
            this.Button_StopSearch.Click += new System.EventHandler(this.Button_StopSearch_Click);
            // 
            // Button_Search
            // 
            this.Button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Search.Location = new System.Drawing.Point(459, 12);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(75, 23);
            this.Button_Search.TabIndex = 19;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // CheckBox_WholeWord
            // 
            this.CheckBox_WholeWord.AutoSize = true;
            this.CheckBox_WholeWord.Location = new System.Drawing.Point(95, 94);
            this.CheckBox_WholeWord.Name = "CheckBox_WholeWord";
            this.CheckBox_WholeWord.Size = new System.Drawing.Size(86, 17);
            this.CheckBox_WholeWord.TabIndex = 18;
            this.CheckBox_WholeWord.Text = "Whole Word";
            this.CheckBox_WholeWord.UseVisualStyleBackColor = true;
            // 
            // CheckBox_MatchCase
            // 
            this.CheckBox_MatchCase.AutoSize = true;
            this.CheckBox_MatchCase.Location = new System.Drawing.Point(6, 94);
            this.CheckBox_MatchCase.Name = "CheckBox_MatchCase";
            this.CheckBox_MatchCase.Size = new System.Drawing.Size(83, 17);
            this.CheckBox_MatchCase.TabIndex = 17;
            this.CheckBox_MatchCase.Text = "Match Case";
            this.CheckBox_MatchCase.UseVisualStyleBackColor = true;
            // 
            // Textbox_LookFor
            // 
            this.Textbox_LookFor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_LookFor.Location = new System.Drawing.Point(74, 41);
            this.Textbox_LookFor.Name = "Textbox_LookFor";
            this.Textbox_LookFor.Size = new System.Drawing.Size(379, 20);
            this.Textbox_LookFor.TabIndex = 16;
            // 
            // Combobox_LookField
            // 
            this.Combobox_LookField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Combobox_LookField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_LookField.FormattingEnabled = true;
            this.Combobox_LookField.Items.AddRange(new object[] {
            "Hash-Codes",
            "File Content",
            "Categories"});
            this.Combobox_LookField.Location = new System.Drawing.Point(74, 67);
            this.Combobox_LookField.Name = "Combobox_LookField";
            this.Combobox_LookField.Size = new System.Drawing.Size(379, 21);
            this.Combobox_LookField.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Field:";
            // 
            // Label_LookFor
            // 
            this.Label_LookFor.AutoSize = true;
            this.Label_LookFor.Location = new System.Drawing.Point(6, 44);
            this.Label_LookFor.Name = "Label_LookFor";
            this.Label_LookFor.Size = new System.Drawing.Size(62, 13);
            this.Label_LookFor.TabIndex = 13;
            this.Label_LookFor.Text = "Search For:";
            // 
            // Combobox_LookIn
            // 
            this.Combobox_LookIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Combobox_LookIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_LookIn.FormattingEnabled = true;
            this.Combobox_LookIn.Location = new System.Drawing.Point(74, 14);
            this.Combobox_LookIn.Name = "Combobox_LookIn";
            this.Combobox_LookIn.Size = new System.Drawing.Size(379, 21);
            this.Combobox_LookIn.TabIndex = 12;
            // 
            // Label_LookIn
            // 
            this.Label_LookIn.AutoSize = true;
            this.Label_LookIn.Location = new System.Drawing.Point(22, 17);
            this.Label_LookIn.Name = "Label_LookIn";
            this.Label_LookIn.Size = new System.Drawing.Size(46, 13);
            this.Label_LookIn.TabIndex = 11;
            this.Label_LookIn.Text = "Look In:";
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSearchResults});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(546, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(45, 17);
            this.lblSearchResults.Text = "0 Items";
            // 
            // AsyncWorker
            // 
            this.AsyncWorker.WorkerSupportsCancellation = true;
            this.AsyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AsyncWorker_DoWork);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text File|*.txt";
            // 
            // lboxResults
            // 
            this.lboxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxResults.ContextMenuStrip = this.ContextMenu_Texts;
            this.lboxResults.FormattingEnabled = true;
            this.lboxResults.Location = new System.Drawing.Point(12, 117);
            this.lboxResults.Name = "lboxResults";
            this.lboxResults.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxResults.Size = new System.Drawing.Size(522, 316);
            this.lboxResults.Sorted = true;
            this.lboxResults.TabIndex = 24;
            this.lboxResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LboxResults_MouseDoubleClick);
            // 
            // FrmSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 462);
            this.Controls.Add(this.lboxResults);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Button_NewSearch);
            this.Controls.Add(this.Button_StopSearch);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.CheckBox_WholeWord);
            this.Controls.Add(this.CheckBox_MatchCase);
            this.Controls.Add(this.Textbox_LookFor);
            this.Controls.Add(this.Combobox_LookField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_LookFor);
            this.Controls.Add(this.Combobox_LookIn);
            this.Controls.Add(this.Label_LookIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSearcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FrmSearcher_Load);
            this.ContextMenu_Texts.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_NewSearch;
        private System.Windows.Forms.Button Button_StopSearch;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.CheckBox CheckBox_WholeWord;
        private System.Windows.Forms.CheckBox CheckBox_MatchCase;
        private System.Windows.Forms.TextBox Textbox_LookFor;
        private System.Windows.Forms.ComboBox Combobox_LookField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_LookFor;
        private System.Windows.Forms.ComboBox Combobox_LookIn;
        private System.Windows.Forms.Label Label_LookIn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSearchResults;
        private System.ComponentModel.BackgroundWorker AsyncWorker;
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
        private System.Windows.Forms.ListBox lboxResults;
    }
}