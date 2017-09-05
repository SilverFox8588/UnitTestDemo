using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            // _class.CheckRUL();
            stopwatch.Stop();

            Assert.IsTrue(stopwatch.ElapsedMilliseconds < 3000);
        }
    }
}
