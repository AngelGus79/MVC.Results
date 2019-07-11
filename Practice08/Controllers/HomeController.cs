using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice08.Services;

namespace Practice08.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Sales()
        {


            /*Products*/

            ServiceProduct serviceProduct = new ServiceProduct();
            var Products = serviceProduct.getProducts();
            ViewBag.Products = Products;

            /*Clients*/

            ServiceClient serviceClient = new ServiceClient();
            var Clients = serviceClient.getClients();
            ViewBag.Clients = Clients;


            return View();
        }

        /*returning a string*/
        public ContentResult PrintName(string Name)
        {
            return Content(Name);
        }

        public ContentResult PrintAge()
        {
            return Content("The Age is: <h1>4</h1>");
        }

        public ContentResult PrintDate()
        {
            return Content(DateTime.Today.ToString(),"text/html");
        }

       
    }
}