using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERespondent
{
    public partial class AddEditOKPO : Form
    {
        public AddEditOKPO()
        {
            InitializeComponent();
        }
        OkpoForm formOKPO;
        private void AddEditOKPO_Load(object sender, EventArgs e)
        {
            formOKPO = this.Owner as OkpoForm;
            //проверка: какую функцию давать форме - добавление или редактирование
            if (formOKPO.Tag.Equals("ADD"))
            {
                btnOk.Click += new EventHandler(ClickAdd);
            }
            else
            {
                try
                {
                    txtOkpo.Text = formOKPO.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtName.Text = formOKPO.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    btnOk.Click += new EventHandler(ClickEdit);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show(@"Не выбрана запись для редактирования!", @"Ошибка редактирования!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        /// <summary>
        /// Редактирование записи в DataTable
        /// </summary>
        private void ClickEdit(object sender, EventArgs e)
        {
            try
            {
                //определим индекс изменяемой строки
                int indexRow = formOKPO.dataGridView1.CurrentRow.Index;
                if (txtOkpo.Text.Length != 12)
                {
                    MessageBox.Show(@"Код должен состоять из 12 символов!", @"Внимание!", MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                    txtOkpo.BackColor = Color.LightYellow;
                    txtOkpo.Select();
                }
                else
                {
                    txtOkpo.BackColor = Color.White;
                    formOKPO._dsOKPO.Tables["OKPO"].Rows[indexRow]["CodeOKPO"] = txtOkpo.Text.ToString();
                    formOKPO._dsOKPO.Tables["OKPO"].Rows[indexRow]["NameOrganization"] = txtName.Text.ToString();

                    formOKPO._daOKPO.Update(formOKPO._dsOKPO);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Добавление записи в DataSet, путем создания DataRow и вставки этой строки DataTable
        /// </summary>        
        private void ClickAdd(object sender, EventArgs e)
        {
            try
            {
                DataTable tblOKPO;
                tblOKPO = formOKPO._dsOKPO.Tables["OKPO"];
                DataRow newOKPORow;
                newOKPORow = tblOKPO.NewRow();
                newOKPORow["CodeOKPO"] = txtOkpo.Text;
                newOKPORow["NameOrganization"] = txtName.Text;
                tblOKPO.Rows.Add(newOKPORow);

                formOKPO._daOKPO.Update(formOKPO._dsOKPO);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Событие происходит при изменении свойста TextBox.Text
        /// (для вывода уведомления о том, что код ОКПО должен быть 12 символов)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOkpo_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length != 12)
            {
                labelAlert12.ForeColor = Color.Red;
                labelAlert12.Visible = true;
                btnOk.Enabled = false;
            }
            else
            {
                labelAlert12.Visible = false;
                btnOk.Enabled = true;
            }

        }

    }
}
