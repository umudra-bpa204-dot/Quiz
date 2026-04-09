using System;
using ConsoleApp17.Class;
using ConsoleApp17.Repository;
using ConsoleApp17.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviscollection = new ServiceCollection();
            serviscollection.AddScoped<IOrderRepository, OrderRepository>();
            serviscollection.AddScoped<PaymentService>();
            var ordercollection = serviscollection.BuildServiceProvider();
            var order=ordercollection.GetService<PaymentService>();
            order.MakeOrder("Et", 200);
            order.MakeOrder("Toyuq", 190);
            order.ShowAllOrders();
            
            
         

        }
    }
}
