namespace MvcSpaDemo.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcSpaDemo.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcSpaDemo.StudentContext context)
        {
            context.Student.AddOrUpdate(
                new Student { StudentID = 1, FirstName = "Raj", LastName = "Kumar", Email = "raj.kumar@gmail.com", Class = "10"},
                new Student { StudentID = 2, FirstName = "Jayvant", LastName = "Masan", Email = "jayvant.masan@gmail.com", Class = "12" });

            context.SaveChanges();
        }
    }
}
