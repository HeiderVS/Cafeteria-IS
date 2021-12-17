namespace Modelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyVendedor : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Ventas", name: "usuarioVendedor_id", newName: "vendedorId");
            RenameIndex(table: "dbo.Ventas", name: "IX_usuarioVendedor_id", newName: "IX_vendedorId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Ventas", name: "IX_vendedorId", newName: "IX_usuarioVendedor_id");
            RenameColumn(table: "dbo.Ventas", name: "vendedorId", newName: "usuarioVendedor_id");
        }
    }
}
