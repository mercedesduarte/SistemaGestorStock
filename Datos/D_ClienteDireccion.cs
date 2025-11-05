using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;

namespace Datos
{
    public class D_ClienteDireccion
    {
        
        public static bool InsertarClienteDireccion(int idCliente, string direccion, string localidad, string provincia, bool activo)
        {
            using (SqlConnection cn = ConnectionBD.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarClienteDireccion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.Parameters.AddWithValue("@Direccion", direccion);
                    cmd.Parameters.AddWithValue("@Localidad", string.IsNullOrEmpty(localidad) ? (object)DBNull.Value : localidad);
                    cmd.Parameters.AddWithValue("@Provincia", string.IsNullOrEmpty(provincia) ? (object)DBNull.Value : provincia);
                    cmd.Parameters.AddWithValue("@Activo", activo);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // 🔹 LISTAR direcciones por cliente
        public static DataTable ListarClienteDirecciones(int idCliente)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = ConnectionBD.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarClienteDirecciones", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        
        public static bool ModificarClienteDireccion(int idClienteDireccion, string direccion, string localidad, string provincia, bool activo)
        {
            using (SqlConnection cn = ConnectionBD.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ModificarClienteDireccion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdClienteDireccion", idClienteDireccion);
                    cmd.Parameters.AddWithValue("@Direccion", direccion);
                    cmd.Parameters.AddWithValue("@Localidad", string.IsNullOrEmpty(localidad) ? (object)DBNull.Value : localidad);
                    cmd.Parameters.AddWithValue("@Provincia", string.IsNullOrEmpty(provincia) ? (object)DBNull.Value : provincia);
                    cmd.Parameters.AddWithValue("@Activo", activo);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        
        public static DataRow ObtenerPorId(int idClienteDireccion)
        {
            using (SqlConnection cn = ConnectionBD.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerClienteDireccionPorId", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdClienteDireccion", idClienteDireccion);

                    cn.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                }
            }
        }
    }
}
