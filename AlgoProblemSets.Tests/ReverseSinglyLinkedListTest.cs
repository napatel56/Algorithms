using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoProblemSets;

namespace AlgoProblemSets.Tests
{
    [TestClass]
    public class ReverseSinglyLinkedListTest
    {
        [TestMethod]
        public void ReverseLinkedList()
        {
            Node<int> head = null;
            
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            Node<int> Node1 = new Node<int>(2,null);
            Node<int> Node2 = new Node<int>(4,null);
            Node<int> Node3 = new Node<int>(7,null);
            Node<int> Node4 = new Node<int>(9,null);
            Node<int> Node5 = new Node<int>(11,null);

            head = list.InsertNode(head, Node1);
            head = list.InsertNode(head, Node2);
            head = list.InsertNode(head, Node3);
            head = list.InsertNode(head, Node4);
            head = list.InsertNode(head, Node5);

            list.PrintLinkedList(head);
            head = list.ReverseLinkedList(head);
            list.PrintLinkedList(head);

            
        }


        [TestMethod]
        public void ReverseLinkedListRecursion()
        {
            Node<int> head = null;

            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            Node<int> Node1 = new Node<int>(2, null);
            Node<int> Node2 = new Node<int>(4, null);
            Node<int> Node3 = new Node<int>(7, null);
            Node<int> Node4 = new Node<int>(9, null);
            Node<int> Node5 = new Node<int>(11, null);

            head = list.InsertNode(head, Node1);
            head = list.InsertNode(head, Node2);
            head = list.InsertNode(head, Node3);
            head = list.InsertNode(head, Node4);
            head = list.InsertNode(head, Node5);

            list.PrintLinkedList(head);
            head = list.ReverseLinkedListRecursion(head);
            list.PrintLinkedList(head);
                        
        }

        [TestMethod]
        public void ReversePairLinkedListTest()
        {
            Node<int> head = null;

            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            Node<int> Node1 = new Node<int>(2, null);
            Node<int> Node2 = new Node<int>(4, null);
            Node<int> Node3 = new Node<int>(7, null);
            Node<int> Node4 = new Node<int>(9, null);
            Node<int> Node5 = new Node<int>(11, null);
            Node<int> Node6 = new Node<int>(13, null);

            head = list.InsertNode(head, Node1);
            head = list.InsertNode(head, Node2);
            head = list.InsertNode(head, Node3);
            head = list.InsertNode(head, Node4);
            head = list.InsertNode(head, Node5);
            head = list.InsertNode(head, Node6);

            list.PrintLinkedList(head);
            head = list.ReversePairLinkedList(head);
            list.PrintLinkedList(head);
                        
        }

        [TestMethod]
        public void ReverseKGroupLinkedListTest()
        {
            Node<int> head = null;

            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            Node<int> Node1 = new Node<int>(2, null);
            Node<int> Node2 = new Node<int>(4, null);
            Node<int> Node3 = new Node<int>(7, null);
            Node<int> Node4 = new Node<int>(9, null);
            Node<int> Node5 = new Node<int>(11, null);
            Node<int> Node6 = new Node<int>(12, null);
            Node<int> Node7 = new Node<int>(13, null);
            Node<int> Node8 = new Node<int>(14, null);
            Node<int> Node9 = new Node<int>(15, null);

            head = list.InsertNode(head, Node1);
            head = list.InsertNode(head, Node2);
            head = list.InsertNode(head, Node3);
            head = list.InsertNode(head, Node4);
            head = list.InsertNode(head, Node5);
            head = list.InsertNode(head, Node6);
            head = list.InsertNode(head, Node7);
            head = list.InsertNode(head, Node8);
            head = list.InsertNode(head, Node9);

            list.PrintLinkedList(head);
            head = list.GroupKReversal(head, 4);
            list.PrintLinkedList(head);

        }

        
    }
}
