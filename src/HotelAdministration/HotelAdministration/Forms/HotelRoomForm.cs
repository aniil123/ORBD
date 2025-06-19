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
        int currentRoomNumber = -1;

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
            findToolStripButton.Click += findToolStripButton_Click;
            filterCheckBox.CheckedChanged += findCheckBox_CheckedChanged;
            toolStripButtonOK.Click += ToolStripButtonOK_Click;
            Shown += HotelRoom_Shown;
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

        private void ToolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void HotelRoom_Shown(object sender, EventArgs e)
        {
            hotelRoomBindingSource.Position = hotelRoomBindingSource.Find("RoomNumber", currentRoomNumber);
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

        public int ShowSelectForm(int roomNumber)
        {
            toolStripButtonOK.Visible = true;
            currentRoomNumber = roomNumber;
            bool dialogResult = ShowDialog() == DialogResult.OK;
            toolStripButtonOK.Visible = false;
            hotelRoomBindingSource.Position = 0;
            if (dialogResult)
                return Convert.ToInt16(((DataRowView)hotelRoomBindingSource.Current)["RoomNumber"]);
            else
                return -1;
        }
    }
}
