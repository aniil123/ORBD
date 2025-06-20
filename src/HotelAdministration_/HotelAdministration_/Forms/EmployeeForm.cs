using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAdministration_.Forms
{
    public partial class EmployeeForm : Form
    {
        private static EmployeeForm _instance;

        public static EmployeeForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new EmployeeForm();
                return _instance;
            }
        }

        public EmployeeForm()
        {
            InitializeComponent();
            employeeBindingNavigatorSaveItem.Click += employeeBindingNavigatorSaveItem_Click;
            scheduleBindingNavigatorSaveItem.Click += scheduleBindingNavigatorSaveItem_Click;
            findToolStripButton.Click += findToolStripButton_Click;
            filterCheckBox.CheckedChanged += filterCheckBox_CheckedChanged;
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                employeeBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(hotelAdministrationDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void scheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                scheduleBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(hotelAdministrationDataSet);
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
                index = employeeBindingSource.Find(GetSelectedEmployeeFieldName(), findToolStripTextBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (index > -1)
                employeeBindingSource.Position = index;
            else
            {
                MessageBox.Show("Такого служащего нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                employeeBindingSource.Position = 0;
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
                        employeeBindingSource.Filter = GetSelectedEmployeeFieldName() + "='" + findToolStripTextBox.Text + "'";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка фильтрации\n" + ex.Message);
                    }
            }
            else
                employeeBindingSource.Filter = "";
            if (employeeBindingSource.Count == 0)
            {
                MessageBox.Show("Значений нет");
                employeeBindingSource.Filter = "";
                filterCheckBox.Checked = false;
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelAdministrationDataSet.Schedule". При необходимости она может быть перемещена или удалена.
            this.scheduleTableAdapter.Fill(this.hotelAdministrationDataSet.Schedule);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelAdministrationDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hotelAdministrationDataSet.Employee);

        }

        private string GetSelectedEmployeeFieldName()
        {
            return employeeDataGridView.Columns[employeeDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private string GetSelectedScheduleFieldName()
        {
            return scheduleDataGridView.Columns[scheduleDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }
    }
}
