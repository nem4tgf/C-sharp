using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp2.Model;

namespace ConsoleApp2.Service
{
    public interface IOrderServices
    {
        void AddOrder(Order order);
        List<Order> GetAllOrder();
        Order GetOrderById(int Id);
    }
}