using System.ComponentModel.DataAnnotations.Schema;
using Modelos.Inventario;
using Modelos.Usuarios;

namespace Modelos.PuntoVenta
{
    public class ProductosVendidos
    {
        public int id { get; set; }
        public int? productoId { get; set; }
        [ForeignKey("productoId")]
        public Producto producto { get; set; }
    }
}