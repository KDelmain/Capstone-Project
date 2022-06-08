using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Delmain_C969
{
    class ExceptionHandler : ApplicationException
    {
        public void invalidLogin()
        {
            if (Login.currentRegionID == 2058)
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta.");
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }
        public void invalidTime()
        {
            MessageBox.Show("Error: Appointments can only be scheduled during normal business hours.");
        }

        public void failedDBConnection()
        {
            MessageBox.Show("Unable to connect to the database.");
        }
    }
}
