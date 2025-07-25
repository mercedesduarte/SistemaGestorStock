using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    internal class ContEspeciales
    {
        public string ContieneCaracteresEspeciales(string contra, int cantidad)
        {
            if (cantidad >= 0)
            {
                int especiales = 0;
                for (int i = 0; i < contra.Length; i++)
                {
                    if (!char.IsLetterOrDigit(contra[i]))
                    {
                        especiales++;
                    }
                }
                if (especiales < cantidad)
                {
                    return $"La contraseña debe contener al menos {cantidad} caracteres especiales.";
                }
                else
                {
                    return contra;
                }
            }
            else
            {
                return contra;
            }
        }
    }
}
