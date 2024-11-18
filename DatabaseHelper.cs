using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PuntuApp.Helpers
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper(string connectionString)
        {
            var builder = new MySqlConnectionStringBuilder(connectionString);
            builder.Server = "localhost";
            this.connectionString = builder.ToString();
        }

        public int AuthenticateUser(string username, string password)
        {
            string userConnectionString = $"server=localhost;database=puntuapp;uid={username};pwd={password};";
            using (MySqlConnection connection = new MySqlConnection(userConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT idUsuario FROM Usuarios WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else if (username == "root")
                        {
                            return 0; // Asumiendo 0 para el usuario root
                        }
                        else
                        {
                            return -1; // Usuario no encontrado
                        }
                    }
                }
                catch (MySqlException)
                {
                    // Autenticación fallida
                    return -1;
                }
            }
        }

        public long AddUser(string fullName, string username, string hashedPassword, byte[] photo)
        {
            string query = @"
                INSERT INTO Usuarios (nombre, username, password, foto) 
                VALUES (@nombre, @username, @password, @foto)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", fullName);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
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

        public bool CreateMySQLUser(string username, string password, string role)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Crear el usuario MySQL
                    string createUserQuery = $"CREATE USER '{username}'@'localhost' IDENTIFIED BY '{password}';";
                    using (MySqlCommand createUserCommand = new MySqlCommand(createUserQuery, connection))
                    {
                        createUserCommand.ExecuteNonQuery();
                    }

                    // Asignar privilegios según el rol
                    string grantPrivilegesQuery;
                    if (role == "Administrador")
                    {
                        grantPrivilegesQuery = $"GRANT ALL PRIVILEGES ON PuntuApp.* TO '{username}'@'localhost';";
                    }
                    else // Empleado
                    {
                        grantPrivilegesQuery = $"GRANT SELECT, UPDATE ON PuntuApp.Usuarios TO '{username}'@'localhost';";
                    }

                    using (MySqlCommand grantPrivilegesCommand = new MySqlCommand(grantPrivilegesQuery, connection))
                    {
                        grantPrivilegesCommand.ExecuteNonQuery();
                    }

                    // Aplicar cambios
                    using (MySqlCommand flushPrivilegesCommand = new MySqlCommand("FLUSH PRIVILEGES;", connection))
                    {
                        flushPrivilegesCommand.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al crear el usuario MySQL: " + ex.Message);
                return false;
            }
        }

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

        public DataRow GetUserById(int userId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Usuarios WHERE idUsuario = @UserId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable userTable = new DataTable();
                        adapter.Fill(userTable);
                        if (userTable.Rows.Count == 1)
                        {
                            return userTable.Rows[0];
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public string GetUserRole(int userId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT Roles.nombreRol FROM Roles
                            INNER JOIN Usuarios_Roles ON Roles.idRol = Usuarios_Roles.idRol
                            WHERE Usuarios_Roles.idUsuario = @UserId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    object result = command.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public bool UpdateUser(long userId, string fullName, string username, string password, byte[] photo)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Construir la consulta dinámicamente según los parámetros proporcionados
                StringBuilder queryBuilder = new StringBuilder("UPDATE Usuarios SET nombre = @FullName, username = @Username");
                if (!string.IsNullOrEmpty(password))
                {
                    queryBuilder.Append(", password = @Password");
                }
                if (photo != null)
                {
                    queryBuilder.Append(", foto = @Photo");
                }
                queryBuilder.Append(" WHERE idUsuario = @UserId");

                using (var command = new MySqlCommand(queryBuilder.ToString(), connection))
                {
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@Username", username);
                    if (!string.IsNullOrEmpty(password))
                    {
                        command.Parameters.AddWithValue("@Password", password); // Recuerde cifrar la contraseña
                    }
                    if (photo != null)
                    {
                        command.Parameters.AddWithValue("@Photo", photo);
                    }
                    command.Parameters.AddWithValue("@UserId", userId);

                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool UpdateUserRole(long userId, long roleId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Eliminar roles existentes para el usuario
                string deleteQuery = "DELETE FROM Usuarios_Roles WHERE idUsuario = @UserId";
                using (var deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@UserId", userId);
                    deleteCommand.ExecuteNonQuery();
                }

                // Asignar el nuevo rol
                string insertQuery = "INSERT INTO Usuarios_Roles (idUsuario, idRol) VALUES (@UserId, @RoleId)";
                using (var insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@UserId", userId);
                    insertCommand.Parameters.AddWithValue("@RoleId", roleId);
                    int result = insertCommand.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool DeleteUser(long userId)
        {
            // Primero, obtenemos el nombre de usuario del usuario que se va a eliminar
            string username = GetUsernameById(userId);
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("No se pudo encontrar el nombre de usuario.");
                return false;
            }

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

                        if (result > 0)
                        {
                            // Eliminamos el usuario MySQL
                            bool mysqlUserDeleted = DeleteMySQLUser(username);
                            if (!mysqlUserDeleted)
                            {
                                MessageBox.Show("El usuario fue eliminado de la base de datos, pero no se pudo eliminar el usuario MySQL.");
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                    return false;
                }
            }
        }

        public string GetUsernameById(long userId)
        {
            string query = "SELECT username FROM Usuarios WHERE idUsuario = @userId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al obtener el nombre de usuario: " + ex.Message);
                    return null;
                }
            }
        }

        public bool DeleteMySQLUser(string username)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Comando para eliminar el usuario MySQL
                    string dropUserQuery = $"DROP USER '{username}'@'localhost';";
                    using (MySqlCommand dropUserCommand = new MySqlCommand(dropUserQuery, connection))
                    {
                        dropUserCommand.ExecuteNonQuery();
                    }

                    // Aplicar cambios
                    using (MySqlCommand flushPrivilegesCommand = new MySqlCommand("FLUSH PRIVILEGES;", connection))
                    {
                        flushPrivilegesCommand.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar el usuario MySQL: " + ex.Message);
                return false;
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
