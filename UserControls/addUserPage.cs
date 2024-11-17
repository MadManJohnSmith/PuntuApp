using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using PuntuApp.Helpers;

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

            // Datos del usuario
            string fullName = $"{txtName.Text} {txtPaterno.Text} {txtMaterno.Text}";
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string roleName = cbUserType.SelectedItem?.ToString();
            byte[] photo = GetPhotoBytes(); // Obtener la foto como byte[]

            try
            {
                // Crear una instancia de DatabaseHelper
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

                // Agregar usuario
                long userId = dbHelper.AddUser(fullName, username, password, photo);
                if (userId == -1)
                {
                    MessageBox.Show("Error al agregar el usuario.");
                    return;
                }

                // Obtener ID del rol
                long roleId = dbHelper.GetRoleId(roleName);
                if (roleId == -1)
                {
                    MessageBox.Show("El rol seleccionado no existe.");
                    return;
                }

                // Asignar el rol al usuario
                bool roleAssigned = dbHelper.AssignRoleToUser(userId, roleId);
                if (!roleAssigned)
                {
                    MessageBox.Show("Error al asignar el rol al usuario.");
                    return;
                }

                MessageBox.Show("Usuario agregado correctamente.");
                btnCancelar_Click(sender, e); // Limpiar el formulario y regresar a la página anterior
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
