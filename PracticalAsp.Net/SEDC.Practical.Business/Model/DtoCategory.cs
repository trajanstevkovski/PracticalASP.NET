using SEDC.Practical.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Business.Model
{
    public class DtoCategory
    {
        public DtoCategory()
        {
        }
        public DtoCategory(Category category)
        {
            CategoryID = category.CategoryID;
            MenuID = category.MenuID;
        }

        public int CategoryID { get; set; }
        public int MenuID { get; set; }
        public string CategoryName { get; set; }
    }
}
