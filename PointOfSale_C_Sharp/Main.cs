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
            this.Hide();
            login.Show();
        }
    }
}
