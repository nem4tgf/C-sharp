using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp2.Model;
using MySql.Data.MySqlClient;

namespace ConsoleApp2.Service
{
    public class ProductServices : IProductServices
    {
        private MySqlConnection connection;
        public ProductServices(string connectionString){
            connection = new MySqlConnection(connectionString);
        }
        public void AddProduct(Product product){
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Insert into Products(name,price,description) values(@Name,@Price, @Description)";
            cmd.Parameters.AddWithValue("@Name",product.Name);
            cmd.Parameters.AddWithValue("@Price",product.Price);
            cmd.Parameters.AddWithValue("@Description",product.Description);
            cmd.ExecuteNonQuery();
            connection.Close();
            
        }

        public List<Product> GetAllProducts(){
            return null;
        }

        public Product GetProductById(int Id){
            return null;
        }

        public void UpdateProduct(Product product){
            
        }

        public void DeleteProduct(int Id){
            
        }
    }
}