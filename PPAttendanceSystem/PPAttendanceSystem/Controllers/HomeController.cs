using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5051.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Student_Dashboard()
        {
            ViewBag.Message = "Student Dashboard.";

            return View();
        }

        public ActionResult Admin_Login()
        {
            ViewBag.Message = "Admin Login";

            return View();
        }

        public ActionResult Admin_Main()
        {
            ViewBag.Message = "Admin Main";

            return View();
        }

        public ActionResult Admin_Edits()
        {
            ViewBag.Message = "Admin Edits";

            return View();
        }
    }
}