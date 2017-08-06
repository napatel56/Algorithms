using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datastructures;

namespace DataStructures.Test
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        public void PreOrderRecursiveTest()
        {
            Node<int> root =ConstructBinaryTree();
            BinaryTree<int> traversal = new BinaryTree<int>();
            traversal.PreOrderRecursiveImp(root);
        }


        [TestMethod]
        public void PreOrderIterTest()
        {
            Node<int> root = ConstructBinaryTree();
            BinaryTree<int> traversal = new BinaryTree<int>();
            traversal.PreOrderIterative(root);
        }

        [TestMethod]
        public void PostOrderIterTest()
        {
            Node<int> root = ConstructBinaryTree();
            BinaryTree<int> traversal = new BinaryTree<int>();
            traversal.PostOrderIterImp(root);
        }

        [TestMethod]
        public void PrintAllPathsTest()
        {
            Node<int> root = ConstructBinaryTreeV1(); // ConstructBinaryTree();
            BinaryTree<int> traversal = new BinaryTree<int>();
            traversal.PrintAllRootToLeafPaths(root);
        }

        [TestMethod]
        public void MirrorTreeTest()
        {
            Node<int> root = ConstructBinaryTree(); // ConstructBinaryTree();
            BinaryTree<int> traversal = new BinaryTree<int>();
            traversal.PreOrderRecursiveImp(root);
            Console.WriteLine();
            Node<int> mirrorRoot  = traversal.MirrorTree(root);
            traversal.PreOrderRecursiveImp(mirrorRoot);
            
        }

        [TestMethod]
        public void DeepestNodeTest()
        {
            Node<int> root = ConstructBinaryTree(); // ConstructBinaryTree();
            BinaryTree<int> traversal = new BinaryTree<int>();
            //traversal.DeepestNode(root);
            Console.WriteLine();
            

        }


        [TestMethod]
        public void NodesAtLevelTest()
        {
            Node<int> root = ConstructBinaryTree(); // ConstructBinaryTree();
            BinaryTree<int> traversal = new BinaryTree<int>();
            traversal.PrintNodesAtLevel(root, 2);
            Console.WriteLine();


        }
        [TestMethod]
        public void NodeCountAtLevelTest()
        {
            Node<int> root = ConstructBinaryTree(); // ConstructBinaryTree();
            BinaryTree<int> traversal = new BinaryTree<int>();
            int count = traversal.NodeCountAtLevel(root, 2);
            Console.WriteLine(count.ToString());
            

        }
        

        [TestMethod]
        public void DeepestNodeNoModeTest()
        {
            Node<int> root = ConstructBinaryTree(); // ConstructBinaryTree();
            BinaryTree<int> traversal = new BinaryTree<int>();
            traversal.DeepestNodeWithMod(root);
            Console.WriteLine();


        }

        [TestMethod]
        public void DeepestLeftNodeTest()
        {
            Node<int> root = ConstructBinaryTree(); // ConstructBinaryTree();
            BinaryTree<int> traversal = new BinaryTree<int>();
            traversal.DeepestLeftNode(root);
            Console.WriteLine();


        }

        private Node<int> ConstructBinaryTree()
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new Node<int>(1);
            btree.Root.Left = new Node<int>(2);
            btree.Root.Left.Left = new Node<int>(10);
            btree.Root.Left.Right = new Node<int>(11);
            btree.Root.Right = new Node<int>(3);

            btree.Root.Right.Right = new Node<int>(4);
            btree.Root.Right.Left = new Node<int>(5);
            btree.Root.Right.Right.Left = new Node<int>(12);

            btree.Root.Right.Right.Right = new Node<int>(6);
            //btree.Root.Right.Right.Right = new Node<int>(7);

            btree.Root.Right.Right.Right.Right = new Node<int>(8);

            return btree.Root;
        }

        private Node<int> ConstructBinaryTreeV1()
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new Node<int>(1);
            btree.Insert(btree.Root,new Node<int>(2));
            btree.Insert(btree.Root, new Node<int>(3));
            btree.Insert(btree.Root, new Node<int>(4));
            btree.Insert(btree.Root, new Node<int>(5));
            btree.Insert(btree.Root, new Node<int>(6));
            btree.Insert(btree.Root, new Node<int>(7));
            btree.Insert(btree.Root, new Node<int>(8));
            
            return btree.Root;
        }
    }
}
