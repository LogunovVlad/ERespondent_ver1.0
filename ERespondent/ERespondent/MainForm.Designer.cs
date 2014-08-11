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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНаПодобиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакНовуюВерсиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникКодовОКПООрганизацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переченьОсновныхНаправленийЭнергосбереженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыТопливаИЭнергииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_ReportManager = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._connectionReport = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this._daReport = new System.Data.SqlClient.SqlDataAdapter();
            this._dsReport = new ERespondent._dsReport();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodOrganizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOrganizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNewReport = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReportManager)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dsReport)).BeginInit();
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
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйToolStripMenuItem,
            this.создатьНаПодобиеToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
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
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
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
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_ReportManager);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 247);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView_ReportManager
            // 
            this.dataGridView_ReportManager.AutoGenerateColumns = false;
            this.dataGridView_ReportManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ReportManager.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dataGridView_ReportManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(202)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ReportManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_ReportManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReportManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodDataGridViewTextBoxColumn,
            this.kodOrganizationDataGridViewTextBoxColumn,
            this.nameOrganizationDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.editDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn});
            this.dataGridView_ReportManager.DataMember = "Reports";
            this.dataGridView_ReportManager.DataSource = this._dsReport;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ReportManager.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_ReportManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ReportManager.EnableHeadersVisualStyles = false;
            this.dataGridView_ReportManager.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ReportManager.Name = "dataGridView_ReportManager";
            this.dataGridView_ReportManager.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_ReportManager.RowHeadersVisible = false;
            this.dataGridView_ReportManager.RowHeadersWidth = 18;
            this.dataGridView_ReportManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ReportManager.Size = new System.Drawing.Size(1146, 247);
            this.dataGridView_ReportManager.TabIndex = 0;
            this.dataGridView_ReportManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // _connectionReport
            // 
            this._connectionReport.ConnectionString = "Data Source=S2\\S2_2K8;Initial Catalog=E_Respondent;Integrated Security=True";
            this._connectionReport.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Reports.*\r\nFROM            Reports";
            this.sqlSelectCommand1.Connection = this._connectionReport;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this._connectionReport;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@KodOrganization", System.Data.SqlDbType.BigInt, 0, "KodOrganization"),
            new System.Data.SqlClient.SqlParameter("@NameOrganization", System.Data.SqlDbType.Text, 0, "NameOrganization"),
            new System.Data.SqlClient.SqlParameter("@Year", System.Data.SqlDbType.Text, 0, "Year"),
            new System.Data.SqlClient.SqlParameter("@Edit", System.Data.SqlDbType.DateTime, 0, "Edit"),
            new System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.Text, 0, "Version")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this._connectionReport;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@KodOrganization", System.Data.SqlDbType.BigInt, 0, "KodOrganization"),
            new System.Data.SqlClient.SqlParameter("@NameOrganization", System.Data.SqlDbType.Text, 0, "NameOrganization"),
            new System.Data.SqlClient.SqlParameter("@Year", System.Data.SqlDbType.Text, 0, "Year"),
            new System.Data.SqlClient.SqlParameter("@Edit", System.Data.SqlDbType.DateTime, 0, "Edit"),
            new System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.Text, 0, "Version"),
            new System.Data.SqlClient.SqlParameter("@Original_Kod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Kod", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KodOrganization", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KodOrganization", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KodOrganization", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KodOrganization", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edit", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Kod", System.Data.SqlDbType.Int, 4, "Kod")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this._connectionReport;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Kod", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Kod", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KodOrganization", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KodOrganization", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KodOrganization", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KodOrganization", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edit", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edit", System.Data.DataRowVersion.Original, null)});
            // 
            // _daReport
            // 
            this._daReport.DeleteCommand = this.sqlDeleteCommand1;
            this._daReport.InsertCommand = this.sqlInsertCommand1;
            this._daReport.SelectCommand = this.sqlSelectCommand1;
            this._daReport.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Reports", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Kod", "Kod"),
                        new System.Data.Common.DataColumnMapping("KodOrganization", "KodOrganization"),
                        new System.Data.Common.DataColumnMapping("NameOrganization", "NameOrganization"),
                        new System.Data.Common.DataColumnMapping("Year", "Year"),
                        new System.Data.Common.DataColumnMapping("Edit", "Edit"),
                        new System.Data.Common.DataColumnMapping("Version", "Version")})});
            this._daReport.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // _dsReport
            // 
            this._dsReport.DataSetName = "_dsReport";
            this._dsReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodDataGridViewTextBoxColumn.Visible = false;
            // 
            // kodOrganizationDataGridViewTextBoxColumn
            // 
            this.kodOrganizationDataGridViewTextBoxColumn.DataPropertyName = "KodOrganization";
            this.kodOrganizationDataGridViewTextBoxColumn.HeaderText = "Код ОКПО";
            this.kodOrganizationDataGridViewTextBoxColumn.Name = "kodOrganizationDataGridViewTextBoxColumn";
            // 
            // nameOrganizationDataGridViewTextBoxColumn
            // 
            this.nameOrganizationDataGridViewTextBoxColumn.DataPropertyName = "NameOrganization";
            this.nameOrganizationDataGridViewTextBoxColumn.HeaderText = "Наименование организации";
            this.nameOrganizationDataGridViewTextBoxColumn.Name = "nameOrganizationDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Период";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // editDataGridViewTextBoxColumn
            // 
            this.editDataGridViewTextBoxColumn.DataPropertyName = "Edit";
            this.editDataGridViewTextBoxColumn.HeaderText = "Изменен";
            this.editDataGridViewTextBoxColumn.Name = "editDataGridViewTextBoxColumn";
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Версия";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.Visible = false;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHistory.Image = global::ERespondent.Properties.Resources.database4_2;
            this.buttonHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHistory.Location = new System.Drawing.Point(359, 30);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(80, 70);
            this.buttonHistory.TabIndex = 8;
            this.buttonHistory.Text = "История";
            this.buttonHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHistory.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.Image = global::ERespondent.Properties.Resources.dbmin2;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete.Location = new System.Drawing.Point(273, 30);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 70);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            this.buttonView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonView.Image = global::ERespondent.Properties.Resources.blueprint;
            this.buttonView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonView.Location = new System.Drawing.Point(187, 30);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(80, 70);
            this.buttonView.TabIndex = 6;
            this.buttonView.Text = "Просмотр";
            this.buttonView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEdit.Image = global::ERespondent.Properties.Resources.pencil;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit.Location = new System.Drawing.Point(101, 30);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 70);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonNewReport
            // 
            this.buttonNewReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNewReport.Image = global::ERespondent.Properties.Resources.dbplus2;
            this.buttonNewReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNewReport.Location = new System.Drawing.Point(15, 30);
            this.buttonNewReport.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonNewReport.Name = "buttonNewReport";
            this.buttonNewReport.Size = new System.Drawing.Size(80, 70);
            this.buttonNewReport.TabIndex = 4;
            this.buttonNewReport.Text = "Создать";
            this.buttonNewReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNewReport.UseVisualStyleBackColor = true;
            this.buttonNewReport.Click += new System.EventHandler(this.создатьНовыйToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1164, 548);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNewReport);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReportManager)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dsReport)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView_ReportManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Data.SqlClient.SqlConnection _connectionReport;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter _daReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodOrganizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOrganizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private _dsReport _dsReport;
        private System.Windows.Forms.Button buttonNewReport;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonHistory;

    }
}