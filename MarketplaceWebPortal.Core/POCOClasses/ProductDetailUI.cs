﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MarketplaceWebPortal.Core.POCOClasses
{
    public class ProductDetailUI
    {


        [Key]
        public int ProductID { get; set; }
        //model
        public string ProductURL { get; set; }
        public string model_name { get; set; }
        public int model_year { get; set; }
        //series
        public string series_name { get; set; }
        //manufacture
        public string ManufactureName { get; set; }

        //property

        //Category, SubCategory
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public string SubCategoryName { get; set; }


        //property-application

        public string use_type { get; set; }
        
        public string Application { get; set; }
        public string MountingLocation { get; set; }
        
        //technical specifications
        public int air_flow { get; set; }
        public decimal power_min { get; set; }
        public decimal power_max { get; set; }
        public int operating_voltage_min { get; set; }
        public int operating_voltage_max { get; set; }
        public int fan_speed_min { get; set; }
        public int fan_speed_max { get; set; }
        public int number_of_fan_speed { get; set; }
        public int sound_at_max_speed { get; set; }

        public float fan_sweep_diameter { get; set; }
        public decimal height_min { get; set; }
        public decimal height_max { get; set; }
        public decimal weight { get; set; }

        
        public string Accessories { get; set; }



    }
}
