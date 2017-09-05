using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.common;
using UnitTestDemo.Models;

namespace UnitTestDemo.Tests.common
{
    [TestClass]
    public class PerformanceTest
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
        public void FilterRanges()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // check a function which may have performance problem
            ShoppingCart shoppingCart = new ShoppingCart();
            for (int i = 1; i <= 1000000; i++)
            {
                shoppingCart.AddItems(new Item { ItemType = (ItemType)(i % 4) }, i);
            }

            for (int i = 1; i <= 1000000; i++)
            {
                shoppingCart.DeleteItems(new Item { ItemType = (ItemType)(i % 4) }, i);
            }
            stopwatch.Stop();

            Assert.IsTrue(stopwatch.ElapsedMilliseconds < 100);
        }
    }
}
