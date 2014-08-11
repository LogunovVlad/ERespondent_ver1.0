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
    public partial class CreateNewReport : Form
    {
        public CreateNewReport()
        {
            InitializeComponent();
        }

        private void CreateNewReport_Load(object sender, EventArgs e)
        {
            var _db = new E_RespondentDataContext();
            var kod = (from c in _db.OKPOs 
                       select c);
            comboBoxKod.DataSource = kod;
            comboBoxKod.DisplayMember = "CodeOKPO";
            comboBoxKod.ValueMember = "CodeRecord";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(comboBoxKod.Text.Length<2||comboBoxYear.Text.Length<2)
            {
                MessageBox.Show("Атрибуты долнжы быть заполнены!", "Ошибка!", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                this.Close();
                ReportPanel _formReport=new ReportPanel();
                _formReport.Show();
            }
        }
       
    }
}
