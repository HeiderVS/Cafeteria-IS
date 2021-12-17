namespace Modelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelacionProductoVenta : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductosVendidos", "usuario_id", "dbo.Usuarios");
            DropIndex("dbo.ProductosVendidos", new[] { "usuario_id" });
            AddColumn("dbo.ProductosVendidos", "Ventas_id", c => c.Int());
            CreateIndex("dbo.ProductosVendidos", "Ventas_id");
            AddForeignKey("dbo.ProductosVendidos", "Ventas_id", "dbo.Ventas", "id");
            DropColumn("dbo.ProductosVendidos", "usuario_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductosVendidos", "usuario_id", c => c.Int());
            DropForeignKey("dbo.ProductosVendidos", "Ventas_id", "dbo.Ventas");
            DropIndex("dbo.ProductosVendidos", new[] { "Ventas_id" });
            DropColumn("dbo.ProductosVendidos", "Ventas_id");
            CreateIndex("dbo.ProductosVendidos", "usuario_id");
            AddForeignKey("dbo.ProductosVendidos", "usuario_id", "dbo.Usuarios", "id");
        }
    }
}
