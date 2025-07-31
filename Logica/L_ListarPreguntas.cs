using Datos;
using Datos.DTOs;
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
            D_ListarPreguntas datos = new D_ListarPreguntas();
            List<PreguntaDTO> lista = datos.ListarPreguntas();

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id_Pregunta", typeof(int));
            tabla.Columns.Add("Pregunta", typeof(string));
            tabla.Columns.Add("Respuesta", typeof(string));
            tabla.Columns.Add("Id_Usuario", typeof(int));

            foreach (var item in lista)
            {
                tabla.Rows.Add(item.IdPregunta, item.Pregunta, item.Respuesta, item.IdUsuario);
            }

            return tabla;
        }
    }
}