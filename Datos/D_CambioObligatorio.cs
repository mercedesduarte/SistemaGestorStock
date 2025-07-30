using Datos.Conecction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_CambioObligatorio
    {
            public static bool ActualizarContra(int idpersona, string contrasena, DateTime fechacambio)
            {
                try
                {
                    using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                    {
                        conexion.Open();

                        using (SqlCommand cmd = new SqlCommand("sp_ActualizarContra", conexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;


                            cmd.Parameters.AddWithValue("@Id_Persona", idpersona);
                            cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                            cmd.Parameters.AddWithValue("@FechaCambio", fechacambio);

                        cmd.ExecuteNonQuery();

                            Console.WriteLine("Contraseña cambiada exitosamente");

                            return true;

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cambiar contraseña: ", ex);
                    return false;
                }
            }
    }
}
