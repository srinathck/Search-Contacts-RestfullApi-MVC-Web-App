using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchRestful.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; }
    }
}