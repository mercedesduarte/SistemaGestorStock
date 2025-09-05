using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Conecction;
using Datos.DTOs;
using System.Data;
using System.Data.SqlClient;
using Sesion;

namespace Datos
{
    public class D_DatosUsuario
    {
        public List<DUsuarioDTO> MostrarDatosUsuario(string usuario)
        {
            List<DUsuarioDTO> datosUsuario = new List<DUsuarioDTO>();

            using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_DatosDeUsuario", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", usuario);

                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datosUsuario.Add(new DUsuarioDTO()
                            {
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Email = reader["Email"].ToString()
                            });
                        }
                    }
                }
            }
            return datosUsuario;
        }
    }
}
           