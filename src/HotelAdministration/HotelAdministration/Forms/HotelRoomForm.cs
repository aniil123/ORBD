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
    public partial class HotelRoomForm : Form
    {
        private static HotelRoomForm _instance;

        public static HotelRoomForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new HotelRoomForm();
                return _instance;
            }
        }

        public HotelRoomForm()
        {
            InitializeComponent();
            hotelRoomDataGridView.DataError += hotelRoomsDataGridView_DataError;
            findToolStripButton.Click += findToolStripButton_Click;
            filterCheckBox.CheckedChanged += findCheckBox_CheckedChanged;
        }

        private void hotelRoomsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void hotelRoomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.hotelRoomBindingSource.EndEdit();
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
                index = hotelRoomBindingSource.Find(GetSelectedFieldName(), findToolStripTextBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (index > -1)
                hotelRoomBindingSource.Position = index;
            else
            {
                MessageBox.Show("Такого гостиничного номера нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                hotelRoomBindingSource.Position = 0;
            }
        }

        private void findCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filterCheckBox.Checked)
            {
                if (findToolStripTextBox.Text == "")
                    MessageBox.Show("Значение не задано", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        hotelRoomBindingSource.Filter = GetSelectedFieldName() + "='" + findToolStripTextBox.Text + "'";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка фильтрации\n" + ex.Message);
                    }
            }
            else
                hotelRoomBindingSource.Filter = "";
            if (hotelRoomBindingSource.Count == 0)
            {
                MessageBox.Show("Значений нет");
                hotelRoomBindingSource.Filter = "";
                filterCheckBox.Checked = false;
            }
        }

        private void HotelRoomForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelAdministrationDataSet.HotelRoom". При необходимости она может быть перемещена или удалена.
            this.hotelRoomTableAdapter.Fill(this.hotelAdministrationDataSet.HotelRoom);

        }

        private string GetSelectedFieldName()
        {
            return hotelRoomDataGridView.Columns[hotelRoomDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }
    }
}
