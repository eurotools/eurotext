using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EuroText2
{
    public sealed class EngineXPreviewControl : Control
    {
        private sealed class EffectState
        {
            public Color Colour = Color.White;
            public bool RandomFontColour;
            public int RandomFontColourStartIndex;
            public int RandomFontColourSeed;
            public bool Teletype = true;
            public bool TeletypeFade;
            public bool Centered;
            public bool SineWave;
            public float SineAmplitude = 10.0f;
            public float SineFrequency = 1.0f;
            public int SineStartIndex;
            public bool Shakey;
            public float ShakeVariance = 2.0f;
            public float ShakeSpeed = 2.0f;
            public bool FadeIn;
            // FI without arguments uses EngineX's 60-tick (two second) fade.
            public int FadeDuration = 60;
            public int FadeDelay;
            public bool Fountain;
            public int FountainDuration = 100;
            public int FountainMinDuration;
            public int FountainStartIndex;
            public long FountainStartTime;
            public bool Circular;
            public float CircleFrequency = 2.0f;
            public float CircleSpeed = 35.0f;
            public float CircleRadius = 6.0f;
            public int CircleStartIndex;
            public bool Rising;
            public float RisingSpeed = 120.0f;
            public bool RandomColour;
            public float RandomRate = 15.0f;
            public int RandomColourStartIndex;
            public int RandomColourSeed;
            public List<Color> CycleColours;
            public int ColourCycleSpeed = 30;
            public int ColourCycleStartIndex;
            public List<int> CycleAlphas;
            public int AlphaCycleSpeed = 30;

            public EffectState Clone()
            {
                return (EffectState)MemberwiseClone();
            }
        }

        private sealed class PreviewGlyph
        {
            public char Character;
            public EffectState State;
            public long RevealTime;
            public int Index;
            public bool NewLine;
            public float ForcedXPercent = -1.0f;
            public PointF Position;
            public SizeF Size;
            public float AlphaCycleDistance;
        }

        private sealed class ColourState
        {
            public Color Colour;
            public bool RandomFontColour;
            public int RandomFontColourStartIndex;
            public int RandomFontColourSeed;
        }

        private sealed class PreviewPage
        {
            public readonly List<PreviewGlyph> Glyphs = new List<PreviewGlyph>();
            public long Duration;
            public bool AutoAdvance;
            public long AutoAdvanceTime;
        }

        private sealed class PreviewLine
        {
            public int StartIndex;
            public int EndIndex;
            public float Width;
            public bool Centered;
        }

        private readonly List<PreviewPage> pages = new List<PreviewPage>();
        private string rawText = string.Empty;
        private int pageIndex;
        private long animationTime;
        private int charactersPerSecond = 30;
        private Font previewFont;
        private int layoutWidth = -1;
        private Font layoutFont;
        private float layoutTextCenterY;
        private int previewRandomSeed = Guid.NewGuid().GetHashCode();
        private int randomColourTagCounter;
        private int randomEffectTagCounter;

        public EngineXPreviewControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            BackColor = Color.Black;
            ForeColor = Color.White;
            previewFont = new Font("Verdana", 14.0f, FontStyle.Regular, GraphicsUnit.Point);
            TabStop = true;
        }

        public int PageCount
        {
            get { return pages.Count; }
        }

        public int PageIndex
        {
            get { return pageIndex; }
        }

        public long AnimationTime
        {
            get { return animationTime; }
        }

        public long CurrentPageDuration
        {
            get
            {
                if (pages.Count == 0) return 0;
                return pages[pageIndex].Duration;
            }
        }

        public bool CurrentPageAutoAdvances
        {
            get { return pages.Count > 0 && pages[pageIndex].AutoAdvance; }
        }

        public long CurrentPageAutoAdvanceTime
        {
            get
            {
                if (pages.Count == 0 || !pages[pageIndex].AutoAdvance) return 0;
                return pages[pageIndex].AutoAdvanceTime;
            }
        }

        public int CharactersPerSecond
        {
            get { return charactersPerSecond; }
            set
            {
                charactersPerSecond = Math.Max(1, value);
                ParseText();
            }
        }

        public Font PreviewFont
        {
            get { return previewFont; }
            set
            {
                if (value == null) return;
                Font previousFont = previewFont;
                previewFont = new Font(value.FontFamily, value.Size, value.Style, GraphicsUnit.Point);
                if (previousFont != null) previousFont.Dispose();
                layoutWidth = -1;
                Invalidate();
            }
        }

        public void SetText(string text)
        {
            rawText = text ?? string.Empty;
            pageIndex = 0;
            animationTime = 0;
            previewRandomSeed = Guid.NewGuid().GetHashCode();
            ParseText();
        }

        public void SetAnimationTime(long milliseconds)
        {
            animationTime = Math.Max(0, milliseconds);
            Invalidate();
        }

        public void SkipAnimation()
        {
            animationTime = CurrentPageDuration + 1000;
            Invalidate();
        }

        public bool SetPage(int newPageIndex)
        {
            if (newPageIndex < 0 || newPageIndex >= pages.Count) return false;
            pageIndex = newPageIndex;
            animationTime = 0;
            layoutWidth = -1;
            Invalidate();
            return true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && previewFont != null)
            {
                previewFont.Dispose();
                previewFont = null;
            }
            base.Dispose(disposing);
        }

        protected override void OnResize(EventArgs e)
        {
            layoutWidth = -1;
            base.OnResize(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Black);
            if (pages.Count == 0 || previewFont == null) return;

            PreviewPage page = pages[pageIndex];
            // W clears the current help window at its exact deadline. The
            // form will select the following page on the same timer tick.
            if (page.AutoAdvance && animationTime >= page.AutoAdvanceTime) return;

            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            EnsureLayout(e.Graphics);
            for (int i = 0; i < page.Glyphs.Count; i++)
            {
                PreviewGlyph glyph = page.Glyphs[i];
                if (glyph.NewLine || animationTime < glyph.RevealTime) continue;

                long elapsed = Math.Max(0, animationTime - glyph.RevealTime);
                Color colour = GetAnimatedColour(glyph, elapsed);
                int alpha = GetAnimatedAlpha(glyph, elapsed, colour.A);
                PointF offset = GetAnimatedOffset(glyph, elapsed);
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(alpha, colour.R, colour.G, colour.B)))
                {
                    e.Graphics.DrawString(glyph.Character.ToString(), previewFont, brush, glyph.Position.X + offset.X, glyph.Position.Y + offset.Y, StringFormat.GenericTypographic);
                }
            }
        }

        private void ParseText()
        {
            pages.Clear();
            PreviewPage page = new PreviewPage();
            pages.Add(page);
            EffectState state = new EffectState();
            Stack<ColourState> colourStack = new Stack<ColourState>();
            randomColourTagCounter = 0;
            randomEffectTagCounter = 0;
            long revealTime = 0;
            float nextXPercent = -1.0f;
            int glyphIndex = 0;
            int characterDelay = Math.Max(1, 1000 / charactersPerSecond);

            for (int position = 0; position < rawText.Length; position++)
            {
                if (rawText[position] == '<')
                {
                    int close = rawText.IndexOf('>', position + 1);
                    if (close >= 0)
                    {
                        string tag = rawText.Substring(position + 1, close - position - 1).Trim();
                        position = close;
                        if (HandleTag(tag, ref page, ref state, colourStack, ref revealTime, ref nextXPercent, ref glyphIndex, characterDelay))
                        {
                            continue;
                        }
                    }
                }

                char character = rawText[position];
                AddCharacter(page, character, state, revealTime, ref glyphIndex, nextXPercent);
                nextXPercent = -1.0f;
                // EngineX advances TT and TTF on visible glyphs. Whitespace
                // is laid out at the current reveal time but does not consume
                // another 30 Hz step; punctuation does consume one normally.
                if (state.Teletype && !char.IsWhiteSpace(character))
                {
                    revealTime += characterDelay;
                }
            }

            foreach (PreviewPage parsedPage in pages)
            {
                long tail = parsedPage.AutoAdvance ? 0 : 500;
                parsedPage.Duration = Math.Max(parsedPage.Duration,
                    GetLastRevealTime(parsedPage) + tail);
            }
            layoutWidth = -1;
            if (pageIndex >= pages.Count) pageIndex = pages.Count - 1;
            Invalidate();
        }

        private bool HandleTag(string tag, ref PreviewPage page, ref EffectState state, Stack<ColourState> colourStack, ref long revealTime, ref float nextXPercent, ref int glyphIndex, int characterDelay)
        {
            string upperTag = tag.ToUpperInvariant();
            if (upperTag == "N")
            {
                AddNewLine(page, state, revealTime, ref glyphIndex);
                return true;
            }
            if (upperTag == "P")
            {
                page.Duration = Math.Max(page.Duration, page.AutoAdvance
                    ? page.AutoAdvanceTime
                    : revealTime + 500);
                page = new PreviewPage();
                pages.Add(page);
                revealTime = 0;
                glyphIndex = 0;
                return true;
            }
            if (upperTag == "E")
            {
                page.Duration = Math.Max(page.Duration, page.AutoAdvance
                    ? page.AutoAdvanceTime
                    : revealTime + 500);
                return true;
            }
            if (upperTag == "LT" || upperTag == "MT")
            {
                char literal = upperTag == "LT" ? '<' : '>';
                AddCharacter(page, literal, state, revealTime, ref glyphIndex, nextXPercent);
                nextXPercent = -1.0f;
                if (state.Teletype) revealTime += characterDelay;
                return true;
            }
            if (upperTag == "T")
            {
                for (int i = 0; i < 4; i++) AddCharacter(page, ' ', state, revealTime, ref glyphIndex, -1.0f);
                return true;
            }
            if (upperTag.StartsWith("W "))
            {
                List<int> waitValues = GetNumbers(tag);
                if (waitValues.Count > 0)
                {
                    // W starts after all content parsed before it has been
                    // revealed, then clears this page after the given number
                    // of native 30 Hz ticks.
                    revealTime += Math.Max(0, waitValues[0]) * 1000L / 30L;
                    page.AutoAdvance = true;
                    page.AutoAdvanceTime = revealTime;
                    page.Duration = Math.Max(page.Duration, revealTime);
                }
                return true;
            }
            if (upperTag == "CNTR") { state.Centered = true; return true; }
            if (upperTag == "END CNTR") { state.Centered = false; return true; }
            if (upperTag.StartsWith("PC 1")) { nextXPercent = 50.0f; return true; }
            if (upperTag.StartsWith("PC 2"))
            {
                List<int> positions = GetNumbers(tag);
                if (positions.Count > 1) nextXPercent = Math.Max(0, Math.Min(100, positions[1]));
                return true;
            }
            if (upperTag.StartsWith("B"))
            {
                AddCharacter(page, '•', state, revealTime, ref glyphIndex, nextXPercent);
                AddCharacter(page, ' ', state, revealTime, ref glyphIndex, -1.0f);
                nextXPercent = -1.0f;
                return true;
            }
            if (upperTag.StartsWith("SO ")) { AddPlaceholder(page, "<Objective Value>", state, revealTime, ref glyphIndex); return true; }
            if (upperTag.StartsWith("IS ")) { AddPlaceholder(page, "<Text String>", state, revealTime, ref glyphIndex); return true; }
            if (upperTag.StartsWith("I ") || upperTag.StartsWith("SB ") || upperTag.StartsWith("DC "))
            {
                AddPlaceholder(page, "[■]", state, revealTime, ref glyphIndex);
                return true;
            }

            if (upperTag == "TT" || upperTag.StartsWith("TT ")) { state.Teletype = true; state.TeletypeFade = false; return true; }
            if (upperTag == "TTF") { state.Teletype = true; state.TeletypeFade = true; return true; }
            if (upperTag == "END TT") { state.Teletype = false; state.TeletypeFade = false; return true; }
            if (upperTag == "END TTF") { state.Teletype = false; state.TeletypeFade = false; return true; }

            if (upperTag == "FC" || upperTag.StartsWith("FC "))
            {
                List<int> values = GetNumbers(tag);
                colourStack.Push(new ColourState
                {
                    Colour = state.Colour,
                    RandomFontColour = state.RandomFontColour,
                    RandomFontColourStartIndex = state.RandomFontColourStartIndex,
                    RandomFontColourSeed = state.RandomFontColourSeed
                });
                if (values.Count >= 3)
                {
                    state.Colour = ConvertColour(values[0], values[1], values[2], 255);
                    state.RandomFontColour = false;
                }
                else
                {
                    state.RandomFontColour = true;
                    state.RandomFontColourStartIndex = glyphIndex;
                    state.RandomFontColourSeed = previewRandomSeed
                        ^ (++randomColourTagCounter * 486187739);
                }
                return true;
            }
            if (upperTag == "END FC")
            {
                if (colourStack.Count > 0)
                {
                    ColourState previous = colourStack.Pop();
                    state.Colour = previous.Colour;
                    state.RandomFontColour = previous.RandomFontColour;
                    state.RandomFontColourStartIndex = previous.RandomFontColourStartIndex;
                    state.RandomFontColourSeed = previous.RandomFontColourSeed;
                }
                else
                {
                    state.Colour = Color.White;
                    state.RandomFontColour = false;
                }
                return true;
            }

            if (upperTag.StartsWith("CC ")) { ApplyColourCycle(tag, state, glyphIndex); return true; }
            if (upperTag == "END CC") { state.CycleColours = null; return true; }
            if (upperTag.StartsWith("AC ")) { ApplyAlphaCycle(tag, state); return true; }
            if (upperTag == "END AC") { state.CycleAlphas = null; return true; }

            if (upperTag == "SW" || upperTag.StartsWith("SW "))
            {
                List<int> values = GetNumbers(tag);
                state.SineWave = true;
                state.SineStartIndex = glyphIndex;
                if (values.Count > 0) state.SineAmplitude = values[0];
                if (values.Count > 1) state.SineFrequency = values[1];
                return true;
            }
            if (upperTag == "END SW") { state.SineWave = false; return true; }
            if (upperTag == "ST" || upperTag.StartsWith("ST "))
            {
                List<int> values = GetNumbers(tag);
                state.Shakey = true;
                // Missing ST values use EngineX's defaults independently.
                // This also prevents a partial tag from inheriting the speed
                // or variance of a preceding ST block.
                state.ShakeVariance = values.Count > 0 ? Math.Max(0, values[0]) : 2.0f;
                state.ShakeSpeed = values.Count > 1 ? Math.Max(1, values[1]) : 2.0f;
                return true;
            }
            if (upperTag == "END ST") { state.Shakey = false; return true; }
            if (upperTag == "FI" || upperTag.StartsWith("FI "))
            {
                List<int> values = GetNumbers(tag);
                state.FadeIn = true;
                // FI defaults to a 60-tick fade with no wait. Its optional
                // second value is the invisible hold before the block starts
                // fading. Reset both so consecutive FI blocks are independent.
                state.FadeDuration = values.Count > 0 ? Math.Max(1, values[0]) : 60;
                state.FadeDelay = values.Count > 1 ? Math.Max(0, values[1]) : 0;
                return true;
            }
            if (upperTag == "END FI") { state.FadeIn = false; return true; }
            if (upperTag == "FTN" || upperTag.StartsWith("FTN "))
            {
                List<int> values = GetNumbers(tag);
                state.Fountain = true;
                state.FountainStartIndex = glyphIndex;
                state.FountainStartTime = revealTime;
                // The original EngineX preview gives bare FTN a maximum of
                // 100 fountain steps. A single value replaces only that maximum;
                // the minimum remains zero. Reset both defaults on every new
                // block so parameters from an earlier FTN cannot leak in.
                state.FountainDuration = values.Count > 0
                    ? Math.Max(1, values[0])
                    : 100;
                state.FountainMinDuration = values.Count > 1
                    ? Math.Max(0, Math.Min(state.FountainDuration, values[1]))
                    : 0;
                return true;
            }
            if (upperTag == "END FTN") { state.Fountain = false; return true; }
            if (upperTag == "CT" || upperTag.StartsWith("CT "))
            {
                List<int> values = GetNumbers(tag);
                state.Circular = true;
                state.CircleStartIndex = glyphIndex;
                // EngineX fills omitted CT parameters independently with
                // Frequency 2, Speed 35 and Radius 6. Reset every field here
                // so a partial CT never inherits values from an earlier one.
                state.CircleFrequency = values.Count > 0 ? values[0] : 2.0f;
                state.CircleSpeed = values.Count > 1 ? values[1] : 35.0f;
                state.CircleRadius = values.Count > 2 ? values[2] : 6.0f;
                return true;
            }
            if (upperTag == "END CT") { state.Circular = false; return true; }
            if (upperTag == "RT" || upperTag.StartsWith("RT "))
            {
                List<int> values = GetNumbers(tag);
                state.Rising = true;
                if (values.Count > 0) state.RisingSpeed = values[0];
                return true;
            }
            if (upperTag == "END RT") { state.Rising = false; return true; }
            if (upperTag == "RFC" || upperTag.StartsWith("RFC "))
            {
                List<int> values = GetNumbers(tag);
                state.RandomColour = true;
                state.RandomColourStartIndex = glyphIndex;
                state.RandomColourSeed = previewRandomSeed
                    ^ (++randomEffectTagCounter * 16777619);
                // RFC without a value holds each random palette for 15
                // EngineX ticks (30 frames in the 60 Hz capture). Reset the
                // default so a preceding explicit rate cannot leak into it.
                state.RandomRate = values.Count > 0
                    ? Math.Max(1, values[0])
                    : 15.0f;
                return true;
            }
            if (upperTag == "END RFC") { state.RandomColour = false; return true; }

            return true;
        }

        private static void AddCharacter(PreviewPage page, char character, EffectState state, long revealTime, ref int glyphIndex, float forcedXPercent)
        {
            page.Glyphs.Add(new PreviewGlyph
            {
                Character = character,
                State = state.Clone(),
                RevealTime = revealTime,
                Index = glyphIndex++,
                ForcedXPercent = forcedXPercent
            });
            if (state.Fountain)
            {
                page.Duration = Math.Max(page.Duration,
                    state.FountainStartTime + FountainStepsToMilliseconds(state.FountainDuration));
            }
            if (state.FadeIn)
            {
                page.Duration = Math.Max(page.Duration, revealTime
                    + (state.FadeDelay + state.FadeDuration) * 1000L / 30L);
            }
        }

        private static void AddNewLine(PreviewPage page, EffectState state, long revealTime, ref int glyphIndex)
        {
            page.Glyphs.Add(new PreviewGlyph { NewLine = true, State = state.Clone(), RevealTime = revealTime, Index = glyphIndex++ });
        }

        private static void AddPlaceholder(PreviewPage page, string text, EffectState state, long revealTime, ref int glyphIndex)
        {
            foreach (char character in text) AddCharacter(page, character, state, revealTime, ref glyphIndex, -1.0f);
        }

        private static long GetLastRevealTime(PreviewPage page)
        {
            long result = 0;
            foreach (PreviewGlyph glyph in page.Glyphs) result = Math.Max(result, glyph.RevealTime);
            return result;
        }

        private static List<int> GetNumbers(string value)
        {
            List<int> result = new List<int>();
            foreach (Match match in Regex.Matches(value, @"-?\d+"))
            {
                int parsed;
                if (int.TryParse(match.Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out parsed)) result.Add(parsed);
            }
            return result;
        }

        private static int ToByteComponent(int value)
        {
            if (value <= 128) return Math.Max(0, Math.Min(255, value * 2));
            return Math.Max(0, Math.Min(255, value));
        }

        private static Color ConvertColour(int red, int green, int blue, int alpha)
        {
            return Color.FromArgb(ToByteComponent(alpha), ToByteComponent(red), ToByteComponent(green), ToByteComponent(blue));
        }

        private static void ApplyColourCycle(string tag, EffectState state, int glyphIndex)
        {
            List<int> values = GetNumbers(tag);
            int start = values.Count % 4 == 1 ? 1 : 0;
            // With no leading speed EngineX uses 30 ticks: the complete list
            // cycles in one second. Reset it explicitly so a preceding CC
            // with a custom speed cannot leak into this effect.
            state.ColourCycleSpeed = start == 1 ? Math.Max(1, values[0]) : 30;
            List<Color> colours = new List<Color>();
            for (int i = start; i + 3 < values.Count; i += 4)
            {
                colours.Add(ConvertColour(values[i], values[i + 1], values[i + 2], values[i + 3]));
            }
            state.CycleColours = colours.Count >= 2 ? colours : null;
            state.ColourCycleStartIndex = glyphIndex;
        }

        private static void ApplyAlphaCycle(string tag, EffectState state)
        {
            List<int> values = GetNumbers(tag);
            if (values.Count < 3) return;
            state.AlphaCycleSpeed = Math.Max(1, values[0]);
            state.CycleAlphas = new List<int>();
            for (int i = 1; i < values.Count; i++) state.CycleAlphas.Add(ToByteComponent(values[i]));
        }

        private void EnsureLayout(Graphics graphics)
        {
            if (layoutWidth == ClientSize.Width && ReferenceEquals(layoutFont, previewFont)) return;
            layoutWidth = ClientSize.Width;
            layoutFont = previewFont;
            if (pages.Count == 0) return;

            const float padding = 18.0f;
            // EngineX lays text out in a centred 4:3 safe area even when the
            // rendered window is widescreen. Keep the ordinary inset inside
            // that logical area so wrapping follows the original game.
            float safeWidth = Math.Min(ClientSize.Width, ClientSize.Height * 4.0f / 3.0f);
            float safeLeft = (ClientSize.Width - safeWidth) * 0.5f;
            float horizontalPadding = safeLeft + padding;
            float availableWidth = Math.Max(20.0f, safeWidth - padding * 2.0f);
            float lineHeight = previewFont.GetHeight(graphics) + 5.0f;
            PreviewPage page = pages[pageIndex];
            List<PreviewLine> lines = new List<PreviewLine>();
            float x = horizontalPadding;
            float y = padding;
            int lineStart = 0;
            bool lineCentered = false;

            for (int i = 0; i < page.Glyphs.Count; i++)
            {
                PreviewGlyph glyph = page.Glyphs[i];
                if (glyph.NewLine)
                {
                    lines.Add(new PreviewLine { StartIndex = lineStart, EndIndex = i - 1, Width = Math.Max(0, x - horizontalPadding), Centered = lineCentered });
                    x = horizontalPadding;
                    y += lineHeight;
                    lineStart = i + 1;
                    lineCentered = glyph.State.Centered;
                    continue;
                }

                glyph.Size = graphics.MeasureString(glyph.Character.ToString(), previewFont, PointF.Empty, StringFormat.GenericTypographic);
                if (glyph.Character == ' ')
                {
                    glyph.Size = new SizeF(Math.Max(2.0f, previewFont.SizeInPoints * 0.52f), glyph.Size.Height);
                }
                if (glyph.ForcedXPercent >= 0) x = horizontalPadding + availableWidth * glyph.ForcedXPercent / 100.0f;
                if (x > horizontalPadding && x + glyph.Size.Width > horizontalPadding + availableWidth)
                {
                    lines.Add(new PreviewLine { StartIndex = lineStart, EndIndex = i - 1, Width = Math.Max(0, x - horizontalPadding), Centered = lineCentered });
                    x = horizontalPadding;
                    y += lineHeight;
                    lineStart = i;
                }
                if (i == lineStart) lineCentered = glyph.State.Centered;
                glyph.Position = new PointF(x, y);
                x += Math.Max(1.0f, glyph.Size.Width);
            }
            lines.Add(new PreviewLine { StartIndex = lineStart, EndIndex = page.Glyphs.Count - 1, Width = Math.Max(0, x - horizontalPadding), Centered = lineCentered });

            foreach (PreviewLine line in lines)
            {
                if (!line.Centered || line.EndIndex < line.StartIndex) continue;
                float shift = Math.Max(0, (availableWidth - line.Width) / 2.0f);
                for (int i = line.StartIndex; i <= line.EndIndex; i++)
                {
                    PreviewGlyph glyph = page.Glyphs[i];
                    if (!glyph.NewLine) glyph.Position = new PointF(glyph.Position.X + shift, glyph.Position.Y);
                }
            }

            // AC follows the accumulated typographic distance, as though the
            // affected text were one continuous horizontal strip. Explicit
            // and automatic line breaks therefore do not restart or align
            // the band, while proportional fonts still produce a smooth
            // sweep. Each AC tag owns a list instance shared by its glyphs.
            Dictionary<List<int>, float> alphaCycleDistances = new Dictionary<List<int>, float>();
            for (int i = 0; i < page.Glyphs.Count; i++)
            {
                PreviewGlyph glyph = page.Glyphs[i];
                List<int> cycle = glyph.State.CycleAlphas;
                if (cycle == null || cycle.Count < 2) continue;
                float distance;
                if (!alphaCycleDistances.TryGetValue(cycle, out distance))
                {
                    distance = 0.0f;
                }
                glyph.AlphaCycleDistance = distance;
                if (!glyph.NewLine)
                {
                    distance += Math.Max(1.0f, glyph.Size.Width);
                }
                alphaCycleDistances[cycle] = distance;
            }

            // EngineX anchors the first line to the top of a fixed four-line
            // band near the bottom of the help window. Additional lines grow
            // downwards; they do not push the beginning of the block upwards.
            float blockBottom = y + lineHeight;
            float textBandTop = Math.Max(padding, ClientSize.Height - lineHeight * 4.0f);
            float verticalShift = Math.Max(0.0f, textBandTop - padding);
            for (int i = 0; i < page.Glyphs.Count; i++)
            {
                PreviewGlyph glyph = page.Glyphs[i];
                if (!glyph.NewLine)
                {
                    glyph.Position = new PointF(glyph.Position.X, glyph.Position.Y + verticalShift);
                }
            }
            layoutTextCenterY = (padding + verticalShift + blockBottom + verticalShift) * 0.5f;
        }

        private Color GetAnimatedColour(PreviewGlyph glyph, long elapsed)
        {
            EffectState state = glyph.State;
            if (state.RandomFontColour)
            {
                int colourIndex = Math.Max(0, glyph.Index - state.RandomFontColourStartIndex);
                return CreateBrightRandomColour(state.RandomFontColourSeed ^ colourIndex * 7919);
            }
            if (state.RandomColour)
            {
                int colourIndex = Math.Max(0, glyph.Index - state.RandomColourStartIndex);
                // Work in EngineX's native 30 Hz units instead of rounding
                // five units to 167 ms. RFC 5 therefore changes on exactly
                // every tenth 60 Hz frame, without accumulating drift.
                int flashIndex = (int)Math.Floor(animationTime * 30.0
                    / (Math.Max(1.0f, state.RandomRate) * 1000.0));
                return CreateBrightRandomColour(state.RandomColourSeed
                    ^ colourIndex * 7919
                    ^ flashIndex * 104729);
            }
            if (state.CycleColours != null && state.CycleColours.Count >= 2)
            {
                // Speed is the duration of the complete colour list, not the
                // duration of each individual transition. EngineX also moves
                // the colour band backwards by one segment every 15 glyphs.
                int cycleDuration = Math.Max(1, state.ColourCycleSpeed) * 1000 / 30;
                int colourIndex = Math.Max(0, glyph.Index - state.ColourCycleStartIndex);
                double progress = animationTime * state.CycleColours.Count / (double)cycleDuration
                    - colourIndex / 15.0;
                progress %= state.CycleColours.Count;
                if (progress < 0) progress += state.CycleColours.Count;
                int firstIndex = ((int)progress) % state.CycleColours.Count;
                int secondIndex = (firstIndex + 1) % state.CycleColours.Count;
                double fraction = progress - Math.Floor(progress);
                return InterpolateColour(state.CycleColours[firstIndex], state.CycleColours[secondIndex], fraction);
            }
            return state.Colour;
        }

        private static Color CreateBrightRandomColour(int seed)
        {
            Random random = new Random(seed);
            int red = random.Next(129);
            int green = random.Next(129);
            int blue = random.Next(129);
            int brightest = Math.Max(red, Math.Max(green, blue));
            if (brightest == 0) return Color.White;

            // EngineX's FC/RFC colours span the complete hue range but keep
            // their brightest component at full intensity. This is why the
            // captured output is vivid/pastel rather than dark.
            return Color.FromArgb(255,
                red * 255 / brightest,
                green * 255 / brightest,
                blue * 255 / brightest);
        }

        private int GetAnimatedAlpha(PreviewGlyph glyph, long elapsed, int baseAlpha)
        {
            EffectState state = glyph.State;
            int alpha = baseAlpha;
            if (state.CycleAlphas != null && state.CycleAlphas.Count >= 2)
            {
                // Speed is the duration of the complete list in EngineX's
                // 30 Hz ticks. The phase follows horizontal distance and is
                // normalized by the selected font size, so resizing the text
                // changes its pixel width without changing the apparent band.
                int cycleDuration = Math.Max(1, state.AlphaCycleSpeed) * 1000 / 30;
                double normalizedDistance = glyph.AlphaCycleDistance
                    * 12.0 / Math.Max(1.0f, previewFont.SizeInPoints);
                const double phaseMillisecondsPerPixelAt12Points = 1.6;
                double phaseTime = animationTime
                    - normalizedDistance * phaseMillisecondsPerPixelAt12Points;
                double progress = phaseTime * state.CycleAlphas.Count / cycleDuration;
                progress %= state.CycleAlphas.Count;
                if (progress < 0) progress += state.CycleAlphas.Count;
                int firstIndex = ((int)progress) % state.CycleAlphas.Count;
                int secondIndex = (firstIndex + 1) % state.CycleAlphas.Count;
                double fraction = progress - Math.Floor(progress);
                // EngineX blends in the rendered scene before the captured
                // image is gamma encoded. GDI+ otherwise makes the middle of
                // the transition too dark and the travelling trough too wide.
                double first = Math.Pow(state.CycleAlphas[firstIndex] / 255.0, 2.2);
                double second = Math.Pow(state.CycleAlphas[secondIndex] / 255.0, 2.2);
                double blended = first + (second - first) * fraction;
                alpha = Convert.ToInt32(Math.Pow(Math.Max(0.0, blended), 1.0 / 2.2) * 255.0);
            }
            if (state.TeletypeFade)
            {
                // EngineX fades every newly revealed TTF glyph for 30 ticks
                // (one second). The captured curve is a sine ease-out rather
                // than a linear ramp, which gives it the characteristic soft
                // but quickly readable appearance.
                double progress = Math.Max(0.0, Math.Min(1.0, elapsed / 1000.0));
                int fadeAlpha = Convert.ToInt32(Math.Sin(progress * Math.PI * 0.5) * 255.0);
                alpha = Math.Min(alpha, fadeAlpha);
            }
            if (state.FadeIn)
            {
                long delay = state.FadeDelay * 1000L / 30L;
                long duration = Math.Max(1, state.FadeDuration) * 1000L / 30L;
                double progress = Math.Max(0.0, Math.Min(1.0,
                    (elapsed - delay) / (double)duration));
                // The original renderer uses the same sine ease-out visible
                // in TTF: halfway through FI the text is about 70% opaque.
                int fadeAlpha = Convert.ToInt32(Math.Sin(progress * Math.PI * 0.5) * 255.0);
                alpha = Math.Min(alpha, fadeAlpha);
            }
            return Math.Max(0, Math.Min(255, alpha));
        }

        private PointF GetAnimatedOffset(PreviewGlyph glyph, long elapsed)
        {
            EffectState state = glyph.State;
            float x = 0;
            float y = 0;
            double seconds = animationTime / 1000.0;
            if (state.SineWave)
            {
                // Keeps SW moving for as long as the page is visible.
                // EngineX keeps the temporal speed fixed at about one cycle per
                // 1.05 seconds. The second SW value controls the spatial
                // frequency (the phase step between glyphs), not that speed.
                int waveIndex = Math.Max(0, glyph.Index - state.SineStartIndex);
                // At the captured 1080p/game font size, amplitude 10 moves the
                // glyph about 12 px. Scale it with the selectable preview font.
                float scaledAmplitude = state.SineAmplitude * previewFont.SizeInPoints / 20.0f;
                double phase = seconds * 6.0 + waveIndex * state.SineFrequency * 0.08;
                y += (float)Math.Round(Math.Sin(phase) * scaledAmplitude,
                    MidpointRounding.AwayFromZero);
            }
            if (state.Shakey)
            {
                // Speed is a hold time in EngineX's native 30 Hz ticks: the
                // captures change ST 2 every four 60 Hz frames and ST 8 every
                // sixteen. Calculate the tick directly so rounding 1000/30
                // cannot introduce an accumulating cadence error.
                int shakeFrame = (int)Math.Floor(animationTime * 30.0
                    / (Math.Max(1.0f, state.ShakeSpeed) * 1000.0));
                int nativeVariance = Math.Max(0, (int)Math.Round(
                    state.ShakeVariance, MidpointRounding.AwayFromZero));
                // EngineX first chooses one of the native integer positions
                // from -Variance through +Variance. Scale that result, not
                // the range: at 12 pt VAR 2 retains five half-pixel positions
                // instead of collapsing to the three positions -1, 0 and 1.
                float shakeScale = previewFont.SizeInPoints / 24.0f;
                x += GetShakeCoordinate(glyph.Index, shakeFrame, 0, nativeVariance)
                    * shakeScale;
                y += GetShakeCoordinate(glyph.Index, shakeFrame, 1, nativeVariance)
                    * shakeScale;
            }
            if (state.Circular)
            {
                // Frequency controls the number of turns during the duration
                // given by Speed (in 30ths of a second). Neighbouring glyphs
                // are phase shifted by index/frequency, as in EngineX.
                double frequency = Math.Max(0.01, state.CircleFrequency);
                double duration = Math.Max(1.0f, state.CircleSpeed) / 30.0;
                int circleIndex = Math.Max(0, glyph.Index - state.CircleStartIndex);
                double angle = seconds * Math.PI * 2.0 * frequency / duration
                    + circleIndex / frequency;
                float scaledRadius = state.CircleRadius * previewFont.SizeInPoints / 24.0f;
                x += (float)Math.Round(Math.Cos(angle) * scaledRadius,
                    MidpointRounding.AwayFromZero);
                y -= (float)Math.Round(Math.Sin(angle) * scaledRadius,
                    MidpointRounding.AwayFromZero);
            }
            if (state.Rising)
            {
                double duration = Math.Max(150.0, state.RisingSpeed * 8.0);
                y -= (float)(Math.Max(0.0, 1.0 - elapsed / duration) * 70.0);
            }
            if (state.Fountain)
            {
                // FTN is a block entrance, not a per-character hop. All
                // glyphs are fired from the centre of the help window and
                // land at their normal layout positions after a stable,
                // pseudo-random time between MinDuration and MaxDuration.
                // Although the Data Info sheet describes these values as
                // 30ths, the captured engine takes about 3.6 seconds for
                // FTN 90: fountain motion advances at 25 steps per second.
                int fountainIndex = Math.Max(0, glyph.Index - state.FountainStartIndex);
                int durationUnits = GetFountainDuration(state, fountainIndex);
                double fountainElapsed = Math.Max(0.0, animationTime - state.FountainStartTime);
                double elapsedSteps = Math.Floor(fountainElapsed / 40.0);
                double progress = durationUnits <= 0
                    ? 1.0
                    : Math.Min(1.0, elapsedSteps / durationUnits);

                if (progress < 1.0)
                {
                    // EngineX advances a flying glyph at a nearly constant
                    // rate. Short-lived glyphs get a proportionally shorter
                    // arc instead of being forced through the same large arc
                    // at a much higher speed.
                    double trajectoryProgress = progress;
                    float sourceX = ClientSize.Width * 0.5f;
                    float sourceY = layoutTextCenterY > 0.0f
                        ? layoutTextCenterY - previewFont.GetHeight() * 1.25f
                        : ClientSize.Height * 0.5f;

                    float durationFactor = Math.Max(0.0f, Math.Min(1.0f,
                        durationUnits / (float)Math.Max(1, state.FountainDuration)));

                    // Each glyph receives a different sideways impulse. The
                    // parabolic term is zero both at launch and landing, so
                    // every character still finishes at its exact laid-out
                    // position but the cloud spreads irregularly in flight.
                    float lateralDirection = GetFountainRandom(fountainIndex, 0x51f15e5d);
                    // Express the impulse in em-like units derived from the
                    // actual selected font. No particular family or point
                    // size is treated as the reference; the viewport cap only
                    // prevents very large fonts from leaving the help window.
                    float fontHeight = previewFont.GetHeight();
                    float lateralReach = Math.Min(ClientSize.Width * 0.25f,
                        fontHeight * 10.0f);
                    float lateralDistance = lateralReach * durationFactor
                        * lateralDirection;
                    double ballisticCurve = 4.0 * trajectoryProgress * (1.0 - trajectoryProgress);
                    float currentX = sourceX + (glyph.Position.X - sourceX) * (float)trajectoryProgress
                        + lateralDistance * (float)ballisticCurve;

                    // Longer-lived characters are fired harder and therefore
                    // climb higher, as in the capture. A second small random
                    // factor avoids the uniform arch produced by the old
                    // implementation while preserving a smooth landing.
                    float heightVariation = GetFountainRandom(fountainIndex, 0x2c9277b5);
                    float verticalReach = Math.Min(ClientSize.Height * 0.63f,
                        fontHeight * 14.0f);
                    float arcHeight = verticalReach
                        * (0.92f + heightVariation * 0.08f)
                        * durationFactor * durationFactor;
                    float currentY = sourceY + (glyph.Position.Y - sourceY) * (float)trajectoryProgress
                        - arcHeight * (float)ballisticCurve;

                    x += currentX - glyph.Position.X;
                    y += currentY - glyph.Position.Y;
                }
            }
            return new PointF(x, y);
        }

        private static int GetFountainDuration(EffectState state, int glyphIndex)
        {
            int minimum = Math.Max(0, Math.Min(state.FountainMinDuration, state.FountainDuration));
            int maximum = Math.Max(minimum, state.FountainDuration);
            if (minimum == maximum) return maximum;

            // Assign each glyph an independent landing time. A local
            // integer hash gives the preview the same irregular distribution
            // without changing from repaint to repaint.
            unchecked
            {
                uint value = (uint)(glyphIndex + 1) * 747796405u + 2891336453u;
                value = ((value >> (int)((value >> 28) + 4)) ^ value) * 277803737u;
                value = (value >> 22) ^ value;
                return minimum + (int)(value % (uint)(maximum - minimum + 1));
            }
        }

        private static long FountainStepsToMilliseconds(int steps)
        {
            // FTN is updated by EngineX's 25 Hz effect clock rather than the
            // 30 Hz timing used by tags such as FI, CC and RFC.
            return Math.Max(0, steps) * 40L;
        }

        private static int GetShakeCoordinate(int glyphIndex, int shakeFrame,
            int axis, int variance)
        {
            if (variance <= 0) return 0;

            // A small integer hash gives every glyph and axis an independent,
            // uniform native offset without allocating a Random on every paint.
            unchecked
            {
                uint value = (uint)(glyphIndex + 1) * 747796405u;
                value ^= (uint)(shakeFrame + 1) * 2891336453u;
                value ^= axis == 0 ? 0x51f15e5du : 0x2c9277b5u;
                value = ((value >> (int)((value >> 28) + 4)) ^ value)
                    * 277803737u;
                value = (value >> 22) ^ value;
                return (int)(value % (uint)(variance * 2 + 1)) - variance;
            }
        }

        private static float GetFountainRandom(int glyphIndex, int salt)
        {
            unchecked
            {
                uint value = (uint)(glyphIndex + 1) * 747796405u + (uint)salt;
                value = ((value >> (int)((value >> 28) + 4)) ^ value) * 277803737u;
                value = (value >> 22) ^ value;
                return value / (float)uint.MaxValue * 2.0f - 1.0f;
            }
        }

        private static Color InterpolateColour(Color first, Color second, double fraction)
        {
            int alpha = Convert.ToInt32(first.A + (second.A - first.A) * fraction);
            int red = Convert.ToInt32(first.R + (second.R - first.R) * fraction);
            int green = Convert.ToInt32(first.G + (second.G - first.G) * fraction);
            int blue = Convert.ToInt32(first.B + (second.B - first.B) * fraction);
            return Color.FromArgb(alpha, red, green, blue);
        }
    }
}
