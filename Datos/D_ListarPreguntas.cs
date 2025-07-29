using Datos.Conecction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_Pregunta
    {
        public static DataTable ListarPreguntas()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ListarPreguntas", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar preguntas: " + ex.Message);
                tabla = null;
            }

            return tabla;
        }
    }
}
