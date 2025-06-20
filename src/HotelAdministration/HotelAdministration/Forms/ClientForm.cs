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
    public partial class ClientForm : Form
    {
        private static ClientForm _instance;

        public static ClientForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new ClientForm();
                return _instance;
            }
        }

        public ClientForm()
        {
            InitializeComponent();
            clientDataGridView.CellClick += ClientDataGridView_CellClick;
            findToolStripButton.Click += findToolStripButton_Click;
            filterCheckBox.CheckedChanged += findCheckBox_CheckedChanged;
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientBindingSource.EndEdit();
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
                index = clientBindingSource.Find(GetSelectedFieldName(), findToolStripTextBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (index > -1)
                clientBindingSource.Position = index;
            else
            {
                MessageBox.Show("Такого клиента нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                clientBindingSource.Position = 0;
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
                        clientBindingSource.Filter = GetSelectedFieldName() + "='" + findToolStripTextBox.Text + "'";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка фильтрации\n" + ex.Message);
                    }
            }
            else
                clientBindingSource.Filter = "";
            if (clientBindingSource.Count == 0)
            {
                MessageBox.Show("Значений нет");
                clientBindingSource.Filter = "";
                filterCheckBox.Checked = false;
            }
        }

        private void ClientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn currentColumn = clientDataGridView.Columns[clientDataGridView.CurrentCell.ColumnIndex];
            if (currentColumn.DataPropertyName == "HotelRoom" && e.RowIndex != -1)
            {
                int roomNumber = -1;
                string currentCellValue = ((DataRowView)clientBindingSource.Current)["HotelRoom"].ToString();
                if (currentCellValue != "")
                {
                    roomNumber = Convert.ToInt16(currentCellValue);
                }
                roomNumber = HotelRoomForm.Instance.ShowSelectForm(roomNumber);
                if (roomNumber >= 0)
                {
                    ((DataRowView)clientBindingSource.Current)["HotelRoom"] = roomNumber;
                }
                clientDataGridView.EndEdit();
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelAdministrationDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.hotelAdministrationDataSet.Client);

        }

        private string GetSelectedFieldName()
        {
            return clientDataGridView.Columns[clientDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }
    }
}
