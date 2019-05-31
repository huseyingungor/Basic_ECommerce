using Basic_ECommerce.Core.DataAccess;
using Basic_ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_ECommerce.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
