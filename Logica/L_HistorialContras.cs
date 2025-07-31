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

        public List<KeyValuePair<int, string>> HistorialDeContrasenas(string usuario)
        {
            var contrasenas = dcontras.ContrasenasAnteriores(usuario);

            if (contrasenas == null || contrasenas.Count == 0)
            {
                return null;
            }

            var listacontras = new List<KeyValuePair<int, string>>();
            foreach (var contra in contrasenas)
            {
                listacontras.Add(new KeyValuePair<int, string>(contra.id_Contrasena, contra.contrasena));
            }

            return listacontras;
        }
    }
}