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
    public class D_Producto
    {
        public static bool InsertarProducto(
            string codigo, string nombre, string descripcion,
            int idCategoria, int idMarca, string lote, DateTime fechaVencimiento,
            int diasAvisoVencimiento, decimal precioCompra, decimal precioVenta,
            int stockActual, int stockMinimo, int stockIdeal, int stockMaximo,
            string tipoStock,
            out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarProducto", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@IdMarca", idMarca);
                        cmd.Parameters.AddWithValue("@Lote", lote);
                        cmd.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
                        cmd.Parameters.AddWithValue("@DiasAvisoVencimiento", diasAvisoVencimiento);
                        cmd.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                        cmd.Parameters.AddWithValue("@PrecioVenta", precioVenta);
                        cmd.Parameters.AddWithValue("@StockActual", stockActual);
                        cmd.Parameters.AddWithValue("@StockMinimo", stockMinimo);
                        cmd.Parameters.AddWithValue("@StockIdeal", stockIdeal);
                        cmd.Parameters.AddWithValue("@StockMaximo", stockMaximo);
                        cmd.Parameters.AddWithValue("@TipoStock", tipoStock);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al insertar producto: " + ex.Message;
                return false;
            }
        }

        public static bool ModificarProducto(
            int idProducto, string codigo, string nombre, string descripcion,
            int idCategoria, int idMarca, string lote, DateTime fechaVencimiento,
            int diasAvisoVencimiento, decimal precioCompra, decimal precioVenta,
            int stockActual, int stockMinimo, int stockIdeal, int stockMaximo,
            string tipoStock, bool activo,
            out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ModificarProducto", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@IdMarca", idMarca);
                        cmd.Parameters.AddWithValue("@Lote", lote);
                        cmd.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
                        cmd.Parameters.AddWithValue("@DiasAvisoVencimiento", diasAvisoVencimiento);
                        cmd.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                        cmd.Parameters.AddWithValue("@PrecioVenta", precioVenta);
                        cmd.Parameters.AddWithValue("@StockActual", stockActual);
                        cmd.Parameters.AddWithValue("@StockMinimo", stockMinimo);
                        cmd.Parameters.AddWithValue("@StockIdeal", stockIdeal);
                        cmd.Parameters.AddWithValue("@StockMaximo", stockMaximo);
                        cmd.Parameters.AddWithValue("@TipoStock", tipoStock);
                        cmd.Parameters.AddWithValue("@Activo", activo);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al modificar producto: " + ex.Message;
                return false;
            }
        }

        public static DataTable ListarProductos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarProductos", cn))
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
                throw new Exception("Error al listar productos: " + ex.Message);
            }
            return tabla;
        }

        public static DataRow ObtenerPorId(int idProducto, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerProductoPorId", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);

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
                            mensaje = "No se encontró el producto.";
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al obtener producto: " + ex.Message;
                return null;
            }
        }

    }
}
