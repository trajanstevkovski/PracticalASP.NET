using SEDC.Practical.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data
{
    public class RestorantContext : DbContext
    {
        public RestorantContext()
            :base("name=RestorantConnection")
        {

        }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderedItems { get; set; }
    }
}
