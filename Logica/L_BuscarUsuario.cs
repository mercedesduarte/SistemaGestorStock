using Datos;
using System;

namespace Logica
{
    public class ResultadoUsuario
    {
        public bool Existe { get; set; }
        public int? IdUsuario { get; set; }
    }

    public class L_BuscarUsuario
    {
        private D_BuscarUsuario dBuscarUsuario = new D_BuscarUsuario();

        public ResultadoUsuario BuscarUsuario(string usuarioIngresado)
        {
            if (string.IsNullOrWhiteSpace(usuarioIngresado))
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");

            var resultadoDatos = dBuscarUsuario.BuscarUsuario(usuarioIngresado);

            return new ResultadoUsuario
            {
                Existe = resultadoDatos.Existe,
                IdUsuario = resultadoDatos.IdUsuario
            };
        }
    }
}
