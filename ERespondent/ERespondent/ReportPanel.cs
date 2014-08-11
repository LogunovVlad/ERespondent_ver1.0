using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using ERespondent.CheckData;
using ERespondent.UtilityFunction;
using ERespondent.Entity;
using ERespondent.Excel;

namespace ERespondent
{
    public partial class ReportPanel : Form
    {
        private E_RespondentDataContext _db;
        private string _year;
        private string _kodOkpo; 

        public ReportPanel(string year, string kodOkpo)
        {
            InitializeComponent();
            _year = year;
            _kodOkpo = kodOkpo;
        }        

        private void MainFormLoad(object sender, EventArgs e)
        {
            ScreenResolution();
            try
            {
                //заполянем комбобоксы для раздела 1 
                FillComboBoxLinq(Section1_dataGrid1ColumnV, "DestinationSave");
                FillComboBoxLinq(Section1_dataGrid2ColumnV, "DestinationSave");
                FillComboBoxLinq(Section1_dataGrid3ColumnV, "DestinationSave");
                //заполянем комбобоксы для раздела 2
                FillComboBoxLinq(Section2_dataGrid1ColumnV, "DestinationSave");
                FillComboBoxLinq(Section2_dataGrid2ColumnV, "DestinationSave");
                FillComboBoxLinq(Section2_dataGrid3ColumnV, "DestinationSave");
                FillComboBoxLinq(Section2_dataGrid1ColumnD, "TypeFuelEnergy");
                FillComboBoxLinq(Section2_dataGrid1ColumnE, "TypeFuelEnergy");
                FillComboBoxLinq(Section2_dataGrid2ColumnD, "TypeFuelEnergy");
                FillComboBoxLinq(Section2_dataGrid2ColumnE, "TypeFuelEnergy");
                FillComboBoxLinq(Section2_dataGrid3ColumnD, "TypeFuelEnergy");
                FillComboBoxLinq(Section2_dataGrid3ColumnE, "TypeFuelEnergy");

                FillSection3Table1();
                statusStrip1.Items[0].Text = @"Соединение установлено!";
            }
            catch (SqlException)
            {
                MessageBox.Show(@"Ошибка сервера!");
                statusStrip1.Items[0].Text = @"Отсутствует подключение к базе данных!";
            }

            /* Для изменения размеров столбцов для первого раздела */
            Section1_dataGridViewHeader1_1.ColumnWidthChanged += dataGridView1_ColumnWidthChanged;

            //для второго раздела
            Section2_dataGridViewHeader2_1.ColumnWidthChanged += dataGridViewSection2_ColumnWidthChanged;

            /*  Section2_dataGridViewHeader2_2.ColumnWidthChanged += dataGridViewSection2_ColumnWidthChanged;
              Section2_dataGridView1.ColumnWidthChanged += dataGridViewSection2_ColumnWidthChanged;
              Section2_dataGridView2.ColumnWidthChanged += dataGridViewSection2_ColumnWidthChanged;
              Section2_dataGridView3.ColumnWidthChanged += dataGridViewSection2_ColumnWidthChanged;*/
        }

        #region РАЗДЕЛ 1 (tab1)
        private DataGridView _gridSection1;

        #region Определяем активную таблицу раздела 1
        private void Section1_dataGridView1_Click(object sender, EventArgs e)
        {
            _gridSection1 = Section1_dataGridView1;
        }

        private void Section1_dataGridView2_Click(object sender, EventArgs e)
        {
            _gridSection1 = Section1_dataGridView2;
        }

        private void Section1_dataGridView3_Click(object sender, EventArgs e)
        {
            _gridSection1 = Section1_dataGridView3;
        }
        #endregion

        #region datagridView1 - По плану мероприятий отчетного года; datagridView2 - Дополнительные мероприятия
        /// <summary>
        /// Событие. Происходит при клике-нажатии на ячейку
        /// Выбор ячейки с в таблице(для того, что бы comboBox раскрывался сразу)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //_gridSection1 = (DataGridView)sender;
            //если textBox, чтобы не вызывать DropDown. (проверка для поля итого)           
            if ("System.Windows.Forms.DataGridViewComboBoxEditingControl".Equals(_gridSection1.CurrentCell.EditType.ToString()))
            {
                if (e.ColumnIndex == 2)
                {
                    ((ComboBox)_gridSection1.EditingControl).DroppedDown = true;
                    ((ComboBox)_gridSection1.EditingControl).SelectionChangeCommitted += new EventHandler(Section1_SelectedIndexChanged);
                }
                else
                {
                    ((ComboBox)_gridSection1.EditingControl).DroppedDown = true;
                    ((ComboBox)_gridSection1.EditingControl).SelectionChangeCommitted -= new EventHandler(Section1_SelectedIndexChanged);
                }
            }
        }

