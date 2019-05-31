using Basic_ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_ECommerce.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetByCategoryId(int categoryId);
        void Add(Category category);
        void Delete(int categoryId);
        void Update(Category category);
    }
}
