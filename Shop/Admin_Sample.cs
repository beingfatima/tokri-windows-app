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
    public partial class Admin_Sample : Form
    {
        public Admin_Sample()
        {
            InitializeComponent();
        }

        private void Exit_AdminSample_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminHome Obj_AdminHome = new AdminHome();
            LoadForms.Load_Window(Obj_AdminHome, this);
        }

        private void Seller_AdminSample_Button_Click(object sender, EventArgs e)
        {
            Sellers Obj_Sellers = new Sellers();
            LoadForms.Load_Window(Obj_Sellers, this);
        }

        private void ItemCategories_AdminSample_Button_Click(object sender, EventArgs e)
        {
            ItemCategories Obj_ItemCategories = new ItemCategories();
            LoadForms.Load_Window(Obj_ItemCategories, this);
        }

        private void Item_AdminSample_Button_Click(object sender, EventArgs e)
        {
            Items Obj_Items = new Items();
            LoadForms.Load_Window(Obj_Items, this);
        }

        private void Sells_AdminSample_Button_Click(object sender, EventArgs e)
        {
            Sells Obj_Sells = new Sells();
            LoadForms.Load_Window(Obj_Sells, this);
        }

        private void Logout_AdminSample_Button_Click(object sender, EventArgs e)
        {
            login Obj_login = new login();
            LoadForms.Load_Window(Obj_login, this);
        }

        private void About_AdminSample_Button_Click(object sender, EventArgs e)
        {
            About Obj_About = new About();
            LoadForms.Load_Window(Obj_About, this);
        }

        private void Order_HomeSample_Button_Click(object sender, EventArgs e)
        {
            Orders Obj_Orders = new Orders();
            LoadForms.Load_Window(Obj_Orders, this);
        }

        private void OrderList_HomeSample_Button_Click(object sender, EventArgs e)
        {
            OrderList Obj_OrderList = new OrderList();
            LoadForms.Load_Window(Obj_OrderList, this);
        }
    }
}
