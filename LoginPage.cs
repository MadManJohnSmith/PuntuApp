using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntuApp
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=puntuapp;uid=" + txtUsername.Text + ";pwd=" + txtPassword.Text + ";";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    this.Hide();
                    MainPage home = new MainPage();
                    home.Show();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
