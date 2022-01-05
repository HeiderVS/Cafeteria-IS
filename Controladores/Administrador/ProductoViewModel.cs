using System;

namespace Controladores.Administrador
{
    public class ProductoViewModel
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String marca { get; set; }
        public decimal precio { get; set; }
        public String categoria { get; set; }
        public int cantidad { get; set; }
    }
}