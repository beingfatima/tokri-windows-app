using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    class LoadForms
    {
        public static void Load_Window(Form OpenWin, Form CloseWin)
        {
            CloseWin.Hide();
            OpenWin.WindowState = FormWindowState.Normal;
            OpenWin.Show();
        }

    }
}
