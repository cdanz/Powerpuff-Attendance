using System.Web.Mvc;
using _5051.Models;
using _5051.Backend;

namespace _5051.Controllers
{
    /// <summary>
    /// Avatar Contoller manages the avatar web pages including how to make new ones, change them, and delete them
    /// </summary>
    public class AvatarController : Controller
    {
        // A ViewModel used for the Avatar that contains the AvatarList
        private AvatarViewModel avatarViewModel = new AvatarViewModel();

        // The Backend Data source
        private AvatarBackend avatarBackend = AvatarBackend.Instance;

        // GET: Avatar
        /// <summary>
        /// Index, the page that shows all the avatars
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            // Load the list of data into the AvatarList
            avatarViewModel.AvatarList = avatarBackend.Index();
            return View(avatarViewModel);
        }

        /// <summary>
        /// Read information on a single avatar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Avatar/Details/5
        public ActionResult Read(string id = null)
        {
            var myData = avatarBackend.Read(id);
            return View(myData);
        }

        /// <summary>
        /// This opens up the make a new Avatar screen
        /// </summary>
        /// <returns></returns>
        // GET: Avatar/Create
        public ActionResult Create()
        {
            var myData = new AvatarModel();
            return View(myData);
        }

        /// <summary>
        /// Make a new avatar sent in by the create avatar screen
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        // POST: Avatar/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include=
                                        "Id,"+
                                        "Name,"+
                                        "Description,"+
                                        "Uri,"+
                                        "")] AvatarModel data)
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

            avatarBackend.Create(data);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// This will show the details of the avatar to update
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Avatar/Edit/5
        public ActionResult Update(string id = null)
        {
            var myData = avatarBackend.Read(id);
            return View(myData);
        }

        /// <summary>
        /// This updates the avatar based on the information posted from the udpate page
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        // POST: Avatar/Update/5
        [HttpPost]
        public ActionResult Update([Bind(Include=
                                        "Id,"+
                                        "Name,"+
                                        "Description,"+
                                        "Uri,"+
                                        "")] AvatarModel data)
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

            avatarBackend.Update(data);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// This shows the avatar info to be deleted
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Avatar/Delete/5
        public ActionResult Delete(string id = null)
        {
            var myData = avatarBackend.Read(id);
            return View(myData);
        }

        /// <summary>
        /// This deletes the avatar sent up as a post from the avatar delete page
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        // POST: Avatar/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind(Include=
                                        "Id,"+
                                        "Name,"+
                                        "Description,"+
                                        "Uri,"+
                                        "")] AvatarModel data)
        {
            if (!ModelState.IsValid)
            {
                // Send back for edit
                return View(data);
            }

            if (data == null)
            {
                // Send to Error Page
                return RedirectToAction("Error", new { route = "Home", action = "Error" });
            }

            if (string.IsNullOrEmpty(data.Id))
            {
                // Send back for Edit
                return View(data);
            }

            avatarBackend.Delete(data.Id);

            return RedirectToAction("Index");
        }
    }
}