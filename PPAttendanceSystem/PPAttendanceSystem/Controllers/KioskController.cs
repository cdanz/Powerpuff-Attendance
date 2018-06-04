using System.Web.Mvc;
using _5051.Models;
using _5051.Backend;

namespace _5051.Controllers
{
    public class KioskController : Controller
    {

        // GET: Old, faked view of student kiosk page
        public ActionResult StudentDashboard()
        {
            ViewBag.Message = "Student Dashboard";

            return View();
        }

        // GET: Old, faked view of add new student page
        public ActionResult StudentNew()
        {
            ViewBag.Message = "Student New";

            return View();
        }
    }
}
