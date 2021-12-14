using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
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