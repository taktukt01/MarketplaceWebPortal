using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketplaceWebPortal.Core.Interfaces;
using MarketplaceWebPortal.EntityLayer.Repository;

namespace MarketplaceWebPortal.UI.Controllers
{
    public class HomeController : Controller
    {
        IProductRepository _iProductRepository;
        
        public HomeController(IProductRepository iProductRepository)
        {
            _iProductRepository = iProductRepository;
        }

        

        public ActionResult Index()
        {
            var _products = _iProductRepository.getProductDetails();
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