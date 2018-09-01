using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Model
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }

        [Required]
        [MaxLength(200)]
        public string RestorantName { get; set; }

        [Required]
        public byte MenuType { get; set; }

        public List<Category> Categories { get; set; }
    }
}
