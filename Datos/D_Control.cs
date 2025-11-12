using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Conecction;

namespace Datos
{
    public class D_Control
    {
        // Obtener reporte completo de control de stock y vencimientos
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

        // Obtener productos críticos
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

        // Obtener productos por estado específico
        public static DataTable ObtenerProductosPorEstado(string estado)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection cn = ConnectionBD.ObtenerConexion())
                {
                    string query = @"
                        SELECT 
                            p.IdProducto,
                            p.Codigo,
                            p.Nombre,
                            p.Descripcion,
                            c.Nombre AS Categoria,
                            m.Nombre AS Marca,
                            p.Lote,
                            p.FechaVencimiento,
                            p.DiasAvisoVencimiento,
                            p.StockActual,
                            p.StockMinimo,
                            p.StockIdeal,
                            p.StockMaximo,
                            p.Activo
                        FROM Productos p
                        INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria
                        INNER JOIN Marcas m ON p.IdMarca = m.IdMarca
                        WHERE p.Activo = 1 AND ";

                    switch (estado.ToUpper())
                    {
                        case "STOCK_MINIMO":
                            query += "p.StockActual <= p.StockMinimo";
                            break;
                        case "VENCIDOS":
                            query += "p.FechaVencimiento < GETDATE()";
                            break;
                        case "POR_VENCER":
                            query += "p.FechaVencimiento BETWEEN GETDATE() AND DATEADD(DAY, ISNULL(p.DiasAvisoVencimiento, 30), GETDATE())";
                            break;
                        case "PUNTO_REPOSICION":
                            query += "p.StockActual > p.StockMinimo AND p.StockActual <= (p.StockMinimo + CAST((p.StockIdeal - p.StockMinimo) * 0.3 AS INT))";
                            break;
                        default:
                            query += "p.Activo = 1";
                            break;
                    }

                    query += " ORDER BY p.Nombre";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al listar productos {estado}: " + ex.Message);
            }
            return tabla;
        }
    }
}