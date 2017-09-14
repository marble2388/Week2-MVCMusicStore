using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week2_MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        // GET: Browse
        public ActionResult Browse(string genre)
        {
            ViewBag.Genre = genre;
            return View();
        }

    }
}



