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
        internal void CreateFormatInfoSheet(ISheet FormatInfo, IWorkbook workbook)
        {
            int rowIndex = 0;

            //Styles
            HSSFPalette palette = ((HSSFWorkbook)workbook).GetCustomPalette();

            //Bold and underline font
            IFont font = workbook.CreateFont();
            font.FontName = "Arial";

            //Styles
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

            ICellStyle grayBackground = workbook.CreateCellStyle();
            short grayBackgroundColor = 47;
            palette.SetColorAtIndex(grayBackgroundColor, 192, 192, 192);
            grayBackground.FillForegroundColor = grayBackgroundColor;
            grayBackground.FillPattern = FillPattern.SolidForeground;

            ICellStyle borderedCellStyle = workbook.CreateCellStyle();
            borderedCellStyle.BorderLeft = BorderStyle.Thin;
            borderedCellStyle.BorderTop = BorderStyle.Thin;
            borderedCellStyle.BorderRight = BorderStyle.Thin;
            borderedCellStyle.BorderBottom = BorderStyle.Thin;

            //Create a new row
            IRow currentRow = FormatInfo.CreateRow(rowIndex);

            //Print POSITION MARKERS Section
            ICell posMarkersCell = currentRow.CreateCell(0);
            posMarkersCell.CellStyle = pinkBackground;
            posMarkersCell.SetCellValue("Position markers");

            ICell posMarkersDescCell = currentRow.CreateCell(1);
            posMarkersDescCell.CellStyle = blueBackground;
            posMarkersDescCell.SetCellValue("Description");

            string[,] positionMarkers = new string[12, 2]
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
                { "MARKER_END_OF_SHEET", "This marks the last column of the spreadsheet" }
            };

            for (int i = 0; i < positionMarkers.GetLength(0); i++)
            {
                rowIndex++;

                currentRow = FormatInfo.CreateRow(rowIndex);
                ICell markerName = currentRow.CreateCell(0);
                markerName.CellStyle = borderedCellStyle;
                markerName.SetCellValue(positionMarkers[i, 0]);

                ICell markerDesc = currentRow.CreateCell(1);
                markerDesc.CellStyle = borderedCellStyle;
                markerDesc.SetCellValue(positionMarkers[i, 1]);
            }

            //Empty Row
            rowIndex++;
            AddEmptyRow(ref currentRow, rowIndex, FormatInfo, borderedCellStyle);

            //Create gray line
            rowIndex++;
            AddGrayRow(ref currentRow, rowIndex, FormatInfo, grayBackground);

            //Print DATA TYPE MARKERS
            rowIndex++;
            currentRow = FormatInfo.CreateRow(rowIndex);
            ICell dataTypeMarkerCell = currentRow.CreateCell(0);
            dataTypeMarkerCell.CellStyle = pinkBackground;
            dataTypeMarkerCell.SetCellValue("Data Type markers");

            ICell dataTypeMarkerDescCell = currentRow.CreateCell(1);
            dataTypeMarkerDescCell.CellStyle = blueBackground;
            dataTypeMarkerDescCell.SetCellValue("Description");

            string[,] DataTypeMarkers = new string[16, 2]
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
                { "BIT_0 -> BIT_31", "Bit flags zero to thirty one. " },
                { "STRING", "character string" },
                { "LEVEL", "This indicates a that the cell above indicates what level the column is refering to" },
                { "HASHCODE", "This indicates that the column holds a hashcode" }
            };

            for (int i = 0; i < DataTypeMarkers.GetLength(0); i++)
            {
                rowIndex++;

                currentRow = FormatInfo.CreateRow(rowIndex);
                ICell markerName = currentRow.CreateCell(0);
                markerName.CellStyle = borderedCellStyle;
                markerName.SetCellValue(DataTypeMarkers[i, 0]);

                ICell markerDesc = currentRow.CreateCell(1);
                markerDesc.CellStyle = borderedCellStyle;
                markerDesc.SetCellValue(DataTypeMarkers[i, 1]);
            }

            //Empty Row
            rowIndex++;
            AddEmptyRow(ref currentRow, rowIndex, FormatInfo, null);
            rowIndex++;
            AddEmptyRow(ref currentRow, rowIndex, FormatInfo, null);

            //Create gray line
            rowIndex++;
            AddGrayRow(ref currentRow, rowIndex, FormatInfo, grayBackground);

            //Print MISC MARKERS Section
            rowIndex++;
            currentRow = FormatInfo.CreateRow(rowIndex);
            ICell miscMarkerCell = currentRow.CreateCell(0);
            miscMarkerCell.CellStyle = pinkBackground;
            miscMarkerCell.SetCellValue("Misc markers");

            ICell miscMarkerDescCell = currentRow.CreateCell(1);
            miscMarkerDescCell.CellStyle = blueBackground;
            miscMarkerDescCell.SetCellValue("Description");

            rowIndex++;
            currentRow = FormatInfo.CreateRow(rowIndex);
            ICell miscMarkerName = currentRow.CreateCell(0);
            miscMarkerName.CellStyle = borderedCellStyle;
            miscMarkerName.SetCellValue("SHEET_TYPE_TEXT");

            ICell miscMarkerDesc = currentRow.CreateCell(1);
            miscMarkerDesc.CellStyle = borderedCellStyle;
            miscMarkerDesc.SetCellValue("This is the marker that goes in the first column of the spreadsheet indicating that this is a text message based spreadsheet");

            //Empty Row
            rowIndex++;
            AddEmptyRow(ref currentRow, rowIndex, FormatInfo, borderedCellStyle);

            //Create gray line
            rowIndex++;
            AddGrayRow(ref currentRow, rowIndex, FormatInfo, grayBackground);

            //Print Language Markers Section
            rowIndex++;
            currentRow = FormatInfo.CreateRow(rowIndex);
            ICell langMarkersCell = currentRow.CreateCell(0);
            langMarkersCell.CellStyle = pinkBackground;
            langMarkersCell.SetCellValue("Language Markers");

            ICell langMarkersDescCell = currentRow.CreateCell(1);
            langMarkersDescCell.CellStyle = blueBackground;
            langMarkersDescCell.SetCellValue("Description");

            string[,] languageMarkers = new string[12, 2]
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
            };

            for (int i = 0; i < languageMarkers.GetLength(0); i++)
            {
                rowIndex++;

                currentRow = FormatInfo.CreateRow(rowIndex);
                ICell markerName = currentRow.CreateCell(0);
                markerName.CellStyle = borderedCellStyle;
                markerName.SetCellValue(languageMarkers[i, 0]);

                ICell markerDesc = currentRow.CreateCell(1);
                markerDesc.CellStyle = borderedCellStyle;
                markerDesc.SetCellValue(languageMarkers[i, 1]);
            }

            //Create gray line
            rowIndex++;
            AddGrayRow(ref currentRow, rowIndex, FormatInfo, grayBackground);

            //Set size
            FormatInfo.AutoSizeColumn(0);
            FormatInfo.AutoSizeColumn(1);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void AddGrayRow(ref IRow headerRow, int rowIndex, ISheet FormatInfo, ICellStyle grayBackground)
        {
            headerRow = FormatInfo.CreateRow(rowIndex);
            ICell grayLeft = headerRow.CreateCell(0);
            grayLeft.CellStyle = grayBackground;
            ICell grayRight = headerRow.CreateCell(1);
            grayRight.CellStyle = grayBackground;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
