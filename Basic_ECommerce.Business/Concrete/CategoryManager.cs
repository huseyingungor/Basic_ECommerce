using Basic_ECommerce.Business.Abstract;
using Basic_ECommerce.DataAccess.Abstract;
using Basic_ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_ECommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int categoryId)
        {
            _categoryDal.Delete(new Category { CategoryId = categoryId });
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public List<Category> GetByCategoryId(int categoryId)
        {
            return _categoryDal.GetList(x => x.CategoryId == categoryId);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
