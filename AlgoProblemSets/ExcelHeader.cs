using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{
    public class ExcelHeader
    {

        
        public class Result
        {
            public int start;
            public int end;
            public int length;
        }


        public static Result MaxIncreasingSubArray(int[] arr) 
        {
            if(arr == null || arr.Length == 0) {
		        return null;
	        }

            int n = arr.Length;
	        
	        Result max_curr   = new Result();
	        max_curr.start = 0;
	        max_curr.end = 0;
	        max_curr.length = 1;

            
            Result max_so_far =  new Result();
            max_so_far.start = 0;
            max_so_far.end = 0;
            max_so_far.length = 1;
	
	        for (int i = 1; i < n; i++)
	        {
		        if(arr[i] > arr[i-1])
		        {
			        max_curr.end++;
			        max_curr.length++;
		        }
		        else{
			        max_curr.start =i;
			        max_curr.end   =i;
			        max_curr.length=1;
		        }
		
		        if(max_so_far.length < max_curr.length) {
			        max_so_far.start = max_curr.start;
                    max_so_far.end = max_curr.end;
                    max_so_far.length = max_curr.length;
		        }
	
	        }
	
	        return max_so_far;
	
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


        public static int Excelcolumn_to_number(string sequence) {

        	int result =0 ;
	        int baseIndex = 1;
	
	        foreach(char c in sequence.Reverse()) {

                result = result + (c - 'A' + 1) * baseIndex;

                baseIndex = baseIndex * 26;
	        }
		
	        return result;
        }

        public static double power(int x, int y)
        {

            if (x == 0)
            {
                return 0;
            }

            if (y == 0)
            {
                return 1;
            }

            if (y % 2 == 0)
            {
                return power(x, y / 2) * power(x, y / 2);
            }

            if (y % 2 > 0)
            {
                return x * power(x, y - 1);
            }

            if (y % 2 < 0)
            {
                return 1 / (power(x, Math.Abs(y)));
            }

            return -1;
        }
    }


}

