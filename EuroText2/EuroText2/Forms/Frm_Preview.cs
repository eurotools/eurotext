using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EuroText2
{
    public partial class Frm_Preview : Form
    {
        private readonly string textToPreview;
        private readonly string previewLanguage;
        private readonly Stopwatch playbackWatch = new Stopwatch();
        private long playbackOffset;
        private bool playing;

        private static readonly Regex EffectStringTag = new Regex(@"<ES\s+([A-Za-z0-9_]+)>", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private static readonly Dictionary<string, string> BuiltInEffectStrings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "HT_Text_ES_S_HelpText", "<FC 60,98,57>" },
            { "HT_Text_ES_E_HelpText", "<END FC>" }
        };

        public Frm_Preview(string textToShow, string language = "")
        {
            previewLanguage = language ?? string.Empty;
            textToPreview = ExpandEffectStrings(textToShow ?? string.Empty);
            InitializeComponent();
            FontDialog_Preview.Font = new Font("Verdana", 12.0f, FontStyle.Bold, GraphicsUnit.Point);
            PreviewCanvas.PreviewFont = FontDialog_Preview.Font;
            PreviewCanvas.CharactersPerSecond = Convert.ToInt32(Numeric_TeletypeSpeed.Value);
            PreviewCanvas.SetText(textToPreview);
            UpdatePageControls();
            UpdateFontLabel();
        }

        private string ExpandEffectStrings(string sourceText)
        {
            Dictionary<string, string> resolvedEffects = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            string expanded = sourceText;

            // Effect strings can themselves contain another <ES> reference. A
            // bounded expansion prevents malformed project data from cycling.
            for (int depth = 0; depth < 16 && EffectStringTag.IsMatch(expanded); depth++)
            {
                bool replacedAny = false;
                expanded = EffectStringTag.Replace(expanded, match =>
                {
                    string hashCode = match.Groups[1].Value;
                    string definition;
                    if (!resolvedEffects.TryGetValue(hashCode, out definition))
                    {
                        definition = ReadEffectString(hashCode);
                        resolvedEffects[hashCode] = definition;
                    }

                    if (string.IsNullOrEmpty(definition)) return match.Value;
                    replacedAny = true;
                    return definition;
                });

                if (!replacedAny) break;
            }

            return expanded;
        }

        private string ReadEffectString(string hashCode)
        {
            string definition = ReadEffectStringFromProject(hashCode);
            if (!string.IsNullOrEmpty(definition)) return definition;

            BuiltInEffectStrings.TryGetValue(hashCode, out definition);
            return definition ?? string.Empty;
        }

        private string ReadEffectStringFromProject(string hashCode)
        {
            string[] projectRoots =
            {
                GlobalVariables.CurrentProject.MessagesDirectory,
                GlobalVariables.WorkingDirectory
            };

            foreach (string projectRoot in projectRoots)
            {
                if (string.IsNullOrWhiteSpace(projectRoot)) continue;
                string effectFile = Path.Combine(projectRoot, "Messages", hashCode + ".etf");
                if (!File.Exists(effectFile)) continue;

                try
                {
                    EuroText_TextFile effectText = new ETXML_Reader().ReadTextFile(effectFile);
                    string definition;
                    if (!string.IsNullOrEmpty(previewLanguage) && effectText.Messages.TryGetValue(previewLanguage, out definition))
                    {
                        return definition;
                    }

                    foreach (KeyValuePair<string, string> message in effectText.Messages)
                    {
                        return message.Value;
                    }
                }
                catch (IOException)
                {
                    // Keep the preview usable if a project file is being saved.
                }
                catch (System.Xml.XmlException)
                {
                    // Invalid referenced effect strings are left unresolved.
                }
            }

            return string.Empty;
        }

        private void Frm_Preview_Shown(object sender, EventArgs e)
        {
            RestartPlayback();
            PreviewCanvas.Focus();
        }

        private void Frm_Preview_FormClosed(object sender, FormClosedEventArgs e)
        {
            Timer_Animation.Stop();
            playbackWatch.Stop();
        }

        private void Frm_Preview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                TogglePlayback();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                ShowPage(PreviewCanvas.PageIndex - 1);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                ShowPage(PreviewCanvas.PageIndex + 1);
                e.Handled = true;
            }
        }

        private void Timer_Animation_Tick(object sender, EventArgs e)
        {
            if (!playing) return;
            long time = playbackOffset + playbackWatch.ElapsedMilliseconds;
            PreviewCanvas.SetAnimationTime(time);
        }

        private void Button_PlayPause_Click(object sender, EventArgs e)
        {
            TogglePlayback();
        }

        private void Button_Restart_Click(object sender, EventArgs e)
        {
            RestartPlayback();
        }

        private void Button_PreviousPage_Click(object sender, EventArgs e)
        {
            ShowPage(PreviewCanvas.PageIndex - 1);
        }

        private void Button_NextPage_Click(object sender, EventArgs e)
        {
            ShowPage(PreviewCanvas.PageIndex + 1);
        }

        private void Button_Font_Click(object sender, EventArgs e)
        {
            FontDialog_Preview.Font = PreviewCanvas.PreviewFont;
            if (FontDialog_Preview.ShowDialog(this) == DialogResult.OK)
            {
                PreviewCanvas.PreviewFont = FontDialog_Preview.Font;
                UpdateFontLabel();
            }
        }

        private void Numeric_TeletypeSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (PreviewCanvas == null) return;
            PreviewCanvas.CharactersPerSecond = Convert.ToInt32(Numeric_TeletypeSpeed.Value);
            RestartPlayback();
            UpdatePageControls();
        }

        private void PreviewCanvas_Click(object sender, EventArgs e)
        {
            PreviewCanvas.SkipAnimation();
            playbackOffset = PreviewCanvas.AnimationTime;
            playbackWatch.Reset();
            playbackWatch.Start();
            playing = true;
            Timer_Animation.Start();
            UpdatePlaybackButton();
        }

        private void TogglePlayback()
        {
            if (playing)
            {
                PausePlayback();
            }
            else
            {
                playbackOffset = PreviewCanvas.AnimationTime;
                playbackWatch.Restart();
                playing = true;
                Timer_Animation.Start();
                UpdatePlaybackButton();
            }
        }

        private void RestartPlayback()
        {
            playbackOffset = 0;
            PreviewCanvas.SetAnimationTime(0);
            playbackWatch.Restart();
            playing = true;
            Timer_Animation.Start();
            UpdatePlaybackButton();
        }

        private void PausePlayback()
        {
            if (playing)
            {
                playbackOffset += playbackWatch.ElapsedMilliseconds;
            }
            playbackWatch.Reset();
            playing = false;
            Timer_Animation.Stop();
            UpdatePlaybackButton();
        }

        private void ShowPage(int pageIndex)
        {
            if (!PreviewCanvas.SetPage(pageIndex)) return;
            RestartPlayback();
            UpdatePageControls();
        }

        private void UpdatePlaybackButton()
        {
            Button_PlayPause.Text = playing ? "Pause" : "Play";
        }

        private void UpdatePageControls()
        {
            int pageCount = Math.Max(1, PreviewCanvas.PageCount);
            Label_Page.Text = string.Format("Page {0}/{1}", PreviewCanvas.PageIndex + 1, pageCount);
            Button_PreviousPage.Enabled = PreviewCanvas.PageIndex > 0;
            Button_NextPage.Enabled = PreviewCanvas.PageIndex + 1 < PreviewCanvas.PageCount;
        }

        private void UpdateFontLabel()
        {
            Label_Font.Text = string.Format("{0}, {1:0.#} pt, {2}", PreviewCanvas.PreviewFont.Name, PreviewCanvas.PreviewFont.SizeInPoints, PreviewCanvas.PreviewFont.Style);
        }
    }
}
