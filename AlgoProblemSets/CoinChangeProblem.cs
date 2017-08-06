using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{
    public class CoinChangeProblem
    {

        public static int MinCoins(int[] coins, int amount)
        {

            int[,] dp = new int[coins.Length + 1, amount + 1];

            for (int i = 0; i < coins.Length; i++)
            {
                dp[i, 0] = 0;
            }

            for (int i = 0; i <= amount; i++)
            {
                dp[0, i] = Int32.MaxValue;
            }

            for (int i = 1; i <= coins.Length; i++)
            {
                for (int j = 1; j <= amount; j++)
                {

                    if (coins[i-1] <= j)
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - coins[i-1]] + 1);
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }

            }

            return dp[coins.Length, amount];

        }
    }
}
