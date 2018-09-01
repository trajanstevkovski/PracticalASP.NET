using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Model
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Required]
        [MaxLength(200)]
        public string ItemName { get; set; }

        [Required]
        [MaxLength(1000)]
        public string ItemDescription { get; set; }

        [MaxLength(2500)]
        public string ItemContent { get; set; }

        [Required]
        public double ItemPrice { get; set; }

        [Required]
        public bool Availability { get; set; }

        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
