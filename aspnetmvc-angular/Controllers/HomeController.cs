using aspnetmvc_angular.Models.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnetmvc_angular.Controllers
{
    public class HomeController : Controller
    {
        private RegistrationContext _db;

        public HomeController()
        {
            _db = new RegistrationContext();
        }

        public ActionResult Index()
        {
            var courses = _db.Courses.ToList();
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializedCourses = JsonConvert.SerializeObject(courses, Formatting.None, settings);
            return View("Index", "",  serializedCourses);
        }
    
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}