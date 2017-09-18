using husnuWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace husnuWebApi.Controllers
{
    public class ProductController : ApiController
    {
        public static List<Product> products;

        public ProductController()
        {
            products = new List<Product>();
            
            Product product1 = new Product();
            product1.id = 1;
            product1.Name = "Apple";
            product1.category = "Food";

            products.Add(product1);


            Product product2 = new Product();
            product2.id = 2;
            product2.Name = "Rice";
            product2.category = "Grocery";

            products.Add(product2);
        }
        // GET: api/Product
        public IEnumerable<Product> Get()
        { 
            return products;

        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            return products.Where(x => x.id == id).FirstOrDefault();
        }

        // POST: api/Product
        public List<Product> Post(Product product)
        {
            try
            {
                products.Add(product);
                return products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/Product/5
        public List<Product> Put(int id, [FromBody]string Name)
        {
            Product productToBeUpdated=products.Where(x => x.id == id).FirstOrDefault();
            productToBeUpdated.Name = Name;
            return products;
        }

        // DELETE: api/Product/5
        public List<Product> Delete(int id)
        {
            Product productToBeDeleted=products.Where(x => x.id==id).FirstOrDefault();
            products.Remove(productToBeDeleted);
            return products;
        }
    }
}
