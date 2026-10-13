namespace EuroText2
{
    partial class Frm_AlphaCycle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Label_Speed = new System.Windows.Forms.Label();
            this.Numeric_Speed = new System.Windows.Forms.NumericUpDown();
            this.Label_Alphas = new System.Windows.Forms.Label();
            this.ListBox_Alphas = new System.Windows.Forms.ListBox();
            this.Label_Alpha = new System.Windows.Forms.Label();
            this.Numeric_Alpha = new System.Windows.Forms.NumericUpDown();
            this.Button_AddAlpha = new System.Windows.Forms.Button();
            this.Button_UpdateAlpha = new System.Windows.Forms.Button();
            this.Button_RemoveAlpha = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Alpha)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Speed
            // 
            this.Label_Speed.AutoSize = true;
            this.Label_Speed.Location = new System.Drawing.Point(12, 14);
            this.Label_Speed.Name = "Label_Speed";
            this.Label_Speed.Size = new System.Drawing.Size(41, 13);
            this.Label_Speed.TabIndex = 0;
            this.Label_Speed.Text = "Speed:";
            // 
            // Numeric_Speed
            // 
            this.Numeric_Speed.Location = new System.Drawing.Point(104, 12);
            this.Numeric_Speed.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.Numeric_Speed.Name = "Numeric_Speed";
            this.Numeric_Speed.Size = new System.Drawing.Size(90, 20);
            this.Numeric_Speed.TabIndex = 1;
            this.Numeric_Speed.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // Label_Alphas
            // 
            this.Label_Alphas.AutoSize = true;
            this.Label_Alphas.Location = new System.Drawing.Point(12, 45);
            this.Label_Alphas.Name = "Label_Alphas";
            this.Label_Alphas.Size = new System.Drawing.Size(169, 13);
            this.Label_Alphas.TabIndex = 2;
            this.Label_Alphas.Text = "Alpha values (at least two, 0-128):";
            // 
            // ListBox_Alphas
            // 
            this.ListBox_Alphas.FormattingEnabled = true;
            this.ListBox_Alphas.Location = new System.Drawing.Point(12, 61);
            this.ListBox_Alphas.Name = "ListBox_Alphas";
            this.ListBox_Alphas.Size = new System.Drawing.Size(182, 121);
            this.ListBox_Alphas.TabIndex = 3;
            this.ListBox_Alphas.SelectedIndexChanged += new System.EventHandler(this.ListBox_Alphas_SelectedIndexChanged);
            // 
            // Label_Alpha
            // 
            this.Label_Alpha.AutoSize = true;
            this.Label_Alpha.Location = new System.Drawing.Point(210, 64);
            this.Label_Alpha.Name = "Label_Alpha";
            this.Label_Alpha.Size = new System.Drawing.Size(64, 13);
            this.Label_Alpha.TabIndex = 4;
            this.Label_Alpha.Text = "Alpha 0-128:";
            // 
            // Numeric_Alpha
            // 
            this.Numeric_Alpha.Location = new System.Drawing.Point(213, 80);
            this.Numeric_Alpha.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            this.Numeric_Alpha.Name = "Numeric_Alpha";
            this.Numeric_Alpha.Size = new System.Drawing.Size(91, 20);
            this.Numeric_Alpha.TabIndex = 5;
            this.Numeric_Alpha.Value = new decimal(new int[] { 128, 0, 0, 0 });
            // 
            // Button_AddAlpha
            // 
            this.Button_AddAlpha.Location = new System.Drawing.Point(213, 106);
            this.Button_AddAlpha.Name = "Button_AddAlpha";
            this.Button_AddAlpha.Size = new System.Drawing.Size(91, 23);
            this.Button_AddAlpha.TabIndex = 6;
            this.Button_AddAlpha.Text = "Add";
            this.Button_AddAlpha.UseVisualStyleBackColor = true;
            this.Button_AddAlpha.Click += new System.EventHandler(this.Button_AddAlpha_Click);
            // 
            // Button_UpdateAlpha
            // 
            this.Button_UpdateAlpha.Location = new System.Drawing.Point(213, 135);
            this.Button_UpdateAlpha.Name = "Button_UpdateAlpha";
            this.Button_UpdateAlpha.Size = new System.Drawing.Size(91, 23);
            this.Button_UpdateAlpha.TabIndex = 7;
            this.Button_UpdateAlpha.Text = "Update";
            this.Button_UpdateAlpha.UseVisualStyleBackColor = true;
            this.Button_UpdateAlpha.Click += new System.EventHandler(this.Button_UpdateAlpha_Click);
            // 
            // Button_RemoveAlpha
            // 
            this.Button_RemoveAlpha.Location = new System.Drawing.Point(213, 164);
            this.Button_RemoveAlpha.Name = "Button_RemoveAlpha";
            this.Button_RemoveAlpha.Size = new System.Drawing.Size(91, 23);
            this.Button_RemoveAlpha.TabIndex = 8;
            this.Button_RemoveAlpha.Text = "Remove";
            this.Button_RemoveAlpha.UseVisualStyleBackColor = true;
            this.Button_RemoveAlpha.Click += new System.EventHandler(this.Button_RemoveAlpha_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(148, 203);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 9;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(229, 203);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 10;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Frm_AlphaCycle
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(316, 238);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Button_RemoveAlpha);
            this.Controls.Add(this.Button_UpdateAlpha);
            this.Controls.Add(this.Button_AddAlpha);
            this.Controls.Add(this.Numeric_Alpha);
            this.Controls.Add(this.Label_Alpha);
            this.Controls.Add(this.ListBox_Alphas);
            this.Controls.Add(this.Label_Alphas);
            this.Controls.Add(this.Numeric_Speed);
            this.Controls.Add(this.Label_Speed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AlphaCycle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alpha Cycle";
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Alpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Label_Speed;
        private System.Windows.Forms.NumericUpDown Numeric_Speed;
        private System.Windows.Forms.Label Label_Alphas;
        private System.Windows.Forms.ListBox ListBox_Alphas;
        private System.Windows.Forms.Label Label_Alpha;
        private System.Windows.Forms.NumericUpDown Numeric_Alpha;
        private System.Windows.Forms.Button Button_AddAlpha;
        private System.Windows.Forms.Button Button_UpdateAlpha;
        private System.Windows.Forms.Button Button_RemoveAlpha;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
    }
}
