using Order.Processing.System.Interfaces.Service;
using Order.Processing.System.Models;
using Order.Processing.System.Models.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services
{
    public abstract class PaymentProcessorService : IPayementPrcocessorSercvice
    {
        public void GenerateSlip(OrderDetail details)
        {
            Console.WriteLine("----------SLIP DETAIL-------------------");
            Console.WriteLine("Slip Id :" + details.Id);
            Console.WriteLine("Product Category :"+details.ProductCategory);
            Console.WriteLine("Holder Name:" + details.SlipHolderName);
            Console.WriteLine("Type :" + details.Type);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("------------AIDS-------------------------");
            if (!string.IsNullOrEmpty(details.Type))
            {
                Console.WriteLine("Aids Provided:" + details.Aid);
            }
            
        }

        public virtual void ProcessOrder(OrderDetail details)
        {
            
        }

        public void SendMail()
        {
            Console.WriteLine("Email Send");
        }
        

    }
}
