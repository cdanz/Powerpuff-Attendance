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

        /// <summary>
        /// This will show the details of the username to update
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Username/Edit/5
        public ActionResult Update(string id = null)
        {
            var myData = "J. Doe";
            return View(myData);
        }

        /// <summary>
        /// This updates the username based on the information posted from the udpate page
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        // POST: Username/Update/5
        [HttpPost]
        public ActionResult Update([Bind(Include=
                                        "Id,"+
                                        "Name,"+
                                        "")] UsernameModels data)
        {
            if (!ModelState.IsValid)
            {
                // Send back for edit
                return View(data);
            }

            if (data == null)
            {
                // Send to error page
                return RedirectToAction("Error", new { route = "Home", action = "Error" });
            }

            if (string.IsNullOrEmpty(data.Id))
            {
                // Send back for Edit
                return View(data);
            }

            return RedirectToAction("Index");
        }


        /// <summary>
        /// This opens up the make a new username screen
        /// </summary>
        /// <returns></returns>
        // GET: Username/Create
        public ActionResult Create()
        {
            var myData = new UsernameModels();
            return View(myData);
        }

        /// <summary>
        /// Make a new profile name sent in by the edit student profile screen
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        // POST: Username/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include=
                                        "Id,"+
                                        "Username,"+
                                        "")] UsernameModels data)
        {
            if (!ModelState.IsValid)
            {
                // Send back for edit, with Error Message
                return View(data);
            }

            if (data == null)
            {
                // Send to Error Page
                return RedirectToAction("Error", new { route = "Home", action = "Error" });
            }

            if (string.IsNullOrEmpty(data.Id))
            {
                // Sind back for Edit
                return View(data);
            }

            return RedirectToAction("Index");
        }
    }
}