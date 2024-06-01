﻿using System;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient;

namespace ProjectManagement{
    class Program{
        static string connectionString ="Server=127.0.0.1;Database=prodb;User Id=root;Password=;";
        public static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Product Management");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Display all products");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();

                switch(choice){
                    case "1": AddProduct();
                        break;
                    case "2": DisplayAllProduct();
                        break;
                    case "3": return;
                    default:
                        Console.WriteLine("Invalid choice, pls try again");
                        break;
                }
            }
        }
        static void AddProduct(){
            Product product = new Product();
            Console.WriteLine("Enter product name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter product price: ");
            product.Price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter description: ");
            product.Description = Console.ReadLine();

            using(MySqlConnection db = new MySqlConnection(connectionString)){
                db.Open();
                string sqlQuery= "insert into products(name,price,description) values(@Name, @Price,@Description)";
                using(MySqlCommand cmd = new MySqlCommand(sqlQuery,db)){
                    cmd.Parameters.AddWithValue("@Name",product.Name);
                    cmd.Parameters.AddWithValue("@Price",product.Price);
                    cmd.Parameters.AddWithValue("@Description",product.Description);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Product added successfully!");
                }
            }
        }
        static void DisplayAllProduct(){
            using(MySqlConnection db = new MySqlConnection(connectionString)){
                db.Open();
                string sqlQuery = "select * from products";
                using(MySqlCommand cmd = new MySqlCommand(sqlQuery,db)){
                    using(MySqlDataReader reader = cmd.ExecuteReader()){
                        while(reader.Read()){
                            Console.WriteLine($"ID: {reader["Id"]},Name:{reader["Name"]},Price:{reader["price"]},Desc:{reader["description"]}");
                        }
                    }
                }
            }
        }
    }
    public class Product{
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

}