using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketplaceWebPortal.Core.Interfaces;
using MarketplaceWebPortal.EntityLayer.Repository;
using Unity;
using Unity.AspNet.Mvc;

namespace MarketplaceWebPortal.UI
{
    public class UnityContainerRegistration
    {
        public static IUnityContainer InitializeContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
    }
}