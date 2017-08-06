using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideConquer
{
    public class QuickSort
    {
        /// <summary>
        /// Partition function is the core of Quick Sort. It is similar to Combine (Merge) in Merge Sort.
        /// </summary>
        /// <param name="elements">Represents the Array to be sorted.</param>
        /// <param name="p">Represents starting index of the Array to be sorted.</param>
        /// <returns></returns>
        private int Partition(int[] elements, int p, int r)
        {
            // Select the last element of the Array as the Pivot element (Element to be Sorted).
            int pivot = elements[r];
            int temp;

            // index i will be one element less than the index 'j'.
            int i = p - 1;
            int j = p;

            // Index i will keep track of elements in the array that are less than or equal to the pivot element.
            // Index j will run till r-1 elements.
            // Advance j index to point to the next element in the array.
            for (j = p; j < r; j++ )
            {
                if (elements[j] < pivot)
                {
                    // Advance the i index by one element.
                    i++;
                    
                    // Exchange elements at ith and jth location.
                    temp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = temp;
                }
            }

            // Exchange i+ 1 element with rth element.
            temp = elements[r];
            elements[r] = elements[i + 1];
            elements[i + 1] = temp;

            return i + 1;
        }

        public void QuickSortUtil(int[] elements, int p, int r)
        {
            if(p < r)
            {
                int q = Partition(elements, p, r);
                QuickSortUtil(elements, p, q - 1);
                QuickSortUtil(elements, q + 1, r);
            }

        }
    }
}
