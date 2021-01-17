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
    public partial class login : Form
    {
        //Login Window Form Initialization of components
        public login()
        {
            InitializeComponent();
        }

        //Login Window Form Load function
        private void login_Load(object sender, EventArgs e)
        {

        }

        //Cross Label event to close application
        private void Cross_Loginform_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Clear label event to clear username and password
        private void Clear_Loginform_Label_Click(object sender, EventArgs e)
        {
            Username_Loginform_textbox.Text = "";
            Password_Loginform_textbox.Text = "";
        }

        //Logo Button Event
        private void Logo_CircleButton_Click(object sender, EventArgs e)
        {

        }

        //login Button Event
        private void login_button_Click(object sender, EventArgs e)
        {
            AdminHome Obj_AdminHome = new AdminHome();
            LoadForms.Load_Window(Obj_AdminHome, this);
        }
    }
}
