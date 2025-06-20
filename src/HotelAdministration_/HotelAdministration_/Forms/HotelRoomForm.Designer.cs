namespace HotelAdministration_.Forms
{
    partial class HotelRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelRoomForm));
            this.hotelRoomBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hotelRoomDataGridView = new System.Windows.Forms.DataGridView();
            this.findToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.filterCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.hotelRoomBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.findToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOK = new System.Windows.Forms.ToolStripButton();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hotelRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelAdministrationDataSet = new HotelAdministration_.HotelAdministrationDataSet();
            this.hotelRoomTableAdapter = new HotelAdministration_.HotelAdministrationDataSetTableAdapters.HotelRoomTableAdapter();
            this.tableAdapterManager = new HotelAdministration_.HotelAdministrationDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingNavigator)).BeginInit();
            this.hotelRoomBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelAdministrationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelRoomBindingNavigator
            // 
            this.hotelRoomBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hotelRoomBindingNavigator.BindingSource = this.hotelRoomBindingSource;
            this.hotelRoomBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hotelRoomBindingNavigator.CountItemFormat = "из {0}";
            this.hotelRoomBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hotelRoomBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hotelRoomBindingNavigatorSaveItem,
            this.findToolStripSeparator,
            this.findToolStripTextBox,
            this.findToolStripButton,
            this.toolStripButtonOK});
            this.hotelRoomBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hotelRoomBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hotelRoomBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hotelRoomBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hotelRoomBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hotelRoomBindingNavigator.Name = "hotelRoomBindingNavigator";
            this.hotelRoomBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hotelRoomBindingNavigator.Size = new System.Drawing.Size(643, 25);
            this.hotelRoomBindingNavigator.TabIndex = 0;
            this.hotelRoomBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hotelRoomDataGridView
            // 
            this.hotelRoomDataGridView.AutoGenerateColumns = false;
            this.hotelRoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelRoomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.Info});
            this.hotelRoomDataGridView.DataSource = this.hotelRoomBindingSource;
            this.hotelRoomDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotelRoomDataGridView.Location = new System.Drawing.Point(0, 25);
            this.hotelRoomDataGridView.Name = "hotelRoomDataGridView";
            this.hotelRoomDataGridView.Size = new System.Drawing.Size(643, 369);
            this.hotelRoomDataGridView.TabIndex = 1;
            // 
            // findToolStripSeparator
            // 
            this.findToolStripSeparator.Name = "findToolStripSeparator";
            this.findToolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // findToolStripTextBox
            // 
            this.findToolStripTextBox.Name = "findToolStripTextBox";
            this.findToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // filterCheckBox
            // 
            this.filterCheckBox.AutoSize = true;
            this.filterCheckBox.Location = new System.Drawing.Point(454, 5);
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.Size = new System.Drawing.Size(66, 17);
            this.filterCheckBox.TabIndex = 4;
            this.filterCheckBox.Text = "Фильтр";
            this.filterCheckBox.UseVisualStyleBackColor = true;
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
            // hotelRoomBindingNavigatorSaveItem
            // 
            this.hotelRoomBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hotelRoomBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hotelRoomBindingNavigatorSaveItem.Image")));
            this.hotelRoomBindingNavigatorSaveItem.Name = "hotelRoomBindingNavigatorSaveItem";
            this.hotelRoomBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hotelRoomBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.hotelRoomBindingNavigatorSaveItem.Click += new System.EventHandler(this.hotelRoomBindingNavigatorSaveItem_Click);
            // 
            // findToolStripButton
            // 
            this.findToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripButton.Image")));
            this.findToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findToolStripButton.Name = "findToolStripButton";
            this.findToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.findToolStripButton.Text = "Поиск";
            // 
            // toolStripButtonOK
            // 
            this.toolStripButtonOK.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonOK.Image = global::HotelAdministration_.Properties.Resources.Home;
            this.toolStripButtonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOK.Name = "toolStripButtonOK";
            this.toolStripButtonOK.Size = new System.Drawing.Size(74, 22);
            this.toolStripButtonOK.Text = "Выбрать";
            this.toolStripButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonOK.Visible = false;
            // 
            // Info
            // 
            this.Info.DataPropertyName = "Info";
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RoomNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "RoomNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CountOfPlaces";
            this.dataGridViewTextBoxColumn4.HeaderText = "CountOfPlaces";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Busy";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Busy";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // hotelRoomBindingSource
            // 
            this.hotelRoomBindingSource.DataMember = "HotelRoom";
            this.hotelRoomBindingSource.DataSource = this.hotelAdministrationDataSet;
            // 
            // hotelAdministrationDataSet
            // 
            this.hotelAdministrationDataSet.DataSetName = "HotelAdministrationDataSet";
            this.hotelAdministrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelRoomTableAdapter
            // 
            this.hotelRoomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.HotelRoom_ReportTableAdapter = null;
            this.tableAdapterManager.HotelRoomTableAdapter = this.hotelRoomTableAdapter;
            this.tableAdapterManager.ReportTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelAdministration_.HotelAdministrationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // HotelRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 394);
            this.Controls.Add(this.filterCheckBox);
            this.Controls.Add(this.hotelRoomDataGridView);
            this.Controls.Add(this.hotelRoomBindingNavigator);
            this.Name = "HotelRoomForm";
            this.Text = "Гостиничные номера";
            this.Load += new System.EventHandler(this.HotelRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingNavigator)).EndInit();
            this.hotelRoomBindingNavigator.ResumeLayout(false);
            this.hotelRoomBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelAdministrationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelAdministrationDataSet hotelAdministrationDataSet;
        private System.Windows.Forms.BindingSource hotelRoomBindingSource;
        private HotelAdministrationDataSetTableAdapters.HotelRoomTableAdapter hotelRoomTableAdapter;
        private HotelAdministrationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hotelRoomBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hotelRoomBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator findToolStripSeparator;
        private System.Windows.Forms.ToolStripTextBox findToolStripTextBox;
        private System.Windows.Forms.ToolStripButton findToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButtonOK;
        private System.Windows.Forms.DataGridView hotelRoomDataGridView;
        private System.Windows.Forms.CheckBox filterCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
    }
}