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
        internal void CreateMessagesSheet(ISheet Messages, IWorkbook workbook, string[] outLevels, string[] textGroup, string[] textSections)
        {
            int rowIndex = 0;

            //Styles
            HSSFPalette palette = ((HSSFWorkbook)workbook).GetCustomPalette();

            //Bold and underline font
            IFont fontUnderline = workbook.CreateFont();
            fontUnderline.FontName = "Arial";
            fontUnderline.IsBold = true;
            fontUnderline.Underline = FontUnderlineType.Single;

            IFont font = workbook.CreateFont();
            fontUnderline.FontName = "Arial";
            fontUnderline.IsBold = true;

            //Styles
            ICellStyle VerticalCenter = workbook.CreateCellStyle();
            VerticalCenter.VerticalAlignment = VerticalAlignment.Center;
            VerticalCenter.Alignment = HorizontalAlignment.Center;
            VerticalCenter.BorderLeft = BorderStyle.Thin;
            VerticalCenter.BorderTop = BorderStyle.Thin;
            VerticalCenter.BorderRight = BorderStyle.Thin;
            VerticalCenter.BorderBottom = BorderStyle.Thin;

            ICellStyle redBackgroundVerticalCenter = workbook.CreateCellStyle();
            redBackgroundVerticalCenter.FillForegroundColor = HSSFColor.Red.Index;
            redBackgroundVerticalCenter.FillPattern = FillPattern.SolidForeground;
            redBackgroundVerticalCenter.Rotation = 90;
            redBackgroundVerticalCenter.VerticalAlignment = VerticalAlignment.Center;
            redBackgroundVerticalCenter.SetFont(fontUnderline);
            redBackgroundVerticalCenter.BorderLeft = BorderStyle.Thin;
            redBackgroundVerticalCenter.BorderTop = BorderStyle.Thin;
            redBackgroundVerticalCenter.BorderRight = BorderStyle.Thin;
            redBackgroundVerticalCenter.BorderBottom = BorderStyle.Thin;

            ICellStyle pinkBackgroundVerticalCenterUnderline = workbook.CreateCellStyle();
            short pinkBackgroundColor = 45;
            palette.SetColorAtIndex(pinkBackgroundColor, 255, 153, 204);
            pinkBackgroundVerticalCenterUnderline.FillForegroundColor = pinkBackgroundColor;
            pinkBackgroundVerticalCenterUnderline.FillPattern = FillPattern.SolidForeground;
            pinkBackgroundVerticalCenterUnderline.VerticalAlignment = VerticalAlignment.Center;
            pinkBackgroundVerticalCenterUnderline.Alignment = HorizontalAlignment.Center;
            pinkBackgroundVerticalCenterUnderline.SetFont(fontUnderline);
            pinkBackgroundVerticalCenterUnderline.BorderLeft = BorderStyle.Thin;
            pinkBackgroundVerticalCenterUnderline.BorderTop = BorderStyle.Thin;
            pinkBackgroundVerticalCenterUnderline.BorderRight = BorderStyle.Thin;
            pinkBackgroundVerticalCenterUnderline.BorderBottom = BorderStyle.Thin;

            ICellStyle pinkBackgroundVerticalCenter = workbook.CreateCellStyle();
            palette.SetColorAtIndex(pinkBackgroundColor, 255, 153, 204);
            pinkBackgroundVerticalCenter.FillForegroundColor = pinkBackgroundColor;
            pinkBackgroundVerticalCenter.FillPattern = FillPattern.SolidForeground;
            pinkBackgroundVerticalCenter.SetFont(font);
            pinkBackgroundVerticalCenter.BorderLeft = BorderStyle.Thin;
            pinkBackgroundVerticalCenter.BorderTop = BorderStyle.Thin;
            pinkBackgroundVerticalCenter.BorderRight = BorderStyle.Thin;
            pinkBackgroundVerticalCenter.BorderBottom = BorderStyle.Thin;

            ICellStyle blueBackgroundVerticalCenterUnderline = workbook.CreateCellStyle();
            short blueBackgroundColor = 46;
            palette.SetColorAtIndex(blueBackgroundColor, 204, 255, 255);
            blueBackgroundVerticalCenterUnderline.FillForegroundColor = blueBackgroundColor;
            blueBackgroundVerticalCenterUnderline.FillPattern = FillPattern.SolidForeground;
            blueBackgroundVerticalCenterUnderline.VerticalAlignment = VerticalAlignment.Center;
            blueBackgroundVerticalCenterUnderline.SetFont(fontUnderline);
            blueBackgroundVerticalCenterUnderline.BorderLeft = BorderStyle.Thin;
            blueBackgroundVerticalCenterUnderline.BorderTop = BorderStyle.Thin;
            blueBackgroundVerticalCenterUnderline.BorderRight = BorderStyle.Thin;
            blueBackgroundVerticalCenterUnderline.BorderBottom = BorderStyle.Thin;

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
            grayBackground.BorderLeft = BorderStyle.Thin;
            grayBackground.BorderTop = BorderStyle.Thin;
            grayBackground.BorderRight = BorderStyle.Thin;
            grayBackground.BorderBottom = BorderStyle.Thin;

            //-----------------Colors used in the levels sections-----------------
            ICellStyle greenBackground = workbook.CreateCellStyle();
            short greenBackgroundColor = 48;
            palette.SetColorAtIndex(greenBackgroundColor, 0, 255, 0);
            greenBackground.FillForegroundColor = greenBackgroundColor;
            greenBackground.FillPattern = FillPattern.SolidForeground;
            greenBackground.Rotation = 90;
            greenBackground.SetFont(fontUnderline);
            greenBackground.FillPattern = FillPattern.SolidForeground;
            greenBackground.BorderLeft = BorderStyle.Thin;
            greenBackground.BorderTop = BorderStyle.Thin;
            greenBackground.BorderRight = BorderStyle.Thin;
            greenBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle orangeBackground = workbook.CreateCellStyle();
            short orangeBackgroundColor = 49;
            palette.SetColorAtIndex(orangeBackgroundColor, 255, 204, 0);
            orangeBackground.FillForegroundColor = orangeBackgroundColor;
            orangeBackground.FillPattern = FillPattern.SolidForeground;
            orangeBackground.Rotation = 90;
            orangeBackground.SetFont(fontUnderline);
            orangeBackground.BorderLeft = BorderStyle.Thin;
            orangeBackground.BorderTop = BorderStyle.Thin;
            orangeBackground.BorderRight = BorderStyle.Thin;
            orangeBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle purpleBackground = workbook.CreateCellStyle();
            short purpleBackgroundColor = 50;
            palette.SetColorAtIndex(purpleBackgroundColor, 255, 0, 255);
            purpleBackground.FillForegroundColor = purpleBackgroundColor;
            purpleBackground.FillPattern = FillPattern.SolidForeground;
            purpleBackground.Rotation = 90;
            purpleBackground.SetFont(fontUnderline);
            purpleBackground.BorderLeft = BorderStyle.Thin;
            purpleBackground.BorderTop = BorderStyle.Thin;
            purpleBackground.BorderRight = BorderStyle.Thin;
            purpleBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle darkBlueBackground = workbook.CreateCellStyle();
            short darkBlueBackgroundColor = 51;
            palette.SetColorAtIndex(darkBlueBackgroundColor, 0, 204, 255);
            darkBlueBackground.FillForegroundColor = darkBlueBackgroundColor;
            darkBlueBackground.FillPattern = FillPattern.SolidForeground;
            darkBlueBackground.Rotation = 90;
            darkBlueBackground.SetFont(fontUnderline);
            darkBlueBackground.BorderLeft = BorderStyle.Thin;
            darkBlueBackground.BorderTop = BorderStyle.Thin;
            darkBlueBackground.BorderRight = BorderStyle.Thin;
            darkBlueBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle yellowBackground = workbook.CreateCellStyle();
            short yellowBackgroundColor = 52;
            palette.SetColorAtIndex(yellowBackgroundColor, 255, 255, 0);
            yellowBackground.FillForegroundColor = yellowBackgroundColor;
            yellowBackground.FillPattern = FillPattern.SolidForeground;
            yellowBackground.Rotation = 90;
            yellowBackground.SetFont(fontUnderline);
            yellowBackground.BorderLeft = BorderStyle.Thin;
            yellowBackground.BorderTop = BorderStyle.Thin;
            yellowBackground.BorderRight = BorderStyle.Thin;
            yellowBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle orangeLightBackgroundUnderline = workbook.CreateCellStyle();
            short orangeLightBackgroundColor = 53;
            palette.SetColorAtIndex(orangeLightBackgroundColor, 255, 204, 153);
            orangeLightBackgroundUnderline.FillForegroundColor = orangeLightBackgroundColor;
            orangeLightBackgroundUnderline.FillPattern = FillPattern.SolidForeground;
            orangeLightBackgroundUnderline.Rotation = 90;
            orangeLightBackgroundUnderline.VerticalAlignment = VerticalAlignment.Center;
            orangeLightBackgroundUnderline.Alignment = HorizontalAlignment.Center;
            orangeLightBackgroundUnderline.SetFont(fontUnderline);
            orangeLightBackgroundUnderline.BorderLeft = BorderStyle.Thin;
            orangeLightBackgroundUnderline.BorderTop = BorderStyle.Thin;
            orangeLightBackgroundUnderline.BorderRight = BorderStyle.Thin;
            orangeLightBackgroundUnderline.BorderBottom = BorderStyle.Thin;

            ICellStyle orangeLightBackground = workbook.CreateCellStyle();
            palette.SetColorAtIndex(orangeLightBackgroundColor, 255, 204, 153);
            orangeLightBackground.FillForegroundColor = orangeLightBackgroundColor;
            orangeLightBackground.FillPattern = FillPattern.SolidForeground;
            orangeLightBackground.Alignment = HorizontalAlignment.Center;
            orangeLightBackground.SetFont(font);
            orangeLightBackground.BorderLeft = BorderStyle.Thin;
            orangeLightBackground.BorderTop = BorderStyle.Thin;
            orangeLightBackground.BorderRight = BorderStyle.Thin;
            orangeLightBackground.BorderBottom = BorderStyle.Thin;

            //-----------------Game Data and Sound INformation-----------------
            ICellStyle grayUnderlineBackground = workbook.CreateCellStyle();
            palette.SetColorAtIndex(grayBackgroundColor, 192, 192, 192);
            grayUnderlineBackground.FillForegroundColor = grayBackgroundColor;
            grayUnderlineBackground.FillPattern = FillPattern.SolidForeground;
            grayUnderlineBackground.VerticalAlignment = VerticalAlignment.Center;
            grayUnderlineBackground.SetFont(fontUnderline);
            grayUnderlineBackground.BorderLeft = BorderStyle.Thin;
            grayUnderlineBackground.BorderTop = BorderStyle.Thin;
            grayUnderlineBackground.BorderRight = BorderStyle.Thin;
            grayUnderlineBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle limeBackground = workbook.CreateCellStyle();
            short limeBackgroundColor = 55;
            palette.SetColorAtIndex(limeBackgroundColor, 204, 255, 204);
            limeBackground.FillForegroundColor = limeBackgroundColor;
            limeBackground.FillPattern = FillPattern.SolidForeground;
            limeBackground.VerticalAlignment = VerticalAlignment.Center;
            limeBackground.Alignment = HorizontalAlignment.Center;
            limeBackground.SetFont(fontUnderline);
            limeBackground.BorderLeft = BorderStyle.Thin;
            limeBackground.BorderTop = BorderStyle.Thin;
            limeBackground.BorderRight = BorderStyle.Thin;
            limeBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle limeBackgroundNoUnderline = workbook.CreateCellStyle();
            palette.SetColorAtIndex(limeBackgroundColor, 204, 255, 204);
            limeBackgroundNoUnderline.FillForegroundColor = limeBackgroundColor;
            limeBackgroundNoUnderline.FillPattern = FillPattern.SolidForeground;
            limeBackgroundNoUnderline.Alignment = HorizontalAlignment.Center;
            limeBackgroundNoUnderline.SetFont(font);
            limeBackgroundNoUnderline.BorderLeft = BorderStyle.Thin;
            limeBackgroundNoUnderline.BorderTop = BorderStyle.Thin;
            limeBackgroundNoUnderline.BorderRight = BorderStyle.Thin;
            limeBackgroundNoUnderline.BorderBottom = BorderStyle.Thin;

            ICellStyle yellowTextGroup = workbook.CreateCellStyle();
            short yellowTextGroupColor = 56;
            palette.SetColorAtIndex(yellowTextGroupColor, 255, 255, 153);
            yellowTextGroup.FillForegroundColor = yellowTextGroupColor;
            yellowTextGroup.FillPattern = FillPattern.SolidForeground;
            yellowTextGroup.BorderLeft = BorderStyle.Thin;
            yellowTextGroup.BorderTop = BorderStyle.Thin;
            yellowTextGroup.BorderRight = BorderStyle.Thin;
            yellowTextGroup.BorderBottom = BorderStyle.Thin;

            ICellStyle lightPurple = workbook.CreateCellStyle();
            short lightPurpleColor = 57;
            palette.SetColorAtIndex(lightPurpleColor, 204, 153, 255);
            lightPurple.Alignment = HorizontalAlignment.Center;
            lightPurple.FillForegroundColor = lightPurpleColor;
            lightPurple.FillPattern = FillPattern.SolidForeground;
            lightPurple.BorderLeft = BorderStyle.Thin;
            lightPurple.BorderTop = BorderStyle.Thin;
            lightPurple.BorderRight = BorderStyle.Thin;
            lightPurple.BorderBottom = BorderStyle.Thin;

            //Header row
            IRow headerRow = Messages.CreateRow(rowIndex);

            ICell sheetTypeCell = headerRow.CreateCell(0);
            sheetTypeCell.CellStyle = VerticalCenter;
            sheetTypeCell.SetCellValue("SHEET_TYPE_TEXT");

            ICell maxNumOfChannelsCell = headerRow.CreateCell(1);
            maxNumOfChannelsCell.CellStyle = redBackgroundVerticalCenter;
            maxNumOfChannelsCell.SetCellValue("Max Num Of Chars");

            ICell deadTextCell = headerRow.CreateCell(2);
            deadTextCell.CellStyle = redBackgroundVerticalCenter;
            deadTextCell.SetCellValue("Dead Text");

            ICell hashcodesCell = headerRow.CreateCell(3);
            hashcodesCell.CellStyle = pinkBackgroundVerticalCenterUnderline;
            hashcodesCell.SetCellValue("Hash Codes");

            ICell emptyCell = headerRow.CreateCell(4);
            emptyCell.CellStyle = grayBackground;
            emptyCell.SetCellValue(" ");

            ICell languagesCell = headerRow.CreateCell(5);
            languagesCell.CellStyle = blueBackgroundVerticalCenterUnderline;
            languagesCell.SetCellValue("Languages");

            for (int i = 0; i < 9; i++)
            {
                emptyCell = headerRow.CreateCell(6 + i);
                if (i > 6)
                {
                    emptyCell.CellStyle = grayBackground;
                }
                else
                {
                    emptyCell.CellStyle = VerticalCenter;
                }
            }

            //Print output levels
            int k = 0;
            int lastColIndex = 15;
            ICellStyle[] colorsLevels = new ICellStyle[] { greenBackground, orangeBackground, purpleBackground, darkBlueBackground, yellowBackground };
            for (int i = 0; i < outLevels.Length; i++, lastColIndex++)
            {
                //Ensure index not out of bounds
                if (k >= colorsLevels.Length)
                {
                    k = 0;
                }
                //Create cell
                ICell levelCell = headerRow.CreateCell(15 + i);
                if (i == 0)
                {
                    levelCell.CellStyle = orangeLightBackgroundUnderline;
                }
                else
                {
                    levelCell.CellStyle = colorsLevels[k];
                }
                levelCell.SetCellValue(outLevels[i]);
                k++;
            }

            //Print GameData
            for (int i = 0; i < 4; i++)
            {
                ICell gameDataCell = headerRow.CreateCell(lastColIndex + i);
                gameDataCell.CellStyle = grayUnderlineBackground;
                if (i == 1)
                {
                    gameDataCell.SetCellValue("Game Data");
                }
            }
            lastColIndex += 4;

            //Print Sound information
            ICell soundInfoCell = headerRow.CreateCell(lastColIndex);
            soundInfoCell.CellStyle = limeBackground;
            soundInfoCell.SetCellValue("Sound Information");

            lastColIndex += 2;
            for (int i = 0; i < 3; i++)
            {
                ICell emptyCells = headerRow.CreateCell(lastColIndex + i);
                emptyCells.CellStyle = grayBackground;
                emptyCells.SetCellValue("  ");
            }

            //--------------------------------------------------[Row 2]-------------------------------------------
            rowIndex++;
            headerRow = Messages.CreateRow(rowIndex);

            ICell grayCell = headerRow.CreateCell(4);
            grayCell.CellStyle = grayBackground;
            grayCell.SetCellValue("  ");

            //Print languages
            string[] languagesArray = new string[] { "English US", "English UK", "German", "French", "Spanish", "Italian", "Korean", "Japan" };
            for (int i = 0; i <languagesArray.Length; i++)
            {
                ICell langCell = headerRow.CreateCell(5 + i);
                langCell.CellStyle = blueBackground;
                langCell.SetCellValue(languagesArray[i]);
            }

            grayCell = headerRow.CreateCell(13);
            grayCell.CellStyle = grayBackground;
            grayCell.SetCellValue("  ");

            grayCell = headerRow.CreateCell(14);
            grayCell.CellStyle = grayBackground;
            grayCell.SetCellValue("  ");

            //Print text groups
            lastColIndex = 15;
            for (int i = 0; i < textSections.Length; i++, lastColIndex++)
            {
                //Create cell
                ICell levelCell = headerRow.CreateCell(15 + i);
                levelCell.CellStyle = yellowTextGroup;
                levelCell.SetCellValue(textSections[i]);
            }

            for (int i = 0; i < 4; i++)
            {
                ICell emptyCells = headerRow.CreateCell(lastColIndex++);
                emptyCells.CellStyle = grayBackground;
            }

            //Print Sound information
            ICell waveNameCell = headerRow.CreateCell(lastColIndex++);
            waveNameCell.CellStyle = limeBackgroundNoUnderline;
            waveNameCell.SetCellValue("Wave Name");
            Messages.AutoSizeColumn(lastColIndex - 1);

            //Ps2 name
            ICell ps2NameCell = headerRow.CreateCell(lastColIndex++);
            ps2NameCell.CellStyle = lightPurple;
            ps2NameCell.SetCellValue("PS2 Name");
            Messages.AutoSizeColumn(lastColIndex - 1);

            for (int i = 0; i < 3; i++)
            {
                ICell emptyCells = headerRow.CreateCell(lastColIndex++);
                emptyCells.CellStyle = grayBackground;
            }

            //Freeze two first rows
            Messages.CreateFreezePane(0, 2);


            //--------------------------------------------------[Row 3]-------------------------------------------
            rowIndex++;
            headerRow = Messages.CreateRow(rowIndex);


            for (int i = 0; i < 3; i++)
            {
                ICell emptyCells = headerRow.CreateCell(i);
                emptyCells.CellStyle = lightPurple;
                if (i == 0)
                {
                    emptyCells.SetCellValue("MARKER_FORMAT_ROW");
                }
            }

            ICell markerHashCodeCell = headerRow.CreateCell(3);
            markerHashCodeCell.CellStyle = pinkBackgroundVerticalCenter;
            markerHashCodeCell.SetCellValue("MARKER_HASHCODE");

            //Print language markers
            string[] languageMarkersArray = new string[] { "MARKER_LANGUAGE_START", "MARKER_ENGLISH_US", "MARKER_ENGLISH_UK", "MARKER_GERMAN", "MARKER_FRENCH", "MARKER_SPANISH", "MARKER_ITALIAN", "MARKER_KOREAN", "MARKER_JAPANESE", "MARKER_LANGUAGE_END" };
            for (int i = 0; i < languageMarkersArray.Length; i++)
            {
                ICell langCell = headerRow.CreateCell(4 + i);
                langCell.CellStyle = blueBackground;
                langCell.SetCellValue(languageMarkersArray[i]);
            }

            ICell markerLevelStart = headerRow.CreateCell(14);
            markerLevelStart.CellStyle = grayBackground;
            markerLevelStart.SetCellValue("MARKER_LEVEL_START");

            lastColIndex = 15;
            for (int i = 0; i < outLevels.Length; i++, lastColIndex++)
            {
                //Create cell
                ICell levelCell = headerRow.CreateCell(15 + i);
                levelCell.CellStyle = orangeLightBackground;
                levelCell.SetCellValue("LEVEL");
            }

            ICell markerLevelEnd = headerRow.CreateCell(lastColIndex++);
            markerLevelEnd.CellStyle = grayBackground;
            markerLevelEnd.SetCellValue("MARKER_LEVEL_END");

            ICell markerDataStart = headerRow.CreateCell(lastColIndex++);
            markerDataStart.CellStyle = grayBackground;
            markerDataStart.SetCellValue("MARKER_DATA_START");

            ICell markerDataEnd = headerRow.CreateCell(lastColIndex++);
            markerDataEnd.CellStyle = grayBackground;
            markerDataEnd.SetCellValue("MARKER_DATA_END");

            ICell markerSoundStart = headerRow.CreateCell(lastColIndex++);
            markerSoundStart.CellStyle = grayBackground;
            markerSoundStart.SetCellValue("MARKER_SOUND_START");

            ICell markerStringSound = headerRow.CreateCell(lastColIndex++);
            markerStringSound.CellStyle = limeBackgroundNoUnderline;
            markerStringSound.SetCellValue("STRING");

            ICell markerHashCodeSound = headerRow.CreateCell(lastColIndex++);
            markerHashCodeSound.CellStyle = limeBackgroundNoUnderline;
            markerHashCodeSound.SetCellValue("HASHCODE");
            Messages.AutoSizeColumn(lastColIndex - 1);

            ICell markerSoundEnd = headerRow.CreateCell(lastColIndex++);
            markerSoundEnd.CellStyle = grayBackground;
            markerSoundEnd.SetCellValue("MARKER_SOUND_END");

            ICell MarkerEndOfSheet = headerRow.CreateCell(lastColIndex++);
            MarkerEndOfSheet.CellStyle = grayBackground;
            MarkerEndOfSheet.SetCellValue("MARKER_END_OF_SHEET");

            ICell MarkerEnd = headerRow.CreateCell(lastColIndex++);
            MarkerEnd.CellStyle = grayBackground;
            MarkerEnd.SetCellValue("");

            //Messages.SetRowGroupCollapsed(0, true);
            for (int i = 0; i < 15; i++)
            {
                if (i != 4 && i != 14)
                {
                    Messages.AutoSizeColumn(i);
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
