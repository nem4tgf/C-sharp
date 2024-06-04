using System;
using System.Net.Http.Headers;
using ConsoleApp2.Controler;
using ConsoleApp2.Service;
using MySql.Data.MySqlClient;
using ConsoleApp2.Model;
namespace ProjectManagement{
    class Program{
        static string connectionString ="Server=127.0.0.1;Database=prodb;User Id=root;Password=;";
        public static void Main(string[] args)
        {
            IProductServices productServices = new ProductServices(connectionString);
            ProductController productController = new ProductController(productServices);
            while(true){
                Console.WriteLine("Product Management");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Display all products");
                Console.WriteLine("3. Find Product By Id");
                Console.WriteLine("4. Edit Product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();

                switch(choice){
                    case "1": 
                        Console.WriteLine("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter product price: ");
                        decimal price = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter Description: ");
                        string description = Console.ReadLine();
                        Product newProduct = new Product{Name = name, Price = price, Description = description};
                        productController.AddProduct(newProduct);
                        Console.WriteLine("Product added Successfully");
                        break;
                    case "2": 
                        break;
                    case "3": return;
                    default:
                        Console.WriteLine("Invalid choice, pls try again");
                        break;
                }
            }
        }

    }
}