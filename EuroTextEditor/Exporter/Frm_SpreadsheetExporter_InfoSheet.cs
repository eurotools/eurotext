using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_SpreadsheetExporter
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal void CreateFormatInfoSheet(ISheet formatInfo, IWorkbook workbook)
        {
            //-------------------------------------------------------------------------------------------
            //  Fonts and Palette
            //-------------------------------------------------------------------------------------------
            IFont font = workbook.CreateFont();
            font.FontName = "Arial";

            HSSFPalette palette = ((HSSFWorkbook)workbook).GetCustomPalette();

            // Create styles
            ICellStyle pinkBackground = CreateCellStyle(workbook, font, palette, 45, 255, 153, 204);
            ICellStyle blueBackground = CreateCellStyle(workbook, font, palette, 46, 204, 255, 255);
            ICellStyle grayBackground = CreateCellStyle(workbook, font, palette, 47, 192, 192, 192, addBorders: false);
            ICellStyle borderedCellStyle = CreateBorderedStyle(workbook, font);

            //-------------------------------------------------------------------------------------------
            //  Writing Sections
            //-------------------------------------------------------------------------------------------
            int rowIndex = 0;

            // Add position markers section
            rowIndex = AddSection(formatInfo, rowIndex, pinkBackground, blueBackground, borderedCellStyle,
                "Position markers", new string[,]
                {
                    { "MARKER_HASHCODE", "This marker indicates the column that the message hash codes are in." },
                    { "MARKER_DATA_START", "This marker indicates the start of the data columns." },
                    { "MARKER_DATA_END", "This marker indicates the end of the data columns." },
                    { "MARKER_FORMAT_ROW", "The row that this marker is on is the format row that dictates how the column data will be exported." },
                    { "MARKER_LANGUAGE_START", "This marks the start of the language columns" },
                    { "MARKER_LANGUAGE_END", "This marks the end of the language columns" },
                    { "MARKER_LEVEL_START", "This marks the start of the level information columns" },
                    { "MARKER_LEVEL_END", "This marks the end of the level information columns" },
                    { "MARKER_SOUND_START", "This marks the start of the sound information" },
                    { "MARKER_SOUND_END", "This marks the end of the sound information" },
                    { "MARKER_LAST_MESSAGE", "This marks the end of the spreadsheet" },
                    { "MARKER_END_OF_SHEET", "This marks the last column of the spreadsheet" },
                    {"","" }
                });

            // Add gray line
            AddGrayRow(formatInfo, ref rowIndex, grayBackground);

            // Add data type markers section
            rowIndex = AddSection(formatInfo, rowIndex, pinkBackground, blueBackground, borderedCellStyle,
                "Data Type markers", new string[,]
                {
                    { "U8", "Unsigned 8 bit" },
                    { "U16", "Unsigned 16 bit" },
                    { "U32", "Unsigned 32 bit" },
                    { "U64", "Unsigned 64 bit" },
                    { "U128", "Unsigned 128 bit" },
                    { "S8", "Signed 8 bit" },
                    { "S16", "Signed 16 bit" },
                    { "S32", "Signed 32 bit" },
                    { "S64", "Signed 64 bit" },
                    { "BOOL", "8 bit bool" },
                    { "FLOAT", "Floating point number" },
                    { "DOUBLE", "Double" },
                    { "BIT_0 -> BIT_31", "Bit flags zero to thirty one." },
                    { "STRING", "character string" },
                    { "LEVEL", "This indicates a that the cell above indicates what level the column is refering to" },
                    { "HASHCODE", "This indicates that the column holds a hashcode" }
                });

            // Add blank row
            AddBlankRow(formatInfo, ref rowIndex);

            // Add blank row
            AddBlankRow(formatInfo, ref rowIndex);

            // Add gray line
            AddGrayRow(formatInfo, ref rowIndex, grayBackground);

            // Add misc markers section
            rowIndex = AddSection(formatInfo, rowIndex, pinkBackground, blueBackground, borderedCellStyle,
                "Misc markers", new string[,]
                {
                    { "SHEET_TYPE_TEXT", "This is the marker that goes in the first column of the spreadsheet indicating that this is a text message based spreadsheet" },
                    {"","" }
                });


            // Add gray line
            AddGrayRow(formatInfo, ref rowIndex, grayBackground);

            // Add language markers section
            rowIndex = AddSection(formatInfo, rowIndex, pinkBackground, blueBackground, borderedCellStyle,
                "Language Markers", new string[,]
                {
                    { "MARKER_ENGLISH", "" },
                    { "MARKER_AMERICAN", "" },
                    { "MARKER_GERMAN", "" },
                    { "MARKER_FRENCH", "" },
                    { "MARKER_SPANISH", "" },
                    { "MARKER_DUTCH", "" },
                    { "MARKER_NORWEGIAN", "" },
                    { "MARKER_FINNISH", "" },
                    { "MARKER_ITALIAN", "" },
                    { "MARKER_DANISH", "" },
                    { "MARKER_SWEDISH", "" },
                    { "MARKER_PORTUGESE", "" }
                });

            // Add gray line
            AddGrayRow(formatInfo, ref rowIndex, grayBackground);

            // Auto-size columns
            formatInfo.AutoSizeColumn(0);
            formatInfo.AutoSizeColumn(1);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void AddBlankRow(ISheet sheet, ref int rowIndex)
        {
            sheet.CreateRow(rowIndex++);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private ICellStyle CreateCellStyle(IWorkbook workbook, IFont font, HSSFPalette palette, short colorIndex, byte r, byte g, byte b, bool addBorders = true)
        {
            palette.SetColorAtIndex(colorIndex, r, g, b);

            ICellStyle style = workbook.CreateCellStyle();
            style.FillForegroundColor = colorIndex;
            style.FillPattern = FillPattern.SolidForeground;
            style.SetFont(font);

            if (addBorders)
            {
                style.BorderLeft = BorderStyle.Thin;
                style.BorderTop = BorderStyle.Thin;
                style.BorderRight = BorderStyle.Thin;
                style.BorderBottom = BorderStyle.Thin;
            }

            return style;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private ICellStyle CreateBorderedStyle(IWorkbook workbook, IFont font)
        {
            ICellStyle style = workbook.CreateCellStyle();
            if (font != null)
            {
                style.SetFont(font);
            }
            style.BorderLeft = BorderStyle.Thin;
            style.BorderTop = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            style.BorderBottom = BorderStyle.Thin;
            return style;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private int AddSection(ISheet sheet, int rowIndex, ICellStyle headerStyle, ICellStyle subHeaderStyle, ICellStyle bodyStyle, string sectionTitle, string[,] content)
        {
            IRow row = sheet.CreateRow(rowIndex++);
            row.CreateCell(0).SetCellValue(sectionTitle);
            row.GetCell(0).CellStyle = headerStyle;

            row.CreateCell(1).SetCellValue("Description");
            row.GetCell(1).CellStyle = subHeaderStyle;

            for (int i = 0; i < content.GetLength(0); i++)
            {
                row = sheet.CreateRow(rowIndex++);
                row.CreateCell(0).SetCellValue(content[i, 0]);
                row.GetCell(0).CellStyle = bodyStyle;

                row.CreateCell(1).SetCellValue(content[i, 1]);
                row.GetCell(1).CellStyle = bodyStyle;
            }

            return rowIndex;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void AddGrayRow(ISheet sheet, ref int rowIndex, ICellStyle grayStyle)
        {
            IRow row = sheet.CreateRow(rowIndex++);
            ICell cell = row.CreateCell(0);
            cell.CellStyle = grayStyle;
            row.CreateCell(1).CellStyle = grayStyle;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
