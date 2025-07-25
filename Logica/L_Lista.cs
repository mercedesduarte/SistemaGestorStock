using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DTOs;
using Datos;

namespace Logica
{
    public class L_Lista
    {
        private D_Lista datos = new D_Lista();

        public List<KeyValuePair<int, string>> ObtenerPersonasParaCombo()
        {
            var personasDTO = datos.ListarPersonas(); 

            var listaCombo = new List<KeyValuePair<int, string>>();
            foreach (var persona in personasDTO)
            {
                listaCombo.Add(new KeyValuePair<int, string>(persona.Id_Persona, persona.NombreCompleto));
            }

            return listaCombo;
        }

    }
}
