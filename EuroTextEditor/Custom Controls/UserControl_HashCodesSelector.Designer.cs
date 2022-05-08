
namespace EuroTextEditor.Editor
{
    partial class UserControl_HashCodesSelector
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox_FilePath = new System.Windows.Forms.GroupBox();
            this.Textbox_FilePath = new System.Windows.Forms.TextBox();
            this.GroupBox_AvailableHashCodes = new System.Windows.Forms.GroupBox();
            this.Combobox_HashCodes = new System.Windows.Forms.ComboBox();
            this.Label_Section = new System.Windows.Forms.Label();
            this.Combobox_HashCodes_Section = new System.Windows.Forms.ComboBox();
            this.OpenFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox_FilePath.SuspendLayout();
            this.GroupBox_AvailableHashCodes.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_FilePath
            // 
            this.GroupBox_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_FilePath.Controls.Add(this.Textbox_FilePath);
            this.GroupBox_FilePath.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_FilePath.Name = "GroupBox_FilePath";
            this.GroupBox_FilePath.Size = new System.Drawing.Size(360, 53);
            this.GroupBox_FilePath.TabIndex = 6;
            this.GroupBox_FilePath.TabStop = false;
            this.GroupBox_FilePath.Text = "File Path:";
            // 
            // Textbox_FilePath
            // 
            this.Textbox_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox_FilePath.BackColor = System.Drawing.SystemColors.Window;
            this.Textbox_FilePath.Location = new System.Drawing.Point(6, 19);
            this.Textbox_FilePath.Name = "Textbox_FilePath";
            this.Textbox_FilePath.ReadOnly = true;
            this.Textbox_FilePath.Size = new System.Drawing.Size(348, 20);
            this.Textbox_FilePath.TabIndex = 0;
            this.Textbox_FilePath.Text = "X:\\Sphinx\\Albert\\hashcodes.h";
            // 
            // GroupBox_AvailableHashCodes
            // 
            this.GroupBox_AvailableHashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_AvailableHashCodes.Controls.Add(this.Combobox_HashCodes);
            this.GroupBox_AvailableHashCodes.Controls.Add(this.Label_Section);
            this.GroupBox_AvailableHashCodes.Controls.Add(this.Combobox_HashCodes_Section);
            this.GroupBox_AvailableHashCodes.Location = new System.Drawing.Point(0, 59);
            this.GroupBox_AvailableHashCodes.Name = "GroupBox_AvailableHashCodes";
            this.GroupBox_AvailableHashCodes.Size = new System.Drawing.Size(360, 80);
            this.GroupBox_AvailableHashCodes.TabIndex = 5;
            this.GroupBox_AvailableHashCodes.TabStop = false;
            this.GroupBox_AvailableHashCodes.Text = "Available HashCodes:";
            // 
            // Combobox_HashCodes
            // 
            this.Combobox_HashCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Combobox_HashCodes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Combobox_HashCodes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Combobox_HashCodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_HashCodes.FormattingEnabled = true;
            this.Combobox_HashCodes.Location = new System.Drawing.Point(6, 46);
            this.Combobox_HashCodes.Name = "Combobox_HashCodes";
            this.Combobox_HashCodes.Size = new System.Drawing.Size(348, 21);
            this.Combobox_HashCodes.TabIndex = 2;
            // 
            // Label_Section
            // 
            this.Label_Section.AutoSize = true;
            this.Label_Section.Location = new System.Drawing.Point(6, 22);
            this.Label_Section.Name = "Label_Section";
            this.Label_Section.Size = new System.Drawing.Size(46, 13);
            this.Label_Section.TabIndex = 1;
            this.Label_Section.Text = "Section:";
            // 
            // Combobox_HashCodes_Section
            // 
            this.Combobox_HashCodes_Section.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Combobox_HashCodes_Section.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Combobox_HashCodes_Section.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Combobox_HashCodes_Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_HashCodes_Section.FormattingEnabled = true;
            this.Combobox_HashCodes_Section.Location = new System.Drawing.Point(58, 19);
            this.Combobox_HashCodes_Section.Name = "Combobox_HashCodes_Section";
            this.Combobox_HashCodes_Section.Size = new System.Drawing.Size(296, 21);
            this.Combobox_HashCodes_Section.TabIndex = 0;
            this.Combobox_HashCodes_Section.SelectedIndexChanged += new System.EventHandler(this.Combobox_HashCodes_Section_SelectedIndexChanged);
            // 
            // OpenFileDiag
            // 
            this.OpenFileDiag.Filter = "h files (*.h)|*.h";
            this.OpenFileDiag.ShowReadOnly = true;
            // 
            // UserControl_HashCodesSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox_FilePath);
            this.Controls.Add(this.GroupBox_AvailableHashCodes);
            this.Name = "UserControl_HashCodesSelector";
            this.Size = new System.Drawing.Size(360, 139);
            this.GroupBox_FilePath.ResumeLayout(false);
            this.GroupBox_FilePath.PerformLayout();
            this.GroupBox_AvailableHashCodes.ResumeLayout(false);
            this.GroupBox_AvailableHashCodes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_FilePath;
        private System.Windows.Forms.GroupBox GroupBox_AvailableHashCodes;
        private System.Windows.Forms.Label Label_Section;
        private System.Windows.Forms.OpenFileDialog OpenFileDiag;
        protected internal System.Windows.Forms.ComboBox Combobox_HashCodes;
        protected internal System.Windows.Forms.ComboBox Combobox_HashCodes_Section;
        protected internal System.Windows.Forms.TextBox Textbox_FilePath;
    }
}
