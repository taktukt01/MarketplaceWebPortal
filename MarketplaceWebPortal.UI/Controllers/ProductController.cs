using MarketplaceWebPortal.Core.Interfaces;
using MarketplaceWebPortal.Core.POCOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketplaceWebPortal.UI.Controllers
{
    public class ProductController : Controller
    {

        IProductRepository _productRepository;


        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }


        // GET: /Product/Summary
        public ActionResult Summary()
        {
            //get URL request parameter value
            var subcategoryName =Request.QueryString["subcategory"];
            //what does this return? --> List<ProductUI>
           List<ProductUI> list = _productRepository.SearchProduct(subcategoryName);



            return View(list);

        }
    }
}