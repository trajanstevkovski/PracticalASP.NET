using SEDC.Practical.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Business.Model
{
    public class DtoItem
    {
        public DtoItem()
        {
        }

        public DtoItem(Item item)
        {
            ItemID = item.ItemID;
            ItemName = item.ItemName;
            ItemContent = item.ItemContent;
            ItemDescription = item.ItemDescription;
            ItemPrice = item.ItemPrice;
            Availability = item.Availability;
            CategoryID = item.CategoryID;
        }

        public int ItemID { get; set; }
        
        public string ItemName { get; set; }

        public string ItemDescription { get; set; }

        public string ItemContent { get; set; }

        public double ItemPrice { get; set; }

        public bool Availability { get; set; }

        public int CategoryID { get; set; }
    }
}
