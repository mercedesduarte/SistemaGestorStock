using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Datos;
using Datos.Conecction;

namespace Logica
{
    public class L_OrdenCompra
    {
        public bool CrearOrden(int idProveedor, DateTime fecha, List<(int idProducto,int cantidad,decimal precio)> detalles, out string mensaje)
        {
            mensaje = string.Empty;
            using (var cn = ConnectionBD.ObtenerConexion())
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        // calcular total
                        decimal total = 0;
                        foreach (var d in detalles) total += d.cantidad * d.precio;

                        int idOrden = D_OrdenCompra.InsertarOrden(cn, tr, idProveedor, fecha, total, out mensaje);
                        if (idOrden <= 0)
                        {
                            tr.Rollback();
                            return false;
                        }

                        foreach (var d in detalles)
                        {
                            bool ok = D_OrdenCompra.InsertarDetalle(cn, tr, idOrden, d.idProducto, d.cantidad, d.precio, out mensaje);
                            if (!ok)
                            {
                                tr.Rollback();
                                return false;
                            }
                        }

                        tr.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        try { tr.Rollback(); } catch { }
                        mensaje = ex.Message;
                        return false;
                    }
                }
            }
        }
    }
}
