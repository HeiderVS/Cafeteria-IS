using System;
using System.ComponentModel.DataAnnotations.Schema;
using Modelos.Usuarios;

namespace Modelos.Inventario
{
    public class Producto
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String marca { get; set; }
        public decimal precio { set; get; }
        public int cantidad { set; get; }
        public int? categoriaId { get; set; }

        [ForeignKey("categoriaId")] public Categoria categoria { get; set; }
    }
}