namespace DentistApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DentistApp.Context.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DentistApp.Context.MyContext context)
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

            context.BloodTypes.AddOrUpdate(x => x.BloodTypeId,
                new Models.BloodType()
                {
                    BloodTypeId = 1,
                    BloodTypeName = "A+"
                },
                new Models.BloodType()
                {
                    BloodTypeId = 2,
                    BloodTypeName = "A-"
                }, new Models.BloodType()
                {
                    BloodTypeId = 3,
                    BloodTypeName = "0+"
                }, new Models.BloodType()
                {
                    BloodTypeId = 4,
                    BloodTypeName = "0-"
                });

            context.Genders.AddOrUpdate(x => x.GenderId,
                new Models.Gender()
                {
                    GenderId = 1,
                    GenderType = "Erkek"
                },
                new Models.Gender()
                {
                    GenderId = 2,
                    GenderType = "Kadýn"
                });

        }
    }
}
