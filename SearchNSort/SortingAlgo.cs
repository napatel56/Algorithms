using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    /// <summary>
    /// Selection Sort is based on establishing and maintaining invaraint. We are going to maintain a pointer that divides
    /// the array into Prefix and Suffix. The invariant that we are going to maintain is that our prefix is always sorted.
    /// </summary>
    public class SortingAlgo
    {
        public void SelectionSort(int[] elements)
        {
            int uBound = elements.Length -1;
            int j = 0;
            int minIndex = 0;
            int minValue = 0;

            for (int i= 0; i <= uBound; i++)
            {
                minValue = elements[i];
                minIndex = i;

                j = i + 1;

                while(j <= uBound)
                {
                    if (minValue > elements[j])
                    {
                        minIndex = j;
                        minValue = elements[j];
                    }
                    j++;
                }

                // Min Index will return the index location of the minimum value from the suffix array.
                // Add this min value at the add of prefix array. 

                int temp = elements[i];
                elements[i] = elements[minIndex];
                elements[minIndex] = temp;
            }
        }

        public void ArrayUtil(ref int[] arr)
        {
            int size = arr.Length;

            arr[0] = 8;
            arr[1] = 7;
            arr[4] = 9;

            Console.WriteLine("");
            for (int i=0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
