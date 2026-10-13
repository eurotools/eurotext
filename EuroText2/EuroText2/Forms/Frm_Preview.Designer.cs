namespace EuroText2
{
    partial class Frm_Preview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Preview));
            this.Panel_Toolbar = new System.Windows.Forms.Panel();
            this.Label_Font = new System.Windows.Forms.Label();
            this.Button_Font = new System.Windows.Forms.Button();
            this.Label_SpeedSuffix = new System.Windows.Forms.Label();
            this.Numeric_TeletypeSpeed = new System.Windows.Forms.NumericUpDown();
            this.Label_Speed = new System.Windows.Forms.Label();
            this.Label_Page = new System.Windows.Forms.Label();
            this.Button_NextPage = new System.Windows.Forms.Button();
            this.Button_PreviousPage = new System.Windows.Forms.Button();
            this.Button_Restart = new System.Windows.Forms.Button();
            this.Button_PlayPause = new System.Windows.Forms.Button();
            this.Timer_Animation = new System.Windows.Forms.Timer(this.components);
            this.FontDialog_Preview = new System.Windows.Forms.FontDialog();
            this.PreviewCanvas = new EuroText2.EngineXPreviewControl();
            this.Panel_Toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_TeletypeSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Toolbar
            // 
            this.Panel_Toolbar.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_Toolbar.Controls.Add(this.Label_Font);
            this.Panel_Toolbar.Controls.Add(this.Button_Font);
            this.Panel_Toolbar.Controls.Add(this.Label_SpeedSuffix);
            this.Panel_Toolbar.Controls.Add(this.Numeric_TeletypeSpeed);
            this.Panel_Toolbar.Controls.Add(this.Label_Speed);
            this.Panel_Toolbar.Controls.Add(this.Label_Page);
            this.Panel_Toolbar.Controls.Add(this.Button_NextPage);
            this.Panel_Toolbar.Controls.Add(this.Button_PreviousPage);
            this.Panel_Toolbar.Controls.Add(this.Button_Restart);
            this.Panel_Toolbar.Controls.Add(this.Button_PlayPause);
            this.Panel_Toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Panel_Toolbar.Name = "Panel_Toolbar";
            this.Panel_Toolbar.Size = new System.Drawing.Size(880, 40);
            this.Panel_Toolbar.TabIndex = 0;
            // 
            // Label_Font
            // 
            this.Label_Font.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Font.Location = new System.Drawing.Point(739, 13);
            this.Label_Font.Name = "Label_Font";
            this.Label_Font.Size = new System.Drawing.Size(129, 17);
            this.Label_Font.TabIndex = 9;
            this.Label_Font.Text = "Verdana, 16 pt, Regular";
            // 
            // Button_Font
            // 
            this.Button_Font.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Font.Location = new System.Drawing.Point(658, 8);
            this.Button_Font.Name = "Button_Font";
            this.Button_Font.Size = new System.Drawing.Size(75, 23);
            this.Button_Font.TabIndex = 8;
            this.Button_Font.Text = "Font...";
            this.Button_Font.UseVisualStyleBackColor = true;
            this.Button_Font.Click += new System.EventHandler(this.Button_Font_Click);
            // 
            // Label_SpeedSuffix
            // 
            this.Label_SpeedSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_SpeedSuffix.AutoSize = true;
            this.Label_SpeedSuffix.Location = new System.Drawing.Point(615, 13);
            this.Label_SpeedSuffix.Name = "Label_SpeedSuffix";
            this.Label_SpeedSuffix.Size = new System.Drawing.Size(38, 13);
            this.Label_SpeedSuffix.TabIndex = 7;
            this.Label_SpeedSuffix.Text = "char/s";
            // 
            // Numeric_TeletypeSpeed
            // 
            this.Numeric_TeletypeSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Numeric_TeletypeSpeed.Location = new System.Drawing.Point(558, 10);
            this.Numeric_TeletypeSpeed.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.Numeric_TeletypeSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numeric_TeletypeSpeed.Name = "Numeric_TeletypeSpeed";
            this.Numeric_TeletypeSpeed.Size = new System.Drawing.Size(51, 20);
            this.Numeric_TeletypeSpeed.TabIndex = 6;
            this.Numeric_TeletypeSpeed.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Numeric_TeletypeSpeed.ValueChanged += new System.EventHandler(this.Numeric_TeletypeSpeed_ValueChanged);
            // 
            // Label_Speed
            // 
            this.Label_Speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Speed.AutoSize = true;
            this.Label_Speed.Location = new System.Drawing.Point(468, 13);
            this.Label_Speed.Name = "Label_Speed";
            this.Label_Speed.Size = new System.Drawing.Size(83, 13);
            this.Label_Speed.TabIndex = 5;
            this.Label_Speed.Text = "Teletype speed:";
            // 
            // Label_Page
            // 
            this.Label_Page.AutoSize = true;
            this.Label_Page.Location = new System.Drawing.Point(298, 13);
            this.Label_Page.Name = "Label_Page";
            this.Label_Page.Size = new System.Drawing.Size(52, 13);
            this.Label_Page.TabIndex = 4;
            this.Label_Page.Text = "Page 1/1";
            // 
            // Button_NextPage
            // 
            this.Button_NextPage.Location = new System.Drawing.Point(251, 8);
            this.Button_NextPage.Name = "Button_NextPage";
            this.Button_NextPage.Size = new System.Drawing.Size(41, 23);
            this.Button_NextPage.TabIndex = 3;
            this.Button_NextPage.Text = ">";
            this.Button_NextPage.UseVisualStyleBackColor = true;
            this.Button_NextPage.Click += new System.EventHandler(this.Button_NextPage_Click);
            // 
            // Button_PreviousPage
            // 
            this.Button_PreviousPage.Location = new System.Drawing.Point(204, 8);
            this.Button_PreviousPage.Name = "Button_PreviousPage";
            this.Button_PreviousPage.Size = new System.Drawing.Size(41, 23);
            this.Button_PreviousPage.TabIndex = 2;
            this.Button_PreviousPage.Text = "<";
            this.Button_PreviousPage.UseVisualStyleBackColor = true;
            this.Button_PreviousPage.Click += new System.EventHandler(this.Button_PreviousPage_Click);
            // 
            // Button_Restart
            // 
            this.Button_Restart.Location = new System.Drawing.Point(93, 8);
            this.Button_Restart.Name = "Button_Restart";
            this.Button_Restart.Size = new System.Drawing.Size(85, 23);
            this.Button_Restart.TabIndex = 1;
            this.Button_Restart.Text = "Restart";
            this.Button_Restart.UseVisualStyleBackColor = true;
            this.Button_Restart.Click += new System.EventHandler(this.Button_Restart_Click);
            // 
            // Button_PlayPause
            // 
            this.Button_PlayPause.Location = new System.Drawing.Point(12, 8);
            this.Button_PlayPause.Name = "Button_PlayPause";
            this.Button_PlayPause.Size = new System.Drawing.Size(75, 23);
            this.Button_PlayPause.TabIndex = 0;
            this.Button_PlayPause.Text = "Pause";
            this.Button_PlayPause.UseVisualStyleBackColor = true;
            this.Button_PlayPause.Click += new System.EventHandler(this.Button_PlayPause_Click);
            // 
            // Timer_Animation
            // 
            this.Timer_Animation.Interval = 16;
            this.Timer_Animation.Tick += new System.EventHandler(this.Timer_Animation_Tick);
            // 
            // FontDialog_Preview
            // 
            this.FontDialog_Preview.Font = new System.Drawing.Font("Verdana", 16F);
            this.FontDialog_Preview.FontMustExist = true;
            this.FontDialog_Preview.ShowEffects = false;
            // 
            // PreviewCanvas
            // 
            this.PreviewCanvas.BackColor = System.Drawing.Color.Black;
            this.PreviewCanvas.CharactersPerSecond = 30;
            this.PreviewCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewCanvas.ForeColor = System.Drawing.Color.White;
            this.PreviewCanvas.Location = new System.Drawing.Point(0, 40);
            this.PreviewCanvas.Name = "PreviewCanvas";
            this.PreviewCanvas.PreviewFont = new System.Drawing.Font("Verdana", 14.25F);
            this.PreviewCanvas.Size = new System.Drawing.Size(880, 581);
            this.PreviewCanvas.TabIndex = 1;
            this.PreviewCanvas.Click += new System.EventHandler(this.PreviewCanvas_Click);
            // 
            // Frm_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 621);
            this.Controls.Add(this.PreviewCanvas);
            this.Controls.Add(this.Panel_Toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "Frm_Preview";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EngineX Text Preview";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Preview_FormClosed);
            this.Shown += new System.EventHandler(this.Frm_Preview_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Preview_KeyDown);
            this.Panel_Toolbar.ResumeLayout(false);
            this.Panel_Toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_TeletypeSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Toolbar;
        private System.Windows.Forms.Button Button_PlayPause;
        private System.Windows.Forms.Button Button_Restart;
        private System.Windows.Forms.Button Button_PreviousPage;
        private System.Windows.Forms.Button Button_NextPage;
        private System.Windows.Forms.Label Label_Page;
        private System.Windows.Forms.Label Label_Speed;
        private System.Windows.Forms.NumericUpDown Numeric_TeletypeSpeed;
        private System.Windows.Forms.Label Label_SpeedSuffix;
        private System.Windows.Forms.Button Button_Font;
        private System.Windows.Forms.Label Label_Font;
        private EngineXPreviewControl PreviewCanvas;
        private System.Windows.Forms.Timer Timer_Animation;
        private System.Windows.Forms.FontDialog FontDialog_Preview;
    }
}
