using Basic_ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_ECommerce.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        void Add(Product product);
        void Delete(int productId);
        void Update(Product product);
        Product GetById(int productId); 
    }
}
