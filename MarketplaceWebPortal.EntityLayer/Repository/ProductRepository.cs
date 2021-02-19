 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarketplaceWebPortal.EntityLayer.Entities;
using MarketplaceWebPortal.Core.POCOClasses;
using MarketplaceWebPortal.Core.Interfaces;

namespace MarketplaceWebPortal.EntityLayer.Repository
{
    public class ProductRepository : IProductRepository
    {
        //private readonly MarketplaceWebPortalEntities2 context;

        ////inject the class that extends DbContext
        //public ProductRepository(MarketplaceWebPortalEntities2 context)
        //{
        //    this.context = context;
        //}
        public List<ProductUI> getAllProducts()
        {
            // SELECT * From Products

            throw new NotImplementedException();
        }

        //MarketplaceWebPortal.EntityLayer.Entities.Entities _entities;
        public List<ProductUI> getProductDetails()
        {
            // dummy data
            List<ProductUI> pListUI = new List<ProductUI>
            {
                //context.Products.
            };
            return pListUI;
            // return _entities.Products.ToList();
        }

  

        public void CreateProduct()
        {
            string modelName = "S-135-S0";
            int modelYear = 2019;
            Model model = new Model
            {
                model_name = modelName,
                model_year = modelYear
            };

            Manufacture manufacturer = new Manufacture
            {
                ManufactureName = "BigAss Fans"
            };

            SubCategory subcategory = new SubCategory
            {
                SubCategoryName = "Electric"
            };

            // get manufacturer ID using Manufacturer Name
            //var manufacturerID = from manufacturer in Manufactures select manufacturer;


            Product product = new Product
            {
                ProductImgUrl = "https://ichef.bbci.co.uk/news/1024/cpsprodpb/151AB/production/_111434468_gettyimages-1143489763.jpg",
                ProductName = "Fan 1",
                ModelID = 1,
                ManufactureID = 1,
                SubCategoryID = 1,


            };

        }

    }
}