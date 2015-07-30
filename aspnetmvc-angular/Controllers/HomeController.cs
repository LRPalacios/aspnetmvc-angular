using aspnetmvc_angular.Models.Data;
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
            return View(courses);
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