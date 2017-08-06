using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoProblemSets;

namespace AlgoProblemSets.Tests
{
    [TestClass]
    public class ExcelHeaderTest
    {
        [TestMethod]
        public void getExcelColumnHeaderTest()
        {

            int position;
            string result = string.Empty;
            string expected = string.Empty;


            position= 27;
            expected = "AA";
            result = ExcelHeader.getExcelColumnHeader(position);
            Assert.AreEqual(result, expected);
            Console.WriteLine(String.Format("Position: {0} => {1}", position.ToString(),result));

            position = 28;
            expected = "AB";
            result = ExcelHeader.getExcelColumnHeader(position);
            Assert.AreEqual(result, expected);
            Console.WriteLine(String.Format("Position: {0} => {1}", position.ToString(), result));

            position = 26;
            expected = "Z";
            result = ExcelHeader.getExcelColumnHeader(position);
            Assert.AreEqual(result, expected);
            Console.WriteLine(String.Format("Position: {0} => {1}", position.ToString(), result));

            position = 36;
            expected = "AJ";
            result = ExcelHeader.getExcelColumnHeader(position);
            Console.WriteLine(String.Format("Position: {0} => {1}", position.ToString(), result));

            position = 41;
            expected = "AO";
            result = ExcelHeader.getExcelColumnHeader(position);
            Console.WriteLine(String.Format("Position: {0} => {1}", position.ToString(), result));

            position = 702;
            expected = "ZZ";
            result = ExcelHeader.getExcelColumnHeader(position);
            Console.WriteLine(String.Format("Position: {0} => {1}", position.ToString(), result));


            position = 703;
            expected = "AAA";
            result = ExcelHeader.getExcelColumnHeader(position);
            Console.WriteLine(String.Format("Position: {0} => {1}", position.ToString(), result));

            position = 18278;
            expected = "ZZ";
            result = ExcelHeader.getExcelColumnHeader(position);
            Console.WriteLine(String.Format("Position: {0} => {1}", position.ToString(), result));

            position = 18279;
            expected = "AAAA";
            result = ExcelHeader.getExcelColumnHeader(position);
            Console.WriteLine(String.Format("Position: {0} => {1}", position.ToString(), result));

        }

        [TestMethod]
        public void getNumberTest()
        {
            int result = ExcelHeader.Excelcolumn_to_number("AZ");
            Console.WriteLine(result);

            result = ExcelHeader.Excelcolumn_to_number("AB");
            Console.WriteLine(result);

            result = ExcelHeader.Excelcolumn_to_number("ZZ");
            Console.WriteLine(result);

            result = ExcelHeader.Excelcolumn_to_number("AAA");
            Console.WriteLine(result);
        }

        [TestMethod]
        public void IncreasingSubArrayTest()
        {
            int[] input = { -2, 1, 2, 3, 4, 5, -9 };

            ExcelHeader.Result result = new ExcelHeader.Result();

            result = ExcelHeader.MaxIncreasingSubArray(input);

        }


        [TestMethod]
        public void TestPower()
        {
            double x = ExcelHeader.power(2, 3);
        }

        
        [TestMethod]
        public void Test2DArray()
        {

            int[] ar = new int[5];
            char ch1 = 'a';
            char ch2 = 'c';
            ar[ch1]++;
            ar[ch2]++;

            int x = 4;
            int y = -8;

            // true iff x and y have opposite signs
            bool isOpposite = ((x ^ y) < 0);

            if (isOpposite)
                Console.Write("Opposite");
            else
                Console.Write("Same sign");

            x = x ^ y;
            y = x ^ y;
            x = x ^ y;

            int min = int.MinValue;

            int result3 = min - 1;
            int result4 = min + 1;

            int max = int.MaxValue;

            int result1 = max - 1;
            int result2 = max + 1;

            int num = 4678;

            int n = num / 10;

            int rem = num % 10;

            char ch = 'r';
            int offset = 'a';
	        int value =  ch - offset;


            char[,] TOKENS = { {'{','}'}, 
									 {'[',']'},
									 {'(',')'} 
								   };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (TOKENS[i, 0] == '{')
                    {
                        Console.WriteLine(TOKENS[i, 1]);

                    }

                }


            }

        }

   }
}
