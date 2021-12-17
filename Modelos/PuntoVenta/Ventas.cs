using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Modelos.Usuarios;

namespace Modelos.PuntoVenta
{
    public class Ventas
    {
        public int id { get; set; }
        public decimal total { get; set; }
        public int? vendedorId { get; set; }
        [ForeignKey("vendedorId")] public virtual Usuario usuarioVendedor { get; set; }
        public ICollection<ProductosVendidos> Productos { get; set; }
        public DateTime fecha { get; set; }
    }
}