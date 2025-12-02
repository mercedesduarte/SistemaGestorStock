using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;

namespace Datos
{
    public class D_Cliente
    {
        public static bool InsertarCliente(
            string codigo, string razonSocial, string email, string formaPago,
            decimal descuento, decimal limiteCredito, string direccion, string localidad,
            string provincia, string telefono, string contacto, string sector,
            string horario, string emailContacto, out string mensaje)
        {
            mensaje = "";

            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarCliente", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@RazonSocial", razonSocial);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                        cmd.Parameters.AddWithValue("@FormaPago", formaPago);
                        cmd.Parameters.AddWithValue("@Descuento", descuento);
                        cmd.Parameters.AddWithValue("@LimiteCredito", limiteCredito);

                        cmd.Parameters.AddWithValue("@Direccion", direccion);
                        cmd.Parameters.AddWithValue("@Localidad", localidad);
                        cmd.Parameters.AddWithValue("@Provincia", provincia);

                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Contacto", contacto);
                        cmd.Parameters.AddWithValue("@Sector", sector);
                        cmd.Parameters.AddWithValue("@Horario", horario);
                        cmd.Parameters.AddWithValue("@EmailContacto", emailContacto);

                        SqlParameter pIdCliente = new SqlParameter("@IdCliente", SqlDbType.Int);
                        pIdCliente.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(pIdCliente);

                        cn.Open();
                        cmd.ExecuteNonQuery();

                        mensaje = "Cliente insertado correctamente";
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    mensaje = "Ya existe un cliente con ese código";
                else
                    mensaje = ex.Message;

                return false;
            }
        }

        // ===== RESTO DEL CÓDIGO ORIGINAL =====

        public static bool ModificarCliente(
            int idCliente, string codigo, string razonSocial, string email,
            string formaPago, decimal descuento, decimal limiteCredito, bool activo)
        {
            using (SqlConnection cn = ConnectionBD.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ModificarCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@RazonSocial", razonSocial);
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                    cmd.Parameters.AddWithValue("@FormaPago", string.IsNullOrEmpty(formaPago) ? (object)DBNull.Value : formaPago);
                    cmd.Parameters.AddWithValue("@Descuento", descuento);
                    cmd.Parameters.AddWithValue("@LimiteCredito", limiteCredito);
                    cmd.Parameters.AddWithValue("@Activo", activo);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public static DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = ConnectionBD.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarClientes", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    tabla.Load(dr);
                }
            }
            return tabla;
        }

        public static DataRow ObtenerPorId(int idCliente)
        {
            using (SqlConnection cn = ConnectionBD.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerClientePorId", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                    cn.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                }
            }
        }

        public static DataTable BuscarClientePorNombreOCodigo(string busqueda)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = ConnectionBD.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_BuscarClientePorNombreOCodigo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Busqueda", string.IsNullOrEmpty(busqueda) ? (object)DBNull.Value : busqueda);

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    tabla.Load(dr);
                }
            }
            return tabla;
        }
    }
}
