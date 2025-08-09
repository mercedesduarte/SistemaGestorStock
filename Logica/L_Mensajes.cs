using MensajeriaApp.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeriaApp.Logica
{
    public class MensajeBLL
    {
        private MensajeDAL dal = new MensajeDAL();

        public void Enviar(int emisorId, int receptorId, string mensaje)
        {
            if (string.IsNullOrWhiteSpace(mensaje))
                throw new Exception("El mensaje no puede estar vacío.");

            dal.EnviarMensaje(emisorId, receptorId, mensaje);
        }

        public DataTable BandejaEntrada(int usuarioId)
        {
            return dal.ObtenerMensajes(usuarioId);
        }
    }
}