using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{
    public class ArrayPblms
    {
        public static int getIndex(int[] input, int[] pattern) 
        {
	        int n = input.Length;
	        int m = pattern.Length;
	
            if( m > n) {
                throw new ArgumentException("Sub Array must be smaller than the input array.");
            }

            for (int i =0; i < n; i++)
            {
                int j = 0;
    
                for (; j < m; j++)
                {
                    if (input[i] != pattern[j])
                    {
                        break;
                    }
                }

                if (j == m)
                {
                    return i - m;
                }
            }
	        
	        return -1;
        }

        public static bool isValidEmailText(string text)
        {

            int x = ' ';
            int y = '~';

            int asciiVal;

            foreach (char c in text)
            {
                asciiVal = c;

                if (asciiVal >= x && asciiVal <= y)
                {
                    return true;
                }
            }

            return false;

        }

        public static string GetEncodedString(int num) 
        {

	        char[] map = {'0','a','t','l','s','i','N'};
		
	        List<char> encoded = new List<char>();

            int rem;

            do 
            {
                rem = num % 7;
                num = num / 7;

                encoded.Add(map[rem]);

            } while (num != 0);

            encoded.Reverse();

            string result = string.Empty;
            
            foreach (char ch in encoded)
            {
                result = result + ch.ToString();
            }

            return result;
        }

    }
}
