using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{
    public class ReorderArray
    {
        public static void ShuffleElements(int[] input)
        {

            int n = input.Length;
            StackMax stack1 = new StackMax(n);
            StackMax stack2 = new StackMax(n);
            
            for (int i = 0; i < n; i++)
            {
                Item newItem = new Item(input[i]);
                stack1.push(newItem);
            }

            int prevMax = int.MinValue;
            int start = 0;
            int end = n - 1;
            bool isFront = true;

            // Indicator to see how many times we are going to the loop.
            int operations=0;

            // Stack1 is used to extract the Maximum element and stack2 is used to maintain the elements placed in it's proper position.
            while (!stack1.isEmpty() || !stack2.isEmpty())
            {

                operations++;
                SelectStackForProcessing(ref stack1, ref stack2);

                Item item = stack1.pop();
                int max = item.Max;

                // If the element value is not the same as the Max value, then it means the current element 
                // is not the one that is placed in correct position. but it is the maximum in the stack that is placed in it's correct
                // position. Push the current element to stack2 for later processing.
                if (item.Data != max)
                {
                    item.Max = item.Data;
                    stack2.push(item);
                }

                // If PrevMax is not same as current max that means a new maximum has been identified.
                if (prevMax != max)
                {

                    // IsFront is used to flip the order of insertion of elements.
                    if (isFront)
                    {
                        input[start] = max;
                        start++;
                    }
                    else
                    {
                        input[end] = max;
                        end--;
                    }
                    isFront = !isFront;
                    prevMax = max;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Number of Operations " + operations.ToString());
        }

        /// <summary>
        /// Select the Stack that has the maximum element of the two stack for processing 
        /// and use the other stack to keep elements yet to be processed.
        /// </summary>
        /// <param name="stack1"></param>
        /// <param name="stack2"></param>
        private static void SelectStackForProcessing(ref StackMax stack1, ref StackMax stack2)
        {
            StackMax temp = null;

            if (!stack1.isEmpty() && !stack2.isEmpty())
            {
                Item item1 = stack1.peek();
                Item item2 = stack2.peek();

                // In case Stack 2 has the largest element then swap stack1 and stack2
                if (item1.Max < item2.Max)
                {
                    temp = stack1;
                    stack1 = stack2;
                    stack2 = temp;
                    
                }

            }

            else if (stack1.isEmpty() && !stack2.isEmpty())
            {
                temp = stack1;
                stack1 = stack2;
                stack2 = temp;
            }
            
        }

    }
}

