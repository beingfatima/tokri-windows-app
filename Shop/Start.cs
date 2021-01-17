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
    public partial class Start : Form
    {
        //Start Window Form Initialization of components
        public Start()
        {
            InitializeComponent();
        }

        //Initialization of variables
        int startpoint = 0;

        //Event for counter of Timer
        private void progressbar_startform_timer_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Startform_Progressbar.Value = startpoint;
            if (Startform_Progressbar.Value == 100)
            {
                Startform_Progressbar.Value = 0;
                progressbar_startform_timer.Stop();
                login login_form = new login();
                this.Hide();
                login_form.Show();
            }
        }

        //Start Window Form Load function
        private void Start_Load(object sender, EventArgs e)
        {
            progressbar_startform_timer.Start();
        }
    }
}
