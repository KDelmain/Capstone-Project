using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delmain_C969
{
    static class Program
    {
        public static string connectDB = "server=sql5.freemysqlhosting.net;database=sql5473620;uid=sql5473620;pwd=mvWGnusv7Z;";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
