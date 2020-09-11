﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECorpSales.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public int Item { get; set; }
        public string Name { get; set; }
        public string Buyer { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
