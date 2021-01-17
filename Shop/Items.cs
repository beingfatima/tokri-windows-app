using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Items : Admin_Sample
    {
        public Items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            Formats.Guna_Button_Color(Item_AdminSample_Button);
            Barcode_ItemsForm_Textbox.Enabled = false;
            Barcode_ItemsForm_Textbox.ForeColor = Color.Silver;
        }
    }
}
