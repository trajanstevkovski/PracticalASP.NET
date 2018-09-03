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
    public class ItemService : BaseService<ItemRepository>, IService<DtoItem>
    {
        public ServiceResult<DtoItem> Load(DtoItem item)
        {
            try
            {
                var result = Repository.Get(item.ItemID);
                return new ServiceResult<DtoItem>()
                {
                    Item = new DtoItem(result),
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoItem>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoItem> LoadAll()
        {
            try
            {
                var result = Repository.GetAll();
                List<DtoItem> list = new List<DtoItem>();
                result.AsParallel().ForAll(i => list.Add(new DtoItem()
                {
                    Availability = i.Availability,
                    CategoryID = i.CategoryID,
                    ItemContent = i.ItemContent,
                    ItemDescription = i.ItemDescription,
                    ItemID = i.ItemID,
                    ItemName = i.ItemName,
                    ItemPrice = i.ItemPrice
                }));
                return new ServiceResult<DtoItem>()
                {
                    Items = list,
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoItem>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoItem> Add(DtoItem item)
        {
            try
            {
                using (var service = new CategoryService())
                {
                    if (!service.LoadAll().Items.Any(m => m.CategoryID == item.CategoryID))
                        return new ServiceResult<DtoItem>
                        {
                            Success = false,
                            ErrorMessage = "Category id does not exist in this context"
                        };
                }
                // Treba da se napravi proverka dali postoi MenuID
                var result = Repository.Create(new Item()
                {
                    CategoryID = item.CategoryID,
                    ItemPrice = item.ItemPrice,
                    ItemName = item.ItemName,
                    ItemDescription = item.ItemDescription,
                    ItemContent = item.ItemContent,
                    Availability = item.Availability
                });
                return new ServiceResult<DtoItem>()
                {
                    Item = new DtoItem(result),
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoItem>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoItem> Edit(DtoItem item)
        {
            try
            {
                using (var service = new CategoryService())
                {
                    if (!service.LoadAll().Items.Any(m => m.CategoryID == item.CategoryID))
                        return new ServiceResult<DtoItem>
                        {
                            Success = false,
                            ErrorMessage = "Category id does not exist in this context"
                        };
                }
                // Treba da se napravi proverka dali postoi MenuID
                Repository.Insert(new Item()
                {
                    CategoryID = item.CategoryID,
                    ItemPrice = item.ItemPrice,
                    ItemName = item.ItemName,
                    ItemDescription = item.ItemDescription,
                    ItemContent = item.ItemContent,
                    Availability = item.Availability,
                    ItemID = item.ItemID
                });
                return new ServiceResult<DtoItem>()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoItem>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }

        public ServiceResult<DtoItem> Remove(DtoItem item)
        {
            try
            {
                Repository.Delete(new Item()
                {
                    CategoryID = item.CategoryID,
                    ItemPrice = item.ItemPrice,
                    ItemName = item.ItemName,
                    ItemDescription = item.ItemDescription,
                    ItemContent = item.ItemContent,
                    Availability = item.Availability,
                    ItemID = item.ItemID
                });
                return new ServiceResult<DtoItem>()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                //Log Exception
                return new ServiceResult<DtoItem>()
                {
                    Success = false,
                    Exception = ex,
                    ErrorMessage = ex.Message
                };
            }
        }
    }
}
