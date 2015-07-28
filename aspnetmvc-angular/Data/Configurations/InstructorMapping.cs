using aspnetmvc_angular.Models;
using System.Data.Entity.ModelConfiguration;

namespace aspnetmvc_angular.Data.Configurations
{
    public class InstructorMapping:EntityTypeConfiguration<Instructor>
    {
        public InstructorMapping()
        {
            Property(p => p.Email).HasMaxLength(150).IsRequired();
            Property(p => p.Name).HasMaxLength(150).IsRequired();
            Property(p => p.RoomNumber).IsRequired();
        }
    }
}