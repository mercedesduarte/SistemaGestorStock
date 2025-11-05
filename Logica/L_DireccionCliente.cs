using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_ClienteDireccion
    {
        
        public bool Insertar(int idCliente, string direccion, string localidad, string provincia, out string mensaje)
        {
            return D_ClienteDireccion.InsertarDireccion(idCliente, direccion, localidad, provincia, out mensaje);
        }

        
        public bool Modificar(int idDireccion, string direccion, string localidad, string provincia, bool activo, out string mensaje)
        {
            return D_ClienteDireccion.ModificarDireccion(idDireccion, direccion, localidad, provincia, activo, out mensaje);
        }

       
        public DataTable Listar(int idCliente)
        {
            return D_ClienteDireccion.ListarDirecciones(idCliente);
        }

        
        public DataRow ObtenerPorId(int idDireccion, out string mensaje)
        {
            return D_ClienteDireccion.ObtenerPorId(idDireccion, out mensaje);
        }
    }
}
