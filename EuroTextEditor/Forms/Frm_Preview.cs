using ConsoleControl;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Preview : Form
    {
        private readonly string textToPreview;
        private bool disableTeletype = false;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_Preview(string textToShow)
        {
            InitializeComponent();

            textToPreview = textToShow;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_Preview_Shown(object sender, EventArgs e)
        {
            if (!asyncWorker.IsBusy)
            {
                asyncWorker.RunWorkerAsync();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void AsyncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool insideTag = false, centerText = false;
            string tagName = string.Empty;
            int carrotPosition = 2;

            for (int i = 0; i < textToPreview.Length; i++)
            {
                //We entered in a tag, get chars
                if (textToPreview[i] == '<')
                {
                    insideTag = true;
                }

                //Get tag
                if (insideTag)
                {
                    tagName += textToPreview[i];
                }

                //Print "normal" chars
                if (!insideTag)
                {
                    consoleControl1.Write(textToPreview[i]);
                    if (!disableTeletype)
                    {
                        Thread.Sleep(30);
                    }
                }

                //We exited from a tag, check it
                if (textToPreview[i] == '>')
                {
                    if (tagName.Equals("<N>"))
                    {
                        Location currentPosition = consoleControl1.GetCursorPosition();
                        consoleControl1.SetCursorPosition(currentPosition.Row + 1, GetStartColumnCenter(i, centerText));
                    }
                    if (tagName.StartsWith("<PC 1>"))
                    {
                        carrotPosition = 40;
                    }
                    if (tagName.StartsWith("<B"))
                    {
                        Location currentPosition = consoleControl1.GetCursorPosition();
                        consoleControl1.SetCursorPosition(currentPosition.Row, GetStartColumnCenter(i, centerText) + carrotPosition);
                        consoleControl1.Write("•");
                        carrotPosition = 2;
                    }
                    if (tagName.StartsWith("<FC "))
                    {
                        Match foreColor = Regex.Match(tagName, @"<FC\s(\d+),\s?(\d+),\s?(\d+)\s?>");
                        int red = Math.Min(Convert.ToInt32(foreColor.Groups[1].Value) * 2, 255);
                        int green = Math.Min(Convert.ToInt32(foreColor.Groups[2].Value) * 2, 255);
                        int blue = Math.Min(Convert.ToInt32(foreColor.Groups[3].Value) * 2, 255);
                        consoleControl1.CurrentForegroundColor = Color.FromArgb(red, green, blue);
                    }
                    if (tagName.Equals("<END FC>"))
                    {
                        consoleControl1.CurrentForegroundColor = consoleControl1.ForeColor;
                    }
                    if (tagName.Equals("<MT>"))
                    {
                        consoleControl1.Write(">");
                    }
                    if (tagName.Equals("<LT>"))
                    {
                        consoleControl1.Write("<");
                    }
                    if (tagName.Equals("<P>"))
                    {
                        Invoke(new Action(() =>
                        {
                            DialogResult diagResult = MessageBox.Show("Do you want to show the next page?", "EuroText", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (diagResult == DialogResult.Yes)
                            {
                                disableTeletype = false;
                                consoleControl1.Clear();
                            }
                            else
                            {
                                Close();
                            }
                        }));
                    }
                    if (tagName.Equals("<CNTR>"))
                    {
                        centerText = true;

                        Location currentPosition = consoleControl1.GetCursorPosition();
                        consoleControl1.SetCursorPosition(currentPosition.Row, GetStartColumnCenter(i, centerText));
                    }
                    if (tagName.Equals("<END CNTR>"))
                    {
                        centerText = false;

                        Location currentPosition = consoleControl1.GetCursorPosition();
                        consoleControl1.SetCursorPosition(currentPosition.Row, GetStartColumnCenter(i, centerText));
                    }
                    if (tagName.Equals("<END TT>"))
                    {
                        disableTeletype = true;
                    }
                    if (tagName.StartsWith("<SO "))
                    {
                        consoleControl1.Write("<Objective Value>");
                    }


                    tagName = string.Empty;
                    insideTag = false;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ConsoleControl1_Click(object sender, EventArgs e)
        {
            disableTeletype = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ConsoleControl1_KeyDown(object sender, KeyEventArgs e)
        {
            disableTeletype = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private int GetStartColumnCenter(int startPos, bool centerText)
        {
            int consoleMiddle = 40;
            int textStartPos = 0;
            if (centerText)
            {
                textStartPos = Clamp(consoleMiddle - (GetRemainingLength(startPos) / 2), 0, 80);
            }
            return textStartPos;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private int Clamp(int value, int min, int max)
        {
            if (value < min) { return min; }
            if (value > max) { return max; }
            return value;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private int GetRemainingLength(int startpos)
        {
            int remainingLength = 0;
            string tagName = string.Empty;
            bool betweenTag = false;

            for (int i = startpos; i < textToPreview.Length; i++)
            {
                if (textToPreview[i] == '<')
                {
                    betweenTag = true;
                }
                if (betweenTag)
                {
                    tagName += textToPreview[i];
                }
                if (!betweenTag)
                {
                    remainingLength += 1;
                }
                if (textToPreview[i] == '>')
                {
                    betweenTag = false;
                    if (tagName.Equals("<P>"))
                    {
                        break;
                    }
                    if (tagName.Equals("<N>"))
                    {
                        break;
                    }
                    tagName = string.Empty;
                }
            }

            return remainingLength;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
