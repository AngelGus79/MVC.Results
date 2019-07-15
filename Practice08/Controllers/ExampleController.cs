using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice08.Services;


namespace Practice08.Models
{
    public class ExampleController : Controller
    {
        // GET: Example

        ServiceProduct Products;
        public ExampleController()
        {
            Products = new ServiceProduct();
        }

        public ActionResult Index()
        {
            return View();
        }

        /*  Learning view Action*/
        public ViewResult GetProduct(int ProductId)
        {

            var product = (from p in Products.Products
                          where p.ProductId == ProductId
                          select p).FirstOrDefault();
            return View(product);
        }
    }
}