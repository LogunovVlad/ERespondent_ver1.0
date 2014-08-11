using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERespondent.Entity;

namespace ERespondent
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private OkpoForm _okpoForm;
        private DirectionEnergySave _formDirEnSave;
        private TypeFuel _formTypeFuel;
        private Color _defaultCellColor;

        private void ReportPanel_Load(object sender, EventArgs e)
        {
            ScreenResolution();
            _defaultCellColor = dataGridView_ReportManager.DefaultCellStyle.SelectionBackColor;
        }

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

        #region Главное меню
        private void справочникКодовОКПООрганизацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _okpoForm = new OkpoForm { Owner = this };
            //указываем владельца
            _okpoForm.Show();
        }

        private void переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formDirEnSave = new DirectionEnergySave();
            _formDirEnSave.Owner = this;
            _formDirEnSave.Show();
        }

        private void видыТопливаИЭнергииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formTypeFuel = new TypeFuel { Owner = this };
            _formTypeFuel.Show();
        }

        private void создатьНовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewReport formRep = new CreateNewReport();
            formRep.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] n = new int[] { 100, 200, 301, 302, 303, 304 };
            /*   _db = new E_RespondentDataContext();
               for (int i = 1; i < n.Count(); i++)
               {
                   Section1_dataGridView1.Rows.Add();
                   Section1_dataGridView1[0, i].Value = n[i];

                   //делаем активной ячейку содержащую ComboBox
                   Section1_dataGridView1.CurrentCell = Section1_dataGridView1.Rows[i].Cells[2];
                   Section1_dataGridView1.Rows[i].Cells[2].Selected = true;
                   //Section1_dataGridView1.BeginEdit(true);

                   DestinationSave row = (from c in _db.DestinationSave
                                          where c.CodeDirection == n[i]
                                          select c).Single<DestinationSave>();
                   //устанавливаем индекс
                   ((DataGridViewComboBoxEditingControl)Section1_dataGridView1.EditingControl).SelectedValue = row.CodeRecord;
                   Section1_dataGridView1[3, i].Value = "23.03.2014";
                   Section1_dataGridView1[4, i].Value = row.Unit;
               }
               Section1_dataGridView1[0, 0].Value = n[0];
               Section1_dataGridView1.CurrentCell = Section1_dataGridView1.Rows[0].Cells[2];
               Section1_dataGridView1.Rows[0].Cells[2].Selected = true;
               ((DataGridViewComboBoxEditingControl)Section1_dataGridView1.EditingControl).SelectedValue = 1;
               //int index = Convert.ToInt32(((ComboBox)sender).SelectedValue);
               /*
               DestinationSave row = (from c in _db.DestinationSave
                                      where c.CodeRecord == index
                                      select c).Single<DestinationSave>();
               _gridSection2.CurrentRow.Cells[0].Value = row.CodeDirection;
               if (!_gridSection2.Tag.Equals("T3"))
               {
                   _gridSection2.CurrentRow.Cells[6].Value = row.Unit;
               }
               _gridSection2.EndEdit();
               */
        }

        #endregion

        private int _lastIndexRow = -1;
        private int _lastIndexColumn = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_lastIndexRow >=0)
            {
                ((DataGridView) sender).Rows[_lastIndexRow].Cells[_lastIndexColumn].Style.SelectionBackColor = _defaultCellColor;
            }

            ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor =  Color.LightBlue;
            _lastIndexRow = ((DataGridView)sender).CurrentCell.RowIndex;
            _lastIndexColumn = ((DataGridView)sender).CurrentCell.ColumnIndex;
        }

        
    }
}
