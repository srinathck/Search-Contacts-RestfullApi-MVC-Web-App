using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeExrecise.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal Price { get; set; }
    }
}