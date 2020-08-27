using Order.Processing.System.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Models
{
    public class RequestOrder
    {
        public AccountProductCategory AccountProductCategory { get; set; }
        public string Type { get; set; }
    }
}
