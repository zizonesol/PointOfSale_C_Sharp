using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_C_Sharp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseConfirm close = new CloseConfirm();
            close.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new PointOfSale_C_Sharp.Login();
            /*
            LogoutConfirm logout = new PointOfSale_C_Sharp.LogoutConfirm();
            logout.Show();
            */

            this.Close();
            login.Show();

            /*
            if (logout.yesBttnwasClicked)
            {
                this.Close();
                login.Show();
            }
            */

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void togoBttn_Click(object sender, EventArgs e)
        {
            FoodItem item = new FoodItem();
            item.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
