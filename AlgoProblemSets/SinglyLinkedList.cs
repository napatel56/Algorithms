using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{
    public class SinglyLinkedList<T>
    {
        public Node<T> InsertNode(Node<T> head, Node<T> node)
        {
            if (head == null)
                return node;

            Node<T> current = head;

            while(current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;

            return head;
        }

        /// <summary>
        /// Reverses Singly Linked List.
        /// At Each Step, we want to reverse the link so we want to make the pointer to point
        /// to previous Node instead of the Next Node.
        /// </summary>
        /// <param name="head">Reference to the start of the Singly Linked List</param>
        /// <returns></returns>
        public Node<T> ReverseLinkedList(Node<T> head)
        {
            Node<T> curr = head;
            Node<T> prev = null;
            Node<T> next = null;

            while(curr != null)
            {
                // Retain the Next Object in a another varaible called Next;
                next = curr.Next;
                
                // Establish a link between Current Node and the Prev Node
                curr.Next = prev;
                
                prev = curr;
                curr = next;
            }
            // At the end of the loop:
            // curr will be NULL;
            // next will be NULL;
            // Prev will have the Last element.

            // Update head to the Prev .
            head = prev;

            return head;
        }

        /// <summary>
        /// Recursive Implementation
        /// </summary>
        /// <param name="head">Reference to the start of the Singly Linked List</param>
        /// <returns></returns>
        public Node<T> ReverseLinkedListRecursion(Node<T> head)
        {
            if (head == null)
                return null;

            Node<T> first = head;
            Node<T> rest = head.Next;

            if (rest == null) 
                return head;

            Node<T> reversedList = ReverseLinkedListRecursion(rest);

            first.Next.Next = first;
            first.Next = null;

            return reversedList;
        }
        
        public void PrintLinkedList(Node<T> head)
        {
            while(head != null)
            {
                Console.Write(head.Item.ToString() + '\t');
                head = head.Next;
            }

            Console.Write('\n');
        }

        /// <summary>
        /// Pairwise reversal of Nodes in a given Linked List.
        /// </summary>
        /// <param name="head">Refernces the staring Node of the given Linked List.</param>
        /// <returns>Returns the Head of the New formed Pairwise reversed Linked List.</returns>
        public Node<T> ReversePairLinkedList(Node<T> head)
        {
            // Base condition:
            // An Empty linked List or a one element linked list is already reversed. 
            if (head == null || head.Next == null)
                return head;

            Node<T> firstNode = head;
            Node<T> secondNode = head.Next;

            // Pass the first element of the next pair of the Nodes to follow.
            Node<T> newHead = ReversePairLinkedList(secondNode.Next);

            // Adjust the links to reverse the Nodes.
            secondNode.Next = firstNode;
            firstNode.Next = newHead;
            
            // New Head post to reversing the elements.
            // Always the second Node will become the first element after reversal so
            // the new Head will be Second Node.
            return secondNode;
        }

        public Node<T> GroupKReversal(Node<T> head, int k)
        {

            if (head == null)
            {
                return null;
            }

            if (head.Next == null)
            {
                return head;
            }

            Node<T> current = head;
            Node<T> prev = null;
            Node<T> next = null;

            int count = 1;

            while (current != null & count <= k)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
                count++;
            }

            Node<T> newHead = GroupKReversal(current, k);
            head.Next = newHead;

            return prev;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">Target References the destination.</param>
        /// <param name="source">Source References the Source List.</param>
        public void MoveNode(ref Node<T> target,ref Node<T> source)
        {
            // the front source Node.
            Node<T> newNode = source;

            //advance the source node.
            source = newNode.Next;

            newNode.Next = target;
            target = newNode;
        }


        public Node<int> MiddleNode(Node<int> head)
        {

            if (head == null)
            {
                return null;
            }

            if (head.Next == null)
            {
                return head;
            }

            Node<int> slow = head;
            Node<int> fast = head.Next;

            while (fast != null && fast.Next != null)
            {

                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;

        }


        public Node<int> MergeSort(Node<int> head)
        {

            if (head == null || head.Next == null)
            {
                return head;
            }

            Node<int> middle = MiddleNode(head);
            Node<int> backRef = middle.Next;
            middle.Next = null;

            Node<int> leftHead = MergeSort(head);
            Node<int> rightHead = MergeSort(backRef);

            return SortedMerge(leftHead, rightHead);

        }

        private Node<int> SortedMerge(Node<int> leftHead, Node<int> rightHead)
        {
            if (leftHead == null && rightHead == null)
            {
                return null;
            }

            if (leftHead == null && rightHead != null)
            {

                return rightHead;
            }

            if (leftHead != null && rightHead == null)
            {

                return leftHead;
            }

            Node<int> sorted = leftHead;
            Node<int> curr1 = leftHead;
            Node<int> curr2 = rightHead;
            Node<int> newHead = null;

            if (curr1.Item <= curr2.Item)
            {
                sorted = curr1;
                curr1 = sorted.Next;
            }
            else
            {
                sorted = curr2;
                curr2 = sorted.Next;
            }

            newHead = sorted;

            while (curr1 != null && curr2 != null)
            {
                if (curr1.Item <= curr2.Item)
                {
                    sorted.Next = curr1;
                    sorted = curr1;
                    curr1 = sorted.Next;
                }
                else
                {
                    sorted.Next = curr2;
                    sorted = curr2;
                    curr2 = sorted.Next;
                }

            }

            if (curr1 == null)
            {
                sorted.Next = curr2;
            }

            if (curr2 == null)
            {
                sorted.Next = curr1;
            }

            return newHead;
        }
    }
}