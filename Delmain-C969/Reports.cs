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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }


        /*** Radio Button Events ***/
        private void schedulesRB_CheckedChanged(object sender, EventArgs e)
        {
            generateReport();
            reportDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void appsPerDayRB_CheckedChanged(object sender, EventArgs e)
        {
            generateReport();
            reportDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void appTypeRB_CheckedChanged(object sender, EventArgs e)
        {
            generateReport();
            reportDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*** Generate Report and Populate DGV ***/
        private void generateReport()
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            string query = "";

            if (schedulesRB.Checked) //Schedule for each consultant
            {
                query = "SELECT userId AS Consultant, DATE_FORMAT(start, \'%Y-%c-%d %T\') AS 'Start Time', DATE_FORMAT(end, \'%Y-%c-%d %T\') AS 'End Time', appointmentId AS 'Appointment ID', type AS 'Type' FROM appointment ORDER BY userId, start";
            }
            else if (appsPerDayRB.Checked) //Number of appointments per day
            {
                query = "SELECT DATE_FORMAT(start, \"%c/%e/%y\") AS Date, count(*) as 'Total Appointments' FROM appointment GROUP BY DATE_FORMAT(start, \"%c/%e/%y\")";
            }
            else if (appTypeRB.Checked) //Number of each type of appointment per month
            {
                query = "SELECT DATE_FORMAT(start, \"%b %Y\") AS Month, type as 'Appointment Type', count(*) as 'Total this Month' FROM appointment GROUP BY DATE_FORMAT(start, \"%b %Y\"), type ORDER BY DATE_FORMAT(start, \"%b %Y\") DESC";
            }

            MySqlCommand cmd = new MySqlCommand(query, con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            if (schedulesRB.Checked)
            {
                string[] startTimes = dt.AsEnumerable().Select(r => r.Field<string>("Start Time")).ToArray(); //Lambda: Used here because it allows me to fill both arrays with only
                string[] endTimes = dt.AsEnumerable().Select(r => r.Field<string>("End Time")).ToArray();       // two lines rather than needing to use a loop

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i][1] = DateTimeHandler.toLocalTime(startTimes[i]);
                    dt.Rows[i][2] = DateTimeHandler.toLocalTime(endTimes[i]);
                }
            }

            reportDGV.DataSource = dt;
        }
    }
}
