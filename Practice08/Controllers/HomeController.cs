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
        [HttpGet]
        public ViewResult Index()
        {
            ViewBag.Title = "Index Page";
            return View();
        }

        [HttpPost]
        public ViewResult Index(Practice08.Models.Product Product )
        {
            return View();
        }

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

        /*Returning Json */

            /*when you use Get method, it generates a error like below*/
        public JsonResult GetJsonError()
        {
            ServiceProduct serviceProduct = new ServiceProduct();
            var Products = serviceProduct.getProducts();
            return Json(Products);
                
        }
        /* Normally you have to get the json information with Post method*/
        /* but if you want to get with Get method you have to allow*/
        public JsonResult GetJson()
        {
            ServiceProduct serviceProduct = new ServiceProduct();
            var Products = serviceProduct.getProducts();


            return Json(Products, JsonRequestBehavior.AllowGet /*Get Method Allowed*/ );
        }

        /*Redirecting to a google*/

        public RedirectResult GetGoogle()
        {
            return Redirect("https://www.google.com");
        }
       
        /*Redirecting to another Action*/
        public RedirectToRouteResult Redirect2Action()
        {
            return RedirectToAction("GetJson");
        }

        /*Redirect Route*/
        public RedirectToRouteResult Redirect2Route()
        {
            return RedirectToRoute("JsonRoute");
        }

        /* returning Http status code result */

        public HttpStatusCodeResult ServerError()
        {
            return new HttpStatusCodeResult(505);
        }

        public HttpStatusCodeResult ResourceNoFound()
        {
            return new HttpStatusCodeResult(404);
        }

        public HttpStatusCodeResult Redirecting()
        {
            return new HttpStatusCodeResult(303);
        }

        /*Returning a File*/

        public FileResult GetPDF()
        {
            var ruta = Server.MapPath("~/cv.pdf");
            return File(ruta, "application/pdf");
        }

        /*Query strings*/
        /*If you do not write any query, there is no problem because string type accept null*/
        public ViewResult QueryString(string title)
        {
            ViewBag.String = title;
            return View();
        }

        /*If you do not write any query, there is PROBLEM because int type does not accept null value*/

        public ViewResult QueryStringInt(int Age)
        {
            ViewBag.Age = Age;
            return View();
        }

        /*Post method*/
        public ViewResult PostMethod()
        {
            return View();
        }

        [HttpPost]
        public ViewResult PostMethod(int Age)
        {
            ViewBag.Age = Age;
            return View();
        }
        [HttpPost]
        public ViewResult PostMethodName(string Name)
        {
            ServiceProduct ServiceProducts = new ServiceProduct();
            var products = ServiceProducts.getProducts();
            ViewBag.Name = Name;
            return View(products);
            
        }
        
        public ViewResult PostMethodName()
        {
            ServiceProduct ServiceProducts = new ServiceProduct();
            var products = ServiceProducts.getProducts();
          
            return View(products);
        }

        public ViewResult Display()
        {
            ServiceProduct ServiceProducts = new ServiceProduct();
            var product = ServiceProducts.getProduct();

            ViewBag.Properties = product;
            return View();
        }

        public ViewResult Clients()
        {
            ServiceClient serviceClient = new ServiceClient();
            var client = serviceClient.getClient();
            ViewBag.Client = client;

            return View();

        }

    }
}