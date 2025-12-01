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
                    cn.Open();

                    using (SqlTransaction tran = cn.BeginTransaction())
                    {
                        try
                        {
                            // Ejecuta el SP que inserta el cliente
                            using (SqlCommand cmd = new SqlCommand("sp_InsertarCliente", cn, tran))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandTimeout = 120; // segundos
                                cmd.Parameters.AddWithValue("@Codigo", codigo);
                                cmd.Parameters.AddWithValue("@RazonSocial", razonSocial);
                                cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                                cmd.Parameters.AddWithValue("@FormaPago", formaPago);
                                cmd.Parameters.AddWithValue("@Descuento", descuento);
                                cmd.Parameters.AddWithValue("@LimiteCredito", limiteCredito);

                                cmd.ExecuteNonQuery();
                            }

                            // Obtener el IdCliente recién insertado usando SCOPE_IDENTITY() en la misma conexión/transacción
                            int idCliente = 0;
                            using (SqlCommand cmdGetId = new SqlCommand("SELECT CAST(SCOPE_IDENTITY() AS INT)", cn, tran))
                            {
                                cmdGetId.CommandType = CommandType.Text;
                                cmdGetId.CommandTimeout = 30;
                                object res = cmdGetId.ExecuteScalar();
                                if (res != null && res != DBNull.Value)
                                    idCliente = Convert.ToInt32(res);
                            }

                            if (idCliente <= 0)
                            {
                                tran.Rollback();
                                mensaje = "No se pudo obtener el Id del cliente insertado.";
                                return false;
                            }

                            // Insertar dirección (si existe) usando la misma conexión y transacción
                            if (!string.IsNullOrWhiteSpace(direccion))
                            {
                                bool dirOk = D_ClienteDireccion.InsertarClienteDireccion(cn, tran, idCliente, direccion, localidad, provincia, true);
                                if (!dirOk)
                                {
                                    tran.Rollback();
                                    mensaje = "No se pudo insertar la dirección del cliente.";
                                    return false;
                                }
                            }

                            // Insertar teléfono (si existe) usando la misma conexión y transacción
                            if (!string.IsNullOrWhiteSpace(telefono))
                            {
                                bool telOk = D_ClienteTelefono.InsertarClienteTelefono(cn, tran, idCliente, telefono, contacto, sector, horario, emailContacto, true);
                                if (!telOk)
                                {
                                    tran.Rollback();
                                    mensaje = "No se pudo insertar el teléfono del cliente.";
                                    return false;
                                }
                            }

                            tran.Commit();
                            mensaje = "Cliente insertado correctamente en la base de datos";
                            return true;
                        }
                        catch (SqlException sqlEx)
                        {
                            try { tran.Rollback(); } catch { }
                            mensaje = $"Error de base de datos: {sqlEx.Message}";
                            if (sqlEx.Number == 2627) // Violación de unique key
                            {
                                mensaje = "Ya existe un cliente con ese código";
                            }
                            else if (sqlEx.Number == 547) // Violación de FK
                            {
                                mensaje = "Error de integridad referencial";
                            }
                            return false;
                        }
                        catch (Exception ex)
                        {
                            try { tran.Rollback(); } catch { }
                            mensaje = $"Error general al insertar cliente: {ex.Message}";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error de conexión al insertar cliente: {ex.Message}";
                return false;
            }
        }

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