using System;
using System.Linq;
using ClosedXML.Excel;
using System.Windows.Forms;
using ERespondent.Entity;

namespace ERespondent.Excel
{
    class ExcelExport
    {
        private static XLWorkbook workBook;
        private static IXLWorksheet _workSheet;
        public ExcelExport()
        {
        }

        #region Раздел 1

        /// <summary>
        /// Метод, создающий таблицу для первого раздела
        /// </summary>
        public static void InitSection1(DataGridView grid1, DataGridView grid2, DataGridView grid3)
        {
            //     var workBook = new XLWorkbook();
            workBook = new XLWorkbook();
            _workSheet = workBook.Worksheets.Add("Раздел 1");

            #region Шапка таблицы
            _workSheet.Cell("B2").Value = "РАЗДЕЛ1";
            _workSheet.Cell("B3").Value = "ВЫПОЛНЕНИЕ МЕРОПРИЯТИЙ ПО ЭКОНОМИИ ТОПЛИВНО-ЭНЕРГЕТИЧЕСКИХ РЕСУРСОВ (ТЭР)";
            _workSheet.Cell("B4").Value = "Код  основных направлений энергосбережения";
            _workSheet.Cell("C3").Value = "";
            _workSheet.Cell("C4").Value = "Номер мероприятия в плане";
            _workSheet.Cell("D4").Value = "Наименование мероприятия";
            _workSheet.Cell("E4").Value = "Дата внедрения";
            // workSheet.Cell("E4").Value = new DateTime(1919, 1, 21);                      
            _workSheet.Cell("F4").Value = "Объем внедрения";
            _workSheet.Cell("H4").Value = "Экономия ТЭР, т усл. топл.";
            _workSheet.Cell("I4").Value = "Затраты на внедрение мероприятия  и источники финансирования, млн.руб.";
            _workSheet.Cell("J5").Value = "из них за счет средств";
            _workSheet.Cell("I5").Value = "Всего";
            _workSheet.Cell("F6").Value = "единица измерения";
            _workSheet.Cell("G6").Value = "количество";
            _workSheet.Cell("J6").Value = "республиканского бюджета на финансирование программ энергосбережения";
            _workSheet.Cell("K6").Value = "инвестиционных фондов";
            _workSheet.Cell("L6").Value = "республиканского бюджета";
            _workSheet.Cell("M6").Value = "местного бюджета";
            _workSheet.Cell("N6").Value = "организации";
            _workSheet.Cell("O6").Value = "кредита";
            _workSheet.Cell("P6").Value = "других источников";

            _workSheet.Cell("B7").Value = "А";
            _workSheet.Cell("C7").Value = "Б";
            _workSheet.Cell("D7").Value = "В";
            _workSheet.Cell("E7").Value = "Г";
            _workSheet.Cell("F7").Value = "Д";
            _workSheet.Cell("G7").Value = "1";
            _workSheet.Cell("H7").Value = "2";
            _workSheet.Cell("I7").Value = "3";
            _workSheet.Cell("J7").Value = "4";
            _workSheet.Cell("K7").Value = "5";
            _workSheet.Cell("L7").Value = "6";
            _workSheet.Cell("M7").Value = "7";
            _workSheet.Cell("N7").Value = "8";
            _workSheet.Cell("O7").Value = "9";
            _workSheet.Cell("P7").Value = "10";
            _workSheet.Range("B7:P7").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

            // worksheet
            var rngTable = _workSheet.Range("B2:P7");
            rngTable.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            rngTable.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rngTable.Style.Alignment.WrapText = true;
            rngTable.Style.Font.FontSize = 9;
            rngTable.Style.Font.FontName = "Times New Roman";
            #endregion

            #region Строка заголовок: РАЗДЕЛ 1
            var rngR1 = rngTable.Range("A1:O6");
            rngR1.Style.Font.Bold = true;
            rngR1.Style.Fill.BackgroundColor = XLColor.LightGray;
            rngR1.Style.Border.BottomBorder = XLBorderStyleValues.None;
            rngR1.Cell(1, 1).Style.Font.Bold = true;
            rngR1.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.White;
            rngR1.Row(1).Merge(); //rngTable.Range("A1:E1").Merge()
            ///
            ///Добавить внешнюю границу
            ///
            rngR1.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            #endregion

            #region Строка заголовок 2
            var rngR2 = rngTable.Range("A2:O2");
            rngR2.Style.Font.Bold = true;
            rngR2.Style.Fill.BackgroundColor = XLColor.LightGray;
            rngR2.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            rngR2.Cell(1, 1).Style.Font.Bold = true;
            rngR2.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.White;
            rngR2.Row(1).Merge(); //rngTable.Range("A1:E1").Merge()            
            #endregion

            #region Объединение ячеек
            var colA = rngTable.Range("A3:A5");
            colA.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colA.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            _workSheet.Row(6).Height = 110;
            colA.Column(1).Merge();

            var colB = rngTable.Range("B3:B5");
            colB.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colB.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colB.Column(1).Merge();

            var colC = rngTable.Range("C3:C5");
            colC.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colC.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colC.Column(1).Merge();

            var colD = rngTable.Range("D3:D5");
            colD.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colD.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colD.Column(1).Merge();

            var colE = rngTable.Range("E3:F3");
            colE.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colE.Style.Border.BottomBorder = XLBorderStyleValues.None;
            rngTable.Range("E3:F3").Merge();
            rngTable.Range("E4:F4").Merge();
            rngTable.Cells("E4:F4").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            rngTable.Cell("F4").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            rngTable.Cells("E5:F5").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            rngTable.Cells("E5:F5").Style.Border.BottomBorder = XLBorderStyleValues.Thin;

            var colG = rngTable.Range("G3:G5");
            colG.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colG.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colG.Column(1).Merge();

            var colH = rngTable.Range("H3:O3");
            colH.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colH.Row(1).Merge();
            rngTable.Range("H4:H5").Merge();
            rngTable.Cells("H4:H5").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            rngTable.Cells("H5").Style.Border.BottomBorder = XLBorderStyleValues.Thin;

            var colI = rngTable.Range("I4:O4");
            colI.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colI.Row(1).Merge();

            rngTable.Cells("I5:N5").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            rngTable.Cells("I5:O5").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            #endregion

            //workSheet.Columns(2, 6).AdjustToContents();
            //int rCount = rngTable.RowCount();           
            //rngTable.Row(rCount).InsertRowsAbove(5);

            FillBookSection1(_workSheet, grid1, grid2, grid3);

            //workBook1.Close();
            //app.Quit();
        }

