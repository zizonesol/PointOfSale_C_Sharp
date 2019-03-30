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
    public partial class LogoutConfirm : Form
    {
        public bool yesBttnwasClicked;

        public LogoutConfirm()
        {
            InitializeComponent();
        }

        private void noBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YesButtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (f.Name != "Login")
                    {
                        f.Close();
                        new Login().Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
