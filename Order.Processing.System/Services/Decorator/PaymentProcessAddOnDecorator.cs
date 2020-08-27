using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services.Decorator
{
    public abstract class PaymentProcessAddOnDecorator
    {
        protected readonly PaymentProcessorService _paymentProcessorService;
        protected abstract void ProcessPayment();
        public PaymentProcessAddOnDecorator(PaymentProcessorService paymentProcessorService)
        {
            _paymentProcessorService = paymentProcessorService;
        }
    }
}
