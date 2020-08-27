using Order.Processing.System.Models;
using Order.Processing.System.Models.Builders;
using Order.Processing.System.Services;
using System;

namespace Order.Processing.System
{
    class Program
    {
        static void Main(string[] args)
        {

            var processOrder = new OrderProcessingService();
            processOrder.ProcessPayment();
            Console.ReadKey();


        }
     
    }
}
