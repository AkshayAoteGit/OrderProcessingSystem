using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services.Decorator.AddOnServices
{
    public class ELearningDecorator: PaymentProcessAddOnDecorator
    {
        public ELearningDecorator(PaymentProcessorService paymentProcessorService) : base(paymentProcessorService)
        { }

        protected override void ProcessPayment()
        {
            _paymentProcessorService.GenerateSlip();
            Console.WriteLine("Added Free Aid to slip");
        }
    }
}
