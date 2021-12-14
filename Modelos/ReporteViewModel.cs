using System;

namespace Modelos
{
    public class ReporteViewModel
    {
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public decimal precioTotal { get; set; }
        public int cantidad { get; set; }
        
        public DateTime fecha { get; set; }
    }
}