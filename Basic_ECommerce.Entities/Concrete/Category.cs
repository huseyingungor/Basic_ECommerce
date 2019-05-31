using Basic_ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_ECommerce.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
