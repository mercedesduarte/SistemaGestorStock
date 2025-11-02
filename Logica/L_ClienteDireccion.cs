using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_ClienteDireccion
    {
        // 🔹 Insertar una nueva dirección
        public bool Insertar(int idCliente, string direccion, string localidad, string provincia, bool activo)
        {
            try
            {
                return D_ClienteDireccion.InsertarClienteDireccion(idCliente, direccion, localidad, provincia, activo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la dirección del cliente: " + ex.Message);
            }
        }

        // 🔹 Listar direcciones por cliente
        public DataTable ListarPorCliente(int idCliente)
        {
            try
            {
                return D_ClienteDireccion.ListarClienteDirecciones(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las direcciones del cliente: " + ex.Message);
            }
        }

        // 🔹 Modificar dirección
        public bool Modificar(int idClienteDireccion, string direccion, string localidad, string provincia, bool activo)
        {
            try
            {
                return D_ClienteDireccion.ModificarClienteDireccion(idClienteDireccion, direccion, localidad, provincia, activo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la dirección del cliente: " + ex.Message);
            }
        }

        // 🔹 Obtener una dirección por ID
        public DataRow ObtenerPorId(int idClienteDireccion)
        {
            try
            {
                return D_ClienteDireccion.ObtenerPorId(idClienteDireccion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la dirección del cliente: " + ex.Message);
            }
        }
    }
}
