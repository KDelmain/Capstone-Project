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
using System.Globalization;
using System.IO;

namespace Delmain_C969
{
    public partial class Login : Form
    {
        // Control Panel > Region > Formats Tab > Set Format: dropdown menu to Spanish (Mexico)
        public static int currentRegionID = CultureInfo.CurrentCulture.LCID;
        public Login()
        {
            InitializeComponent();

            if (currentRegionID == 2058) //Spanish - Mexico
            {
                formLabel.Text = "Por favor Iniciar sesión";
                usernameLabel.Text = "Nombre de usuario:";
                passwordLabel.Text = "Contraseña:";
                loginButton.Text = "Iniciar sesión";
                exitButton.Text = "Salida";
            }
        }

        public int findUser(string username, string password)
        {
            MySqlConnection con = new MySqlConnection(Program.connectDB);
            con.Open();

            //Using MySqlCommand to prevent SQL Injection - Security Requirement
            MySqlCommand cmd = new MySqlCommand($"SELECT userId FROM user WHERE userName = '{username}' AND password = '{password}'", con);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();

                int userID = (Convert.ToInt32(rdr[0]));

                setUserType(userID);

                CurrentUser.currentUser.userID = (Convert.ToInt32(rdr[0]));
                CurrentUser.currentUser.username = username;

                rdr.Close();
                con.Close();

                return CurrentUser.currentUser.userID;
            }

            return 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try //Exception Handler for Invalid Login
            {
                if (findUser(usernameTB.Text, passwordTB.Text) != 0)
                {
                    logUserLogin(CurrentUser.currentUser.userID);

                    this.Hide();

                    Main Main = new Main();
                    Main.Show();
                }
                else
                {
                    throw new ExceptionHandler();
                }
            }
            catch (ExceptionHandler ex) { ex.invalidLogin(); }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static void logUserLogin(int userID)
        {
            string file = @".\log.text"; //File located in { \\Delmain-C969\Delmain-C969\bin\Debug }
            string log = $"User {userID} logged in at {DateTimeHandler.timestamp()}" + Environment.NewLine;

            using (StreamWriter w = File.AppendText(file))
            {
                w.WriteLine(log);
            }
        }

        public void setUserType(int userID)
        {
            if (userID == 1)
                CurrentUser.currentUser = new AdminUser();
            else
                CurrentUser.currentUser = new User();
        }
    }
}
