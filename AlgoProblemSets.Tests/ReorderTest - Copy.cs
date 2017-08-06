using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoProblemSets.Tests
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void TestEncoding()
        {
            int num = 7;

            string result = ArrayPblms.GetEncodedString(num);

            Console.WriteLine(result);


            num = 9;

            result = ArrayPblms.GetEncodedString(num);

            Console.WriteLine(result);

            num = 15;

            result = ArrayPblms.GetEncodedString(num);

            Console.WriteLine(result);

            num = 0;

            result = ArrayPblms.GetEncodedString(num);

            Console.WriteLine(result);
        }

        [TestMethod]
        public void TestValidEmailText()
        {
            string input = "abcdef";
            bool result = ArrayPblms.isValidEmailText(input);

            Console.WriteLine (result.ToString());
            
            input = "ab*(cdef";
            ArrayPblms.isValidEmailText(input);
            Console.WriteLine(result.ToString());
        }
    }
}
