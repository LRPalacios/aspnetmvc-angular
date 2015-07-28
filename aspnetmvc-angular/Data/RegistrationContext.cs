using aspnetmvc_angular.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aspnetmvc_angular.Models.Data
{
    public class RegistrationContext:DbContext
    {
        public DbSet<Course> Coruses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new InstructorMapping());
            modelBuilder.Configurations.Add(new CourseMapping());
            base.OnModelCreating(modelBuilder);
        }
    }

}