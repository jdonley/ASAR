namespace ASAR
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web.Http;

    public class ProductsController : ApiController
    {
        Products[] products = new Products[]  
        {  
            new Products { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },  
            new Products { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },  
            new Products { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }  
        };

        public IEnumerable<Products> GetAllProducts()
        {
            return products;
        }

        public Products GetProductById(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }

        public IEnumerable<Products> GetProductsByCategory(string category)
        {
            return products.Where(p => string.Equals(p.Category, category,
                    StringComparison.OrdinalIgnoreCase));
        }
    }
}