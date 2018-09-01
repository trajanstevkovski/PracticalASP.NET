using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Model
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        [Required]
        public short Quantity { get; set; }

        public int ItemID { get; set; }
        public Item Item { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }
        

        
    }
}
