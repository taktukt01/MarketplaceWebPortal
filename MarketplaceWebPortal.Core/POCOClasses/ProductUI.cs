using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MarketplaceWebPortal.Core.POCOClasses
{
    //model of Product
    public class ProductUI
    {
        public int ProductID { get; set; }
        public Nullable<int> ModelID { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public string ProductImgUrl { get; set; }
        public Nullable<int> SubCategoryID { get; set; }
        public string ProductName { get; set; }
    }
}
