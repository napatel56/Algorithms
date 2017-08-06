using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructures.Test
{
    [TestClass]
    public class MaxHeapTest
    {
        [TestMethod]
        public void BuildMaxHeapTest()
        {
            //Array in ascending order.
            int[] elements = { 3, 5, 7, 8, 9, 10, 11 };
            MaxHeap maxHeap = new MaxHeap();
            maxHeap.BuildMaxHeap(elements);

            Console.Write("Max Heap: ");
            for (int index = 0; index < elements.Length - 1; index++)
            {
                Console.Write(elements[index].ToString() + '\t');
            }
        }

        [TestMethod]
        public void Heap_ExtractMaxTest()
        {
            //Array in ascending order.
            int[] elements = { 100, 50, 60, 30, 20, 40 };
            MaxHeap maxHeap = new MaxHeap();
            int max = maxHeap.ExtractMax_Heap(elements);

            Console.WriteLine(string.Format("The Maximum element extracted from Heap is: {0}\n", max));

            Console.Write("New Max Heap : ");
            for (int index = 0; index < elements.Length - 2; index++)
            {
                Console.Write(elements[index].ToString() + '\t');
            }
        }

         [TestMethod]
        public void IncreaseKeyTest()
        {
            //Array in ascending order.
            int[] elements = { 3, 5, 7, 8, 9, 10, 11 };
            MaxHeap maxHeap = new MaxHeap();
            maxHeap.BuildMaxHeap(elements);

            Console.Write("Max Heap: ");
            for (int index = 0; index <= elements.Length - 1; index++)
            {
                Console.Write(elements[index].ToString() + '\t');
            }

            // Attempts to increase the prority from 5 to 15.
            maxHeap.Heap_Increase_Key(elements, 4, 14);
            Console.WriteLine();
            Console.Write("New Max Heap post increasing the Key: ");
            for (int index = 0; index <= elements.Length - 1; index++)
            {
                Console.Write(elements[index].ToString() + '\t');
            }
        }


         [TestMethod]
         public void DecreaseKeyTest()
         {
             //Array in ascending order.
             int[] elements = { 3, 5, 7, 8, 9, 10, 11 };
             MaxHeap maxHeap = new MaxHeap();
             maxHeap.BuildMaxHeap(elements);

             Console.Write("Max Heap: ");
             for (int index = 0; index <= elements.Length - 1; index++)
             {
                 Console.Write(elements[index].ToString() + '\t');
             }

             // Attempts to increase the prority from 5 to 15.
             maxHeap.Heap_Decrease_Key(elements, 2, 2);
             Console.WriteLine();
             Console.Write("New Max Heap post decreasing the Key: ");
             for (int index = 0; index <= elements.Length - 1; index++)
             {
                 Console.Write(elements[index].ToString() + '\t');
             }
         }
    }
}
