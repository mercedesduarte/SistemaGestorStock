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
    public class D_ProveedorTelefono
    {
        // Insertar Teléfono
        public static bool InsertarTelefono(
            int idProveedor, string telefono, string contacto,
            string sector, string horario, string emailContacto,
            out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarProveedorTelefono", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Contacto", string.IsNullOrEmpty(contacto) ? (object)DBNull.Value : contacto);
                        cmd.Parameters.AddWithValue("@Sector", string.IsNullOrEmpty(sector) ? (object)DBNull.Value : sector);
                        cmd.Parameters.AddWithValue("@Horario", string.IsNullOrEmpty(horario) ? (object)DBNull.Value : horario);
                        cmd.Parameters.AddWithValue("@EmailContacto", string.IsNullOrEmpty(emailContacto) ? (object)DBNull.Value : emailContacto);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al insertar teléfono: " + ex.Message;
                return false;
            }
        }

        // Listar Teléfonos por proveedor
        public static DataTable ListarTelefonos(int idProveedor)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarProveedorTelefonos", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);

                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar teléfonos: " + ex.Message);
            }
            return tabla;
        }

        // Modificar Teléfono
        public static bool ModificarTelefono(
            int idTelefono, string telefono, string contacto,
            string sector, string horario, string emailContacto,
            bool activo,
            out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ModificarProveedorTelefono", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdTelefono", idTelefono);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Contacto", string.IsNullOrEmpty(contacto) ? (object)DBNull.Value : contacto);
                        cmd.Parameters.AddWithValue("@Sector", string.IsNullOrEmpty(sector) ? (object)DBNull.Value : sector);
                        cmd.Parameters.AddWithValue("@Horario", string.IsNullOrEmpty(horario) ? (object)DBNull.Value : horario);
                        cmd.Parameters.AddWithValue("@EmailContacto", string.IsNullOrEmpty(emailContacto) ? (object)DBNull.Value : emailContacto);
                        cmd.Parameters.AddWithValue("@Activo", activo);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al modificar teléfono: " + ex.Message;
                return false;
            }
        }

        public static DataRow ObtenerPorId(int idTelefono, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerProveedorTelefonoPorId", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdTelefono", idTelefono);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                            return dt.Rows[0];
                        else
                        {
                            mensaje = "No se encontró el teléfono.";
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al obtener teléfono: " + ex.Message;
                return null;
            }
        }

    }
}

