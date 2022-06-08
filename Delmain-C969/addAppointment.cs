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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();

            endPicker.Value = endPicker.Value.AddHours(1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(validateForm())
            {
                addAppointment();

                Main main = new Main();
                main.Show();

                Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to cancel? \n Warning: All progress will be lost if you cancel", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Main main = new Main();
                main.Show();

                this.Close();
            }
        }

        /*** Creates new Appointment ID ***/
        public int generateID()
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT MAX(appointmentId) + 1 FROM appointment", con);
            
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<int> idList = new List<int>();
            while (rdr.Read())
            {
                idList.Add(Convert.ToInt32(rdr[0]));
            }

            rdr.Close();
            con.Close();

            return idList[0];
        }

        private bool validateForm()
        {
            bool isValid = true;

            //Checks that all boxes contain a value
            if(string.IsNullOrWhiteSpace(custIDTB.Text) || string.IsNullOrWhiteSpace(typeTB.Text))
            {
                MessageBox.Show("Error: One or more items left blank.");
                isValid = false;
            }
            //check that the customer ID is correct
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM customer WHERE customerId = {custIDTB.Text}", con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            if (!rdr.Read())
            {
                MessageBox.Show("Error: Customer ID does not belong to an existing customer. Please reference the Customer Records page.");
                isValid = false;
            }

            rdr.Close();

            //check that app is not outside business hours (9:00 - 17:00)
            DateTime businessOpen = DateTime.Today.AddHours(9); // 9am
            DateTime businessClose = DateTime.Today.AddHours(17); // 5pm

            DateTime appStart = DateTime.Parse(startPicker.Text);
            DateTime appEnd = DateTime.Parse(endPicker.Text);

            try
            {
                if (appStart.TimeOfDay < businessOpen.TimeOfDay || appStart.TimeOfDay > businessClose.TimeOfDay ||
                appEnd.TimeOfDay < businessOpen.TimeOfDay || appEnd.TimeOfDay > businessClose.TimeOfDay)
                {
                    isValid = false;
                    throw new ExceptionHandler();
                }
            }
            catch (ExceptionHandler ex) { ex.invalidTime(); }

            //Checks that start < end and both are on the same day
            if((appStart.Date.CompareTo(appEnd.Date) != 0) || (appStart.CompareTo(appEnd) >= 0))
            {
                MessageBox.Show("Error: Start time and end time must be on the same day and start time must be before end time.");
                isValid = false;
            }

            //no overlapping appointments per consultant
            cmd = new MySqlCommand("SELECT start, end FROM appointment", con);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            string temp = "";

            for (int i = 0; i < dt.Rows.Count; i++) //Converts the values from UTC to Local
            {
                temp = dt.Rows[i][0].ToString();
                DateTime existingStart = DateTime.Parse(DateTimeHandler.toLocalTime(temp));

                if(appStart.Date.CompareTo(existingStart.Date) == 0)
                {
                    temp = dt.Rows[i][1].ToString();
                    DateTime existingEnd = DateTime.Parse(DateTimeHandler.toLocalTime(temp));

                    if((appStart.TimeOfDay >= existingStart.TimeOfDay && appStart.TimeOfDay <= existingEnd.TimeOfDay) || //Start time during existing app
                        (appEnd.TimeOfDay >= existingStart.TimeOfDay && appEnd.TimeOfDay <= existingEnd.TimeOfDay) || //End time during existing app
                            (appStart.TimeOfDay < existingStart.TimeOfDay && appEnd.TimeOfDay > existingEnd.TimeOfDay)) //Start time before app and end time after app
                    {
                        MessageBox.Show("Error: Entered appointment times conflict with an existing appointment.");
                        isValid = false;
                    }
                }
            }

            return isValid;
        }

        private void addAppointment()
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            int appID = generateID();

            MySqlCommand cmd = new MySqlCommand($"INSERT INTO appointment VALUES ('{appID}', '{custIDTB.Text}', '{CurrentUser.currentUser.userID}', '{"not needed"}', '{"not needed"}', '{"not needed"}', '{"not needed"}', '{typeTB.Text}', '{"not needed"}', '{DateTimeHandler.toUTCTime(startPicker.Text)}', '{DateTimeHandler.toUTCTime(endPicker.Text)}', '{DateTimeHandler.timestamp()}', '{CurrentUser.currentUser.username}', '{DateTimeHandler.timestamp()}', '{CurrentUser.currentUser.username}' )", con);

            if (cmd.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Error: Could not add data to the database.");
            }

            con.Close();
        }


    }
}
