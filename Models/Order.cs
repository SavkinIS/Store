using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Order
    {
        public Guid ID { get; set; }

        public Guid Customer_ID { get; set; }

        public DateTime ORDER_DATE { get; set; }

        public DateTime SHIPMENT_DATE { get; set; }

        public int ORDER_NUMBER { get; set; }

        public string STATUS { get; set; }
    }
}
