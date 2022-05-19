
namespace EuroTextEditor
{
    partial class Frm_Searcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Searcher));
            this.Label_LookIn = new System.Windows.Forms.Label();
            this.Combobox_LookIn = new System.Windows.Forms.ComboBox();
            this.Label_LookFor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Combobox_LookField = new System.Windows.Forms.ComboBox();
            this.Textbox_LookFor = new System.Windows.Forms.TextBox();
            this.CheckBox_MatchCase = new System.Windows.Forms.CheckBox();
            this.CheckBox_WholeWord = new System.Windows.Forms.CheckBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.Button_StopSearch = new System.Windows.Forms.Button();
            this.Button_NewSearch = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.Label_NumberOfItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.UserControl_HashCodesTable = new EuroTextEditor.Custom_Controls.UserControl_ListViewHashCodes();
            this.AsyncWorker = new System.ComponentModel.BackgroundWorker();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_LookIn
            // 
            this.Label_LookIn.AutoSize = true;
            this.Label_LookIn.Location = new System.Drawing.Point(28, 15);
            this.Label_LookIn.Name = "Label_LookIn";
            this.Label_LookIn.Size = new System.Drawing.Size(46, 13);
            this.Label_LookIn.TabIndex = 0;
            this.Label_LookIn.Text = "Look In:";
            // 
            // Combobox_LookIn
            // 
            this.Combobox_LookIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Combobox_LookIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_LookIn.FormattingEnabled = true;
            this.Combobox_LookIn.Location = new System.Drawing.Point(80, 12);
            this.Combobox_LookIn.Name = "Combobox_LookIn";
            this.Combobox_LookIn.Size = new System.Drawing.Size(294, 21);
            this.Combobox_LookIn.TabIndex = 1;
            // 
            // Label_LookFor
            // 
            this.Label_LookFor.AutoSize = true;
            this.Label_LookFor.Location = new System.Drawing.Point(12, 42);
            this.Label_LookFor.Name = "Label_LookFor";
            this.Label_LookFor.Size = new System.Drawing.Size(62, 13);
            this.Label_LookFor.TabIndex = 2;
            this.Label_LookFor.Text = "Search For:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Field:";
            // 
            // Combobox_LookField
            // 
            this.Combobox_LookField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Combobox_LookField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_LookField.FormattingEnabled = true;
            this.Combobox_LookField.Items.AddRange(new object[] {
            "Hash-Codes",
            "File Content"});
            this.Combobox_LookField.Location = new System.Drawing.Point(80, 65);
            this.Combobox_LookField.Name = "Combobox_LookField";
            this.Combobox_LookField.Size = new System.Drawing.Size(294, 21);
            this.Combobox_LookField.TabIndex = 4;
            // 
            // Textbox_LookFor
            // 
            this.Textbox_LookFor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_LookFor.Location = new System.Drawing.Point(80, 39);
            this.Textbox_LookFor.Name = "Textbox_LookFor";
            this.Textbox_LookFor.Size = new System.Drawing.Size(294, 20);
            this.Textbox_LookFor.TabIndex = 5;
            // 
            // CheckBox_MatchCase
            // 
            this.CheckBox_MatchCase.AutoSize = true;
            this.CheckBox_MatchCase.Location = new System.Drawing.Point(12, 92);
            this.CheckBox_MatchCase.Name = "CheckBox_MatchCase";
            this.CheckBox_MatchCase.Size = new System.Drawing.Size(83, 17);
            this.CheckBox_MatchCase.TabIndex = 6;
            this.CheckBox_MatchCase.Text = "Match Case";
            this.CheckBox_MatchCase.UseVisualStyleBackColor = true;
            // 
            // CheckBox_WholeWord
            // 
            this.CheckBox_WholeWord.AutoSize = true;
            this.CheckBox_WholeWord.Location = new System.Drawing.Point(101, 92);
            this.CheckBox_WholeWord.Name = "CheckBox_WholeWord";
            this.CheckBox_WholeWord.Size = new System.Drawing.Size(86, 17);
            this.CheckBox_WholeWord.TabIndex = 7;
            this.CheckBox_WholeWord.Text = "Whole Word";
            this.CheckBox_WholeWord.UseVisualStyleBackColor = true;
            // 
            // Button_Search
            // 
            this.Button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Search.Location = new System.Drawing.Point(380, 10);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(75, 23);
            this.Button_Search.TabIndex = 8;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // Button_StopSearch
            // 
            this.Button_StopSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_StopSearch.Location = new System.Drawing.Point(380, 39);
            this.Button_StopSearch.Name = "Button_StopSearch";
            this.Button_StopSearch.Size = new System.Drawing.Size(75, 23);
            this.Button_StopSearch.TabIndex = 9;
            this.Button_StopSearch.Text = "Stop";
            this.Button_StopSearch.UseVisualStyleBackColor = true;
            this.Button_StopSearch.Click += new System.EventHandler(this.Button_StopSearch_Click);
            // 
            // Button_NewSearch
            // 
            this.Button_NewSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_NewSearch.Location = new System.Drawing.Point(380, 68);
            this.Button_NewSearch.Name = "Button_NewSearch";
            this.Button_NewSearch.Size = new System.Drawing.Size(75, 23);
            this.Button_NewSearch.TabIndex = 10;
            this.Button_NewSearch.Text = "New Search";
            this.Button_NewSearch.UseVisualStyleBackColor = true;
            this.Button_NewSearch.Click += new System.EventHandler(this.Button_NewSearch_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label_NumberOfItems});
            this.StatusBar.Location = new System.Drawing.Point(0, 394);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(461, 22);
            this.StatusBar.TabIndex = 12;
            this.StatusBar.Text = "statusStrip1";
            // 
            // Label_NumberOfItems
            // 
            this.Label_NumberOfItems.Name = "Label_NumberOfItems";
            this.Label_NumberOfItems.Size = new System.Drawing.Size(45, 17);
            this.Label_NumberOfItems.Text = "0 Items";
            // 
            // UserControl_HashCodesTable
            // 
            this.UserControl_HashCodesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserControl_HashCodesTable.Location = new System.Drawing.Point(0, 115);
            this.UserControl_HashCodesTable.Name = "UserControl_HashCodesTable";
            this.UserControl_HashCodesTable.Size = new System.Drawing.Size(461, 279);
            this.UserControl_HashCodesTable.TabIndex = 11;
            // 
            // AsyncWorker
            // 
            this.AsyncWorker.WorkerSupportsCancellation = true;
            this.AsyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AsyncWorker_DoWork);
            // 
            // Frm_Searcher
            // 
            this.AcceptButton = this.Button_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 416);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.UserControl_HashCodesTable);
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
            this.Name = "Frm_Searcher";
            this.TabText = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Frm_Searcher_Load);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_LookIn;
        private System.Windows.Forms.ComboBox Combobox_LookIn;
        private System.Windows.Forms.Label Label_LookFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combobox_LookField;
        private System.Windows.Forms.TextBox Textbox_LookFor;
        private System.Windows.Forms.CheckBox CheckBox_MatchCase;
        private System.Windows.Forms.CheckBox CheckBox_WholeWord;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.Button Button_StopSearch;
        private System.Windows.Forms.Button Button_NewSearch;
        private Custom_Controls.UserControl_ListViewHashCodes UserControl_HashCodesTable;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel Label_NumberOfItems;
        private System.ComponentModel.BackgroundWorker AsyncWorker;
    }
}