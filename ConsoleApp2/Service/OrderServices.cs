using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp2.Model;
using MySql.Data.MySqlClient;

namespace ConsoleApp2.Service
{
    public class OrderServices : IOrderServices
    {
        private MySqlConnection connection;

        public OrderServices(String connectionString){
            connection = new MySqlConnection(connectionString);
        }
        void AddOrder(Order order){
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
        //Tao ra giao dich ms
        MySqlTransaction transaction = connection.BeginTransaction();
        //thuc hien code la them don hang ms
        ///...
        cmd.CommandText="Insert into orders(customer_idm order_date) values (@customerId, @OrderDate)";
        cmd.Parameters.AddWithValue("@CustomerId",order.CustomerId);
        cmd.Parameters.AddWithValue("@OrderDate",order.OrderDate);
        cmd.ExecuteNonQuery();

        int orderId = (int)cmd.LastInsertedId; //Lay ra id moi nhat vua dc add o tren
        foreach(var detail in order.OrderDetails){
            cmd.CommandText = "Insert into order_detail(order_id, product_id,quantity) values (@OrderId, ProducIdt, @Quantity)";
            cmd.Parameters.AddWithValue("@Order_Id",orderId);
            cmd.Parameters.AddWithValue("@ProductId",detail.ProductId);
            cmd.Parameters.AddWithValue("@Quantity",detail.Quantity);
            cmd.ExecuteNonQuery();
        }

        //Ket thuc giao dich
        transaction.Commit();
        connection.Close();
        }
        List<Order> GetAllOrder(){
            return null;
        }
        Order GetOrderById(int Id){
            return null;
        }
    }
}