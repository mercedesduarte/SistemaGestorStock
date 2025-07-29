using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class L_ListarPreguntas
    {
 
        public DataTable ListarPreguntas()
        {
            return D_Pregunta.ListarPreguntas();
        }
    }
}