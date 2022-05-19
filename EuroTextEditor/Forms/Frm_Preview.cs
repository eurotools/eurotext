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
        private void asyncWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool insideTag = false;
            string tagName = string.Empty;

            for (int i = 0; i < textToPreview.Length; i++)
            {
                if (textToPreview[i] == '<')
                {
                    insideTag = true;
                }

                if (insideTag)
                {
                    tagName += textToPreview[i];
                }

                if (!insideTag)
                {
                    consoleControl1.Write(textToPreview[i]);
                    if (!disableTeletype)
                    {
                        Thread.Sleep(30);
                    }
                }

                if (textToPreview[i] == '>')
                {
                    if (tagName.Equals("<N>"))
                    {
                        Location currentPosition = consoleControl1.GetCursorPosition();
                        consoleControl1.SetCursorPosition(currentPosition.Row + 1, 0);
                    }
                    if (tagName.StartsWith("<B"))
                    {
                        Location currentPosition = consoleControl1.GetCursorPosition();
                        consoleControl1.SetCursorPosition(currentPosition.Row, 2);
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
                        }));
                    }

                    tagName = string.Empty;
                    insideTag = false;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void consoleControl1_Click(object sender, EventArgs e)
        {
            disableTeletype = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void consoleControl1_KeyDown(object sender, KeyEventArgs e)
        {
            disableTeletype = true;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
