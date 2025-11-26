using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_EmisionPresupuesto
    {
        public static string GenerarNumeroPresupuesto()
        {
            string ultimoNumero = D_EmisionPresupuesto.ObtenerUltimoNumeroPresupuesto();

            if (string.IsNullOrEmpty(ultimoNumero))
            {
                return "PRE-00000001";
            }
            else
            {
                // Extraer el número y incrementar
                string[] partes = ultimoNumero.Split('-');
                if (partes.Length == 2 && int.TryParse(partes[1], out int numero))
                {
                    return $"PRE-{(numero + 1).ToString("D8")}";
                }
                else
                {
                    return "PRE-" + DateTime.Now.ToString("yyyyMMddHHmmss");
                }
            }
        }

        public static DataTable BuscarClientes(string busqueda)
        {
            return D_EmisionPresupuesto.BuscarClientes(busqueda);
        }

        public static DataTable BuscarProductos(string busqueda)
        {
            return D_EmisionPresupuesto.BuscarProductos(busqueda);
        }

        public static int GuardarPresupuestoCompleto(
            string numeroPresupuesto,
            DateTime fecha,
            int idCliente,
            decimal subTotal,
            decimal descuento,
            decimal total,
            int validez,
            string usuario,
            DataTable detalles
        )
        {
            // Insertar cabecera
            int idPresupuesto = D_EmisionPresupuesto.InsertarPresupuesto(
                numeroPresupuesto, fecha, idCliente, subTotal,
                descuento, total, validez, usuario
            );

            if (idPresupuesto > 0)
            {
                // Insertar detalles
                foreach (DataRow row in detalles.Rows)
                {
                    bool resultado = D_EmisionPresupuesto.InsertarDetallePresupuesto(
                        idPresupuesto,
                        Convert.ToInt32(row["IdProducto"]),
                        Convert.ToDecimal(row["Cantidad"]),
                        Convert.ToDecimal(row["PrecioUnitario"]),
                        Convert.ToDecimal(row["SubTotal"])
                    );

                    if (!resultado)
                    {
                        return -1; // Error en detalle
                    }
                }
                return idPresupuesto;
            }
            return -1;
        }
    }
}