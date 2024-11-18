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
                    pbPhoto.Image = Image.FromFile(filePath);
                    pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar el formulario
            txtName.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPassVeri.Clear();
            cbUserType.SelectedIndex = 0;
            pbPhoto.BackgroundImage = Properties.Resources.account_circle_24dp_133E87_FILL0_wght400_GRAD0_opsz24;

            // Regresar a la página de empleados
            navigationControl.Display(1);

            // Actualizar la tabla de empleados
            var employeesPage = navigationControl.GetControl<EmployeesPage>(1);
            employeesPage.LoadEmployees();
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
            byte[] photo = GetPhotoBytes();

            try
            {
                // Crear usuario en base de datos
                DatabaseHelper dbHelper = new DatabaseHelper(connectionString);
                long userId = dbHelper.AddUser(fullName, username, password, photo);
                if (userId == -1)
                {
                    MessageBox.Show("Error al agregar el usuario.");
                    return;
                }

                // Obtener ID del rol y asignar al usuario
                long roleId = dbHelper.GetRoleId(roleName);
                if (roleId == -1)
                {
                    MessageBox.Show("El rol seleccionado no existe.");
                    return;
                }

                bool roleAssigned = dbHelper.AssignRoleToUser(userId, roleId);
                if (!roleAssigned)
                {
                    MessageBox.Show("Error al asignar el rol al usuario.");
                    return;
                }

                // Crear usuario MySQL con privilegios según el rol
                bool mysqlUserCreated = dbHelper.CreateMySQLUser(username, password, roleName);
                if (!mysqlUserCreated)
                {
                    MessageBox.Show("Error al crear el usuario MySQL.");
                    return;
                }

                MessageBox.Show("Usuario agregado correctamente.");

                // Actualizar la tabla de empleados
                btnCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private byte[] GetPhotoBytes()
        {
            if(pbPhoto.Image == null) return null;

            using (var ms = new System.IO.MemoryStream())
            {
                pbPhoto.Image.Save(ms, pbPhoto.Image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
