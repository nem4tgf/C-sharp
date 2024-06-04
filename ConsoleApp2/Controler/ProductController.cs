using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp2.Model;
using ConsoleApp2.Service;

namespace ConsoleApp2.Controler
{
    public class ProductController
    {
        //Instante of model
        private IProductServices productService;
        public ProductController(IProductServices proService){
            productService = proService;
        }

        public void AddProduct(Product product){
            productService.AddProduct(product);
        }

        
    }
}