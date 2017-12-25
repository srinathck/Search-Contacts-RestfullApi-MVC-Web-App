using RestfulSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestfulSearch.Controllers
{
    public class PersonController : ApiController
    {
        static ICollection<Person> persons = new Person[]
            {
            new Person { ID = 1, FirstName = "TomatoSoup", LastName = "Groceries", Phone = 9827254738 },
            new Person { ID = 2, FirstName = "Yoyo", LastName = "Toys", Phone = 9827254738 },
            new Person { ID = 3, FirstName = "Hammer", LastName = "Hardware", Phone = 9827254738 },
            new Person { ID = 4, FirstName = "Kokl", LastName = "Groceries", Phone = 9827254738 },
            new Person { ID = 5, FirstName = "vvo", LastName = "Hardware", Phone = 9827254738 },
            new Person { ID = 6, FirstName = "bbgbmk", LastName = "Toys", Phone = 9827254738 },
            new Person { ID = 7, FirstName = "efrv", LastName = "Groceries", Phone = 9827254738 },
            new Person { ID = 8, FirstName = "Ypoiehfje", LastName = "Toys", Phone = 9827254738 },
            new Person { ID = 9, FirstName = "Yoedyo", LastName = "Toys", Phone = 9827254738 },
            new Person { ID = 10, FirstName = "lskjj", LastName = "Groceries", Phone = 9827254738 },
            new Person { ID = 11, FirstName = "deedeyo", LastName = "Hardware", Phone = 9827254738 },
            new Person { ID = 12, FirstName = "Yeffv", LastName = "Hardware", Phone = 9827254738 },
            new Person { ID = 13, FirstName = "wed", LastName = "Toys", Phone = 9827254738 },
            new Person { ID = 14, FirstName = "ccdcd", LastName = "Groceries", Phone = 9827254738 },
            new Person { ID = 15, FirstName = "eefrf", LastName = "Hardware", Phone = 9827254738 }
            };

        [HttpGet]
        public IHttpActionResult Search(string fname, string lname)
        {
            List<Person> person = new List<Person>();

            if (!string.IsNullOrEmpty(fname) && !string.IsNullOrEmpty(lname))
            {
                person = persons.Where(x => x.FirstName.ToLower().Trim().Contains(fname.ToLower().Trim()) && x.LastName.ToLower().Trim().Contains(lname.ToLower().Trim())).ToList();
            }
            else if (!string.IsNullOrEmpty(fname) && string.IsNullOrEmpty(lname))
            {
                person = persons.Where(x => x.FirstName.ToLower().Trim().Contains(fname.ToLower().Trim())).ToList();
            }

            else if (string.IsNullOrEmpty(fname) && !string.IsNullOrEmpty(lname))
            {
                person = persons.Where(x => x.LastName.ToLower().Trim().Contains(lname.ToLower().Trim())).ToList();
            }
            else
            {
                // person = persons.Where((p) => p.FirstName.ToLower().Trim() == fname.ToLower().Trim() || p.LastName.ToLower().Trim() == lname.ToLower().Trim()).ToList();
                person = persons.ToList();

            }

            if (person == null)
            {
                return NotFound();
            }
            return Json(person);
        }

    }
}
