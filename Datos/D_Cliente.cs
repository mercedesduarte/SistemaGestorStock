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
                using (SqlCommand cmd = new SqlCommand("sp_InsertarCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // CLIENTE
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@RazonSocial", razonSocial);
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                    cmd.Parameters.AddWithValue("@FormaPago", formaPago);
                    cmd.Parameters.AddWithValue("@Descuento", descuento);
                    cmd.Parameters.AddWithValue("@LimiteCredito", limiteCredito);

                    // DIRECCIÓN
                    cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(direccion) ? (object)DBNull.Value : direccion);
                    cmd.Parameters.AddWithValue("@Localidad", string.IsNullOrEmpty(localidad) ? (object)DBNull.Value : localidad);
                    cmd.Parameters.AddWithValue("@Provincia", string.IsNullOrEmpty(provincia) ? (object)DBNull.Value : provincia);

                    // TELÉFONO
                    cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);
                    cmd.Parameters.AddWithValue("@Contacto", string.IsNullOrEmpty(contacto) ? (object)DBNull.Value : contacto);
                    cmd.Parameters.AddWithValue("@Sector", string.IsNullOrEmpty(sector) ? (object)DBNull.Value : sector);
                    cmd.Parameters.AddWithValue("@Horario", string.IsNullOrEmpty(horario) ? (object)DBNull.Value : horario);
                    cmd.Parameters.AddWithValue("@EmailContacto", string.IsNullOrEmpty(emailContacto) ? (object)DBNull.Value : emailContacto);

                    SqlParameter pId = new SqlParameter("@IdCliente", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(pId);

                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    // esto verifica si se inserto
                    if (pId.Value != DBNull.Value && Convert.ToInt32(pId.Value) > 0)
                    {
                        mensaje = "Cliente insertado correctamente en la base de datos";
                        return true;
                    }
                    else
                    {
                        mensaje = "No se pudo insertar el cliente - No se generó ID";
                        return false;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // esto ve errores específicos de SQL
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
                mensaje = $"Error general al insertar cliente: {ex.Message}";
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