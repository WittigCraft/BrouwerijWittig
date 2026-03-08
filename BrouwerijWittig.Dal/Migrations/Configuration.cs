namespace BrouwerijWittig.Dal.Migrations
{
    using BrouwerijWittig.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BrouwerijWittig.Dal.BrouwerijWittigDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BrouwerijWittig.Dal.BrouwerijWittigDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            /*

            context.Beers.AddOrUpdate(x => x.ProductName,
                new Beer(Guid.Parse("812f778b-336a-4d42-8bc4-38b7025b92b1"), "Duvel", 6m, "Belgium", 8.5m, 30m),
                new Beer(Guid.Parse("88babb52-5e42-4786-a3dc-8157ed148f95"), "Jupiler", 3.5m, "Belgium", 5.2m, 25m)); */
        }
    }
}
