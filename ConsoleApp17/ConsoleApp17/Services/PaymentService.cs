using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp17.Services;
using ConsoleApp17.Repository;
using ConsoleApp17.Class;

namespace ConsoleApp17.Services
{
    public class PaymentService
    {
        private IOrderRepository _orderRepository;
       

        public PaymentService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        
        }
     
        
        
        public void MakeOrder(string productName,double productPrice)
        {
            Order order = new Order {ProductName=productName,ProductPrice=productPrice };
           
            _orderRepository.CreateOrder(order);
        }
        public void ShowAllOrders()
        {
            _orderRepository.GetAllOrders();
        }
    }
}
