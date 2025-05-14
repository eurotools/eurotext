using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmMain
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal void CreateConfigSheet(ISheet formatInfo, IWorkbook workbook)
        {
            //-------------------------------------------------------------------------------------------
            //  Fonts
            //-------------------------------------------------------------------------------------------
            IFont titleFont = CreateFont(workbook, "Arial", 16);
            IFont font = CreateFont(workbook, "Arial", 12);

            //-------------------------------------------------------------------------------------------
            //  Styles
            //-------------------------------------------------------------------------------------------
            HSSFPalette palette = ((HSSFWorkbook)workbook).GetCustomPalette();

            ICellStyle pinkBackground = CreateCellStyle(workbook, palette, titleFont, 255, 153, 204);
            ICellStyle blueBackgroundCenter = CreateCellStyle(workbook, palette, font, 204, 255, 255, NPOI.SS.UserModel.HorizontalAlignment.Center);
            ICellStyle blueBackground = CreateCellStyle(workbook, palette, font, 204, 255, 255);
            ICellStyle grayBackground = CreateCellStyle(workbook, palette, font, 192, 192, 192);

            //-------------------------------------------------------------------------------------------
            //  Writing
            //-------------------------------------------------------------------------------------------
            int rowIndex = 0;

            AddRow(formatInfo, rowIndex++, "Configuration settings", pinkBackground);
            AddBlankRow(formatInfo, ref rowIndex);
            AddRow(formatInfo, rowIndex++, "Enable Hashcode exporting", grayBackground, "1", blueBackgroundCenter);
            AddRow(formatInfo, rowIndex++, "Hashcode admin file path", grayBackground, @"x:\enginex\utils\htadmin.exe", blueBackground);
            AddRow(formatInfo, rowIndex++, "Message Hashcode section", grayBackground, "HT_Text", blueBackground);

            // Set column sizes
            AutoSizeColumns(formatInfo, 2);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private IFont CreateFont(IWorkbook workbook, string fontName, short fontSize)
        {
            IFont font = workbook.CreateFont();
            font.FontName = fontName;
            font.FontHeightInPoints = fontSize;
            return font;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private ICellStyle CreateCellStyle(IWorkbook workbook, HSSFPalette palette, IFont font, int r, int g, int b, NPOI.SS.UserModel.HorizontalAlignment alignment = NPOI.SS.UserModel.HorizontalAlignment.General)
        {
            short colorIndex = palette.FindSimilarColor((byte)r, (byte)g, (byte)b).Indexed;
            ICellStyle style = workbook.CreateCellStyle();
            style.FillForegroundColor = colorIndex;
            style.FillPattern = FillPattern.SolidForeground;
            style.SetFont(font);
            style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style.Alignment = alignment;
            return style;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void AddRow(ISheet sheet, int rowIndex, string key, ICellStyle keyStyle, string value = null, ICellStyle valueStyle = null)
        {
            IRow row = sheet.CreateRow(rowIndex);
            ICell keyCell = row.CreateCell(0);
            keyCell.CellStyle = keyStyle;
            keyCell.SetCellValue(key);

            if (value != null && valueStyle != null)
            {
                ICell valueCell = row.CreateCell(1);
                valueCell.CellStyle = valueStyle;
                valueCell.SetCellValue(value);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void AutoSizeColumns(ISheet sheet, int columnCount)
        {
            for (int i = 0; i < columnCount; i++)
            {
                sheet.AutoSizeColumn(i);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
