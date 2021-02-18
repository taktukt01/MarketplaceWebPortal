using System;
using System.Collections.Generic;
using System.Text;
using MarketplaceWebPortal.Core.POCOClasses;

namespace MarketplaceWebPortal.Core.Interfaces
{
    public interface IProductDetailsRepository
    {
        ProductDetailUI getProductDetail(int productID);
    }
}
