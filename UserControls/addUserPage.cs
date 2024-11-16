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
using System.Reflection;

namespace PuntuApp.UserControls
{
    public partial class addUserPage : UserControl
    {
        private NavigationControl navigationControl;
        private string connectionString;
        public addUserPage(NavigationControl navigationControl, string connectionString)
        {
            InitializeComponent();
            this.navigationControl = navigationControl;
            this.connectionString = connectionString;
        }
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    pbPhoto.BackgroundImage = Image.FromFile(filePath);
                    pbPhoto.BackgroundImageLayout = ImageLayout.Zoom; // Adjust layout as needed
                }
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtPassword.Text != txtPassVeri.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string fullName = $"{txtName.Text} {txtPaterno.Text} {txtMaterno.Text}";
            string username = txtUsername.Text;
            string userType = cbUserType.SelectedItem.ToString();
            string password = txtPassword.Text;


            string hashedPassword = password;

            // Convert photo to byte array
            byte[] photo = null;
            if (pbPhoto.BackgroundImage != null)
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    pbPhoto.BackgroundImage.Save(ms, pbPhoto.BackgroundImage.RawFormat);
                    photo = ms.ToArray();
                }
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Usuarios (nombre, username, email, hashedPassword, rol, foto) VALUES (@nombre, @username, @username, @hashedPassword, @rol, @foto)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", fullName);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                        cmd.Parameters.AddWithValue("@rol", userType);
                        cmd.Parameters.AddWithValue("@foto", photo);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User added successfully.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPassVeri.Clear();
            cbUserType.SelectedIndex = 0;
            pbPhoto.BackgroundImage = null;

            pbPhoto.BackgroundImage = Properties.Resources.account_circle_24dp_133E87_FILL0_wght400_GRAD0_opsz24;

            navigationControl.Display(1);
        }
        private void pbPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
