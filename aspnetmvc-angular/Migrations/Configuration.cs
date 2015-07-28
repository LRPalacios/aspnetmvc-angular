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
                p=>p.Name,
                new Course { Instructor = "Luis Palacios", Name="CR103", Number = "1003" }
                );

            context.Instructors.AddOrUpdate(
                p=>p.Name,
                new Instructor { Name = "Luis Palacios", Email = "lrpalaciosdev@gmail.com", RoomNumber = 1003 }
                );
            
        }
    }
}
