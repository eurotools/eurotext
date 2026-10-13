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
            public int FadeDuration = 30;
            public int FadeDelay;
            public bool Fountain;
            public int FountainDuration = 60;
            public int FountainMinDuration;
            public int FountainStartIndex;
            public long FountainStartTime;
            public bool Circular;
            public float CircleFrequency = 2.0f;
            // The retail EngineX build behaves as CT 2,30,3 when CT has no
            // arguments (verified frame-for-frame against the captured game).
            public float CircleSpeed = 30.0f;
            public float CircleRadius = 3.0f;
            public int CircleStartIndex;
            public bool Rising;
            public float RisingSpeed = 120.0f;
            public bool RandomColour;
            public float RandomRate = 30.0f;
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
            public float AlphaCycleOriginX;
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
            previewFont = new Font("Verdana", 12.0f, FontStyle.Bold, GraphicsUnit.Point);
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

            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            EnsureLayout(e.Graphics);
            PreviewPage page = pages[pageIndex];
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

                AddCharacter(page, rawText[position], state, revealTime, ref glyphIndex, nextXPercent);
                nextXPercent = -1.0f;
                if (state.Teletype) revealTime += characterDelay;
            }

            foreach (PreviewPage parsedPage in pages)
            {
                parsedPage.Duration = Math.Max(parsedPage.Duration, GetLastRevealTime(parsedPage) + 500);
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
                page.Duration = Math.Max(page.Duration, revealTime + 500);
                page = new PreviewPage();
                pages.Add(page);
                revealTime = 0;
                glyphIndex = 0;
                return true;
            }
            if (upperTag == "E")
            {
                page.Duration = Math.Max(page.Duration, revealTime + 500);
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
                if (waitValues.Count > 0) revealTime += waitValues[0] * 1000L / 30L;
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
                if (values.Count > 0) state.ShakeVariance = values[0];
                if (values.Count > 1) state.ShakeSpeed = values[1];
                return true;
            }
            if (upperTag == "END ST") { state.Shakey = false; return true; }
            if (upperTag == "FI" || upperTag.StartsWith("FI "))
            {
                List<int> values = GetNumbers(tag);
                state.FadeIn = true;
                if (values.Count > 0) state.FadeDuration = values[0];
                if (values.Count > 1) state.FadeDelay = values[1];
                return true;
            }
            if (upperTag == "END FI") { state.FadeIn = false; return true; }
            if (upperTag == "FTN" || upperTag.StartsWith("FTN "))
            {
                List<int> values = GetNumbers(tag);
                state.Fountain = true;
                state.FountainStartIndex = glyphIndex;
                state.FountainStartTime = revealTime;
                if (values.Count > 0) state.FountainDuration = Math.Max(1, values[0]);
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
                if (values.Count > 0) state.CircleFrequency = values[0];
                if (values.Count > 1) state.CircleSpeed = values[1];
                if (values.Count > 2) state.CircleRadius = values[2];
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
                if (values.Count > 0) state.RandomRate = values[0];
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
                    state.FountainStartTime + state.FountainDuration * 1000L / 30L);
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
            if (start == 1) state.ColourCycleSpeed = Math.Max(1, values[0]);
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
            float availableWidth = Math.Max(20.0f, ClientSize.Width - padding * 2.0f);
            float lineHeight = previewFont.GetHeight(graphics) + 5.0f;
            PreviewPage page = pages[pageIndex];
            List<PreviewLine> lines = new List<PreviewLine>();
            float x = padding;
            float y = padding;
            int lineStart = 0;
            bool lineCentered = false;

            for (int i = 0; i < page.Glyphs.Count; i++)
            {
                PreviewGlyph glyph = page.Glyphs[i];
                if (glyph.NewLine)
                {
                    lines.Add(new PreviewLine { StartIndex = lineStart, EndIndex = i - 1, Width = Math.Max(0, x - padding), Centered = lineCentered });
                    x = padding;
                    y += lineHeight;
                    lineStart = i + 1;
                    lineCentered = glyph.State.Centered;
                    continue;
                }

                glyph.Size = graphics.MeasureString(glyph.Character.ToString(), previewFont, PointF.Empty, StringFormat.GenericTypographic);
                // GDI+ reports little or no advance for an isolated trailing space.
                // The preview lays text out glyph by glyph, so give spaces an
                // explicit advance derived from the selected font size.
                if (glyph.Character == ' ')
                {
                    glyph.Size = new SizeF(Math.Max(2.0f, previewFont.SizeInPoints * 0.52f), glyph.Size.Height);
                }
                if (glyph.ForcedXPercent >= 0) x = padding + availableWidth * glyph.ForcedXPercent / 100.0f;
                if (x > padding && x + glyph.Size.Width > padding + availableWidth)
                {
                    lines.Add(new PreviewLine { StartIndex = lineStart, EndIndex = i - 1, Width = Math.Max(0, x - padding), Centered = lineCentered });
                    x = padding;
                    y += lineHeight;
                    lineStart = i;
                }
                if (i == lineStart) lineCentered = glyph.State.Centered;
                glyph.Position = new PointF(x, y);
                x += Math.Max(1.0f, glyph.Size.Width);
            }
            lines.Add(new PreviewLine { StartIndex = lineStart, EndIndex = page.Glyphs.Count - 1, Width = Math.Max(0, x - padding), Centered = lineCentered });

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

            // AC is a horizontal travelling band. Keep the phase tied to the
            // laid-out X coordinate rather than the character number, so
            // proportional fonts do not turn it into a letter-by-letter
            // blink. Each AC tag owns a list instance shared by its glyphs.
            Dictionary<List<int>, float> alphaCycleOrigins = new Dictionary<List<int>, float>();
            for (int i = 0; i < page.Glyphs.Count; i++)
            {
                PreviewGlyph glyph = page.Glyphs[i];
                List<int> cycle = glyph.State.CycleAlphas;
                if (glyph.NewLine || cycle == null || cycle.Count < 2) continue;
                float origin;
                if (!alphaCycleOrigins.TryGetValue(cycle, out origin))
                {
                    origin = glyph.Position.X;
                    alphaCycleOrigins.Add(cycle, origin);
                }
                glyph.AlphaCycleOriginX = origin;
            }

            // EngineX normally presents dialogue and help text along the
            // bottom of the viewport. Move the complete laid-out block as a
            // unit so explicit new lines, wrapping and horizontal alignment
            // retain exactly the same geometry.
            float blockBottom = y + lineHeight;
            float verticalShift = Math.Max(0.0f, ClientSize.Height - padding - blockBottom);
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
                double normalizedDistance = (glyph.Position.X - glyph.AlphaCycleOriginX)
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
            if (state.TeletypeFade) alpha = Math.Min(alpha, Convert.ToInt32(Math.Min(1.0, elapsed / 250.0) * 255.0));
            if (state.FadeIn)
            {
                long delay = state.FadeDelay * 1000L / 30L;
                long duration = Math.Max(1, state.FadeDuration) * 1000L / 30L;
                alpha = Math.Min(alpha, Convert.ToInt32(Math.Max(0.0, Math.Min(1.0, (elapsed - delay) / (double)duration)) * 255.0));
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
                // EngineX keeps SW moving for as long as the page is visible.
                // The captured effect completes a cycle in about 1.05 seconds
                // (six radians per second) with a subtle 0.08 radian phase
                // offset between neighbouring glyphs.
                int waveIndex = Math.Max(0, glyph.Index - state.SineStartIndex);
                // The 1080p capture moves 12 px for amplitude 10. Scaling
                // from that text size gives 6 px at the default preview 12 pt.
                float scaledAmplitude = state.SineAmplitude * previewFont.SizeInPoints / 20.0f;
                double phase = seconds * state.SineFrequency * 6.0 + waveIndex * 0.08;
                y += (float)Math.Round(Math.Sin(phase) * scaledAmplitude,
                    MidpointRounding.AwayFromZero);
            }
            if (state.Shakey)
            {
                int interval = Math.Max(1, Convert.ToInt32(Math.Max(1.0f, state.ShakeSpeed) * 1000.0 / 30.0));
                Random random = new Random(glyph.Index * 7919 ^ Convert.ToInt32(animationTime / interval));
                // The captured game font is roughly equivalent to 24 pt in
                // this preview: ST's native variance 2 therefore becomes one
                // pixel at the default 12 pt, and scales with the chosen size.
                float scaledVariance = state.ShakeVariance * previewFont.SizeInPoints / 24.0f;
                int variance = state.ShakeVariance <= 0.0f
                    ? 0
                    : Math.Max(1, (int)Math.Round(scaledVariance, MidpointRounding.AwayFromZero));
                x += random.Next(-variance, variance + 1);
                y += random.Next(-variance, variance + 1);
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
                // Both values are expressed in EngineX's 30ths of a second.
                int fountainIndex = Math.Max(0, glyph.Index - state.FountainStartIndex);
                int durationUnits = GetFountainDuration(state, fountainIndex);
                double duration = Math.Max(1.0, durationUnits * 1000.0 / 30.0);
                double fountainElapsed = Math.Max(0.0, animationTime - state.FountainStartTime);
                double progress = Math.Min(1.0, fountainElapsed / duration);

                if (progress < 1.0)
                {
                    float sourceX = ClientSize.Width * 0.5f;
                    float sourceY = layoutTextCenterY > 0.0f
                        ? layoutTextCenterY
                        : ClientSize.Height * 0.5f;

                    // Each glyph receives a different sideways impulse. The
                    // parabolic term is zero both at launch and landing, so
                    // every character still finishes at its exact laid-out
                    // position but the cloud spreads irregularly in flight.
                    float lateralDirection = GetFountainRandom(fountainIndex, 0x51f15e5d);
                    float fountainFontScale = Math.Max(0.5f, previewFont.SizeInPoints / 12.0f);
                    float lateralScale = Math.Min(1.5f, fountainFontScale);
                    float lateralDistance = ClientSize.Width * 0.22f * lateralScale * lateralDirection;
                    double ballisticCurve = 4.0 * progress * (1.0 - progress);
                    float currentX = sourceX + (glyph.Position.X - sourceX) * (float)progress
                        + lateralDistance * (float)ballisticCurve;

                    // Longer-lived characters are fired harder and therefore
                    // climb higher, as in the capture. A second small random
                    // factor avoids the uniform arch produced by the old
                    // implementation while preserving a smooth landing.
                    double durationRange = Math.Max(1.0,
                        state.FountainDuration - state.FountainMinDuration);
                    double durationFactor = (durationUnits - state.FountainMinDuration) / durationRange;
                    float heightVariation = GetFountainRandom(fountainIndex, 0x2c9277b5);
                    float heightRatio = 0.48f + (float)durationFactor * 0.22f + heightVariation * 0.05f;
                    float arcHeight = Math.Min(ClientSize.Height * 0.82f,
                        ClientSize.Height * heightRatio * fountainFontScale);
                    float currentY = sourceY + (glyph.Position.Y - sourceY) * (float)progress
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

            // EngineX assigns each glyph an independent landing time. A local
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
