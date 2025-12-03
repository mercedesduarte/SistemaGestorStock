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
            string horario, string emailContacto, out string mensaje, out int idCliente)
        {
            mensaje = "";
            idCliente = 0;

            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand("sp_InsertarClienteCompleto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 60;

                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@RazonSocial", razonSocial);
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                    cmd.Parameters.AddWithValue("@FormaPago", string.IsNullOrEmpty(formaPago) ? (object)DBNull.Value : formaPago);
                    cmd.Parameters.AddWithValue("@Descuento", descuento);
                    cmd.Parameters.AddWithValue("@LimiteCredito", limiteCredito);

                    // Dirección
                    cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(direccion) ? (object)DBNull.Value : direccion);
                    cmd.Parameters.AddWithValue("@Localidad", string.IsNullOrEmpty(localidad) ? (object)DBNull.Value : localidad);
                    cmd.Parameters.AddWithValue("@Provincia", string.IsNullOrEmpty(provincia) ? (object)DBNull.Value : provincia);
                    cmd.Parameters.AddWithValue("@ActivoDireccion", 1);

                    // Teléfono
                    cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);
                    cmd.Parameters.AddWithValue("@Contacto", string.IsNullOrEmpty(contacto) ? (object)DBNull.Value : contacto);
                    cmd.Parameters.AddWithValue("@Sector", string.IsNullOrEmpty(sector) ? (object)DBNull.Value : sector);
                    cmd.Parameters.AddWithValue("@Horario", string.IsNullOrEmpty(horario) ? (object)DBNull.Value : horario);
                    cmd.Parameters.AddWithValue("@EmailContacto", string.IsNullOrEmpty(emailContacto) ? (object)DBNull.Value : emailContacto);
                    cmd.Parameters.AddWithValue("@ActivoTelefono", 1);

                    SqlParameter pId = new SqlParameter("@IdCliente", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(pId);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    idCliente = pId.Value != DBNull.Value ? Convert.ToInt32(pId.Value) : 0;

                    if (idCliente > 0)
                    {
                        mensaje = $"Cliente insertado correctamente. Id: {idCliente}";
                        return true;
                    }
                    else
                    {
                        mensaje = "No se generó IdCliente al insertar.";
                        return false;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                    mensaje = "Ya existe un cliente con ese código";
                else
                    mensaje = "Error de base de datos: " + sqlEx.Message;
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error general al insertar cliente: " + ex.Message;
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
