using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5051.Controllers
{
    public class LandingController : Controller
    {
        // GET: Landing
        public ActionResult Home()
        {
            ViewBag.Message = "Home";
            return View();
        }

        // GET: Student profile login page
        public ActionResult StudentLogin()
        {
            ViewBag.Message = "Student Login";

            return View();
        }
    }
}