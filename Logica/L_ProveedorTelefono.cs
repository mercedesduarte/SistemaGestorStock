using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_ProveedorTelefono
    {
        // Insertar Teléfono
        public bool Insertar(int idProveedor, string telefono, string contacto,
                             string sector, string horario, string emailContacto,
                             out string mensaje)
        {
            mensaje = "";

            if (idProveedor <= 0)
            {
                mensaje = "Debe seleccionar un proveedor válido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                mensaje = "El número de teléfono no puede estar vacío.";
                return false;
            }

            return D_ProveedorTelefono.InsertarTelefono(
                idProveedor, telefono, contacto, sector, horario, emailContacto, out mensaje);
        }

        // Listar Teléfonos por proveedor
        public DataTable Listar(int idProveedor)
        {
            if (idProveedor <= 0)
            {
                throw new Exception("Debe seleccionar un proveedor válido.");
            }

            return D_ProveedorTelefono.ListarTelefonos(idProveedor);
        }

        // Modificar Teléfono
        public bool Modificar(int idTelefono, string telefono, string contacto,
                              string sector, string horario, string emailContacto,
                              bool activo,
                              out string mensaje)
        {
            mensaje = "";

            if (idTelefono <= 0)
            {
                mensaje = "Debe seleccionar un teléfono válido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                mensaje = "El número de teléfono no puede estar vacío.";
                return false;
            }

            return D_ProveedorTelefono.ModificarTelefono(
                idTelefono, telefono, contacto, sector, horario, emailContacto, activo, out mensaje);
        }

        public DataRow ObtenerPorId(int idTelefono, out string mensaje)
        {
            return D_ProveedorTelefono.ObtenerPorId(idTelefono, out mensaje);
        }

    }
}

