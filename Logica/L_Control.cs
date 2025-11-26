using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_Control
    {
        public DataTable ObtenerProductosStockMinimo()
        {
            try
            {
                DataTable todosLosDatos = D_Control.ObtenerControlStockVencimientos();
                DataTable resultado = new DataTable();

                resultado.Columns.Add("Codigo");
                resultado.Columns.Add("Producto");
                resultado.Columns.Add("Stock Actual");
                resultado.Columns.Add("Stock Minimo");
                resultado.Columns.Add("Estado");

                foreach (DataRow row in todosLosDatos.Rows)
                {
                    if (row["EstadoStock"].ToString() == "CRITICO")
                    {
                        resultado.Rows.Add(
                            row["Codigo"],
                            row["Nombre"],
                            row["StockActual"],
                            row["StockMinimo"],
                            "STOCK MINIMO"
                        );
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                return CrearDatosPrueba("Stock Minimo");
            }
        }

        public DataTable ObtenerProductosPuntoReposicion()
        {
            try
            {
                DataTable todosLosDatos = D_Control.ObtenerControlStockVencimientos();
                DataTable resultado = new DataTable();

                resultado.Columns.Add("Codigo");
                resultado.Columns.Add("Producto");
                resultado.Columns.Add("Stock Actual");
                resultado.Columns.Add("Punto Reposicion");
                resultado.Columns.Add("Estado");

                foreach (DataRow row in todosLosDatos.Rows)
                {
                    if (row["EstadoStock"].ToString() == "ALERTA")
                    {
                        resultado.Rows.Add(
                            row["Codigo"],
                            row["Nombre"],
                            row["StockActual"],
                            row["PuntoReposicion"],
                            "PUNTO REPOSICION"
                        );
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                return CrearDatosPrueba("Punto Reposicion");
            }
        }

        public DataTable ObtenerProductosPorVencer()
        {
            try
            {
                DataTable todosLosDatos = D_Control.ObtenerControlStockVencimientos();
                DataTable resultado = new DataTable();

                resultado.Columns.Add("Codigo");
                resultado.Columns.Add("Producto");
                resultado.Columns.Add("Lote");
                resultado.Columns.Add("Fecha Vencimiento");
                resultado.Columns.Add("Dias Restantes");
                resultado.Columns.Add("Estado");

                foreach (DataRow row in todosLosDatos.Rows)
                {
                    if (row["EstadoVencimiento"].ToString() == "PROXIMO_VENCER")
                    {
                        resultado.Rows.Add(
                            row["Codigo"],
                            row["Nombre"],
                            row["Lote"],
                            Convert.ToDateTime(row["FechaVencimiento"]).ToString("dd/MM/yyyy"),
                            row["DiasHastaVencimiento"],
                            "POR VENCER"
                        );
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                return CrearDatosPrueba("Por Vencer");
            }
        }

        public DataTable ObtenerProductosVencidos()
        {
            try
            {
                DataTable todosLosDatos = D_Control.ObtenerControlStockVencimientos();
                DataTable resultado = new DataTable();

                resultado.Columns.Add("Codigo");
                resultado.Columns.Add("Producto");
                resultado.Columns.Add("Lote");
                resultado.Columns.Add("Fecha Vencimiento");
                resultado.Columns.Add("Dias Vencido");
                resultado.Columns.Add("Estado");

                foreach (DataRow row in todosLosDatos.Rows)
                {
                    if (row["EstadoVencimiento"].ToString() == "VENCIDO")
                    {
                        resultado.Rows.Add(
                            row["Codigo"],
                            row["Nombre"],
                            row["Lote"],
                            Convert.ToDateTime(row["FechaVencimiento"]).ToString("dd/MM/yyyy"),
                            row["DiasHastaVencimiento"],
                            "VENCIDO"
                        );
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                return CrearDatosPrueba("Vencidos");
            }
        }

        public DataTable ObtenerReporteCompleto()
        {
            try
            {
                return D_Control.ObtenerControlStockVencimientos();
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public DataTable ObtenerProductosCriticos()
        {
            try
            {
                return D_Control.ObtenerProductosCriticos();
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        private DataTable CrearDatosPrueba(string tipo)
        {
            DataTable dt = new DataTable();

            switch (tipo)
            {
                case "Stock Minimo":
                    dt.Columns.Add("Codigo");
                    dt.Columns.Add("Producto");
                    dt.Columns.Add("Stock Actual");
                    dt.Columns.Add("Stock Minimo");
                    dt.Columns.Add("Estado");
                    dt.Rows.Add("TEST001", "Aspirina 500mg", 5, 10, "STOCK MINIMO");
                    dt.Rows.Add("TEST002", "Jarabe para la tos", 3, 15, "STOCK MINIMO");
                    break;

                case "Punto Reposicion":
                    dt.Columns.Add("Codigo");
                    dt.Columns.Add("Producto");
                    dt.Columns.Add("Stock Actual");
                    dt.Columns.Add("Punto Reposicion");
                    dt.Columns.Add("Estado");
                    dt.Rows.Add("TEST003", "Analgesico", 25, 30, "PUNTO REPOSICION");
                    break;

                case "Por Vencer":
                    dt.Columns.Add("Codigo");
                    dt.Columns.Add("Producto");
                    dt.Columns.Add("Lote");
                    dt.Columns.Add("Fecha Vencimiento");
                    dt.Columns.Add("Dias Restantes");
                    dt.Columns.Add("Estado");
                    dt.Rows.Add("TEST004", "Antibiotico", "LOTE-2024", "15/12/2024", 15, "POR VENCER");
                    break;

                case "Vencidos":
                    dt.Columns.Add("Codigo");
                    dt.Columns.Add("Producto");
                    dt.Columns.Add("Lote");
                    dt.Columns.Add("Fecha Vencimiento");
                    dt.Columns.Add("Dias Vencido");
                    dt.Columns.Add("Estado");
                    dt.Rows.Add("TEST005", "Jarabe Expectorante", "LOTE-2023", "15/10/2024", 30, "VENCIDO");
                    break;
            }

            return dt;
        }
    }
}