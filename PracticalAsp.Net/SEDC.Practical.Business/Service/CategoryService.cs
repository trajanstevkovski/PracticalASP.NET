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
    public class CategoryService : BaseService<CategoryRepository>, IService<DtoCategory>
    {
        public ServiceResult<DtoCategory> Load(DtoCategory item)
        {
            try
            {
                var result = Repository.Get(item.CategoryID);
                return new ServiceResult<DtoCategory>()
                {
                    Item = new DtoCategory(result),
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoCategory>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoCategory> LoadAll()
        {
            try
            {
                var result = Repository.GetAll();
                List<DtoCategory> list = new List<DtoCategory>();
                result.ForEach(c => list.Add(new DtoCategory()
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    MenuID = c.MenuID
                }));
                return new ServiceResult<DtoCategory>()
                {
                    Items = list,
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoCategory>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoCategory> Add(DtoCategory item)
        {
            try
            {
                var result = Repository.Create(new Category()
                {
                    CategoryName = item.CategoryName,
                    MenuID = item.MenuID
                });
                return new ServiceResult<DtoCategory>()
                {
                    Item = new DtoCategory(result),
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoCategory>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoCategory> Edit(DtoCategory item)
        {
            try
            {
                Repository.Insert(new Category()
                {
                    CategoryID = item.CategoryID,
                    CategoryName = item.CategoryName,
                    MenuID = item.MenuID
                });
                return new ServiceResult<DtoCategory>()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoCategory>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoCategory> Remove(DtoCategory item)
        {
            try
            {
                Repository.Delete(new Category()
                {
                    CategoryID = item.CategoryID,
                    CategoryName = item.CategoryName,
                    MenuID = item.MenuID
                });
                return new ServiceResult<DtoCategory>()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoCategory>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }
    }
}
