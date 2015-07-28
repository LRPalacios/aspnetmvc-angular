using aspnetmvc_angular.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace aspnetmvc_angular.Data.Configurations
{
    public class CourseMapping:EntityTypeConfiguration<Course>
    {
        public CourseMapping()
        {
            Property(p => p.Instructor).HasMaxLength(150).IsRequired();
            Property(p => p.Name).HasMaxLength(150).IsRequired();
            Property(p => p.Number).IsRequired();
        }
    }
}