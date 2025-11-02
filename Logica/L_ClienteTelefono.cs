using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class L_ClienteTelefono
    {
        // 🔹 Insertar teléfono
        public bool Insertar(int idCliente, string telefono, string contacto, string sector,
                             string horario, string emailContacto, bool activo, out string mensaje)
        {
            return D_ClienteTelefono.InsertarClienteTelefono(
                idCliente, telefono, contacto, sector, horario, emailContacto, activo, out mensaje);
        }

        // 🔹 Listar teléfonos por cliente
        public DataTable ListarPorCliente(int idCliente)
        {
            return D_ClienteTelefono.ListarClienteTelefonos(idCliente);
        }

        // 🔹 Modificar teléfono
        public bool Modificar(int idClienteTelefono, string telefono, string contacto, string sector,
                              string horario, string emailContacto, bool activo, out string mensaje)
        {
            return D_ClienteTelefono.ModificarClienteTelefono(
                idClienteTelefono, telefono, contacto, sector, horario, emailContacto, activo, out mensaje);
        }

        // 🔹 Obtener un teléfono por su ID
        public DataRow ObtenerPorId(int idClienteTelefono, out string mensaje)
        {
            return D_ClienteTelefono.ObtenerPorId(idClienteTelefono, out mensaje);
        }
    }
}

