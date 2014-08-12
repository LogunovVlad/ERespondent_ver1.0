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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNewReport = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this._masterAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this._detailsAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.detailBinding = new System.Windows.Forms.BindingSource(this.components);
            this._masterBinding = new System.Windows.Forms.BindingSource(this.components);
            this._dsRV1 = new ERespondent._dsRV();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.panelHistotyLabel = new System.Windows.Forms.Panel();
            this.panelHistoryTable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.versionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReportManager)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._masterBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dsRV1)).BeginInit();
            this.panelHistory.SuspendLayout();
            this.panelHistotyLabel.SuspendLayout();
            this.panelHistoryTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
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
            this.panel1.Size = new System.Drawing.Size(1146, 226);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView_ReportManager
            // 
            this.dataGridView_ReportManager.AllowUserToAddRows = false;
            this.dataGridView_ReportManager.AutoGenerateColumns = false;
            this.dataGridView_ReportManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ReportManager.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dataGridView_ReportManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(202)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ReportManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ReportManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReportManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView_ReportManager.DataSource = this._masterBinding;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ReportManager.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ReportManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ReportManager.EnableHeadersVisualStyles = false;
            this.dataGridView_ReportManager.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ReportManager.Name = "dataGridView_ReportManager";
            this.dataGridView_ReportManager.ReadOnly = true;
            this.dataGridView_ReportManager.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_ReportManager.RowHeadersVisible = false;
            this.dataGridView_ReportManager.RowHeadersWidth = 18;
            this.dataGridView_ReportManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ReportManager.Size = new System.Drawing.Size(1146, 226);
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
            this.tableLayoutPanel1.Controls.Add(this.panelHistory, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76587F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23413F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1152, 457);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // _connectionReport
            // 
            this._connectionReport.ConnectionString = "Data Source=S2\\S2_2K8;Initial Catalog=E_Respondent;Integrated Security=True";
            this._connectionReport.FireInfoMessageEventOnUserErrors = false;
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHistory.Image = global::ERespondent.Properties.Resources.database4_2;
            this.buttonHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHistory.Location = new System.Drawing.Point(358, 30);
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
            new System.Data.SqlClient.SqlParameter("@Edit", System.Data.SqlDbType.DateTime, 0, "Edit")});
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
            new System.Data.SqlClient.SqlParameter("@Original_ReportId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReportId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KodOrganization", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KodOrganization", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KodOrganization", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KodOrganization", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edit", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ReportId", System.Data.SqlDbType.Int, 4, "ReportId")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this._connectionReport;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ReportId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReportId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KodOrganization", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KodOrganization", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KodOrganization", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KodOrganization", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Edit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Edit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Edit", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edit", System.Data.DataRowVersion.Original, null)});
            // 
            // _masterAdapter
            // 
            this._masterAdapter.DeleteCommand = this.sqlDeleteCommand1;
            this._masterAdapter.InsertCommand = this.sqlInsertCommand1;
            this._masterAdapter.SelectCommand = this.sqlSelectCommand1;
            this._masterAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Reports", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ReportId", "ReportId"),
                        new System.Data.Common.DataColumnMapping("KodOrganization", "KodOrganization"),
                        new System.Data.Common.DataColumnMapping("NameOrganization", "NameOrganization"),
                        new System.Data.Common.DataColumnMapping("Year", "Year"),
                        new System.Data.Common.DataColumnMapping("Edit", "Edit")})});
            this._masterAdapter.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        Version.*\r\nFROM            Version";
            this.sqlSelectCommand2.Connection = this._connectionReport;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO [Version] ([ReportId], [DateEdit]) VALUES (@ReportId, @DateEdit);\r\nSE" +
                "LECT VersionId, ReportId, DateEdit FROM Version WHERE (VersionId = SCOPE_IDENTIT" +
                "Y())";
            this.sqlInsertCommand2.Connection = this._connectionReport;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ReportId", System.Data.SqlDbType.Int, 0, "ReportId"),
            new System.Data.SqlClient.SqlParameter("@DateEdit", System.Data.SqlDbType.DateTime, 0, "DateEdit")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this._connectionReport;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ReportId", System.Data.SqlDbType.Int, 0, "ReportId"),
            new System.Data.SqlClient.SqlParameter("@DateEdit", System.Data.SqlDbType.DateTime, 0, "DateEdit"),
            new System.Data.SqlClient.SqlParameter("@Original_VersionId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VersionId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ReportId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ReportId", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ReportId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReportId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DateEdit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateEdit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DateEdit", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateEdit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@VersionId", System.Data.SqlDbType.Int, 4, "VersionId")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this._connectionReport;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_VersionId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VersionId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ReportId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ReportId", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ReportId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ReportId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DateEdit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateEdit", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DateEdit", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateEdit", System.Data.DataRowVersion.Original, null)});
            // 
            // _detailsAdapter
            // 
            this._detailsAdapter.DeleteCommand = this.sqlDeleteCommand2;
            this._detailsAdapter.InsertCommand = this.sqlInsertCommand2;
            this._detailsAdapter.SelectCommand = this.sqlSelectCommand2;
            this._detailsAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Version", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("VersionId", "VersionId"),
                        new System.Data.Common.DataColumnMapping("ReportId", "ReportId"),
                        new System.Data.Common.DataColumnMapping("DateEdit", "DateEdit")})});
            this._detailsAdapter.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // detailBinding
            // 
            this.detailBinding.DataMember = "Reports_Version";
            this.detailBinding.DataSource = this._masterBinding;
            // 
            // _masterBinding
            // 
            this._masterBinding.DataMember = "Reports";
            this._masterBinding.DataSource = this._dsRV1;
            // 
            // _dsRV1
            // 
            this._dsRV1.DataSetName = "_dsRV";
            this._dsRV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ReportId";
            this.dataGridViewTextBoxColumn6.HeaderText = "ReportId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "KodOrganization";
            this.dataGridViewTextBoxColumn7.HeaderText = "Код ОКПО";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NameOrganization";
            this.dataGridViewTextBoxColumn8.HeaderText = "Наименование организации";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn9.HeaderText = "Период";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Edit";
            this.dataGridViewTextBoxColumn10.HeaderText = "Изменен";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // panelHistory
            // 
            this.panelHistory.Controls.Add(this.panelHistoryTable);
            this.panelHistory.Controls.Add(this.panelHistotyLabel);
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistory.Location = new System.Drawing.Point(3, 235);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(1146, 219);
            this.panelHistory.TabIndex = 3;
            // 
            // panelHistotyLabel
            // 
            this.panelHistotyLabel.Controls.Add(this.label1);
            this.panelHistotyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHistotyLabel.Location = new System.Drawing.Point(0, 0);
            this.panelHistotyLabel.Name = "panelHistotyLabel";
            this.panelHistotyLabel.Size = new System.Drawing.Size(1146, 24);
            this.panelHistotyLabel.TabIndex = 5;
            // 
            // panelHistoryTable
            // 
            this.panelHistoryTable.Controls.Add(this.dataGridView1);
            this.panelHistoryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistoryTable.Location = new System.Drawing.Point(0, 24);
            this.panelHistoryTable.Name = "panelHistoryTable";
            this.panelHistoryTable.Size = new System.Drawing.Size(1146, 195);
            this.panelHistoryTable.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(202)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.versionIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dateEditDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detailBinding;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 18;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 195);
            this.dataGridView1.TabIndex = 5;
            // 
            // versionIdDataGridViewTextBoxColumn
            // 
            this.versionIdDataGridViewTextBoxColumn.DataPropertyName = "VersionId";
            this.versionIdDataGridViewTextBoxColumn.HeaderText = "VersionId";
            this.versionIdDataGridViewTextBoxColumn.Name = "versionIdDataGridViewTextBoxColumn";
            this.versionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.versionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReportId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ReportId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dateEditDataGridViewTextBoxColumn
            // 
            this.dateEditDataGridViewTextBoxColumn.DataPropertyName = "DateEdit";
            this.dateEditDataGridViewTextBoxColumn.HeaderText = "Изменен от";
            this.dateEditDataGridViewTextBoxColumn.Name = "dateEditDataGridViewTextBoxColumn";
            this.dateEditDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "История версий отчета";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1164, 600);
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
            ((System.ComponentModel.ISupportInitialize)(this.detailBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._masterBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dsRV1)).EndInit();
            this.panelHistory.ResumeLayout(false);
            this.panelHistotyLabel.ResumeLayout(false);
            this.panelHistotyLabel.PerformLayout();
            this.panelHistoryTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button buttonNewReport;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodOrganizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOrganizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter _masterAdapter;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter _detailsAdapter;
        private System.Windows.Forms.BindingSource _masterBinding;
        private System.Windows.Forms.BindingSource detailBinding;
        private _dsRV _dsRV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.Panel panelHistoryTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelHistotyLabel;
        private System.Windows.Forms.Label label1;

    }
}