using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public int TableNumber { get; set; }
        public string OrderComment { get; set; }
        public OrderStatus OrderStatus { get; set; } // Moze da se stavi na orderItem

        //Readonly props
        public double TotalPrice { get; set; } // readonly prop
        public int TotalQuantaty { get; set; } // readonly prop
        public DateTime OrderCreated { get; set; } // readonly prop
        // ----

        public virtual List<OrderItem> OrderedItems { get; set; }
    }
}
