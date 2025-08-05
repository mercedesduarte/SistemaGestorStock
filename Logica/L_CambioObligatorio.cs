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
        public bool CambiaContra(string usuario, string contrasena, string confcontra)
        {
            DateTime fechaCambio = DateTime.Now;

            if (contrasena != confcontra)
            {
                throw new ArgumentException("Las contraseñas no coinciden.");
            }
            else
            {

                string hash = HashconUsu.Hashconusu(usuario, contrasena);


                return D_CambioObligatorio.ActualizarContra(usuario, hash, fechaCambio);
            }
        }
    }
}