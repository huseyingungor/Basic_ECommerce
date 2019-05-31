using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic_ECommerce.Business.Abstract;
using Basic_ECommerce.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic_ECommerce.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int page = 1, int category = 0)
        {
            int pageSize = 10;
            var productList = _productService.GetByCategoryId(category);

            return View(new ProductListViewModel
            {
                ProductList = productList.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                CurrentPage = page,
                CurrentCategory = category,
                PageSize = pageSize,
                PageCount = Convert.ToInt32(Math.Ceiling(productList.Count / (double)pageSize))
            });
        }
    }
}