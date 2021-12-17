namespace Modelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FechaVenta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ventas", "fecha", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ventas", "fecha");
        }
    }
}
