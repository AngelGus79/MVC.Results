using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice08.Models;

namespace Practice08.Services
{
    public class ServiceProduct
    {

        public Product getProduct()
        {
            Product product = new Product { ProductId = 1, Description = "Laptop", Price = 7599.99m };

            return product;
        }

        public List<Product> getProducts()
        {
            Product product1 = new Product { ProductId = 1, Description = "Laptop", Price = 7599.99m };
            Product product2 = new Product { ProductId = 2, Description = "Desktop", Price = 6599.99m };

            return new List<Product> { product1, product2 };
        }


    }
}