using Order.Processing.System.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Services
{
    public class NotificationService : INotificationService
    {
        public bool Sendmail()
        {
            Console.WriteLine("User notified with email");
            return true;
        }
    }
}
