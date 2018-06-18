﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace full_inventory
{
    class Product
    {

        public string name { get; set; }

        public Double price { get; set; }

        public double quantity { get; set; }

        public string type { get; set; }

        public Product(string name, Double price, int quantity, string type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }


    }
}
