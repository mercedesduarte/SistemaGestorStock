using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class L_Categoria
    {
        public bool Insertar(string nombre, string descripcion, out string mensaje)
        {
            mensaje = "";
            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensaje = "El nombre de la categoría no puede estar vacío.";
                return false;
            }

            return D_Categoria.InsertarCategoria(nombre, descripcion, out mensaje);
        }

        public bool Modificar(int idCategoria, string nombre, string descripcion, bool activo, out string mensaje)
        {
            mensaje = "";
            if (idCategoria <= 0)
            {
                mensaje = "Debe seleccionar una categoría válida.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensaje = "El nombre de la categoría no puede estar vacío.";
                return false;
            }

            return D_Categoria.ModificarCategoria(idCategoria, nombre, descripcion, activo, out mensaje);
        }

        public DataTable Listar()
        {
            return D_Categoria.ListarCategorias();
        }
    }
}


