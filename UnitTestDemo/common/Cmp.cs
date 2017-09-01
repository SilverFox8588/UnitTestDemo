using System;

namespace UnitTestDemo.common
{
    public class Cmp
    {
        //public static int Largest(int[] list)
        //{
        //    int max = int.MinValue;
        //    if (list.Length == 0)
        //    {
        //        throw new ArgumentException("Largest: list cannot be empty");
        //    }

        //    foreach (int item in list) // we use foreach to avoid "off-by-one" error
        //    {
        //        if (item > max)
        //        {
        //            max = item;
        //        }
        //    }
        //    return max;
        //}

        //public static int Largest(int[] list)
        //{
        //    int max = int.MinValue;
        //    if (list.Length == 0)
        //    {
        //        throw new ArgumentException("Largest: list cannot be empty");
        //    }

        //    for (int i = 0; i < list.Length -1; i++) // error: for loop ends too early(off-by-one)
        //    {
        //        if (list[i] > max)
        //        {
        //            max = list[i];
        //        }
        //    }

        //    return max;
        //}

        public static int Largest(int[] list)
        {
            int max = 0; // error: we want the max with min value as its initial value
            if (list.Length == 0)
            {
                throw new ArgumentException("Largest: list cannot be empty");
            }

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}