        /// <summary>
        /// Метод задающий стили и количество строк в таблица по каждому подразделу
        /// </summary>
        /// <param name="workSheet"></param>
        /// <param name="grid1"></param>
        /// <param name="grid2"></param>
        /// <param name="grid3"></param>
        public static void FillBookSection1(IXLWorksheet workSheet, DataGridView grid1, DataGridView grid2, DataGridView grid3)
        {
            int rCount = grid1.RowCount + 1 + grid2.RowCount + 1 + grid3.RowCount + 1;
            var sheetSection1 = workSheet.Range("B8:P" + (rCount + 8));

            sheetSection1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            sheetSection1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            sheetSection1.Style.Alignment.WrapText = true;
            sheetSection1.Style.Font.FontSize = 9;
            sheetSection1.Style.Font.FontName = "Times New Roman";
            sheetSection1.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

            #region Таблица 1
            workSheet.Cells("B8").Value = "1. По плану мероприятий отчетного года";
            var tempRow1 = sheetSection1.Range("A1:O1");
            tempRow1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRow1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            tempRow1.Style.Fill.BackgroundColor = XLColor.LightGray;
            tempRow1.Row(1).Merge();
            int indexRow = 9;
            FillValueSection1(workSheet, grid1, indexRow);
            #endregion

            #region Таблица 2
            indexRow = indexRow + grid1.RowCount;
            workSheet.Cells("B" + (indexRow).ToString()).Value = "2. Дополнительные мероприятия";
            var tempRow2 = sheetSection1.Range("A" + (grid1.RowCount + 2).ToString() + ":" + "O" + (grid1.RowCount + 2).ToString());
            tempRow2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRow2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            tempRow2.Style.Fill.BackgroundColor = XLColor.LightGray;
            tempRow2.Row(1).Merge();

            FillValueSection1(workSheet, grid2, ++indexRow);
            #endregion

            #region Таблица 3
            indexRow = indexRow + grid2.RowCount;
            workSheet.Cells("B" + (indexRow).ToString()).Value = "3. По мероприятиям предшествующего года внедрения";
            var tempRow3 = sheetSection1.Range("A" + (grid1.RowCount + grid2.RowCount + 3).ToString() + ":" + "O" + (grid1.RowCount + grid2.RowCount + 3).ToString());
            tempRow3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRow3.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            tempRow3.Style.Fill.BackgroundColor = XLColor.LightGray;
            tempRow3.Row(1).Merge();

            FillValueSection1(workSheet, grid3, ++indexRow);
            #endregion

        }

