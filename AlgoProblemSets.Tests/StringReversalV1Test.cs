using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoProblemSets;

namespace AlgoProblemSets.Tests
{
    [TestClass]
    public class StringReversalV1Test
    {
        [TestMethod]
        public void ReverseString()
        {
            //char[] array = new char[] { 'M', 'I', 'C', 'R', 'O', 'S', 'T' };
            string inputstring = "microsoft";
            string expected = "tfosorcim";

            string result = new string(StringReversal.Reverse(inputstring.ToCharArray()));
            Assert.AreEqual(result, expected);
        }
    }
}
