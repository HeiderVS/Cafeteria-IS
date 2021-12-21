namespace Modelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usuario_activo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "activo", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "activo");
        }
    }
}
