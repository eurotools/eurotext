namespace EuroText2
{
    partial class Frm_ColourCycle
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
            this.CheckBox_Speed = new System.Windows.Forms.CheckBox();
            this.Numeric_Speed = new System.Windows.Forms.NumericUpDown();
            this.Label_Colours = new System.Windows.Forms.Label();
            this.ListBox_Colours = new System.Windows.Forms.ListBox();
            this.Label_Alpha = new System.Windows.Forms.Label();
            this.Numeric_Alpha = new System.Windows.Forms.NumericUpDown();
            this.Button_AddColour = new System.Windows.Forms.Button();
            this.Button_UpdateColour = new System.Windows.Forms.Button();
            this.Button_RemoveColour = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.ColorDialog_Colour = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Alpha)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBox_Speed
            // 
            this.CheckBox_Speed.AutoSize = true;
            this.CheckBox_Speed.Location = new System.Drawing.Point(12, 14);
            this.CheckBox_Speed.Name = "CheckBox_Speed";
            this.CheckBox_Speed.Size = new System.Drawing.Size(106, 17);
            this.CheckBox_Speed.TabIndex = 0;
            this.CheckBox_Speed.Text = "Custom speed:";
            this.CheckBox_Speed.UseVisualStyleBackColor = true;
            this.CheckBox_Speed.CheckedChanged += new System.EventHandler(this.CheckBox_Speed_CheckedChanged);
            // 
            // Numeric_Speed
            // 
            this.Numeric_Speed.Enabled = false;
            this.Numeric_Speed.Location = new System.Drawing.Point(124, 12);
            this.Numeric_Speed.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.Numeric_Speed.Name = "Numeric_Speed";
            this.Numeric_Speed.Size = new System.Drawing.Size(90, 20);
            this.Numeric_Speed.TabIndex = 1;
            this.Numeric_Speed.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // Label_Colours
            // 
            this.Label_Colours.AutoSize = true;
            this.Label_Colours.Location = new System.Drawing.Point(12, 45);
            this.Label_Colours.Name = "Label_Colours";
            this.Label_Colours.Size = new System.Drawing.Size(178, 13);
            this.Label_Colours.TabIndex = 2;
            this.Label_Colours.Text = "Colours (at least two, engine 0-128):";
            // 
            // ListBox_Colours
            // 
            this.ListBox_Colours.FormattingEnabled = true;
            this.ListBox_Colours.Location = new System.Drawing.Point(12, 61);
            this.ListBox_Colours.Name = "ListBox_Colours";
            this.ListBox_Colours.Size = new System.Drawing.Size(282, 121);
            this.ListBox_Colours.TabIndex = 3;
            this.ListBox_Colours.SelectedIndexChanged += new System.EventHandler(this.ListBox_Colours_SelectedIndexChanged);
            // 
            // Label_Alpha
            // 
            this.Label_Alpha.AutoSize = true;
            this.Label_Alpha.Location = new System.Drawing.Point(306, 64);
            this.Label_Alpha.Name = "Label_Alpha";
            this.Label_Alpha.Size = new System.Drawing.Size(64, 13);
            this.Label_Alpha.TabIndex = 4;
            this.Label_Alpha.Text = "Alpha 0-128:";
            // 
            // Numeric_Alpha
            // 
            this.Numeric_Alpha.Location = new System.Drawing.Point(309, 80);
            this.Numeric_Alpha.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            this.Numeric_Alpha.Name = "Numeric_Alpha";
            this.Numeric_Alpha.Size = new System.Drawing.Size(91, 20);
            this.Numeric_Alpha.TabIndex = 5;
            this.Numeric_Alpha.Value = new decimal(new int[] { 128, 0, 0, 0 });
            // 
            // Button_AddColour
            // 
            this.Button_AddColour.Location = new System.Drawing.Point(309, 106);
            this.Button_AddColour.Name = "Button_AddColour";
            this.Button_AddColour.Size = new System.Drawing.Size(91, 23);
            this.Button_AddColour.TabIndex = 6;
            this.Button_AddColour.Text = "Add colour...";
            this.Button_AddColour.UseVisualStyleBackColor = true;
            this.Button_AddColour.Click += new System.EventHandler(this.Button_AddColour_Click);
            // 
            // Button_UpdateColour
            // 
            this.Button_UpdateColour.Location = new System.Drawing.Point(309, 135);
            this.Button_UpdateColour.Name = "Button_UpdateColour";
            this.Button_UpdateColour.Size = new System.Drawing.Size(91, 23);
            this.Button_UpdateColour.TabIndex = 7;
            this.Button_UpdateColour.Text = "Update...";
            this.Button_UpdateColour.UseVisualStyleBackColor = true;
            this.Button_UpdateColour.Click += new System.EventHandler(this.Button_UpdateColour_Click);
            // 
            // Button_RemoveColour
            // 
            this.Button_RemoveColour.Location = new System.Drawing.Point(309, 164);
            this.Button_RemoveColour.Name = "Button_RemoveColour";
            this.Button_RemoveColour.Size = new System.Drawing.Size(91, 23);
            this.Button_RemoveColour.TabIndex = 8;
            this.Button_RemoveColour.Text = "Remove";
            this.Button_RemoveColour.UseVisualStyleBackColor = true;
            this.Button_RemoveColour.Click += new System.EventHandler(this.Button_RemoveColour_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(244, 203);
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
            this.Button_Cancel.Location = new System.Drawing.Point(325, 203);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 10;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // ColorDialog_Colour
            // 
            this.ColorDialog_Colour.FullOpen = true;
            // 
            // Frm_ColourCycle
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(412, 238);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Button_RemoveColour);
            this.Controls.Add(this.Button_UpdateColour);
            this.Controls.Add(this.Button_AddColour);
            this.Controls.Add(this.Numeric_Alpha);
            this.Controls.Add(this.Label_Alpha);
            this.Controls.Add(this.ListBox_Colours);
            this.Controls.Add(this.Label_Colours);
            this.Controls.Add(this.Numeric_Speed);
            this.Controls.Add(this.CheckBox_Speed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ColourCycle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colour Cycle";
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Alpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_Speed;
        private System.Windows.Forms.NumericUpDown Numeric_Speed;
        private System.Windows.Forms.Label Label_Colours;
        private System.Windows.Forms.ListBox ListBox_Colours;
        private System.Windows.Forms.Label Label_Alpha;
        private System.Windows.Forms.NumericUpDown Numeric_Alpha;
        private System.Windows.Forms.Button Button_AddColour;
        private System.Windows.Forms.Button Button_UpdateColour;
        private System.Windows.Forms.Button Button_RemoveColour;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.ColorDialog ColorDialog_Colour;
    }
}
