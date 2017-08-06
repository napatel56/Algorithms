using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoProblemSets.Tests
{
    [TestClass]
    public class ShuffleTest
    {
        [TestMethod]
        public void TestShuffleArray()
        {
            //int[] input = { 3, 4, 1, 8, 2, 6, 5, 9};
            int[] input = { 3, 4, 1, 8, 2, 6 };

            Console.WriteLine("The Input Array:");
            for (int index = 0; index < input.Length; index++)
            {
                Console.Write(input[index].ToString() + '\t');
            }

            Shuffle.ShuffleArray(input);

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

            Shuffle.ShuffleArray(input2);

            Console.WriteLine();
            Console.WriteLine("The Shuffled Array:");
            for (int index = 0; index < input2.Length; index++)
            {
                Console.Write(input2[index].ToString() + '\t');
            }
        }

        [TestMethod]
        public void MSSTest()
        {
            int[] input2 = { -7, 4, -4, 3, 11, 9, 8 };
            Shuffle.Result result = Shuffle.MSSDP(input2);

            Console.WriteLine(result.start);
            Console.WriteLine(result.end);
            Console.WriteLine(result.sum);

        }
    }
}
