using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class L_VerificarCodigo2FA
    {

        public bool VerificarCodigo(int idUsuario, string codigoIngresado)
        {
            var verificador = new D_Verificacion2FA();
            bool esValido = verificador.ValidarCodigoIngresado(idUsuario, codigoIngresado);
            return esValido;
        }


    }
}
