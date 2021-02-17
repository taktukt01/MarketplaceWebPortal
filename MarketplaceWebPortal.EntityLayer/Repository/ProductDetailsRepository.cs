using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using MarketplaceWebPortal.EntityLayer.Entities;
using MarketplaceWebPortal.Core.POCOClasses;
using MarketplaceWebPortal.Core.Interfaces;

namespace MarketplaceWebPortal.EntityLayer.Repository
{
    public class ProductDetailsRepository:IProductDetailsRepository
    {
        public ProductDetailUI getProductDetail(int productID)
        {
            ProductDetailUI detail = new ProductDetailUI();



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
    }
}