using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEDC.Practical.Business.Model;
using SEDC.Practical.Business.Service;

namespace SEDC.Practical.WebApp.Tests.Services
{
    [TestClass]
    public class MenuServiceTests
    {
        [TestMethod]
        public void AddMenu_ValidInput_ExpectTwoItems()
        {
            //Act
            DtoMenu menu1 = new DtoMenu()
            {
                TypeEnum = MenuType.Meals,
                RestorantName = "Seavus Restorant"
            };

            DtoMenu menu2 = new DtoMenu()
            {
                TypeEnum = MenuType.Drinks,
                RestorantName = "Seavus Restorant"
            };

            //Arrange

            var service = new MenuService();
            var result1 = service.Add(menu1);
            var result2 = service.Add(menu2);
            var resultMenus = service.LoadAll();

            //Assert

            Assert.IsNotNull(result1);
            Assert.IsTrue(result1.Success);

            Assert.IsNotNull(result2);
            Assert.IsTrue(result2.Success);

            Assert.IsNotNull(resultMenus);
            Assert.IsTrue(resultMenus.Success);
            Assert.AreEqual(2, resultMenus.Items.Count);
        }
    }
}
