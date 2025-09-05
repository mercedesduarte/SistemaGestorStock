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
{
    public class D_TraerRol
    {
        public List<PermisoDTO> ObtenerPermisosPorRol(int idRol)
        {
            var lista = new List<PermisoDTO>();

            using (var conexion = ConnectionBD.ObtenerConexion())
            {
                conexion.Open();
                using (var cmd = new SqlCommand("sp_TraerPermisos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdRol", idRol);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new PermisoDTO
                            {
                                Id_Permiso = Convert.ToInt32(dr["Id_Permiso"]),
                                Permiso = dr["Permiso"].ToString(),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }

    }
}
