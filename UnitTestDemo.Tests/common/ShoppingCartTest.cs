using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.common;
using UnitTestDemo.Models;

namespace UnitTestDemo.Tests.common
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestInitialize]
        public void Init()
        {
            Assert.IsTrue(true);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ItemCount_Test()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddItems(new Item { ItemType = ItemType.Car }, 10);
            Assert.AreEqual(10, shoppingCart.TotalItemsCount);

            shoppingCart.AddItems(new Item { ItemType = ItemType.Computer }, 10);
            Assert.AreEqual(20, shoppingCart.TotalItemsCount);

            shoppingCart.AddItems(new Item { ItemType = ItemType.HomeAppliances }, 10);
            Assert.AreEqual(30, shoppingCart.TotalItemsCount);

            shoppingCart.AddItems(new Item { ItemType = ItemType.OfficeSupplies }, 10);
            Assert.AreEqual(40, shoppingCart.TotalItemsCount);
        }

        /// <summary>
        /// 如果参数Quantity是等于1的整数，那么执行AddItems之后，ItemCount应该等于1.
        /// </summary>
        [TestMethod]
        public void AddItems_Test_With_Correct_Quantity()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddItems(new Item(), 1);
            Assert.AreEqual(1, shoppingCart.TotalItemsCount);
        }

        /// <summary>
        /// 如果参数Quantity是大于1的整数，那么执行AddItems之后，ItemCount应该等于参数值.
        /// </summary>
        [TestMethod]
        public void AddItems_Test_With_Quantity_Larger_Than_One()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddItems(new Item(), 10);
            Assert.AreEqual(10, shoppingCart.TotalItemsCount);
        }

        /// <summary>
        /// 如果参数Quantity是0，则抛出ArgumentException异常.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddItems_Test_With_Quantity_Zero()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddItems(new Item(), 0);
        }

        /// <summary>
        /// 如果参数Quantity是负数，则抛出ArgumentException异常.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddItems_Test_With_Quantity_Negative()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddItems(new Item(), -1);
        }

        [TestMethod]
        public void DeleteItems_Test_With_Quantity_One_OR_Larger_Than_One()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            Item item = new Item();

            shoppingCart.AddItems(item, 10);
            Assert.AreEqual(10, shoppingCart.TotalItemsCount);

            shoppingCart.DeleteItems(item, 1);
            Assert.AreEqual(9, shoppingCart.TotalItemsCount);

            shoppingCart.DeleteItems(item, 9);
            Assert.AreEqual(0, shoppingCart.TotalItemsCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteItems_Test_With_Quantity_Zero()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            Item item = new Item();

            shoppingCart.AddItems(item, 10);
            Assert.AreEqual(10, shoppingCart.TotalItemsCount);

            shoppingCart.DeleteItems(item, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteItems_Test_With_Quantity_Negative()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            Item item = new Item();

            shoppingCart.AddItems(item, 10);
            Assert.AreEqual(10, shoppingCart.TotalItemsCount);

            shoppingCart.DeleteItems(item, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeleteItems_Test_With_Quantity_Larger_Than_The_Count_Of_That_Type_Item()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            Item item = new Item();

            shoppingCart.AddItems(item, 10);
            Assert.AreEqual(10, shoppingCart.TotalItemsCount);

            shoppingCart.DeleteItems(item, 11);
        }
    }
}
