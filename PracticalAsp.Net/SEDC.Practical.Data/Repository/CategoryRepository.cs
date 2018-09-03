using SEDC.Practical.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Repository 
{
    public class CategoryRepository : BaseRepository, IRepository<Category>
    {
        public Category Get(int id)
        {
            return DbContext.Categories.SingleOrDefault(c => c.CategoryID == id);
        }

        public List<Category> GetAll()
        {
            return DbContext.Categories.ToList();
        }

        public Category Create(Category entity)
        {
            DbContext.Categories.Add(entity);
            DbContext.SaveChanges();
            return entity;
        }

        public void Delete(Category entity)
        {
            var dbItem = DbContext.Categories.Single(o => o.CategoryID == entity.CategoryID);
            DbContext.Categories.Remove(dbItem);
            DbContext.SaveChanges();
        }

        public void Insert(Category entity)
        {
            var item = DbContext.Categories.Find(entity.CategoryID);
            item.CategoryName = entity.CategoryName;
            item.MenuID = entity.MenuID;
            DbContext.Entry<Category>(item).State = System.Data.Entity.EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}
