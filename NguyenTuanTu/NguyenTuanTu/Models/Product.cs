﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenTuanTu.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}