        /// <summary>
        /// Метод для заполнениея первого раздела в Excel
        /// </summary>
        /// <param name="workSheet"></param>
        /// <param name="grid"></param>
        /// <param name="indexRow"></param>
        private static void FillValueSection1(IXLWorksheet workSheet, DataGridView grid, int indexRow)
        {
            var db = new E_RespondentDataContext();
            for (int i = 0; i < grid.RowCount; i++)
            {
                int j = 0;
                for (char c = 'B'; c < 'Q'; c++)
                {
                    if (grid[j, i].Value != null)
                    {

                        if (grid[j, i].EditType.ToString().Equals("System.Windows.Forms.DataGridViewComboBoxEditingControl"))
                        {
                            var value = from cStt in db.DestinationSave
                                        where cStt.CodeRecord == Convert.ToInt32(grid[j, i].Value)
                                        select cStt;
                            foreach (var k in value)
                            {
                                workSheet.Cells(c.ToString() + (i + indexRow).ToString()).Value = k.DestinationsSave;
                                workSheet.Column(4).Width = 40;
                            }
                        }
                        else
                        {
                            workSheet.Cells(c.ToString() + (i + indexRow).ToString()).Value = grid[j, i].Value;
                            workSheet.Column(4).Width = 40;
                        }
                    }
                    j++;
                }

            }
        }

        #endregion

        #region Раздел 2

