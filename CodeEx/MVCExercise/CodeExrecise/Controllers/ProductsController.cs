using CodeExrecise.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CodeExrecise.Controllers
{
    public class ProductsController : ApiController
    {
        ICollection<Product> product = new Product[]
        {
            new Product { Id = 1, Firstname = "Tomato Soup", Lastname = "Groceries", Price = 1 },
            new Product { Id = 2, Firstname = "Yo-yo", Lastname = "Toys", Price = 3.75M },
            new Product { Id = 3, Firstname = "Hammer", Lastname = "Hardware", Price = 16.99M },
            new Product { Id = 4, Firstname = "Kokl", Lastname = "Groceries", Price = 33.75M },
            new Product { Id = 5, Firstname = "vvo", Lastname = "Hardware", Price = 53.75M },
            new Product { Id = 6, Firstname = "bbgbmk", Lastname = "Toys", Price = 23.75M },
            new Product { Id = 7, Firstname = "efrv", Lastname = "Groceries", Price = 223.75M },
            new Product { Id = 8, Firstname = "Ypoiehfje", Lastname = "Toys", Price = 453.75M },
            new Product { Id = 9, Firstname = "Yoedyo", Lastname = "Toys", Price = 53.75M },
            new Product { Id = 10, Firstname = "lskjj", Lastname = "Groceries", Price = 63.75M },
            new Product { Id = 11, Firstname = "deedeyo", Lastname = "Hardware", Price = 36.75M },
            new Product { Id = 12, Firstname = "Yeffv", Lastname = "Hardware", Price = 31.75M },
            new Product { Id = 13, Firstname = "wed", Lastname = "Toys", Price = 366.75M },
            new Product { Id = 14, Firstname = "ccdcd", Lastname = "Groceries", Price = 34.75M },
            new Product { Id = 15, Firstname = "eefrf", Lastname = "Hardware", Price = 3444.75M }
        };
        //public IEnumerable<Product> GetAllProducts()
        //{
        //    return product;
        //}

        [HttpGet]
        public IHttpActionResult GetProduct(string fname = "", string lname = "")
        {
            List<Product> product1 = new List<Product>();

            if (!string.IsNullOrEmpty(fname) && !string.IsNullOrEmpty(lname))
            {
                product1 = product.Where(x => x.Firstname.ToLower().Trim() == fname.ToLower().Trim() && x.Lastname.ToLower().Trim() == lname.ToLower().Trim()).ToList();
            }
            else if (!string.IsNullOrEmpty(fname) && string.IsNullOrEmpty(lname))
            {
                product1 = product.Where(x => x.Firstname.ToLower().Trim() == fname.ToLower().Trim()).ToList();
            }

            else if (string.IsNullOrEmpty(fname) && !string.IsNullOrEmpty(lname))
            {
                product1 = product.Where(x => x.Lastname.ToLower().Trim() == lname.ToLower().Trim()).ToList();
            }
            else
            {
                // product = products.Where((p) => p.FirstName.ToLower().Trim() == fname.ToLower().Trim() || p.LastName.ToLower().Trim() == lname.ToLower().Trim()).ToList();
                product1= product.ToList();

            }

            if (product1 == null)
            {
                return NotFound();
            }
            return Ok(product1);
        }
    }
}
