using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class L_Control
    {
        public DataTable ObtenerControlStock(DataTable productos)
        {
            try
            {
                DataTable controlStock = new DataTable();

                // Crear las columnas para el control de stock
                controlStock.Columns.Add("ID", typeof(int));
                controlStock.Columns.Add("Código", typeof(string));
                controlStock.Columns.Add("Producto", typeof(string));
                controlStock.Columns.Add("Categoría", typeof(string));
                controlStock.Columns.Add("Marca", typeof(string));
                controlStock.Columns.Add("Stock Actual", typeof(int));
                controlStock.Columns.Add("Stock Mínimo", typeof(int));
                controlStock.Columns.Add("Stock Ideal", typeof(int));
                controlStock.Columns.Add("Stock Máximo", typeof(int));
                controlStock.Columns.Add("Punto Reposición", typeof(int));
                controlStock.Columns.Add("Estado", typeof(string));
                controlStock.Columns.Add("Nivel", typeof(string));

                // Procesar cada producto
                foreach (DataRow producto in productos.Rows)
                {
                    if (Convert.ToBoolean(producto["Activo"]))
                    {
                        int stockActual = Convert.ToInt32(producto["StockActual"]);
                        int stockMinimo = Convert.ToInt32(producto["StockMinimo"]);
                        int stockIdeal = Convert.ToInt32(producto["StockIdeal"]);
                        int stockMaximo = Convert.ToInt32(producto["StockMaximo"]);

                        int puntoReposicion = CalcularPuntoReposicion(stockMinimo, stockIdeal);
                        string estado = "";
                        string nivel = "";

                        // Determinar el estado del stock
                        if (stockActual <= stockMinimo)
                        {
                            estado = "🔴 CRÍTICO - Reponer URGENTE";
                            nivel = "CRITICO";
                        }
                        else if (stockActual <= puntoReposicion)
                        {
                            estado = "🟡 ALERTA - Considerar reposición";
                            nivel = "ALERTA";
                        }
                        else if (stockActual <= stockIdeal)
                        {
                            estado = "🟢 NORMAL - Stock adecuado";
                            nivel = "NORMAL";
                        }
                        else if (stockActual <= stockMaximo)
                        {
                            estado = "🔵 ÓPTIMO - Stock alto";
                            nivel = "OPTIMO";
                        }
                        else
                        {
                            estado = "⚪ EXCEDIDO - Sobre stock máximo";
                            nivel = "EXCEDIDO";
                        }

                        // Agregar fila al DataTable
                        controlStock.Rows.Add(
                            producto["IdProducto"],
                            producto["Codigo"],
                            producto["Nombre"],
                            producto["Categoria"],
                            producto["Marca"],
                            stockActual,
                            stockMinimo,
                            stockIdeal,
                            stockMaximo,
                            puntoReposicion,
                            estado,
                            nivel
                        );
                    }
                }

                return controlStock;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar control de stock: " + ex.Message);
            }
        }

        private int CalcularPuntoReposicion(int stockMinimo, int stockIdeal)
        {
            if (stockMinimo >= stockIdeal)
                return stockMinimo + 1;

            return stockMinimo + (int)((stockIdeal - stockMinimo) * 0.3);
        }
    }
}