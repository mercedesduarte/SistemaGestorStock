using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_Cliente
    {
        public bool Insertar(
            string codigo, string razonSocial, string email,
            string formaPago, decimal descuento,
            decimal limiteCredito, string direccion, string localidad,
            string provincia, string telefono, string contacto,
            string sector, string horario, string emailContacto,
            out string mensaje, out int idCliente)
        {
            mensaje = "";
            idCliente = 0;

            if (string.IsNullOrWhiteSpace(codigo))
            {
                mensaje = "El código del cliente es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(razonSocial))
            {
                mensaje = "La razón social es obligatoria.";
                return false;
            }

            return D_Cliente.InsertarCliente(
                codigo, razonSocial, email, formaPago,
                descuento, limiteCredito, direccion, localidad,
                provincia, telefono, contacto, sector,
                horario, emailContacto, out mensaje, out idCliente);
        }

        // ===== RESTO SIN CAMBIOS =====

        public bool Modificar(
            int idCliente, string codigo, string razonSocial,
            string email, string formaPago,
            decimal descuento, decimal limiteCredito,
            bool activo, out string mensaje)
        {
            mensaje = "";

            try
            {
                if (idCliente <= 0)
                {
                    mensaje = "Debe seleccionar un cliente válido.";
                    return false;
                }

                return D_Cliente.ModificarCliente(
                    idCliente, codigo, razonSocial, email,
                    formaPago, descuento, limiteCredito, activo);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }

        public DataTable Listar()
        {
            return D_Cliente.ListarClientes();
        }

        public DataRow ObtenerPorId(int idCliente)
        {
            return D_Cliente.ObtenerPorId(idCliente);
        }

        public DataTable BuscarPorNombreOCodigo(string filtro)
        {
            return D_Cliente.BuscarClientePorNombreOCodigo(filtro);
        }
    }
}
