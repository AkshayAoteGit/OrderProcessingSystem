using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services.Category
{
    public class ELearningPaymentProcessor : PaymentProcessorService
    {
        protected override void ProcessOrder()
        {
            GenerateSlip();
        }
    }
}
