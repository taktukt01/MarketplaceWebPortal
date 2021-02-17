using System;
using System.Collections.Generic;
using System.Text;

namespace MarketplaceWebPortal.Core.Interfaces
{
    public interface IRepository<T, in TPK> where T : class
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
