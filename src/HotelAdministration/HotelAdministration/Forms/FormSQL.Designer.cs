namespace HotelAdministration.Forms
{
    partial class FormSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSQL));
            this.sqlTabControl = new System.Windows.Forms.TabControl();
            this.primerTabPage = new System.Windows.Forms.TabPage();
            this.selectDataGridView = new System.Windows.Forms.DataGridView();
            this.selectGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeRadioButton = new System.Windows.Forms.RadioButton();
            this.scheduleRadioButton = new System.Windows.Forms.RadioButton();
            this.reportRadioButton = new System.Windows.Forms.RadioButton();
            this.clientRadioButton = new System.Windows.Forms.RadioButton();
            this.hotelRoomRadioButton = new System.Windows.Forms.RadioButton();
            this.selectTabPage = new System.Windows.Forms.TabPage();
            this.fSelectDataGridView = new System.Windows.Forms.DataGridView();
            this.fSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.fSelectButton = new System.Windows.Forms.Button();
            this.detGroupBox = new System.Windows.Forms.GroupBox();
            this.noChoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.addCityRadioButton = new System.Windows.Forms.RadioButton();
            this.addCostRadioButton = new System.Windows.Forms.RadioButton();
            this.ascArrivalDateCheckBox = new System.Windows.Forms.CheckBox();
            this.moreArrivalDateTextBox = new System.Windows.Forms.TextBox();
            this.arrivalDateCheckBox = new System.Windows.Forms.CheckBox();
            this.clientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.clientSurnameLabel = new System.Windows.Forms.Label();
            this.subqueryTabPage = new System.Windows.Forms.TabPage();
            this.subqueryDataGridView = new System.Windows.Forms.DataGridView();
            this.subqueryGroupBox = new System.Windows.Forms.GroupBox();
            this.subqueryButton = new System.Windows.Forms.Button();
            this.countOfPlacesTextBox = new System.Windows.Forms.TextBox();
            this.countOfPlacesLabel = new System.Windows.Forms.Label();
            this.noCorrelatedRadioButton = new System.Windows.Forms.RadioButton();
            this.correlatedRadioButton = new System.Windows.Forms.RadioButton();
            this.dmlTabPage = new System.Windows.Forms.TabPage();
            this.dmlGroupBox = new System.Windows.Forms.GroupBox();
            this.insertRadioButton = new System.Windows.Forms.RadioButton();
            this.updateRadioButton = new System.Windows.Forms.RadioButton();
            this.deleteRadioButton = new System.Windows.Forms.RadioButton();
            this.passportDataLabel = new System.Windows.Forms.Label();
            this.passportDataTextBox = new System.Windows.Forms.TextBox();
            this.clientPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.hotelRoomLabel = new System.Windows.Forms.Label();
            this.arrivalDateLabel = new System.Windows.Forms.Label();
            this.cityFromWhichCameLabel = new System.Windows.Forms.Label();
            this.departureDate = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.hotelRoomTextBox = new System.Windows.Forms.TextBox();
            this.cityFromWhichCameTextBox = new System.Windows.Forms.TextBox();
            this.arrivalDateTextBox = new System.Windows.Forms.TextBox();
            this.departureDateTextBox = new System.Windows.Forms.TextBox();
            this.executeDMLButton = new System.Windows.Forms.Button();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.selectClientButton = new System.Windows.Forms.Button();
            this.sqlTabControl.SuspendLayout();
            this.primerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectDataGridView)).BeginInit();
            this.selectGroupBox.SuspendLayout();
            this.selectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fSelectDataGridView)).BeginInit();
            this.fSelectGroupBox.SuspendLayout();
            this.detGroupBox.SuspendLayout();
            this.subqueryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subqueryDataGridView)).BeginInit();
            this.subqueryGroupBox.SuspendLayout();
            this.dmlTabPage.SuspendLayout();
            this.dmlGroupBox.SuspendLayout();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlTabControl
            // 
            this.sqlTabControl.Controls.Add(this.primerTabPage);
            this.sqlTabControl.Controls.Add(this.selectTabPage);
            this.sqlTabControl.Controls.Add(this.subqueryTabPage);
            this.sqlTabControl.Controls.Add(this.dmlTabPage);
            this.sqlTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlTabControl.Location = new System.Drawing.Point(0, 0);
            this.sqlTabControl.Name = "sqlTabControl";
            this.sqlTabControl.SelectedIndex = 0;
            this.sqlTabControl.Size = new System.Drawing.Size(757, 408);
            this.sqlTabControl.TabIndex = 0;
            // 
            // primerTabPage
            // 
            this.primerTabPage.Controls.Add(this.selectDataGridView);
            this.primerTabPage.Controls.Add(this.selectGroupBox);
            this.primerTabPage.Location = new System.Drawing.Point(4, 22);
            this.primerTabPage.Name = "primerTabPage";
            this.primerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.primerTabPage.Size = new System.Drawing.Size(749, 382);
            this.primerTabPage.TabIndex = 0;
            this.primerTabPage.Text = "Примеры запросов";
            this.primerTabPage.UseVisualStyleBackColor = true;
            // 
            // selectDataGridView
            // 
            this.selectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectDataGridView.Location = new System.Drawing.Point(3, 65);
            this.selectDataGridView.Name = "selectDataGridView";
            this.selectDataGridView.Size = new System.Drawing.Size(743, 314);
            this.selectDataGridView.TabIndex = 1;
            // 
            // selectGroupBox
            // 
            this.selectGroupBox.Controls.Add(this.employeeRadioButton);
            this.selectGroupBox.Controls.Add(this.scheduleRadioButton);
            this.selectGroupBox.Controls.Add(this.reportRadioButton);
            this.selectGroupBox.Controls.Add(this.clientRadioButton);
            this.selectGroupBox.Controls.Add(this.hotelRoomRadioButton);
            this.selectGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectGroupBox.Location = new System.Drawing.Point(3, 3);
            this.selectGroupBox.Name = "selectGroupBox";
            this.selectGroupBox.Size = new System.Drawing.Size(743, 62);
            this.selectGroupBox.TabIndex = 0;
            this.selectGroupBox.TabStop = false;
            this.selectGroupBox.Text = "Запросы по данным";
            // 
            // employeeRadioButton
            // 
            this.employeeRadioButton.AutoSize = true;
            this.employeeRadioButton.Location = new System.Drawing.Point(307, 19);
            this.employeeRadioButton.Name = "employeeRadioButton";
            this.employeeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.employeeRadioButton.TabIndex = 4;
            this.employeeRadioButton.TabStop = true;
            this.employeeRadioButton.Text = "Служащие";
            this.employeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // scheduleRadioButton
            // 
            this.scheduleRadioButton.AutoSize = true;
            this.scheduleRadioButton.Location = new System.Drawing.Point(457, 20);
            this.scheduleRadioButton.Name = "scheduleRadioButton";
            this.scheduleRadioButton.Size = new System.Drawing.Size(86, 17);
            this.scheduleRadioButton.TabIndex = 3;
            this.scheduleRadioButton.TabStop = true;
            this.scheduleRadioButton.Text = "Расписания";
            this.scheduleRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportRadioButton
            // 
            this.reportRadioButton.AutoSize = true;
            this.reportRadioButton.Location = new System.Drawing.Point(607, 19);
            this.reportRadioButton.Name = "reportRadioButton";
            this.reportRadioButton.Size = new System.Drawing.Size(62, 17);
            this.reportRadioButton.TabIndex = 2;
            this.reportRadioButton.TabStop = true;
            this.reportRadioButton.Text = "Отчеты";
            this.reportRadioButton.UseVisualStyleBackColor = true;
            // 
            // clientRadioButton
            // 
            this.clientRadioButton.AutoSize = true;
            this.clientRadioButton.Location = new System.Drawing.Point(157, 19);
            this.clientRadioButton.Name = "clientRadioButton";
            this.clientRadioButton.Size = new System.Drawing.Size(69, 17);
            this.clientRadioButton.TabIndex = 1;
            this.clientRadioButton.TabStop = true;
            this.clientRadioButton.Text = "Клиенты";
            this.clientRadioButton.UseVisualStyleBackColor = true;
            // 
            // hotelRoomRadioButton
            // 
            this.hotelRoomRadioButton.AutoSize = true;
            this.hotelRoomRadioButton.Location = new System.Drawing.Point(7, 20);
            this.hotelRoomRadioButton.Name = "hotelRoomRadioButton";
            this.hotelRoomRadioButton.Size = new System.Drawing.Size(132, 17);
            this.hotelRoomRadioButton.TabIndex = 0;
            this.hotelRoomRadioButton.TabStop = true;
            this.hotelRoomRadioButton.Text = "Гостиничные номера";
            this.hotelRoomRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectTabPage
            // 
            this.selectTabPage.Controls.Add(this.fSelectDataGridView);
            this.selectTabPage.Controls.Add(this.fSelectGroupBox);
            this.selectTabPage.Location = new System.Drawing.Point(4, 22);
            this.selectTabPage.Name = "selectTabPage";
            this.selectTabPage.Size = new System.Drawing.Size(749, 382);
            this.selectTabPage.TabIndex = 1;
            this.selectTabPage.Text = "Полная запись SELECT";
            this.selectTabPage.UseVisualStyleBackColor = true;
            // 
            // fSelectDataGridView
            // 
            this.fSelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fSelectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fSelectDataGridView.Location = new System.Drawing.Point(0, 174);
            this.fSelectDataGridView.Name = "fSelectDataGridView";
            this.fSelectDataGridView.Size = new System.Drawing.Size(749, 208);
            this.fSelectDataGridView.TabIndex = 1;
            // 
            // fSelectGroupBox
            // 
            this.fSelectGroupBox.Controls.Add(this.fSelectButton);
            this.fSelectGroupBox.Controls.Add(this.detGroupBox);
            this.fSelectGroupBox.Controls.Add(this.ascArrivalDateCheckBox);
            this.fSelectGroupBox.Controls.Add(this.moreArrivalDateTextBox);
            this.fSelectGroupBox.Controls.Add(this.arrivalDateCheckBox);
            this.fSelectGroupBox.Controls.Add(this.clientSurnameTextBox);
            this.fSelectGroupBox.Controls.Add(this.clientSurnameLabel);
            this.fSelectGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.fSelectGroupBox.Location = new System.Drawing.Point(0, 0);
            this.fSelectGroupBox.Name = "fSelectGroupBox";
            this.fSelectGroupBox.Size = new System.Drawing.Size(749, 174);
            this.fSelectGroupBox.TabIndex = 0;
            this.fSelectGroupBox.TabStop = false;
            this.fSelectGroupBox.Text = "Гостиничные номера клиентов";
            // 
            // fSelectButton
            // 
            this.fSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fSelectButton.Image = ((System.Drawing.Image)(resources.GetObject("fSelectButton.Image")));
            this.fSelectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fSelectButton.Location = new System.Drawing.Point(341, 145);
            this.fSelectButton.Name = "fSelectButton";
            this.fSelectButton.Size = new System.Drawing.Size(75, 23);
            this.fSelectButton.TabIndex = 6;
            this.fSelectButton.Text = "Клиент";
            this.fSelectButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fSelectButton.UseVisualStyleBackColor = true;
            // 
            // detGroupBox
            // 
            this.detGroupBox.Controls.Add(this.noChoiceRadioButton);
            this.detGroupBox.Controls.Add(this.addCityRadioButton);
            this.detGroupBox.Controls.Add(this.addCostRadioButton);
            this.detGroupBox.Location = new System.Drawing.Point(454, 29);
            this.detGroupBox.Name = "detGroupBox";
            this.detGroupBox.Size = new System.Drawing.Size(263, 100);
            this.detGroupBox.TabIndex = 5;
            this.detGroupBox.TabStop = false;
            this.detGroupBox.Text = "Детализация клиентов";
            // 
            // noChoiceRadioButton
            // 
            this.noChoiceRadioButton.AutoSize = true;
            this.noChoiceRadioButton.Location = new System.Drawing.Point(7, 68);
            this.noChoiceRadioButton.Name = "noChoiceRadioButton";
            this.noChoiceRadioButton.Size = new System.Drawing.Size(91, 17);
            this.noChoiceRadioButton.TabIndex = 2;
            this.noChoiceRadioButton.TabStop = true;
            this.noChoiceRadioButton.Text = "Не выбирать";
            this.noChoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // addCityRadioButton
            // 
            this.addCityRadioButton.AutoSize = true;
            this.addCityRadioButton.Location = new System.Drawing.Point(7, 44);
            this.addCityRadioButton.Name = "addCityRadioButton";
            this.addCityRadioButton.Size = new System.Drawing.Size(218, 17);
            this.addCityRadioButton.TabIndex = 1;
            this.addCityRadioButton.TabStop = true;
            this.addCityRadioButton.Text = "Добавить город, из которого приехал";
            this.addCityRadioButton.UseVisualStyleBackColor = true;
            // 
            // addCostRadioButton
            // 
            this.addCostRadioButton.AutoSize = true;
            this.addCostRadioButton.Location = new System.Drawing.Point(7, 20);
            this.addCostRadioButton.Name = "addCostRadioButton";
            this.addCostRadioButton.Size = new System.Drawing.Size(247, 17);
            this.addCostRadioButton.TabIndex = 0;
            this.addCostRadioButton.TabStop = true;
            this.addCostRadioButton.Text = "Добавить стоимость проживания в номере";
            this.addCostRadioButton.UseVisualStyleBackColor = true;
            // 
            // ascArrivalDateCheckBox
            // 
            this.ascArrivalDateCheckBox.AutoSize = true;
            this.ascArrivalDateCheckBox.Location = new System.Drawing.Point(12, 115);
            this.ascArrivalDateCheckBox.Name = "ascArrivalDateCheckBox";
            this.ascArrivalDateCheckBox.Size = new System.Drawing.Size(294, 17);
            this.ascArrivalDateCheckBox.TabIndex = 4;
            this.ascArrivalDateCheckBox.Text = "Включить сортировку по возрастанию даты приезда";
            this.ascArrivalDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // moreArrivalDateTextBox
            // 
            this.moreArrivalDateTextBox.Location = new System.Drawing.Point(193, 69);
            this.moreArrivalDateTextBox.Name = "moreArrivalDateTextBox";
            this.moreArrivalDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.moreArrivalDateTextBox.TabIndex = 3;
            // 
            // arrivalDateCheckBox
            // 
            this.arrivalDateCheckBox.AutoSize = true;
            this.arrivalDateCheckBox.Location = new System.Drawing.Point(12, 69);
            this.arrivalDateCheckBox.Name = "arrivalDateCheckBox";
            this.arrivalDateCheckBox.Size = new System.Drawing.Size(174, 17);
            this.arrivalDateCheckBox.TabIndex = 2;
            this.arrivalDateCheckBox.Text = "Выбрать дата приезда более";
            this.arrivalDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // clientSurnameTextBox
            // 
            this.clientSurnameTextBox.Location = new System.Drawing.Point(193, 26);
            this.clientSurnameTextBox.Name = "clientSurnameTextBox";
            this.clientSurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientSurnameTextBox.TabIndex = 1;
            // 
            // clientSurnameLabel
            // 
            this.clientSurnameLabel.AutoSize = true;
            this.clientSurnameLabel.Location = new System.Drawing.Point(26, 29);
            this.clientSurnameLabel.Name = "clientSurnameLabel";
            this.clientSurnameLabel.Size = new System.Drawing.Size(100, 13);
            this.clientSurnameLabel.TabIndex = 0;
            this.clientSurnameLabel.Text = "Фамилия клиента";
            // 
            // subqueryTabPage
            // 
            this.subqueryTabPage.Controls.Add(this.subqueryDataGridView);
            this.subqueryTabPage.Controls.Add(this.subqueryGroupBox);
            this.subqueryTabPage.Location = new System.Drawing.Point(4, 22);
            this.subqueryTabPage.Name = "subqueryTabPage";
            this.subqueryTabPage.Size = new System.Drawing.Size(749, 382);
            this.subqueryTabPage.TabIndex = 2;
            this.subqueryTabPage.Text = "Примеры подзопросов";
            this.subqueryTabPage.UseVisualStyleBackColor = true;
            // 
            // subqueryDataGridView
            // 
            this.subqueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subqueryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subqueryDataGridView.Location = new System.Drawing.Point(0, 193);
            this.subqueryDataGridView.Name = "subqueryDataGridView";
            this.subqueryDataGridView.Size = new System.Drawing.Size(749, 189);
            this.subqueryDataGridView.TabIndex = 1;
            // 
            // subqueryGroupBox
            // 
            this.subqueryGroupBox.Controls.Add(this.subqueryButton);
            this.subqueryGroupBox.Controls.Add(this.countOfPlacesTextBox);
            this.subqueryGroupBox.Controls.Add(this.countOfPlacesLabel);
            this.subqueryGroupBox.Controls.Add(this.noCorrelatedRadioButton);
            this.subqueryGroupBox.Controls.Add(this.correlatedRadioButton);
            this.subqueryGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.subqueryGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subqueryGroupBox.Location = new System.Drawing.Point(0, 0);
            this.subqueryGroupBox.Name = "subqueryGroupBox";
            this.subqueryGroupBox.Size = new System.Drawing.Size(749, 193);
            this.subqueryGroupBox.TabIndex = 0;
            this.subqueryGroupBox.TabStop = false;
            this.subqueryGroupBox.Text = "Подзапросы по данным";
            // 
            // subqueryButton
            // 
            this.subqueryButton.Location = new System.Drawing.Point(177, 153);
            this.subqueryButton.Name = "subqueryButton";
            this.subqueryButton.Size = new System.Drawing.Size(154, 23);
            this.subqueryButton.TabIndex = 4;
            this.subqueryButton.Text = "Выполнить подзапрос";
            this.subqueryButton.UseVisualStyleBackColor = true;
            // 
            // countOfPlacesTextBox
            // 
            this.countOfPlacesTextBox.Location = new System.Drawing.Point(193, 101);
            this.countOfPlacesTextBox.Name = "countOfPlacesTextBox";
            this.countOfPlacesTextBox.Size = new System.Drawing.Size(100, 20);
            this.countOfPlacesTextBox.TabIndex = 3;
            // 
            // countOfPlacesLabel
            // 
            this.countOfPlacesLabel.AutoSize = true;
            this.countOfPlacesLabel.Location = new System.Drawing.Point(24, 104);
            this.countOfPlacesLabel.Name = "countOfPlacesLabel";
            this.countOfPlacesLabel.Size = new System.Drawing.Size(149, 13);
            this.countOfPlacesLabel.TabIndex = 2;
            this.countOfPlacesLabel.Text = "Количество мест в номерах";
            // 
            // noCorrelatedRadioButton
            // 
            this.noCorrelatedRadioButton.AutoSize = true;
            this.noCorrelatedRadioButton.Location = new System.Drawing.Point(246, 43);
            this.noCorrelatedRadioButton.Name = "noCorrelatedRadioButton";
            this.noCorrelatedRadioButton.Size = new System.Drawing.Size(131, 17);
            this.noCorrelatedRadioButton.TabIndex = 1;
            this.noCorrelatedRadioButton.TabStop = true;
            this.noCorrelatedRadioButton.Text = "Некоррелированный";
            this.noCorrelatedRadioButton.UseVisualStyleBackColor = true;
            // 
            // correlatedRadioButton
            // 
            this.correlatedRadioButton.AutoSize = true;
            this.correlatedRadioButton.Location = new System.Drawing.Point(27, 43);
            this.correlatedRadioButton.Name = "correlatedRadioButton";
            this.correlatedRadioButton.Size = new System.Drawing.Size(118, 17);
            this.correlatedRadioButton.TabIndex = 0;
            this.correlatedRadioButton.TabStop = true;
            this.correlatedRadioButton.Text = "Коррелированный";
            this.correlatedRadioButton.UseVisualStyleBackColor = true;
            // 
            // dmlTabPage
            // 
            this.dmlTabPage.Controls.Add(this.clientDataGridView);
            this.dmlTabPage.Controls.Add(this.clientPanel);
            this.dmlTabPage.Controls.Add(this.dmlGroupBox);
            this.dmlTabPage.Location = new System.Drawing.Point(4, 22);
            this.dmlTabPage.Name = "dmlTabPage";
            this.dmlTabPage.Size = new System.Drawing.Size(749, 382);
            this.dmlTabPage.TabIndex = 3;
            this.dmlTabPage.Text = "Запросы изменения данных";
            this.dmlTabPage.UseVisualStyleBackColor = true;
            // 
            // dmlGroupBox
            // 
            this.dmlGroupBox.Controls.Add(this.executeDMLButton);
            this.dmlGroupBox.Controls.Add(this.passportDataTextBox);
            this.dmlGroupBox.Controls.Add(this.passportDataLabel);
            this.dmlGroupBox.Controls.Add(this.deleteRadioButton);
            this.dmlGroupBox.Controls.Add(this.updateRadioButton);
            this.dmlGroupBox.Controls.Add(this.insertRadioButton);
            this.dmlGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dmlGroupBox.Location = new System.Drawing.Point(0, 0);
            this.dmlGroupBox.Name = "dmlGroupBox";
            this.dmlGroupBox.Size = new System.Drawing.Size(749, 100);
            this.dmlGroupBox.TabIndex = 0;
            this.dmlGroupBox.TabStop = false;
            this.dmlGroupBox.Text = "Операторы";
            // 
            // insertRadioButton
            // 
            this.insertRadioButton.AutoSize = true;
            this.insertRadioButton.Location = new System.Drawing.Point(9, 20);
            this.insertRadioButton.Name = "insertRadioButton";
            this.insertRadioButton.Size = new System.Drawing.Size(119, 17);
            this.insertRadioButton.TabIndex = 0;
            this.insertRadioButton.TabStop = true;
            this.insertRadioButton.Text = "Дабавить клиента";
            this.insertRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(290, 19);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(120, 17);
            this.updateRadioButton.TabIndex = 1;
            this.updateRadioButton.TabStop = true;
            this.updateRadioButton.Text = "Изменить клиента";
            this.updateRadioButton.UseVisualStyleBackColor = true;
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.AutoSize = true;
            this.deleteRadioButton.Location = new System.Drawing.Point(551, 20);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(112, 17);
            this.deleteRadioButton.TabIndex = 2;
            this.deleteRadioButton.TabStop = true;
            this.deleteRadioButton.Text = "Удалить клиента";
            this.deleteRadioButton.UseVisualStyleBackColor = true;
            // 
            // passportDataLabel
            // 
            this.passportDataLabel.AutoSize = true;
            this.passportDataLabel.Location = new System.Drawing.Point(7, 57);
            this.passportDataLabel.Name = "passportDataLabel";
            this.passportDataLabel.Size = new System.Drawing.Size(155, 13);
            this.passportDataLabel.TabIndex = 3;
            this.passportDataLabel.Text = "Паспортные данные клиента";
            // 
            // passportDataTextBox
            // 
            this.passportDataTextBox.Location = new System.Drawing.Point(168, 54);
            this.passportDataTextBox.Name = "passportDataTextBox";
            this.passportDataTextBox.Size = new System.Drawing.Size(100, 20);
            this.passportDataTextBox.TabIndex = 4;
            // 
            // clientPanel
            // 
            this.clientPanel.Controls.Add(this.selectClientButton);
            this.clientPanel.Controls.Add(this.departureDateTextBox);
            this.clientPanel.Controls.Add(this.arrivalDateTextBox);
            this.clientPanel.Controls.Add(this.cityFromWhichCameTextBox);
            this.clientPanel.Controls.Add(this.hotelRoomTextBox);
            this.clientPanel.Controls.Add(this.patronymicTextBox);
            this.clientPanel.Controls.Add(this.surnameTextBox);
            this.clientPanel.Controls.Add(this.nameTextBox);
            this.clientPanel.Controls.Add(this.departureDate);
            this.clientPanel.Controls.Add(this.cityFromWhichCameLabel);
            this.clientPanel.Controls.Add(this.arrivalDateLabel);
            this.clientPanel.Controls.Add(this.hotelRoomLabel);
            this.clientPanel.Controls.Add(this.patronymicLabel);
            this.clientPanel.Controls.Add(this.surnameLabel);
            this.clientPanel.Controls.Add(this.nameLabel);
            this.clientPanel.Location = new System.Drawing.Point(3, 99);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(743, 142);
            this.clientPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(16, 42);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Surname";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(16, 81);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(59, 13);
            this.patronymicLabel.TabIndex = 2;
            this.patronymicLabel.Text = "Patronymic";
            // 
            // hotelRoomLabel
            // 
            this.hotelRoomLabel.AutoSize = true;
            this.hotelRoomLabel.Location = new System.Drawing.Point(16, 113);
            this.hotelRoomLabel.Name = "hotelRoomLabel";
            this.hotelRoomLabel.Size = new System.Drawing.Size(60, 13);
            this.hotelRoomLabel.TabIndex = 3;
            this.hotelRoomLabel.Text = "HotelRoom";
            // 
            // arrivalDateLabel
            // 
            this.arrivalDateLabel.AutoSize = true;
            this.arrivalDateLabel.Location = new System.Drawing.Point(245, 42);
            this.arrivalDateLabel.Name = "arrivalDateLabel";
            this.arrivalDateLabel.Size = new System.Drawing.Size(59, 13);
            this.arrivalDateLabel.TabIndex = 4;
            this.arrivalDateLabel.Text = "ArrivalDate";
            // 
            // cityFromWhichCameLabel
            // 
            this.cityFromWhichCameLabel.AutoSize = true;
            this.cityFromWhichCameLabel.Location = new System.Drawing.Point(245, 8);
            this.cityFromWhichCameLabel.Name = "cityFromWhichCameLabel";
            this.cityFromWhichCameLabel.Size = new System.Drawing.Size(105, 13);
            this.cityFromWhichCameLabel.TabIndex = 5;
            this.cityFromWhichCameLabel.Text = "CityFromWhichCame";
            // 
            // departureDate
            // 
            this.departureDate.AutoSize = true;
            this.departureDate.Location = new System.Drawing.Point(245, 81);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(77, 13);
            this.departureDate.TabIndex = 7;
            this.departureDate.Text = "DepartureDate";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(79, 8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(79, 39);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 9;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(81, 78);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronymicTextBox.TabIndex = 10;
            // 
            // hotelRoomTextBox
            // 
            this.hotelRoomTextBox.Location = new System.Drawing.Point(82, 110);
            this.hotelRoomTextBox.Name = "hotelRoomTextBox";
            this.hotelRoomTextBox.Size = new System.Drawing.Size(100, 20);
            this.hotelRoomTextBox.TabIndex = 11;
            // 
            // cityFromWhichCameTextBox
            // 
            this.cityFromWhichCameTextBox.Location = new System.Drawing.Point(356, 8);
            this.cityFromWhichCameTextBox.Name = "cityFromWhichCameTextBox";
            this.cityFromWhichCameTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityFromWhichCameTextBox.TabIndex = 12;
            // 
            // arrivalDateTextBox
            // 
            this.arrivalDateTextBox.Location = new System.Drawing.Point(356, 39);
            this.arrivalDateTextBox.Name = "arrivalDateTextBox";
            this.arrivalDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.arrivalDateTextBox.TabIndex = 13;
            // 
            // departureDateTextBox
            // 
            this.departureDateTextBox.Location = new System.Drawing.Point(356, 78);
            this.departureDateTextBox.Name = "departureDateTextBox";
            this.departureDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.departureDateTextBox.TabIndex = 14;
            // 
            // executeDMLButton
            // 
            this.executeDMLButton.Location = new System.Drawing.Point(290, 71);
            this.executeDMLButton.Name = "executeDMLButton";
            this.executeDMLButton.Size = new System.Drawing.Size(152, 23);
            this.executeDMLButton.TabIndex = 5;
            this.executeDMLButton.Text = "Выполнить запрос";
            this.executeDMLButton.UseVisualStyleBackColor = true;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clientDataGridView.Location = new System.Drawing.Point(0, 247);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(749, 135);
            this.clientDataGridView.TabIndex = 2;
            // 
            // selectClientButton
            // 
            this.selectClientButton.Location = new System.Drawing.Point(275, 119);
            this.selectClientButton.Name = "selectClientButton";
            this.selectClientButton.Size = new System.Drawing.Size(170, 23);
            this.selectClientButton.TabIndex = 15;
            this.selectClientButton.Text = "Показать список клиентов";
            this.selectClientButton.UseVisualStyleBackColor = true;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 408);
            this.Controls.Add(this.sqlTabControl);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.sqlTabControl.ResumeLayout(false);
            this.primerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectDataGridView)).EndInit();
            this.selectGroupBox.ResumeLayout(false);
            this.selectGroupBox.PerformLayout();
            this.selectTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fSelectDataGridView)).EndInit();
            this.fSelectGroupBox.ResumeLayout(false);
            this.fSelectGroupBox.PerformLayout();
            this.detGroupBox.ResumeLayout(false);
            this.detGroupBox.PerformLayout();
            this.subqueryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subqueryDataGridView)).EndInit();
            this.subqueryGroupBox.ResumeLayout(false);
            this.subqueryGroupBox.PerformLayout();
            this.dmlTabPage.ResumeLayout(false);
            this.dmlGroupBox.ResumeLayout(false);
            this.dmlGroupBox.PerformLayout();
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl sqlTabControl;
        private System.Windows.Forms.TabPage primerTabPage;
        private System.Windows.Forms.GroupBox selectGroupBox;
        private System.Windows.Forms.RadioButton hotelRoomRadioButton;
        private System.Windows.Forms.RadioButton employeeRadioButton;
        private System.Windows.Forms.RadioButton scheduleRadioButton;
        private System.Windows.Forms.RadioButton reportRadioButton;
        private System.Windows.Forms.RadioButton clientRadioButton;
        private System.Windows.Forms.DataGridView selectDataGridView;
        private System.Windows.Forms.TabPage selectTabPage;
        private System.Windows.Forms.GroupBox fSelectGroupBox;
        private System.Windows.Forms.TextBox clientSurnameTextBox;
        private System.Windows.Forms.Label clientSurnameLabel;
        private System.Windows.Forms.TextBox moreArrivalDateTextBox;
        private System.Windows.Forms.CheckBox arrivalDateCheckBox;
        private System.Windows.Forms.DataGridView fSelectDataGridView;
        private System.Windows.Forms.CheckBox ascArrivalDateCheckBox;
        private System.Windows.Forms.GroupBox detGroupBox;
        private System.Windows.Forms.RadioButton noChoiceRadioButton;
        private System.Windows.Forms.RadioButton addCityRadioButton;
        private System.Windows.Forms.RadioButton addCostRadioButton;
        private System.Windows.Forms.Button fSelectButton;
        private System.Windows.Forms.TabPage subqueryTabPage;
        private System.Windows.Forms.GroupBox subqueryGroupBox;
        private System.Windows.Forms.RadioButton noCorrelatedRadioButton;
        private System.Windows.Forms.RadioButton correlatedRadioButton;
        private System.Windows.Forms.Button subqueryButton;
        private System.Windows.Forms.TextBox countOfPlacesTextBox;
        private System.Windows.Forms.Label countOfPlacesLabel;
        private System.Windows.Forms.DataGridView subqueryDataGridView;
        private System.Windows.Forms.TabPage dmlTabPage;
        private System.Windows.Forms.GroupBox dmlGroupBox;
        private System.Windows.Forms.RadioButton deleteRadioButton;
        private System.Windows.Forms.RadioButton updateRadioButton;
        private System.Windows.Forms.RadioButton insertRadioButton;
        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.TextBox passportDataTextBox;
        private System.Windows.Forms.Label passportDataLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label departureDate;
        private System.Windows.Forms.Label cityFromWhichCameLabel;
        private System.Windows.Forms.Label arrivalDateLabel;
        private System.Windows.Forms.Label hotelRoomLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox departureDateTextBox;
        private System.Windows.Forms.TextBox arrivalDateTextBox;
        private System.Windows.Forms.TextBox cityFromWhichCameTextBox;
        private System.Windows.Forms.TextBox hotelRoomTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.Button selectClientButton;
        private System.Windows.Forms.Button executeDMLButton;
    }
}