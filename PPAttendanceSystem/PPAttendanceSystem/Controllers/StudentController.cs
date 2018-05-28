using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5051.Models;

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

        [HttpPost]
        public ActionResult Index(UsernameModels user)
        {
            string userId = user.Id;
            string name = user.Username;

            return View();
        }

        // GET: Student username
        /// <summary>
        /// Read information on a single user and assign template username
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Username/Details/5
        public ActionResult Read(string id = null)
        {
            var myData = "Mystery Explorer";
            return View(myData);
        }
    }
}