using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEDC.Practical.Business.Model;
using SEDC.Practical.Business.Service;

namespace SEDC.Practical.WebApp.Tests.Services
{
    [TestClass]
    public class CategoryServiceTests
    {
        [TestMethod]
        public void AddCategory_ValidInput_ExpectTwoItems()
        {
            DtoCategory category1 = new DtoCategory()
            {
                CategoryName = "Food",
                MenuID = 1
            };
            DtoCategory category2 = new DtoCategory()
            {
                CategoryName = "Drink",
                MenuID = 2
            };
            DtoCategory category3 = new DtoCategory()
            {
                CategoryName = "Wines",
                MenuID = 10
            };

            var service = new CategoryService();
            var result1 = service.Add(category1);
            var result2 = service.Add(category2);
            var result3 = service.Add(category3);
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
