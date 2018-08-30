using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Model
{
    public class OrderItem
    {
        public int ItemID { get; set; }
        public int OrderID { get; set; }
        public OrderStatus ItemStatus { get; set; } // Moze da se promeni
        public int Quantaty { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
