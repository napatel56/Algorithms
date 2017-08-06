using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoProblemSets.Tests
{
    [TestClass]
    public class SuperPrimeTest
    {
        [TestMethod]
        public void TestNSuperPrime()
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23,29,31,37,39};

            int result = SuperPrime.NSuperPrime(primes, 3);

            Console.WriteLine(result);

            result = SuperPrime.NSuperPrime(primes, 4);

            Console.WriteLine(result);

            result = SuperPrime.NSuperPrime(primes, 5);

            Console.WriteLine(result);
        }
    }
}
