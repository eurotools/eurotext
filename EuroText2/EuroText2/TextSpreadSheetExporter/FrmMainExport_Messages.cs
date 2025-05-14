using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmMain
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal void CreateMessagesSheet(BackgroundWorker bw, ISheet Messages, IWorkbook workbook, string[] outLevels, string[] textSections, bool WantsHashcodesNoSection)
        {
            //-------------------------------------------------------------------------------------------
            //  Fonts
            //-------------------------------------------------------------------------------------------
            IFont fontUnderline = workbook.CreateFont();
            fontUnderline.FontName = "Arial";
            fontUnderline.IsBold = true;
            fontUnderline.Underline = FontUnderlineType.Single;

            IFont fontBold = workbook.CreateFont();
            fontBold.FontName = "Arial";
            fontBold.IsBold = true;

            IFont fontStandard = workbook.CreateFont();
            fontStandard.FontName = "Arial";

            //-------------------------------------------------------------------------------------------
            //  Styles
            //-------------------------------------------------------------------------------------------
            HSSFPalette palette = ((HSSFWorkbook)workbook).GetCustomPalette();

            ICellStyle VerticalCenter = workbook.CreateCellStyle();
            VerticalCenter.VerticalAlignment = VerticalAlignment.Center;
            VerticalCenter.Alignment = HorizontalAlignment.Center;
            VerticalCenter.BorderLeft = BorderStyle.Thin;
            VerticalCenter.BorderTop = BorderStyle.Thin;
            VerticalCenter.BorderRight = BorderStyle.Thin;
            VerticalCenter.BorderBottom = BorderStyle.Thin;

            ICellStyle normalStyleLeft = workbook.CreateCellStyle();
            normalStyleLeft.Alignment = HorizontalAlignment.Left;
            normalStyleLeft.BorderLeft = BorderStyle.Thin;
            normalStyleLeft.BorderTop = BorderStyle.Thin;
            normalStyleLeft.BorderRight = BorderStyle.Thin;
            normalStyleLeft.BorderBottom = BorderStyle.Thin;

            ICellStyle normalStyle = workbook.CreateCellStyle();
            normalStyle.BorderLeft = BorderStyle.Thin;
            normalStyle.BorderTop = BorderStyle.Thin;
            normalStyle.BorderRight = BorderStyle.Thin;
            normalStyle.BorderBottom = BorderStyle.Thin;

            ICellStyle textLangsStyle = workbook.CreateCellStyle();
            textLangsStyle.VerticalAlignment = VerticalAlignment.Top;
            textLangsStyle.Alignment = HorizontalAlignment.Left;
            textLangsStyle.BorderLeft = BorderStyle.Thin;
            textLangsStyle.BorderTop = BorderStyle.Thin;
            textLangsStyle.BorderRight = BorderStyle.Thin;
            textLangsStyle.BorderBottom = BorderStyle.Thin;

            ICellStyle redBackgroundVerticalCenter = workbook.CreateCellStyle();
            redBackgroundVerticalCenter.FillForegroundColor = HSSFColor.Red.Index;
            redBackgroundVerticalCenter.FillPattern = FillPattern.SolidForeground;
            redBackgroundVerticalCenter.Rotation = 90;
            redBackgroundVerticalCenter.VerticalAlignment = VerticalAlignment.Center;
            redBackgroundVerticalCenter.Alignment = HorizontalAlignment.Center;
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
            pinkBackgroundVerticalCenter.SetFont(fontStandard);
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

            ICellStyle blueBackgroundBold = workbook.CreateCellStyle();
            palette.SetColorAtIndex(blueBackgroundColor, 204, 255, 255);
            blueBackgroundBold.FillForegroundColor = blueBackgroundColor;
            blueBackgroundBold.FillPattern = FillPattern.SolidForeground;
            blueBackgroundBold.SetFont(fontBold);
            blueBackgroundBold.BorderLeft = BorderStyle.Thin;
            blueBackgroundBold.BorderTop = BorderStyle.Thin;
            blueBackgroundBold.BorderRight = BorderStyle.Thin;
            blueBackgroundBold.BorderBottom = BorderStyle.Thin;

            ICellStyle blueBackground = workbook.CreateCellStyle();
            palette.SetColorAtIndex(blueBackgroundColor, 204, 255, 255);
            blueBackground.FillForegroundColor = blueBackgroundColor;
            blueBackground.FillPattern = FillPattern.SolidForeground;
            blueBackground.SetFont(fontStandard);
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
            ICellStyle greenBackgroundVerticalBold = workbook.CreateCellStyle();
            short greenBackgroundColor = 48;
            palette.SetColorAtIndex(greenBackgroundColor, 0, 255, 0);
            greenBackgroundVerticalBold.FillForegroundColor = greenBackgroundColor;
            greenBackgroundVerticalBold.FillPattern = FillPattern.SolidForeground;
            greenBackgroundVerticalBold.Rotation = 90;
            greenBackgroundVerticalBold.SetFont(fontBold);
            greenBackgroundVerticalBold.FillPattern = FillPattern.SolidForeground;
            greenBackgroundVerticalBold.BorderLeft = BorderStyle.Thin;
            greenBackgroundVerticalBold.BorderTop = BorderStyle.Thin;
            greenBackgroundVerticalBold.BorderRight = BorderStyle.Thin;
            greenBackgroundVerticalBold.BorderBottom = BorderStyle.Thin;

            ICellStyle orangeBackgroundVerticalBold = workbook.CreateCellStyle();
            short orangeBackgroundColor = 49;
            palette.SetColorAtIndex(orangeBackgroundColor, 255, 204, 0);
            orangeBackgroundVerticalBold.FillForegroundColor = orangeBackgroundColor;
            orangeBackgroundVerticalBold.FillPattern = FillPattern.SolidForeground;
            orangeBackgroundVerticalBold.Rotation = 90;
            orangeBackgroundVerticalBold.SetFont(fontBold);
            orangeBackgroundVerticalBold.BorderLeft = BorderStyle.Thin;
            orangeBackgroundVerticalBold.BorderTop = BorderStyle.Thin;
            orangeBackgroundVerticalBold.BorderRight = BorderStyle.Thin;
            orangeBackgroundVerticalBold.BorderBottom = BorderStyle.Thin;

            ICellStyle purpleBackgroundVerticalBold = workbook.CreateCellStyle();
            short purpleBackgroundColor = 50;
            palette.SetColorAtIndex(purpleBackgroundColor, 255, 0, 255);
            purpleBackgroundVerticalBold.FillForegroundColor = purpleBackgroundColor;
            purpleBackgroundVerticalBold.FillPattern = FillPattern.SolidForeground;
            purpleBackgroundVerticalBold.Rotation = 90;
            purpleBackgroundVerticalBold.SetFont(fontBold);
            purpleBackgroundVerticalBold.BorderLeft = BorderStyle.Thin;
            purpleBackgroundVerticalBold.BorderTop = BorderStyle.Thin;
            purpleBackgroundVerticalBold.BorderRight = BorderStyle.Thin;
            purpleBackgroundVerticalBold.BorderBottom = BorderStyle.Thin;

            ICellStyle darkBlueBackgroundVerticalBold = workbook.CreateCellStyle();
            short darkBlueBackgroundColor = 51;
            palette.SetColorAtIndex(darkBlueBackgroundColor, 0, 204, 255);
            darkBlueBackgroundVerticalBold.FillForegroundColor = darkBlueBackgroundColor;
            darkBlueBackgroundVerticalBold.FillPattern = FillPattern.SolidForeground;
            darkBlueBackgroundVerticalBold.Rotation = 90;
            darkBlueBackgroundVerticalBold.SetFont(fontBold);
            darkBlueBackgroundVerticalBold.BorderLeft = BorderStyle.Thin;
            darkBlueBackgroundVerticalBold.BorderTop = BorderStyle.Thin;
            darkBlueBackgroundVerticalBold.BorderRight = BorderStyle.Thin;
            darkBlueBackgroundVerticalBold.BorderBottom = BorderStyle.Thin;

            ICellStyle yellowBackgroundVerticalBold = workbook.CreateCellStyle();
            short yellowBackgroundColor = 52;
            palette.SetColorAtIndex(yellowBackgroundColor, 255, 255, 0);
            yellowBackgroundVerticalBold.FillForegroundColor = yellowBackgroundColor;
            yellowBackgroundVerticalBold.FillPattern = FillPattern.SolidForeground;
            yellowBackgroundVerticalBold.Rotation = 90;
            yellowBackgroundVerticalBold.SetFont(fontBold);
            yellowBackgroundVerticalBold.BorderLeft = BorderStyle.Thin;
            yellowBackgroundVerticalBold.BorderTop = BorderStyle.Thin;
            yellowBackgroundVerticalBold.BorderRight = BorderStyle.Thin;
            yellowBackgroundVerticalBold.BorderBottom = BorderStyle.Thin;

            ICellStyle greenBackground = workbook.CreateCellStyle();
            palette.SetColorAtIndex(greenBackgroundColor, 0, 255, 0);
            greenBackground.FillForegroundColor = greenBackgroundColor;
            greenBackground.FillPattern = FillPattern.SolidForeground;
            greenBackground.SetFont(fontStandard);
            greenBackground.FillPattern = FillPattern.SolidForeground;
            greenBackground.BorderLeft = BorderStyle.Thin;
            greenBackground.BorderTop = BorderStyle.Thin;
            greenBackground.BorderRight = BorderStyle.Thin;
            greenBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle orangeBackground = workbook.CreateCellStyle();
            palette.SetColorAtIndex(orangeBackgroundColor, 255, 204, 0);
            orangeBackground.FillForegroundColor = orangeBackgroundColor;
            orangeBackground.FillPattern = FillPattern.SolidForeground;
            orangeBackground.SetFont(fontStandard);
            orangeBackground.BorderLeft = BorderStyle.Thin;
            orangeBackground.BorderTop = BorderStyle.Thin;
            orangeBackground.BorderRight = BorderStyle.Thin;
            orangeBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle purpleBackground = workbook.CreateCellStyle();
            palette.SetColorAtIndex(purpleBackgroundColor, 255, 0, 255);
            purpleBackground.FillForegroundColor = purpleBackgroundColor;
            purpleBackground.FillPattern = FillPattern.SolidForeground;
            purpleBackground.SetFont(fontStandard);
            purpleBackground.BorderLeft = BorderStyle.Thin;
            purpleBackground.BorderTop = BorderStyle.Thin;
            purpleBackground.BorderRight = BorderStyle.Thin;
            purpleBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle darkBlueBackground = workbook.CreateCellStyle();
            palette.SetColorAtIndex(darkBlueBackgroundColor, 0, 204, 255);
            darkBlueBackground.FillForegroundColor = darkBlueBackgroundColor;
            darkBlueBackground.FillPattern = FillPattern.SolidForeground;
            darkBlueBackground.SetFont(fontStandard);
            darkBlueBackground.BorderLeft = BorderStyle.Thin;
            darkBlueBackground.BorderTop = BorderStyle.Thin;
            darkBlueBackground.BorderRight = BorderStyle.Thin;
            darkBlueBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle yellowBackground = workbook.CreateCellStyle();
            palette.SetColorAtIndex(yellowBackgroundColor, 255, 255, 0);
            yellowBackground.FillForegroundColor = yellowBackgroundColor;
            yellowBackground.FillPattern = FillPattern.SolidForeground;
            yellowBackground.SetFont(fontStandard);
            yellowBackground.BorderLeft = BorderStyle.Thin;
            yellowBackground.BorderTop = BorderStyle.Thin;
            yellowBackground.BorderRight = BorderStyle.Thin;
            yellowBackground.BorderBottom = BorderStyle.Thin;

            //-----------------------------------------------------------------------------------------

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
            orangeLightBackground.SetFont(fontStandard);
            orangeLightBackground.BorderLeft = BorderStyle.Thin;
            orangeLightBackground.BorderTop = BorderStyle.Thin;
            orangeLightBackground.BorderRight = BorderStyle.Thin;
            orangeLightBackground.BorderBottom = BorderStyle.Thin;

            //-----------------Game Data and Sound Information-----------------
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

            ICellStyle limeBackgroundUnderline = workbook.CreateCellStyle();
            short limeBackgroundColor = 55;
            palette.SetColorAtIndex(limeBackgroundColor, 204, 255, 204);
            limeBackgroundUnderline.FillForegroundColor = limeBackgroundColor;
            limeBackgroundUnderline.FillPattern = FillPattern.SolidForeground;
            limeBackgroundUnderline.VerticalAlignment = VerticalAlignment.Center;
            limeBackgroundUnderline.Alignment = HorizontalAlignment.Center;
            limeBackgroundUnderline.SetFont(fontUnderline);
            limeBackgroundUnderline.BorderLeft = BorderStyle.Thin;
            limeBackgroundUnderline.BorderTop = BorderStyle.Thin;
            limeBackgroundUnderline.BorderRight = BorderStyle.Thin;
            limeBackgroundUnderline.BorderBottom = BorderStyle.Thin;

            ICellStyle limeBackground = workbook.CreateCellStyle();
            palette.SetColorAtIndex(limeBackgroundColor, 204, 255, 204);
            limeBackground.FillForegroundColor = limeBackgroundColor;
            limeBackground.FillPattern = FillPattern.SolidForeground;
            limeBackground.Alignment = HorizontalAlignment.Center;
            limeBackground.SetFont(fontStandard);
            limeBackground.BorderLeft = BorderStyle.Thin;
            limeBackground.BorderTop = BorderStyle.Thin;
            limeBackground.BorderRight = BorderStyle.Thin;
            limeBackground.BorderBottom = BorderStyle.Thin;

            ICellStyle yellowTextGroup = workbook.CreateCellStyle();
            short yellowTextGroupColor = 56;
            palette.SetColorAtIndex(yellowTextGroupColor, 255, 255, 153);
            yellowTextGroup.FillForegroundColor = yellowTextGroupColor;
            yellowTextGroup.FillPattern = FillPattern.SolidForeground;
            yellowTextGroup.BorderLeft = BorderStyle.Thin;
            yellowTextGroup.BorderTop = BorderStyle.Thin;
            yellowTextGroup.BorderRight = BorderStyle.Thin;
            yellowTextGroup.BorderBottom = BorderStyle.Thin;

            ICellStyle lightPurpleCenter = workbook.CreateCellStyle();
            short lightPurpleColor = 57;
            palette.SetColorAtIndex(lightPurpleColor, 204, 153, 255);
            lightPurpleCenter.FillForegroundColor = lightPurpleColor;
            lightPurpleCenter.Alignment = HorizontalAlignment.Center;
            lightPurpleCenter.FillPattern = FillPattern.SolidForeground;
            lightPurpleCenter.SetFont(fontStandard);
            lightPurpleCenter.BorderLeft = BorderStyle.Thin;
            lightPurpleCenter.BorderTop = BorderStyle.Thin;
            lightPurpleCenter.BorderRight = BorderStyle.Thin;
            lightPurpleCenter.BorderBottom = BorderStyle.Thin;

            ICellStyle lightPurple = workbook.CreateCellStyle();
            palette.SetColorAtIndex(lightPurpleColor, 204, 153, 255);
            lightPurple.FillForegroundColor = lightPurpleColor;
            lightPurple.Alignment = HorizontalAlignment.Left;
            lightPurple.FillPattern = FillPattern.SolidForeground;
            lightPurple.SetFont(fontStandard);
            lightPurple.BorderLeft = BorderStyle.Thin;
            lightPurple.BorderTop = BorderStyle.Thin;
            lightPurple.BorderRight = BorderStyle.Thin;
            lightPurple.BorderBottom = BorderStyle.Thin;

            ICellStyle lightGreen = workbook.CreateCellStyle();
            short lightGreenColor = 58;
            palette.SetColorAtIndex(lightGreenColor, 153, 204, 0);
            lightGreen.FillForegroundColor = lightGreenColor;
            lightGreen.Alignment = HorizontalAlignment.Left;
            lightGreen.FillPattern = FillPattern.SolidForeground;
            lightGreen.SetFont(fontStandard);
            lightGreen.BorderLeft = BorderStyle.Thin;
            lightGreen.BorderTop = BorderStyle.Thin;
            lightGreen.BorderRight = BorderStyle.Thin;
            lightGreen.BorderBottom = BorderStyle.Thin;

            //-------------------------------------------------------------------------------------------
            //  Writing
            //-------------------------------------------------------------------------------------------
            //Header row
            int lastColIndex = 0;
            int rowIndex = 0;
            IRow headerRow = Messages.CreateRow(rowIndex);

            ICell sheetTypeCell = headerRow.CreateCell(lastColIndex++);
            sheetTypeCell.CellStyle = VerticalCenter;
            sheetTypeCell.SetCellValue("SHEET_TYPE_TEXT");

            ICell maxNumOfChannelsCell = headerRow.CreateCell(lastColIndex++);
            maxNumOfChannelsCell.CellStyle = redBackgroundVerticalCenter;
            maxNumOfChannelsCell.SetCellValue("Max Num Of Chars");

            ICell deadTextCell = headerRow.CreateCell(lastColIndex++);
            deadTextCell.CellStyle = redBackgroundVerticalCenter;
            deadTextCell.SetCellValue("Dead Text");

            ICell hashcodesCell = headerRow.CreateCell(lastColIndex++);
            hashcodesCell.CellStyle = pinkBackgroundVerticalCenterUnderline;
            hashcodesCell.SetCellValue("Hash Codes");

            ICell emptyCell = headerRow.CreateCell(lastColIndex++);
            emptyCell.CellStyle = grayBackground;

            ICell languagesCell = headerRow.CreateCell(lastColIndex++);
            languagesCell.CellStyle = blueBackgroundVerticalCenterUnderline;
            languagesCell.SetCellValue("Languages");

            for (int i = 0; i < GlobalVariables.CurrentProject.Languages.Count + 1; i++)
            {
                emptyCell = headerRow.CreateCell(lastColIndex++);
                if (i > GlobalVariables.CurrentProject.Languages.Count - 2)
                {
                    emptyCell.CellStyle = grayBackground;
                }
                else
                {
                    emptyCell.CellStyle = VerticalCenter;
                }
            }

            //Languages Array
            ICellStyle[] colorsLevelsVerticalBold = new ICellStyle[] { greenBackgroundVerticalBold, orangeBackgroundVerticalBold, purpleBackgroundVerticalBold, darkBlueBackgroundVerticalBold, yellowBackgroundVerticalBold };
            ICellStyle[] colorsLevels = new ICellStyle[] { greenBackground, orangeBackground, purpleBackground, darkBlueBackground, yellowBackground };

            //Print output levels
            PrintColorsSection(ref lastColIndex, outLevels, orangeLightBackgroundUnderline, colorsLevelsVerticalBold, headerRow, true);

            //Print GameData
            for (int i = 0; i < 4; i++)
            {
                ICell gameDataCell = headerRow.CreateCell(lastColIndex++);
                gameDataCell.CellStyle = grayUnderlineBackground;
                if (i == 1)
                {
                    gameDataCell.SetCellValue("Game Data");
                }
            }

            //Print Sound information
            ICell soundInfoCell = headerRow.CreateCell(lastColIndex++);
            soundInfoCell.CellStyle = limeBackgroundUnderline;
            soundInfoCell.SetCellValue("Sound Information");
            for (int i = 0; i < 4; i++)
            {
                ICell emptyCells = headerRow.CreateCell(lastColIndex++);
                if (i > 0)
                {
                    emptyCells.CellStyle = grayBackground;
                }
                else
                {
                    emptyCells.CellStyle = normalStyle;
                }
            }

            //Collapse row
            Messages.SetRowGroupCollapsed(0, true);

            //--------------------------------------------------[Row 2]-------------------------------------------
            //Reset var
            lastColIndex = 0;

            //Create new row
            rowIndex++;
            headerRow = Messages.CreateRow(rowIndex);

            //Start printing
            for (int i = 0; i < 5; i++)
            {
                ICell secondRowEmptyCell = headerRow.CreateCell(lastColIndex++);
                if (i == 4)
                {
                    secondRowEmptyCell.CellStyle = grayBackground;
                }
                else
                {
                    secondRowEmptyCell.CellStyle = normalStyle;
                }
            }

            //Print languages
            for (int i = 0; i < GlobalVariables.CurrentProject.Languages.Count; i++)
            {
                ICell langCell = headerRow.CreateCell(lastColIndex++);
                langCell.CellStyle = blueBackgroundBold;
                langCell.SetCellValue(GlobalVariables.CurrentProject.Languages[i]);
            }

            //Empty cells
            for (int i = 0; i < 2; i++)
            {
                ICell grayCell = headerRow.CreateCell(lastColIndex++);
                grayCell.CellStyle = grayBackground;
            }

            //Print text groups
            for (int i = 0; i < textSections.Length; i++)
            {
                //Create cell
                ICell levelCell = headerRow.CreateCell(lastColIndex++);
                levelCell.CellStyle = yellowTextGroup;
                levelCell.SetCellValue(textSections[i]);
                Messages.SetColumnWidth(lastColIndex - 1, 870);
            }

            for (int i = 0; i < 4; i++)
            {
                ICell emptyCells = headerRow.CreateCell(lastColIndex++);
                emptyCells.CellStyle = grayBackground;
            }

            //Print Sound information
            ICell waveNameCell = headerRow.CreateCell(lastColIndex++);
            waveNameCell.CellStyle = limeBackground;
            waveNameCell.SetCellValue("Wave Name");
            Messages.AutoSizeColumn(lastColIndex - 1);

            //PS2 name
            ICell ps2NameCell = headerRow.CreateCell(lastColIndex++);
            ps2NameCell.CellStyle = lightPurpleCenter;
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
            //Reset var
            lastColIndex = 0;

            //Create new row
            rowIndex++;
            headerRow = Messages.CreateRow(rowIndex);

            for (int i = 0; i < 4; i++, lastColIndex++)
            {
                ICell markerCells = headerRow.CreateCell(i);
                if (i < 3)
                {
                    markerCells.CellStyle = lightPurple;
                    if (i == 0)
                    {
                        markerCells.SetCellValue("MARKER_FORMAT_ROW");
                    }
                }
                else
                {
                    markerCells.CellStyle = pinkBackgroundVerticalCenter;
                    markerCells.SetCellValue("MARKER_HASHCODE");
                }
            }

            //Print language markers
            ICell languagesStartMarker = headerRow.CreateCell(lastColIndex++);
            languagesStartMarker.CellStyle = blueBackground;
            languagesStartMarker.SetCellValue("MARKER_LANGUAGE_START");

            for (int i = 0; i < GlobalVariables.CurrentProject.Languages.Count; i++)
            {
                ICell langCell = headerRow.CreateCell(lastColIndex++);
                langCell.CellStyle = blueBackground;
                string language = GlobalVariables.CurrentProject.Languages[i];
                if (language.Equals("Japan", StringComparison.OrdinalIgnoreCase))
                {
                    language = "JAPANESE";
                }
                string cellValue = "MARKER_" + language.ToUpper().Replace(" ", "_");
                langCell.SetCellValue(cellValue);
            }

            ICell languagesEndMarker = headerRow.CreateCell(lastColIndex++);
            languagesEndMarker.CellStyle = blueBackground;
            languagesEndMarker.SetCellValue("MARKER_LANGUAGE_END");
            Messages.SetColumnWidth(lastColIndex - 1, 6900);

            //Print levels
            ICell markerLevelStart = headerRow.CreateCell(lastColIndex++);
            markerLevelStart.CellStyle = grayBackground;
            markerLevelStart.SetCellValue("MARKER_LEVEL_START");
            Messages.SetColumnWidth(lastColIndex - 1, 2100);

            for (int i = 0; i < outLevels.Length; i++)
            {
                //Create cell
                ICell levelCell = headerRow.CreateCell(lastColIndex++);
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
            markerStringSound.CellStyle = limeBackground;
            markerStringSound.SetCellValue("STRING");

            ICell markerHashCodeSound = headerRow.CreateCell(lastColIndex++);
            markerHashCodeSound.CellStyle = limeBackground;
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

            //-------------------------------------------------------------------------------------------
            //  WRITE MESSAGES
            //-------------------------------------------------------------------------------------------
            int SpreadSheetColsCount = lastColIndex;

            //Reset var
            lastColIndex = 0;

            //Create new row
            rowIndex++;
            headerRow = Messages.CreateRow(rowIndex++);

            //Print groups
            PrintTextGroup(SpreadSheetColsCount, grayBackground, headerRow, "M_TEXT_ALL");

            //Get all messages
            ETXML_Reader textReader = new ETXML_Reader();
            string[] messagesToPrint = Directory.GetFiles(Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages"), "*.etf", SearchOption.TopDirectoryOnly);
            Array.Sort(messagesToPrint);

            //Filter
            Dictionary<string, List<EuroText_TextFile>> messagesCategorizes = new Dictionary<string, List<EuroText_TextFile>>();
            for (int i = 0; i < messagesToPrint.Length; i++)
            {
                EuroText_TextFile textObj = textReader.ReadTextFile(messagesToPrint[i]);
                textObj.HashCode = Path.GetFileNameWithoutExtension(messagesToPrint[i]);

                //Skip hashcodes with no section
                if (textObj.OutputSection.Length == 0 && !WantsHashcodesNoSection)
                {
                    continue;
                }

                //Exclude texts with flag unused
                if (CommonFunctions.GetFlag((uint)textObj.textFlags, (byte)(GlobalVariables.CurrentProject.UnusedTextBit - 1)))
                {
                    continue;
                }

                //We only want texts that has a group assigned
                if (!string.IsNullOrEmpty(textObj.Group))
                {
                    if (messagesCategorizes.ContainsKey(textObj.Group))
                    {
                        messagesCategorizes[textObj.Group].Add(textObj);
                    }
                    else
                    {
                        messagesCategorizes.Add(textObj.Group, new List<EuroText_TextFile>());
                        messagesCategorizes[textObj.Group].Add(textObj);
                    }
                }
            }

            //Start writtings
            foreach (KeyValuePair<string, List<EuroText_TextFile>> groupToPrint in messagesCategorizes)
            {
                if (bw.CancellationPending)
                {
                    break;
                }
                else
                {
                    headerRow = Messages.CreateRow(rowIndex++);
                    PrintTextGroup(SpreadSheetColsCount, grayBackground, headerRow, groupToPrint.Key);

                    for (int i = 0; i < groupToPrint.Value.Count; i++)
                    {
                        if (bw.CancellationPending)
                        {
                            break;
                        }
                        else
                        {
                            //Read text object
                            EuroText_TextFile textObj = groupToPrint.Value[i];

                            //Report progress
                            bw.ReportProgress((i * 100) / groupToPrint.Value.Count, string.Join(" ", "Text Group:", groupToPrint.Key, "Writting:", textObj.HashCode));

                            //Create a new row
                            headerRow = Messages.CreateRow(rowIndex++);

                            //Print basic config
                            for (int l = 0; l < 5; l++)
                            {
                                ICell infoCell = headerRow.CreateCell(lastColIndex++);
                                infoCell.CellStyle = normalStyle;
                                switch (l)
                                {
                                    case 1:
                                        if (textObj.MaxNumOfChars > 0)
                                        {
                                            infoCell.SetCellValue(textObj.MaxNumOfChars);
                                        }
                                        break;
                                    case 2:
                                        if (textObj.DeadText > 0)
                                        {
                                            infoCell.SetCellValue(textObj.DeadText);
                                        }
                                        break;
                                    case 3:
                                        infoCell.SetCellValue(textObj.HashCode);
                                        infoCell.CellStyle = normalStyleLeft;
                                        break;
                                    case 4:
                                        infoCell.CellStyle = grayBackground;
                                        break;
                                }
                            }

                            //Print languages
                            foreach (string languageToPrint in GlobalVariables.CurrentProject.Languages)
                            {
                                ICell langCell = headerRow.CreateCell(lastColIndex++);
                                langCell.CellStyle = textLangsStyle;
                                if (textObj.Messages.ContainsKey(languageToPrint))
                                {
                                    langCell.SetCellValue(textObj.Messages[languageToPrint]);
                                }
                                langCell.CellStyle.WrapText = true;
                            }

                            //Empty section
                            for (int l = 0; l < 2; l++)
                            {
                                ICell emtpyCell = headerRow.CreateCell(lastColIndex++);
                                emtpyCell.CellStyle = grayBackground;
                            }

                            //Print Section
                            PrintColorsSection(ref lastColIndex, outLevels, orangeLightBackground, colorsLevels, headerRow);

                            //Set bit to the output group
                            if (textObj.OutputSection.Length > 0)
                            {
                                for (int x = 0; x < textObj.OutputSection.Length; x++)
                                {
                                    int bitPosition = Array.IndexOf(textSections, textObj.OutputSection[x]);
                                    if (bitPosition >= 0)
                                    {
                                        int colIndex = 7 + GlobalVariables.CurrentProject.Languages.Count + bitPosition;
                                        ICell textSectionCell = headerRow.GetCell(colIndex);
                                        if (textSectionCell != null)
                                        {
                                            textSectionCell.SetCellValue(1);
                                        }
                                    }
                                }
                            }

                            //Print game data and sound information
                            for (int l = 0; l < 9; l++)
                            {
                                ICell emtpyCell = headerRow.CreateCell(lastColIndex++);
                                if (l == 4 || l == 5)
                                {
                                    emtpyCell.CellStyle = normalStyle;
                                }
                                else
                                {
                                    emtpyCell.CellStyle = grayBackground;
                                }
                            }

                            lastColIndex = 0;

                        }

                        Thread.Sleep(1);
                    }

                    headerRow = Messages.CreateRow(rowIndex++);
                    PrintTextGroup(SpreadSheetColsCount, grayBackground, headerRow, groupToPrint.Key);
                }
            }

            //End generic group
            headerRow = Messages.CreateRow(rowIndex++);
            PrintTextGroup(SpreadSheetColsCount, grayBackground, headerRow, "M_TEXT_ALL");

            //Last marker
            headerRow = Messages.CreateRow(rowIndex++);
            PrintTextGroup(SpreadSheetColsCount, lightGreen, headerRow, "MARKER_LAST_MESSAGE");

            //Autosize columns
            Messages.AutoSizeColumn(0);
            Messages.SetColumnWidth(1, 970);
            Messages.SetColumnWidth(2, 970);
            Messages.AutoSizeColumn(3);
            Messages.SetColumnWidth(4, 570);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void PrintTextGroup(int lastColIndex, ICellStyle grayBackground, IRow headerRow, string groupName)
        {
            for (int i = 0; i < lastColIndex; i++)
            {
                ICell textAllGroup = headerRow.CreateCell(i);
                textAllGroup.CellStyle = grayBackground;
                if (i == 0)
                {
                    textAllGroup.SetCellValue(groupName);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void PrintColorsSection(ref int lastColIndex, string[] outLevels, ICellStyle firstColor, ICellStyle[] colorsLevels, IRow headerRow, bool printText = false)
        {
            int k = 0;
            for (int i = 0; i < outLevels.Length; i++)
            {
                //Ensure index not out of bounds
                if (k >= colorsLevels.Length)
                {
                    k = 0;
                }

                //Set color
                ICell levelCell = headerRow.CreateCell(lastColIndex++);
                if (i == 0)
                {
                    levelCell.CellStyle = firstColor;
                }
                else
                {
                    levelCell.CellStyle = colorsLevels[k];
                }

                //Set text
                if (printText)
                {
                    levelCell.SetCellValue(outLevels[i]);
                }
                k++;
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
