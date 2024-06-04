using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using ConsoleApp2.Model;
using MySql.Data.MySqlClient;

namespace ConsoleApp2.Service
{
    public class CustomerServices : ICustomerServices
    {
        private MySqlConnection connection;
        public CustomerServices(string connectionString){
            
        }

        void AddCustomer (Customer customer){}
        List<Customer> customers(){
            return null;
        }
        Customer GetCustomerById(int Id){
            return null;
        }
        void UpdateCustomer(Customer customer){}
        void DeleteCustomer(int Id){}
    }
}