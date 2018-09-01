using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        T Create(T entity);
        void Insert(T entity);
        void Delete(T entity);

        List<T> GetAll();
        T Get(int id);
    }
}
