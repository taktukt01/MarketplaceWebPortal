using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketplaceWebPortal.Core.Interfaces;
using MarketplaceWebPortal.Core.POCOClasses;
using MarketplaceWebPortal.EntityLayer.Repository;
using MarketplaceWebPortal.UI.Models;

namespace MarketplaceWebPortal.UI.Controllers
{
    public class ProductDetailController : Controller
    {
        IProductDetailsRepository _iProductRepository;
        
        public ProductDetailController(IProductDetailsRepository repository)
        {
            _iProductRepository = repository;
        }

        

        public ActionResult Detail()
        {
            var _products = _iProductRepository.getProductDetail(1);
            List<ProductDetailUI> list = new List<ProductDetailUI>();
            list.Add(_products);
            return View(list);

        }
        public ActionResult Compare(Product product)
        {
            // input: ProductID
            int[] arr = product.ProductID;
            
            List<ProductDetailUI> list = new List<ProductDetailUI>();
            for (int i = 0; i < arr.Length; i++)
            {
                int productId = arr[i];
                //int productId = (int)idList.ElementAt(i);
                // each element in idList is a ProductID.
                var _products = _iProductRepository.getProductDetail(productId);
                list.Add(_products);
            }
            return View(list);
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