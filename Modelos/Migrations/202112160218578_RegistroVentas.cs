namespace Modelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistroVentas : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ProductosVendidos", name: "producto_id", newName: "productoId");
            RenameIndex(table: "dbo.ProductosVendidos", name: "IX_producto_id", newName: "IX_productoId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ProductosVendidos", name: "IX_productoId", newName: "IX_producto_id");
            RenameColumn(table: "dbo.ProductosVendidos", name: "productoId", newName: "producto_id");
        }
    }
}
