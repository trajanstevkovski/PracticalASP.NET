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
        //public OrderStatus OrderStatus { get; set; } // Moze da se stavi na orderItem

        //Readonly props
        public double TotalPrice { get { return OrderedItems.Sum(o => o.Quantaty * o.Item.ItemPrice); } } // readonly prop
        public int TotalQuantaty { get { return OrderedItems.Count; } } // readonly prop
        public DateTime OrderCreated { get { return DateTime.UtcNow; } } // readonly prop
        // ----

        public virtual List<OrderItem> OrderedItems { get; set; }
    }
}
