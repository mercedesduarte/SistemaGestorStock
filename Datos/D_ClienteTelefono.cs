using Datos.Conecction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class D_ClienteTelefono
    {
        public static bool InsertarClienteTelefono(int idCliente, string telefono, string contacto, string sector,
                                                   string horario, string emailContacto, bool activo, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarClienteTelefono", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 60;

                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Contacto", contacto);
                        cmd.Parameters.AddWithValue("@Sector", sector);
                        cmd.Parameters.AddWithValue("@Horario", horario);
                        cmd.Parameters.AddWithValue("@EmailContacto", emailContacto);
                        cmd.Parameters.AddWithValue("@Activo", activo);

                        cn.Open();
                        cmd.ExecuteNonQuery();

                        mensaje = "Teléfono agregado correctamente.";
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }

        // Overload that uses existing connection and transaction
        public static bool InsertarClienteTelefono(SqlConnection cn, SqlTransaction tran, int idCliente, string telefono, string contacto, string sector,
                                                   string horario, string emailContacto, bool activo)
        {
            using (SqlCommand cmd = new SqlCommand("sp_InsertarClienteTelefono", cn, tran))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 60;

                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Contacto", contacto);
                cmd.Parameters.AddWithValue("@Sector", sector);
                cmd.Parameters.AddWithValue("@Horario", horario);
                cmd.Parameters.AddWithValue("@EmailContacto", emailContacto);
                cmd.Parameters.AddWithValue("@Activo", activo);

                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public static DataTable ListarClienteTelefonos(int idCliente)
        {
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarClienteTelefonos", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                        cn.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        return dt;
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public static bool ModificarClienteTelefono(int idClienteTelefono, string telefono, string contacto, string sector,
                                                    string horario, string emailContacto, bool activo, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ModificarClienteTelefono", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdClienteTelefono", idClienteTelefono);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@Contacto", contacto);
                        cmd.Parameters.AddWithValue("@Sector", sector);
                        cmd.Parameters.AddWithValue("@Horario", horario);
                        cmd.Parameters.AddWithValue("@EmailContacto", emailContacto);
                        cmd.Parameters.AddWithValue("@Activo", activo);

                        cn.Open();
                        cmd.ExecuteNonQuery();

                        mensaje = "Teléfono modificado correctamente.";
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }

        public static DataRow ObtenerPorId(int idClienteTelefono, out string mensaje)
        {
            mensaje = "";
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerClienteTelefonoPorId", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdClienteTelefono", idClienteTelefono);

                        cn.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());

                        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return null;
            }
        }
    }
}

