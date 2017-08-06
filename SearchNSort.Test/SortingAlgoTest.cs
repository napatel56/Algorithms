using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;

namespace SearchNSort.Test
{
    [TestClass]
    public class SortingAlgoTest
    {
        [TestMethod]
        public void SelectionSortTest()
        {
            int[] unsorted = { 10, 8, 11, 6, 4, 13, 44, 21, 18, 23 };
            //int[] unsorted = { 10, 8, 11, 6 };
            SortingAlgo selSort = new SortingAlgo();
            selSort.SelectionSort(unsorted);

            for (int index = 0; index <= unsorted.Length - 1; index++)
            {
                Console.Write(unsorted[index].ToString() + '\t');
            }
        }

        [TestMethod]
        public void BitwiseTest()
        {
            int a = 10;
            int b = 4;

            string binaryA = Convert.ToString(a, 2);
            string binaryB = Convert.ToString(b, 2);

            //a &~ b;


            a |= 1 << 5;

            binaryA = Convert.ToString(a, 2);
        }

        [TestMethod]
        public void ArraysTest()
        {

            int[] visited = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("");
            for (int i = 0; i < visited.Length; i++)
            {
                
                Console.WriteLine(visited[i]);
            } 
            
            SortingAlgo test = new SortingAlgo();
            test.ArrayUtil(ref visited);

            Console.WriteLine("");
            for (int i = 0; i < visited.Length; i++)
            {
                
                Console.WriteLine(visited[i]);
            }
        }
    }
}
