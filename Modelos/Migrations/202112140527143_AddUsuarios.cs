namespace Modelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsuarios : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "password", c => c.String());
        }
    }
}
