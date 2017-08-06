using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{
    public class Shuffle
    {

        public class Result
        {
            public int start {get;set;}
            public int end {get; set;}
            public int sum {get; set;}

            public Result (int start, int end, int sum) {
                this.start = start;
                this.end = end;
                this.sum = sum;
            }
        }

        public static void ShuffleArray(int[] input)
        {

            int n = input.Length;
            Stack stack = buildSortedStack(input);
            bool isFront = true;
            int start = 0;
            int end = n - 1;

            while (!stack.isEmpty())
            {

                if (isFront)
                {
                    input[start] = stack.pop();
                    start++;
                }
                else
                {
                    input[end] = stack.pop();
                    end--;
                }

                isFront = !isFront;

            }

        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static Stack buildSortedStack(int[] input)
        {
            int size = input.Length;

            if (size == 0)
            {
                return null;

            }

            // Stack1 will maintain the elements is decending order.
            Stack stack1 = new Stack(size);
            Stack stack2 = new Stack(size);

            stack1.push(input[0]);

            for (int i = 1; i < size; i++)
            {
                if (stack1.peek() < input[i])
                {
                    // Push the element onto Stack 1.
                    stack1.push(input[i]);
                }
                else
                {
                    // Keeping pushing the elements from stack1 to stack2 as long as 
                    // top of Stack1 is greater than input element under question.
                    while (!stack1.isEmpty() && stack1.peek() > input[i])
                    {
                        int value = stack1.pop();
                        stack2.push(value);
                    }

                    // Add the element in question to stack1.
                    stack1.push(input[i]);

                    // Then, move all the elements from stack 2 back to stack1
                    while (!stack2.isEmpty())
                    {
                        int value = stack2.pop();
                        stack1.push(value);
                    }
                }

            }

            return stack1;
        }

        

        public static Result MSSDP(int[] arr)
        {

            if (arr == null || arr.Length == 0)
            {
                return null;
            }

            if (arr.Length == 1)
            {
                return new Result(0, 0, arr[0]);
            }

            Result currMSS = new Result(0, 0, arr[0]);
            Result maxMSS = new Result(0, 0, arr[0]);;

            for (int i = 1; i < arr.Length; i++)
            {
                if (currMSS.sum + arr[i] > arr[i])
                {
                    currMSS.sum = currMSS.sum + arr[i];
                    currMSS.end = i;
                }
                else
                {
                    currMSS.sum = arr[i];
                    currMSS.start = i;
                }

                if (currMSS.sum > maxMSS.sum)
                {
                    maxMSS.start = currMSS.start;
                    maxMSS.end = currMSS.end;
                    maxMSS.sum = currMSS.sum;
                }
            }

            return maxMSS;
        }

    }
}

