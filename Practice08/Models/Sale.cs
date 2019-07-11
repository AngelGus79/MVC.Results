using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice08.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}