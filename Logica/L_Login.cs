using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;
using Datos;

namespace Logica
{
    public class L_Login 
    {
        public static bool LoginUsuario(string usuario, string contrasena)
        {
            try
            {
                using (SqlConnection conexion =  ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_LogearUsuario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine(usuario);
                    Console.WriteLine(contrasena);

                    return (result == 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(usuario);
                Console.WriteLine(contrasena);
                return (false);
            }
        }
    }
}
