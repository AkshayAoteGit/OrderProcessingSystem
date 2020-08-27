using Order.Processing.System.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Interfaces.Service
{
    public interface ISlipGenration
    {
        OrderDetail GenerateSlip(OrderDetail orderDetail);
    }
}
