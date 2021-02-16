using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarketplaceWebPortal.Core.POCOClasses;

namespace MarketplaceWebPortal.Core.Interfaces
{
    public interface IProductRepository
    {
        List<ProductUI> getProductDetails();
    }
}
