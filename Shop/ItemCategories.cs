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
    public partial class ItemCategories : Admin_Sample
    {
        public ItemCategories()
        {
            InitializeComponent();
        }

        private void ItemCategories_Load(object sender, EventArgs e)
        {
            Formats.Guna_Button_Color(ItemCategories_AdminSample_Button);
        }
    }
}
