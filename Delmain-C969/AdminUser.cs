using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delmain_C969
{
    class AdminUser : User
    {
        public override bool canDeleteData()
        {
            return true;
        }

    }
}
