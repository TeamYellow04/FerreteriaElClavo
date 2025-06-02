using FerreteriaElClavo.Data;
using System;
using System.Data.SqlClient;

namespace FerreteriaElClavo.Entities
{
    internal class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int Rol { get; set; } // Nuevo campo

        public static bool Autenticar(string nombreUsuario, string contrasena, out int rol)
        {
            rol = 0; // Valor por defecto si no se encuentra

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT Rol FROM Usuario WHERE nombre = @nombre AND Contrasena = @Contrasena";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        rol = Convert.ToInt32(result);
                        return rol == 1 || rol == 2;
                    }

                    return false;
                }
            }
        }
    }
}
