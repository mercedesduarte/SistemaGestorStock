using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using System.Data;

namespace Logica
{
    public class L_Marca
    {
        public bool Insertar(string nombre, out string mensaje)
        {
            mensaje = "";
            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensaje = "El nombre de la marca no puede estar vacío.";
                return false;
            }

            return D_Marca.InsertarMarca(nombre, out mensaje);
        }

        public bool Modificar(int idMarca, string nombre, bool activo, out string mensaje)
        {
            mensaje = "";
            if (idMarca <= 0)
            {
                mensaje = "Debe seleccionar una marca válida.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensaje = "El nombre de la marca no puede estar vacío.";
                return false;
            }

            return D_Marca.ModificarMarca(idMarca, nombre, activo, out mensaje);
        }

        public DataTable Listar()
        {
            return D_Marca.ListarMarcas();
        }
    }
}

