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
            this.arrivalDateTextBox = new System.Windows.Forms.TextBox();
            this.arrivalDateCheckBox = new System.Windows.Forms.CheckBox();
            this.clientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.clientSurnameLabel = new System.Windows.Forms.Label();
            this.sqlTabControl.SuspendLayout();
            this.primerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectDataGridView)).BeginInit();
            this.selectGroupBox.SuspendLayout();
            this.selectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fSelectDataGridView)).BeginInit();
            this.fSelectGroupBox.SuspendLayout();
            this.detGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlTabControl
            // 
            this.sqlTabControl.Controls.Add(this.primerTabPage);
            this.sqlTabControl.Controls.Add(this.selectTabPage);
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
            this.fSelectGroupBox.Controls.Add(this.arrivalDateTextBox);
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
            // arrivalDateTextBox
            // 
            this.arrivalDateTextBox.Location = new System.Drawing.Point(193, 69);
            this.arrivalDateTextBox.Name = "arrivalDateTextBox";
            this.arrivalDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.arrivalDateTextBox.TabIndex = 3;
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
        private System.Windows.Forms.TextBox arrivalDateTextBox;
        private System.Windows.Forms.CheckBox arrivalDateCheckBox;
        private System.Windows.Forms.DataGridView fSelectDataGridView;
        private System.Windows.Forms.CheckBox ascArrivalDateCheckBox;
        private System.Windows.Forms.GroupBox detGroupBox;
        private System.Windows.Forms.RadioButton noChoiceRadioButton;
        private System.Windows.Forms.RadioButton addCityRadioButton;
        private System.Windows.Forms.RadioButton addCostRadioButton;
        private System.Windows.Forms.Button fSelectButton;
    }
}