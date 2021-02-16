using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarketplaceWebPortal.EntityLayer.Entities;

namespace MarketplaceWebPortal.EntityLayer.Repository
{
    public class ProductRepository
    {
        MarketplaceWebPortal.EntityLayer.Entities.Entities _entities;
        public List<Product> getProductDetails()
        {
            List<Product> pList = new List<Product> 
            {
                new Product{ProductID=1,ModelID=1,ManufacturerID=1,ProductImgUrl="/p.jpg",SubCategoryID=1,ProductName="Product1"},
                new Product{ProductID=2,ModelID=21,ManufacturerID=11,ProductImgUrl="/p1.jpg",SubCategoryID=1,ProductName="Product2"},
                new Product{ProductID=3,ModelID=33,ManufacturerID=10,ProductImgUrl="/p111.jpg",SubCategoryID=1,ProductName="Product133"}

            };
            return pList;
           // return _entities.Products.ToList();
        }
    }
}