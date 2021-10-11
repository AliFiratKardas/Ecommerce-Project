using Api.Models;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class ProductsController : ApiController
    {
        ProductService productService = new ProductService();
        public List<ProductVM> GetProducts()
        {

            var products = productService.GetList().Select(x => new ProductVM
            {
                ProductID=x.ID,
                ProductName=x.ProductName,
                UnitPrice=x.UnitPrice,
                UnitsInStock=x.UnitsInStock
            });
            return products.ToList();
        }


    }
}
