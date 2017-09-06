using System.Threading;

namespace UnitTestDemo.common
{
    public class DesignForTest
    {
        /// <summary>
        /// Waits for time.
        /// </summary>
        /// <param name="fileSize">Size of the data.</param>
        public void WaitForTime(int fileSize)
        {
            int timeToWait;

            if (fileSize < 100)
            {
                timeToWait = 50;
            }
            else if (fileSize < 250)
            {
                timeToWait = 100;
            }
            else if (fileSize < 60)
            {
                timeToWait = 150;
            }
            else
            {
                timeToWait = 200;
            }

            Thread.Sleep(timeToWait);
        }
    }
}