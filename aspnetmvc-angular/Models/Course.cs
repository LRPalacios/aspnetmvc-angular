using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspnetmvc_angular.Models
{
    public class Course:BaseEntity
    {
        public string Number { get; set; }

        public string Name { get; set; }

        public string Instructor { get; set; }
    }
}