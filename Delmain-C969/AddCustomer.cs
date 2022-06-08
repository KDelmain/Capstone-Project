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
    public partial class AddCustomer : Form
    {
        int addressID = 0;
        public AddCustomer()
        {
            InitializeComponent();

            foreach(string city in CustomerRecords.cities) //Populates the city combo box
            {
                cityCB.Items.Add(city);
            }
        }

        /*** Adds the address to the adress table, then adds the customer to the customer table ***/
        private void addButton_Click(object sender, EventArgs e)
        {
            if(validateForm())
            {
                addAddress();
                addCustomer();

                CustomerRecords custRec = new CustomerRecords();
                custRec.Show();

                Close();
            }
        }

        /*** Back Button ***/
        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to cancel? \n Warning: All progress will be lost if you cancel", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CustomerRecords custRec = new CustomerRecords();
                custRec.Show();

                this.Close();
            }
        }

        /*** Confirms the form fields contain valid data ***/
        private bool validateForm() 
        {
            bool isValid = true;

            // Checks that all boxes contain a value
            if (string.IsNullOrWhiteSpace(nameTB.Text) || string.IsNullOrWhiteSpace(phoneTB.Text) || string.IsNullOrWhiteSpace(addressTB.Text) || cityCB.SelectedIndex == -1 || string.IsNullOrWhiteSpace(postalTB.Text))
            {
                MessageBox.Show("Error: One or more items left blank.");
                isValid = false;
            }

            int postal;
            Int32.TryParse(postalTB.Text, out postal);

            // Checks that the postal code is valid (5 digits)
            if (postal < 10000 || postal > 99999)
            {
                MessageBox.Show("Error: Invalid Postal Code.");
                isValid = false;
            }

            int phoneValue;
            Int32.TryParse(phoneTB.Text, out phoneValue);

            // Checks that the phone number is valid
            if (phoneValue < 1000000 || phoneValue > 9999999)
            {
                MessageBox.Show("Error: Invalid phone number. \n\n(Required Format: xxxxxxx)");
                isValid = false;
            }

            return isValid;
        }

        /*** Adds the address to the address table ***/
        private void addAddress()
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            addressID = generateID("address");
            int city = cityCB.SelectedIndex + 1;

            var phone = new StringBuilder();
            int count = 0;
            foreach (var c in phoneTB.Text)
            {
                phone.Append(c);
                if ((++count) == 3)
                {
                    phone.Append('-');
                }
            }

            MySqlCommand cmd = new MySqlCommand($"INSERT INTO address VALUES ('{addressID}', '{addressTB.Text}','{address2TB.Text}','{city}','{postalTB.Text}','{phone.ToString()}', '{DateTimeHandler.timestamp()}', '{CurrentUser.currentUser.username}', '{DateTimeHandler.timestamp()}', '{CurrentUser.currentUser.username}' )", con);
            
            if (cmd.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Error: Could not add data to the database.");
            }

            con.Close();
        }

        /*** Adds the customer to the customer table ***/
        private void addCustomer()
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

             int custID = generateID("customer");

            MySqlCommand cmd = new MySqlCommand($"INSERT INTO customer VALUES ('{custID}', '{nameTB.Text}','{addressID}', 1, '{DateTimeHandler.timestamp()}', '{CurrentUser.currentUser.username}', '{DateTimeHandler.timestamp()}', '{CurrentUser.currentUser.username}' )", con);
            
            if (cmd.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Error: Could not add data to the database.");
            }

            con.Close();

        }

        /*** Creates new Primary Key for the specified table ***/
        public int generateID(string table)
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT MAX({table}Id) + 1 FROM {table}", con);
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

    }
}
