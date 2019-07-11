using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice08.Models;

namespace Practice08.Services
{
    public class ServiceSale
    {
        public List<Sale> Sales;

        public ServiceSale()
        {
            Sales = new List<Sale>();
        }

        public void addSale(Product product, Client client, int quantity, DateTime saleDate)
        {

            var MaxSaleId = Sales.Select(s => s.SaleId).Max();

            int saleId = (int)MaxSaleId + 1;
            Sales.Add(new Sale { Product = product, Client = client, Quantity = quantity, SaleDate = saleDate, SaleId = saleId });
           
            

        }

    }
}