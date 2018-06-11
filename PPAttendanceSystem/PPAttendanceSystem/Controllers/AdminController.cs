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

        // GET: Admin Dashboard landing page (different week view)
        public ActionResult AdminDashboardp1()
        {
            ViewBag.Message = "Admin Dashboard (-1wk)";

            return View();
        }

        // GET: Admin Dashboard landing page (different week view)
        public ActionResult AdminDashboardp2()
        {
            ViewBag.Message = "Admin Dashboard (-2wk)";

            return View();
        }

        // GET: Admin Dashboard landing page (different view specific to Monday)
        public ActionResult AdminDashboardm()
        {
            ViewBag.Message = "Admin Dashboard Monday";

            return View();
        }

        // GET: Admin Dashboard landing page (different view specific to Wednesday)
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
        
        // GET: Admin report on class community hours goal
        public ActionResult CommunityHours()
        {
            ViewBag.Message = "Community Hours";

            return View();
        }
        
        // GET: Admin calendar
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
        
        // GET: Admin custom report (all class)
        public ActionResult CustomReportResult()
        {
            ViewBag.Message = "Custom Report";

            return View();
        }
        
        // GET: Admin custom report (individual student)
        public ActionResult CustomReportIndividualResult()
        {
            ViewBag.Message = "Custom Individual Report";

            return View();
        }
        
        // GET: Class settings page
        public ActionResult ClassSettings()
        {
            ViewBag.Message = "Class Settings";

            return View();
        }

        // GET: Student Change Log for custom edits
        public ActionResult StudentChangeLog()
        {
            ViewBag.Message = "Student Change Log";

            return View();
        }
    }
}
