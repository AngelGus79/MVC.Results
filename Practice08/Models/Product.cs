﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice08.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public string Category { get; set; }

        public DateTime FirstDate { get; set; }

    }
}