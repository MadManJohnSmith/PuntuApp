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

namespace PuntuApp.UserControls
{
    public partial class editUserPage : UserControl
    {
        private NavigationControl navigationControl;
        private string connectionString;
        private DatabaseHelper dbHelper;
        private int userId;
        private bool isEditing = false;
        private int loggedInUserId;
        public editUserPage(NavigationControl navigationControl, string connectionString, int loggedInUserId)
        {
            InitializeComponent();
            this.navigationControl = navigationControl;
            this.connectionString = connectionString;
            this.dbHelper = new DatabaseHelper(connectionString);
            this.loggedInUserId = loggedInUserId;
            cbUserType.SelectedIndex = 0;
        }
        public void SetUserData(int userId)
        {
            this.userId = userId;
            isEditing = true;

            DataRow userRow = dbHelper.GetUserById(userId);

            if (userRow != null)
            {

                txtName.Text = userRow["nombre"].ToString();

                txtUsername.Text = userRow["username"].ToString();

                string roleName = dbHelper.GetUserRole(userId);
                cbUserType.SelectedItem = roleName ?? "Empleado";

                if (userRow["foto"] != DBNull.Value)
                {
                    byte[] photoBytes = (byte[])userRow["foto"];
                    using (var ms = new MemoryStream(photoBytes))
                    {
                        pbPhoto.BackgroundImage = Image.FromStream(ms);
                        pbPhoto.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                }
                else
                {
                    pbPhoto.BackgroundImage = Properties.Resources.account_circle_24dp_1B1925_FILL0_wght400_GRAD0_opsz241;
                }
            }
            else
            {
                MessageBox.Show("No se pudo obtener los datos del usuario.");
            }
        }
        public void ClearForm()
        {
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPassVeri.Clear();
            cbUserType.SelectedIndex = 0;
            pbPhoto.BackgroundImage = Properties.Resources.account_circle_24dp_1B1925_FILL0_wght400_GRAD0_opsz241;

            isEditing = false;
            userId = 0;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearForm();
            navigationControl.Display(1);
            var employeesPage = navigationControl.GetControl<EmployeesPage>(1);
            employeesPage.LoadEmployees();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (isEditing && userId >= 0)
            {
                if (userId == loggedInUserId)
                {
                    MessageBox.Show("No se puede eliminar el usuario que está actualmente conectado.");
                    return;
                }

                var result = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool deleted = dbHelper.DeleteUser(userId);
                        if (!deleted)
                        {
                            MessageBox.Show("Error al eliminar el usuario.");
                            return;
                        }
                        MessageBox.Show("Usuario eliminado correctamente.");

                        btnCancelar_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay usuario seleccionado para eliminar.");
            }
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
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Los campos de nombre y nombre de usuario son obligatorios.");
                return;
            }

            try
            {
                string fullName = txtName.Text;
                string username = txtUsername.Text;
                string roleName = cbUserType.SelectedItem?.ToString();
                byte[] photo = GetPhotoBytes();

                if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text != txtPassVeri.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden o están vacías.");
                    return;
                }
                string password = txtPassword.Text;


                if (isEditing)
                {
                    bool updated = dbHelper.UpdateUser(userId, fullName, username, password, photo);
                    if (!updated)
                    {
                        MessageBox.Show("Error al actualizar el usuario.");
                        return;
                    }

                    long roleId = dbHelper.GetRoleId(roleName);
                    if (roleId == -1)
                    {
                        MessageBox.Show("El rol seleccionado no existe.");
                        return;
                    }
                    bool roleUpdated = dbHelper.UpdateUserRole(userId, roleId);
                    if (!roleUpdated)
                    {
                        MessageBox.Show("Error al actualizar el rol del usuario.");
                        return;
                    }

                    MessageBox.Show("Usuario actualizado correctamente.");
                }
                else
                {

                    long newUserId = dbHelper.AddUser(fullName, username, password, photo);
                    if (newUserId == -1)
                    {
                        MessageBox.Show("Error al agregar el usuario.");
                        return;
                    }

                    long roleId = dbHelper.GetRoleId(roleName);
                    if (roleId == -1)
                    {
                        MessageBox.Show("El rol seleccionado no existe.");
                        return;
                    }
                    bool roleAssigned = dbHelper.AssignRoleToUser(newUserId, roleId);
                    if (!roleAssigned)
                    {
                        MessageBox.Show("Error al asignar el rol al usuario.");
                        return;
                    }

                    MessageBox.Show("Usuario agregado correctamente.");
                }

                isEditing = false;
                userId = 0;
                btnCancelar_Click(sender, e);
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
