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
    public partial class AdminHome : Sample
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            UserName_Label.Text = "Tokri";
        }

        private void Exit_AdminHomeForm_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sellers_AdminHomeForm_Button_Click(object sender, EventArgs e)
        {
            Sellers Obj_Sellers = new Sellers();
            LoadForms.Load_Window(Obj_Sellers, this);
        }

        private void ItemCategories_AdminHomeForm_Button_Click(object sender, EventArgs e)
        {
            ItemCategories Obj_ItemCategories = new ItemCategories();
            LoadForms.Load_Window(Obj_ItemCategories, this);
        }

        private void Items_AdminHomeForm_Button_Click(object sender, EventArgs e)
        {
            Items Obj_Items = new Items();
            LoadForms.Load_Window(Obj_Items, this);
        }

        private void Sells_AdminHomeForm_Button_Click(object sender, EventArgs e)
        {
            Sells Obj_Sells = new Sells();
            LoadForms.Load_Window(Obj_Sells, this);
        }

        private void Logout_AdminHomeForm_Button_Click(object sender, EventArgs e)
        {
            login obj_login = new login();
            LoadForms.Load_Window(obj_login, this);
        }

        private void Order_AdminHomeForm_Button_Click(object sender, EventArgs e)
        {
            Orders Obj_Orders = new Orders();
            LoadForms.Load_Window(Obj_Orders, this);
        }

        private void Orderlist_AdminHomeForm_Button_Click(object sender, EventArgs e)
        {
            OrderList Obj_OrderList = new OrderList();
            LoadForms.Load_Window(Obj_OrderList, this);
        }
    }
}
