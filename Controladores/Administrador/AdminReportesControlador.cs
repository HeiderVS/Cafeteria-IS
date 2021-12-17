using System;
using System.Collections.Generic;
using System.Linq;
using Controladores.Administrador;
using Microsoft.EntityFrameworkCore;
using Modelos;
using Modelos.PuntoVenta;

namespace Controladores
{
    public class AdminReportesControlador
    {
        public IEnumerable<ReporteViewModel> GetReportes(DateTime startDate, DateTime endDate)
        {
            using (var dbContext = new CafeteriaDBContext())
            {
                /*List<Ventas> VENTAS = dbContext.Ventas.ToList();
                Console.Write("");
                return null;*/

                return dbContext.Ventas
                    .Include(v => v.usuarioVendedor)
                    .ToList()
                    .Where(venta => venta.fecha.Date >= startDate && venta.fecha.Date <= endDate)
                    .Select(ventas => new ReporteViewModel
                    {
                        fecha = ventas.fecha,
                        idVenta = ventas.id,
                        precioTotal = ventas.total,
                        vendedor = ventas.usuarioVendedor.nombre
                                   + " " + ventas.usuarioVendedor.apellidoPaterno
                                   + " " + ventas.usuarioVendedor.apellidoMaterno,
                        idVendedor = ventas.usuarioVendedor.id
                    }).ToList();
            }
        }
    }
}