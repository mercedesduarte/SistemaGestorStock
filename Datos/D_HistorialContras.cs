using Datos.Conecction;
using Datos.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos

//Seguir mas tarde con la implementacion en la logica

{
    public class D_HistorialContras
    {
        public List<HistorialContrasDTO> ContrasenasAnteriores()
        {
            List<HistorialContrasDTO> lista = new List<HistorialContrasDTO>();

            try
            {
                using (SqlConnection conexion = ConnectionBD.ObtenerConexion())
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_BuscarContraseñas", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                lista = null;
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    HistorialContrasDTO historial = new HistorialContrasDTO
                                    {
                                        id_Contrasena = Convert.ToInt32(reader["Id_Historial"]),
                                        contrasena = reader["Contrasena"].ToString()
                                    };

                                    lista.Add(historial);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar las contraseñas del usuario: ", ex);
            }

            return lista;
        }
    }
}
