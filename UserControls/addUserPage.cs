using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

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
                    pbPhoto.BackgroundImageLayout = ImageLayout.Zoom;
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
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPaterno.Text) ||
                string.IsNullOrWhiteSpace(txtMaterno.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtPassVeri.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (txtPassword.Text != txtPassVeri.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            string fullName = $"{txtName.Text} {txtPaterno.Text} {txtMaterno.Text}";
            string username = txtUsername.Text;
            string roleName = cbUserType.SelectedItem?.ToString();
            string password = txtPassword.Text;
            byte[] photo = GetPhotoBytes(); // Obtener la foto como byte[]

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction(); // Iniciar transacción

                    // Insertar usuario
                    string userQuery = @"
                INSERT INTO Usuarios (nombre, username, hashedPassword, foto) 
                VALUES (@nombre, @username, @hashedPassword, @foto)";
                    long userId;
                    using (MySqlCommand userCmd = new MySqlCommand(userQuery, connection, transaction))
                    {
                        userCmd.Parameters.AddWithValue("@nombre", fullName);
                        userCmd.Parameters.AddWithValue("@username", username);
                        userCmd.Parameters.AddWithValue("@hashedPassword", password);
                        userCmd.Parameters.AddWithValue("@foto", photo);

                        userCmd.ExecuteNonQuery();
                        userId = userCmd.LastInsertedId; // Obtener el ID del usuario creado
                    }

                    // Obtener ID del rol
                    string roleQuery = "SELECT idRol FROM Roles WHERE nombreRol = @roleName";
                    long roleId;
                    using (MySqlCommand roleCmd = new MySqlCommand(roleQuery, connection, transaction))
                    {
                        roleCmd.Parameters.AddWithValue("@roleName", roleName);
                        object result = roleCmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("El rol seleccionado no existe.");
                            transaction.Rollback();
                            return;
                        }
                        roleId = Convert.ToInt64(result);
                    }

                    // Asignar usuario al rol
                    string userRoleQuery = @"
                INSERT INTO Usuarios_Roles (idUsuario, idRol) 
                VALUES (@idUsuario, @idRol)";
                    using (MySqlCommand userRoleCmd = new MySqlCommand(userRoleQuery, connection, transaction))
                    {
                        userRoleCmd.Parameters.AddWithValue("@idUsuario", userId);
                        userRoleCmd.Parameters.AddWithValue("@idRol", roleId);

                        userRoleCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Usuario agregado correctamente.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private byte[] GetPhotoBytes()
        {
            if (pbPhoto.BackgroundImage == null) return null;

            using (var ms = new System.IO.MemoryStream())
            {
                pbPhoto.BackgroundImage.Save(ms, pbPhoto.BackgroundImage.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
