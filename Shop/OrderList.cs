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
    public partial class OrderList : Admin_Sample
    {
        public OrderList()
        {
            InitializeComponent();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            OrderList_HomeSample_Button.BaseColor = Color.SteelBlue;
        }

        private void ItemsCategories_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CreateOrder_OrderListForm_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create Order");
        }
    }
}
