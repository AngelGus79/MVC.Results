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

        /*The decorator  ChildActionOnly obliges that the action to be called eather RenderAction or Action methods
         If you try to call the Action by url an error will appeare*/
        [ChildActionOnly]
        public ViewResult GetProducts()
        {
            ViewBag.ProductSelectList = GetProductSelectList();
            return View(Products.getProducts());
        }

        public List<SelectListItem> GetProductSelectList()
        {
            ServiceProduct serviceProducts = new ServiceProduct();
            var products = serviceProducts.getProducts();
            List<SelectListItem> items = new List<SelectListItem>();

            int index = 0;
            foreach(var product in products)
            {
                items.Add(new SelectListItem
                {
                    Value = index.ToString(),
                    Text = product.Description
                });
                index++;
            }

            return items;
        }
        
    }
}