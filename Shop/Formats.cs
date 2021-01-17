using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna;
using Guna.UI.WinForms;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu;

namespace Shop
{
    class Formats
    {
        public static void Guna_Button_Color(GunaButton Button)
        {
            Button.BaseColor = Color.SteelBlue;
        }

        public static void Bunifu_Label_Text(BunifuCustomLabel label,string Text)
        {
            label.Text = Text;
            label.ForeColor = Color.White;
        }
    }
}
