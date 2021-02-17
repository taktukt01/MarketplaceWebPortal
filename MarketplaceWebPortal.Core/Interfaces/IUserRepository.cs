using System;
using System.Collections.Generic;
using System.Text;
using MarketplaceWebPortal.Core.POCOClasses;
using System.Web;

namespace MarketplaceWebPortal.Core.Interfaces
{
    public interface IUserRepository
    {
        List<UserUI> getUsers();

        void Create(UserUI entity);

    }
}