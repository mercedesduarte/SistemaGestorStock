using System;
using System.Data;
using Datos;

namespace Logica
{
    public class L_EmisionPresupuesto
    {
        
        private static int _idClienteSeleccionado = 0;
        private static DataTable _detallesPresupuesto;

        
        static L_EmisionPresupuesto()
        {
            InicializarTablaDetalles();
        }

        private static void InicializarTablaDetalles()
        {
            _detallesPresupuesto = new DataTable();
            _detallesPresupuesto.Columns.Add("IdProducto", typeof(int));
            _detallesPresupuesto.Columns.Add("NombreProducto", typeof(string));
            _detallesPresupuesto.Columns.Add("Categoria", typeof(string));
            _detallesPresupuesto.Columns.Add("Marca", typeof(string));
            _detallesPresupuesto.Columns.Add("Cantidad", typeof(decimal));
            _detallesPresupuesto.Columns.Add("PrecioUnitario", typeof(decimal));
            _detallesPresupuesto.Columns.Add("SubTotal", typeof(decimal));
        }

        public static DataTable BuscarClientes(string busqueda)
        {
            return D_EmisionPresupuesto.BuscarClientes(busqueda);
        }

        public static DataTable BuscarProductos(string busqueda)
        {
            return D_EmisionPresupuesto.BuscarProductos(busqueda);
        }

       
        public static bool CargarDatosCliente(int idCliente, ref string nombre, ref string email, ref string formaPago)
        {
            try
            {
                DataTable dt = D_EmisionPresupuesto.ObtenerClientePorId(idCliente);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    nombre = row["RazonSocial"].ToString();
                    email = row["Email"].ToString();
                    formaPago = row["FormaPago"].ToString();

                    _idClienteSeleccionado = idCliente;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en CargarDatosCliente: " + ex.ToString());
                return false;
            }
        }

        public static bool CargarDatosProductoCompleto(int idProducto, ref string nombre,
                                                       ref string categoria, ref string marca,
                                                       ref decimal precio, ref decimal stock)
        {
            try
            {
                DataTable dt = D_EmisionPresupuesto.ObtenerProductoPorId(idProducto);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    nombre = row["Nombre"].ToString();
                    precio = Convert.ToDecimal(row["PrecioVenta"]);
                    stock = Convert.ToDecimal(row["StockActual"]);

                    
                    if (row["IdCategoria"] != DBNull.Value)
                    {
                        int idCategoria = Convert.ToInt32(row["IdCategoria"]);
                        categoria = D_EmisionPresupuesto.ObtenerNombreCategoria(idCategoria);
                    }
                    else
                    {
                        categoria = "Sin categoría";
                    }

                    if (row["IdMarca"] != DBNull.Value)
                    {
                        int idMarca = Convert.ToInt32(row["IdMarca"]);
                        marca = D_EmisionPresupuesto.ObtenerNombreMarca(idMarca);
                    }
                    else
                    {
                        marca = "Sin marca";
                    }

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en CargarDatosProductoCompleto: " + ex.ToString());
                return false;
            }
        }

       
        public static bool AgregarProductoAPresupuesto(int idProducto, string nombreProducto,
                                                       string categoria, string marca,
                                                       decimal cantidad, decimal precioUnitario)
        {
            try
            {
                
                DataRow[] existingRows = _detallesPresupuesto.Select($"IdProducto = {idProducto}");

                if (existingRows.Length > 0)
                {
                    
                    DataRow row = existingRows[0];
                    decimal nuevaCantidad = Convert.ToDecimal(row["Cantidad"]) + cantidad;
                    row["Cantidad"] = nuevaCantidad;
                    
                }
                else
                {
                    
                    DataRow newRow = _detallesPresupuesto.NewRow();
                    newRow["IdProducto"] = idProducto;
                    newRow["NombreProducto"] = nombreProducto;
                    newRow["Categoria"] = categoria;
                    newRow["Marca"] = marca;
                    newRow["Cantidad"] = cantidad;
                    newRow["PrecioUnitario"] = precioUnitario;
                    
                    _detallesPresupuesto.Rows.Add(newRow);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en AgregarProductoAPresupuesto: " + ex.ToString());
                return false;
            }
        }

        public static void EliminarProductoDelPresupuesto(int idProducto)
        {
            try
            {
                DataRow[] rows = _detallesPresupuesto.Select($"IdProducto = {idProducto}");
                foreach (DataRow row in rows)
                {
                    _detallesPresupuesto.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en EliminarProductoDelPresupuesto: " + ex.ToString());
            }
        }

        public static DataTable ObtenerDetallesPresupuesto()
        {
            return _detallesPresupuesto.Copy();
        }

        
        public static DataTable CalcularTotalesConSP()
        {
            try
            {
                
                if (_detallesPresupuesto.Rows.Count == 0)
                {
                    return CrearTablaResultadosVacia();
                }

                
                DataTable tablaParaSP = new DataTable();
                tablaParaSP.Columns.Add("IdProducto", typeof(int));
                tablaParaSP.Columns.Add("Cantidad", typeof(decimal));
                tablaParaSP.Columns.Add("PrecioUnitario", typeof(decimal));

                
                foreach (DataRow row in _detallesPresupuesto.Rows)
                {
                    DataRow nuevaFila = tablaParaSP.NewRow();
                    nuevaFila["IdProducto"] = row["IdProducto"];
                    nuevaFila["Cantidad"] = row["Cantidad"];
                    nuevaFila["PrecioUnitario"] = row["PrecioUnitario"];
                    tablaParaSP.Rows.Add(nuevaFila);
                }

               
                int idCliente = _idClienteSeleccionado;

               
                DataTable resultados = D_EmisionPresupuesto.EjecutarSP_CalcularTotales(tablaParaSP, idCliente);

                ActualizarSubtotalesEnDetalles();

                return resultados;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en CalcularTotalesConSP: " + ex.ToString());

                return CalcularTotalesLocalmente();
            }
        }

        private static DataTable CrearTablaResultadosVacia()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SubTotal", typeof(decimal));
            dt.Columns.Add("PorcentajeDescuento", typeof(decimal));
            dt.Columns.Add("Descuento", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));

            DataRow fila = dt.NewRow();
            fila["SubTotal"] = 0m;
            fila["PorcentajeDescuento"] = 0m;
            fila["Descuento"] = 0m;
            fila["Total"] = 0m;
            dt.Rows.Add(fila);

            return dt;
        }

