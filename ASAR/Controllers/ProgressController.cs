namespace ASAR
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web.Http;

    public class ProgressController : ApiController
    {
        Progress[] products = new Progress[]  
        {  
            new Progress { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },  
            new Progress { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },  
            new Progress { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }  
        };

        public IEnumerable<Progress> GetAllProducts()
        {
            return products;
        }

        public Progress GetProductById(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }

        public IEnumerable<Progress> GetProductsByCategory(string category)
        {
            return products.Where(p => string.Equals(p.Category, category,
                    StringComparison.OrdinalIgnoreCase));
        }
    }
}