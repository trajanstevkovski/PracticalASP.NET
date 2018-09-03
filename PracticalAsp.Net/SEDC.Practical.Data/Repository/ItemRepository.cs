using SEDC.Practical.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Repository
{
    public class ItemRepository : BaseRepository, IRepository<Item>
    {
        public Item Get(int id)
        {
            return DbContext.Items.SingleOrDefault(i => i.ItemID == id);
        }

        public List<Item> GetAll()
        {
            return DbContext.Items.ToList();
        }

        public Item Create(Item entity)
        {
            DbContext.Items.Add(entity);
            DbContext.SaveChanges();
            return entity;
        }

        public void Delete(Item entity)
        {
            var dbItem = DbContext.Items.Single(i => i.ItemID == entity.ItemID);
            DbContext.Items.Remove(dbItem);
            DbContext.SaveChanges();
        }

        public void Insert(Item entity)
        {
            var item = DbContext.Items.Find(entity.ItemID);
            item.ItemContent = entity.ItemContent;
            item.ItemDescription = entity.ItemDescription;
            item.ItemName = entity.ItemName;
            item.ItemPrice = entity.ItemPrice;
            item.CategoryID = entity.CategoryID;
            item.Availability = entity.Availability;
            DbContext.Entry<Item>(item).State = System.Data.Entity.EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}
