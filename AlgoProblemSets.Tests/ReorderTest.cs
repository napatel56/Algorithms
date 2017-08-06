using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoProblemSets.Tests
{
    [TestClass]
    public class ReorderTest
    {
        [TestMethod]
        public void TestReorderArray()
        {
            int[] input = { 3, 4, 1, 8, 2, 6, 5, 9};
            
            Console.WriteLine();
            Console.WriteLine("The Input Array:");
            
            for (int index = 0; index < input.Length; index++)
            {
                Console.Write(input[index].ToString() + '\t');
            }

            ReorderArray.ShuffleElements(input);

            Console.WriteLine();
            Console.WriteLine("The Shuffled Array:");
            
            for (int index = 0; index < input.Length; index++)
            {
                Console.Write(input[index].ToString() + '\t');
            }



            int[] input2 = { -7, 4, -4, 3, 11, 9, 8 };

            Console.WriteLine();
            Console.WriteLine("The Input Array:");
            
            for (int index = 0; index < input2.Length; index++)
            {
                Console.Write(input2[index].ToString() + '\t');
            }

            ReorderArray.ShuffleElements(input2);

            Console.WriteLine();
            Console.WriteLine("The Shuffled Array:");
            
            for (int index = 0; index < input2.Length; index++)
            {
                Console.Write(input2[index].ToString() + '\t');
            }

            int[] input3 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine();
            Console.WriteLine("The Input Array:");
            
            for (int index = 0; index < input3.Length; index++)
            {
                Console.Write(input3[index].ToString() + '\t');
            }

            ReorderArray.ShuffleElements(input3);

            Console.WriteLine();
            Console.WriteLine("The Shuffled Array:");
            
            for (int index = 0; index < input3.Length; index++)
            {
                Console.Write(input3[index].ToString() + '\t');
            }

            int[] input4 = { 9, 7, 5, 3, 1, 2, 4, 6, 8 };

            Console.WriteLine();
            Console.WriteLine("The Input Array:");
            
            for (int index = 0; index < input4.Length; index++)
            {
                Console.Write(input4[index].ToString() + '\t');
            }

            ReorderArray.ShuffleElements(input4);

            Console.WriteLine();
            Console.WriteLine("The Shuffled Array:");
            
            for (int index = 0; index < input4.Length; index++)
            {
                Console.Write(input4[index].ToString() + '\t');
            }

        }
    }
}