        private static void ActualizarSubtotalesEnDetalles()
        {

            foreach (DataRow row in _detallesPresupuesto.Rows)
            {
                decimal cantidad = Convert.ToDecimal(row["Cantidad"]);
                decimal precio = Convert.ToDecimal(row["PrecioUnitario"]);
                row["SubTotal"] = cantidad * precio;
            }
        }

        private static DataTable CalcularTotalesLocalmente()
        {
            DataTable dt = CrearTablaResultadosVacia();
            DataRow fila = dt.Rows[0];

            
            decimal subtotal = 0m;
            foreach (DataRow row in _detallesPresupuesto.Rows)
            {
                decimal cantidad = Convert.ToDecimal(row["Cantidad"]);
                decimal precio = Convert.ToDecimal(row["PrecioUnitario"]);
                subtotal += cantidad * precio;
            }

         
            decimal total = subtotal * 1.21m;

            fila["SubTotal"] = subtotal;
            fila["Total"] = total;

            return dt;
        }

        public static bool ObtenerValoresTotales(out decimal subtotal, out decimal total)
        {
            subtotal = 0m;
            total = 0m;

            try
            {
                DataTable resultados = CalcularTotalesConSP();

                if (resultados.Rows.Count > 0)
                {
                    DataRow fila = resultados.Rows[0];
                    subtotal = Convert.ToDecimal(fila["SubTotal"]);
                    total = Convert.ToDecimal(fila["Total"]);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerValoresTotales: " + ex.ToString());
            }

            return false;
        }

        public static int GuardarPresupuestoCompleto(
            DateTime fecha,
            int idCliente,
            decimal subTotal,
            decimal descuento,
            decimal total,
            int validez,
            string usuario,
            DataTable detalles)
        {
            
            string numeroTemporal = "TEMP-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            int idPresupuesto = D_EmisionPresupuesto.InsertarPresupuesto(
                numeroTemporal, fecha, idCliente, subTotal,
                descuento, total, validez, usuario);

            if (idPresupuesto > 0)
            {
                foreach (DataRow row in detalles.Rows)
                {
                    bool resultado = D_EmisionPresupuesto.InsertarDetallePresupuesto(
                        idPresupuesto,
                        Convert.ToInt32(row["IdProducto"]),
                        Convert.ToDecimal(row["Cantidad"]),
                        Convert.ToDecimal(row["PrecioUnitario"]),
                        Convert.ToDecimal(row["SubTotal"]));

                    if (!resultado)
                    {
                        return -1;
                    }
                }
                return idPresupuesto;
            }
            return -1;
        }

        public static void LimpiarPresupuesto()
        {
            _detallesPresupuesto.Clear();
            _idClienteSeleccionado = 0;
        }

        public static int ObtenerClienteSeleccionado()
        {
            return _idClienteSeleccionado;
        }

        public static int ObtenerCantidadProductos()
        {
            return _detallesPresupuesto.Rows.Count;
        }

        public static bool HayClienteSeleccionado()
        {
            return _idClienteSeleccionado > 0;
        }
    }
}