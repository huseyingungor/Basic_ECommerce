using Basic_ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_ECommerce.Web.Models
{
    public class ProductListViewModel
    {
        public List<Product> ProductList{ get; set; }
        public int CurrentPage { get; set; }
        public int CurrentCategory { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
    }
}