        /// <summary>
        /// Подстановка "Код" и "Единицы измерения" при выборе из ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Section1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _db = new E_RespondentDataContext();
            int index = Convert.ToInt32(((ComboBox)sender).SelectedValue);
            DestinationSave row = (from c in _db.DestinationSave
                                   where c.CodeRecord == index
                                   select c).Single<DestinationSave>();
            _gridSection1.CurrentRow.Cells[0].Value = row.CodeDirection;
            if (!_gridSection1.Tag.Equals("T3"))
            {
                _gridSection1.CurrentRow.Cells[4].Value = row.Unit;
            }
            _gridSection1.EndEdit();
        }

        /// <summary>
        /// Событие на вывод строки "Итого"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxTable1_Click(object sender, EventArgs e)
        {
            DataGridView grid = null;
            CheckBox c = ((CheckBox)sender);
            if (c.Name.Equals("checkBoxTable1"))
            {
                grid = Section1_dataGridView1;
            }
            if (c.Name.Equals("checkBoxTable2"))
            {
                grid = Section1_dataGridView2;
            }
            if (grid.RowCount > 1)
            {
                if (grid != null)
                {
                    grid.AllowUserToAddRows = false;
                    int rowCount = grid.RowCount;
                    DataGridViewRow newRow = new DataGridViewRow();
                    if (c.Checked)
                    {
                        for (int i = 0; i < grid.ColumnCount; i++)
                        {
                            newRow.Cells.Add(new DataGridViewTextBoxCell());
                        }
                        newRow.ReadOnly = true;
                        grid.Rows.InsertRange(rowCount, newRow);
                        rowCount = grid.RowCount;

                        grid[2, rowCount - 1].Value = "Итого";
                        StyleTotalCells(grid);
                        FillRowValue_X(grid, grid.RowCount - 1, 3, 5);
                        AutoTotalSumm.TotalSumm(grid, 6); //6 - потому что расчет Итого ведется начиная с 6 колонки таблицы (графа 2 - Экономия ТЭР) 
                        AutoTotalSumm.FillTotalRow(grid, 6);
                    }
                    else
                    {
                        grid.Rows.RemoveAt(rowCount - 1);
                        grid.AllowUserToAddRows = true;
                    }
                }
            }
        }

        /// <summary>
        /// Активирует элемент управления CheckBox для добавления строки ИТОГО
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var grid = ((DataGridView)sender);

            if (grid.Tag.Equals("T1"))
                checkBoxTable1.Enabled = true;
            else
                checkBoxTable2.Enabled = true;

            grid.Focus();
        }

        /// <summary>
        /// Вызываем пересчет ИТОГО
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1and2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            grid.EndEdit();
            if (grid.Name.Equals("Section1_dataGridView1"))
            {
                AutoTotalSumm.TotalSumm(grid, 6); //6 - потому что расчет Итого ведется начиная с 6 колонки таблицы (графа 2 - Экономия ТЭР) 
                if (checkBoxTable1.Checked)
                {
                    AutoTotalSumm.FillTotalRow(grid, 6);
                }
            }
            else
            {
                if (grid.Name.Equals("Section1_dataGridView2"))
                {
                    AutoTotalSumm.TotalSumm(grid, 6); //6 - потому что расчет Итого ведется начиная с 6 колонки таблицы (графа 2 - Экономия ТЭР) 
                    if (checkBoxTable2.Checked)
                    {
                        AutoTotalSumm.FillTotalRow(grid, 6);
                    }
                }
            }
            //Пересчитать всего по разделу, если изменились значения
            if (checkBoxTable3.Checked)
            {
                AutoTotalSumm.TotalSummGrid3(Section1_dataGridView3, 6);
                AutoTotalSumm.TotalAll1Section(Section1_dataGridView1, Section1_dataGridView2, Section1_dataGridView3, 6);
                AutoTotalSumm.FillGrid3(Section1_dataGridView3, 6);
            }
        }

        /// <summary>
        /// Для изменения ширины столбцов, для каждой таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            for (int i = 0; i < Section1_dataGridViewHeader1_1.ColumnCount; i++)
            {
                Section1_dataGridView1.Columns[i].Width = Section1_dataGridViewHeader1_1.Columns[i].Width;
                Section1_dataGridView2.Columns[i].Width = Section1_dataGridViewHeader1_1.Columns[i].Width;
                Section1_dataGridView3.Columns[i].Width = Section1_dataGridViewHeader1_1.Columns[i].Width;
            }
            /* При изменении размера столбца в любой колонке, изменялась ширина колонок во всех таблицах
            int indexCol = e.Column.Index;
            int newWidth = e.Column.Width;
            Section1_dataGridView1.Columns[indexCol].Width = newWidth;
            Section1_dataGridView2.Columns[indexCol].Width = newWidth;
            Section1_dataGridView3.Columns[indexCol].Width = newWidth;
            */
        }
        #endregion

        #region dataGridView3 -
        /// <summary>
        /// Для datagridView 3 нужно указать столбца которые нельзя редактировать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView3_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView grid = ((DataGridView)sender);
            //int _rowNumber = grid.CurrentRow.Index;
            int rowNumber = grid.RowCount - 2;
            checkBoxTable3.Enabled = true;

            //!!!!!!!!!!!!!Пустить по циклу
            grid.Rows[rowNumber].Cells[4].Value = "X";
            grid.Rows[rowNumber].Cells[4].ReadOnly = true;
            grid.Rows[rowNumber].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Rows[rowNumber].Cells[4].Style.BackColor = Color.LightGray;

            grid.Rows[rowNumber].Cells[5].Value = "X";
            grid.Rows[rowNumber].Cells[5].ReadOnly = true;
            grid.Rows[rowNumber].Cells[5].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Rows[rowNumber].Cells[5].Style.BackColor = Color.LightGray;

            for (int cellInd = 7; cellInd < 15; cellInd++)
            {
                grid.Rows[rowNumber].Cells[cellInd].Value = "X";
                grid.Rows[rowNumber].Cells[cellInd].ReadOnly = true;
                grid.Rows[rowNumber].Cells[cellInd].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Rows[rowNumber].Cells[cellInd].Style.BackColor = Color.LightGray;
            }

            grid.ClearSelection();
            grid.Focus();
        }

        /// <summary>
        /// 3-ий checkBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxTable3_Click(object sender, EventArgs e)
        {
            DataGridView grid = null;
            grid = Section1_dataGridView3;
            CheckBox c = ((CheckBox)sender);

            if (grid != null && grid.RowCount > 1)
            {
                grid.AllowUserToAddRows = false;
                int rowCount = grid.RowCount;
                DataGridViewRow newRow = new DataGridViewRow();
                if (c.Checked)
                {
                    for (int i = 0; i < grid.ColumnCount; i++)
                    {
                        newRow.Cells.Add(new DataGridViewTextBoxCell());
                    }
                    newRow.ReadOnly = true;
                    grid.Rows.InsertRange(rowCount, newRow);
                    rowCount = grid.RowCount;

                    grid[2, rowCount - 1].Value = "Итого";
                    StyleTotalCells(grid);
                    FillRowValue_X(grid, grid.RowCount - 1, 3, 5);
                    FillRowValue_X(grid, grid.RowCount - 1, 7, 14);

                    //добавим строку ИТОГО ПО РАЗДЕЛУ 1
                    rowCount = grid.RowCount;
                    newRow = new DataGridViewRow();
                    for (int i = 0; i < grid.ColumnCount; i++)
                    {
                        newRow.Cells.Add(new DataGridViewTextBoxCell());
                    }
                    grid.Rows.InsertRange(rowCount, newRow);
                    rowCount = grid.RowCount;
                    grid[2, rowCount - 1].Value = "Всего по разделу I";
                    grid[2, rowCount - 1].ReadOnly = true;
                    grid[2, rowCount - 1].Style.Alignment = DataGridViewContentAlignment.TopLeft;
                    grid[2, rowCount - 1].Style.BackColor = Color.LightGray;
                    FillRowValue_X(grid, grid.RowCount - 1, 3, 5);
                    //end                   
                    AutoTotalSumm.TotalSummGrid3(Section1_dataGridView3, 6);
                    AutoTotalSumm.TotalAll1Section(Section1_dataGridView1, Section1_dataGridView2, Section1_dataGridView3, 6);
                    AutoTotalSumm.FillGrid3(grid, 6);

                }
                else
                {
                    grid.Rows.RemoveAt(grid.RowCount - 1);
                    grid.Rows.RemoveAt(grid.RowCount - 1);
                    grid.AllowUserToAddRows = true;
                }
            }
        }

        /// <summary>
        /// Пересчет итого, при редактировании ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            grid.EndEdit();
            if (checkBoxTable3.Checked)
            {
                AutoTotalSumm.TotalSummGrid3(grid, 6);
                AutoTotalSumm.TotalAll1Section(Section1_dataGridView1, Section1_dataGridView2, Section1_dataGridView3, 6);
                AutoTotalSumm.FillGrid3(grid, 6);
            }
        }
        #endregion

        #region Главное меню

        private void соединитьСБазойДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionDB connection = new ConnectionDB();
            SqlConnection conn = connection.CreateConnection();
            statusStrip1.Items[0].Text = conn != null ? "Соединение установлено!" : "Ошибка соединения!";
        }

        private void ВыходToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Контрольные функции для раздела 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void контрольныеФункцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Снимаем выделения с ячеек таблицы и активируем строку ИТОГО
            Section1_dataGridView1.CurrentCell = null;
            Section1_dataGridView2.CurrentCell = null;
            Section1_dataGridView3.CurrentCell = null;
            Section2_dataGridView1.CurrentCell = null;
            Section2_dataGridView2.CurrentCell = null;
            Section2_dataGridView3.CurrentCell = null;
            Section3_T3.CurrentCell = null;
            Section3_T4.CurrentCell = null;
            Section3_T5.CurrentCell = null;

            if (Section1_dataGridView1.RowCount > 1)
            { checkBoxTable1.Checked = true; }
            if (Section1_dataGridView2.RowCount > 1)
            { checkBoxTable2.Checked = true; }
            if (Section1_dataGridView3.RowCount > 1)
            { checkBoxTable3.Checked = true; }

            if (Section2_dataGridView1.RowCount > 1)
            { Section2_checkBoxTable1.Checked = true; }
            if (Section2_dataGridView2.RowCount > 1)
            { Section2_checkBoxTable2.Checked = true; }
            if (Section2_dataGridView3.RowCount > 1)
            { Section2_checkBoxTable3.Checked = true; }
            #endregion

            CheckProtocol.ErrorForAllSection.Clear();
            ControlFunction controlObj = new ControlFunction();
            controlObj.CheckSection(Section1_dataGridView1, Section1_dataGridView2, Section1_dataGridView3,
                "РАЗДЕЛ 1: ВЫПОЛНЕНИЕ МЕРОПРИЯТИЙ ПО ЭКОНОМИИ ТОПЛИВНО-ЭНЕРГЕТИЧЕСКИХ РЕСУРСОВ (ТЭР)\n", 8);

            controlObj = new ControlFunction();
            controlObj.CheckSection(Section2_dataGridView1, Section2_dataGridView2, Section2_dataGridView3, "\n\nРАЗДЕЛ 2: ВЫПОЛНЕНИЕ МЕРОПРИЯТИЙ ПО" +
            "УВЕЛИЧЕНИЮ ИСПОЛЬЗОВАНИЯ МЕСТНЫХ ВИДОВ ТОПЛИВА, ОТХОДОВ ПРОИЗВОДСТВА И ДРУГИХ ВТОРИЧНЫХ И ВОЗОБНОВЛЯЕМЫХ ЭНЕРГОРЕСУРСОВ (МВТ)\n", 10);
            DataGridView[] massGrid = new DataGridView[] { Section1_dataGridView1, Section1_dataGridView2, Section2_dataGridView1, Section2_dataGridView2 };


            //Фактическое значение из Раздела 3 таблицы 3 (строка 1)
            controlObj.CheckSection3Table3Row1(massGrid, Section3_T3);

            //Фактическое значение из Раздела 3 таблицы 3 (Строка 2)
            controlObj.CheckSection3Table3Row2(Section1_dataGridView1, Section1_dataGridView2, Section3_T3);

            //Фактическое значение из Раздела 3 таблицы 3 (Строка 3)
            controlObj.CheckSection3Table3Row3(Section2_dataGridView1, Section2_dataGridView2, Section3_T3);

            //Фактическое значение из Раздела 3 таблицы 3 (Строка 4)
            int iii = Section1_dataGridView3.RowCount;
            controlObj.CheckSection3Table3Row4(Section1_dataGridView3, Section2_dataGridView3, Section3_T3);

            controlObj.ShowListError();

        }

        private void экспортВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //завершает режим редактирования ячейки
            Section3_T3.EditingPanel.Hide();
            Section3_T4.EditingPanel.Hide();
            Section3_T5.EditingPanel.Hide();
            ExcelExport.InitSection1(Section1_dataGridView1, Section1_dataGridView2, Section1_dataGridView3);
            ExcelExport.InitSection2(Section2_dataGridView1, Section2_dataGridView2, Section2_dataGridView3);
            ExcelExport.InitSection3(Section3_T3, Section3_T4, Section3_T5);
        }
        #endregion

        #region Работа с ячейками таблицы

        /// <summary>
        /// Метод заполняющий ячейки
        /// </summary>
        /// <param name="grid">Таблица, в которой заполняются ячейки</param>
        /// <param name="numberRow">Количество строк в таблице</param>
        /// <param name="from">От какой ячейки заполнять</param>
        /// <param name="to">До какой ячейки заполнять</param>
        private static void FillRowValue_X(DataGridView grid, int numberRow, int from, int to)
        {
            for (int colInd = from; colInd < to + 1; colInd++)
            {
                grid[colInd, numberRow].Value = "X";
                grid[colInd, numberRow].ReadOnly = true;
                grid[colInd, numberRow].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid[colInd, numberRow].Style.BackColor = Color.LightGray;
            }
        }
        #endregion

        #region Контекстное меню таблицы 1 и 2 !(Переделать)

        private DataGridView _gridContext = null;
        private ContextMenuStrip _strip;
        private void DataGridView1EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            _gridContext = ((DataGridView)sender);

            var delete = new ToolStripMenuItem();
            var add = new ToolStripMenuItem();
            var copyText = new ToolStripMenuItem();
            var pasteText = new ToolStripMenuItem();
            var cutText = new ToolStripMenuItem();

            if (_strip == null)
            {
                _strip = new ContextMenuStrip();
                delete.Text = @"Удалить строку";
                delete.Name = "delete";
                add.Text = @"Добавить строку";
                add.Name = "add";
                copyText.Text = @"Копировать текст ячейки";
                copyText.Name = "copy";
                pasteText.Text = @"Вставить";
                pasteText.Name = "paste";
                cutText.Text = @"Вырезать";
                cutText.Name = "cut";
                _strip.Items.Add(delete);
                _strip.Items.Add(add);
                //strip.Items.Add(copyText);
                //strip.Items.Add(pasteText);
                //strip.Items.Add(cutText);

                _strip.Items["delete"].Click += new EventHandler(DeleteClick);
                _strip.Items["add"].Click += new EventHandler(AddClick);
                //strip.Items["copy"].Click += new EventHandler(copyText_Click);
                //strip.Items["paste"].Click += new EventHandler(pasteText_Click);

            }
            //чтобы нельзя было удалить новую пустую строку
            if (_gridContext.CurrentRow.Index == _gridContext.RowCount - 1)
            {
                _strip.Items["delete"].Enabled = false;
            }
            else { _strip.Items["delete"].Enabled = true; }


            e.Control.ContextMenuStrip = _strip;
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            _gridContext.Rows.RemoveAt(_gridContext.CurrentRow.Index);
        }

        private void AddClick(object sender, EventArgs e)
        {
            _gridContext.Rows.Add();
        }

        private void CopyTextClick(object sender, EventArgs e)
        {
            Clipboard.SetText(_gridContext.SelectedCells[0].Value.ToString());
        }

        private void PasteTextClick(object sender, EventArgs e)
        {
            _gridContext.SelectedCells[0].Value = Clipboard.GetText();
            _gridContext.UpdateCellValue(6, 0);

        }
        #endregion

        #endregion

        #region РАЗДЕЛ 2 (tab2)

        #region Таблица 1 и 2 и 3

        /// <summary>
        /// Метод для заполнения comboBox для 1 и 2 таблицы (раздел 2)
        /// </summary>
        /// <param name="boxColumn">Столбец, в ячейках которого располагается выпадающий список</param>
        /// <param name="nameTable">Имя таблицы из которой берем данные для заполнения выпадающего списка</param>
        private void FillComboBoxLinq(DataGridViewComboBoxColumn boxColumn, string nameTable)
        {
            _db = new E_RespondentDataContext();
            switch (nameTable)
            {
                case "DestinationSave":
                    var save = from c in _db.DestinationSave
                               select c;
                    boxColumn.DataSource = save;
                    boxColumn.DisplayMember = "DestinationsSave";
                    boxColumn.ValueMember = "Coderecord";
                    // новое добавление
                    boxColumn.DataPropertyName = "Coderecord";
                    break;
                case "TypeFuelEnergy":
                    var energy = from c in _db.TypeFuelEnergy
                                 select c;
                    boxColumn.DataSource = energy;
                    boxColumn.DisplayMember = "CodeTypeFuel";
                    boxColumn.ValueMember = "CodeRecord";
                    // новое добавление
                    boxColumn.DataPropertyName = "Coderecord";
                    break;
            }
            boxColumn.DropDownWidth = 1200;
        }

        private DataGridView _gridSection2;
        /// <summary>
        /// Событие, которое происходит по нажатию на ячейку dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Section2_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ("System.Windows.Forms.DataGridViewComboBoxEditingControl".Equals(_gridSection2.CurrentCell.EditType.ToString()))
            {
                if (e.ColumnIndex == 2)
                {
                    ((ComboBox)_gridSection2.EditingControl).DroppedDown = true;
                    ((ComboBox)_gridSection2.EditingControl).SelectionChangeCommitted += new EventHandler(Section2_SelectedIndexChanged);
                }
                else
                {
                    ((ComboBox)_gridSection2.EditingControl).DroppedDown = true;
                    ((ComboBox)_gridSection2.EditingControl).SelectionChangeCommitted -= new EventHandler(Section2_SelectedIndexChanged);
                }
            }
        }

        /// <summary>
        /// Подстановка "Код" и "Единицы измерения" при выборе из ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Section2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _db = new E_RespondentDataContext();
            int index = Convert.ToInt32(((ComboBox)sender).SelectedValue);
            DestinationSave row = (from c in _db.DestinationSave
                                   where c.CodeRecord == index
                                   select c).Single<DestinationSave>();
            _gridSection2.CurrentRow.Cells[0].Value = row.CodeDirection;
            if (!_gridSection2.Tag.Equals("T3"))
            {
                _gridSection2.CurrentRow.Cells[6].Value = row.Unit;
            }
            _gridSection2.EndEdit();
        }

        /// <summary>
        /// Проверка правильности ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Section3_T3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (((DataGridView)sender).CurrentCell.Value != null)
                {
                    double.Parse(((DataGridView)sender).CurrentCell.Value.ToString());
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Ошибка формата: введите число!", @"Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ((DataGridView)sender).CurrentCell.Value = null;
            }

            for (int i = 1; i < 5; i++)
            {
                if (((DataGridView)sender)[3, i].Value != null
                    && Convert.ToDouble(((DataGridView)sender)[3, i].Value) != 0
                    && ((DataGridView)sender)[4, i].Value != null)
                {
                    ((DataGridView)sender)[5, i].Value = Convert.ToDouble(((DataGridView)sender)[4, i].Value)
                                                        / Convert.ToDouble(((DataGridView)sender)[3, i].Value);
                }
            }
        }
        #endregion

        #region Section2_checkBoxTable
        /// <summary>
        /// Событие для обработки нажатия CheckBox (Для добавления строки итого)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Section2_checkBoxTable_Click(object sender, EventArgs e)
        {
            switch (((CheckBox)sender).Tag.ToString())
            {
                case "Section2_chB1":
                    Activate_1and2_CheckBox(sender, Section2_dataGridView1);
                    break;
                case "Section2_chB2":
                    Activate_1and2_CheckBox(sender, Section2_dataGridView2);
                    break;
                case "Section2_chB3":
                    Activate_3_CheckBox(sender, Section2_dataGridView3);
                    break;
            }
        }

        /// <summary>
        /// Для добавления строки итого для 1 и 2 таблицы
        /// </summary>
        /// <param name="sender"></param>
        private void Activate_1and2_CheckBox(object sender, DataGridView grid)
        {
            //когда нажата, добавляем строку
            if (((CheckBox)sender).Checked)
            {
                InsertTextRow(grid);
                grid[2, grid.RowCount - 1].Value = "Итого";
                grid[2, grid.RowCount - 1].Selected = true;
                StyleTotalCells(grid);
                FillRowValue_X(grid, grid.RowCount - 1, 3, 7);
                AutoTotalSumm.TotalSumm(grid, 8);
                AutoTotalSumm.FillTotalRow(grid, 8);
            }
            //когда отжата - удаляем строку итого
            else
            {
                if (grid.Rows.Count > 0)
                {
                    grid.Rows.RemoveAt(grid.Rows.Count - 1);
                    grid.AllowUserToAddRows = true;
                }
            }
        }

        /// <summary>
        /// Для добавления строки "Итого" и "Всего по разделу" для 3 талблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="grid"></param>
        private void Activate_3_CheckBox(object sender, DataGridView grid)
        {
            if (((CheckBox)sender).Checked)
            {
                InsertTextRow(grid);
                grid[2, grid.RowCount - 1].Value = "Итого";
                StyleTotalCells(grid);
                FillRowValue_X(grid, grid.RowCount - 1, 3, 7);
                FillRowValue_X(grid, grid.RowCount - 1, 9, 16);

                InsertTextRow(grid);
                grid[2, grid.RowCount - 1].Value = "Всего по разделу 2";
                StyleTotalCells(grid);
                FillRowValue_X(grid, grid.RowCount - 1, 3, 7);

                AutoTotalSumm.TotalSummGrid3(grid, 8);
                AutoTotalSumm.TotalAll1Section(Section2_dataGridView1, Section2_dataGridView2, Section2_dataGridView3, 8);
                AutoTotalSumm.FillGrid3(grid, 8);

                /*AutoTotalSumm.TotalSummGrid3(Section1_dataGridView3, 6);
                AutoTotalSumm.TotalAll1Section(Section1_dataGridView1, Section1_dataGridView2, Section1_dataGridView3, 6);
                AutoTotalSumm.FillGrid3(Section1_dataGridView3, 6);*/
            }
            else
            {
                grid.Rows.RemoveAt(grid.Rows.Count - 1);
                grid.Rows.RemoveAt(grid.Rows.Count - 1);
                grid.AllowUserToAddRows = true;
            }

        }

        /// <summary>
        /// Изменение стиля ячеек для строки Итого
        /// </summary>
        /// <param name="grid"></param>
        private static void StyleTotalCells(DataGridView grid)
        {
            grid[2, grid.RowCount - 1].ReadOnly = true;
            grid[2, grid.RowCount - 1].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid[2, grid.RowCount - 1].Style.BackColor = Color.LightGray;
        }

        #endregion

        #region Определяем текущую таблицу
        private void Section2_dataGridView1_Click(object sender, EventArgs e)
        {
            _gridSection2 = Section2_dataGridView1;
        }

        private void Section2_dataGridView2_Click(object sender, EventArgs e)
        {
            _gridSection2 = Section2_dataGridView2;
        }

        private void Section2_dataGridView3_Click(object sender, EventArgs e)
        {
            _gridSection2 = Section2_dataGridView3;
        }
        #endregion

        /// <summary>
        /// Событие, которое происходит при изменении размера столбца (в шапке таблицы),
        /// при этом все связанные с этой колонкой столбцы тоже меняют размер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewSection2_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            for (int i = 0; i < Section2_dataGridViewHeader2_1.ColumnCount; i++)
            {
                Section2_dataGridView1.Columns[i].Width = Section2_dataGridViewHeader2_1.Columns[i].Width;
                Section2_dataGridView2.Columns[i].Width = Section2_dataGridViewHeader2_1.Columns[i].Width;
                Section2_dataGridView3.Columns[i].Width = Section2_dataGridViewHeader2_1.Columns[i].Width;
            }
        }

        /// <summary>
        /// Активировать элемент управления (checkBox) для Итого
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Section2_dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            switch (((DataGridView)sender).Tag.ToString())
            {
                case "T1":
                    Section2_checkBoxTable1.Enabled = true;
                    break;
                case "T2":
                    Section2_checkBoxTable2.Enabled = true;
                    break;
                case "T3":
                    FillRowValue_X(Section2_dataGridView3, Section2_dataGridView3.RowCount - 2, 6, 7);
                    FillRowValue_X(Section2_dataGridView3, Section2_dataGridView3.RowCount - 2, 9, 16);
                    Section2_checkBoxTable3.Enabled = true;
                    break;
            }
            // ((DataGridView)sender).ClearSelection();
        }

        /// <summary>
        /// Создает строку c текстовыми полями и вставляет в конец (для поля "Итого" и "Всего по разделу")
        /// </summary>
        /// <param name="grid"></param>
        private void InsertTextRow(DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            var newRow = new DataGridViewRow();
            for (int i = 0; i < Section2_dataGridView1.ColumnCount; i++)
            {
                newRow.Cells.Add(new DataGridViewTextBoxCell());
            }
            newRow.ReadOnly = true;
            grid.Rows.InsertRange(grid.Rows.Count, newRow);
        }

        /// <summary>
        /// Пересчет значений ИТОГО при изменении значения ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Section2_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (((DataGridView)sender).Name)
            {
                case "Section2_dataGridView1":
                    AutoTotalSumm.TotalSumm(((DataGridView)sender), 8);
                    if (Section2_checkBoxTable1.Checked)
                    {
                        AutoTotalSumm.FillTotalRow(((DataGridView)sender), 8);
                    }
                    break;
                case "Section2_dataGridView2":
                    AutoTotalSumm.TotalSumm(((DataGridView)sender), 8);
                    if (Section2_checkBoxTable2.Checked)
                    {
                        AutoTotalSumm.FillTotalRow(((DataGridView)sender), 8);
                    }
                    break;
            }
            if (Section2_checkBoxTable3.Checked)
            {
                AutoTotalSumm.TotalSummGrid3(Section2_dataGridView3, 8);
                AutoTotalSumm.TotalAll1Section(Section2_dataGridView1, Section2_dataGridView2, Section2_dataGridView3, 8);
                AutoTotalSumm.FillGrid3(Section2_dataGridView3, 8);
            }
        }
        #endregion

        #region Раздел 3 (tab3)


        /// <summary>
        /// Заполнение таблицы 3, 4, 5 (РАЗДЕЛ 3)
        /// </summary>
        private void FillSection3Table1()
        {
            #region Таблица 3
            Section3_T3.Rows.Add(5);
            Section3_T3[0, 0].Value = "А";
            Section3_T3[1, 0].Value = "Б";
            Section3_T3[2, 0].Value = "В";
            Section3_T3[3, 0].Value = "1";
            Section3_T3[4, 0].Value = "2";
            Section3_T3[5, 0].Value = "3";

            for (int i = 0; i < 6; i++)
            {
                Section3_T3[i, 0].ReadOnly = true;
                Section3_T3[i, 0].Style.BackColor = Color.FromArgb(181, 181, 181);
                Section3_T3[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Section3_T3[0, 1].Value = "Количество мероприятий";
            Section3_T3[1, 1].Value = "1";
            Section3_T3[2, 1].Value = "ед.";

            Section3_T3[0, 2].Value = "Экономия ТЭР";
            Section3_T3[1, 2].Value = "2";
            Section3_T3[2, 2].Value = "т усл. топл.";

            Section3_T3[0, 3].Value = "Увеличение использования МВТ";
            Section3_T3[1, 3].Value = "3";
            Section3_T3[2, 3].Value = "т усл. топл.";

            Section3_T3[0, 4].Value = "Затраты на внедрение  мероприятий";
            Section3_T3[1, 4].Value = "4";
            Section3_T3[2, 4].Value = "млн.руб.";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Section3_T3[i, j].ReadOnly = true;
                    Section3_T3[i, j].Style.BackColor = Color.FromArgb(240, 240, 240);
                    Section3_T3[i, j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            #endregion

            #region Таблица 4
            Section3_T4.Rows.Add();
            Section3_T4[0, 0].Value = "A";
            Section3_T4[1, 0].Value = "1";
            Section3_T4[2, 0].Value = "2";
            for (int i = 0; i < 3; i++)
            {
                Section3_T4[i, 0].ReadOnly = true;
                Section3_T4[i, 0].Style.BackColor = Color.FromArgb(181, 181, 181);
                Section3_T4[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            Section3_T4.Rows.Add();
            Section3_T4[0, 1].Value = "5";
            Section3_T4[0, 1].ReadOnly = true;
            Section3_T4[0, 1].Style.BackColor = Color.FromArgb(240, 240, 240);
            Section3_T4[0, 1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            #endregion

            #region Таблица 5
            Section3_T5.Rows.Add();
            Section3_T5[0, 0].Value = "А";
            Section3_T5[1, 0].Value = "Б";
            Section3_T5[2, 0].Value = "В";

            for (int i = 0; i < 3; i++)
            {
                Section3_T5[i, 0].ReadOnly = true;
                Section3_T5[i, 0].Style.BackColor = Color.FromArgb(181, 181, 181);
                Section3_T5[i, 0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            #endregion
        }

        #endregion

        /// <summary>
        /// Устанавливает размер формы по размерам разрешения экрана
        /// </summary>
        private void ScreenResolution()
        {
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = new Point(0, 0);
            this.Height = heightScreen;
            this.Width = widthScreen;
        }

        /// <summary>
        /// Горячие клавиши на удаление записи в таблице (cltr+del)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Section1_dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    try
                    {
                        int indexRow;
                        if (_gridSection1 != null && _gridSection1.RowCount > 1)
                        {
                            indexRow = _gridSection1.CurrentRow.Index;
                            _gridSection1.Rows.RemoveAt(indexRow);
                        }
                        if (_gridSection2 != null && _gridSection2.RowCount > 1)
                        {
                            indexRow = _gridSection2.CurrentRow.Index;
                            _gridSection2.Rows.RemoveAt(indexRow);
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(@"Удаление непереданной строки невозможно!", @"Внимание!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }
        }

        /// <summary>
        /// При "разворачивании/сворачивании в окно" меняются заголовки слолбцов в каждой таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportPanel_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized || this.WindowState==FormWindowState.Maximized)
            {
                for (int i = 0; i < Section1_dataGridViewHeader1_1.ColumnCount; i++)
                {
                    Section1_dataGridView1.Columns[i].Width = Section1_dataGridViewHeader1_1.Columns[i].Width;
                    Section1_dataGridView2.Columns[i].Width = Section1_dataGridViewHeader1_1.Columns[i].Width;
                    Section1_dataGridView3.Columns[i].Width = Section1_dataGridViewHeader1_1.Columns[i].Width;
                }

                for (int i = 0; i < Section2_dataGridViewHeader2_1.ColumnCount; i++)
                {
                    Section2_dataGridView1.Columns[i].Width = Section2_dataGridViewHeader2_1.Columns[i].Width;
                    Section2_dataGridView2.Columns[i].Width = Section2_dataGridViewHeader2_1.Columns[i].Width;
                    Section2_dataGridView3.Columns[i].Width = Section2_dataGridViewHeader2_1.Columns[i].Width;
                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveHelper objHelper = new SaveHelper(_year, _kodOkpo);
        }
    }
}

