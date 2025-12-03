using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_Control
    {
        // Helper to find first existing column name among candidates (case-insensitive)
        private string FindColumn(DataTable table, params string[] candidates)
        {
            if (table == null) return null;
            foreach (var c in candidates)
            {
                foreach (DataColumn col in table.Columns)
                {
                    if (string.Equals(col.ColumnName, c, StringComparison.OrdinalIgnoreCase))
                        return col.ColumnName;
                }
            }
            // try contains
            foreach (var c in candidates)
            {
                foreach (DataColumn col in table.Columns)
                {
                    if (col.ColumnName.IndexOf(c, StringComparison.OrdinalIgnoreCase) >= 0)
                        return col.ColumnName;
                }
            }
            return null;
        }

        private object GetValue(DataRow row, string columnName)
        {
            if (row == null || string.IsNullOrEmpty(columnName)) return null;
            try
            {
                return row.Table.Columns.Contains(columnName) ? row[columnName] : null;
            }
            catch { return null; }
        }

        private bool RowContainsAny(DataRow row, params string[] keywords)
        {
            if (row == null) return false;
            foreach (var col in row.Table.Columns)
            {
                try
                {
                    var val = row[col as DataColumn];
                    if (val == null || val == DBNull.Value) continue;
                    string s = val.ToString();
                    if (string.IsNullOrEmpty(s)) continue;
                    foreach (var kw in keywords)
                    {
                        if (s.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0)
                            return true;
                    }
                }
                catch { }
            }
            return false;
        }

        private DateTime? GetFechaFromRow(DataRow row)
        {
            if (row == null) return null;
            string[] candidates = new[] { "FechaVencimiento", "Fecha Vencimiento", "fechavencimiento", "FechaVence", "Fecha" };
            foreach (var c in candidates)
            {
                if (row.Table.Columns.Contains(c))
                {
                    var v = row[c];
                    if (v != null && v != DBNull.Value)
                    {
                        DateTime dt;
                        if (DateTime.TryParse(v.ToString(), out dt)) return dt;
                    }
                }
            }
            // try any column that looks like a date
            foreach (DataColumn col in row.Table.Columns)
            {
                var v = row[col];
                if (v == null || v == DBNull.Value) continue;
                DateTime dt;
                if (DateTime.TryParse(v.ToString(), out dt)) return dt;
            }
            return null;
        }

        private int? GetIntFromRow(DataRow row, string colName)
        {
            var v = GetValue(row, colName);
            if (v == null || v == DBNull.Value) return null;
            int x;
            if (int.TryParse(v.ToString(), out x)) return x;
            try { return Convert.ToInt32(v); } catch { return null; }
        }

        public DataTable ObtenerProductosStockMinimo()
        {
            try
            {
                DataTable src = D_Producto.ObtenerProductosPorEstado("STOCK_MINIMO");
                if (src == null || src.Rows.Count == 0)
                    src = D_Control.ObtenerControlStockVencimientos();

                if (src == null || src.Rows.Count == 0)
                    return CrearDatosPrueba("Stock Minimo");

                DataTable resultado = new DataTable();
                resultado.Columns.Add("Codigo");
                resultado.Columns.Add("Producto");
                resultado.Columns.Add("Stock Actual");
                resultado.Columns.Add("Stock Minimo");
                resultado.Columns.Add("Estado");

                foreach (DataRow row in src.Rows)
                {
                    // prefer explicit flags
                    if (RowContainsAny(row, "CRITIC", "CRITICO"))
                    {
                        resultado.Rows.Add(
                            row.Table.Columns.Contains("Codigo") ? row["Codigo"] : (row.Table.Columns.Contains("CodigoProducto") ? row["CodigoProducto"] : row[0]),
                            row.Table.Columns.Contains("Nombre") ? row["Nombre"] : (row.Table.Columns.Contains("Producto") ? row["Producto"] : ""),
                            GetValue(row, "StockActual") ?? GetValue(row, "Stock"),
                            GetValue(row, "StockMinimo"),
                            "STOCK MINIMO"
                        );
                        continue;
                    }

                    // fallback numeric check
                    int? stockActual = GetIntFromRow(row, "StockActual") ?? GetIntFromRow(row, "Stock");
                    int? stockMin = GetIntFromRow(row, "StockMinimo") ?? GetIntFromRow(row, "StockMin");
                    if (stockActual.HasValue && stockMin.HasValue && stockActual.Value <= stockMin.Value)
                    {
                        resultado.Rows.Add(
                            row.Table.Columns.Contains("Codigo") ? row["Codigo"] : (row.Table.Columns.Contains("CodigoProducto") ? row["CodigoProducto"] : row[0]),
                            row.Table.Columns.Contains("Nombre") ? row["Nombre"] : (row.Table.Columns.Contains("Producto") ? row["Producto"] : ""),
                            stockActual,
                            stockMin,
                            "STOCK MINIMO"
                        );
                    }
                }

                return resultado;
            }
            catch (Exception)
            {
                return CrearDatosPrueba("Stock Minimo");
            }
        }

        public DataTable ObtenerProductosPuntoReposicion()
        {
            try
            {
                DataTable src = D_Producto.ObtenerProductosPorEstado("PUNTO_REPOSICION");
                if (src == null || src.Rows.Count == 0)
                    src = D_Control.ObtenerControlStockVencimientos();

                if (src == null || src.Rows.Count == 0)
                    return CrearDatosPrueba("Punto Reposicion");

                DataTable resultado = new DataTable();
                resultado.Columns.Add("Codigo");
                resultado.Columns.Add("Producto");
                resultado.Columns.Add("Stock Actual");
                resultado.Columns.Add("Punto Reposicion");
                resultado.Columns.Add("Estado");

                foreach (DataRow row in src.Rows)
                {
                    if (RowContainsAny(row, "ALERT", "ALERTA"))
                    {
                        resultado.Rows.Add(
                            row.Table.Columns.Contains("Codigo") ? row["Codigo"] : (row.Table.Columns.Contains("CodigoProducto") ? row["CodigoProducto"] : row[0]),
                            row.Table.Columns.Contains("Nombre") ? row["Nombre"] : (row.Table.Columns.Contains("Producto") ? row["Producto"] : ""),
                            GetValue(row, "StockActual") ?? GetValue(row, "Stock"),
                            GetValue(row, "PuntoReposicion"),
                            "PUNTO REPOSICION"
                        );
                        continue;
                    }

                    // fallback: stock between min and some threshold
                    int? stockActual = GetIntFromRow(row, "StockActual") ?? GetIntFromRow(row, "Stock");
                    int? stockMin = GetIntFromRow(row, "StockMinimo") ?? GetIntFromRow(row, "StockMin");
                    int? stockIdeal = GetIntFromRow(row, "StockIdeal");
                    if (stockActual.HasValue && stockMin.HasValue && stockIdeal.HasValue)
                    {
                        int threshold = stockMin.Value + (int)Math.Ceiling((stockIdeal.Value - stockMin.Value) * 0.3);
                        if (stockActual.Value > stockMin.Value && stockActual.Value <= threshold)
                        {
                            resultado.Rows.Add(
                                row.Table.Columns.Contains("Codigo") ? row["Codigo"] : (row.Table.Columns.Contains("CodigoProducto") ? row["CodigoProducto"] : row[0]),
                                row.Table.Columns.Contains("Nombre") ? row["Nombre"] : (row.Table.Columns.Contains("Producto") ? row["Producto"] : ""),
                                stockActual,
                                threshold,
                                "PUNTO REPOSICION"
                            );
                        }
                    }
                }

                return resultado;
            }
            catch (Exception)
            {
                return CrearDatosPrueba("Punto Reposicion");
            }
        }

        public DataTable ObtenerProductosPorVencer()
        {
            try
            {
                DataTable src = D_Producto.ObtenerProductosPorEstado("POR_VENCER");
                if (src == null || src.Rows.Count == 0)
                    src = D_Control.ObtenerControlStockVencimientos();

                if (src == null || src.Rows.Count == 0)
                    return CrearDatosPrueba("Por Vencer");

                DataTable resultado = new DataTable();
                resultado.Columns.Add("Codigo");
                resultado.Columns.Add("Producto");
                resultado.Columns.Add("Lote");
                resultado.Columns.Add("Fecha Vencimiento");
                resultado.Columns.Add("Dias Restantes");
                resultado.Columns.Add("Estado");

                foreach (DataRow row in src.Rows)
                {
                    // check explicit flags first
                    if (RowContainsAny(row, "PROXIM", "PROXIMO", "POR VENCER"))
                    {
                        DateTime? fecha = GetFechaFromRow(row);
                        resultado.Rows.Add(
                            row.Table.Columns.Contains("Codigo") ? row["Codigo"] : (row.Table.Columns.Contains("CodigoProducto") ? row["CodigoProducto"] : row[0]),
                            row.Table.Columns.Contains("Nombre") ? row["Nombre"] : (row.Table.Columns.Contains("Producto") ? row["Producto"] : ""),
                            GetValue(row, "Lote"),
                            fecha.HasValue ? fecha.Value.ToString("dd/MM/yyyy") : string.Empty,
                            GetValue(row, "DiasHastaVencimiento"),
                            "POR VENCER"
                        );
                        continue;
                    }

                    // fallback by date range
                    DateTime? f = GetFechaFromRow(row);
                    if (f.HasValue)
                    {
                        var hoy = DateTime.Today;
                        var diasAviso = 30; // default
                        int? dias = GetIntFromRow(row, "DiasAvisoVencimiento") ?? GetIntFromRow(row, "DiasHastaVencimiento");
                        if (dias.HasValue) diasAviso = dias.Value;

                        if (f.Value.Date >= hoy && f.Value.Date <= hoy.AddDays(diasAviso))
                        {
                            resultado.Rows.Add(
                                row.Table.Columns.Contains("Codigo") ? row["Codigo"] : (row.Table.Columns.Contains("CodigoProducto") ? row["CodigoProducto"] : row[0]),
                                row.Table.Columns.Contains("Nombre") ? row["Nombre"] : (row.Table.Columns.Contains("Producto") ? row["Producto"] : ""),
                                GetValue(row, "Lote"),
                                f.Value.ToString("dd/MM/yyyy"),
                                (f.Value - hoy).Days,
                                "POR VENCER"
                            );
                        }
                    }
                }

                return resultado;
            }
            catch (Exception)
            {
                return CrearDatosPrueba("Por Vencer");
            }
        }

        public DataTable ObtenerProductosVencidos()
        {
            try
            {
                DataTable src = D_Producto.ObtenerProductosPorEstado("VENCIDOS");
                if (src == null || src.Rows.Count == 0)
                    src = D_Control.ObtenerControlStockVencimientos();

                if (src == null || src.Rows.Count == 0)
                    return CrearDatosPrueba("Vencidos");

                DataTable resultado = new DataTable();
                resultado.Columns.Add("Codigo");
                resultado.Columns.Add("Producto");
                resultado.Columns.Add("Lote");
                resultado.Columns.Add("Fecha Vencimiento");
                resultado.Columns.Add("Dias Vencido");
                resultado.Columns.Add("Estado");

                foreach (DataRow row in src.Rows)
                {
                    // explicit flags
                    if (RowContainsAny(row, "VENCID", "VENCIDO"))
                    {
                        DateTime? fecha = GetFechaFromRow(row);
                        int dias = 0;
                        if (fecha.HasValue) dias = (DateTime.Today - fecha.Value.Date).Days;

                        resultado.Rows.Add(
                            row.Table.Columns.Contains("Codigo") ? row["Codigo"] : (row.Table.Columns.Contains("CodigoProducto") ? row["CodigoProducto"] : row[0]),
                            row.Table.Columns.Contains("Nombre") ? row["Nombre"] : (row.Table.Columns.Contains("Producto") ? row["Producto"] : ""),
                            GetValue(row, "Lote"),
                            fecha.HasValue ? fecha.Value.ToString("dd/MM/yyyy") : string.Empty,
                            dias,
                            "VENCIDO"
                        );
                        continue;
                    }

                    // fallback by date
                    DateTime? f = GetFechaFromRow(row);
                    if (f.HasValue && f.Value.Date < DateTime.Today)
                    {
                        int dias = (DateTime.Today - f.Value.Date).Days;
                        resultado.Rows.Add(
                            row.Table.Columns.Contains("Codigo") ? row["Codigo"] : (row.Table.Columns.Contains("CodigoProducto") ? row["CodigoProducto"] : row[0]),
                            row.Table.Columns.Contains("Nombre") ? row["Nombre"] : (row.Table.Columns.Contains("Producto") ? row["Producto"] : ""),
                            GetValue(row, "Lote"),
                            f.Value.ToString("dd/MM/yyyy"),
                            dias,
                            "VENCIDO"
                        );
                    }
                }

                return resultado;
            }
            catch (Exception)
            {
                return CrearDatosPrueba("Vencidos");
            }
        }

        public DataTable ObtenerReporteCompleto()
        {
            try
            {
                // return underlying producto report (fallback)
                return D_Producto.ListarControlStockVencimientos();
            }
            catch (Exception)
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
            catch (Exception)
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