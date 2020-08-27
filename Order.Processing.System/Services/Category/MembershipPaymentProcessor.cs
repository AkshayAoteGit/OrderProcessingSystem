﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services.Category
{
    public class MembershipPaymentProcessor : PaymentProcessorService
    {
        protected override void ProcessOrder()
        {
            GenerateSlip();
            SendMail();
        }
    }
}
