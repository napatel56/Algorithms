using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoProblemSets.Tests
{
    [TestClass]
    public class CoinChangeProblemTest
    {
        [TestMethod]
        public void TestCoinChange()
        {
            int[] coins = { 1, 3, 4 };
            int amount = 6;

            int result = CoinChangeProblem.MinCoins(coins, amount);
            Console.WriteLine(result);
            //Console.ReadLine();
        }
    }
}
