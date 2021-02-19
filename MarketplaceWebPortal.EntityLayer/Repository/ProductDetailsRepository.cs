using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarketplaceWebPortal.EntityLayer.Entities;
using MarketplaceWebPortal.Core.POCOClasses;
using MarketplaceWebPortal.Core.Interfaces;
using System.Diagnostics;

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

            var product = from pRecord in db.Products
                          where pRecord.ProductID == productID
                          join moRecord in db.Models
                          on pRecord.ModelID equals moRecord.Model_id
                          join maRecord in db.Manufactures
                          on pRecord.ManufactureID equals maRecord.ManufactureID
                          join sRecord in db.Series
                          on pRecord.SeriesID equals sRecord.SeriesID
                          join subRecord in db.SubCategories
                          on pRecord.SubCategoryID equals subRecord.SubCategoryID
                          join proRecord in db.Properties
                          on pRecord.PropertyID equals proRecord.PropertyID
                          join appRecord in db.Applications
                          on proRecord.ApplicationID equals appRecord.ApplicationID
                          select new ProductDetailUI
                          {
                              CategoryID = 1,
                              CategoryName = "Electrical",
                              model_name = moRecord.model_name,
                              model_year = moRecord.model_year,
                              series_name = sRecord.SeriesName,
                              ManufactureName = maRecord.ManufactureName,
                              Application = appRecord.ApplicationName,
                              use_type="Commercial",
                              MountingLocation=appRecord.MountingLocation,
                              air_flow=proRecord.air_flow,
                              power_min=proRecord.power_min,
                              power_max=proRecord.power_max,
                              operating_voltage_min=proRecord.operating_voltage_min,
                              operating_voltage_max=proRecord.operating_voltage_max,
                              fan_speed_min=proRecord.fan_speed_min,
                              fan_speed_max=proRecord.fan_speed_max,
                              number_of_fan_speed=proRecord.number_of_fan_speed,
                              fan_sweep_diameter=60,
                              height_min=proRecord.height_min,
                              height_max=proRecord.height_max,
                              weight=proRecord.weight,
                              Accessories=proRecord.Accessories
                          };
            List<ProductDetailUI> rList = new List<ProductDetailUI>();
            ProductDetailUI nUI=new ProductDetailUI();
            nUI.air_flow = 55000;
            foreach (ProductDetailUI item in product)
            {
                Debug.WriteLine(item.CategoryName);
                Debug.WriteLine(item.ProductID);
                nUI = item;
            }

            return nUI;
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


