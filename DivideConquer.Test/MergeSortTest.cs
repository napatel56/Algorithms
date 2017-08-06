using System;
using DivideConquer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DivideConquer.Test
{
    [TestClass]
    public class MergeSorTest
    {
        [TestMethod]
        public void MergeSort()
        {

            //int[] unsorted = { 10, 8, 11, 6, 4, 13, 44, 21, 18, 23 };
            int[] unsorted = { 10, 8, 11, 6};
            MergeSort mergeSort = new MergeSort();
            int[] result = mergeSort.SortUtil(unsorted); 
            
            for (int index = 0; index < result.Length - 1; index ++)
            {
                Console.Write(result[index].ToString() + '\t');
            }


        }

        [TestMethod]
        public void ArraySizeTest()
        {
            int[] unsorted = { 10, 8, 11, 6,11 };

            CalculateArraySize(unsorted);
        }

        private void CalculateArraySize(int[] unsorted)
        {
            Console.Write(unsorted.Length); ;
        }
    }
}
