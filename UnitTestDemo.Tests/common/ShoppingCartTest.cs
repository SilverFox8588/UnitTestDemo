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

        /// <summary>
        /// 如果参数Quantity是等于1的整数，那么执行AddItems之后，ItemCount应该等于1.
        /// </summary>
        [TestMethod]
        public void AddItems_Test_With_Correct_Quantity()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddItems(new Item(), 1);
            Assert.AreEqual(1, shoppingCart.ItemCount);
        }

        /// <summary>
        /// 如果参数Quantity是大于1的整数，那么执行AddItems之后，ItemCount应该等于参数值.
        /// </summary>
        [TestMethod]
        public void AddItems_Test_With_Quantity_Larger_Than_One()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            shoppingCart.AddItems(new Item(), 10);
            Assert.AreEqual(10, shoppingCart.ItemCount);
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
    }
}
