using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Data.Repository
{
    public class BaseRepository : IDisposable
    {
        private RestorantContext _dbContext;

        public RestorantContext DbContext => _dbContext;

        public BaseRepository()
        {
            _dbContext = new RestorantContext();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
