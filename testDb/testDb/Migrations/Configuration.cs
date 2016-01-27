namespace testDb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<testDb.Models.TestDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(testDb.Models.TestDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Cars.AddOrUpdate(
                car => car.CarName,
                new Models.Car { CarName = "Testing Car I", Image = "aljfals", Model = "Testla", Price = 300000 },
                new Models.Car { CarName = "Testing Car II", Image = "aljfals", Model = "Testla", Price = 300000 },
                new Models.Car { CarName = "Testing Car III", Image = "aljfals", Model = "Testla", Price = 300000 }

                );
        }
    }
}
