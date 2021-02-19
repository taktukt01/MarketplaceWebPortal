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

        IProductDetailsRepository _productRepository;


        public ProductController(IProductDetailsRepository productRepository)
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
            //List<ProductDetailUI> list = _productRepository.SearchProduct(subcategoryName);
           List<ProductDetailUI> ListProducts = _productRepository.searchProduct("Electrical","Fan");


            return View(ListProducts);

        }
    }
}