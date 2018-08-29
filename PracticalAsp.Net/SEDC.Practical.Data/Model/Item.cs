using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Model
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public bool Availability { get; set; }
        public double ItemPrice { get; set; }
        public string ItemDescription { get; set; }
        public string ItemContent { get; set; }

        public int CategoryID { get; set; }
        public int OrderItemID { get; set; }

        public virtual OrderItem OrderItem { get; set; }
        public virtual Category Category { get; set; }
    }
}
