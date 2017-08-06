using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideConquer
{
    public class MergeSort
    {
        /// <summary>
        /// Merge Sort Utility
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        private int[] MergeSortUtil(int[] array, int low, int high)
        {
            // Base Case Recursion
            // in case of One element Array. The array is already sorted. 
            if (high - low < 1)
            {
                return new int[] { array[low] };
            }
            else
            {
                // Low index acts as Offset.
                int middle = low + (high - low) / 2;                        // Divide

                int[] left = MergeSortUtil(array, low, middle);             // Conquer Step
                int[] right = MergeSortUtil(array, middle + 1, high);       // Conquer Step
                int[] result = CombineV1(array,low, middle, high);                        // Combine Step

                return result;
            }
        }

        /// <summary>
        /// Merges two sorted arrays and forms a new sorted array.
        /// </summary>
        public int[] CombineV2(int[] left, int[] right)
        {
            int lIndex = 0;             // references the smallest unpicked element from Left Array.
            int rIndex = 0;             // references the smallest unpicked element from Right Array.
            int sortedArraySize = left.Length + right.Length;
            int sIndex = 0;
            int[] sortedArray = new int[sortedArraySize];

            while(lIndex < left.Length && rIndex < right.Length)
            {
                if(left[lIndex] < right[rIndex])
                {
                    sortedArray[sIndex] = left[lIndex];
                    lIndex++;
                }
                else
                {
                    sortedArray[sIndex] = right[rIndex];
                    rIndex++;
                }

                sIndex++;

            }

            while (lIndex < left.Length - 1)
            {
                sortedArray[sIndex] = lIndex;
                lIndex++;
                sIndex++;
            }

            while (rIndex < right.Length - 1)
            {
                sortedArray[rIndex] = rIndex;
                rIndex++;
                sIndex++;
            }

            return sortedArray;
        }

        /// <summary>
        /// Warpper Util function for merged sort.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] SortUtil(int[] array)
        {
            int low = 0;
            int high = array.Length - 1;

            int[] result = MergeSortUtil(array, low, high);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="p">Represents the start of the left sorted list</param>
        /// <param name="q">1. q      => Represents the end of the left sorted list
        ///                 2. q + 1  => Represents the start of the right sorted list.
        ///                 </param>
        /// <param name="r">Represents the End of the Right Sorted List</param>
        /// <returns></returns>
        private int[] CombineV1(int[] numbers, int p, int q, int r)
        {
            // Create Left and Right Arrays.
            int nLeft = q- p + 1;  // Size of Left Array.
            int nRight = r- q;     // Size of Right Array. 
            int lIndex = 0;        // References the Left Array 
            int rIndex = 0;        // References the Right Array 
            int kIndex = 0;        // 

            int[] left = new int[nLeft];
            int[] right = new int[nRight];
            int[] temp = new int[nLeft + nRight];

            // Copy the Elements from the Main Array into Left and Right Array.
            for(int index = 0; index < q; index++)
            {
                left[lIndex] = numbers[index];
            }

            for(int index = q; index < r; index++)
            {
                right[rIndex] = numbers[index];
            }

            lIndex = 0;
            rIndex = 0;

            while (lIndex < left.Length && rIndex < right.Length)
            {
                if (left[lIndex] < right[rIndex])
                {
                    temp[kIndex] = left[lIndex];
                    lIndex++;
                }
                else
                {
                    temp[kIndex] = right[rIndex];
                    rIndex++;
                }

                kIndex++;

            }

            while (lIndex < left.Length - 1)
            {
                temp[kIndex] = lIndex;
                lIndex++;
                kIndex++;
            }

            while (rIndex < right.Length - 1)
            {
                temp[rIndex] = rIndex;
                rIndex++;
                kIndex++;
            }

            kIndex = p;
            for (int index = 0; index < temp.Length; index++ )
            {
                numbers[kIndex] = temp[index];
                kIndex++;
            }

            return numbers;
        }
    }
}
