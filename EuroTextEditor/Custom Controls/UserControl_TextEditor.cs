using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_TextEditor : UserControl
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        private readonly string fontColorRegexPattern = @"(?s)(?=(<FC\s+([0-9]+)\s?,\s?([0-9]+)\s?,\s?([0-9]+)\s?>(?<inner>(?>(?!<FC\b|<END FC>).|(?<c>)<FC\b|(?<b-c>)<END FC>)*)(<END FC>|.*)))";
        //private readonly string tagsPattern = @"<.*?>";

        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControl_TextEditor()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void UserControl_TextEditor_Load(object sender, EventArgs e)
        {
            Textbox.AutoWordSelection = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_FontSize_Click(object sender, EventArgs e)
        {
            DialogResult diagResult = fontDialog1.ShowDialog();
            if (diagResult == DialogResult.OK)
            {
                Textbox.SelectAll();
                Textbox.SelectionFont = fontDialog1.Font;
            }
        }

        private void MenuItem_FontType_Click(object sender, EventArgs e)
        {
            //Open selector
            if (File.Exists(GlobalVariables.HashtablesFilePath))
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

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Cut_Click(object sender, EventArgs e)
        {
            Textbox.Cut();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Copy_Click(object sender, EventArgs e)
        {
            Textbox.Copy();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Paste_Click(object sender, EventArgs e)
        {
            Textbox.Paste();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Delete_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Empty;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Undo_Click(object sender, EventArgs e)
        {
            Textbox.Undo();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Redo_Click(object sender, EventArgs e)
        {
            Textbox.Redo();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
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
        private void MenuItem_EffectString_Click(object sender, EventArgs e)
        {
            if (File.Exists(GlobalVariables.HashtablesFilePath))
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
        private void MenuItem_NewLine_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<N>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_InsertButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(GlobalVariables.HashtablesFilePath))
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
        private void MenuItem_ItemIcon_Click(object sender, EventArgs e)
        {
            if (File.Exists(GlobalVariables.HashtablesFilePath))
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

        //-------------------------------------------------------------------------------------------------------------------------------
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
        private void MenuItem_CenterText_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<CNTR>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ShowObjective_Click(object sender, EventArgs e)
        {
            if (File.Exists(GlobalVariables.HashtablesFilePath))
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
        private void MenuItem_InsertTextString_Click(object sender, EventArgs e)
        {
            if (File.Exists(GlobalVariables.HashtablesFilePath))
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

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ShowGamePadButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(GlobalVariables.HashtablesFilePath))
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

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            UpdateWordsInColor();
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
    }
    //-------------------------------------------------------------------------------------------------------------------------------
}
