﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECorpSales.Models
{
    public class Carts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CartId { get; set; }
        public int Item { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal CartTotal { get; set; }
    }
}
