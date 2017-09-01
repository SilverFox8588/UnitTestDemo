using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.common;

namespace UnitTestDemo.Tests.common
{
    [TestClass]
    public class CmpTest
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
        public void TestLargest()
        {
            // 数组中元素从小到大排列
            Assert.AreEqual(9, Cmp.Largest(new[] { 1, 3, 9 }));

            // 数组中元素从大到小排列
            Assert.AreEqual(9, Cmp.Largest(new[] { 9, 3, 1 }));

            // 包含最大值和最小值
            Assert.AreEqual(int.MaxValue, Cmp.Largest(new[] { int.MinValue, int.MaxValue, 0 }));

            // 包含负数和0
            Assert.AreEqual(1, Cmp.Largest(new[] { -1, 1, 0 }));

            // 数组中只有一个元素
            Assert.AreEqual(0, Cmp.Largest(new[] { 0 }));
        }

        [TestMethod]
        public void TestLargestWithAllNegativeData()
        {
            Assert.AreEqual(-1, Cmp.Largest(new[] { int.MinValue, -10, -1 }));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLargestWithEmptyList()
        {
            Cmp.Largest(new int[] { });
        }

        [TestMethod]
        [TestCategory("short")]
        public void OtherTest()
        {
            Assert.AreEqual(3.33, 10.0 / 3, 0.01);

            Assert.IsNull(null);
            Assert.IsFalse(1 + 1 > 2);
            Assert.AreSame("sss", "sss");
        }
    }
}
