using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;

namespace Datos
{
    public class D_Proveedor
    {
        // Insertar proveedor
        public static bool InsertarProveedor(
            string codigo, string razonSocial, string cuit,
            string email, string formaPago, int? tiempoEntrega, decimal descuento,
            out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarProveedor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@RazonSocial", razonSocial);
                        cmd.Parameters.AddWithValue("@Cuit", cuit);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        cmd.Parameters.AddWithValue("@FormaPago", string.IsNullOrEmpty(formaPago) ? (object)DBNull.Value : formaPago);
                        cmd.Parameters.AddWithValue("@TiempoEntrega", tiempoEntrega);
                        cmd.Parameters.AddWithValue("@Descuento", descuento);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al insertar proveedor: " + ex.Message;
                return false;
            }
        }

        // Modificar proveedor
        public static bool ModificarProveedor(
            int idProveedor, string codigo, string razonSocial, string cuit,
            string email, string formaPago, int? tiempoEntrega, decimal descuento,
            bool activo,
            out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ModificarProveedor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@RazonSocial", razonSocial);
                        cmd.Parameters.AddWithValue("@Cuit", cuit);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        cmd.Parameters.AddWithValue("@FormaPago", string.IsNullOrEmpty(formaPago) ? (object)DBNull.Value : formaPago);
                        cmd.Parameters.AddWithValue("@TiempoEntrega", tiempoEntrega);
                        cmd.Parameters.AddWithValue("@Descuento", descuento);
                        cmd.Parameters.AddWithValue("@Activo", activo);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al modificar proveedor: " + ex.Message;
                return false;
            }
        }

        // Listar todos los proveedores
        public static DataTable ListarProveedores()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarProveedores", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();

                        SqlDataReader dr = cmd.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar proveedores: " + ex.Message);
            }
            return tabla;
        }

        // Buscar proveedor por nombre o CUIT
        public static DataTable BuscarProveedorPorNombreOCuit(string filtro)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_BuscarProveedorPorNombreOCuit", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Filtro", filtro);
                        cn.Open();

                        SqlDataReader dr = cmd.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar proveedor: " + ex.Message);
            }
            return tabla;
        }

        // Obtener proveedor por Id
        public static DataRow ObtenerPorId(int idProveedor, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerProveedorPorId", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);

                        cn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            return dt.Rows[0];
                        }
                        else
                        {
                            mensaje = "No se encontró el proveedor.";
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al obtener proveedor: " + ex.Message;
                return null;
            }
        }

    }
}

