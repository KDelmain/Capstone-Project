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
using MySqlX.XDevAPI.Relational;

namespace Delmain_C969
{
    public partial class CustomerRecords : Form
    {
        public static int recordIndex { get; set; } // Keeps track of the selected row in customersDGV
        public static int custID { get; set; } //Holds customerID for selected row for use in UpdateCustomer

        public static string[] cities; //Stores City names for use in Add and Update Customer

        public static string[] custNames; //Stores customer names for search feature

        public CustomerRecords()
        {
            InitializeComponent();

            generateRecords();
            getCities();

            customersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersDGV.DefaultCellStyle.SelectionBackColor = customersDGV.DefaultCellStyle.BackColor;
            customersDGV.DefaultCellStyle.SelectionForeColor = customersDGV.DefaultCellStyle.ForeColor;

            customersDGV.ClearSelection();

            recordIndex = -1;
        }

        /*** DGV Row Selection ***/
        private void customersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recordIndex = customersDGV.CurrentCell.RowIndex;
            customersDGV.DefaultCellStyle.SelectionBackColor = Color.Yellow;
        }

        private void addCustButton_Click(object sender, EventArgs e)
        {
            AddCustomer addCust = new AddCustomer();
            addCust.Show();

            this.Close();

        }

        private void updateCustButton_Click(object sender, EventArgs e)
        {
            if (recordIndex >= 0)
            {
                custID = Convert.ToInt32(customersDGV[0, recordIndex].Value);

                UpdateCustomer updateCust = new UpdateCustomer();
                updateCust.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a customer record to update.");
            }

        }

        private void deleteCustButton_Click(object sender, EventArgs e)
        {
            if(CurrentUser.currentUser.canDeleteData())
            {
                if (recordIndex >= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete the selected customer record? \n\n WARNING: Deleting a customer record will also delete any associated appointments", "Delete Appointment", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        custID = Convert.ToInt32(customersDGV[0, recordIndex].Value);

                        deleteAssocAppointments(custID); //Deletes appointments associated with the customer to be deleted
                        deleteCustomerRecord(custID); //Deletes customer record

                        generateRecords();

                        customersDGV.ClearSelection();
                        recordIndex = -1;
                    }

                }
                else
                {
                    MessageBox.Show("Please select a customer record to delete.");
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void generateRecords()
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT c.customerId AS 'Customer ID', c.customerName AS 'Customer Name', a.phone AS 'Phone Number', a.address AS Address, a.address2 as Address2, ci.city AS City, a.postalCode AS 'Postal Code' FROM address a INNER JOIN customer c ON c.addressId = a.addressId INNER JOIN city ci ON ci.cityId = a.cityId;", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            customersDGV.DataSource = dt;
        }

        private void deleteAssocAppointments(int custID)
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            MySqlCommand cmd = new MySqlCommand($"DELETE FROM appointment WHERE customerId ='{custID}'", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            con.Close();
            customersDGV.DataSource = dt;
        }

        private void deleteCustomerRecord(int custID)
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            MySqlCommand cmd = new MySqlCommand($"DELETE FROM customer WHERE customerId ='{custID}';", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt); 

            customersDGV.DataSource = dt;
        }

        private void getCities()
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT city FROM city", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            cities = dt.AsEnumerable().Select(r => r.Field<string>("city")).ToArray(); //Lambda: Used because it reduces the need for a loop statement to add data
                                                                                            // from the data table to the string array cities 
            con.Close();
        }

        /*** Search Feature ***/

        private void searchButton_Click(object sender, EventArgs e)
        {
            customersDGV.ClearSelection();
            customersDGV.DefaultCellStyle.SelectionBackColor = Color.Yellow;

            bool found = false;
            string custName;

            if (searchTB.Text != "")
            {
                for (int i = 0; i < customersDGV.Rows.Count - 1; i++)
                {
                    custName = customersDGV.Rows[i].Cells[1].Value.ToString();
                    if (custName.ToUpper().Contains(searchTB.Text.ToUpper()))
                    {
                        customersDGV.Rows[i].Selected = true;
                        found = true;
                        recordIndex = i;
                    }
                }
            }
            if (!found)
                MessageBox.Show("No Matches");
        }
    }
}
