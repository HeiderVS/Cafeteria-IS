namespace Modelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdministradorPuntoVenta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        id = c.Int(nullable: false),
                        categoria = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        marca = c.String(),
                        precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        cantidad = c.Int(nullable: false),
                        categoriaId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categorias", t => t.categoriaId)
                .Index(t => t.categoriaId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        id = c.Int(nullable: false),
                        rol = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        usuario = c.String(),
                        nombre = c.String(),
                        apellidoMaterno = c.String(),
                        apellidoPaterno = c.String(),
                        rolId = c.Int(),
                        PasswordStored = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Roles", t => t.rolId)
                .Index(t => t.rolId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        usuarioVendedor_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Usuarios", t => t.usuarioVendedor_id)
                .Index(t => t.usuarioVendedor_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "usuarioVendedor_id", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "rolId", "dbo.Roles");
            DropForeignKey("dbo.Productoes", "categoriaId", "dbo.Categorias");
            DropIndex("dbo.Ventas", new[] { "usuarioVendedor_id" });
            DropIndex("dbo.Usuarios", new[] { "rolId" });
            DropIndex("dbo.Productoes", new[] { "categoriaId" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Roles");
            DropTable("dbo.Productoes");
            DropTable("dbo.Categorias");
        }
    }
}
