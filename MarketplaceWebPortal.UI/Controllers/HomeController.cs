using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketplaceWebPortal.EntityLayer.Repository;

namespace MarketplaceWebPortal.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var _repository = new ProductRepository();
            var _products = _repository.getProductDetails();
            return View(_products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}