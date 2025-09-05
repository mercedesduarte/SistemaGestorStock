using System.Collections.Generic;
using Datos;
using Datos.DTOs;
using Sesion;

namespace Logica
{
    public class L_DatosUsuario
    {
        private D_DatosUsuario datosUsuario = new D_DatosUsuario();

        public List<string> ObtenerDatosUsuario()
        {
            string usuarioSesion = SesionUsuario.Usuario;
            List<DUsuarioDTO> datos = datosUsuario.MostrarDatosUsuario(usuarioSesion);

            List<string> listaDatos = new List<string>();

            if (datos.Count > 0)
            {
                listaDatos.Add(datos[0].Nombre);
                listaDatos.Add(datos[0].Apellido);
                listaDatos.Add(datos[0].Email);
            }

            return listaDatos;
        }
    }
}
