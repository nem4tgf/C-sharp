using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp2.Model;

namespace ConsoleApp2.Service
{
    public interface ICustomerServices
    {
        void AddCustomer (Customer customer);
        List<Customer> customers();
        Customer GetCustomerById(int Id);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int Id);

    }
}