
namespace Lab_12_app
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadCountriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadCitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCountries = new System.Windows.Forms.TabPage();
            this.statusStripImg = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelImg = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bindingNavigatorCountries = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesDBDataSet = new Lab_12_app.CountriesDBDataSet();
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
            this.создатьToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.печатьToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.копироватьToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.вставкаToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.countryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryPolityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryFlagDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.labelFlag = new System.Windows.Forms.Label();
            this.textBoxCOuntryPolity = new System.Windows.Forms.TextBox();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.labelCountryPolity = new System.Windows.Forms.Label();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.tabPageCities = new System.Windows.Forms.TabPage();
            this.bindingNavigatorCities = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.создатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.печатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.копироватьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.вставкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.cityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityPopulationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countriesTableAdapter = new Lab_12_app.CountriesDBDataSetTableAdapters.CountriesTableAdapter();
            this.citiesTableAdapter = new Lab_12_app.CountriesDBDataSetTableAdapters.CitiesTableAdapter();
            this.errorProviderCities = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCountries = new System.Windows.Forms.ErrorProvider(this.components);
            this.printPreviewDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCountries.SuspendLayout();
            this.statusStripImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCountries)).BeginInit();
            this.bindingNavigatorCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.tabPageCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCities)).BeginInit();
            this.bindingNavigatorCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dBToolStripMenuItem
            // 
            this.dBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadCountriesToolStripMenuItem,
            this.uploadCitiesToolStripMenuItem,
            this.uploadToolStripMenuItem});
            this.dBToolStripMenuItem.Name = "dBToolStripMenuItem";
            this.dBToolStripMenuItem.Size = new System.Drawing.Size(43, 26);
            this.dBToolStripMenuItem.Text = "DB";
            // 
            // uploadCountriesToolStripMenuItem
            // 
            this.uploadCountriesToolStripMenuItem.Name = "uploadCountriesToolStripMenuItem";
            this.uploadCountriesToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.uploadCountriesToolStripMenuItem.Text = "Upload countries from DB";
            this.uploadCountriesToolStripMenuItem.Click += new System.EventHandler(this.uploadCountriesToolStripMenuItem_Click);
            // 
            // uploadCitiesToolStripMenuItem
            // 
            this.uploadCitiesToolStripMenuItem.Name = "uploadCitiesToolStripMenuItem";
            this.uploadCitiesToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.uploadCitiesToolStripMenuItem.Text = "Upload cities from DB";
            this.uploadCitiesToolStripMenuItem.Click += new System.EventHandler(this.uploadCitiesToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.uploadToolStripMenuItem.Text = "Upload ";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCountries);
            this.tabControl1.Controls.Add(this.tabPageCities);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 507);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageCountries
            // 
            this.tabPageCountries.Controls.Add(this.statusStripImg);
            this.tabPageCountries.Controls.Add(this.splitContainer1);
            this.tabPageCountries.Location = new System.Drawing.Point(4, 25);
            this.tabPageCountries.Name = "tabPageCountries";
            this.tabPageCountries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCountries.Size = new System.Drawing.Size(863, 478);
            this.tabPageCountries.TabIndex = 0;
            this.tabPageCountries.Text = "Countries";
            this.tabPageCountries.UseVisualStyleBackColor = true;
            // 
            // statusStripImg
            // 
            this.statusStripImg.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripImg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelImg});
            this.statusStripImg.Location = new System.Drawing.Point(3, 453);
            this.statusStripImg.Name = "statusStripImg";
            this.statusStripImg.Size = new System.Drawing.Size(857, 22);
            this.statusStripImg.TabIndex = 0;
            this.statusStripImg.Text = "statusStripImage";
            // 
            // toolStripStatusLabelImg
            // 
            this.toolStripStatusLabelImg.Name = "toolStripStatusLabelImg";
            this.toolStripStatusLabelImg.Size = new System.Drawing.Size(0, 16);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bindingNavigatorCountries);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewCountries);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxFlag);
            this.splitContainer1.Panel2.Controls.Add(this.labelFlag);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCOuntryPolity);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCountryName);
            this.splitContainer1.Panel2.Controls.Add(this.labelCountryPolity);
            this.splitContainer1.Panel2.Controls.Add(this.labelCountryName);
            this.splitContainer1.Size = new System.Drawing.Size(857, 449);
            this.splitContainer1.SplitterDistance = 464;
            this.splitContainer1.TabIndex = 0;
            // 
            // bindingNavigatorCountries
            // 
            this.bindingNavigatorCountries.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorCountries.BindingSource = this.countriesBindingSource;
            this.bindingNavigatorCountries.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorCountries.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorCountries.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorCountries.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorCountries.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.создатьToolStripButton1,
            this.открытьToolStripButton1,
            this.сохранитьToolStripButton1,
            this.печатьToolStripButton1,
            this.toolStripSeparator2,
            this.вырезатьToolStripButton1,
            this.копироватьToolStripButton1,
            this.вставкаToolStripButton1,
            this.toolStripSeparator3,
            this.справкаToolStripButton1});
            this.bindingNavigatorCountries.Location = new System.Drawing.Point(0, 422);
            this.bindingNavigatorCountries.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorCountries.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorCountries.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorCountries.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorCountries.Name = "bindingNavigatorCountries";
            this.bindingNavigatorCountries.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorCountries.Size = new System.Drawing.Size(464, 27);
            this.bindingNavigatorCountries.TabIndex = 1;
            this.bindingNavigatorCountries.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.countriesDBDataSet;
            // 
            // countriesDBDataSet
            // 
            this.countriesDBDataSet.DataSetName = "CountriesDBDataSet";
            this.countriesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // создатьToolStripButton1
            // 
            this.создатьToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.создатьToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripButton1.Image")));
            this.создатьToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripButton1.Name = "создатьToolStripButton1";
            this.создатьToolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.создатьToolStripButton1.Text = "&Создать";
            // 
            // открытьToolStripButton1
            // 
            this.открытьToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton1.Image")));
            this.открытьToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton1.Name = "открытьToolStripButton1";
            this.открытьToolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.открытьToolStripButton1.Text = "&Открыть";
            // 
            // сохранитьToolStripButton1
            // 
            this.сохранитьToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton1.Image")));
            this.сохранитьToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton1.Name = "сохранитьToolStripButton1";
            this.сохранитьToolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.сохранитьToolStripButton1.Text = "&Сохранить";
            this.сохранитьToolStripButton1.Click += new System.EventHandler(this.сохранитьToolStripButton1_Click);
            // 
            // печатьToolStripButton1
            // 
            this.печатьToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.печатьToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripButton1.Image")));
            this.печатьToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripButton1.Name = "печатьToolStripButton1";
            this.печатьToolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.печатьToolStripButton1.Text = "&Печать";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // вырезатьToolStripButton1
            // 
            this.вырезатьToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вырезатьToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripButton1.Image")));
            this.вырезатьToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripButton1.Name = "вырезатьToolStripButton1";
            this.вырезатьToolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.вырезатьToolStripButton1.Text = "В&ырезать";
            // 
            // копироватьToolStripButton1
            // 
            this.копироватьToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.копироватьToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripButton1.Image")));
            this.копироватьToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripButton1.Name = "копироватьToolStripButton1";
            this.копироватьToolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.копироватьToolStripButton1.Text = "&Копировать";
            // 
            // вставкаToolStripButton1
            // 
            this.вставкаToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вставкаToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripButton1.Image")));
            this.вставкаToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripButton1.Name = "вставкаToolStripButton1";
            this.вставкаToolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.вставкаToolStripButton1.Text = "Вст&авка";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // справкаToolStripButton1
            // 
            this.справкаToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.справкаToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripButton1.Image")));
            this.справкаToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.справкаToolStripButton1.Name = "справкаToolStripButton1";
            this.справкаToolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.справкаToolStripButton1.Text = "Спр&авка";
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.AutoGenerateColumns = false;
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryIdDataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn,
            this.countryPolityDataGridViewTextBoxColumn,
            this.countryFlagDataGridViewImageColumn});
            this.dataGridViewCountries.DataSource = this.countriesBindingSource;
            this.dataGridViewCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCountries.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.RowHeadersWidth = 51;
            this.dataGridViewCountries.RowTemplate.Height = 24;
            this.dataGridViewCountries.Size = new System.Drawing.Size(464, 449);
            this.dataGridViewCountries.TabIndex = 0;
            // 
            // countryIdDataGridViewTextBoxColumn
            // 
            this.countryIdDataGridViewTextBoxColumn.DataPropertyName = "CountryId";
            this.countryIdDataGridViewTextBoxColumn.HeaderText = "CountryId";
            this.countryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryIdDataGridViewTextBoxColumn.Name = "countryIdDataGridViewTextBoxColumn";
            this.countryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryIdDataGridViewTextBoxColumn.Visible = false;
            this.countryIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.countryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            this.countryNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryPolityDataGridViewTextBoxColumn
            // 
            this.countryPolityDataGridViewTextBoxColumn.DataPropertyName = "CountryPolity";
            this.countryPolityDataGridViewTextBoxColumn.HeaderText = "Polity";
            this.countryPolityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryPolityDataGridViewTextBoxColumn.Name = "countryPolityDataGridViewTextBoxColumn";
            this.countryPolityDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryFlagDataGridViewImageColumn
            // 
            this.countryFlagDataGridViewImageColumn.DataPropertyName = "CountryFlag";
            this.countryFlagDataGridViewImageColumn.HeaderText = "Flag";
            this.countryFlagDataGridViewImageColumn.MinimumWidth = 6;
            this.countryFlagDataGridViewImageColumn.Name = "countryFlagDataGridViewImageColumn";
            this.countryFlagDataGridViewImageColumn.Width = 125;
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFlag.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.countriesBindingSource, "CountryFlag", true));
            this.pictureBoxFlag.Location = new System.Drawing.Point(66, 70);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(157, 133);
            this.pictureBoxFlag.TabIndex = 5;
            this.pictureBoxFlag.TabStop = false;
            // 
            // labelFlag
            // 
            this.labelFlag.AutoSize = true;
            this.labelFlag.Location = new System.Drawing.Point(13, 124);
            this.labelFlag.Name = "labelFlag";
            this.labelFlag.Size = new System.Drawing.Size(39, 17);
            this.labelFlag.TabIndex = 4;
            this.labelFlag.Text = "Flag:";
            // 
            // textBoxCOuntryPolity
            // 
            this.textBoxCOuntryPolity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "CountryPolity", true));
            this.textBoxCOuntryPolity.Location = new System.Drawing.Point(66, 42);
            this.textBoxCOuntryPolity.Name = "textBoxCOuntryPolity";
            this.textBoxCOuntryPolity.Size = new System.Drawing.Size(157, 22);
            this.textBoxCOuntryPolity.TabIndex = 3;
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "CountryName", true));
            this.textBoxCountryName.Location = new System.Drawing.Point(66, 14);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(157, 22);
            this.textBoxCountryName.TabIndex = 2;
            // 
            // labelCountryPolity
            // 
            this.labelCountryPolity.AutoSize = true;
            this.labelCountryPolity.Location = new System.Drawing.Point(13, 45);
            this.labelCountryPolity.Name = "labelCountryPolity";
            this.labelCountryPolity.Size = new System.Drawing.Size(46, 17);
            this.labelCountryPolity.TabIndex = 1;
            this.labelCountryPolity.Text = "Polity:";
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Location = new System.Drawing.Point(13, 17);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(49, 17);
            this.labelCountryName.TabIndex = 0;
            this.labelCountryName.Text = "Name:";
            // 
            // tabPageCities
            // 
            this.tabPageCities.Controls.Add(this.bindingNavigatorCities);
            this.tabPageCities.Controls.Add(this.dataGridViewCities);
            this.tabPageCities.Location = new System.Drawing.Point(4, 25);
            this.tabPageCities.Name = "tabPageCities";
            this.tabPageCities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCities.Size = new System.Drawing.Size(863, 480);
            this.tabPageCities.TabIndex = 1;
            this.tabPageCities.Text = "Cities";
            this.tabPageCities.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorCities
            // 
            this.bindingNavigatorCities.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigatorCities.BindingSource = this.citiesBindingSource;
            this.bindingNavigatorCities.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorCities.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigatorCities.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorCities.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorCities.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.создатьToolStripButton,
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.печатьToolStripButton,
            this.toolStripSeparator,
            this.вырезатьToolStripButton,
            this.копироватьToolStripButton,
            this.вставкаToolStripButton,
            this.toolStripSeparator1,
            this.справкаToolStripButton});
            this.bindingNavigatorCities.Location = new System.Drawing.Point(3, 446);
            this.bindingNavigatorCities.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorCities.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorCities.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorCities.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorCities.Name = "bindingNavigatorCities";
            this.bindingNavigatorCities.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorCities.Size = new System.Drawing.Size(857, 31);
            this.bindingNavigatorCities.TabIndex = 1;
            this.bindingNavigatorCities.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.countriesDBDataSet;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // создатьToolStripButton
            // 
            this.создатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.создатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripButton.Image")));
            this.создатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripButton.Name = "создатьToolStripButton";
            this.создатьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.создатьToolStripButton.Text = "&Создать";
            // 
            // открытьToolStripButton
            // 
            this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton.Image")));
            this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton.Name = "открытьToolStripButton";
            this.открытьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.открытьToolStripButton.Text = "&Открыть";
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.сохранитьToolStripButton.Text = "&Сохранить";
            this.сохранитьToolStripButton.Click += new System.EventHandler(this.сохранитьToolStripButton_Click);
            // 
            // печатьToolStripButton
            // 
            this.печатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.печатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripButton.Image")));
            this.печатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripButton.Name = "печатьToolStripButton";
            this.печатьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.печатьToolStripButton.Text = "&Печать";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // вырезатьToolStripButton
            // 
            this.вырезатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вырезатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripButton.Image")));
            this.вырезатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripButton.Name = "вырезатьToolStripButton";
            this.вырезатьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.вырезатьToolStripButton.Text = "В&ырезать";
            // 
            // копироватьToolStripButton
            // 
            this.копироватьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.копироватьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripButton.Image")));
            this.копироватьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripButton.Name = "копироватьToolStripButton";
            this.копироватьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.копироватьToolStripButton.Text = "&Копировать";
            // 
            // вставкаToolStripButton
            // 
            this.вставкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вставкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripButton.Image")));
            this.вставкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripButton.Name = "вставкаToolStripButton";
            this.вставкаToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.вставкаToolStripButton.Text = "Вст&авка";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // справкаToolStripButton
            // 
            this.справкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.справкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripButton.Image")));
            this.справкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.справкаToolStripButton.Name = "справкаToolStripButton";
            this.справкаToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.справкаToolStripButton.Text = "Спр&авка";
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.AutoGenerateColumns = false;
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityIdDataGridViewTextBoxColumn,
            this.countryIdDataGridViewTextBoxColumn1,
            this.cityNameDataGridViewTextBoxColumn,
            this.cityPopulationDataGridViewTextBoxColumn});
            this.dataGridViewCities.DataSource = this.citiesBindingSource;
            this.dataGridViewCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCities.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.RowHeadersWidth = 51;
            this.dataGridViewCities.RowTemplate.Height = 24;
            this.dataGridViewCities.Size = new System.Drawing.Size(857, 474);
            this.dataGridViewCities.TabIndex = 0;
            this.dataGridViewCities.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewCities_DataBindingComplete);
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            this.cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
            this.cityIdDataGridViewTextBoxColumn.HeaderText = "CityId";
            this.cityIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            this.cityIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityIdDataGridViewTextBoxColumn.Visible = false;
            this.cityIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryIdDataGridViewTextBoxColumn1
            // 
            this.countryIdDataGridViewTextBoxColumn1.DataPropertyName = "CountryId";
            this.countryIdDataGridViewTextBoxColumn1.DataSource = this.countriesBindingSource;
            this.countryIdDataGridViewTextBoxColumn1.DisplayMember = "CountryName";
            this.countryIdDataGridViewTextBoxColumn1.HeaderText = "Country";
            this.countryIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.countryIdDataGridViewTextBoxColumn1.Name = "countryIdDataGridViewTextBoxColumn1";
            this.countryIdDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countryIdDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.countryIdDataGridViewTextBoxColumn1.ValueMember = "CountryId";
            this.countryIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.cityNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            this.cityNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityPopulationDataGridViewTextBoxColumn
            // 
            this.cityPopulationDataGridViewTextBoxColumn.DataPropertyName = "CityPopulation";
            this.cityPopulationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.cityPopulationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityPopulationDataGridViewTextBoxColumn.Name = "cityPopulationDataGridViewTextBoxColumn";
            this.cityPopulationDataGridViewTextBoxColumn.Width = 125;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // errorProviderCities
            // 
            this.errorProviderCities.ContainerControl = this;
            this.errorProviderCities.DataSource = this.citiesBindingSource;
            // 
            // errorProviderCountries
            // 
            this.errorProviderCountries.ContainerControl = this;
            this.errorProviderCountries.DataSource = this.countriesBindingSource;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.Document = this.printDocument1;
            this.printPreviewDialog.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCountries.ResumeLayout(false);
            this.tabPageCountries.PerformLayout();
            this.statusStripImg.ResumeLayout(false);
            this.statusStripImg.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCountries)).EndInit();
            this.bindingNavigatorCountries.ResumeLayout(false);
            this.bindingNavigatorCountries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            this.tabPageCities.ResumeLayout(false);
            this.tabPageCities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCities)).EndInit();
            this.bindingNavigatorCities.ResumeLayout(false);
            this.bindingNavigatorCities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadCountriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadCitiesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCountries;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.TabPage tabPageCities;
        private CountriesDBDataSet countriesDBDataSet;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private CountriesDBDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCountries;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn countryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryPolityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn countryFlagDataGridViewImageColumn;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.Label labelFlag;
        private System.Windows.Forms.TextBox textBoxCOuntryPolity;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Label labelCountryPolity;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private CountriesDBDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCities;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn countryIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityPopulationDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton создатьToolStripButton1;
        private System.Windows.Forms.ToolStripButton открытьToolStripButton1;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton1;
        private System.Windows.Forms.ToolStripButton печатьToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton вырезатьToolStripButton1;
        private System.Windows.Forms.ToolStripButton копироватьToolStripButton1;
        private System.Windows.Forms.ToolStripButton вставкаToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton справкаToolStripButton1;
        private System.Windows.Forms.ToolStripButton создатьToolStripButton;
        private System.Windows.Forms.ToolStripButton открытьToolStripButton;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
        private System.Windows.Forms.ToolStripButton печатьToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton вырезатьToolStripButton;
        private System.Windows.Forms.ToolStripButton копироватьToolStripButton;
        private System.Windows.Forms.ToolStripButton вставкаToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton справкаToolStripButton;
        private System.Windows.Forms.ErrorProvider errorProviderCities;
        private System.Windows.Forms.ErrorProvider errorProviderCountries;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripImg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelImg;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

