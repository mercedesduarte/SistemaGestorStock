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
    public class D_ProveedorProducto
    {
        // 🔹 Insertar relación Producto-Proveedor
        public static bool InsertarProveedorProducto(
            int idProducto, int idProveedor, decimal precioCompra, string catalogo,
            out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarProductoProveedor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        cmd.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                        cmd.Parameters.AddWithValue("@Catalogo", string.IsNullOrEmpty(catalogo) ? (object)DBNull.Value : catalogo);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al insertar relación Producto-Proveedor: " + ex.Message;
                return false;
            }
        }

        // 🔹 Modificar relación Producto-Proveedor
        public static bool ModificarProveedorProducto(
            int idProductoProveedor, int idProducto, int idProveedor,
            decimal precioCompra, string catalogo, bool activo,
            out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ModificarProductoProveedor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdProductoProveedor", idProductoProveedor);
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        cmd.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                        cmd.Parameters.AddWithValue("@Catalogo", string.IsNullOrEmpty(catalogo) ? (object)DBNull.Value : catalogo);
                        cmd.Parameters.AddWithValue("@Activo", activo);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al modificar relación Producto-Proveedor: " + ex.Message;
                return false;
            }
        }

        // 🔹 Listar productos de un proveedor
        public static DataTable ListarProductosPorProveedor(int idProveedor)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarProductosPorProveedor", cn))
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
                throw new Exception("Error al listar productos del proveedor: " + ex.Message);
            }
            return tabla;
        }

        // 🔹 Listar proveedores de un producto
        public static DataTable ListarProveedoresPorProducto(int idProducto)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarProveedoresPorProducto", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar proveedores del producto: " + ex.Message);
            }
            return tabla;
        }

        // 🔹 Obtener relación Producto-Proveedor por Id (usa el SP)
        public static DataRow ObtenerPorId(int idProductoProveedor, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerProductoProveedorPorId", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProductoProveedor", idProductoProveedor);

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
                            mensaje = "No se encontró la relación Producto-Proveedor.";
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al obtener relación Producto-Proveedor: " + ex.Message;
                return null;
            }
        }
    }
}
