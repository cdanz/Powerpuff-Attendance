using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5051.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Home Page";

            return View();
        }

        public ActionResult Student_Dashboard()
        {
            ViewBag.Message = "Student Dashboard";

            return View();
        }

        public ActionResult Student_New()
        {
            ViewBag.Message = "Student New";

            return View();
        }

        public ActionResult Puzzle()
        {
            ViewBag.Message = "Puzzle";

            return View();
        }

        public ActionResult Admin_Login()
        {
            ViewBag.Message = "Admin Login";

            return View();
        }

        public ActionResult AdminDashboard()
        {
            ViewBag.Message = "Admin Dashboard";

            return View();
        }

        public ActionResult ClassSettings()
        {
            ViewBag.Message = "Class Settings";

            return View();
        }

        public ActionResult CustomReport()
        {
            ViewBag.Message = "Build Custom Report";

            return View();
        }
        public ActionResult ClassRoster()
        {
            ViewBag.Message = "Class Roster";

            return View();
        }
    }
}