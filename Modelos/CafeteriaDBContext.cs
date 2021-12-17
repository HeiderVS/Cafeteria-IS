using System;
using System.Data.Entity;
using Modelos.Inventario;
using Modelos.PuntoVenta;
using Modelos.Usuarios;

namespace Modelos
{
    public class CafeteriaDBContext : DbContext
    {
        public CafeteriaDBContext() : base("SQLEXPRESS")
        {
        }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Ventas> Ventas { get; set; }

        public DbSet<ProductosVendidos> ProductosVendidos { get; set; }
    }
}