namespace aspnetmvc_angular.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<aspnetmvc_angular.Models.Data.RegistrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(aspnetmvc_angular.Models.Data.RegistrationContext context)
        {
            context.Courses.AddOrUpdate(
                p => p.Name,
                new Course { Instructor = "Rubeus Hagrid", Name = "Care of Magical Creatures", Number = "CREA101" },
                new Course { Instructor = "Serverus Snape", Name = "Defence against the dark arts", Number = "DARK502" },
                new Course { Instructor = "Minerva McGonagall", Name = "Transfigurations", Number = "TRAN201" }
                );

            context.Instructors.AddOrUpdate(
                p => p.Name,
                new Instructor { Name = "Rubeus Hagrid", Email = "hagrids@hogwarts.com", RoomNumber = 1001 },
                new Instructor { Name = "Serverus Snape", Email = "snape@hogwarts.com", RoomNumber = 105 },
                new Instructor { Name = "Minerva McGonagall", Email = "mcgonagall@hogwarts.com", RoomNumber = 102 }
                );

        }
    }
}
