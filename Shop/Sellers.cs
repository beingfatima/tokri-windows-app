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
    public partial class Sellers : Admin_Sample
    {
        public Sellers()
        {
            InitializeComponent();
        }
        int Pass_Check = 0;

        private void Sellers_Load(object sender, EventArgs e)
        {
            Formats.Guna_Button_Color(Seller_AdminSample_Button);
            //Formats.Bunifu_Label_Text(FormName_Label, "Sellers");
        }

        private void Password_SellersForm_Textbox_OnValueChanged(object sender, EventArgs e)
        {
            Password_SellersForm_Textbox.isPassword = true;
        }

        private void ConfirmPassword_SellersForm_Textbox_OnValueChanged(object sender, EventArgs e)
        {
            ConfirmPassword_SellersForm_Textbox.isPassword = true;
        }

        private void ShowPassword_SellersForm_Label_Click(object sender, EventArgs e)
        {
            if(Pass_Check == 0)
            {
                Password_SellersForm_Textbox.isPassword = false;
                ConfirmPassword_SellersForm_Textbox.isPassword = false;
                Pass_Check++;
            }
            else
            {
                Pass_Check--;
                Password_SellersForm_Textbox.isPassword = true;
                ConfirmPassword_SellersForm_Textbox.isPassword = true;
            }
        }
    }
}
