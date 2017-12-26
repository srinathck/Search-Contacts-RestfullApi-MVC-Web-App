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
            ICollection<Person> persons = new Person[]
            {
            new Person { ID = 1, FirstName = "Albert", LastName = "Day", Phone = 1299810871 },
            new Person { ID = 2, FirstName = "Brian", LastName = "Kennedy", Phone = 9827254738 },
            new Person { ID = 3, FirstName = "Brandon", LastName = "Stewart", Phone = 5540987373 },
            new Person { ID = 4, FirstName = "Jack", LastName = "Gonzalez", Phone = 8990991234 },
            new Person { ID = 5, FirstName = "Roy", LastName = "Hernandez", Phone = 7178892673 },
            new Person { ID = 6, FirstName = "Robert", LastName = "Kennedy", Phone = 5366781230 },
            new Person { ID = 7, FirstName = "Antonio", LastName = "Thomas", Phone = 6576570909 },
            new Person { ID = 8, FirstName = "Lois", LastName = "Wood", Phone = 5622371890 },
            new Person { ID = 9, FirstName = "Sean", LastName = "Sanders", Phone = 3562711890 },
            new Person { ID = 10, FirstName = "Ryan", LastName = "Robertson", Phone = 8743974444 },
            new Person { ID = 11, FirstName = "Douglas", LastName = "Oliver", Phone = 6453928431 },
            new Person { ID = 12, FirstName = "Anthony", LastName = "Henry", Phone = 6637829093 },
            new Person { ID = 13, FirstName = "Michelle", LastName = "Bailey", Phone = 5578990123 },
            new Person { ID = 14, FirstName = "Harry", LastName = "Thomas", Phone = 8832210910 },
            new Person { ID = 15, FirstName = "Anna", LastName = "Lane", Phone = 7236827290 }
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
