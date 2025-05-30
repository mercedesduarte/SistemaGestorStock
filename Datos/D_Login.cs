using Datos.Conecction;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Login
    {
        public static bool LoginBD(string usuario, string contrasena, out bool esAdmin, out string nombreRol)
        {
            esAdmin = false;
            nombreRol = null;
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_Login", conexion)) // Asegurate del nombre este bien

                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                        SqlParameter esAdminParam = new SqlParameter("@EsAdmin", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(esAdminParam);

                        SqlParameter nombreRolParam = new SqlParameter("@NombreRol", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(nombreRolParam);

                        cmd.ExecuteNonQuery();

                        if (esAdminParam.Value != DBNull.Value)
                        {
                            esAdmin = Convert.ToBoolean(esAdminParam.Value);
                            nombreRol = nombreRolParam.Value?.ToString();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar iniciar sesión: " + ex.Message);
                return false;
            }
        }
    }
}
