
namespace EuroTextEditor
{
    partial class UserControl_TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_TextEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DropDown_Insert = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItem_ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_PageDownButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_InsertButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_LessThan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_MoreThan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_NewLine = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_InsertTextString = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Icons = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItem_ItemIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Button = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItem_FontColour = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_FontType = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Effect = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItem_EffectString = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_FadeIn = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Others = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItem_CenterText = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ShowObjective = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Wait = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EFF = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_EPO = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_GamePad = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuItem_DisableGamepad = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_StopGamepad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ToolButton_Cut = new System.Windows.Forms.ToolStripButton();
            this.ToolButton_Copy = new System.Windows.Forms.ToolStripButton();
            this.ToolButton_Paste = new System.Windows.Forms.ToolStripButton();
            this.ToolButton_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolButton_Undo = new System.Windows.Forms.ToolStripButton();
            this.ToolButton_Redo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolButton_FontSize = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Textbox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDown_Insert,
            this.DropDown_Icons,
            this.DropDown_Button,
            this.DropDown_Effect,
            this.DropDown_Others,
            this.DropDown_GamePad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(529, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "MainMenu";
            // 
            // DropDown_Insert
            // 
            this.DropDown_Insert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DropDown_Insert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ExitButton,
            this.MenuItem_PageDownButton,
            this.MenuItem_InsertButton,
            this.MenuItem_LessThan,
            this.MenuItem_MoreThan,
            this.MenuItem_NewLine,
            this.MenuItem_InsertTextString});
            this.DropDown_Insert.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_Insert.Image")));
            this.DropDown_Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDown_Insert.Name = "DropDown_Insert";
            this.DropDown_Insert.Size = new System.Drawing.Size(49, 22);
            this.DropDown_Insert.Text = "Insert";
            // 
            // MenuItem_ExitButton
            // 
            this.MenuItem_ExitButton.Name = "MenuItem_ExitButton";
            this.MenuItem_ExitButton.Size = new System.Drawing.Size(173, 22);
            this.MenuItem_ExitButton.Text = "Exit Button";
            this.MenuItem_ExitButton.Click += new System.EventHandler(this.MenuItem_ExitButton_Click);
            // 
            // MenuItem_PageDownButton
            // 
            this.MenuItem_PageDownButton.Name = "MenuItem_PageDownButton";
            this.MenuItem_PageDownButton.Size = new System.Drawing.Size(173, 22);
            this.MenuItem_PageDownButton.Text = "Page Down Button";
            this.MenuItem_PageDownButton.Click += new System.EventHandler(this.MenuItem_PageDownButton_Click);
            // 
            // MenuItem_InsertButton
            // 
            this.MenuItem_InsertButton.Name = "MenuItem_InsertButton";
            this.MenuItem_InsertButton.Size = new System.Drawing.Size(173, 22);
            this.MenuItem_InsertButton.Text = "Insert Button";
            this.MenuItem_InsertButton.Click += new System.EventHandler(this.MenuItem_InsertButton_Click);
            // 
            // MenuItem_LessThan
            // 
            this.MenuItem_LessThan.Name = "MenuItem_LessThan";
            this.MenuItem_LessThan.Size = new System.Drawing.Size(173, 22);
            this.MenuItem_LessThan.Text = "Insert Less Than";
            this.MenuItem_LessThan.Click += new System.EventHandler(this.MenuItem_LessThan_Click);
            // 
            // MenuItem_MoreThan
            // 
            this.MenuItem_MoreThan.Name = "MenuItem_MoreThan";
            this.MenuItem_MoreThan.Size = new System.Drawing.Size(173, 22);
            this.MenuItem_MoreThan.Text = "Insert More Than";
            this.MenuItem_MoreThan.Click += new System.EventHandler(this.MenuItem_MoreThan_Click);
            // 
            // MenuItem_NewLine
            // 
            this.MenuItem_NewLine.Name = "MenuItem_NewLine";
            this.MenuItem_NewLine.Size = new System.Drawing.Size(173, 22);
            this.MenuItem_NewLine.Text = "Insert New Line";
            this.MenuItem_NewLine.Click += new System.EventHandler(this.MenuItem_NewLine_Click);
            // 
            // MenuItem_InsertTextString
            // 
            this.MenuItem_InsertTextString.Name = "MenuItem_InsertTextString";
            this.MenuItem_InsertTextString.Size = new System.Drawing.Size(173, 22);
            this.MenuItem_InsertTextString.Text = "Inserts Text String";
            this.MenuItem_InsertTextString.Click += new System.EventHandler(this.MenuItem_InsertTextString_Click);
            // 
            // DropDown_Icons
            // 
            this.DropDown_Icons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DropDown_Icons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ItemIcon});
            this.DropDown_Icons.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_Icons.Image")));
            this.DropDown_Icons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDown_Icons.Name = "DropDown_Icons";
            this.DropDown_Icons.Size = new System.Drawing.Size(48, 22);
            this.DropDown_Icons.Text = "Icons";
            // 
            // MenuItem_ItemIcon
            // 
            this.MenuItem_ItemIcon.Name = "MenuItem_ItemIcon";
            this.MenuItem_ItemIcon.Size = new System.Drawing.Size(156, 22);
            this.MenuItem_ItemIcon.Text = "Insert Item Icon";
            this.MenuItem_ItemIcon.Click += new System.EventHandler(this.MenuItem_ItemIcon_Click);
            // 
            // DropDown_Button
            // 
            this.DropDown_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DropDown_Button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_FontColour,
            this.MenuItem_FontType});
            this.DropDown_Button.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_Button.Image")));
            this.DropDown_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDown_Button.Name = "DropDown_Button";
            this.DropDown_Button.Size = new System.Drawing.Size(44, 22);
            this.DropDown_Button.Text = "Font";
            // 
            // MenuItem_FontColour
            // 
            this.MenuItem_FontColour.Name = "MenuItem_FontColour";
            this.MenuItem_FontColour.Size = new System.Drawing.Size(137, 22);
            this.MenuItem_FontColour.Text = "Font Colour";
            this.MenuItem_FontColour.Click += new System.EventHandler(this.MenuItem_FontColour_Click);
            // 
            // MenuItem_FontType
            // 
            this.MenuItem_FontType.Name = "MenuItem_FontType";
            this.MenuItem_FontType.Size = new System.Drawing.Size(137, 22);
            this.MenuItem_FontType.Text = "Font Type";
            this.MenuItem_FontType.Click += new System.EventHandler(this.MenuItem_FontType_Click);
            // 
            // DropDown_Effect
            // 
            this.DropDown_Effect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DropDown_Effect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_EffectString,
            this.MenuItem_FadeIn});
            this.DropDown_Effect.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_Effect.Image")));
            this.DropDown_Effect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDown_Effect.Name = "DropDown_Effect";
            this.DropDown_Effect.Size = new System.Drawing.Size(55, 22);
            this.DropDown_Effect.Text = "Effects";
            // 
            // MenuItem_EffectString
            // 
            this.MenuItem_EffectString.Name = "MenuItem_EffectString";
            this.MenuItem_EffectString.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_EffectString.Text = "Do Text Effect String";
            this.MenuItem_EffectString.Click += new System.EventHandler(this.MenuItem_EffectString_Click);
            // 
            // MenuItem_FadeIn
            // 
            this.MenuItem_FadeIn.Name = "MenuItem_FadeIn";
            this.MenuItem_FadeIn.Size = new System.Drawing.Size(180, 22);
            this.MenuItem_FadeIn.Text = "Fade In";
            this.MenuItem_FadeIn.Click += new System.EventHandler(this.MenuItem_FadeIn_Click);
            // 
            // DropDown_Others
            // 
            this.DropDown_Others.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DropDown_Others.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_CenterText,
            this.MenuItem_ShowObjective,
            this.MenuItem_Wait,
            this.MenuItem_EFF,
            this.MenuItem_EPO});
            this.DropDown_Others.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_Others.Image")));
            this.DropDown_Others.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDown_Others.Name = "DropDown_Others";
            this.DropDown_Others.Size = new System.Drawing.Size(55, 22);
            this.DropDown_Others.Text = "Others";
            // 
            // MenuItem_CenterText
            // 
            this.MenuItem_CenterText.Name = "MenuItem_CenterText";
            this.MenuItem_CenterText.Size = new System.Drawing.Size(246, 22);
            this.MenuItem_CenterText.Text = "Central justification of text";
            this.MenuItem_CenterText.Click += new System.EventHandler(this.MenuItem_CenterText_Click);
            // 
            // MenuItem_ShowObjective
            // 
            this.MenuItem_ShowObjective.Name = "MenuItem_ShowObjective";
            this.MenuItem_ShowObjective.Size = new System.Drawing.Size(246, 22);
            this.MenuItem_ShowObjective.Text = "Show Objective";
            this.MenuItem_ShowObjective.Click += new System.EventHandler(this.MenuItem_ShowObjective_Click);
            // 
            // MenuItem_Wait
            // 
            this.MenuItem_Wait.Name = "MenuItem_Wait";
            this.MenuItem_Wait.Size = new System.Drawing.Size(246, 22);
            this.MenuItem_Wait.Text = "Wait";
            this.MenuItem_Wait.Click += new System.EventHandler(this.MenuItem_Wait_Click);
            // 
            // MenuItem_EFF
            // 
            this.MenuItem_EFF.Name = "MenuItem_EFF";
            this.MenuItem_EFF.Size = new System.Drawing.Size(246, 22);
            this.MenuItem_EFF.Text = "Ensure that Fast Effect is Enabled";
            this.MenuItem_EFF.Click += new System.EventHandler(this.MenuItem_EFF_Click);
            // 
            // MenuItem_EPO
            // 
            this.MenuItem_EPO.Name = "MenuItem_EPO";
            this.MenuItem_EPO.Size = new System.Drawing.Size(246, 22);
            this.MenuItem_EPO.Text = "Enable Page Buttons Override";
            this.MenuItem_EPO.Click += new System.EventHandler(this.MenuItem_EPO_Click);
            // 
            // DropDown_GamePad
            // 
            this.DropDown_GamePad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DropDown_GamePad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_DisableGamepad,
            this.MenuItem_StopGamepad});
            this.DropDown_GamePad.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_GamePad.Image")));
            this.DropDown_GamePad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDown_GamePad.Name = "DropDown_GamePad";
            this.DropDown_GamePad.Size = new System.Drawing.Size(71, 22);
            this.DropDown_GamePad.Text = "Gamepad";
            // 
            // MenuItem_DisableGamepad
            // 
            this.MenuItem_DisableGamepad.Name = "MenuItem_DisableGamepad";
            this.MenuItem_DisableGamepad.Size = new System.Drawing.Size(225, 22);
            this.MenuItem_DisableGamepad.Text = "Disable all gamepad testing";
            this.MenuItem_DisableGamepad.Click += new System.EventHandler(this.MenuItem_DisableGamepad_Click);
            // 
            // MenuItem_StopGamepad
            // 
            this.MenuItem_StopGamepad.Name = "MenuItem_StopGamepad";
            this.MenuItem_StopGamepad.Size = new System.Drawing.Size(225, 22);
            this.MenuItem_StopGamepad.Text = "Stop Gamepad being hidden";
            this.MenuItem_StopGamepad.Click += new System.EventHandler(this.MenuItem_StopGamepad_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolButton_Cut,
            this.ToolButton_Copy,
            this.ToolButton_Paste,
            this.ToolButton_Delete,
            this.toolStripSeparator1,
            this.ToolButton_Undo,
            this.ToolButton_Redo,
            this.toolStripSeparator2,
            this.ToolButton_FontSize});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(529, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ToolButton_Cut
            // 
            this.ToolButton_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolButton_Cut.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_Cut.Image")));
            this.ToolButton_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_Cut.Name = "ToolButton_Cut";
            this.ToolButton_Cut.Size = new System.Drawing.Size(30, 22);
            this.ToolButton_Cut.Text = "Cut";
            this.ToolButton_Cut.Click += new System.EventHandler(this.ToolButton_Cut_Click);
            // 
            // ToolButton_Copy
            // 
            this.ToolButton_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolButton_Copy.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_Copy.Image")));
            this.ToolButton_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_Copy.Name = "ToolButton_Copy";
            this.ToolButton_Copy.Size = new System.Drawing.Size(39, 22);
            this.ToolButton_Copy.Text = "Copy";
            this.ToolButton_Copy.Click += new System.EventHandler(this.ToolButton_Copy_Click);
            // 
            // ToolButton_Paste
            // 
            this.ToolButton_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolButton_Paste.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_Paste.Image")));
            this.ToolButton_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_Paste.Name = "ToolButton_Paste";
            this.ToolButton_Paste.Size = new System.Drawing.Size(39, 22);
            this.ToolButton_Paste.Text = "Paste";
            this.ToolButton_Paste.Click += new System.EventHandler(this.ToolButton_Paste_Click);
            // 
            // ToolButton_Delete
            // 
            this.ToolButton_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolButton_Delete.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_Delete.Image")));
            this.ToolButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_Delete.Name = "ToolButton_Delete";
            this.ToolButton_Delete.Size = new System.Drawing.Size(44, 22);
            this.ToolButton_Delete.Text = "Delete";
            this.ToolButton_Delete.Click += new System.EventHandler(this.ToolButton_Delete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolButton_Undo
            // 
            this.ToolButton_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolButton_Undo.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_Undo.Image")));
            this.ToolButton_Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_Undo.Name = "ToolButton_Undo";
            this.ToolButton_Undo.Size = new System.Drawing.Size(40, 22);
            this.ToolButton_Undo.Text = "Undo";
            this.ToolButton_Undo.Click += new System.EventHandler(this.ToolButton_Undo_Click);
            // 
            // ToolButton_Redo
            // 
            this.ToolButton_Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolButton_Redo.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_Redo.Image")));
            this.ToolButton_Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_Redo.Name = "ToolButton_Redo";
            this.ToolButton_Redo.Size = new System.Drawing.Size(38, 22);
            this.ToolButton_Redo.Text = "Redo";
            this.ToolButton_Redo.Click += new System.EventHandler(this.ToolButton_Redo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolButton_FontSize
            // 
            this.ToolButton_FontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolButton_FontSize.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_FontSize.Image")));
            this.ToolButton_FontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_FontSize.Name = "ToolButton_FontSize";
            this.ToolButton_FontSize.Size = new System.Drawing.Size(35, 22);
            this.ToolButton_FontSize.Text = "Font";
            this.ToolButton_FontSize.Click += new System.EventHandler(this.ToolButton_FontSize_Click);
            // 
            // Textbox
            // 
            this.Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox.Location = new System.Drawing.Point(0, 53);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(529, 293);
            this.Textbox.TabIndex = 5;
            this.Textbox.Text = "";
            this.Textbox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            this.Textbox.VisibleChanged += new System.EventHandler(this.Textbox_VisibleChanged);
            // 
            // UserControl_TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UserControl_TextEditor";
            this.Size = new System.Drawing.Size(529, 346);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton DropDown_Insert;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ExitButton;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_PageDownButton;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_InsertButton;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_LessThan;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_MoreThan;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_NewLine;
        private System.Windows.Forms.ToolStripDropDownButton DropDown_Icons;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ItemIcon;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ToolButton_Cut;
        private System.Windows.Forms.ToolStripButton ToolButton_Copy;
        private System.Windows.Forms.ToolStripButton ToolButton_Paste;
        private System.Windows.Forms.ToolStripButton ToolButton_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolButton_FontSize;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton ToolButton_Undo;
        private System.Windows.Forms.ToolStripButton ToolButton_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton DropDown_Button;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_FontColour;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_FontType;
        private System.Windows.Forms.ColorDialog colorDialog1;
        protected internal System.Windows.Forms.RichTextBox Textbox;
        private System.Windows.Forms.ToolStripDropDownButton DropDown_Effect;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_EffectString;
        private System.Windows.Forms.ToolStripDropDownButton DropDown_Others;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_CenterText;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ShowObjective;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Wait;
        private System.Windows.Forms.ToolStripDropDownButton DropDown_GamePad;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_DisableGamepad;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_StopGamepad;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_EFF;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_EPO;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_InsertTextString;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_FadeIn;
    }
}
