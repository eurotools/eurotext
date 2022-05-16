using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_TextEditor : DockContent
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        //private readonly string tagsPattern = @"<.*?>";
        private readonly string fontColorRegexPattern = @"(?s)(?=(<FC\s+([0-9]+)\s?,\s?([0-9]+)\s?,\s?([0-9]+)\s?>(?<inner>(?>(?!<FC\b|<END FC>).|(?<c>)<FC\b|(?<b-c>)<END FC>)*)(<END FC>|.*)))";
        private readonly MenuItem formMenuItem;

        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControl_TextEditor(MenuItem parentMainForm)
        {
            InitializeComponent();
            formMenuItem = parentMainForm;

            //Menu Item
            formMenuItem.Click += (se, ev) => { if (IsHidden) { Show(); formMenuItem.Checked = true; } };
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void UserControl_TextEditor_Load(object sender, EventArgs e)
        {
            Textbox.AutoWordSelection = false;
        }

        //-------------------------------------------------------------------------------------------
        //  TOOLBAR OPTIONS
        //-------------------------------------------------------------------------------------------
        private void ToolButton_Cut_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.Cut();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Copy_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.Copy();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Paste_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.Paste();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Delete_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.SelectedText = string.Empty;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Undo_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.Undo();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Redo_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.Redo();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_SelectAll_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.SelectAll();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_FontSize_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = fontDialog1.ShowDialog();
            if (diagResult == DialogResult.OK)
            {
                Textbox.Focus();
                Textbox.SelectAll();
                Textbox.SelectionFont = fontDialog1.Font;
            }
        }

        //-------------------------------------------------------------------------------------------
        //  CONTEXT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_Cut_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.Cut();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Copy_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.Copy();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Paste_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.Paste();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Delete_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.SelectedText = string.Empty;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Undo_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.Undo();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Redo_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.Redo();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_SelectAll_Click(object sender, EventArgs e)
        {
            Textbox.Focus();
            Textbox.SelectAll();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Font_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = fontDialog1.ShowDialog();
            if (diagResult == DialogResult.OK)
            {
                Textbox.Focus();
                Textbox.SelectAll();
                Textbox.SelectionFont = fontDialog1.Font;
            }
        }

        //-------------------------------------------------------------------------------------------
        //  TOOLBAR 1 - INSERT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_ExitButton_Click(object sender, EventArgs e)
        {
            if (!Textbox.Text.EndsWith("<E>"))
            {
                Textbox.Text = string.Join("", Textbox.Text, "<E>");
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_PageDownButton_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<P>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_InsertButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h")))
            {
                Frm_TextEditor_Buttons buttonsForm = new Frm_TextEditor_Buttons();
                if (buttonsForm.ShowDialog() == DialogResult.OK)
                {
                    //Add tags
                    string replacedText = buttonsForm.ButtonsText;
                    Textbox.SelectedText = replacedText;
                }
            }
            else
            {
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_LessThan_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<LT>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_MoreThan_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<MT>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_NewLine_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<N>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_InsertTextString_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h")))
            {
                //Open selector
                Frm_HashCodesSelector selector = new Frm_HashCodesSelector("HT_Objective", true)
                {
                    Text = "Inserts Text String"
                };
                if (selector.ShowDialog() == DialogResult.OK)
                {
                    Textbox.SelectedText = string.Join("", "<IS ", selector.SelectedHashCode, ">");
                }
            }
            else
            {
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------
        //  TOOLBAR 1 - ICONS MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_ItemIcon_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h")))
            {
                Frm_InsertIcon buttonsForm = new Frm_InsertIcon("HT_Texture", true);
                if (buttonsForm.ShowDialog() == DialogResult.OK)
                {
                    //Add tags
                    string replacedText = buttonsForm.SelectedIcon;
                    Textbox.SelectedText = replacedText;
                }
            }
            else
            {
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------
        //  TOOLBAR 1 - FONT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_FontColour_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = colorDialog1.ShowDialog();
            if (diagResult == DialogResult.OK)
            {
                //Add tags
                string replacedText;
                if (Textbox.SelectedText.Length > 0)
                {
                    replacedText = string.Format("<FC {0},{1},{2}>{3}<END FC>", colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B, Textbox.SelectedText);
                }
                else
                {
                    replacedText = string.Format("<FC {0},{1},{2}>{3}", colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B, Textbox.SelectedText);
                }

                Textbox.SelectedText = replacedText;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_FontType_Click(object sender, EventArgs e)
        {
            //Open selector
            if (File.Exists(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h")))
            {
                Frm_HashCodesSelector selector = new Frm_HashCodesSelector("HT_Font", true)
                {
                    Text = "Font Type"
                };
                if (selector.ShowDialog() == DialogResult.OK)
                {
                    //Add tags
                    if (Textbox.SelectedText.Length > 0)
                    {
                        Textbox.SelectedText = string.Join("", "<FT ", selector.SelectedHashCode, ">", Textbox.SelectedText, "<END FT>");
                    }
                    else
                    {
                        string replacedText = string.Join("", "<FT ", selector.SelectedHashCode, ">");
                        Textbox.SelectedText = replacedText;
                    }
                }
            }
            else
            {
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------
        //  TOOLBAR 1 - EFFECTS MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_EffectString_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h")))
            {
                //Open selector
                Frm_HashCodesSelector selector = new Frm_HashCodesSelector("HT_Text", true)
                {
                    Text = "Insert Text Effect"
                };
                if (selector.ShowDialog() == DialogResult.OK)
                {
                    string replacedText = string.Join("", "<ES ", selector.SelectedHashCode, ">");
                    Textbox.SelectedText = replacedText;
                }
            }
            else
            {
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_FadeIn_Click(object sender, EventArgs e)
        {
            Frm_FadeIn selector = new Frm_FadeIn();
            if (selector.ShowDialog() == DialogResult.OK)
            {
                string replacedText;
                if (Textbox.SelectedText.Length > 0)
                {
                    replacedText = string.Format("{0}{1}{2}", selector.fadeInEffect, Textbox.SelectedText, "<END FI>");
                }
                else
                {
                    replacedText = string.Join("", selector.fadeInEffect, Textbox.SelectedText);
                }

                Textbox.SelectedText = replacedText;
            }
        }

        //-------------------------------------------------------------------------------------------
        //  TOOLBAR 1 - GAMEPAD MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_DisableGamepad_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<DP>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_StopGamepad_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<DHP>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ShowGamePadButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h")))
            {
                //Open selector
                Frm_HashCodesSelector selector = new Frm_HashCodesSelector("HT_Action", true)
                {
                    Text = "Show Gamepad Button"
                };
                if (selector.ShowDialog() == DialogResult.OK)
                {
                    Textbox.SelectedText = string.Join("", "<SB ", selector.SelectedHashCode, ">");
                }
            }
            else
            {
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------
        //  TOOLBAR 1 - OTHERS MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_CenterText_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<CNTR>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ShowObjective_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(GlobalVariables.CurrentProject.EuroLandHahCodesServPath, "hashcodes.h")))
            {
                //Open selector
                Frm_HashCodesSelector selector = new Frm_HashCodesSelector("HT_Objective", true)
                {
                    Text = "Show Objective"
                };
                if (selector.ShowDialog() == DialogResult.OK)
                {
                    Textbox.SelectedText = string.Join("", "<SO ", selector.SelectedHashCode, ">");
                }
            }
            else
            {
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Wait_Click(object sender, EventArgs e)
        {
            //Open selector
            if (!Textbox.Text.EndsWith("<W "))
            {
                Frm_WaitTime selector = new Frm_WaitTime();
                if (selector.ShowDialog() == DialogResult.OK)
                {
                    Textbox.Text = string.Join("", Textbox.Text, "<W ", selector.TimeToWait, ">");
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_EFF_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<EFF>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_EPO_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<EPO>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------
        //  EVENTS
        //-------------------------------------------------------------------------------------------
        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            UpdateWordsInColor();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        public void UpdateWordsInColor()
        {
            int prevPosition = Textbox.SelectionStart;

            //Reset words colors
            Textbox.Select(0, Textbox.TextLength);
            Textbox.SelectionColor = Textbox.ForeColor;

            //Update words colors
            MatchCollection stringMatches = Regex.Matches(Textbox.Text, fontColorRegexPattern);
            try
            {
                foreach (Match match in stringMatches)
                {
                    int startTagEnd = match.Groups[1].Value.IndexOf('>') + 1;
                    int colorTextLength = match.Groups[1].Value.IndexOf("<END FC>", startTagEnd);
                    if (colorTextLength == -1)
                    {
                        colorTextLength = match.Groups[1].Value.IndexOf("<FC ", startTagEnd);
                        if (colorTextLength == -1)
                        {
                            colorTextLength = match.Groups[1].Value.Length;
                        }
                    }

                    Textbox.Select(match.Groups[1].Index + startTagEnd, colorTextLength - startTagEnd);
                    Textbox.SelectionColor = Color.FromArgb(1, Convert.ToInt32(match.Groups[2].Value), Convert.ToInt32(match.Groups[3].Value), Convert.ToInt32(match.Groups[4].Value));
                }
            }
            catch (Exception ex)
            {
                Textbox.Undo();
                MessageBox.Show(ex.Message, "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Textbox.Select(Textbox.TextLength, 0);
            Textbox.SelectionColor = Textbox.ForeColor;

            //Tags
            /*stringMatches = Regex.Matches(Textbox.Text, tagsPattern);
            foreach (Match match in stringMatches)
            {
                Textbox.Select(match.Index, match.Length);
                Textbox.SelectionFont = new Font(Textbox.Font, FontStyle.Bold | FontStyle.Italic);
            }
            Textbox.Select(Textbox.TextLength, 0);
            Textbox.SelectionFont = new Font(Textbox.Font, FontStyle.Regular);*/

            //Clear selection
            Textbox.DeselectAll();
            Textbox.SelectionStart = prevPosition;
            Textbox.Focus();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Textbox_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                UpdateWordsInColor();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_TimerTest_Click(object sender, EventArgs e)
        {
            int charCount = 0, timeFor30;
            decimal calcTime;

            bool insideFormatter = false;
            for (int i = 0; i < Textbox.Text.Length; i++)
            {
                if (Textbox.Text[i] == '<')
                {
                    insideFormatter = true;
                }
                if (!insideFormatter && Textbox.Text[i] != ' ')
                {
                    charCount++;
                }
                if (Textbox.Text[i] == '>')
                {
                    insideFormatter = false;
                }
            }

            //Do calculations
            calcTime = decimal.Divide(charCount, 30);
            timeFor30 = (int)Math.Round(calcTime * 30);

            //Show info
            MessageBox.Show(string.Join(" ", "Character count =", charCount, "\nTeletype time =", calcTime.ToString("0.00000000"), "Seconds", "\nFrames =", timeFor30), "EuroText", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void UserControl_TextEditor_VisibleChanged(object sender, EventArgs e)
        {
            if (IsHidden)
            {
                formMenuItem.Checked = false;
            }
        }
    }
    //-------------------------------------------------------------------------------------------------------------------------------
}
