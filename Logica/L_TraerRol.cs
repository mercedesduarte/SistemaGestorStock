using Datos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Logica
{

    public class PermisoVista
    {
        public int Id_Permiso { get; set; }
        public string Permiso { get; set; }
        public string Descripcion { get; set; }
    }
    public class L_TraerRol
    {
        private readonly D_TraerRol datos = new D_TraerRol();

        public List<PermisoVista> ObtenerPermisosPorRol(int idRol)
        {
            List<PermisoDTO> listaDTO = datos.ObtenerPermisosPorRol(idRol);

            return listaDTO.Select(dto => new PermisoVista
            {
                Id_Permiso = dto.Id_Permiso,
                Permiso = dto.Permiso,
                Descripcion = dto.Descripcion
            }).ToList();
        }
    }
}

