using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    /// <summary>
    /// Properties of Max Heap
    /// 1. Leaf Nodes are nothing but Tree with single node, and tree with One Node is by default either Max Heap or Min Heap.
    /// 2. Starting of Leaf Nodes in an zero-based index complete Binary Tree or almost complete Binary Tree = |n/2|.
    /// 3. Max Index of Non Leaf Node in an zero based index complete Binary Tree or almost complete Binary Tree = |n/2| - 1.
    /// 4. Starting of Leaf Nodes in an non-zero based index complete Binary Tree or almost complete Binary Tree = |n/2| + 1.
    /// 3. Max Index of Non Leaf Node in an non-zero based index complete Binary Tree or almost complete Binary Tree = |n/2| .
    /// </summary>
    public class MaxHeap
    {
        /// <summary>
        /// The heart of the Max Heapify algorithm is that right and left subtree are Max Heap. And the root element should be placed 
        /// at it's correct location.
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="root"></param>
        /// <param name="heapSize"></param>
        private void MaxHeapify(int[] elements, int root, int heapSize)
        {
            // Get the indexes of the Right and Left child of the given Root Node.
            int leftChildIndex = 2 * root + 1;
            int rightChildIndex = 2 * root + 2;
            int largestIndex = 0;

            // condition: leftChildIndex <= heapSize tests if there exists a Left Child to Root Node.
            if(leftChildIndex <= heapSize && elements[leftChildIndex] > elements[root])
            {
                largestIndex = leftChildIndex;
            }
            else
            {
                largestIndex = root;
            }

            // condition: rightChildIndex <= heapSize tests if there exists a Right Child to Root Node.
            if (rightChildIndex <= heapSize && elements[rightChildIndex] > elements[largestIndex])
            {
                largestIndex = rightChildIndex;
            }

            
            if(largestIndex != root)
            {
                // Heapify - Exchange the largest of the child nodes with the Root Node to satify the Heap property.
                int temp = elements[root];
                elements[root] = elements[largestIndex];
                elements[largestIndex] = temp;
                MaxHeapify(elements, largestIndex, heapSize);
            }
        }

        /// <summary>
        /// Build Max Heap iterates starting from Max Non Leaf Node to all the way upto Root Node.
        // Heap Size incase of zero based Binary Tree is one less than the length of Array (Array.Length -1).
        // Heap Size incase of non-zero based Binary Tree is the length of Array (Array.Length).
        /// </summary>
        /// <param name="elements"></param>
        public void BuildMaxHeap(int[] elements)
        {
            // 
            int heapSize = elements.Length - 1;
            int numElements = elements.Length;
            int MaxNonLeafIndex = Math.Abs(numElements/ 2) - 1;

            // iterate from Max Non Leaf Index Node to Root Node.
            for (int index = MaxNonLeafIndex; index >= 0; index--)
            {
                MaxHeapify(elements, index, heapSize); 
            }
        }

        /// <summary>
        /// Removes the Max element from the Max Heap and places the last element of the array 
        /// as the root node
        /// TIME COMPLEXITY of Extract Max from Heap is O(Log N) => Depth of the Tree. Because MaxHeapify 
        /// is called at the Root Node. The height of root Node is of order Log N.
        /// SPACE COMPLEXITY is O (Log N). Max Heapify function makes recursive call. In the worst case, the Max Heapify recursive calls
        /// will be  equal to the depth of the tree.
        /// </summary>
        /// <param name="elements">Represent Max Heap.</param>
        public int ExtractMax_Heap(int[] elements)
        {
            int heapSize = elements.Length - 1;
            
            // First element on a Max Heap is the element with Maximum value.
            int max = elements[0];

            // Place the last element of the Max Heap in the fist location (Root Node).
            elements[0] = elements[heapSize];
            // As the first element has been extracted the Array will be reduced by 1 element.
            //elements = elements.Take(elements.Length-1).ToArray();
            heapSize = heapSize - 1;

            MaxHeapify(elements, 0, heapSize);

            return max;
        }

       /// <summary>
       /// Given Max Heap and the index location of the Node whose key should be increased.
       /// Time Complexity: In worst case, we may start with increasing the Key of the Leaf Node and the Key floats up all
       /// the way upto the Heap Root so the Time Complexity of Increasing Key is O (Log n).
       /// </summary>
        /// <param name="elements">Array representation of Max Heap.</param>
       /// <param name="index">Index location of the element to be increased.</param>
       /// <param name="newValue">Represents teh new Value element [i] will hold.</param>
        public void Heap_Increase_Key(int[] elements, int i, int newValue)
        {
            if(newValue < elements[i])
            {
                throw new ArgumentException("New value (prority) is less than the existing value. Please validate the new value.");
            }

            // Assign the new value at the given Node Index 'i'
            elements[i] = newValue;
            
            int parent = Math.Abs((i-1)/2);

            while(i>0 && elements[parent] < elements[i])
            {
                // Swap Parent element with elements[i]
                int temp = elements[i];
                elements[i] = elements[parent];
                elements[parent] = temp;

                i = parent;
                parent = Math.Abs((i - 1) / 2);
            }
        }

        /// <summary>
        /// Decreasing the Key (Prority) and rebuilds the Max Heap.
        /// Time Complexity: In worst case, you try to decrease the key of the Heap Root and the new value moves all the way 
        /// to the Leaf Node so the Time Complexity will be O (Log n).
        /// </summary>
        /// <param name="elements">Array representation of Max Heap.</param>
        /// <param name="index">Index location of the element to be increased.</param>
        /// <param name="newValue">Represents teh new Value element [i] will hold.</param>
        public void Heap_Decrease_Key(int[] elements, int i, int newValue)
        {
            if (newValue > elements[i])
            {
                throw new ArgumentException("New value (prority) is greater than the existing value. Please validate the new value.");
            }

            int heapSize = elements.Length - 1;

            // Assign the new value at the given Node Index 'i'
            elements[i] = newValue;

            MaxHeapify(elements, i, heapSize);
        }

        public void HeapSort(int[] elements)
        {

        }
    }
}
