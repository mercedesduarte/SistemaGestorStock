using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;

namespace Datos
{
    public class D_Control
    {
        public static DataTable ObtenerControlStockVencimientos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ReporteControlStockVencimientos", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener control de stock: " + ex.Message);
            }
            return tabla;
        }

        public static DataTable ObtenerProductosCriticos()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ReporteProductosCriticos", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos críticos: " + ex.Message);
            }
            return tabla;
        }
    }
}