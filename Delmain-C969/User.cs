using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delmain_C969
{
    public class User
    {
        public int userID { get; set; }
        public string username { get; set; }

        public virtual bool canDeleteData()
        {
            MessageBox.Show("Error: Data can only be deleted by the admin user.");

            return false;
        }
    }
}
