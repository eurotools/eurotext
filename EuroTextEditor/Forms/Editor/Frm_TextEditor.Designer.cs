
namespace EuroTextEditor
{
    partial class Frm_TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TextEditor));
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemStrip_ResetSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemStrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStrip_Windows = new System.Windows.Forms.ToolStripMenuItem();
            this.UserControl_TextOptions = new EuroTextEditor.Custom_Controls.UserControl_TextOptions();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_OK
            // 
            this.Button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Location = new System.Drawing.Point(600, 549);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 3;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Cancel.Location = new System.Drawing.Point(681, 549);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 4;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(12, 77);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(744, 466);
            this.dockPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStrip_File,
            this.MenuItemStrip_Windows});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemStrip_File
            // 
            this.MenuItemStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStrip_Save,
            this.MenuItemStrip_Separator1,
            this.MenuItemStrip_ResetSettings,
            this.MenuItemStrip_Separator2,
            this.MenuItemStrip_Exit});
            this.MenuItemStrip_File.Name = "MenuItemStrip_File";
            this.MenuItemStrip_File.Size = new System.Drawing.Size(37, 20);
            this.MenuItemStrip_File.Text = "File";
            // 
            // MenuItemStrip_Save
            // 
            this.MenuItemStrip_Save.Name = "MenuItemStrip_Save";
            this.MenuItemStrip_Save.Size = new System.Drawing.Size(147, 22);
            this.MenuItemStrip_Save.Text = "Save";
            this.MenuItemStrip_Save.Click += new System.EventHandler(this.MenuItemStrip_Save_Click);
            // 
            // MenuItemStrip_Separator1
            // 
            this.MenuItemStrip_Separator1.Name = "MenuItemStrip_Separator1";
            this.MenuItemStrip_Separator1.Size = new System.Drawing.Size(144, 6);
            // 
            // MenuItemStrip_ResetSettings
            // 
            this.MenuItemStrip_ResetSettings.Name = "MenuItemStrip_ResetSettings";
            this.MenuItemStrip_ResetSettings.Size = new System.Drawing.Size(147, 22);
            this.MenuItemStrip_ResetSettings.Text = "Reset Settings";
            this.MenuItemStrip_ResetSettings.Click += new System.EventHandler(this.MenuItemStrip_ResetSettings_Click);
            // 
            // MenuItemStrip_Separator2
            // 
            this.MenuItemStrip_Separator2.Name = "MenuItemStrip_Separator2";
            this.MenuItemStrip_Separator2.Size = new System.Drawing.Size(144, 6);
            // 
            // MenuItemStrip_Exit
            // 
            this.MenuItemStrip_Exit.Name = "MenuItemStrip_Exit";
            this.MenuItemStrip_Exit.Size = new System.Drawing.Size(147, 22);
            this.MenuItemStrip_Exit.Text = "Exit";
            this.MenuItemStrip_Exit.Click += new System.EventHandler(this.MenuItemStrip_Exit_Click);
            // 
            // MenuItemStrip_Windows
            // 
            this.MenuItemStrip_Windows.Name = "MenuItemStrip_Windows";
            this.MenuItemStrip_Windows.Size = new System.Drawing.Size(68, 20);
            this.MenuItemStrip_Windows.Text = "Windows";
            this.MenuItemStrip_Windows.DropDownOpening += new System.EventHandler(this.MenuItemStrip_Windows_DropDownOpening);
            // 
            // UserControl_TextOptions
            // 
            this.UserControl_TextOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserControl_TextOptions.Location = new System.Drawing.Point(12, 27);
            this.UserControl_TextOptions.Name = "UserControl_TextOptions";
            this.UserControl_TextOptions.Size = new System.Drawing.Size(744, 44);
            this.UserControl_TextOptions.TabIndex = 5;
            // 
            // Frm_TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 584);
            this.Controls.Add(this.UserControl_TextOptions);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_TextEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Messages Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_TextEditor_FormClosing);
            this.Load += new System.EventHandler(this.Frm_TextEditor_Load);
            this.Shown += new System.EventHandler(this.Frm_TextEditor_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private Custom_Controls.UserControl_TextOptions UserControl_TextOptions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_Save;
        private System.Windows.Forms.ToolStripSeparator MenuItemStrip_Separator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_ResetSettings;
        private System.Windows.Forms.ToolStripSeparator MenuItemStrip_Separator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStrip_Windows;
    }
}