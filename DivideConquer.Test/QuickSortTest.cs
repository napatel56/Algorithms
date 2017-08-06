using System;
using DivideConquer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DivideConquer.Test
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void QuickSortV1()
        {

            int[] unsorted = { 10, 8, 11, 6, 4, 13, 44, 21, 18, 23 };
            //int[] unsorted = { 10, 8, 11, 6 };
            int p = 0;
            int r = unsorted.Length - 1;

            QuickSort quickSort = new QuickSort();
            quickSort.QuickSortUtil(unsorted,p,r);

            for (int index = 0; index < unsorted.Length - 1; index++)
            {
                Console.Write(unsorted[index].ToString() + '\t');
            }
        }
    }
}
