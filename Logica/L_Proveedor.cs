using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class L_Proveedor
    {
        public bool Insertar(string codigo, string razonSocial, string cuit, string email,
                             string formaPago, int? tiempoEntrega, decimal descuento, out string mensaje)
        {
            mensaje = "";

            if (string.IsNullOrWhiteSpace(razonSocial))
            {
                mensaje = "La razón social del proveedor no puede estar vacía.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cuit))
            {
                mensaje = "El CUIT del proveedor no puede estar vacío.";
                return false;
            }

            return D_Proveedor.InsertarProveedor(codigo, razonSocial, cuit, email, formaPago, tiempoEntrega, descuento, out mensaje);
        }

        public bool Modificar(int idProveedor, string codigo, string razonSocial, string cuit, string email,
                              string formaPago, int? tiempoEntrega, decimal descuento, bool activo, out string mensaje)
        {
            mensaje = "";

            if (idProveedor <= 0)
            {
                mensaje = "Debe seleccionar un proveedor válido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(razonSocial))
            {
                mensaje = "La razón social del proveedor no puede estar vacía.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cuit))
            {
                mensaje = "El CUIT del proveedor no puede estar vacío.";
                return false;
            }

            return D_Proveedor.ModificarProveedor(idProveedor, codigo, razonSocial, cuit, email, formaPago, tiempoEntrega, descuento, activo, out mensaje);
        }

        public DataTable Listar()
        {
            return D_Proveedor.ListarProveedores();
        }

        public DataTable BuscarPorNombreOCuit(string filtro)
        {
            return D_Proveedor.BuscarProveedorPorNombreOCuit(filtro);
        }

        public DataRow ObtenerPorId(int idProveedor, out string mensaje)
        {
            return D_Proveedor.ObtenerPorId(idProveedor, out mensaje);
        }
    }
}
