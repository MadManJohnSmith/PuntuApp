using MySql.Data.MySqlClient;
using PuntuApp.Helpers;
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
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Utiliza un usuario de la aplicación con permisos para autenticar
            string appConnectionString = "server=localhost;database=puntuapp;uid=appUser;pwd=appPassword;";
            DatabaseHelper dbHelper = new DatabaseHelper(appConnectionString);

            int loggedInUserId = dbHelper.AuthenticateUser(username, password);

            if (loggedInUserId >= 0)
            {
                string userConnectionString = $"server=localhost;database=puntuapp;uid={username};pwd={password};";
                this.Hide();
                MainPage home = new MainPage(userConnectionString, loggedInUserId);
                home.Show();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado o credenciales incorrectas.");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
