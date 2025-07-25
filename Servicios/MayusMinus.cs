using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    internal class MayusMinus
    {
        public string VerificarMayus(string contra, int cantidad)
        {
            if (cantidad >= 0)
            {
                int mayusculas = 0;
                for (int i = 0; i < contra.Length; i++)
                {
                    if (char.IsUpper(contra[i]))
                    {
                        mayusculas++;
                    }
                }

                if (mayusculas < cantidad)
                {
                    return $"La contraseña debe contener al menos {cantidad} mayusculas";
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
