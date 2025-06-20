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
            subqueryButton.Click += SubqueryButton_Click;
            selectClientButton.Click += SelectClientButton_Click;
            executeDMLButton.Click += ExecuteDMLButton;
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
            if (arrivalDateCheckBox.Checked && String.IsNullOrEmpty(moreArrivalDateTextBox.Text))
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
                    command.Parameters.AddWithValue("@arrivalDate", moreArrivalDateTextBox.Text);
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

        private void SubqueryButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(countOfPlacesTextBox.Text))
            {
                MessageBox.Show("Обязательно укажите количество мест", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";
            if(correlatedRadioButton.Checked)
            {
                sqlSelect = @"SELECT 
                              HotelRoom.RoomNumber, 
                              HotelRoom.PhoneNumber, 
                              HotelRoom.Cost, 
                              HotelRoom.CountOfPlaces, 
                              (SELECT BusyDays FROM HotelRoom_Report WHERE Quarter = 1 AND RoomNumber = HotelRoom.RoomNumber) AS BusyDays
                              FROM HotelRoom
                              WHERE CountOfPlaces = @countOfPlaces";
            }
            else if(noCorrelatedRadioButton.Checked)
            {
                sqlSelect = @"SELECT *
                              FROM HotelRoom
                              WHERE Cost > (SELECT AVG(Cost) FROM HotelRoom) AND CountOfPlaces = @countOfPlaces";
            }
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.HotelAdministrationConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.AddWithValue("@countOfPlaces", Convert.ToInt16(countOfPlacesTextBox.Text));
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            subqueryDataGridView.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SelectClientButton_Click(object sender, EventArgs e)
        {
            clientDataGridView.DataSource = FillDataGridView("SELECT * FROM Client");
        }

        private void ExecuteDMLButton(object sender, EventArgs e)
        {
            if (insertRadioButton.Checked)
                InsertClient();
            else if (updateRadioButton.Checked)
                UpdateClient();
            else if (deleteRadioButton.Checked)
                DeleteClient();
            else
                MessageBox.Show("Необходимо выбрать операцию", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void InsertClient()
        {
            if (String.IsNullOrEmpty(passportDataTextBox.Text) ||
                String.IsNullOrEmpty(nameTextBox.Text) ||
                String.IsNullOrEmpty(surnameTextBox.Text) ||
                String.IsNullOrEmpty(patronymicTextBox.Text) ||
                String.IsNullOrEmpty(hotelRoomTextBox.Text) ||
                String.IsNullOrEmpty(cityFromWhichCameTextBox.Text) ||
                String.IsNullOrEmpty(arrivalDateTextBox.Text) ||
                String.IsNullOrEmpty(departureDateTextBox.Text))
            {
                MessageBox.Show("Обязательно введите все необходимые данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }
            string sqlInsert = @"INSERT INTO Client (PassportData, Name, Surname, Patronymic, HotelRoom, CityFromWhichCame, ArrivalDate, DepartureDate)
                                 VALUES (@passportData, @name, @surname, @patronymic, @hotelRoom, @cityFromWhichCame, @arrivalDate, @departureDate)";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.HotelAdministrationConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@passportData", passportDataTextBox.Text);
            command.Parameters.AddWithValue("@name", nameTextBox.Text);
            command.Parameters.AddWithValue("@surname", surnameTextBox.Text);
            command.Parameters.AddWithValue("@patronymic", patronymicTextBox.Text);
            command.Parameters.AddWithValue("@hotelRoom", hotelRoomTextBox.Text);
            command.Parameters.AddWithValue("@cityFromWhichCame", cityFromWhichCameTextBox.Text);
            command.Parameters.AddWithValue("@arrivalDate", arrivalDateTextBox.Text);
            command.Parameters.AddWithValue("@departureDate", departureDateTextBox.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения запроса\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            SelectClientButton_Click(this, EventArgs.Empty);
        }

        private void UpdateClient()
        {
            if (String.IsNullOrEmpty(nameTextBox.Text) ||
                String.IsNullOrEmpty(surnameTextBox.Text) ||
                String.IsNullOrEmpty(patronymicTextBox.Text) ||
                String.IsNullOrEmpty(hotelRoomTextBox.Text) ||
                String.IsNullOrEmpty(cityFromWhichCameTextBox.Text) ||
                String.IsNullOrEmpty(arrivalDateTextBox.Text) ||
                String.IsNullOrEmpty(departureDateTextBox.Text))
            {
                MessageBox.Show("Обязательно введите все необходимые данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlUpdate = @"UPDATE Client SET {0} WHERE PassportData = @passportData";

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.HotelAdministrationConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(nameTextBox.Text))
                sqlValues += "Name=@name,";
            if (!String.IsNullOrEmpty(surnameTextBox.Text))
                sqlValues += "Surname=@surname,";
            if (!String.IsNullOrEmpty(patronymicTextBox.Text))
                sqlValues += "Patronymic=@patronymic,";
            if (!String.IsNullOrEmpty(hotelRoomTextBox.Text))
                sqlValues += "HotelRoom=@hotelRoom,";
            if (!String.IsNullOrEmpty(cityFromWhichCameTextBox.Text))
                sqlValues += "CityFromWhichCame=@cityFromWhichCame,";
            if (!String.IsNullOrEmpty(arrivalDateTextBox.Text))
                sqlValues += "ArrivalDate=@arrivalDate,";
            if (!String.IsNullOrEmpty(departureDateTextBox.Text))
                sqlValues += "DepartureDate=@departureDate,";
            sqlValues = sqlValues.Substring(0, sqlValues.Length - 1);
            command.CommandText = String.Format(sqlUpdate, sqlValues);
            if (!String.IsNullOrEmpty(passportDataTextBox.Text))
                command.Parameters.AddWithValue("@passportData", passportDataTextBox.Text);
            if (!String.IsNullOrEmpty(nameTextBox.Text))
                command.Parameters.AddWithValue("@name", nameTextBox.Text);
            if (!String.IsNullOrEmpty(surnameTextBox.Text))
                command.Parameters.AddWithValue("@surname", surnameTextBox.Text);
            if (!String.IsNullOrEmpty(patronymicTextBox.Text))
                command.Parameters.AddWithValue("@patronymic", patronymicTextBox.Text);
            if (!String.IsNullOrEmpty(hotelRoomTextBox.Text))
                command.Parameters.AddWithValue("@hotelRoom", hotelRoomTextBox.Text);
            if (!String.IsNullOrEmpty(cityFromWhichCameTextBox.Text))
                command.Parameters.AddWithValue("@cityFromWhichCame", cityFromWhichCameTextBox.Text);
            if (!String.IsNullOrEmpty(arrivalDateTextBox.Text))
                command.Parameters.AddWithValue("@arrivalDate", arrivalDateTextBox.Text);
            if (!String.IsNullOrEmpty(departureDateTextBox.Text))
                command.Parameters.AddWithValue("@departureDate", departureDateTextBox.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения запроса\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            SelectClientButton_Click(this, EventArgs.Empty);
        }

        private void DeleteClient()
        {

            if (String.IsNullOrEmpty(passportDataTextBox.Text))
            {
                MessageBox.Show("Обязательно укажите паспортные данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }
            string sqlDelete = @"DELETE FROM Client WHERE PassportData = @passportData";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.HotelAdministrationConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@passportData", passportDataTextBox.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения запроса\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            SelectClientButton_Click(this, EventArgs.Empty);
        }

        private void DataVerification()
        {
            if (String.IsNullOrEmpty(passportDataTextBox.Text))
            {
                throw new Exception("Необходимо заполнить паспортные данные");
            }
            else
            {
                string passportData = passportDataTextBox.Text;
                string gradualPassportData = "";
                if (passportData[4] != ' ' || passportData.Length != 11)
                    throw new Exception("Ошибка в паспортных данных");
                for (int i = 0; i < 4; i++)
                {
                    gradualPassportData += passportData[i];
                }
                Convert.ToInt32(gradualPassportData);
                gradualPassportData = "";
                for (int i = 5; i < 11; i++)
                {
                    gradualPassportData += passportData[i];
                }
                Convert.ToInt32(gradualPassportData);
            }
            if (String.IsNullOrEmpty(nameTextBox.Text))
                throw new Exception("Необходимо заполнить имя");
            if (String.IsNullOrEmpty(surnameTextBox.Text))
                throw new Exception("Необходимо заполнить фамилию");
            if (String.IsNullOrEmpty(patronymicTextBox.Text))
                throw new Exception("Необходимо заполнить отчество");
            if (String.IsNullOrEmpty(hotelRoomTextBox.Text))
                throw new Exception("Необходимо заполнить гостиничный номер");
            else
                Convert.ToInt16(hotelRoomTextBox.Text);
            if (String.IsNullOrEmpty(cityFromWhichCameTextBox.Text))
                throw new Exception("Необходимо заполнить город");
            if (String.IsNullOrEmpty(arrivalDateTextBox.Text))
                throw new Exception("Необходимо заполнить дату приезда");
            if (String.IsNullOrEmpty(departureDateTextBox.Text))
                throw new Exception("Необходимо заполнить дату отъезда");
        }
    }
}
