using SEDC.Practical.Business.Model;
using SEDC.Practical.Data.Model;
using SEDC.Practical.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Practical.Business.Service
{
    public class MenuService : BaseService<MenuRepository>, IService<DtoMenu>
    {
        public ServiceResult<DtoMenu> Load(DtoMenu item)
        {
            try
            {
                var result = Repository.Get(item.MenuID);
                return new ServiceResult<DtoMenu>()
                {
                    Item = new DtoMenu(result),
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoMenu>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoMenu> LoadAll()
        {
            try
            {
                var result = Repository.GetAll().ToList();
                List<DtoMenu> resultList = new List<DtoMenu>();
                result.ForEach(m => resultList.Add(new DtoMenu(m)));
                return new ServiceResult<DtoMenu>()
                {
                    Items = new List<DtoMenu>(resultList),
                    Success = true
                };
            }
            catch(Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoMenu>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoMenu> Add(DtoMenu item)
        {
            try
            {
                var result = Repository.Create(new Menu()
                {
                    MenuType = (byte)item.TypeEnum,
                    RestorantName = item.RestorantName
                });
                return new ServiceResult<DtoMenu>()
                {
                    Item = new DtoMenu(result),
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoMenu>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoMenu> Edit(DtoMenu item)
        {
            try
            {
                Repository.Insert(new Menu()
                {
                    MenuID = item.MenuID,
                    MenuType = (byte)item.TypeEnum,
                    RestorantName = item.RestorantName
                });
                return new ServiceResult<DtoMenu>()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoMenu>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoMenu> Remove(DtoMenu item)
        {
            try
            {
                Repository.Delete(new Menu()
                {
                    MenuID = item.MenuID,
                    MenuType = (byte)item.TypeEnum,
                    RestorantName = item.RestorantName
                });
                return new ServiceResult<DtoMenu>()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoMenu>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }
    }
}
