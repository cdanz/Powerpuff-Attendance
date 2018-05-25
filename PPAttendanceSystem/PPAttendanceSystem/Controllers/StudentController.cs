using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5051.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student profile landing page
        public ActionResult StudentHome()
        {
            ViewBag.Message = "Student Home";

            return View();
        }

        // GET: Student report page
        public ActionResult StudentReport()
        {
            ViewBag.Message = "Student Report";

            return View();
        }

        // GET: Student profile edit page
        public ActionResult StudentEditProfile()
        {
            ViewBag.Message = "Student Edit Profile";

            return View();
        }
    }
}