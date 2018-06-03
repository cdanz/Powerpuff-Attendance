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

        public ActionResult AdminDashboardp1()
        {
            ViewBag.Message = "Admin Dashboard (-1wk)";

            return View();
        }

        public ActionResult AdminDashboardp2()
        {
            ViewBag.Message = "Admin Dashboard (-2wk)";

            return View();
        }

        public ActionResult AdminDashboardm()
        {
            ViewBag.Message = "Admin Dashboard Monday";

            return View();
        }

        public ActionResult AdminDashboardw()
        {
            ViewBag.Message = "Admin Dashboard Wednesday";

            return View();
        }

        // GET: Class Roster
        public ActionResult ClassRoster()
        {
            ViewBag.Message = "Class Roster";

            return View();
        }
        public ActionResult CommunityHours()
        {
            ViewBag.Message = "Community Hours";

            return View();
        }
        public ActionResult SchoolCalendar()
        {
            ViewBag.Message = "School Calendar";

            return View();
        }
        // GET: Custom Report
        public ActionResult CustomReport()
        {
            ViewBag.Message = "Build Custom Reports";

            return View();
        }
        public ActionResult CustomReportResult()
        {
            ViewBag.Message = "Custom Report";

            return View();
        }
        public ActionResult CustomReportIndividualtResult()
        {
            ViewBag.Message = "Custom Individual Report";

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