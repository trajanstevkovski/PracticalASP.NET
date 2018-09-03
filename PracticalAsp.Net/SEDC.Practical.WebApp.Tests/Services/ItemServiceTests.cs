using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEDC.Practical.Business.Model;
using SEDC.Practical.Business.Service;

namespace SEDC.Practical.WebApp.Tests.Services
{
    [TestClass]
    public class ItemServiceTests
    {
        [TestMethod]
        public void AddItem_ValidInput_ExpectTwoItems()
        {
            var item1 = new DtoItem()
            {
                Availability = true,
                CategoryID = 3,
                ItemContent = "Something awesome",
                ItemDescription = "Yummy",
                ItemName = "Food",
                ItemPrice = 200
            };
            var item2 = new DtoItem()
            {
                Availability = true,
                CategoryID = 2,
                ItemContent = "Something awesome",
                ItemDescription = "Yummy",
                ItemName = "Drink",
                ItemPrice = 100
            };
            var item3 = new DtoItem()
            {
                Availability = true,
                CategoryID = 5,
                ItemContent = "Something awesome",
                ItemDescription = "Yummy",
                ItemName = "NjamNjam",
                ItemPrice = 200
            };

            var service = new ItemService();
            var result1 = service.Add(item1);
            var result2 = service.Add(item2);
            var result3 = service.Add(item3);
            var resultCategories = service.LoadAll();

            Assert.IsNotNull(result1);
            Assert.IsTrue(result1.Success);

            Assert.IsNotNull(result2);
            Assert.IsTrue(result2.Success);

            Assert.IsNotNull(result3);
            Assert.IsFalse(result3.Success);

            Assert.IsNotNull(resultCategories);
            Assert.IsTrue(resultCategories.Success);
        }
    }
}
