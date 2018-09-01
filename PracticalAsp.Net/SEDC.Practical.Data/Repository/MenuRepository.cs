using SEDC.Practical.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Repository
{
    public class MenuRepository : BaseRepository, IRepository<Menu>
    {
        public Menu Get(int id)
        {
            return DbContext.Menus.SingleOrDefault(m => m.MenuID == id);
        }

        public List<Menu> GetAll()
        {
            return DbContext.Menus.ToList();
        }

        public Menu Create(Menu entity)
        {
            DbContext.Menus.Add(entity);
            DbContext.SaveChanges();
            return entity;
        }

        public void Delete(Menu entity)
        {
            var dbItem = DbContext.Menus.Single(m => m.MenuID == entity.MenuID);
            DbContext.Menus.Remove(dbItem);
            DbContext.SaveChanges();
        }

        public void Insert(Menu entity)
        {
            var item = DbContext.Menus.Find(entity.MenuID);
            item.MenuType = entity.MenuType;
            item.RestorantName = entity.RestorantName;
            DbContext.Entry<Menu>(item).State = System.Data.Entity.EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}
