using System;
using System.Data.Entity;
using Modelos.Inventario;
using Modelos.Usuarios;

namespace Modelos
{
    public class CafeteriaDBContext : DbContext
    {
        public CafeteriaDBContext() : base("SQLEXPRESS")
        {
        }

        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
        
        public DbSet<Producto> Productos { get; set; }
    }

    public class Ventas
    {
        public int id { get; set; }
        public int productoId { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }

        public DateTime fecha { get; set; }
    }
}