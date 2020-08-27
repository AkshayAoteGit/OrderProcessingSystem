using Order.Processing.System.Models;
using Order.Processing.System.Models.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services.Decorator.AddOnServices
{
    public class PhysicalProductDecorator : PaymentProcessAddOnDecorator
    {
        
        public override void ProcessOrder(OrderDetail details)
        {
            GenerateSlip(details);
            Console.WriteLine("Generate Physical Slip With Add on");
        }
    }
}
