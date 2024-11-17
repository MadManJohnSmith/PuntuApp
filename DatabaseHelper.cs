using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PuntuApp.Helpers
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Agrega un usuario nuevo a la base de datos
        public long AddUser(string fullName, string username, string hashedPassword, byte[] photo)
        {
            string query = @"
                INSERT INTO Usuarios (nombre, username, hashedPassword, foto) 
                VALUES (@nombre, @username, @hashedPassword, @foto)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", fullName);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                        cmd.Parameters.AddWithValue("@foto", photo);

                        cmd.ExecuteNonQuery();
                        return cmd.LastInsertedId; // Retorna el ID del usuario recién creado
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al agregar usuario: " + ex.Message);
                    return -1; // Indica un fallo
                }
            }
        }
        //Verifica si un rol existe en la base de datos
        public long GetRoleId(string roleName)
        {
            string query = "SELECT idRol FROM Roles WHERE nombreRol = @roleName";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@roleName", roleName);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt64(result);
                        }
                        else
                        {
                            MessageBox.Show("Rol no encontrado: " + roleName);
                            return -1;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al obtener ID del rol: " + ex.Message);
                    return -1;
                }
            }
        }
        //Asigna un rol a un usuario en la tabla Usuarios_Roles
        public bool AssignRoleToUser(long userId, long roleId)
        {
            string query = @"
                INSERT INTO Usuarios_Roles (idUsuario, idRol) 
                VALUES (@userId, @roleId)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@roleId", roleId);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al asignar rol: " + ex.Message);
                    return false;
                }
            }
        }
        //Devuelve una lista de empleados con información básica
        public DataTable GetUsers()
        {
            DataTable dataTable = new DataTable();
            string query = @"
                SELECT 
                    Usuarios.idUsuario AS ID, 
                    Usuarios.nombre AS Nombre, 
                    Usuarios.username AS Username,
                    Roles.nombreRol AS Rol
                FROM Usuarios
                LEFT JOIN Usuarios_Roles ON Usuarios.idUsuario = Usuarios_Roles.idUsuario
                LEFT JOIN Roles ON Usuarios_Roles.idRol = Roles.idRol
                ORDER BY Usuarios.idUsuario";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al obtener usuarios: " + ex.Message);
                }
            }

            return dataTable;
        }
        //Actualiza la información de un usuario existente
        public bool UpdateUser(long userId, string fullName, string username, string hashedPassword, byte[] photo)
        {
            string query = @"
                UPDATE Usuarios 
                SET nombre = @nombre, 
                    username = @username, 
                    hashedPassword = @hashedPassword, 
                    foto = @foto 
                WHERE idUsuario = @userId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", fullName);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                        cmd.Parameters.AddWithValue("@foto", photo);
                        cmd.Parameters.AddWithValue("@userId", userId);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar usuario: " + ex.Message);
                    return false;
                }
            }
        }
        //Elimina un usuario de la base de datos
        public bool DeleteUser(long userId)
        {
            string query = "DELETE FROM Usuarios WHERE idUsuario = @userId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                    return false;
                }
            }
        }
        public DataTable GetUsersWithAttendance()
        {
            string query = @"
        SELECT 
            Usuarios.idUsuario AS ID,
            Usuarios.nombre AS name,
            Usuarios.username AS Username,
            MAX(Registros.horaEntrada) AS lastEntry,
            MAX(Registros.horaSalida) AS lastExit
        FROM Usuarios
        LEFT JOIN Registros ON Usuarios.idUsuario = Registros.idUsuario
        GROUP BY Usuarios.idUsuario, Usuarios.nombre, Usuarios.username
        ORDER BY Usuarios.idUsuario";

            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al obtener datos de empleados: " + ex.Message);
                }
            }
            return dataTable;
        }
    }
}