        /// <summary>
        /// Метод, создающий таблицу для второго раздела
        /// </summary>
        public static void InitSection2(DataGridView grid1, DataGridView grid2, DataGridView grid3)
        {
            _workSheet = workBook.Worksheets.Add("Раздел 2");
            #region Шапка с заголовками
            _workSheet.Cell("B2").Value = "РАЗДЕЛ1";
            _workSheet.Cell("B3").Value = "ВЫПОЛНЕНИЕ МЕРОПРИЯТИЙ ПО УВЕЛИЧЕНИЮ ИСПОЛЬЗОВАНИЯ МЕСТНЫХ ВИДОВ ТОПЛИВА, ОТХОДОВ ПРОИЗВОДСТВА И ДРУГИХ ВТОРИЧНЫХ И ВОЗОБНОВЛЯЕМЫХ ЭНЕРГОРЕСУРСОВ (МВТ)";
            _workSheet.Cell("B4").Value = "Код  основных направлений энергосбережения";
            _workSheet.Cell("C3").Value = "";
            _workSheet.Cell("C4").Value = "Номер мероприятия в плане";
            _workSheet.Cell("D4").Value = "Наименование мероприятия";
            _workSheet.Cell("E4").Value = "Дата внедрения";
            // workSheet.Cell("E4").Value = new DateTime(1919, 1, 21);                      
            _workSheet.Cell("F4").Value = "Код топлива или энергии";
            _workSheet.Cell("F6").Value = "до внедрения мероприятия";//
            _workSheet.Cell("G6").Value = "после внедрения мероприятия";//

            _workSheet.Cell("H4").Value = "Объем внедрения";
            _workSheet.Cell("H6").Value = "единица измерения";
            _workSheet.Cell("I6").Value = "количество";
            _workSheet.Cell("J4").Value = "Увеличение использования МВТ, т усл. топл.";
            _workSheet.Cell("K4").Value = "Затраты на внедрение мероприятия и источники финансирования, млн. руб.";
            _workSheet.Cell("K5").Value = "всего";
            _workSheet.Cell("L5").Value = "из них за счет средств";
            _workSheet.Cell("L6").Value = "республиканского бюджета на финансирование программ энергосбережения";
            _workSheet.Cell("M6").Value = "инвестиционных фондов";
            _workSheet.Cell("N6").Value = "респуюликанского бюджета";
            _workSheet.Cell("O6").Value = "местного бюджета";
            _workSheet.Cell("P6").Value = "организации";
            _workSheet.Cell("Q6").Value = "кредита";
            _workSheet.Cell("R6").Value = "других источников";

            _workSheet.Cell("B7").Value = "А";
            _workSheet.Cell("C7").Value = "Б";
            _workSheet.Cell("D7").Value = "В";
            _workSheet.Cell("E7").Value = "Г";
            _workSheet.Cell("F7").Value = "Д";
            _workSheet.Cell("G7").Value = "Е";
            _workSheet.Cell("H7").Value = "Ж";
            _workSheet.Cell("I7").Value = "1";
            _workSheet.Cell("J7").Value = "2";
            _workSheet.Cell("K7").Value = "3";
            _workSheet.Cell("L7").Value = "4";
            _workSheet.Cell("M7").Value = "5";
            _workSheet.Cell("N7").Value = "6";
            _workSheet.Cell("O7").Value = "7";
            _workSheet.Cell("P7").Value = "8";
            _workSheet.Cell("Q7").Value = "9";
            _workSheet.Cell("R7").Value = "10";
            _workSheet.Range("B7:R7").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

            // worksheet
            var rngTable = _workSheet.Range("B2:R7");
            rngTable.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            rngTable.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rngTable.Style.Alignment.WrapText = true;
            rngTable.Style.Font.FontSize = 9;
            rngTable.Style.Font.FontName = "Times New Roman";
            #endregion

            #region Строка заголовок: РАЗДЕЛ 1
            var rngR1 = rngTable.Range("A1:Q6");
            rngR1.Style.Font.Bold = true;
            rngR1.Style.Fill.BackgroundColor = XLColor.LightGray;
            rngR1.Style.Border.BottomBorder = XLBorderStyleValues.None;
            rngR1.Cell(1, 1).Style.Font.Bold = true;
            rngR1.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.White;
            rngR1.Row(1).Merge(); //rngTable.Range("A1:E1").Merge()
            ///
            ///Добавить внешнюю границу
            ///
            rngR1.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            #endregion

            #region Строка заголовок 2
            var rngR2 = rngTable.Range("A2:Q2");
            rngR2.Style.Font.Bold = true;
            rngR2.Style.Fill.BackgroundColor = XLColor.LightGray;
            rngR2.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            rngR2.Cell(1, 1).Style.Font.Bold = true;
            rngR2.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.White;
            rngR2.Row(1).Merge(); //rngTable.Range("A1:E1").Merge()   
            _workSheet.Row(3).Height = 30;
            _workSheet.Row(4).Height = 25;
            #endregion

            #region Объединение ячеек шапки таблицы

            var colA = rngTable.Range("A3:A5");
            colA.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colA.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            // workSheet.Row(6).Height = 110;
            colA.Column(1).Merge();

            var colB = rngTable.Range("B3:B5");
            colB.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colB.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colB.Column(1).Merge();

            var colC = rngTable.Range("C3:C5");
            colC.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colC.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colC.Column(1).Merge();

            var colD = rngTable.Range("D3:D5");
            colD.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colD.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colD.Column(1).Merge();

            rngTable.Range("E3:F3").Merge();
            rngTable.Range("E4:F4").Merge();

            rngTable.Cells("E4:F4").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            rngTable.Cell("F3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            rngTable.Cell("F4").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            rngTable.Range("G3:H3").Merge();
            rngTable.Cells("G4:H4").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            rngTable.Cells("H3:H4").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            rngTable.Cells("E5:H5").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            var colI = rngTable.Range("I3:I5");
            colI.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colI.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colI.Column(1).Merge();

            rngTable.Range("J3:Q3").Merge();
            rngTable.Cells("J3:Q3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;

            rngTable.Range("K4:Q4").Merge();
            rngTable.Cells("K4:Q4").Style.Border.BottomBorder = XLBorderStyleValues.Thin;

            var colJ = rngTable.Range("J4:J5");
            colJ.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colJ.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colJ.Column(1).Merge();

            rngTable.Cells("K5:Q5").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            #endregion

            FillBookSection2(_workSheet, grid1, grid2, grid3);
        }

        /// <summary>
        /// Метод задающий стили и количество строк в таблица по каждому подразделу
        /// </summary>
        /// <param name="workSheet">Excel worksheet</param>
        /// <param name="grid1">Таблица 1 из раздела 2</param>
        /// <param name="grid2">Таблица 2 из раздела 2</param>
        /// <param name="grid3">Таблица 3 из раздела 2</param>
        public static void FillBookSection2(IXLWorksheet workSheet, DataGridView grid1, DataGridView grid2, DataGridView grid3)
        {
            int rCount = grid1.RowCount + 1 + grid2.RowCount + 1 + grid3.RowCount + 1;
            var sheetSection1 = workSheet.Range("B8:R" + (rCount + 8));

            sheetSection1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            sheetSection1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            sheetSection1.Style.Alignment.WrapText = true;
            sheetSection1.Style.Font.FontSize = 9;
            sheetSection1.Style.Font.FontName = "Times New Roman";
            sheetSection1.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

            #region Таблица 1
            workSheet.Cells("B8").Value = "1. По плану мероприятий отчетного года";
            var tempRow1 = sheetSection1.Range("A1:Q1");
            tempRow1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRow1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            tempRow1.Style.Fill.BackgroundColor = XLColor.LightGray;
            tempRow1.Row(1).Merge();
            int indexRow = 9;
            FillValueSection2(workSheet, grid1, indexRow);
            #endregion

            #region Таблица 2
            indexRow = indexRow + grid1.RowCount;
            workSheet.Cells("B" + (indexRow).ToString()).Value = "2. Дополнительные мероприятия";
            var tempRow2 = sheetSection1.Range("A" + (grid1.RowCount + 2).ToString() + ":" + "Q" + (grid1.RowCount + 2).ToString());
            tempRow2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRow2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            tempRow2.Style.Fill.BackgroundColor = XLColor.LightGray;
            tempRow2.Row(1).Merge();

            FillValueSection2(workSheet, grid2, ++indexRow);
            #endregion

            #region Таблица 3
            indexRow = indexRow + grid2.RowCount;
            workSheet.Cells("B" + (indexRow).ToString()).Value = "3. По мероприятиям предшествующего года внедрения";
            var tempRow3 = sheetSection1.Range("A" + (grid1.RowCount + grid2.RowCount + 3).ToString() + ":" + "Q" + (grid1.RowCount + grid2.RowCount + 3).ToString());
            tempRow3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            tempRow3.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            tempRow3.Style.Fill.BackgroundColor = XLColor.LightGray;
            tempRow3.Row(1).Merge();

            FillValueSection2(workSheet, grid3, ++indexRow);
            #endregion

        }

        /// <summary>
        /// Метод для заполнениея второго раздела в Excel
        /// </summary>
        /// <param name="workSheet"></param>
        /// <param name="grid"></param>
        /// <param name="indexRow"></param>
        /// <param name="S"></param>
        private static void FillValueSection2(IXLWorksheet workSheet, DataGridView grid, int indexRow)
        {
            var db = new E_RespondentDataContext();
            for (int i = 0; i < grid.RowCount; i++)
            {
                int j = 0;
                for (char c = 'B'; c < 'S'; c++)
                {
                    if (grid[j, i].Value != null)
                    {

                        if (grid[j, i].EditType.ToString().Equals("System.Windows.Forms.DataGridViewComboBoxEditingControl"))
                        {
                            var value = from cStt in db.DestinationSave
                                        where cStt.CodeRecord == Convert.ToInt32(grid[j, i].Value)
                                        select cStt;
                            foreach (var k in value)
                            {
                                workSheet.Cells(c.ToString() + (i + indexRow).ToString()).Value = k.DestinationsSave;
                                workSheet.Column(4).Width = 40;
                            }
                        }
                        else
                        {
                            workSheet.Cells(c.ToString() + (i + indexRow).ToString()).Value = grid[j, i].Value;
                            workSheet.Column(4).Width = 40;
                        }
                    }
                    j++;
                }

            }
        }

        #endregion

        #region Раздел 3
        public static void InitSection3(DataGridView grid1, DataGridView grid2, DataGridView grid3)
        {
            _workSheet = workBook.Worksheets.Add("Раздел 3");

            #region Таблица: Выполнение программы (плана мероприятий) по энергосбережению
            #region Шапка
            _workSheet.Cell("B2").Value = "Выполнение программы (плана мероприятий) по энергосбережению";
            _workSheet.Cell("B3").Value = "Наименование показателя";
            _workSheet.Cell("C3").Value = "Код строки";
            _workSheet.Cell("D3").Value = "Единица измерения";
            _workSheet.Cell("E3").Value = "По плану";
            _workSheet.Cell("F3").Value = "Фактически";
            _workSheet.Cell("G3").Value = "Процент выполнения";
            _workSheet.Cell("B4").Value = "А";
            _workSheet.Cell("C4").Value = "Б";
            _workSheet.Cell("D4").Value = "В";
            _workSheet.Cell("E4").Value = "1";
            _workSheet.Cell("F4").Value = "2";
            _workSheet.Cell("G4").Value = "3";
            _workSheet.Cell("B5").Value = "Количество мероприятий";
            _workSheet.Cell("B6").Value = "Экономия ТЭР";
            _workSheet.Cell("B7").Value = "Увеличение использования МВТ";
            _workSheet.Cell("B8").Value = "Затраты на внедрение мероприятий";
            _workSheet.Cell("C5").Value = "1";
            _workSheet.Cell("C6").Value = "2";
            _workSheet.Cell("C7").Value = "3";
            _workSheet.Cell("C8").Value = "4";
            _workSheet.Cell("D5").Value = "ед.";
            _workSheet.Cell("D6").Value = "т. усл. топл.";
            _workSheet.Cell("D7").Value = "т. усл. топл.";
            _workSheet.Cell("D8").Value = "млн. руб.";
            #endregion

            #region Объединение и стили ячеек
            // worksheet - выделяем диапазон ячеек и работаем с ними как таблицой которая начинается с ячейки А1
            var rngTable = _workSheet.Range("B2:G8");
            rngTable.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            rngTable.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rngTable.Style.Alignment.WrapText = true;
            rngTable.Style.Font.FontSize = 10;
            rngTable.Style.Font.FontName = "Times New Roman";
            
            #region Строка заголовок: таблица 1
            var rngR1 = rngTable.Range("A1:F3");
            rngR1.Style.Font.Bold = true;
            rngR1.Style.Fill.BackgroundColor = XLColor.LightGray;
            rngR1.Style.Border.BottomBorder = XLBorderStyleValues.None;
            rngR1.Cell(1, 1).Style.Font.Bold = true;
            rngR1.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.White;
            rngR1.Row(1).Merge(); //rngTable.Range("A1:E1").Merge()
            ///
            ///Добавить внешнюю границу
            ///
            rngR1.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            #endregion

            rngTable.Cells("A2:F7").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            _workSheet.Columns("B").Width = 35;
            _workSheet.Columns("C:D").Width = 20;
            _workSheet.Columns("E:G").Width = 13;
            #endregion
            #endregion

            #region Таблица: Причины невыполнения мероприятий программы (плана мероприятий) по энергосбережению
            #region Шапка
            _workSheet.Cell("B11").Value = "Причины невыполнения мероприятий программы (плана мероприятий) по энергосбережению";
            _workSheet.Cell("B12").Value = "Номер пункта в программе (плане мероприятий)";
            _workSheet.Cell("B13").Value = "А";
            _workSheet.Cell("C12").Value = "Наименование мероприятия";
            _workSheet.Cell("C13").Value = "Б";
            _workSheet.Cell("D12").Value = "Причины невыполнения мероприятия, принимаемые меры по устранению отставания от плановых показателей";
            _workSheet.Cell("D13").Value = "В";
            #endregion

            #region Объединение и стили ячеек
            // worksheet - выделяем диапазон ячеек и работаем с ними как таблицой которая начинается с ячейки А1
            var rngTable2 = _workSheet.Range("B11:D13");
            rngTable2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            rngTable2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rngTable2.Style.Alignment.WrapText = true;
            rngTable2.Style.Font.FontSize = 10;
            rngTable2.Style.Font.FontName = "Times New Roman";
            #region Строка заголовок: таблица 1
            var rngR2 = rngTable2.Range("A1:C3");
            rngR2.Style.Font.Bold = true;
            rngR2.Style.Fill.BackgroundColor = XLColor.LightGray;
            rngR2.Style.Border.BottomBorder = XLBorderStyleValues.None;
            rngR2.Cell(1, 1).Style.Font.Bold = true;
            rngR2.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.White;
            rngR2.Row(1).Merge(); //rngTable.Range("A1:E1").Merge()
            ///
            ///Добавить внешнюю границу
            ///
            rngR2.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            #endregion

            rngTable2.Cells("A1:C3").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

            #endregion
            #endregion

            #region Таблица: Причины невыполнения мероприятий программы (плана мероприятий) по энергосбережению
            #region Шапка
            _workSheet.Cell("I2").Value = "Выполнение установленного годового задания по экономии ТЭР";
            _workSheet.Cell("I3").Value = "Код строки";
            _workSheet.Cell("I5").Value = "А";
            _workSheet.Cell("J3").Value = "Экономия ТЭР, т. усл. топл.";
            _workSheet.Cell("J4").Value = "годовое задание";
            _workSheet.Cell("J5").Value = "1";
            _workSheet.Cell("K4").Value = "фактически";
            _workSheet.Cell("K5").Value = "2";
            _workSheet.Cell("I6").Value = "5";
            #endregion

            #region Объединение и стили ячеек
            // worksheet - выделяем диапазон ячеек и работаем с ними как таблицой которая начинается с ячейки А1
            var rngTable3 = _workSheet.Range("I2:K6");
            rngTable3.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            rngTable3.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            rngTable3.Style.Alignment.WrapText = true;
            rngTable3.Style.Font.FontSize = 10;
            rngTable3.Style.Font.FontName = "Times New Roman";

            #region Строка заголовок: таблица 1
            var rngR3 = rngTable3.Range("A1:C4");
            rngR3.Style.Font.Bold = true;
            rngR3.Style.Fill.BackgroundColor = XLColor.LightGray;
            rngR3.Style.Border.BottomBorder = XLBorderStyleValues.None;
            rngR3.Cell(1, 1).Style.Font.Bold = true;
            rngR3.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.White;
            rngR3.Row(1).Merge(); //rngTable.Range("A1:E1").Merge()
            ///
            ///Добавить внешнюю границу
            ///
            rngR3.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            #endregion

            var colTemp = rngTable3.Range("A2:A3");
            colTemp.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            colTemp.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            colTemp.Column(1).Merge();
            rngTable3.Range("B2:C3").Merge();
            
            rngTable3.Cells("A1:C5").Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            _workSheet.Columns("I:K").Width = 20;
            
            #endregion
            #endregion

            SaveBook(workBook);
        }

        public 

        #endregion

        /// <summary>
        /// Сохранение книги Excel в формате 2007 и 2003
        /// </summary>
        /// <param name="workBook"></param>
        private static void SaveBook(XLWorkbook workBook)
        {
            workBook.SaveAs("BasicTable.xlsx");
            var app = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                //Если используется английская версия Excel, а региональные стандарты настроены на использование языка 
                //отличного от английского
                System.Globalization.CultureInfo oldCi = System.Threading.Thread.CurrentThread.CurrentCulture;
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                var workBook1 = app.Workbooks.Open(Application.StartupPath + @"\BasicTable.xlsx");
                workBook1.SaveAs(Filename: Application.StartupPath + @"\Office2003File.xls", FileFormat: Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8);
                app.Visible = true;

                //возвращаем начальные региональные параметры
                System.Threading.Thread.CurrentThread.CurrentCulture = oldCi;
            }
            catch (Exception ex)
            {
                app.Quit();
                MessageBox.Show(ex.StackTrace, @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
