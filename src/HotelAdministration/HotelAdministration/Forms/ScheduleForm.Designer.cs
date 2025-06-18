namespace HotelAdministration.Forms
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.hotelAdministrationDataSet = new HotelAdministration.HotelAdministrationDataSet();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableAdapter = new HotelAdministration.HotelAdministrationDataSetTableAdapters.ScheduleTableAdapter();
            this.tableAdapterManager = new HotelAdministration.HotelAdministrationDataSetTableAdapters.TableAdapterManager();
            this.scheduleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.scheduleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.filterCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.hotelAdministrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingNavigator)).BeginInit();
            this.scheduleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelAdministrationDataSet
            // 
            this.hotelAdministrationDataSet.DataSetName = "HotelAdministrationDataSet";
            this.hotelAdministrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.hotelAdministrationDataSet;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.HotelRoom_ReportTableAdapter = null;
            this.tableAdapterManager.HotelRoomTableAdapter = null;
            this.tableAdapterManager.ReportTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = this.scheduleTableAdapter;
            this.tableAdapterManager.UpdateOrder = HotelAdministration.HotelAdministrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // scheduleBindingNavigator
            // 
            this.scheduleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.scheduleBindingNavigator.BindingSource = this.scheduleBindingSource;
            this.scheduleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.scheduleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.scheduleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.scheduleBindingNavigatorSaveItem,
            this.findToolStripSeparator,
            this.findToolStripTextBox,
            this.findToolStripButton});
            this.scheduleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.scheduleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.scheduleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.scheduleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.scheduleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.scheduleBindingNavigator.Name = "scheduleBindingNavigator";
            this.scheduleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.scheduleBindingNavigator.Size = new System.Drawing.Size(564, 25);
            this.scheduleBindingNavigator.TabIndex = 0;
            this.scheduleBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
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
            // scheduleBindingNavigatorSaveItem
            // 
            this.scheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scheduleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleBindingNavigatorSaveItem.Image")));
            this.scheduleBindingNavigatorSaveItem.Name = "scheduleBindingNavigatorSaveItem";
            this.scheduleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.scheduleBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.scheduleBindingNavigatorSaveItem.Click += new System.EventHandler(this.scheduleBindingNavigatorSaveItem_Click_1);
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleDataGridView.AutoGenerateColumns = false;
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.scheduleDataGridView.DataSource = this.scheduleBindingSource;
            this.scheduleDataGridView.Location = new System.Drawing.Point(12, 28);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.Size = new System.Drawing.Size(543, 360);
            this.scheduleDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Schedule";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Schedule";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Employee";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Employee";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WeekDay";
            this.dataGridViewTextBoxColumn3.HeaderText = "WeekDay";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Floor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Floor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HotelRoom";
            this.dataGridViewTextBoxColumn5.HeaderText = "HotelRoom";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
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
            this.filterCheckBox.Location = new System.Drawing.Point(456, 5);
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.Size = new System.Drawing.Size(66, 17);
            this.filterCheckBox.TabIndex = 5;
            this.filterCheckBox.Text = "Фильтр";
            this.filterCheckBox.UseVisualStyleBackColor = true;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 396);
            this.Controls.Add(this.filterCheckBox);
            this.Controls.Add(this.scheduleDataGridView);
            this.Controls.Add(this.scheduleBindingNavigator);
            this.Name = "ScheduleForm";
            this.Text = "Расписания";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelAdministrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingNavigator)).EndInit();
            this.scheduleBindingNavigator.ResumeLayout(false);
            this.scheduleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelAdministrationDataSet hotelAdministrationDataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private HotelAdministrationDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private HotelAdministrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator scheduleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton scheduleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripSeparator findToolStripSeparator;
        private System.Windows.Forms.ToolStripTextBox findToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findToolStripButton;
        private System.Windows.Forms.CheckBox filterCheckBox;
    }
}