using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarketplaceWebPortal.EntityLayer.Entities;
using MarketplaceWebPortal.Core.POCOClasses;
using MarketplaceWebPortal.Core.Interfaces;

namespace MarketplaceWebPortal.EntityLayer.Repository
{
    public class ProductDetailsRepository:IProductDetailsRepository
    {
        private readonly MarketplaceWebPortalEntities context;

        //inject the class that extends DbContext
        public ProductDetailsRepository(MarketplaceWebPortalEntities context)
        {
            this.context = context;
        }
       
        public ProductDetailUI getProductDetail(int productID)
        {
            ProductDetailUI detail = new ProductDetailUI();

            //categories
            detail.CategoryID = 1;
            detail.CategoryName = "Electrical";

            detail.model_name = "Customm Model";
            detail.model_year = 2020;
            //series
            detail.series_name = "Haiku H";
            //manufacture
            detail.ManufactureName = "Big Ass";
            detail.Application = "Indoor";
            detail.use_type = "Commercial";
            detail.MountingLocation = "Table";

            //technical specifications
            detail.air_flow = 5467;
            detail.power_min = 2;
            detail.power_max = 21;
            detail.operating_voltage_min = 100;
            detail.operating_voltage_max = 240;
            detail.fan_speed_min = 35;
            detail.fan_speed_max = 200;
            detail.number_of_fan_speed = 7;
            detail.sound_at_max_speed = 35;
            detail.fan_sweep_diameter = 60;
            detail.height_min = 12;
            detail.height_max = 53;
            detail.weight = 13;
            detail.Accessories = "With Light";
            return detail;
        }



        /*
         *  input: SubCategoryName
         *  
         *  output: 3 Products that match the subcategory name, with additional details on the products.
         * 
         */
        public List<ProductDetailUI> searchProduct(string categoryname , string subcategoryName)
        {
                List<ProductDetailUI> products = new List<ProductDetailUI>();

            //grab subcategory ID that matches subcategoryName

            var x = context.Categories.ToList();            // returns 0 

           //grab all subcategories with name = SubcategoryName

            var subcats = (context.SubCategories.Where(sub => sub.SubCategoryName == subcategoryName)).ToList();




            if (subcats.Count == 0)
            {
                List<ProductDetailUI> poo = new List<ProductDetailUI>();
                return poo;
                //no subcategory found
            }//if Subcategory exists in DB then return its CategoryID
            int SubCategoryID = subcats[0].SubCategoryID;
            int CategoryID = (int)(subcats[0].CategoryID);


            string CategoryName = context.Categories.Where(cat => cat.CategoryID == CategoryID).First().CategoryName;
            var productsList = context.Products.Where(p => p.SubCategoryID == SubCategoryID).ToList();


            /*
             *  for each product that matches the SubCategoryID, let's create a ProductDetail model 
             */
            foreach(var product in productsList)
            {
                int productId = product.ProductID;


                int modelID =(int) product.ModelID;
                var ProductModel = context.Models.Where(model => model.Model_id == modelID).First();
                int model_year = ProductModel.model_year;
                string model_name =  ProductModel.model_name;
                int manufacturerID = (int)product.ManufactureID;
                var ProductManufacturer = context.Manufactures.Where(manufacturer => manufacturer.ManufactureID  == manufacturerID).First();
                string manufacturerName = ProductManufacturer.ManufactureName;

                //how to get series ID?
                // we have manufacturerID  ,, not sure about this.
                var ManufacturerSeries = context.ManufactureSeries.Where(m => m.ManufactureID == manufacturerID).First();
                int series_id = (int) ManufacturerSeries.SeriesID;
                string series_name = context.Series.Where(s => s.SeriesID == series_id).First().SeriesName;

                var application = context.Properties.Where(c => c.ProductID == productId).First();
                int airflow = application.air_flow;
                decimal min_power = application.power_min;
                decimal max_power = application.power_max;
                int operating_volt_min = application.operating_voltage_min;
                int operating_volt_max = application.operating_voltage_max;
                int fan_speed_min = application.fan_speed_min;
                int fan_speed_max = application.fan_speed_max;
                int numFans = application.number_of_fan_speed;
                int soundAtMaxSpeed = application.sound_at_max_speed;
                decimal min_height = application.height_min;
                int max_height =(int) application.height_max;
                int weight = (int)application.weight;
                string productUrl = product.ProductImgUrl;
                ////string mountingLoc = 

                ProductDetailUI productDetail = new ProductDetailUI
                {
                    ManufactureName = manufacturerName,
                    model_year = model_year,
                    model_name = model_name,
                    series_name = series_name,
                    air_flow = airflow,
                    power_min = (float)min_power,
                    power_max = (float)max_power,
                    operating_voltage_min = operating_volt_min,
                    operating_voltage_max = operating_volt_max,
                    fan_speed_min = fan_speed_min,
                    fan_speed_max = fan_speed_max,
                    number_of_fan_speed = numFans,
                    sound_at_max_speed = soundAtMaxSpeed,
                    //fan sweep diameter missing
                    height_min = (float)min_height,
                    height_max = max_height,
                    weight = weight,
                    ProductURL = productUrl,
                    MountingLocation = "blah",
                    Accessories="With Lights",
                    CategoryName = CategoryName,
                    SubCategoryName = subcategoryName,
                    Application="Blah",


                };

                products.Add(productDetail);
            }

            // what do I need to grab....
            // let's start with Property for each Product

                //context.Categories.Select("")
                //context.SubCategories.Find()

                // grab subCategoryID from Products entity List...
                // get collection of Products that matches the subcategory name




                return products;
                // we will reutnr all the Product Result , however in Controller only grab 3.
            }

        }
    }


