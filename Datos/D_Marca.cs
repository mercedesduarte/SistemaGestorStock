using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos.Conecction;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_Marca
    {
        public static bool InsertarMarca(string nombre, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarMarca", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", nombre);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al insertar marca: " + ex.Message;
                return false;
            }
        }

        public static bool ModificarMarca(int idMarca, string nombre, bool activo, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ModificarMarca", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdMarca", idMarca);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Activo", activo);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al modificar marca: " + ex.Message;
                return false;
            }
        }

        public static DataTable ListarMarcas()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = ConnectionBD.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarMarcas", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    tabla.Load(dr);
                }
            }
            return tabla;
        }
    }
}

