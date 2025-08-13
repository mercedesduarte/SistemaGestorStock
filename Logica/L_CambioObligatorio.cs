using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sesion;

namespace Logica
{
    public class L_CambioObligatorio
    {

        public bool CambiaContra(int idUsuario, string usuario, string contrasena, string confcontra)
        {
            if (contrasena != confcontra)
                throw new ArgumentException("Las contraseñas no coinciden.");

            DateTime fechaCambio = DateTime.Now;
            string hash = HashconUsu.Hashconusu(usuario, contrasena);

            return D_CambioObligatorio.ActualizarContra(idUsuario, hash, fechaCambio);
        }


    }
}