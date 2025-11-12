using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class L_Producto
    {
        public bool Insertar(
            string codigo, string nombre, string descripcion,
            int idCategoria, int idMarca, string lote, DateTime fechaVencimiento,
            int diasAvisoVencimiento, decimal precioCompra, decimal precioVenta,
            int stockActual, int stockMinimo, int stockIdeal, int stockMaximo,
            string tipoStock,
            out string mensaje)
        {
            mensaje = "";

            // Validaciones
            if (string.IsNullOrWhiteSpace(codigo))
            {
                mensaje = "El código del producto no puede estar vacío.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensaje = "El nombre del producto no puede estar vacío.";
                return false;
            }
            if (idCategoria <= 0)
            {
                mensaje = "Debe seleccionar una categoría válida.";
                return false;
            }
            if (idMarca <= 0)
            {
                mensaje = "Debe seleccionar una marca válida.";
                return false;
            }
            if (precioCompra < 0 || precioVenta < 0)
            {
                mensaje = "Los precios no pueden ser negativos.";
                return false;
            }
            if (stockActual < 0 || stockMinimo < 0 || stockIdeal < 0 || stockMaximo < 0)
            {
                mensaje = "Los valores de stock no pueden ser negativos.";
                return false;
            }

            return D_Producto.InsertarProducto(
                codigo, nombre, descripcion,
                idCategoria, idMarca, lote, fechaVencimiento,
                diasAvisoVencimiento, precioCompra, precioVenta,
                stockActual, stockMinimo, stockIdeal, stockMaximo,
                tipoStock,
                out mensaje
            );
        }

        public bool Modificar(
            int idProducto, string codigo, string nombre, string descripcion,
            int idCategoria, int idMarca, string lote, DateTime fechaVencimiento,
            int diasAvisoVencimiento, decimal precioCompra, decimal precioVenta,
            int stockActual, int stockMinimo, int stockIdeal, int stockMaximo,
            string tipoStock, bool activo,
            out string mensaje)
        {
            mensaje = "";

            if (idProducto <= 0)
            {
                mensaje = "Debe seleccionar un producto válido.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(codigo))
            {
                mensaje = "El código del producto no puede estar vacío.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensaje = "El nombre del producto no puede estar vacío.";
                return false;
            }
            if (idCategoria <= 0)
            {
                mensaje = "Debe seleccionar una categoría válida.";
                return false;
            }
            if (idMarca <= 0)
            {
                mensaje = "Debe seleccionar una marca válida.";
                return false;
            }
            if (precioCompra < 0 || precioVenta < 0)
            {
                mensaje = "Los precios no pueden ser negativos.";
                return false;
            }

            return D_Producto.ModificarProducto(
                idProducto, codigo, nombre, descripcion,
                idCategoria, idMarca, lote, fechaVencimiento,
                diasAvisoVencimiento, precioCompra, precioVenta,
                stockActual, stockMinimo, stockIdeal, stockMaximo,
                tipoStock, activo,
                out mensaje
            );
        }

        public DataTable Listar()
        {
            return D_Producto.ListarProductos();
        }

        public DataRow ObtenerPorId(int idProducto, out string mensaje)
        {
            if (idProducto <= 0)
            {
                mensaje = "Id inválido.";
                return null;
            }

            return D_Producto.ObtenerPorId(idProducto, out mensaje);
        }

        // Métodos corregidos - usar D_Producto directamente para mantener consistencia
        public DataTable ListarProductosActivos()
        {
            try
            {
                return D_Producto.ListarProductosActivos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos activos: " + ex.Message);
            }
        }

        public DataTable ListarProductosCriticos()
        {
            try
            {
                return D_Producto.ListarProductosCriticos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos críticos: " + ex.Message);
            }
        }

        // Agregar los métodos nuevos que necesitas para el control de stock
        public DataTable ListarControlStockVencimientos()
        {
            try
            {
                return D_Producto.ListarControlStockVencimientos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener control de stock: " + ex.Message);
            }
        }

        public DataTable ObtenerProductosPorEstado(string estado)
        {
            try
            {
                return D_Producto.ObtenerProductosPorEstado(estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener productos {estado}: " + ex.Message);
            }
        }
    }
}