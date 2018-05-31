using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5051.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin Dashboard landing page
        public ActionResult AdminDashboard()
        {
            ViewBag.Message = "Admin Dashboard";

            return View();
        }

        // GET: Class Roster
        public ActionResult ClassRoster()
        {
            ViewBag.Message = "Class Roster";

            return View();
        }

        // GET: Custom Report
        public ActionResult CustomReport()
        {
            ViewBag.Message = "Build Custom Report";

            return View();
        }

        // GET: Class Settings
        public ActionResult ClassSettings()
        {
            ViewBag.Message = "Class Settings";

            return View();
        }
    }
}