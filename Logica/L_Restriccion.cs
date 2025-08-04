using Datos;
using Servicios;
using Sesion;
using System;

namespace Logica
{
    public class L_Restriccion
    {
        private readonly D_Restriccion dRestriccion = new D_Restriccion();

        public EstadoRestricciones ConseguirRestricciones()
        {
            var estado = dRestriccion.ObtenerRestricciones();

            Console.WriteLine("\nRestricciones activas:");
            if (estado.MinimoCar == 1) Console.WriteLine("- Mínimo de caracteres");
            if (estado.MayusMinus == 1) Console.WriteLine("- Combinar mayúsculas y minúsculas");
            if (estado.NumeroLetras == 1) Console.WriteLine("- Contener números y letras");
            if (estado.CaracterEsp == 1) Console.WriteLine("- Contener un carácter especial");
            if (estado.ContrasenaAnterior == 1) Console.WriteLine("- No repetir contraseñas anteriores");
            if (estado.DatosPersonales == 1) Console.WriteLine("- No permitir datos personales");
            if (estado.DosFA == 1) Console.WriteLine("- Requiere autenticación 2FA por correo");

            Console.WriteLine("Finalizó la carga de restricciones.");

            return estado;
        }

        public void GuardarRestricciones(
            decimal minCaracteres,
            bool mayusMinus,
            bool numLetras,
            bool caracterEspecial,
            bool noRepetir,
            bool noDatosPersonales,
            bool dosFA)
        {
            dRestriccion.GuardarRestricciones(minCaracteres, mayusMinus, numLetras, caracterEspecial, noRepetir, noDatosPersonales, dosFA);
        }
    }
}
