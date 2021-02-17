using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketplaceWebPortal.UI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }


        // GET: /Product/Summary
        public ActionResult Summary()
        {


            return View();

        }
    }
}