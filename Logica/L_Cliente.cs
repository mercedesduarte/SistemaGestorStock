using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_Cliente
    {
        public bool Insertar(string codigo, string razonSocial, string email,
                             string formaPago, decimal descuento,
                             decimal limiteCredito, string direccion, string localidad,
                             string provincia, string telefono, string contacto,
                             string sector, string horario, string emailContacto, out string mensaje)
        {
            mensaje = "";

            try
            {
               
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

                if (string.IsNullOrWhiteSpace(direccion))
                {
                    mensaje = "La dirección es obligatoria.";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(telefono))
                {
                    mensaje = "Debe ingresar al menos un teléfono.";
                    return false;
                }

               
                if (codigo.Length > 50)
                {
                    mensaje = "El código no puede tener más de 50 caracteres.";
                    return false;
                }

                
                if (razonSocial.Length > 150)
                {
                    mensaje = "La razón social no puede tener más de 150 caracteres.";
                    return false;
                }

                
                bool resultado = D_Cliente.InsertarCliente(
                    codigo, razonSocial, email, formaPago, descuento, limiteCredito,
                    direccion, localidad, provincia,
                    telefono, contacto, sector, horario, emailContacto, out string mensajeBD
                );

                
                mensaje = mensajeBD;
                return resultado;
            }
            catch (Exception ex)
            {
                mensaje = $"Error en la lógica de negocio: {ex.Message}";
                return false;
            }
        }

        public bool Modificar(int idCliente, string codigo, string razonSocial,
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

                if (string.IsNullOrWhiteSpace(razonSocial))
                {
                    mensaje = "La razón social no puede estar vacía.";
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