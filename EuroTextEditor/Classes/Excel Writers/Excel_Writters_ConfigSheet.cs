using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace EuroTextEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    partial class ExcelWritters
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal void CreateConfigSheet(ISheet FormatInfo, IWorkbook workbook)
        {
            //-------------------------------------------------------------------------------------------
            //  Fonts
            //-------------------------------------------------------------------------------------------
            IFont titleFont = workbook.CreateFont();
            titleFont.FontName = "Arial";
            titleFont.FontHeightInPoints = 16;

            IFont font = workbook.CreateFont();
            font.FontName = "Arial";
            font.FontHeightInPoints = 12;

            //-------------------------------------------------------------------------------------------
            //  Styles
            //-------------------------------------------------------------------------------------------
            HSSFPalette palette = ((HSSFWorkbook)workbook).GetCustomPalette();

            ICellStyle pinkBackground = workbook.CreateCellStyle();
            short pinkBackgroundColor = 45;
            palette.SetColorAtIndex(pinkBackgroundColor, 255, 153, 204);
            pinkBackground.FillForegroundColor = pinkBackgroundColor;
            pinkBackground.FillPattern = FillPattern.SolidForeground;
            pinkBackground.SetFont(titleFont);
            pinkBackground.BorderLeft = BorderStyle.Thin;
            pinkBackground.BorderTop = BorderStyle.Thin;
            pinkBackground.BorderRight = BorderStyle.Thin;
            pinkBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle blueBackgroundCenter = workbook.CreateCellStyle();
            short blueBackgroundColor = 46;
            palette.SetColorAtIndex(blueBackgroundColor, 204, 255, 255);
            blueBackgroundCenter.FillForegroundColor = blueBackgroundColor;
            blueBackgroundCenter.FillPattern = FillPattern.SolidForeground;
            blueBackgroundCenter.SetFont(font);
            blueBackgroundCenter.BorderLeft = BorderStyle.Thin;
            blueBackgroundCenter.BorderTop = BorderStyle.Thin;
            blueBackgroundCenter.BorderRight = BorderStyle.Thin;
            blueBackgroundCenter.BorderBottom = BorderStyle.Thin;
            blueBackgroundCenter.Alignment = HorizontalAlignment.Center;

            ICellStyle blueBackground = workbook.CreateCellStyle();
            palette.SetColorAtIndex(blueBackgroundColor, 204, 255, 255);
            blueBackground.FillForegroundColor = blueBackgroundColor;
            blueBackground.FillPattern = FillPattern.SolidForeground;
            blueBackground.SetFont(font);
            blueBackground.BorderLeft = BorderStyle.Thin;
            blueBackground.BorderTop = BorderStyle.Thin;
            blueBackground.BorderRight = BorderStyle.Thin;
            blueBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle grayBackground = workbook.CreateCellStyle();
            short grayBackgroundColor = 47;
            palette.SetColorAtIndex(grayBackgroundColor, 192, 192, 192);
            grayBackground.FillForegroundColor = grayBackgroundColor;
            grayBackground.FillPattern = FillPattern.SolidForeground;
            grayBackground.SetFont(font);
            grayBackground.BorderLeft = BorderStyle.Thin;
            grayBackground.BorderTop = BorderStyle.Thin;
            grayBackground.BorderRight = BorderStyle.Thin;
            grayBackground.BorderBottom = BorderStyle.Thin;

            //-------------------------------------------------------------------------------------------
            //  Writing
            //-------------------------------------------------------------------------------------------
            //Row
            int rowIndex = 0;
            IRow currentRow = FormatInfo.CreateRow(rowIndex);

            //Configuration Settings - Title only
            ICell posMarkersCell = currentRow.CreateCell(0);
            posMarkersCell.CellStyle = pinkBackground;
            posMarkersCell.SetCellValue("Configuration settings");

            //Create empty row and add a new one
            rowIndex++;
            AddEmptyRow(ref currentRow, rowIndex, FormatInfo, null);

            //Hashcodes Exporting - Key and Value
            rowIndex++;
            currentRow = FormatInfo.CreateRow(rowIndex);

            ICell hashcodeExporting = currentRow.CreateCell(0);
            hashcodeExporting.CellStyle = grayBackground;
            hashcodeExporting.SetCellValue("Enable Hashcode exporting");

            ICell hashcodeExportingValue = currentRow.CreateCell(1);
            hashcodeExportingValue.CellStyle = blueBackgroundCenter;
            hashcodeExportingValue.SetCellValue(1);

            //Admin File Path - Key and Value
            rowIndex++;
            currentRow = FormatInfo.CreateRow(rowIndex);

            ICell hashcodeAdminPath = currentRow.CreateCell(0);
            hashcodeAdminPath.CellStyle = grayBackground;
            hashcodeAdminPath.SetCellValue("Hashcode admin file path");

            ICell hashcodeAdminPathDesc = currentRow.CreateCell(1);
            hashcodeAdminPathDesc.CellStyle = blueBackground;
            hashcodeAdminPathDesc.SetCellValue(@"x:\enginex\utils\htadmin.exe");

            //Hashcode exporting
            rowIndex++;
            currentRow = FormatInfo.CreateRow(rowIndex);

            ICell hashcodeSection = currentRow.CreateCell(0);
            hashcodeSection.CellStyle = grayBackground;
            hashcodeSection.SetCellValue("Message Hashcode section");

            ICell hashcodeSectionMessage = currentRow.CreateCell(1);
            hashcodeSectionMessage.CellStyle = blueBackground;
            hashcodeSectionMessage.SetCellValue("HT_Text");

            //Set size
            FormatInfo.AutoSizeColumn(0);
            FormatInfo.AutoSizeColumn(1);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void AddEmptyRow(ref IRow headerRow, int rowIndex, ISheet FormatInfo, ICellStyle borderedCellStyle)
        {
            headerRow = FormatInfo.CreateRow(rowIndex);
            ICell emptyLeft = headerRow.CreateCell(0);
            if (borderedCellStyle != null)
            {
                emptyLeft.CellStyle = borderedCellStyle;
            }

            ICell emptyRight = headerRow.CreateCell(1);
            if (borderedCellStyle != null)
            {
                emptyRight.CellStyle = borderedCellStyle;
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
