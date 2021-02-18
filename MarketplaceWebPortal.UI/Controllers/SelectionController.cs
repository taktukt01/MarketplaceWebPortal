using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketplaceWebPortal.Controllers
{
    public class SelectionController : Controller
    {
        public ActionResult ShowSelection()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Details(string selectedtText, string Category)
        {
            return View("Selection");
        }
    }
}