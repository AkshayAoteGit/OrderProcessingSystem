using Order.Processing.System.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services
{
    public abstract class PaymentProcessorService : IPayementPrcocessorSercvice
    {
        protected abstract void ProcessOrder();
        public void GenerateSlip()
        {
            Console.WriteLine("Basic Slip Generated");
        }
        public void SendMail()
        {
            Console.WriteLine("Email Send");
        }
        

    }
}
