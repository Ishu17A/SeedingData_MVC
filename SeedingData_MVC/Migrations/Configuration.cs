namespace SeedingData_MVC.Migrations
{
    using SeedingData_MVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SeedingData_MVC.Models.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SeedingData_MVC.Models.EmployeeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.EmployeeData.Add(new Employee { Name = "Aman", EmployeeID = 234, Age = 23 });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
