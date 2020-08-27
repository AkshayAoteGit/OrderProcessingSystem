using Order.Processing.System.Models;
using Order.Processing.System.Models.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services.Decorator.AddOnServices
{
    public class ELearningDecorator: PaymentProcessAddOnDecorator
    {

        public override void ProcessOrder(OrderDetail details)
        {
            GenerateSlip(details);
            Console.WriteLine("With Aid");
        }

    }
}
