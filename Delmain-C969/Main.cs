using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Delmain_C969
{
    public partial class Main : Form
    {
        public static int calendarIndex { get; set; } //Keeps track of the selected row in calendarDGV
        public static int appID { get; set; } //Holds customerID for selected row for use in UpdateCustomer

        public Main()
        {
            InitializeComponent();

            weekAppsRB.Checked = true;

            appReminder();

            calendarDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            calendarDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            calendarDGV.DefaultCellStyle.SelectionBackColor = calendarDGV.DefaultCellStyle.BackColor;
            calendarDGV.DefaultCellStyle.SelectionForeColor = calendarDGV.DefaultCellStyle.ForeColor;

            calendarDGV.ClearSelection();

            calendarIndex = -1;
        }


        /*** Radio Button Events ***/
        private void weekAppsRB_CheckedChanged(object sender, EventArgs e)
        {
            generateCalendar();
        }

        private void monthAppsRB_CheckedChanged(object sender, EventArgs e)
        {
            generateCalendar();
        }

        /*** Add Appointment ***/
        private void addAppButton_Click(object sender, EventArgs e)
        {
            AddAppointment addApp = new AddAppointment();
            addApp.Show();

            this.Close();
        }

        /*** Update Appointment ***/
        private void updateAppButton_Click(object sender, EventArgs e)
        {
            if (calendarIndex >= 0)
            {
                appID = Convert.ToInt32(calendarDGV[0, calendarIndex].Value);

                UpdateAppointment updateApp = new UpdateAppointment();
                updateApp.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an appointment to update.");
            }
        }

        /*** Delete Appointment ***/
        private void deleteAppButton_Click(object sender, EventArgs e)
        {
            if (calendarIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete the selected appointment?", "Delete Appointment", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int appID = Convert.ToInt32(calendarDGV[0, calendarIndex].Value); 

                    MySqlConnection con = new MySqlConnection(Program.connectDB);
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand($"DELETE FROM appointment WHERE appointmentId ='{appID}'", con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    calendarDGV.DataSource = dt;
                    generateCalendar();

                }

            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }

            calendarDGV.ClearSelection();
            calendarIndex = -1;
        }

        /*** DGV Row Selection ***/
        private void calendarDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            calendarIndex = calendarDGV.CurrentCell.RowIndex;
            calendarDGV.DefaultCellStyle.SelectionBackColor = Color.Yellow;
        }

        /*** Open Customer Records Form ***/
        private void custRecordsButton_Click(object sender, EventArgs e)
        {
            CustomerRecords custRecs = new CustomerRecords();
            custRecs.Show();
        }

        /*** Open Reports Form ***/
        private void reportsButton_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        /*** Logout of Application ***/
        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to logout?", "Exit Application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /*** Fills in the Calendar DGV and updates when a radio button is clicked ***/
        private void generateCalendar()
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            string query = "";
            
            if (weekAppsRB.Checked)
            {
                query = $"SELECT a.appointmentId AS 'Appointment ID', a.type AS Type, DATE_FORMAT(a.start, \'%Y-%c-%d %T\') AS 'Start Time', DATE_FORMAT(a.end, \'%Y-%c-%d %T\') AS 'End Time', c.customerName AS 'Customer Name' FROM appointment a INNER JOIN customer c USING(customerId) WHERE YEARWEEK(start, 1) = YEARWEEK(CURRENT_DATE(), 1) AND a.userid = '{CurrentUser.currentUser.userID}' ORDER BY start, 'Start Time'";
            }
            else if (monthAppsRB.Checked)
            {
                query = $"SELECT a.appointmentId AS 'Appointment ID', a.type AS Type, DATE_FORMAT(a.start, \'%Y-%c-%d %T\') AS 'Start Time', DATE_FORMAT(a.end, \'%Y-%c-%d %T\') AS 'End Time', c.customerName AS 'Customer Name' FROM appointment a INNER JOIN customer c USING(customerId) WHERE MONTH(start) = MONTH(CURRENT_DATE()) AND YEAR(start) = YEAR(CURRENT_DATE()) AND a.userid = '{CurrentUser.currentUser.userID}' ORDER BY start, 'Start Time'";
            }

            MySqlCommand cmd = new MySqlCommand(query, con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            /*** Convert the Start and End rows from UTC to Local ***/
            string[] startTimes = dt.AsEnumerable().Select(r => r.Field<string>("Start Time")).ToArray(); //Lambda: Used here because it allows me to fill both arrays with only
            string[] endTimes = dt.AsEnumerable().Select(r => r.Field<string>("End Time")).ToArray();       // two lines rather than needing to use a loop

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][2] = DateTimeHandler.toLocalTime(startTimes[i]);
                dt.Rows[i][3] = DateTimeHandler.toLocalTime(endTimes[i]);
            }

            con.Close();

            calendarDGV.DataSource = dt;
        }

        private void appReminder()
        {
            DateTime now = DateTime.Now; //Gets Current Local Time
            DateTime existingApp;
            string temp = "";

            if(calendarDGV.Rows.Count > 0 && calendarDGV[2, 0].Value != null)
            {
                for(int i = 0; i < calendarDGV.Rows.Count - 1; i++)
                {
                    temp = Convert.ToString(calendarDGV[2, i].Value);

                    existingApp = DateTime.Parse(temp);

                    if(now.Date.CompareTo(existingApp.Date) == 0) //If appointments are on the same day
                    {
                        TimeSpan nowToApp = now - existingApp;

                        if (nowToApp.TotalMinutes >= -15 && nowToApp.TotalMinutes < 1)
                        {
                            MessageBox.Show($"Reminder: You have a meeting with {Convert.ToString(calendarDGV[6, i].Value)} at {existingApp.TimeOfDay}");
                        }
                    }
                }

            }
        }

    }
}
