using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;
using Datos.DTOs;

namespace Datos
{
    public class D_BusquedaCP
    {
        public CodigoPostalDTO BusquedaDatosCp(int cp)
        {
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_CodigoPostal", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CodigoPostal", cp);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new CodigoPostalDTO
                            {
                                Localidad = reader["Localidad"].ToString(),
                                Partido = reader["Partido"].ToString(),
                                Provincia = reader["Provincia"].ToString()
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar los datos del código postal: " + ex.Message);
                return null;
            }
        }
    }
}
