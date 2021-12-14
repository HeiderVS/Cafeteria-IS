
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Modelos.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Modelos.CafeteriaDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    } 
}