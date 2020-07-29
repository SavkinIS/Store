using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class OrderItem
    {
        public Guid ID { get; set; }

        public Guid ORDER_ID { get; set; }

        public Guid ITEM_ID { get; set; }
        public long ITEMS_COUNT { get; set; }

        public int ITEM_PRICE { get; set; }
    }
}
