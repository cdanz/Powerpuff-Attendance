using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5051.Controllers
{
    public class KioskController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Home Page";

            return View();
        }

        public ActionResult StudentDashboard()
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

    }
}