using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services.Decorator.AddOnServices
{
    public class PhysicalProductDecorator: PaymentProcessAddOnDecorator
    {
        public PhysicalProductDecorator(PaymentProcessorService paymentProcessorService):base(paymentProcessorService)
        {}

        protected override void ProcessPayment()
        {
            _paymentProcessorService.GenerateSlip();
            Console.WriteLine("Generate Physical Slip With Add on");
        }
    }
}
