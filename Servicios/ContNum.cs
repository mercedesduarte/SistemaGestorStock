using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    internal class ContNum
    {
        public string ContieneNumeros(string contra, int cantidad)
        {
            if (cantidad >= 0)
            {
                int numeros = 0;
                for (int i = 0; i < contra.Length; i++)
                {
                    if (char.IsDigit(contra[i]))
                    {
                        numeros++;
                    }
                }
                if (numeros < cantidad)
                {
                    return $"La contraseña debe contener al menos {cantidad} números.";
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
