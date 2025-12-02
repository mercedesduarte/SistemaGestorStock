using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_RegistroPresupuesto
    {

        public class ResultadoFacturacion
        {
            public bool Exito { get; set; }
            public int IdFactura { get; set; }
            public string NumeroFactura { get; set; }
            public string Mensaje { get; set; }

            public ResultadoFacturacion()
            {
                Exito = false;
                IdFactura = 0;
                NumeroFactura = string.Empty;
                Mensaje = string.Empty;
            }
        }


        public static string ObtenerProximoNumeroFactura()
        {
            try
            {
                return D_RegistroPresupuesto.ObtenerProximoNumeroFactura();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerProximoNumeroFactura: " + ex.ToString());
                return "FAC-001-" + DateTime.Now.ToString("yyyyMM") + "-000001";
            }
        }


        public static ResultadoFacturacion CrearFacturaDesdePresupuesto(
            int idPresupuesto,
            string numeroFactura,
            DateTime fechaFactura,
            DateTime fechaVencimiento,
            int idCliente,
            decimal subTotal,
            decimal descuento,
            decimal total,
            string observaciones,
            string usuario)
        {
            var resultado = new ResultadoFacturacion();

            try
            {
                
                if (idPresupuesto <= 0)
                {
                    resultado.Mensaje = "ID de presupuesto inválido";
                    return resultado;
                }

                if (string.IsNullOrEmpty(numeroFactura))
                {
                    resultado.Mensaje = "Número de factura requerido";
                    return resultado;
                }

                if (idCliente <= 0)
                {
                    resultado.Mensaje = "Cliente inválido";
                    return resultado;
                }

                if (total <= 0)
                {
                    resultado.Mensaje = "Total debe ser mayor a cero";
                    return resultado;
                }


                int idFactura = D_RegistroPresupuesto.CrearFacturaDesdePresupuesto(
                    idPresupuesto,
                    numeroFactura,
                    fechaFactura,
                    fechaVencimiento,
                    idCliente,
                    subTotal,
                    descuento,
                    total,
                    observaciones,
                    usuario);

                if (idFactura > 0)
                {
                    resultado.Exito = true;
                    resultado.IdFactura = idFactura;
                    resultado.NumeroFactura = numeroFactura;
                    resultado.Mensaje = $"Factura {numeroFactura} creada exitosamente";
                }
                else
                {
                    resultado.Mensaje = "Error al crear la factura";
                }
            }
            catch (Exception ex)
            {
                resultado.Mensaje = $"Error: {ex.Message}";
                Console.WriteLine("Error en CrearFacturaDesdePresupuesto: " + ex.ToString());
            }

            return resultado;
        }

 
        public static bool ObtenerDatosCliente(int idCliente,
            ref string razonSocial, ref string email, ref string formaPago, ref decimal descuento)
        {
            try
            {
                DataTable dt = D_RegistroPresupuesto.ObtenerClientePorId(idCliente);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    razonSocial = row["RazonSocial"].ToString();
                    email = row["Email"].ToString();
                    formaPago = row["FormaPago"].ToString();

                    if (row["Descuento"] != DBNull.Value)
                        descuento = Convert.ToDecimal(row["Descuento"]);
                    else
                        descuento = 0;

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerDatosCliente: " + ex.ToString());
                return false;
            }
        }

    }
}