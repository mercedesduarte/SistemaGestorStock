using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_ProveedorDireccion
    {
        // Insertar una nueva dirección
        public bool Insertar(int idProveedor, string direccion, string localidad, string provincia, out string mensaje)
        {
            return D_ProveedorDireccion.InsertarDireccion(idProveedor, direccion, localidad, provincia, out mensaje);
        }

        // Modificar dirección existente
        public bool Modificar(int idDireccion, string direccion, string localidad, string provincia, bool activo, out string mensaje)
        {
            return D_ProveedorDireccion.ModificarDireccion(idDireccion, direccion, localidad, provincia, activo, out mensaje);
        }

        // Listar todas las direcciones de un proveedor
        public DataTable Listar(int idProveedor)
        {
            return D_ProveedorDireccion.ListarDirecciones(idProveedor);
        }

        // Obtener una dirección específica por su ID
        public DataRow ObtenerPorId(int idDireccion, out string mensaje)
        {
            return D_ProveedorDireccion.ObtenerPorId(idDireccion, out mensaje);
        }
    }
}

