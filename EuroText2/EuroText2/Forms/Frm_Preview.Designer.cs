
namespace EuroText2
{
    partial class Frm_Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Preview));
            this.consoleControl1 = new ConsoleControl.ConsoleControl();
            this.asyncWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // consoleControl1
            // 
            this.consoleControl1.AllowInput = false;
            this.consoleControl1.BackColor = System.Drawing.Color.Black;
            this.consoleControl1.ConsoleBackgroundColor = System.Drawing.Color.Black;
            this.consoleControl1.ConsoleForegroundColor = System.Drawing.Color.LightGray;
            this.consoleControl1.CurrentBackgroundColor = System.Drawing.Color.Black;
            this.consoleControl1.CurrentForegroundColor = System.Drawing.Color.LightGray;
            this.consoleControl1.CursorType = ConsoleControl.CursorTypes.Invisible;
            this.consoleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleControl1.EchoInput = false;
            this.consoleControl1.ForeColor = System.Drawing.Color.LightGray;
            this.consoleControl1.Location = new System.Drawing.Point(0, 0);
            this.consoleControl1.Name = "consoleControl1";
            this.consoleControl1.ShowCursor = true;
            this.consoleControl1.Size = new System.Drawing.Size(646, 377);
            this.consoleControl1.TabIndex = 0;
            this.consoleControl1.Click += new System.EventHandler(this.ConsoleControl1_Click);
            this.consoleControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsoleControl1_KeyDown);
            // 
            // asyncWorker
            // 
            this.asyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AsyncWorker_DoWork);
            // 
            // Frm_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 377);
            this.Controls.Add(this.consoleControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Preview";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preview";
            this.Shown += new System.EventHandler(this.Frm_Preview_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private ConsoleControl.ConsoleControl consoleControl1;
        private System.ComponentModel.BackgroundWorker asyncWorker;
    }
}