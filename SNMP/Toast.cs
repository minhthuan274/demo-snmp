using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNMP
{
    class Toast
    {
        public Toast()
        {

        }

        public void ShowAlert(string message)
        {
            MessageBox.Show(message);
        }
    }
}
