using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{
    public class SuperPrime
    {


        // Complexity: O(n * Log P) where P is the size of prime array.
        public static int NSuperPrime(int[] primes, int n)
        {

            if (primes == null || n == 0)
            {
                return -1;
            }

            int counter = 0;
            int position = 0;

            while (counter < n)
            {
                position = position + 1;
                
                if (isPrime(primes, position))
                {
                    counter = counter + 1;
                }
                
            }

            return primes[position - 1];
        }

        public static bool isPrime(int[] primes, int number)
        {

            int low = 0;
            int high = primes.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (number == primes[mid])
                    return true;

                else if (number > primes[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

            }

            return false;

        }
    }
}


