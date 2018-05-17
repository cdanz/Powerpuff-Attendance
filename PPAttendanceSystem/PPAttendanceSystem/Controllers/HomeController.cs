﻿using System;
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
            return View();
        }



        public ActionResult Dashboard()
        {
            ViewBag.Message = "Student Dashboard.";

            return View();
        }

        public ActionResult Admin_Login()
        {
            ViewBag.Message = "Admin Login";

            return View();
        }
    }
}