using Datos.Conecction;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_Registro
    {
        public static bool RegistrarUsuario(string usuario, string contrasena)
        {
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    return (result == 1);
                }
            }
            catch (Exception ex)
            {
                // Podés logear el error si querés: Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
