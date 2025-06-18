using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAdministration.Forms
{
    public partial class ScheduleForm : Form
    {
        private static ScheduleForm _instance;

        public static ScheduleForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new ScheduleForm();
                return _instance;
            }
        }

        public ScheduleForm()
        {
            InitializeComponent();
            scheduleDataGridView.DataError += scheduleDataGridView_DataError;
            findToolStripButton.Click += findToolStripButton_Click;
            filterCheckBox.CheckedChanged += filterCheckBox_CheckedChanged;
        }

        private void scheduleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void scheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.scheduleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hotelAdministrationDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findToolStripButton_Click(object sender, EventArgs e)
        {
            if (findToolStripTextBox.Text == "")
            {
                MessageBox.Show("Значение не задано", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int index;
            try
            {
                index = scheduleBindingSource.Find(GetSelectedFieldName(), findToolStripTextBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (index > -1)
                scheduleBindingSource.Position = index;
            else
            {
                MessageBox.Show("Такого расписания нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                scheduleBindingSource.Position = 0;
            }
        }

        private void filterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filterCheckBox.Checked)
            {
                if (findToolStripTextBox.Text == "")
                    MessageBox.Show("Значение не задано", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        scheduleBindingSource.Filter = GetSelectedFieldName() + "='" + findToolStripTextBox.Text + "'";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка фильтрации\n" + ex.Message);
                    }
            }
            else
                scheduleBindingSource.Filter = "";
            if (scheduleBindingSource.Count == 0)
            {
                MessageBox.Show("Значений нет");
                scheduleBindingSource.Filter = "";
                filterCheckBox.Checked = false;
            }
        }

        private void scheduleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.scheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelAdministrationDataSet);

        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelAdministrationDataSet.Schedule". При необходимости она может быть перемещена или удалена.
            this.scheduleTableAdapter.Fill(this.hotelAdministrationDataSet.Schedule);

        }

        private string GetSelectedFieldName()
        {
            return scheduleDataGridView.Columns[scheduleDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }
    }
}
