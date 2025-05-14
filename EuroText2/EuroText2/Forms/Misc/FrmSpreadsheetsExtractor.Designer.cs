
namespace EuroText2
{
    partial class FrmSpreadsheetsExtractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpreadsheetsExtractor));
            this.GroupBox_Options = new System.Windows.Forms.GroupBox();
            this.Button_ReadTable = new System.Windows.Forms.Button();
            this.Button_GetSections = new System.Windows.Forms.Button();
            this.Button_GetMessages = new System.Windows.Forms.Button();
            this.Button_GetGroups = new System.Windows.Forms.Button();
            this.DataGridView_ExcelSheet = new System.Windows.Forms.DataGridView();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.grbxSetFlags = new System.Windows.Forms.GroupBox();
            this.txtOutputFlags = new System.Windows.Forms.TextBox();
            this.GroupBox_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ExcelSheet)).BeginInit();
            this.grbxSetFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Options
            // 
            this.GroupBox_Options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Options.Controls.Add(this.Button_ReadTable);
            this.GroupBox_Options.Controls.Add(this.Button_GetSections);
            this.GroupBox_Options.Controls.Add(this.Button_GetMessages);
            this.GroupBox_Options.Controls.Add(this.Button_GetGroups);
            this.GroupBox_Options.Location = new System.Drawing.Point(654, 12);
            this.GroupBox_Options.Name = "GroupBox_Options";
            this.GroupBox_Options.Size = new System.Drawing.Size(112, 142);
            this.GroupBox_Options.TabIndex = 15;
            this.GroupBox_Options.TabStop = false;
            this.GroupBox_Options.Text = "Options";
            // 
            // Button_ReadTable
            // 
            this.Button_ReadTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ReadTable.Location = new System.Drawing.Point(6, 19);
            this.Button_ReadTable.Name = "Button_ReadTable";
            this.Button_ReadTable.Size = new System.Drawing.Size(100, 23);
            this.Button_ReadTable.TabIndex = 8;
            this.Button_ReadTable.Text = "Read Table";
            this.Button_ReadTable.UseVisualStyleBackColor = true;
            this.Button_ReadTable.Click += new System.EventHandler(this.Button_ReadTable_Click);
            // 
            // Button_GetSections
            // 
            this.Button_GetSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GetSections.Location = new System.Drawing.Point(6, 106);
            this.Button_GetSections.Name = "Button_GetSections";
            this.Button_GetSections.Size = new System.Drawing.Size(100, 23);
            this.Button_GetSections.TabIndex = 12;
            this.Button_GetSections.Text = "Get Text Sections";
            this.Button_GetSections.UseVisualStyleBackColor = true;
            this.Button_GetSections.Click += new System.EventHandler(this.Button_GetSections_Click);
            // 
            // Button_GetMessages
            // 
            this.Button_GetMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GetMessages.Location = new System.Drawing.Point(6, 77);
            this.Button_GetMessages.Name = "Button_GetMessages";
            this.Button_GetMessages.Size = new System.Drawing.Size(100, 23);
            this.Button_GetMessages.TabIndex = 11;
            this.Button_GetMessages.Text = "Get Messages";
            this.Button_GetMessages.UseVisualStyleBackColor = true;
            this.Button_GetMessages.Click += new System.EventHandler(this.Button_GetMessages_Click);
            // 
            // Button_GetGroups
            // 
            this.Button_GetGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GetGroups.Location = new System.Drawing.Point(6, 48);
            this.Button_GetGroups.Name = "Button_GetGroups";
            this.Button_GetGroups.Size = new System.Drawing.Size(100, 23);
            this.Button_GetGroups.TabIndex = 10;
            this.Button_GetGroups.Text = "Get Text Groups";
            this.Button_GetGroups.UseVisualStyleBackColor = true;
            this.Button_GetGroups.Click += new System.EventHandler(this.Button_GetGroups_Click);
            // 
            // DataGridView_ExcelSheet
            // 
            this.DataGridView_ExcelSheet.AllowUserToAddRows = false;
            this.DataGridView_ExcelSheet.AllowUserToDeleteRows = false;
            this.DataGridView_ExcelSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_ExcelSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ExcelSheet.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_ExcelSheet.Name = "DataGridView_ExcelSheet";
            this.DataGridView_ExcelSheet.ReadOnly = true;
            this.DataGridView_ExcelSheet.Size = new System.Drawing.Size(654, 573);
            this.DataGridView_ExcelSheet.TabIndex = 14;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "EuroText File (*.etf)|*.etf";
            // 
            // grbxSetFlags
            // 
            this.grbxSetFlags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxSetFlags.Controls.Add(this.txtOutputFlags);
            this.grbxSetFlags.Location = new System.Drawing.Point(654, 160);
            this.grbxSetFlags.Name = "grbxSetFlags";
            this.grbxSetFlags.Size = new System.Drawing.Size(112, 55);
            this.grbxSetFlags.TabIndex = 16;
            this.grbxSetFlags.TabStop = false;
            this.grbxSetFlags.Text = "Set Text Flags:";
            // 
            // txtOutputFlags
            // 
            this.txtOutputFlags.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutputFlags.Location = new System.Drawing.Point(6, 19);
            this.txtOutputFlags.Name = "txtOutputFlags";
            this.txtOutputFlags.ReadOnly = true;
            this.txtOutputFlags.Size = new System.Drawing.Size(100, 20);
            this.txtOutputFlags.TabIndex = 0;
            this.txtOutputFlags.Tag = "0";
            this.txtOutputFlags.Click += new System.EventHandler(this.TxtOutputFlags_Click);
            // 
            // FrmSpreadsheetsExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 573);
            this.Controls.Add(this.grbxSetFlags);
            this.Controls.Add(this.GroupBox_Options);
            this.Controls.Add(this.DataGridView_ExcelSheet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSpreadsheetsExtractor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SpreadSheets Extractor";
            this.GroupBox_Options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ExcelSheet)).EndInit();
            this.grbxSetFlags.ResumeLayout(false);
            this.grbxSetFlags.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Options;
        private System.Windows.Forms.Button Button_ReadTable;
        private System.Windows.Forms.Button Button_GetSections;
        private System.Windows.Forms.Button Button_GetMessages;
        private System.Windows.Forms.Button Button_GetGroups;
        private System.Windows.Forms.DataGridView DataGridView_ExcelSheet;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.GroupBox grbxSetFlags;
        private System.Windows.Forms.TextBox txtOutputFlags;
    }
}