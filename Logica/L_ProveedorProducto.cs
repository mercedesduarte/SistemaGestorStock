using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_ProveedorProducto
    {
        // 🔹 Insertar relación Producto-Proveedor
        public bool Insertar(
            int idProducto, int idProveedor, decimal precioCompra, string catalogo,
            out string mensaje)
        {
            return D_ProveedorProducto.InsertarProveedorProducto(
                idProducto, idProveedor, precioCompra, catalogo, out mensaje
            );
        }

        // 🔹 Modificar relación Producto-Proveedor
        public bool Modificar(
            int idProductoProveedor, int idProducto, int idProveedor,
            decimal precioCompra, string catalogo, bool activo,
            out string mensaje)
        {
            return D_ProveedorProducto.ModificarProveedorProducto(
                idProductoProveedor, idProducto, idProveedor,
                precioCompra, catalogo, activo, out mensaje
            );
        }

        // 🔹 Listar productos de un proveedor
        public DataTable ListarProductosPorProveedor(int idProveedor)
        {
            try
            {
                return D_ProveedorProducto.ListarProductosPorProveedor(idProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos del proveedor: " + ex.Message);
            }
        }

        // 🔹 Listar proveedores de un producto
        public DataTable ListarProveedoresPorProducto(int idProducto)
        {
            try
            {
                return D_ProveedorProducto.ListarProveedoresPorProducto(idProducto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar proveedores del producto: " + ex.Message);
            }
        }

        // 🔹 Obtener relación por Id
        public DataRow ObtenerPorId(int idProductoProveedor, out string mensaje)
        {
            return D_ProveedorProducto.ObtenerPorId(idProductoProveedor, out mensaje);
        }
    }
}

