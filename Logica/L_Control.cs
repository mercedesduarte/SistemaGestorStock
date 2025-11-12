using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_Control
    {
        // Obtener reporte completo de control de stock
        public DataTable ObtenerControlStockVencimientos()
        {
            try
            {
                return D_Control.ObtenerControlStockVencimientos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener control de stock: " + ex.Message);
            }
        }

        // Obtener productos críticos
        public DataTable ObtenerProductosCriticos()
        {
            try
            {
                return D_Control.ObtenerProductosCriticos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos críticos: " + ex.Message);
            }
        }

        // Obtener productos con stock mínimo
        public DataTable ObtenerProductosStockMinimo()
        {
            try
            {
                return D_Control.ObtenerProductosPorEstado("STOCK_MINIMO");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos con stock mínimo: " + ex.Message);
            }
        }

        // Obtener productos en punto de reposición
        public DataTable ObtenerProductosPuntoReposicion()
        {
            try
            {
                return D_Control.ObtenerProductosPorEstado("PUNTO_REPOSICION");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos en punto de reposición: " + ex.Message);
            }
        }

        // Obtener productos próximos a vencer
        public DataTable ObtenerProductosPorVencer()
        {
            try
            {
                return D_Control.ObtenerProductosPorEstado("POR_VENCER");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos por vencer: " + ex.Message);
            }
        }

        // Obtener productos vencidos
        public DataTable ObtenerProductosVencidos()
        {
            try
            {
                return D_Control.ObtenerProductosPorEstado("VENCIDOS");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos vencidos: " + ex.Message);
            }
        }
    }
}