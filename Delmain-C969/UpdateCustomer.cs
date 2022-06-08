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
    public partial class UpdateCustomer : Form
    {
        private static int addressID { get; set; }
        public UpdateCustomer()
        {
            InitializeComponent();

            foreach (string city in CustomerRecords.cities) //Populates the city combo box
            {
                cityCB.Items.Add(city);
            }

            fillForm();

        }

        /*** Updates the address to the adress table, then adds the customer to the customer table ***/
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                updateAddress();
                updateCustomer();

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

        /*** Updates address in the address table ***/
        private void updateAddress()
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

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

            MySqlCommand cmd = new MySqlCommand($"UPDATE address SET address = '{addressTB.Text}', address2 = '{address2TB.Text}', cityId = '{city}', postalCode = '{postalTB.Text}', phone = '{phone.ToString()}', lastUpdate = '{DateTimeHandler.timestamp()}', lastUpdateBy = '{CurrentUser.currentUser.username}' WHERE addressId = '{addressID}'", con);

            if (cmd.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Error: Could not add data to the database.");
            }

            con.Close();
        }

        /*** Updates customer record in customer table ***/
        private void updateCustomer()
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            MySqlCommand cmd = new MySqlCommand($"UPDATE customer SET customerName = '{nameTB.Text}', lastUpdate = '{DateTimeHandler.timestamp()}', lastUpdateBy = '{CurrentUser.currentUser.username}' WHERE customerId = '{CustomerRecords.custID}'", con);

            if (cmd.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Error: Could not add data to the database.");
            }

            con.Close();

        }

        private void fillForm()
        {
            nameTB.Text = getCustTableData();

            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT address, address2, cityId, postalCode, phone FROM address WHERE addressId = {addressID}", con);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<string> dataList = new List<string>();
            while (rdr.Read())
            {
                dataList.Add(Convert.ToString(rdr[0])); //address
                dataList.Add(Convert.ToString(rdr[1])); //address2
                dataList.Add(Convert.ToString(rdr[2])); //cityId
                dataList.Add(Convert.ToString(rdr[3])); //postal
                dataList.Add(Convert.ToString(rdr[4])); //phone
            }

            rdr.Close();
            con.Close();

            String phone = new String(dataList[4].Where(ch => Char.IsLetterOrDigit(ch)).ToArray()); //Removes dash from phone number

            phoneTB.Text = phone;
            addressTB.Text = dataList[0];
            address2TB.Text = dataList[1];
            cityCB.SelectedIndex = Convert.ToInt32(dataList[2]) - 1;
            postalTB.Text = dataList[3];
        }

        private string getCustTableData()
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT addressId, customerName FROM customer WHERE customerId = {CustomerRecords.custID}", con);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<string> idList = new List<string>();
            while (rdr.Read())
            {
                idList.Add(Convert.ToString(rdr[0])); //addressId
                idList.Add(Convert.ToString(rdr[1])); //customer name
            }

            rdr.Close();
            con.Close();

            addressID = (Convert.ToInt32(idList[0]));

            return idList[1];
        }
    }
}
