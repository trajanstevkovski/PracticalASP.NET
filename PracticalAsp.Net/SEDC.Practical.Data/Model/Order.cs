using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Model
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        [MaxLength(3)]
        public string Table { get; set; }

        [Required]
        public byte StatusID { get; set; }

        [Required]
        public DateTime WhenCreated { get; set; }

        public string OrderComment { get; set; }

        //Readonly props
        public double? TotalCost { get { return OrderedItems?.Sum(o => o.Quantity * o.Item.ItemPrice); } }
        public int? TotalQuantity { get { return OrderedItems?.Sum(o => o.Quantity); } }
        // ----

        public List<OrderItem> OrderedItems { get; set; }
    }
}
