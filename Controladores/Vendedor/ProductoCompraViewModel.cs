using System;

namespace Controladores.Vendedor
{
    public class ProductoCompraViewModel
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
    }
}