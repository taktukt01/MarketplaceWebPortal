using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarketplaceWebPortal.EntityLayer.Entities;
using MarketplaceWebPortal.Core.POCOClasses;
using MarketplaceWebPortal.Core.Interfaces;

namespace MarketplaceWebPortal.EntityLayer.Repository
{
    public class ProductRepository:IProductRepository
    {
        MarketplaceWebPortal.EntityLayer.Entities.Entities _entities;
        public List<ProductUI> getProductDetails()
        {
            // dummy data
            List<ProductUI> pListUI = new List<ProductUI> 
            {
                new ProductUI{ProductID=1,ModelID=1,ManufacturerID=1,ProductImgUrl="https://ichef.bbci.co.uk/news/1024/cpsprodpb/151AB/production/_111434468_gettyimages-1143489763.jpg",SubCategoryID=1,ProductName="Product1"},
                new ProductUI{ProductID=2,ModelID=21,ManufacturerID=11,ProductImgUrl="/p1.jpg",SubCategoryID=1,ProductName="Product2"},
                new ProductUI{ProductID=3,ModelID=33,ManufacturerID=10,ProductImgUrl="/p111.jpg",SubCategoryID=1,ProductName="Product133"}

            };
            return pListUI;
           // return _entities.Products.ToList();
        }
    }
}