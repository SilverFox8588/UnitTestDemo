using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.common;
using UnitTestDemo.Models;
using UnitTestDemo.Tests.Extends;

namespace UnitTestDemo.Tests.common
{
    //1. 用数量0或者负数来调用AddItems或者DeleteItems, 应该引发异常（ArgumentException）
    //2. 调用AddItems, 条目的数量应当增加，无论那个条目是否已经存在
    //3. 调用DeleteItems删除不存在的条目，应当引发异常
    //4. 调用DeleteItems删除的数量大于车内已经有的物品的数量，应当引发异常
    //5. 调用DeleteItems,能够删除指定的条目，或者指定条目的数量
    //6. TotalItemsCount应当是所有类别条目的总数量


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
        /// 如果参数Quantity是等于1的整数，那么执行AddItems之后，ItemCount的数量应该增加1.
        /// </summary>
        [TestMethod]
        public void AddItems_Test_With_Correct_Quantity()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddItems(new Item(), 1);
            Assert.AreEqual(1, shoppingCart.TotalItemsCount);
        }

        /// <summary>
        /// 如果参数Quantity是大于1的整数，那么执行AddItems之后，ItemCount的数量应该增加参数值大小.
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

        /// <summary>
        /// 如何借助protected的成员变量测试某些难以测试属性或方法.
        /// </summary>
        [TestMethod]
        public void TotalItemsCount_Test()
        {
            ShoppingCartTesting shoppingCart = new ShoppingCartTesting();
            shoppingCart.Items.Add(new Item { ItemType = ItemType.Car }, 1);
            shoppingCart.Items.Add(new Item { ItemType = ItemType.Car }, 10);
            Assert.AreEqual(11, shoppingCart.TotalItemsCount);

            shoppingCart.Items.Add(new Item { ItemType = ItemType.Computer }, 10);
            Assert.AreEqual(21, shoppingCart.TotalItemsCount);

            shoppingCart.Items.Add(new Item { ItemType = ItemType.HomeAppliances }, 10);
            Assert.AreEqual(31, shoppingCart.TotalItemsCount);

            shoppingCart.Items.Add(new Item { ItemType = ItemType.OfficeSupplies }, 10);
            Assert.AreEqual(41, shoppingCart.TotalItemsCount);
        }
    }
}
