using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelAdministration.Forms
{
    public partial class FormSQL : Form
    {
        private static FormSQL _instance;

        public static FormSQL Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FormSQL();
                return _instance;
            }
        }

        public FormSQL()
        {
            InitializeComponent();
            hotelRoomRadioButton.CheckedChanged += HotelRoomRadioButton_CheckedChanged;
            clientRadioButton.CheckedChanged += ClientRadioButton_CheckedChanged;
            employeeRadioButton.CheckedChanged += EmployeeRadioButton_CheckedChanged;
            scheduleRadioButton.CheckedChanged += ScheduleRadioButton_CheckedChanged;
            reportRadioButton.CheckedChanged += ReportRadioButton_CheckedChanged;
            fSelectButton.Click += FSelectButton_Click;
        }

        private void HotelRoomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hotelRoomRadioButton.Checked)
                selectDataGridView.DataSource = FillDataGridView("SELECT * FROM HotelRoom");
        }

        private void ClientRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (clientRadioButton.Checked)
                selectDataGridView.DataSource = FillDataGridView(
                    @"SELECT 
                        PassportData, 
                        Name + ' ' + Surname + ' ' + Patronymic AS FIO, 
                        Client.HotelRoom,
                        PhoneNumber AS HotelRoomPhoneNumber
                    FROM Client INNER JOIN HotelRoom
                    ON Client.HotelRoom = HotelRoom.RoomNumber"
                );
        }

        private void EmployeeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeRadioButton.Checked)
                selectDataGridView.DataSource = FillDataGridView(
                    @"SELECT 
                        Employee.ID_Employee,
                        AVG(Age) AS Age,
                        WeekDay,
                        AVG(Floor) AS Floor
                    FROM Employee INNER JOIN Schedule
                    ON Employee.ID_Employee = Schedule.ID_Employee
                    GROUP BY Employee.ID_Employee, WeekDay
                    ORDER BY Employee.ID_Employee"
                );
        }

        private void ScheduleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (scheduleRadioButton.Checked)
                selectDataGridView.DataSource = FillDataGridView("SELECT * FROM Schedule");
        }

        private void ReportRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(reportRadioButton.Checked)
                selectDataGridView.DataSource = FillDataGridView("SELECT * FROM Report");
        }

        private void FSelectButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(clientSurnameTextBox.Text))
            {
                MessageBox.Show("Обязательно укажите фамилию необходимого клиента.\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (arrivalDateCheckBox.Checked && String.IsNullOrEmpty(arrivalDateTextBox.Text))
            {
                MessageBox.Show("Не указана дата в условии", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                arrivalDateCheckBox.Checked = false;
                return;
            }
            string sqlSelect = "";
            if (addCostRadioButton.Checked)
            {
                sqlSelect += @"SELECT PassportData, Surname, Client.HotelRoom, ArrivalDate, DepartureDate, Cost 
                               FROM Client, HotelRoom 
                               WHERE Client.HotelRoom = HotelRoom.RoomNumber AND Surname LIKE @surname ";
            }
            else if (addCityRadioButton.Checked)
            {
                sqlSelect += @"SELECT PassportData, Surname, Client.HotelRoom, ArrivalDate, DepartureDate, CityFromWhichCame
                               FROM Client
                               WHERE Surname LIKE @surname ";
            }
            else
            {
                sqlSelect += @"SELECT PassportData, Surname, Client.HotelRoom, ArrivalDate, DepartureDate
                               FROM Client
                               WHERE Surname LIKE @surname ";
            }
            sqlSelect += " ";
            if (arrivalDateCheckBox.Checked)
            {
                sqlSelect += "AND ArrivalDate > @arrivalDate ";
            }
            if(ascArrivalDateCheckBox.Checked)
            {
                sqlSelect += "ORDER BY ArrivalDate";
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.HotelAdministrationConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@surname", clientSurnameTextBox.Text + "%");
            if (arrivalDateCheckBox.Checked)
            {
                try
                {
                    command.Parameters.AddWithValue("@arrivalDate", arrivalDateTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Неверный формат даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            fSelectDataGridView.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.HotelAdministrationConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
