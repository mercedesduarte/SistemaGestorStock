using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class L_HistorialContras
    {
        private D_HistorialContras dcontras = new D_HistorialContras();

        public List<KeyValuePair<int, string>> HistorialDeContrasenas()
        {
            var contrasenas = dcontras.ContrasenasAnteriores();

            //Si este metodo retorna null, hacer que en la vista se habra un form al iniciar sesion

            if (contrasenas == null || contrasenas.Count == 0)
            {
                return null;
            }
            else
            {
                /*sino se puede usar esta lista para que cuando quiera cambiar la contraseña,
                se pueda comparar con las anteriores*/
                var listacontras = new List<KeyValuePair<int, string>>();
                foreach (var contra in contrasenas)
                {
                    listacontras.Add(new KeyValuePair<int, string>(contra.id_Contrasena, contra.contrasena));
                }

                return listacontras;
            }
        }
    }
}
