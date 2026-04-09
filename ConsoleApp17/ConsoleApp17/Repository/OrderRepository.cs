using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp17.Class;

namespace ConsoleApp17.Repository

{
    public class OrderRepository : IOrderRepository
    {
        List<Order> orders = new List<Order>();
        public void CreateOrder(Order order)
        {
            order.Id = orders.Count;
            orders.Add(order);
        }

        public void GetAllOrders()
        {
            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Id}:{item.ProductName}:{item.ProductPrice}");
            }
        }
    }
}
