using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    partial class ExcelWritters
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal void CreateMessagesSheet(ISheet Messages, IWorkbook workbook)
        {
            int rowIndex = 0;

            //Styles
            HSSFPalette palette = ((HSSFWorkbook)workbook).GetCustomPalette();

            //Bold and underline font
            IFont font = workbook.CreateFont();
            font.FontName = "Arial";
            font.IsBold = true;
            font.Underline = FontUnderlineType.Single;

            //Styles
            ICellStyle redBackground = workbook.CreateCellStyle();
            redBackground.FillForegroundColor = HSSFColor.Red.Index;
            redBackground.FillPattern = FillPattern.SolidForeground;
            redBackground.Rotation = 90;
            redBackground.SetFont(font);

            ICellStyle pinkBackground = workbook.CreateCellStyle();
            short pinkBackgroundColor = 45;
            palette.SetColorAtIndex(pinkBackgroundColor, 255, 153, 204);
            pinkBackground.FillForegroundColor = pinkBackgroundColor;
            pinkBackground.FillPattern = FillPattern.SolidForeground;
            pinkBackground.SetFont(font);

            ICellStyle blueBackground = workbook.CreateCellStyle();
            short blueBackgroundColor = 46;
            palette.SetColorAtIndex(blueBackgroundColor, 204, 255, 255);
            blueBackground.FillForegroundColor = blueBackgroundColor;
            blueBackground.FillPattern = FillPattern.SolidForeground;
            blueBackground.SetFont(font);

            ICellStyle grayBackground = workbook.CreateCellStyle();
            short grayBackgroundColor = 47;
            palette.SetColorAtIndex(grayBackgroundColor, 192, 192, 192);
            grayBackground.FillForegroundColor = grayBackgroundColor;
            grayBackground.FillPattern = FillPattern.SolidForeground;

            //Header row
            IRow headerRow = Messages.CreateRow(rowIndex);
            headerRow.CreateCell(0).SetCellValue("SHEET_TYPE_TEXT");

            ICell maxNumOfChannelsCell = headerRow.CreateCell(1);
            maxNumOfChannelsCell.CellStyle = redBackground;
            maxNumOfChannelsCell.SetCellValue("Max Num Of Chars");

            ICell deadTextCell = headerRow.CreateCell(2);
            deadTextCell.CellStyle = redBackground;
            deadTextCell.SetCellValue("Dead Text");

            ICell hashcodesCell = headerRow.CreateCell(3);
            hashcodesCell.CellStyle = pinkBackground;
            hashcodesCell.SetCellValue("Hash Codes");

            ICell emptyCell = headerRow.CreateCell(4);
            emptyCell.CellStyle = grayBackground;
            emptyCell.SetCellValue(" ");

            ICell languagesCell = headerRow.CreateCell(5);
            languagesCell.CellStyle = blueBackground;
            languagesCell.SetCellValue("Languages");

            //Messages.SetRowGroupCollapsed(0, true);
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
