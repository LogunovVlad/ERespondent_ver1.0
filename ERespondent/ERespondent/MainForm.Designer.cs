namespace ERespondent
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникКодовОКПООрганизацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыТопливаИЭнергииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНаПодобиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакНовуюВерсиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnKodOkpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNameOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMonthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.данныеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1164, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникКодовОКПООрганизацийToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.правкаToolStripMenuItem.Text = "ОКПО";
            // 
            // справочникКодовОКПООрганизацийToolStripMenuItem
            // 
            this.справочникКодовОКПООрганизацийToolStripMenuItem.Name = "справочникКодовОКПООрганизацийToolStripMenuItem";
            this.справочникКодовОКПООрганизацийToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.справочникКодовОКПООрганизацийToolStripMenuItem.Text = "Справочник кодов ОКПО организаций";
            this.справочникКодовОКПООрганизацийToolStripMenuItem.Click += new System.EventHandler(this.справочникКодовОКПООрганизацийToolStripMenuItem_Click);
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem,
            this.видыТопливаИЭнергииToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.данныеToolStripMenuItem.Text = "Справочники";
            // 
            // переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem
            // 
            this.переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem.Name = "переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem";
            this.переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem.Size = new System.Drawing.Size(369, 22);
            this.переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem.Text = "Перечень основных направлений энергосбережения";
            this.переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem.Click += new System.EventHandler(this.переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem_Click);
            // 
            // видыТопливаИЭнергииToolStripMenuItem
            // 
            this.видыТопливаИЭнергииToolStripMenuItem.Name = "видыТопливаИЭнергииToolStripMenuItem";
            this.видыТопливаИЭнергииToolStripMenuItem.Size = new System.Drawing.Size(369, 22);
            this.видыТопливаИЭнергииToolStripMenuItem.Text = "Виды топлива и энергии";
            this.видыТопливаИЭнергииToolStripMenuItem.Click += new System.EventHandler(this.видыТопливаИЭнергииToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1164, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйToolStripMenuItem,
            this.создатьНаПодобиеToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.создатьToolStripMenuItem.Text = "Создать...";
            // 
            // создатьНовыйToolStripMenuItem
            // 
            this.создатьНовыйToolStripMenuItem.Name = "создатьНовыйToolStripMenuItem";
            this.создатьНовыйToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.создатьНовыйToolStripMenuItem.Text = "Создать новый";
            this.создатьНовыйToolStripMenuItem.Click += new System.EventHandler(this.создатьНовыйToolStripMenuItem_Click);
            // 
            // создатьНаПодобиеToolStripMenuItem
            // 
            this.создатьНаПодобиеToolStripMenuItem.Name = "создатьНаПодобиеToolStripMenuItem";
            this.создатьНаПодобиеToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.создатьНаПодобиеToolStripMenuItem.Text = "Создать на подобие";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem1,
            this.сохранитьКакНовуюВерсиюToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить...";
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            // 
            // сохранитьКакНовуюВерсиюToolStripMenuItem
            // 
            this.сохранитьКакНовуюВерсиюToolStripMenuItem.Name = "сохранитьКакНовуюВерсиюToolStripMenuItem";
            this.сохранитьКакНовуюВерсиюToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.сохранитьКакНовуюВерсиюToolStripMenuItem.Text = "Сохранить как новую версию";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 247);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(202)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKodOkpo,
            this.ColumnNameOrganization,
            this.ColumnMonthYear,
            this.ColumnEdit,
            this.ColumnStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 18;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnKodOkpo
            // 
            this.ColumnKodOkpo.HeaderText = "Код ОКПО";
            this.ColumnKodOkpo.Name = "ColumnKodOkpo";
            // 
            // ColumnNameOrganization
            // 
            this.ColumnNameOrganization.HeaderText = "Наименование организации";
            this.ColumnNameOrganization.Name = "ColumnNameOrganization";
            // 
            // ColumnMonthYear
            // 
            this.ColumnMonthYear.HeaderText = "Период";
            this.ColumnMonthYear.Name = "ColumnMonthYear";
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "Изменен";
            this.ColumnEdit.Name = "ColumnEdit";
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Состояние";
            this.ColumnStatus.Name = "ColumnStatus";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.67974F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.32026F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1152, 306);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1164, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ERespondent";
            this.Load += new System.EventHandler(this.ReportPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникКодовОКПООрганизацийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыТопливаИЭнергииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНовыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНаПодобиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакНовуюВерсиюToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKodOkpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameOrganization;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMonthYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}