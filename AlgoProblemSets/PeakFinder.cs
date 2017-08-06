using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{
    public class PeakFinder
    {
        private static int PeakFinder1DUtil(List<int> array, int low, int high)
        {
            // find the mid-point
            int mid = low + (high - low)/2;
            
            // mid =0 implies, it is a single element array.
            // if the the selected mid-point is greater than its neighbours than the selected element is a Peak element.
            if(mid == 0 || (array[mid] >= array[mid - 1] && array[mid] >= array[mid +1]))        
                return array[mid];
            
            else if(array[mid-1] >= array[mid])
            {
                return PeakFinder1DUtil(array, low, mid - 1); 
            }
            // array[mid + 1] >= array[mid], peak is at right side of the mid element.
            else 
            {
                return PeakFinder1DUtil(array, mid + 1, high); 
            }

        }

        /// <summary>
        /// Wraaper function to call the recursive version of Peak finder 1D version Util.
        /// </summary>
        /// <param name="array"></param>
        public static int PeakFinder1D(List<int> array)
        {
            int low = 0;
            int high = array.Count() - 1;

            return PeakFinder1DUtil(array, low, high);
        }

        /// <summary>
        /// Wrapper function to call the recursive version of Peak finder 1D version Util.
        /// </summary>
        /// <param name="array"></param>
        public static int PeakFinder2D(int[,] matrix, int rows, int cols)
        {
            // find the middle column in the matrix.
            int j = cols / 2; 

            
            // Get the Global Max on column j.
            int globalMaxRowIndex = getGlobalMaxOnSelectedCol(matrix, rows, j);

            List<int> array = Get1DRowArrayFromMatrix(matrix, cols, globalMaxRowIndex);

            int peakElement = PeakFinder1D(array);

            return peakElement;
            //return PeakFinder2DUtil(array, low, high);
        }

        /// <summary>
        /// Find the Global Max Index on Selected Column.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="rows"></param>
        /// <param name="mcol"></param>
        /// <returns></returns>
        private static int getGlobalMaxOnSelectedCol(int[,] matrix, int rows, int mcol)
        {
            int maxIndex = 0;

            List<int> array = Get1DColArrayFromMatrix(matrix, rows, mcol);

            for (int j = 1; j < rows; j++)
            {
                if (array[maxIndex] < array[j])
                    maxIndex = j;
            }

            return maxIndex;
        }

        /// <summary>
        /// Get 1D Column Array from 2D Array.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="elementCount"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static List<int> Get1DColArrayFromMatrix(int[,] matrix, int elementCount, int index)
        {
            List<int> array = new List<int>();

            for (int i = 0; i < elementCount; i++)
            {
                array.Add(matrix[i, index]);
            }

            return array;

        }

        /// <summary>
        /// Get 1D Row Array from 2D Array.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="elementCount"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static List<int> Get1DRowArrayFromMatrix(int[,] matrix, int elementCount, int index)
        {
            List<int> array = new List<int>();

            for (int i = 0; i < elementCount; i++)
            {
                array.Add(matrix[index, i]);
            }

            return array;

        }

        private static int PeakFinder2DUtil(int[,] matrix)
        {
            int row = matrix.Length;
            //int col = matrix.C;

            // Find the mid column for 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns the Excel Column Header for the given integer position.
        /// </summary>
        /// <param name="position">References the integer position.</param>
        /// <returns>String Representation of the Column Header.</returns>
        public static string getExcelColumnHeader(int position) 
        {

	        char[] letters = new char[] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
            List<string> columnHeader = new List<string>();
	
            // Check the Input Argument
            if(position <= 0) 
            {
		        throw new ArgumentException("Numeric Position is invalid", "argument");
            }
	
            int remainder = 0;
            while(position != 0) 
            {
	
                remainder = position % 26;
		        
		        if(remainder == 0 ) 
                {
			        columnHeader.Add("Z");
                    position = position / 26 - 1;
		        }
                else
                {
                    columnHeader.Add(letters[remainder - 1].ToString());
                    position = position / 26;
                }
                    
		    }
	
            // Reverses the List
	        columnHeader.Reverse();

            // Converts the List of Letters into Column Header string.
            StringBuilder builder = new StringBuilder();
            foreach (string ch in columnHeader)
            {
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }


}

