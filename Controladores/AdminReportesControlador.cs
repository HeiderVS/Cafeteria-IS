using System;
using System.Collections.Generic;
using System.Linq;
using Modelos;

namespace Controladores
{
    public class AdminReportesControlador
    {
        public IEnumerable<ReporteViewModel> GetReportes(DateTime startDate, DateTime endDate)
        {
            using (Modelos.CafeteriaDBContext dbContext = new CafeteriaDBContext())
            {
                IEnumerable<Modelos.ReporteViewModel> reporteViewModels = (from venta in dbContext.Ventas
                        select new ReporteViewModel
                        {
                            idVenta = venta.id,
                            idProducto = venta.productoId,
                            cantidad = venta.cantidad,
                            precioTotal = venta.total,
                            fecha = venta.fecha
                        }).Where(venta => venta.fecha >= startDate && venta.fecha < endDate)
                    .ToList();
                return reporteViewModels;
            }
        }
    }
}