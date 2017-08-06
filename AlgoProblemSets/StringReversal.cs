using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{
    public class StringReversal
    {
        /// <summary>
        /// Wrapper function to call the recursive version of Reverse Util.
        /// </summary>
        /// <param name="array"></param>
        public static char[] Reverse(char[] array)
        {
            int low = 0;
            int high = array.Count() - 1;

            return ReverseUtil(array, low, high);
        }

        private static char[] ReverseUtil(char[] array, int low, int high)
        {
            if (high - low < 1)
                return array;

            // swap first and last element of the array.
            char temp = array[low];
            array[low] = array[high];
            array[high] = temp;

            // increment the lower bound
            low = low + 1 ;

            // decrement the upper bound
            high = high - 1;

            return ReverseUtil(array, low, high);

        }

    }
}
