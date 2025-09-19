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
    public class D_Categoria
    {
        public static bool InsertarCategoria(string nombre, string descripcion, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarCategoria", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrEmpty(descripcion) ? (object)DBNull.Value : descripcion);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al insertar categoría: " + ex.Message;
                return false;
            }
        }

        public static bool ModificarCategoria(int idCategoria, string nombre, string descripcion, bool activo, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ModificarCategoria", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrEmpty(descripcion) ? (object)DBNull.Value : descripcion);
                        cmd.Parameters.AddWithValue("@Activo", activo);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al modificar categoría: " + ex.Message;
                return false;
            }
        }

        public static DataTable ListarCategorias()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = ConnectionBD.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarCategorias", cn))
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


