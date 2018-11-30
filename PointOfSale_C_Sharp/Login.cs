using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PointOfSale_C_Sharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // connection variable for the MySQL server
        MySqlConnection con = new MySqlConnection("server=localhost; database=jburgers; username=root; passwd=;");

        // Variable for the login attempt count
        int count;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtuser.Text;
            password = txtpass.Text;

            count += 1;

            if (count > 3)
            {
                // If the login has been attempted more than 3 times, the window will close
                MessageBox.Show("POS System has been blocked", "blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if(username == "" || password == "")
            {
                label4.Text = "Username or Password cannot be blank";
            }
            else
            {
                // Create a string variable to insert into MySqlAdapter for online query
                string query = "SELECT * FROM login WHERE username = '" + username + "' && passwd = '" + password + "' ";
                MySqlDataAdapter data = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                data.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Main main = new Main();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    label4.ForeColor = Color.DarkRed;
                    label4.Text = "Please try again";
                    txtuser.Clear();
                    txtpass.Clear();
                    txtuser.Focus();
                }

            }
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



