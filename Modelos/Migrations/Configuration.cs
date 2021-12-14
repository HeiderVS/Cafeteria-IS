
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Modelos.Usuarios;

namespace Modelos.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Modelos.CafeteriaDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CafeteriaDBContext context)
        {
            context.Roles.SeedEnumValues<Roles, RolesEnum>(@enum => @enum);
            context.SaveChanges();
            base.Seed(context);
        }
    } 
}