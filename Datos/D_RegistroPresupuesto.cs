using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;

namespace Datos
{
    public class D_RegistroPresupuesto
    {

        public static string ObtenerProximoNumeroFactura()
        {
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerProximoNumeroFactura", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        object result = cmd.ExecuteScalar();
                        return result?.ToString() ?? "FAC-001-" + DateTime.Now.ToString("yyyyMM") + "-000001";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerProximoNumeroFactura: " + ex.ToString());
                return "FAC-001-" + DateTime.Now.ToString("yyyyMM") + "-000001";
            }
        }


        public static int CrearFacturaDesdePresupuesto(
            int idPresupuesto,
            string numeroFactura,
            DateTime fechaFactura,
            DateTime fechaVencimiento,
            int idCliente,
            decimal subTotal,
            decimal descuento,
            decimal total,
            string observaciones,
            string usuario)
        {
            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_CrearFacturaDesdePresupuesto", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdPresupuesto", idPresupuesto);
                        cmd.Parameters.AddWithValue("@NumeroFactura", numeroFactura);
                        cmd.Parameters.AddWithValue("@FechaFactura", fechaFactura);
                        cmd.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmd.Parameters.AddWithValue("@SubTotal", subTotal);
                        cmd.Parameters.AddWithValue("@Descuento", descuento);
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.Parameters.AddWithValue("@Observaciones", (object)observaciones ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);

                        SqlParameter outputId = new SqlParameter("@IdFactura", SqlDbType.Int);
                        outputId.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputId);

                        cmd.ExecuteNonQuery();

                        return (int)outputId.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en CrearFacturaDesdePresupuesto: " + ex.ToString());
                return -1;
            }
        }

        public static DataTable ObtenerClientePorId(int idCliente)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT IdCliente, RazonSocial, Email, FormaPago, Descuento " +
                        "FROM Clientes WHERE IdCliente = @IdCliente AND Activo = 1", conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerClientePorId: " + ex.ToString());
            }

            return dt;
        }


    }
}