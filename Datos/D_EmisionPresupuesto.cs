using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;

namespace Datos
{
    public class D_EmisionPresupuesto
    {
        public static DataTable BuscarClientes(string busqueda)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_BuscarClientes", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Busqueda", busqueda);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BuscarClientes: " + ex.ToString());
            }
            return dt;
        }

        public static DataTable BuscarProductos(string busqueda)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_BuscarProductos", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Busqueda", busqueda);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BuscarProductos: " + ex.ToString());
            }
            return dt;
        }

        public static string ObtenerUltimoNumeroPresupuesto()
        {
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerUltimoNumeroPresupuesto", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        var result = cmd.ExecuteScalar();
                        return result?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerUltimoNumeroPresupuesto: " + ex.ToString());
                return null;
            }
        }

        public static int InsertarPresupuesto(
            string numeroPresupuesto,
            DateTime fecha,
            int idCliente,
            decimal subTotal,
            decimal descuento,
            decimal total,
            int validez,
            string usuario
        )
        {
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarPresupuesto", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NumeroPresupuesto", numeroPresupuesto);
                        cmd.Parameters.AddWithValue("@Fecha", fecha);
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmd.Parameters.AddWithValue("@SubTotal", subTotal);
                        cmd.Parameters.AddWithValue("@Descuento", descuento);
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.Parameters.AddWithValue("@Validez", validez);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);

                        SqlParameter outputId = new SqlParameter("@IdPresupuesto", SqlDbType.Int);
                        outputId.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputId);

                        cmd.ExecuteNonQuery();
                        return (int)outputId.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en InsertarPresupuesto: " + ex.ToString());
                return -1;
            }
        }

        public static bool InsertarDetallePresupuesto(
            int idPresupuesto,
            int idProducto,
            decimal cantidad,
            decimal precioUnitario,
            decimal subTotal
        )
        {
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarDetallePresupuesto", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdPresupuesto", idPresupuesto);
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                        cmd.Parameters.AddWithValue("@SubTotal", subTotal);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en InsertarDetallePresupuesto: " + ex.ToString());
                return false;
            }
        }
    }
}