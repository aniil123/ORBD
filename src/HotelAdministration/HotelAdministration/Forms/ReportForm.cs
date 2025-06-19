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
    public partial class ReportForm : Form
    {
        private static ReportForm _instance;

        public static ReportForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new ReportForm();
                return _instance;
            }
        }

        public ReportForm()
        {
            InitializeComponent();
            reportBindingNavigatorSaveItem.Click += reportBindingNavigatorSaveItem_Click;
            hotelRoom_ReportBindingNavigatorSaveItem.Click += hotelRoom_ReportBindingNavigatorSaveItem_Click;
            findToolStripButton.Click += findToolStripButton_Click;
            filterCheckBox.CheckedChanged += filterCheckBox_CheckedChanged;
        }

        private void reportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                reportBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(hotelAdministrationDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hotelRoom_ReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                hotelRoom_ReportBindingSource.EndEdit();
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
                index = reportBindingSource.Find(GetSelectedreportFieldName(), findToolStripTextBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (index > -1)
                reportBindingSource.Position = index;
            else
            {
                MessageBox.Show("Такого служащего нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                reportBindingSource.Position = 0;
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
                        reportBindingSource.Filter = GetSelectedreportFieldName() + "='" + findToolStripTextBox.Text + "'";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка фильтрации\n" + ex.Message);
                    }
            }
            else
                reportBindingSource.Filter = "";
            if (reportBindingSource.Count == 0)
            {
                MessageBox.Show("Значений нет");
                reportBindingSource.Filter = "";
                filterCheckBox.Checked = false;
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelAdministrationDataSet.HotelRoom". При необходимости она может быть перемещена или удалена.
            this.hotelRoomTableAdapter.Fill(this.hotelAdministrationDataSet.HotelRoom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelAdministrationDataSet.HotelRoom_Report". При необходимости она может быть перемещена или удалена.
            this.hotelRoom_ReportTableAdapter.Fill(this.hotelAdministrationDataSet.HotelRoom_Report);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelAdministrationDataSet.Report". При необходимости она может быть перемещена или удалена.
            this.reportTableAdapter.Fill(this.hotelAdministrationDataSet.Report);

        }

        private string GetSelectedreportFieldName()
        {
            return reportDataGridView.Columns[reportDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }
    }
}
