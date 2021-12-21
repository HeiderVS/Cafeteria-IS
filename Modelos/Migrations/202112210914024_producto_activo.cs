namespace Modelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class producto_activo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "activo", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "activo");
        }
    }
}
