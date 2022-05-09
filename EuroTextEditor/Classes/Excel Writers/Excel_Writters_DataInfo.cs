using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.ComponentModel;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    partial class ExcelWritters
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal void CreateDataInfo(ISheet FormatInfo, IWorkbook workbook, DoWorkEventArgs e, BackgroundWorker asyncWorker)
        {
            //-------------------------------------------------------------------------------------------
            //  Fonts
            //-------------------------------------------------------------------------------------------
            IFont font = workbook.CreateFont();
            font.FontName = "Arial";
            font.FontHeightInPoints = 10;

            IFont fontColor = workbook.CreateFont();
            fontColor.FontName = "Arial";
            fontColor.FontHeightInPoints = 10;
            fontColor.Color = IndexedColors.Blue.Index;

            //-------------------------------------------------------------------------------------------
            //  Styles
            //-------------------------------------------------------------------------------------------
            HSSFPalette palette = ((HSSFWorkbook)workbook).GetCustomPalette();

            ICellStyle pinkBackground = workbook.CreateCellStyle();
            short pinkBackgroundColor = 45;
            palette.SetColorAtIndex(pinkBackgroundColor, 255, 153, 204);
            pinkBackground.FillForegroundColor = pinkBackgroundColor;
            pinkBackground.FillPattern = FillPattern.SolidForeground;
            pinkBackground.SetFont(font);
            pinkBackground.BorderLeft = BorderStyle.Thin;
            pinkBackground.BorderTop = BorderStyle.Thin;
            pinkBackground.BorderRight = BorderStyle.Thin;
            pinkBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle blueBackground = workbook.CreateCellStyle();
            short blueBackgroundColor = 46;
            palette.SetColorAtIndex(blueBackgroundColor, 204, 255, 255);
            blueBackground.FillForegroundColor = blueBackgroundColor;
            blueBackground.FillPattern = FillPattern.SolidForeground;
            blueBackground.SetFont(font);
            blueBackground.BorderLeft = BorderStyle.Thin;
            blueBackground.BorderTop = BorderStyle.Thin;
            blueBackground.BorderRight = BorderStyle.Thin;
            blueBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle blueBackgroundAndFore = workbook.CreateCellStyle();
            blueBackgroundAndFore.FillForegroundColor = blueBackgroundColor;
            blueBackgroundAndFore.FillPattern = FillPattern.SolidForeground;
            blueBackgroundAndFore.SetFont(fontColor);
            blueBackgroundAndFore.BorderLeft = BorderStyle.Thin;
            blueBackgroundAndFore.BorderTop = BorderStyle.Thin;
            blueBackgroundAndFore.BorderRight = BorderStyle.Thin;
            blueBackgroundAndFore.BorderBottom = BorderStyle.Thin;

            ICellStyle borderedCellStyle = workbook.CreateCellStyle();
            borderedCellStyle.BorderLeft = BorderStyle.Thin;
            borderedCellStyle.BorderTop = BorderStyle.Thin;
            borderedCellStyle.BorderRight = BorderStyle.Thin;
            borderedCellStyle.BorderBottom = BorderStyle.Thin;

            //-------------------------------------------------------------------------------------------
            //  Writing
            //-------------------------------------------------------------------------------------------
            int rowIndex = 0;
            IRow currentRow = FormatInfo.CreateRow(rowIndex);

            //User data - Title only
            ICell userDataCell = currentRow.CreateCell(0);
            userDataCell.CellStyle = pinkBackground;
            userDataCell.SetCellValue("User Data");

            //Effect Format Codes - Key and Value
            rowIndex = 6;
            currentRow = FormatInfo.CreateRow(rowIndex);

            ICell EffectFormatCodesCell = currentRow.CreateCell(0);
            EffectFormatCodesCell.CellStyle = pinkBackground;
            EffectFormatCodesCell.SetCellValue("Effect Format Codes");

            ICell EffectFormatCodesValueCell = currentRow.CreateCell(1);
            EffectFormatCodesValueCell.SetCellValue("These are the format codes that are supported by the help window. Typically these format codes allow you to change the font colour before or during the text, add command buttons EG page down, exit button)");


            //Start with descriptions of each tag
            rowIndex++;
            currentRow = FormatInfo.CreateRow(rowIndex);

            ICell ShowExitButtonCell = currentRow.CreateCell(0);
            ShowExitButtonCell.CellStyle = blueBackgroundAndFore;
            ShowExitButtonCell.SetCellValue("Show Exit Button");

            //Print Other Options
            string[,] formatCodes = new string[83, 2]
            {
                { "<E>", "Show exit button" },
                { "Show Page Down Button", "" },
                { "<P>", "End of page marker (Shows page down if we have no control buttons)" },
                { "Insert Button", "" },
                { "<B Type, ID>", "Create button of type 'Type' with return value of ID" },
                { "<B ID>", "Creates a default select button with return value of ID" },
                { "Insert Less Than", "" },
                { "<LT>", "Insert a less than character ( < )" },
                { "Insert More Than", "" },
                { "<MT>", "Insert a more than character ( > )" },
                { "Insert New Line", "" },
                { "<N>", "Insert a new line" },
                { "End Effector", "" },
                { "<END What>", "End the specified effector EG <END TT> will end the last teletype effector" },
                { "Insert Item Icon", "" },
                { "<I Hashcode>", "Shows the specified item. The hashcode is the texture hashcode of the icon in the icon elf file." },
                { "<I Hashcode, Width, Height>", "As above except you can specify the width and height of the item in pixels." },
                { "", "" },
                { "", "" },
                { "", "" },
                { "", "" },
                { "Teletype", "" },
                { "<TT>", "Teletype text from the current text position" },
                { "Teletype Fade", "" },
                { "<TTF>", "Teletypes text and also fades it onto the screen" },
                { "Font Colour", "" },
                { "<FC Red, Green,Blue>", "Change the font colour to the specified values. Colour values should range from 0-128" },
                { "Font Type", "" },
                { "<FT Hashcode>", "Sets the current font to the given style" },
                { "Wait", "" },
                { "<W Time>", "This will cause the help window to automatically clear after the specified Time (30ths of a second) if the player does not clear the window before. If there are more pages to be displayed the next page is automatically displayed." },
                { "Sine Wave", "" },
                { "<SW Amp, Freq>", "Makes the text oscillate in a sine wave fashion with the specified frequency and amplitude in pixels." },
                { "<SW Amp>", "As above but requires only the amplitude, default frequency will be used" },
                { "<SW>", "Does sine wave text with the default values (Amplitude = 10, Frequency = 1)" },
                { "Colour Cycle", "" },
                { "<CC Speed, r1,g1,b1,a1…>", "Cycle through the specified colours at the given speed(30ths of a second) (There should be at least two colours)" },
                { "<CC r1,g1,b1,a1…>", "Cycle through the specified colours at the default speed." },
                { "Alpha Cycle", "" },
                { "<AC Speed a1,a2…>", "Cycles the alpha values at the given speed(30ths of a second). (There should always be at least two alphas)" },
                { "Shakey Text", "" },
                { "<ST Variance>", "Shakes the text by the given amount" },
                { "<ST Variance,Speed>", "Shakes the text by the given speed (30ths of a second) and variance" },
                { "<ST>", "Shakes the text by the default amount (Speed = 2, Variance = 2)" },
                { "Circle Text", "" },
                { "<CT>", "Circles the text with the default radius,frequency and speed (Speed = 35, Radius = 6, Frequency = 2)" },
                { "<CT Frequency>", @"""But with the specified frequency" },
                { "<CT Freq, Speed>", @""" But with specified speed(30ths of a second) and frequency" },
                { "<CT Freq, Speed, Radius>", "Circles the text with the specified frequency, speed(30ths of a second) and radius" },
                { "Show Objective Variable", "" },
                { "<SO Hashcode>", "Shows the value of the given objective variable with the specified hashcode" },
                { "Do Text Effect String", "" },
                { "<ES Hashcode>", "Inserts all the effects stored in the string with the given hashcode at the current position" },
                { "Falling text", "" },
                { "<RT>", "Text will fall into position from the top of the screen" },
                { "<RT Speed>", "" },
                { "Fade In", "" },
                { "<FI>", "Fades the text in with no delay over the default duration" },
                { "<FI Duration>", @""" With the specified duration (In 30ths of a second)" },
                { "<FI Duration, WaitDelay>", @"""With the specified duration AND waits the specified time before starting (Also in 30ths of a second)" },
                { "Fountain", "" },
                { "<FTN>", "Fires all of the text out of a fountaining from the centre of the help window" },
                { "<FTN MaxDuration>", @""" The maximum time for a character to land will be this time (In 30ths of a second)" },
                { "<FTN MaxDuration, MinDuration>", @"""The minimum time for a character to land can also be set (This should always be less than maxduration)" },
                { "Random font colour change", "" },
                { "<RFC>", "This changes the fonts colour to a random value at the specified rate." },
                { "<RFC FlashRate>", @""" Flashes at the specified frequency (30ths of a second)" },
                { "Disable all gamepad testing", "" },
                { "<DP>", "This stops the gamepad from being used by the Help window. This allows text to be display without effecting how the buttons work for the player. This formatter should be used with a wait text or have a script to clear the help window, otherwise the text will never be removed." },
                { "Stop Gamepad being hidden", "" },
                { "<DHP>", "This stops the default functionality of the help window hiding the onscreen gamepad" },
                { "Central justification of text", "" },
                { "<CNTR>", "This indicates that the text should be central justified instead of left aligned" },
                { "Dynamic code", "" },
                { "<DC What ObjectiveID1, ObjectID2>", "What Values..{ObjectID's go from 0-9)" },
                { "", "1 = Insert icon, ObjectiveID1 = Objective variable with Icon hashcode in, ObjectiveID2 = Objective variable with the file hashcode in. The fourth and fifth parameters is the items width and height but are optional." },
                { "Show gamepad button", "" },
                { "<SB HT_Action_XX>", "This causes the graphic image of the button used for the given show button context" },
                { "Position Text Carrot", "" },
                { "<PC 1>", "This positions the carrot position half way across the help window (Allowing you to align items/text down the centre of the window)" },
                { "<PC 2, Percentage>", "This positions the carrot by the given percentage of the help windows width EG current carrot pos = (Percentage / 100) * (Window Width)" },
                { "", "" },
                { "", "" }
            };

            for (int i = 0; i < formatCodes.GetLength(0); i++)
            {
                rowIndex++;

                currentRow = FormatInfo.CreateRow(rowIndex);
                ICell markerName = currentRow.CreateCell(0);
                markerName.CellStyle = blueBackgroundAndFore;
                if (formatCodes[i, 0].StartsWith("<"))
                {
                    markerName.CellStyle = blueBackground;
                }
                markerName.SetCellValue(formatCodes[i, 0]);

                ICell markerDesc = currentRow.CreateCell(1);
                markerDesc.CellStyle = borderedCellStyle;
                markerDesc.SetCellValue(formatCodes[i, 1]);

                asyncWorker.ReportProgress((i * 100) / formatCodes.GetLength(0), string.Join(" ", "Effect Format Codes:", formatCodes[i, 0], formatCodes[i, 1]));
            }

            //Set size
            FormatInfo.AutoSizeColumn(0);
            FormatInfo.AutoSizeColumn(1);
        }
    }
    //-------------------------------------------------------------------------------------------------------------------------------
}
