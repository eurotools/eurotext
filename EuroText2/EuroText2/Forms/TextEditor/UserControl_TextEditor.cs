using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_TextEditor : DockContent
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControl_TextEditor()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void UserControl_TextEditor_Load(object sender, EventArgs e)
        {
            Textbox.AutoWordSelection = false;
            MenuItem_Factor.Text = Convert.ToString(Textbox.ZoomFactor * 100);
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
            if (Textbox.CanUndo)
            {
                Textbox.Undo();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Redo_Click(object sender, EventArgs e)
        {
            if (Textbox.CanRedo)
            {
                Textbox.Redo();
            }
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
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void MenuItem_Tab_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<T>", Textbox.SelectedText);
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
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------
        //  TOOLBAR 1 - FONT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_FontColour_Click(object sender, EventArgs e)
        {
            //Load custom colors
            List<int> savedColors = new List<int>();
            IniFile applicationIni = new IniFile(GlobalVariables.EuroTextIni);
            for (int i = 0; i < 16; i++)
            {
                string color = applicationIni.Read("Col" + i, "CustomColors");
                if (!string.IsNullOrEmpty(color))
                {
                    savedColors.Add(Convert.ToInt32(color));
                }
            }

            //Show color picker
            colorPicker.CustomColors = savedColors.ToArray();
            DialogResult diagResult = colorPicker.ShowDialog();
            if (diagResult == DialogResult.OK)
            {
                //Add tags
                string replacedText;
                if (Textbox.SelectedText.Length > 0)
                {
                    replacedText = string.Format("<FC {0},{1},{2}>{3}<END FC>", colorPicker.Color.R, colorPicker.Color.G, colorPicker.Color.B, Textbox.SelectedText);
                }
                else
                {
                    replacedText = string.Format("<FC {0},{1},{2}>{3}", colorPicker.Color.R, colorPicker.Color.G, colorPicker.Color.B, Textbox.SelectedText);
                }
                Textbox.SelectedText = replacedText;

                //Save custom colors
                for (int i = 0; i < colorPicker.CustomColors.Length; i++)
                {
                    applicationIni.Write("Col" + i, colorPicker.CustomColors[i].ToString(), "CustomColors");
                }
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
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_SineWave_Click(object sender, EventArgs e)
        {
            Frm_SineWave selector = new Frm_SineWave();
            if (selector.ShowDialog() == DialogResult.OK)
            {
                string replacedText;
                if (Textbox.SelectedText.Length > 0)
                {
                    replacedText = string.Format("{0}{1}{2}", selector.fadeInEffect, Textbox.SelectedText, "<END SW>");
                }
                else
                {
                    replacedText = string.Join("", selector.fadeInEffect, Textbox.SelectedText);
                }

                Textbox.SelectedText = replacedText;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ShakeyText_Click(object sender, EventArgs e)
        {
            Frm_ShakeyText selector = new Frm_ShakeyText();
            if (selector.ShowDialog() == DialogResult.OK)
            {
                string replacedText;
                if (Textbox.SelectedText.Length > 0)
                {
                    replacedText = string.Format("{0}{1}{2}", selector.fadeInEffect, Textbox.SelectedText, "<END ST>");
                }
                else
                {
                    replacedText = string.Join("", selector.fadeInEffect, Textbox.SelectedText);
                }

                Textbox.SelectedText = replacedText;
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
        private void MenuItem_Fountain_Click(object sender, EventArgs e)
        {
            Frm_Fountain fountain = new Frm_Fountain();
            if (fountain.ShowDialog() == DialogResult.OK)
            {
                string replacedText;
                if (Textbox.SelectedText.Length > 0)
                {
                    replacedText = string.Format("{0}{1}{2}", fountain.fountainEffect, Textbox.SelectedText, "<END FI>");
                }
                else
                {
                    replacedText = string.Join("", fountain.fountainEffect, Textbox.SelectedText);
                }

                Textbox.SelectedText = replacedText;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_EnsureFastEffect_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<EFF>", Textbox.SelectedText);
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
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Hashtable file not found, please specify the file path under the 'Settings' menu.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void MenuItem_EPO_Click(object sender, EventArgs e)
        {
            Textbox.SelectedText = string.Join("", "<EPO>", Textbox.SelectedText);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_TextCarrot_Click(object sender, EventArgs e)
        {
            Frm_TextCarrot selector = new Frm_TextCarrot();
            if (selector.ShowDialog() == DialogResult.OK)
            {
                string replacedText = string.Join("", selector.carrotText, Textbox.SelectedText);
                Textbox.SelectedText = replacedText;
            }
        }

        //-------------------------------------------------------------------------------------------
        //  EVENTS
        //-------------------------------------------------------------------------------------------
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
            MessageBox.Show(string.Join(" ", "Character count =", charCount, "\nTeletype time =", calcTime.ToString("0.00000000"), "Seconds", "\nFrames =", timeFor30), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_ZoomIn_Click(object sender, EventArgs e)
        {
            if (Textbox.ZoomFactor < 64.0f - 0.20f)
            {
                Textbox.ZoomFactor += 0.20f;
                MenuItem_Factor.Text = string.Format("{0:F0}", Textbox.ZoomFactor * 100);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_ZoomOut_Click(object sender, EventArgs e)
        {
            if (Textbox.ZoomFactor > 0.16f + 0.20f)
            {
                Textbox.ZoomFactor -= 0.20f;
                MenuItem_Factor.Text = string.Format("{0:F0}", Textbox.ZoomFactor * 100);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Factor_Leave(object sender, EventArgs e)
        {
            try
            {
                Textbox.ZoomFactor = Convert.ToSingle(MenuItem_Factor.Text) / 100;
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid number", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MenuItem_Factor.Focus();
                MenuItem_Factor.SelectAll();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Enter valid number", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MenuItem_Factor.Focus();
                MenuItem_Factor.SelectAll();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Zoom factor should be between 20% and 6400%", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MenuItem_Factor.Focus();
                MenuItem_Factor.SelectAll();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ToolButton_Preview_Click(object sender, EventArgs e)
        {
            Frm_Preview previewForm = new Frm_Preview(Textbox.Text);
            previewForm.ShowDialog();
        }
    }
    //-------------------------------------------------------------------------------------------------------------------------------
}
