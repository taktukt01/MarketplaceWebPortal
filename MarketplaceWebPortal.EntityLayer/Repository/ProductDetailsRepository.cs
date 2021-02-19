using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using MarketplaceWebPortal.EntityLayer.Entities;
using MarketplaceWebPortal.Core.POCOClasses;
using MarketplaceWebPortal.Core.Interfaces;
using System.Diagnostics;

namespace MarketplaceWebPortal.EntityLayer.Repository
{
    public class ProductDetailsRepository:IProductDetailsRepository
    {
        Entities.MarketplaceWebPortalEntities3 db = new Entities.MarketplaceWebPortalEntities3();
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


    }


}