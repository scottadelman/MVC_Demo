using MVC_Demo.Models;
using Testing.Models;
using System;

namespace MVC_Demo
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        public Product GetProduct(int id);

        public void UpdateProduct(Product product);
        public Product AssignCategory();
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
       
    }
}
 