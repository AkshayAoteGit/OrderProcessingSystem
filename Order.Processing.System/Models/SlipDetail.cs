using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Processing.System.Models
{
    public class SlipDetail
    {
        public int Id { get; set; }
        public string SlipHolderName { get; set; }
        public string ProductCategory{ get; set; }
        public string Type { get; set; }
        public string Aid { get; set; }
    }
}
