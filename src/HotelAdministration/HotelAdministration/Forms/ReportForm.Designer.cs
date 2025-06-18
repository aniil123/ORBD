namespace HotelAdministration.Forms
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.hotelAdministrationDataSet = new HotelAdministration.HotelAdministrationDataSet();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTableAdapter = new HotelAdministration.HotelAdministrationDataSetTableAdapters.ReportTableAdapter();
            this.tableAdapterManager = new HotelAdministration.HotelAdministrationDataSetTableAdapters.TableAdapterManager();
            this.reportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.reportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.filterCheckBox = new System.Windows.Forms.CheckBox();
            this.hotelRoom_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelRoom_ReportTableAdapter = new HotelAdministration.HotelAdministrationDataSetTableAdapters.HotelRoom_ReportTableAdapter();
            this.hotelRoom_ReportDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.hotelRoom_ReportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotelAdministrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingNavigator)).BeginInit();
            this.reportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoom_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoom_ReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hotelAdministrationDataSet
            // 
            this.hotelAdministrationDataSet.DataSetName = "HotelAdministrationDataSet";
            this.hotelAdministrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "Report";
            this.reportBindingSource.DataSource = this.hotelAdministrationDataSet;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.HotelRoom_ReportTableAdapter = this.hotelRoom_ReportTableAdapter;
            this.tableAdapterManager.HotelRoomTableAdapter = null;
            this.tableAdapterManager.ReportTableAdapter = this.reportTableAdapter;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelAdministration.HotelAdministrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportBindingNavigator
            // 
            this.reportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reportBindingNavigator.BindingSource = this.reportBindingSource;
            this.reportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reportBindingNavigator.CountItemFormat = "из {0}";
            this.reportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.reportBindingNavigatorSaveItem,
            this.findToolStripSeparator,
            this.findToolStripTextBox,
            this.findToolStripButton});
            this.reportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reportBindingNavigator.Name = "reportBindingNavigator";
            this.reportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reportBindingNavigator.Size = new System.Drawing.Size(533, 25);
            this.reportBindingNavigator.TabIndex = 0;
            this.reportBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
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
            // reportBindingNavigatorSaveItem
            // 
            this.reportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reportBindingNavigatorSaveItem.Image")));
            this.reportBindingNavigatorSaveItem.Name = "reportBindingNavigatorSaveItem";
            this.reportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reportBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.reportBindingNavigatorSaveItem.Click += new System.EventHandler(this.reportBindingNavigatorSaveItem_Click);
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportDataGridView.AutoGenerateColumns = false;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.reportDataGridView.DataSource = this.reportBindingSource;
            this.reportDataGridView.Location = new System.Drawing.Point(12, 28);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.Size = new System.Drawing.Size(506, 217);
            this.reportDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quarter";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quarter";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientCount";
            this.dataGridViewTextBoxColumn2.HeaderText = "ClientCount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Profit";
            this.dataGridViewTextBoxColumn3.HeaderText = "Profit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // findToolStripSeparator
            // 
            this.findToolStripSeparator.Name = "findToolStripSeparator";
            this.findToolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // findToolStripTextBox
            // 
            this.findToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.findToolStripTextBox.Name = "findToolStripTextBox";
            this.findToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // findToolStripButton
            // 
            this.findToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripButton.Image")));
            this.findToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findToolStripButton.Name = "findToolStripButton";
            this.findToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.findToolStripButton.Text = "Поиск";
            // 
            // filterCheckBox
            // 
            this.filterCheckBox.AutoSize = true;
            this.filterCheckBox.Location = new System.Drawing.Point(452, 5);
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.Size = new System.Drawing.Size(66, 17);
            this.filterCheckBox.TabIndex = 6;
            this.filterCheckBox.Text = "Фильтр";
            this.filterCheckBox.UseVisualStyleBackColor = true;
            // 
            // hotelRoom_ReportBindingSource
            // 
            this.hotelRoom_ReportBindingSource.DataMember = "FK_HotelRoom_Report_Report";
            this.hotelRoom_ReportBindingSource.DataSource = this.reportBindingSource;
            // 
            // hotelRoom_ReportTableAdapter
            // 
            this.hotelRoom_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // hotelRoom_ReportDataGridView
            // 
            this.hotelRoom_ReportDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hotelRoom_ReportDataGridView.AutoGenerateColumns = false;
            this.hotelRoom_ReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelRoom_ReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.hotelRoom_ReportDataGridView.DataSource = this.hotelRoom_ReportBindingSource;
            this.hotelRoom_ReportDataGridView.Location = new System.Drawing.Point(12, 276);
            this.hotelRoom_ReportDataGridView.Name = "hotelRoom_ReportDataGridView";
            this.hotelRoom_ReportDataGridView.Size = new System.Drawing.Size(506, 249);
            this.hotelRoom_ReportDataGridView.TabIndex = 6;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.reportBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.CountItemFormat = "из {0}";
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.hotelRoom_ReportBindingNavigatorSaveItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 248);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(279, 25);
            this.bindingNavigator1.TabIndex = 7;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "из {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // hotelRoom_ReportBindingNavigatorSaveItem
            // 
            this.hotelRoom_ReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hotelRoom_ReportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hotelRoom_ReportBindingNavigatorSaveItem.Image")));
            this.hotelRoom_ReportBindingNavigatorSaveItem.Name = "hotelRoom_ReportBindingNavigatorSaveItem";
            this.hotelRoom_ReportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hotelRoom_ReportBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quarter";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quarter";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RoomNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "RoomNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BusyDays";
            this.dataGridViewTextBoxColumn6.HeaderText = "BusyDays";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 559);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.hotelRoom_ReportDataGridView);
            this.Controls.Add(this.filterCheckBox);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.reportBindingNavigator);
            this.Name = "ReportForm";
            this.Text = "Отчеты";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelAdministrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingNavigator)).EndInit();
            this.reportBindingNavigator.ResumeLayout(false);
            this.reportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoom_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoom_ReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelAdministrationDataSet hotelAdministrationDataSet;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private HotelAdministrationDataSetTableAdapters.ReportTableAdapter reportTableAdapter;
        private HotelAdministrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reportBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton reportBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripSeparator findToolStripSeparator;
        private System.Windows.Forms.ToolStripTextBox findToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findToolStripButton;
        private System.Windows.Forms.CheckBox filterCheckBox;
        private HotelAdministrationDataSetTableAdapters.HotelRoom_ReportTableAdapter hotelRoom_ReportTableAdapter;
        private System.Windows.Forms.BindingSource hotelRoom_ReportBindingSource;
        private System.Windows.Forms.DataGridView hotelRoom_ReportDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton hotelRoom_ReportBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}