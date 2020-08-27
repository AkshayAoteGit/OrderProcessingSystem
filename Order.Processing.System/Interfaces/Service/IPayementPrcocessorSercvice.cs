using Order.Processing.System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Interfaces.Service
{
    public interface IPayementPrcocessorSercvice
    {
        void ProcessOrder(OrderDetail details);
    }
}
