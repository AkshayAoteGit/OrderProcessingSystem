using Order.Processing.System.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services.Decorator
{
    public abstract class PaymentProcessAddOnDecorator: PaymentProcessorService
    {
        public PaymentProcessAddOnDecorator(ISlipGenrator slipGenration, INotificationService notificationService) : base(slipGenration, notificationService)
        {

        }
        
    }
}
