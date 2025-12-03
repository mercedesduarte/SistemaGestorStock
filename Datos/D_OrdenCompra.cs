using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;
using Sesion;

namespace Datos
{
    public static class D_OrdenCompra
    {
        // Inserts order header and returns new id via out parameter. Uses stored procedure present in DB: sp_InsertarOrdenCompra
        public static int InsertarOrden(SqlConnection cn, SqlTransaction tr, int idProveedor, DateTime fecha, decimal total, out string mensaje)
        {
            mensaje = string.Empty;
            try
            {
                using (var cmd = new SqlCommand("sp_InsertarOrdenCompra", cn, tr))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameters expected by the SP: IdProveedor, UsuarioCreacion, Observaciones, and output IdOrdenCompra
                    cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);

                    if (!string.IsNullOrWhiteSpace(SesionUsuario.Usuario))
                        cmd.Parameters.AddWithValue("@UsuarioCreacion", SesionUsuario.Usuario);
                    else
                        cmd.Parameters.AddWithValue("@UsuarioCreacion", DBNull.Value);

                    // Pass fecha and total inside Observaciones so DB receives some context (or empty)
                    string observ = $"Fecha:{fecha:yyyy-MM-dd};Total:{total:N2}";
                    cmd.Parameters.AddWithValue("@Observaciones", observ);

                    var pId = new SqlParameter("@IdOrdenCompra", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(pId);

                    cmd.ExecuteNonQuery();

                    return pId.Value != DBNull.Value ? Convert.ToInt32(pId.Value) : -1;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return -1;
            }
        }

        // Inserts a detail line for an order. Uses stored procedure sp_InsertarDetalleOrdenCompra that inserts into DetalleOrdenCompra
        public static bool InsertarDetalle(SqlConnection cn, SqlTransaction tr, int idOrdenCompra, int idProducto, int cantidad, decimal precioUnitario, out string mensaje)
        {
            mensaje = string.Empty;
            try
            {
                using (var cmd = new SqlCommand("sp_InsertarDetalleOrdenCompra", cn, tr))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdOrdenCompra", idOrdenCompra);
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);

                    // Add Importe parameter as required by the DetalleOrdenCompra table
                    decimal importe = cantidad * precioUnitario;
                    cmd.Parameters.AddWithValue("@Importe", importe);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }
    }
}
