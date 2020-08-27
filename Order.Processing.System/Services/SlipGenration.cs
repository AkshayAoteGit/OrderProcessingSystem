using Order.Processing.System.Interfaces.Service;
using Order.Processing.System.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services
{
    public class SlipGenration : ISlipGenration
    {
        
        public OrderDetail GenerateSlip(OrderDetail details)
        {
            Console.WriteLine("----------SLIP DETAIL-------------------");
            Console.WriteLine("Slip Id :" + details.Id);
            Console.WriteLine("Product Category :" + details.ProductCategory);
            Console.WriteLine("Holder Name:" + details.SlipHolderName);
            Console.WriteLine("Type :" + details.Type);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            if (!string.IsNullOrEmpty(details.Aid))
            {
                Console.WriteLine("------------AIDS-------------------------");
                Console.WriteLine("Aids Provided:" + details.Aid);
            }
            //Anything can be done with this object i.e processing
            return details;
        }
    }
}
