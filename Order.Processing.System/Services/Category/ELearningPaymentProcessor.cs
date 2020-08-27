using Order.Processing.System.Interfaces.Service;
using Order.Processing.System.Models;
using Order.Processing.System.Models.Builders;
using Order.Processing.System.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services.Category
{
    public class ELearningPaymentProcessor : PaymentProcessorService
    {

        public ELearningPaymentProcessor(ISlipGenration slipGenration, INotificationService notificationService) : base(slipGenration, notificationService)
        {

        }

        public override void ProcessOrder(OrderDetail details)
        {
            GenerateSlip(details);
        }
    }
}
