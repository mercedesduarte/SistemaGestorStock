using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;

namespace Datos
{
    public class D_ClienteDireccion
    {
        
        public static bool InsertarDireccion(int idCliente, string direccion, string localidad, string provincia, out string mensaje)
        {
            mensaje = "";
            try
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

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al insertar dirección: " + ex.Message;
                return false;
            }
        }

        // Modificar dirección
        public static bool ModificarDireccion(int idDireccion, string direccion, string localidad, string provincia, bool activo, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ModificarClienteDireccion", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdDireccion", idDireccion);
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
            catch (Exception ex)
            {
                mensaje = "Error al modificar dirección: " + ex.Message;
                return false;
            }
        }

        
        public static DataTable ListarDirecciones(int idCliente)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarClienteDirecciones", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar direcciones: " + ex.Message);
            }
            return tabla;
        }

        
        public static DataRow ObtenerPorId(int idDireccion, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerClienteDireccionPorId", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdDireccion", idDireccion);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            return dt.Rows[0];
                        }
                        else
                        {
                            mensaje = "No se encontró la dirección.";
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al obtener dirección: " + ex.Message;
                return null;
            }
        }
    }
}
