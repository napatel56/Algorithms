using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoProblemSets;

namespace AlgoProblemSets.Tests
{
    [TestClass]
    public class PeakFinderTest
    {
        [TestMethod]
        public void FindPeak1DVersion()
        {
            List<int> expectedPeak = new List<int>();
            expectedPeak.Add(20);
            expectedPeak.Add(90);

            // { 10, 20, 15, 2, 23, 90, 67}
            List<int> array = new List<int>();

            array.Add(10);
            array.Add(20);
            array.Add(15);
            array.Add(2);
            array.Add(23);
            array.Add(90); 
            array.Add(67);

            int result = PeakFinder.PeakFinder1D(array); 
            Assert.IsTrue(expectedPeak.Contains(result));
        }

        [TestMethod]
        public void FindPeak2DVersion()
        {
            int[,] matrix = new int[,]{
                                            {1,2,3,4,5},
                                            {5,6,9,8,6},
                                            {9,0,1,2,9},
                                            {3,4,5,6,8}
                                    };

            // get the # of rows.
            int rows = matrix.GetLength(0);
            // get the # of columns.
            int cols = matrix.GetLength(1);

            List<int> expectedPeak = new List<int>();
            expectedPeak.Add(9);
            
            int result = PeakFinder.PeakFinder2D (matrix,rows, cols);
            Assert.IsTrue(expectedPeak.Contains(result));
        }


        [TestMethod]
        public void FindPeak2DVersion1()
        {
            int[,] matrix = new int[,]{
                                            {1,2,3,4,5},
                                            {5,6,9,8,6},
                                            {9,0,1,2,9},
                                            {3,4,5,6,8}
                                    };

            // get the # of rows.
            int rows = matrix.GetLength(0);
            // get the # of columns.
            int cols = matrix.GetLength(1);

            List<int> expectedPeak = new List<int>();
            expectedPeak.Add(9);

            int result = PeakFinder.PeakFinder2D(matrix, rows, cols);
            Assert.IsTrue(expectedPeak.Contains(result));
        }

        [TestMethod]
        public void getExcelColumnHeaderTest()
        {
            int position;
            string result = string.Empty;
            string expected = string.Empty;


            position= 27;
            expected = "AA";
            result = PeakFinder.getExcelColumnHeader(position);
            Assert.AreEqual(result, expected);
            Console.WriteLine(result);


            position = 28;
            expected = "AB";
            result = PeakFinder.getExcelColumnHeader(position);
            Assert.AreEqual(result, expected);
            Console.WriteLine(result);

            position = 26;
            expected = "Z";
            result = PeakFinder.getExcelColumnHeader(position);
            Assert.AreEqual(result, expected);
            Console.WriteLine(result);

            position = 36;
            expected = "AJ";
            result = PeakFinder.getExcelColumnHeader(position);
            Console.WriteLine(result);

            position = 41;
            expected = "AO";
            result = PeakFinder.getExcelColumnHeader(position);
            Console.WriteLine(result);

            position = 702;
            expected = "ZZ";
            result = PeakFinder.getExcelColumnHeader(position);
            Console.WriteLine(result);


            position = 703;
            expected = "AAA";
            result = PeakFinder.getExcelColumnHeader(position);
            Console.WriteLine(result);

            position = 18278;
            expected = "ZZ";
            result = PeakFinder.getExcelColumnHeader(position);
            Console.WriteLine(result);

            position = 18279;
            expected = "AAAA";
            result = PeakFinder.getExcelColumnHeader(position);
            Console.WriteLine(result);

        }
   }
}
