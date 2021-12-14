using System.Data.Entity;
namespace Modelos
{
    public class CafeteriaDBContext : DbContext
    {
        public CafeteriaDBContext() :base("SQLEXPRESS")
        {
            
        }
        
        public DbSet<Ventas> Ventas{get; set;}
    }
    
    public class Ventas
    {
        public int id {get; set;}
        public int productoId{get; set;}
        public int cantidad{get; set;}
        public decimal total{get; set;}
    }
}