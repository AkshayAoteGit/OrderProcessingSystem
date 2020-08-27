using Order.Processing.System.Interfaces.Service;
using Order.Processing.System.Models;
using Order.Processing.System.Models.Builders;
using Order.Processing.System.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services
{
    public abstract class PaymentProcessorService : IPayementPrcocessorSercvice
    {
        private readonly ISlipGenrator _slipGenration;
        private readonly INotificationService _notificationService;
        public PaymentProcessorService(ISlipGenrator slipGenration, INotificationService notificationService)
        {
            _slipGenration = slipGenration;
            _notificationService = notificationService;
        }
        public void GenerateSlip(OrderDetail details)
        {
            _slipGenration.GenerateSlip(details);  
        }

        public virtual void ProcessOrder(OrderDetail details)
        {
            
        }

        public void SendMail()
        {
            _notificationService.Sendmail();
            

        }
        

    }
}
