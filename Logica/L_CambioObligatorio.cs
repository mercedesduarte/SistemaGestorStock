using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class L_CambioObligatorio
    {
        public bool CambiaContra(int idPersona, string contrasena, string confcontra, DateTime fechaCambio)
        {
            if (contrasena != confcontra)
            {
                throw new ArgumentException("Las contraseñas no coinciden.");
            }
            else
            {
                return D_CambioObligatorio.ActualizarContra(idPersona, contrasena, fechaCambio);
            }
        }
    }
}
