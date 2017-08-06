using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AlgoProblemSets;

namespace AlgoProblemSets.Tests
{
    [TestClass]
    public class SinglyLinkedListTest
    {
        [TestMethod]
        public void MoveNodeTest()
        {
            Node<int> source = null;

            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            Node<int> Node1 = new Node<int>(2, null);
            Node<int> Node2 = new Node<int>(4, null);
            Node<int> Node3 = new Node<int>(7, null);

            source = list.InsertNode(source, Node1);
            source = list.InsertNode(source, Node2);
            source = list.InsertNode(source, Node3);

            Node<int> target = null;
            SinglyLinkedList<int> secondList = new SinglyLinkedList<int>();

            Node<int> Node4 = new Node<int>(9, null);
            Node<int> Node5 = new Node<int>(11, null);
            Node<int> Node6 = new Node<int>(10, null);

            target = secondList.InsertNode(target, Node4);
            target = secondList.InsertNode(target, Node5);

            list.PrintLinkedList(source);
            list.PrintLinkedList(target);

            list.MoveNode(ref target, ref source);
            list.PrintLinkedList(target);
            list.PrintLinkedList(source);

        }

        [TestMethod]
        public void method1()
        {
            LinkedList<int>[] adjacencyList = new LinkedList<int>[5];

            for (int i = 0; i < 5; i++)
            {
                adjacencyList[i] = new LinkedList<int>();
            }

            adjacencyList[0].AddFirst(1);
            adjacencyList[1].AddFirst(2);
            adjacencyList[2].AddFirst(3);
            adjacencyList[3].AddFirst(0);
        }

        [TestMethod]
        public void TestSorting()
        {
            Node<int> source = null;

            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            Node<int> Node1 = new Node<int>(2, null);
            Node<int> Node2 = new Node<int>(4, null);
            Node<int> Node3 = new Node<int>(7, null);
            Node<int> Node4 = new Node<int>(3, null);
            Node<int> Node5 = new Node<int>(1, null);
            Node<int> Node6 = new Node<int>(8, null);
            Node<int> Node7 = new Node<int>(5, null);
            //Node<int> Node4 = new Node<int>(3, null);

            source = list.InsertNode(source, Node1);
            source = list.InsertNode(source, Node2);
            source = list.InsertNode(source, Node3);
            source = list.InsertNode(source, Node4);
            source = list.InsertNode(source, Node5);
            source = list.InsertNode(source, Node6);
            source = list.InsertNode(source, Node7);

            list.PrintLinkedList(source);

            Node<int> newhead = list.MergeSort(source);

            list.PrintLinkedList(newhead);
        }
    }
}
