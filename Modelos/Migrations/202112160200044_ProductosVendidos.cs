namespace Modelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductosVendidos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductosVendidos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        producto_id = c.Int(),
                        usuario_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Productoes", t => t.producto_id)
                .ForeignKey("dbo.Usuarios", t => t.usuario_id)
                .Index(t => t.producto_id)
                .Index(t => t.usuario_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductosVendidos", "usuario_id", "dbo.Usuarios");
            DropForeignKey("dbo.ProductosVendidos", "producto_id", "dbo.Productoes");
            DropIndex("dbo.ProductosVendidos", new[] { "usuario_id" });
            DropIndex("dbo.ProductosVendidos", new[] { "producto_id" });
            DropTable("dbo.ProductosVendidos");
        }
    }
}
