namespace Tech_service
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.авторизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бланкЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakazBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techDS = new Tech_service.TechDS();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ZakazDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ClientBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CompBttn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PriseListButton = new System.Windows.Forms.Button();
            this.AddNewClientButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CostButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.StatusBttn = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.SearchButtonBool2 = new System.Windows.Forms.Button();
            this.SearchButtonBool1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.DataSearchZakazButton = new System.Windows.Forms.Button();
            this.DTP2 = new System.Windows.Forms.DateTimePicker();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.IDZakazaSearchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rabotaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VidRabBS = new System.Windows.Forms.BindingSource(this.components);
            this.rabotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.VersionLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CommentLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zakazTableAdapter = new Tech_service.TechDSTableAdapters.ZakazTableAdapter();
            this.clientyTableAdapter = new Tech_service.TechDSTableAdapters.ClientyTableAdapter();
            this.rabotaTableAdapter = new Tech_service.TechDSTableAdapters.RabotaTableAdapter();
            this.vid_RabTableAdapter = new Tech_service.TechDSTableAdapters.Vid_RabTableAdapter();
            this.tableAdapterManager = new Tech_service.TechDSTableAdapters.TableAdapterManager();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingNavigator)).BeginInit();
            this.zakazBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZakazDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidRabBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторизацияToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // авторизацияToolStripMenuItem
            // 
            this.авторизацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem,
            this.регистрацияToolStripMenuItem});
            this.авторизацияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("авторизацияToolStripMenuItem.Image")));
            this.авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            this.авторизацияToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.авторизацияToolStripMenuItem.Text = "Авторизация";
            this.авторизацияToolStripMenuItem.Click += new System.EventHandler(this.авторизацияToolStripMenuItem_Click);
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("входToolStripMenuItem.Image")));
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.входToolStripMenuItem.Text = "Вход";
            this.входToolStripMenuItem.Click += new System.EventHandler(this.входToolStripMenuItem_Click);
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("регистрацияToolStripMenuItem.Image")));
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортToolStripMenuItem,
            this.печатьToolStripMenuItem});
            this.инструментыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("инструментыToolStripMenuItem.Image")));
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаExcelToolStripMenuItem});
            this.экспортToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("экспортToolStripMenuItem.Image")));
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            // 
            // таблицаExcelToolStripMenuItem
            // 
            this.таблицаExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("таблицаExcelToolStripMenuItem.Image")));
            this.таблицаExcelToolStripMenuItem.Name = "таблицаExcelToolStripMenuItem";
            this.таблицаExcelToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.таблицаExcelToolStripMenuItem.Text = "Таблица Excel";
            this.таблицаExcelToolStripMenuItem.Click += new System.EventHandler(this.таблицаExcelToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бланкЗаказаToolStripMenuItem,
            this.спискиЗаказовToolStripMenuItem});
            this.печатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripMenuItem.Image")));
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // бланкЗаказаToolStripMenuItem
            // 
            this.бланкЗаказаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("бланкЗаказаToolStripMenuItem.Image")));
            this.бланкЗаказаToolStripMenuItem.Name = "бланкЗаказаToolStripMenuItem";
            this.бланкЗаказаToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.бланкЗаказаToolStripMenuItem.Text = "Бланк заказа";
            // 
            // спискиЗаказовToolStripMenuItem
            // 
            this.спискиЗаказовToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("спискиЗаказовToolStripMenuItem.Image")));
            this.спискиЗаказовToolStripMenuItem.Name = "спискиЗаказовToolStripMenuItem";
            this.спискиЗаказовToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.спискиЗаказовToolStripMenuItem.Text = "Списки заказов";
            this.спискиЗаказовToolStripMenuItem.Click += new System.EventHandler(this.спискиЗаказовToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("помощьToolStripMenuItem.Image")));
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click_1);
            // 
            // zakazBindingNavigator
            // 
            this.zakazBindingNavigator.AddNewItem = null;
            this.zakazBindingNavigator.BindingSource = this.zakazBindingSource;
            this.zakazBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zakazBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zakazBindingNavigator.Enabled = false;
            this.zakazBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.zakazBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.zakazBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zakazBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zakazBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zakazBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zakazBindingNavigator.Name = "zakazBindingNavigator";
            this.zakazBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zakazBindingNavigator.Size = new System.Drawing.Size(743, 25);
            this.zakazBindingNavigator.TabIndex = 1;
            this.zakazBindingNavigator.Text = "bindingNavigator1";
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "Zakaz";
            this.zakazBindingSource.DataSource = this.techDS;
            // 
            // techDS
            // 
            this.techDS.DataSetName = "TechDS";
            this.techDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Обновить данные";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ZakazDGV
            // 
            this.ZakazDGV.AutoGenerateColumns = false;
            this.ZakazDGV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ZakazDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZakazDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.ZakazDGV.DataSource = this.zakazBindingSource;
            this.ZakazDGV.Enabled = false;
            this.ZakazDGV.Location = new System.Drawing.Point(6, 19);
            this.ZakazDGV.Name = "ZakazDGV";
            this.ZakazDGV.Size = new System.Drawing.Size(688, 202);
            this.ZakazDGV.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Zakaza";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn2.DataSource = this.ClientBS;
            this.dataGridViewTextBoxColumn2.DisplayMember = "FIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_Client";
            // 
            // ClientBS
            // 
            this.ClientBS.DataMember = "Clienty";
            this.ClientBS.DataSource = this.techDS;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_Zakaza";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата заказа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.ToolTipText = "DD.MM.YYYY HH.mm.ss";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Itogo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Итоговая сумма";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewCheckBoxColumn1.FalseValue = "False";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Статус";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.TrueValue = "True";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CompBttn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.ZakazDGV);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 571);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказы";
            // 
            // CompBttn
            // 
            this.CompBttn.Enabled = false;
            this.CompBttn.Location = new System.Drawing.Point(554, 517);
            this.CompBttn.Name = "CompBttn";
            this.CompBttn.Size = new System.Drawing.Size(157, 42);
            this.CompBttn.TabIndex = 9;
            this.CompBttn.Text = "Оформить заказ";
            this.CompBttn.UseVisualStyleBackColor = true;
            this.CompBttn.Click += new System.EventHandler(this.CompBttn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PriseListButton);
            this.groupBox2.Controls.Add(this.AddNewClientButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 462);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 103);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Меню:";
            // 
            // PriseListButton
            // 
            this.PriseListButton.Location = new System.Drawing.Point(174, 34);
            this.PriseListButton.Name = "PriseListButton";
            this.PriseListButton.Size = new System.Drawing.Size(144, 39);
            this.PriseListButton.TabIndex = 1;
            this.PriseListButton.Text = "Прейскурант";
            this.PriseListButton.UseVisualStyleBackColor = true;
            this.PriseListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewClientButton
            // 
            this.AddNewClientButton.Location = new System.Drawing.Point(6, 34);
            this.AddNewClientButton.Name = "AddNewClientButton";
            this.AddNewClientButton.Size = new System.Drawing.Size(144, 39);
            this.AddNewClientButton.TabIndex = 0;
            this.AddNewClientButton.Text = "Добавить клиента";
            this.AddNewClientButton.UseVisualStyleBackColor = true;
            this.AddNewClientButton.Click += new System.EventHandler(this.AddNewClientButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.CostButton);
            this.groupBox5.Location = new System.Drawing.Point(342, 462);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 103);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Расчитать итоговую сумму:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 34);
            this.textBox1.TabIndex = 1;
            // 
            // CostButton
            // 
            this.CostButton.Enabled = false;
            this.CostButton.Location = new System.Drawing.Point(6, 59);
            this.CostButton.Name = "CostButton";
            this.CostButton.Size = new System.Drawing.Size(88, 38);
            this.CostButton.TabIndex = 0;
            this.CostButton.Text = "Посчитать";
            this.CostButton.UseVisualStyleBackColor = true;
            this.CostButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox9);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(6, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 220);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск и фильтры";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.StatusBttn);
            this.groupBox9.Location = new System.Drawing.Point(143, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(181, 50);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Пометить заказ как готовый";
            // 
            // StatusBttn
            // 
            this.StatusBttn.Image = ((System.Drawing.Image)(resources.GetObject("StatusBttn.Image")));
            this.StatusBttn.Location = new System.Drawing.Point(45, 21);
            this.StatusBttn.Name = "StatusBttn";
            this.StatusBttn.Size = new System.Drawing.Size(82, 23);
            this.StatusBttn.TabIndex = 5;
            this.StatusBttn.UseVisualStyleBackColor = true;
            this.StatusBttn.Click += new System.EventHandler(this.StatusBttn_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.SearchButtonBool2);
            this.groupBox8.Controls.Add(this.SearchButtonBool1);
            this.groupBox8.Location = new System.Drawing.Point(230, 75);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(94, 115);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Выполненные заказы:";
            // 
            // SearchButtonBool2
            // 
            this.SearchButtonBool2.Location = new System.Drawing.Point(6, 61);
            this.SearchButtonBool2.Name = "SearchButtonBool2";
            this.SearchButtonBool2.Size = new System.Drawing.Size(82, 23);
            this.SearchButtonBool2.TabIndex = 5;
            this.SearchButtonBool2.Text = "Не готово";
            this.SearchButtonBool2.UseVisualStyleBackColor = true;
            this.SearchButtonBool2.Click += new System.EventHandler(this.SearchButtonBool2_Click);
            // 
            // SearchButtonBool1
            // 
            this.SearchButtonBool1.Location = new System.Drawing.Point(6, 32);
            this.SearchButtonBool1.Name = "SearchButtonBool1";
            this.SearchButtonBool1.Size = new System.Drawing.Size(82, 23);
            this.SearchButtonBool1.TabIndex = 4;
            this.SearchButtonBool1.Text = "Готово";
            this.SearchButtonBool1.UseVisualStyleBackColor = true;
            this.SearchButtonBool1.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.DataSearchZakazButton);
            this.groupBox7.Controls.Add(this.DTP2);
            this.groupBox7.Controls.Add(this.DTP1);
            this.groupBox7.Location = new System.Drawing.Point(6, 75);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(219, 115);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Дата заказа:";
            // 
            // DataSearchZakazButton
            // 
            this.DataSearchZakazButton.Image = ((System.Drawing.Image)(resources.GetObject("DataSearchZakazButton.Image")));
            this.DataSearchZakazButton.Location = new System.Drawing.Point(75, 86);
            this.DataSearchZakazButton.Name = "DataSearchZakazButton";
            this.DataSearchZakazButton.Size = new System.Drawing.Size(73, 23);
            this.DataSearchZakazButton.TabIndex = 4;
            this.DataSearchZakazButton.UseVisualStyleBackColor = true;
            this.DataSearchZakazButton.Click += new System.EventHandler(this.DataSearchZakazButton_Click);
            // 
            // DTP2
            // 
            this.DTP2.Location = new System.Drawing.Point(6, 55);
            this.DTP2.Name = "DTP2";
            this.DTP2.Size = new System.Drawing.Size(200, 20);
            this.DTP2.TabIndex = 3;
            // 
            // DTP1
            // 
            this.DTP1.Location = new System.Drawing.Point(6, 19);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(200, 20);
            this.DTP1.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.IDZakazaSearchTextBox);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(130, 50);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "№ Заказа:";
            // 
            // IDZakazaSearchTextBox
            // 
            this.IDZakazaSearchTextBox.Location = new System.Drawing.Point(6, 19);
            this.IDZakazaSearchTextBox.Name = "IDZakazaSearchTextBox";
            this.IDZakazaSearchTextBox.Size = new System.Drawing.Size(118, 20);
            this.IDZakazaSearchTextBox.TabIndex = 0;
            this.IDZakazaSearchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rabotaDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(342, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 220);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Виды работы";
            // 
            // rabotaDataGridView
            // 
            this.rabotaDataGridView.AutoGenerateColumns = false;
            this.rabotaDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rabotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rabotaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.rabotaDataGridView.DataSource = this.rabotaBindingSource;
            this.rabotaDataGridView.Location = new System.Drawing.Point(6, 19);
            this.rabotaDataGridView.Name = "rabotaDataGridView";
            this.rabotaDataGridView.Size = new System.Drawing.Size(340, 182);
            this.rabotaDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_Zakaza";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_Zakaza";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Vid_Raboty";
            this.dataGridViewTextBoxColumn6.DataSource = this.VidRabBS;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Vid_Rabot";
            this.dataGridViewTextBoxColumn6.HeaderText = "Вид Работы";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "Vid_Rabot";
            // 
            // VidRabBS
            // 
            this.VidRabBS.DataMember = "Vid_Rab";
            this.VidRabBS.DataSource = this.techDS;
            // 
            // rabotaBindingSource
            // 
            this.rabotaBindingSource.DataMember = "FK_Rabota_Zakaz";
            this.rabotaBindingSource.DataSource = this.zakazBindingSource;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersionLable,
            this.toolStripStatusLabel1,
            this.CommentLable,
            this.TimeLable});
            this.statusStrip1.Location = new System.Drawing.Point(0, 645);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(743, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // VersionLable
            // 
            this.VersionLable.Name = "VersionLable";
            this.VersionLable.Size = new System.Drawing.Size(46, 17);
            this.VersionLable.Text = "Версия";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = ":";
            // 
            // CommentLable
            // 
            this.CommentLable.Name = "CommentLable";
            this.CommentLable.Size = new System.Drawing.Size(84, 17);
            this.CommentLable.Text = "Пользователь";
            // 
            // TimeLable
            // 
            this.TimeLable.Margin = new System.Windows.Forms.Padding(450, 0, 0, 0);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(12, 22);
            this.TimeLable.Text = "_";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // clientyTableAdapter
            // 
            this.clientyTableAdapter.ClearBeforeFill = true;
            // 
            // rabotaTableAdapter
            // 
            this.rabotaTableAdapter.ClearBeforeFill = true;
            // 
            // vid_RabTableAdapter
            // 
            this.vid_RabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutorizationTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientyTableAdapter = this.clientyTableAdapter;
            this.tableAdapterManager.RabotaTableAdapter = this.rabotaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Tech_service.TechDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vid_RabTableAdapter = this.vid_RabTableAdapter;
            this.tableAdapterManager.ZakazTableAdapter = this.zakazTableAdapter;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "D:\\ProjectFoSell\\Tech-service\\Tech-service\\Properties\\helpForProject.chm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 667);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zakazBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Тех. Сервис";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingNavigator)).EndInit();
            this.zakazBindingNavigator.ResumeLayout(false);
            this.zakazBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZakazDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rabotaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VidRabBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem авторизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бланкЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спискиЗаказовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private TechDS techDS;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private TechDSTableAdapters.ZakazTableAdapter zakazTableAdapter;
        private TechDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zakazBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView ZakazDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddNewClientButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel VersionLable;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TimeLable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource rabotaBindingSource;
        private TechDSTableAdapters.RabotaTableAdapter rabotaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView rabotaDataGridView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource ClientBS;
        private TechDSTableAdapters.ClientyTableAdapter clientyTableAdapter;
        private System.Windows.Forms.Button PriseListButton;
        private System.Windows.Forms.BindingSource VidRabBS;
        private TechDSTableAdapters.Vid_RabTableAdapter vid_RabTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox IDZakazaSearchTextBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button DataSearchZakazButton;
        private System.Windows.Forms.DateTimePicker DTP2;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button SearchButtonBool1;
        private System.Windows.Forms.Button SearchButtonBool2;
        private System.Windows.Forms.Button CostButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CompBttn;
        public System.Windows.Forms.ToolStripStatusLabel CommentLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button StatusBttn;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

