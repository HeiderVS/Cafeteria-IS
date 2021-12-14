using System;
using System.Collections;
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
                        precioTotal = venta.total
                    }).ToList();
                return reporteViewModels;
            }
        }
    }
}