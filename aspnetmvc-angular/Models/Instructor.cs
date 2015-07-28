namespace aspnetmvc_angular.Models
{
    public class Instructor:BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int RoomNumber { get; set; }
    }
}