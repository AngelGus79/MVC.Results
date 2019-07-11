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
            /**/

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
        
        

    }
}