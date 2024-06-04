using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp2.Model;

namespace ConsoleApp2.Service
{
    public interface IProductServices
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
        Product GetProductById(int Id);
        void UpdateProduct(Product product);
        void DeleteProduct (int Id);
    }
}