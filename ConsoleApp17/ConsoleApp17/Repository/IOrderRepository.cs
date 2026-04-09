using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp17.Class;

namespace ConsoleApp17.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        void GetAllOrders();
    }
}
