using SEDC.Practical.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Business.Model
{
    public class DtoMenu
    {
        public DtoMenu()
        {
        }
        public DtoMenu(Menu menu)
        {
            MenuID = menu.MenuID;
            TypeEnum = (MenuType)menu.MenuType;
        }

        public int MenuID { get; set; }

        public MenuType TypeEnum { get; set; }

        public string RestorantName { get; set; }
    }
}
