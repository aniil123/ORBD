using HotelAdministration.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAdministration
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FormClosing += MainForm_Closing;
            FormClosed += MainForm_Closed;
            exitToolStripMenuItem.Click += Exit;
            contextExitToolStripMenuItem.Click += Exit;
            exitToolStripButton.Click += Exit;
            aboutProgramToolStripMenuItem.Click += AboutProgram;
            contextAboutProgramToolStripMenuItem.Click += AboutProgram;
            aboutProgramToolStripButton.Click += AboutProgram;
            hotelRoomToolStripMenuItem.Click += ShowHotelRoom;
            contextHotelRoomToolStripMenuItem.Click += ShowHotelRoom;
            clientToolStripMenuItem.Click += ShowClient;
            contextClientToolStripMenuItem.Click += ShowClient;
            employeeToolStripMenuItem.Click += ShowEmployee;
            contextEmployeeToolStripMenuItem.Click += ShowEmployee;
            scheduleToolStripMenuItem.Click += ShowSchedule;
            contextScheduleToolStripMenuItem.Click += ShowSchedule;
            reportToolStripMenuItem.Click += ShowReport;
            contextReportToolStripMenuItem.Click += ShowReport;
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы действительно желаете закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutProgram(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КСУП, Иванов Даниил Викторович, 573-1, 2025", "О программе");
        }

        private void ShowHotelRoom(object sender, EventArgs e)
        {
            ShowForm(HotelRoomForm.Instance);
        }

        private void ShowClient(object sender, EventArgs e)
        {
            ShowForm(ClientForm.Instance);
        }

        private void ShowEmployee(object sender, EventArgs e)
        {
            ShowForm(EmployeeForm.Instance);
        }

        private void ShowSchedule(object sender, EventArgs e)
        {
            ShowForm(ScheduleForm.Instance);
        }

        private void ShowReport(object sender, EventArgs e)
        {
            ShowForm(ReportForm.Instance);
        }

        private void ShowForm(Form form)
        {
            form.Show();
            form.Activate();
        }
    }
}
