using System.Web.Mvc;
using _5051.Models;
using _5051.Backend;

namespace _5051.Controllers
{
    public class KioskController : Controller
    {

        public ActionResult StudentDashboard()
        {
            ViewBag.Message = "Student Dashboard";

            return View();
        }

        public ActionResult StudentNew()
        {
            ViewBag.Message = "Student New";

            return View();
        }
    }
}