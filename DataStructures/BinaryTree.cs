using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public virtual void Clear()
        {
            Root = null;
        }

        public void Insert(Node<T> target, Node<T> newNode)
        {
            if(target.CompareTo(newNode) <= 0)
            { 
                if(target.Left == null)
                {
                    target.Left = newNode;
                }
                else
                {
                    Insert(target.Left, newNode);
                }
            }
            else
            {
                if(target.Right == null)
                {
                    target.Right = newNode;
                }
                else
                {
                    Insert(target.Right, newNode);
                }
            }




        }

        public void Delete(Node<T> dNode)
        {

        }

        /// Visit each Node before recursively vising its children, left to right. 
        /// Root is visited first.
        /// Time Complexity: This method is called for each Node in the Tree.Each node is 
        /// visited only once, so a preorder traversal takes O(n) time
        /// where n is the number of nodes in the Tree.
        /// </summary>
        public void PreOrderRecursiveImp(Node<T> root)
        {
            if (root == null)
                return;

            Visit(root);
            PreOrderRecursiveImp(root.Left);
            PreOrderRecursiveImp(root.Right);
        }

        /// <summary>
        /// Pre Order Traversal: Visits the node before visiting it's children.
        /// Iterative implementation utilizing Stack data structure.; 
        /// </summary>
        /// <param name="root">Represents the Root Node of the Binary Tree</param>
        public void PreOrderIterative(Node<T> root)
        {
            Stack<Node<T>> stack = new Stack<Node<T>>();
            Queue<Node<T>> qout = new Queue<Node<T>>();

            // Initialization step: Add the Root element to the Stack 
            // as it will be the first node to be visited.
            stack.Push(root);

            // Loop until the Stack is Empty.
            while (stack.Count > 0)
            {
                // Curr Node is the Top element in the Stack.
                Node<T> currNode = stack.Peek();

                // Add the Curr Node to the Queue;
                qout.Enqueue(currNode);

                stack.Pop();

                if (currNode.Right != null)
                {
                    stack.Push(currNode.Right);
                }

                if (currNode.Left != null)
                {
                    stack.Push(currNode.Left);
                }
            }

            Console.WriteLine("Pre order sequence of given Binary Tree is : ");
            while (qout.Count > 0)
            {
                Console.Write(qout.Peek().Value.ToString());
                qout.Dequeue();
            }
        }

        public void InOrderRecursiveImp()
        {

        }

        /// <summary>
        /// Post Order Traversal: Node is visited after vsisting Children nodesfrom Left to Right.
        /// Post Order traversal can be easily be done using Two Stacks. The idea is to push Reverse Pre Order Traversal to a Stack.
        /// 
        /// </summary>
        public void PostOrderIterImp(Node<T> root)
        {
            Stack<Node<T>> stack = new Stack<Node<T>>();
            Stack<Node<T>> sout = new Stack<Node<T>>();

            // Initialization step: Add the Root element to the Stack 
            // as it will be the first node to be visited.
            stack.Push(root);

            // Loop until the Stack is Empty.
            while (stack.Count > 0)
            {
                // Curr Node is the Top element in the Stack.
                Node<T> currNode = stack.Peek();

                // Add the Curr Node to the Queue;
                sout.Push(currNode);

                stack.Pop();

                if (currNode.Left != null)
                {
                    stack.Push(currNode.Left);
                }

                if (currNode.Right != null)
                {
                    stack.Push(currNode.Right);
                }
            }

            Console.WriteLine("Post order sequence of given Binary Tree is : ");
            while (sout.Count > 0)
            {
                Console.Write(sout.Peek().Value.ToString());
                sout.Pop();
            }
        }

        /// <summary>
        /// Node is visited after visiting Children nodes from Left to Right.
        /// </summary>
        public void PostOrderRecursiveImp()
        {

        }

        private void Visit(Node<T> node)
        {
            Console.Write(node.Value);
        }

        public Node<T> MirrorTree(Node<T> root) 
        {
            if(root == null) 
            {
		        return null;
	        }
	
	        Node<T> mirrorRoot = new Node<T>(root.Value);
            mirrorRoot.Right = MirrorTree(root.Left);
            mirrorRoot.Left = MirrorTree(root.Right);
	        
	
	        return mirrorRoot;
    
        }

        public void PrintAllRootToLeafPaths(Node<T> root)
        {
            List<Node<T>> path = new List<Node<T>>();

            PrintAllRootToLeafPaths(root, path);


        }

        private void PrintAllRootToLeafPaths(Node<T> root, List<Node<T>> path)
        {
            if (root == null)
            {
                return;
            }

            path.Add(root);

            if (root.Left == null && root.Right == null)
            {
                PrintPath(path);
            }
            else
            {
                PrintAllRootToLeafPaths(root.Left, path);
                PrintAllRootToLeafPaths(root.Right, path);
            }

            path.Remove(root);
    
        }

        private void PrintPath(List<Node<T>> path)
        {
            foreach (Node<T> node in path)
            {
                Console.WriteLine(node.Value);

            }
        }

        public void DeepestNode(Node<T> root)
        {

            if (root == null)
            {
                return;
            }
            

            Node<T> deepest = DeepestNode(root, 0 );

            Console.WriteLine(deepest.Value);
            Console.WriteLine(deepest.Level);

        }

        public void DeepestNodeWithMod(Node<T> root) {

	        if(root == null) {
		        return;
	        }
            MaximumLevel maxLevel = new MaximumLevel();
            maxLevel.Level = 0;

            Node<T> deepest = null;
            DeepestNodeNoModification(root, 0, maxLevel, ref deepest);

            Console.WriteLine(deepest.Value);
            Console.WriteLine(maxLevel.Level);
        
        }

        public class MaximumLevel
        {
            public int Level {get; set;}
        }

        private void DeepestNodeNoModification(Node<T> root, int level, MaximumLevel maxLevel, ref Node<T> deepest)
        {

            if (root == null)
            {
                return;
            }

            if (root.Left == null && root.Right == null & maxLevel.Level < level)
            {
                maxLevel.Level = level;
                deepest = root;
            }

            DeepestNodeNoModification(root.Left, level + 1, maxLevel, ref deepest);
            DeepestNodeNoModification(root.Right, level + 1, maxLevel, ref deepest);
        }

        private Node<T> DeepestNode(Node<T> root, int level)
        {

            if (root == null)
            {
                return null;
            }

            root.Level = level;

            if (root.Left == null && root.Right == null)
            {
                return root;
            }

            Node<T> deepestL = DeepestNode(root.Left, level + 1);
            Node<T> deepestR = DeepestNode(root.Right, level + 1);

            Node<T> deepest = null;

            if (deepestL != null && deepestR != null)
            {

                if (deepestL.Level > deepestR.Level)
                {
                    deepest = deepestL;
                }
                else
                    deepest = deepestR;
            }
            else if (deepestL != null)
            {
                deepest = deepestL;
            }
            else
            {
                deepest = deepestR;
            }

            return deepest;
        }



        public void DeepestLeftNode(Node<T> root)
        {

            if (root == null)
            {
                return;
            }

            Node<T> deepest = DeepestLeftNode(root, 0, false);

            Console.WriteLine(deepest.Value);
            Console.WriteLine(deepest.Level);

        }

        private Node<T> DeepestLeftNode(Node<T> root, int level, bool isLeftSubtree)
        {

            if (root == null)
            {
                return null;
            }

            root.Level = level;

            if (isLeftSubtree && root.Left == null && root.Right == null)
            {
                return root;
            }
            

            Node<T> deepestL = DeepestLeftNode(root.Left, level + 1, true);
            Node<T> deepestR = DeepestLeftNode(root.Right, level + 1, false);

            Node<T> deepest = null;

            if (deepestL != null && deepestR != null)
            {

                if (deepestL.Level > deepestR.Level)
                {
                    deepest = deepestL;
                }
                else
                    deepest = deepestR;
            }
            else if (deepestL != null)
            {
                deepest = deepestL;
            }
            else
            {
                deepest = deepestR;
            }

            return deepest;
        }


        public int NodeCountAtLevel(Node<T> root, int level)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();
            NodeCountAtLevel(root, 0, map);
            int count = -1;

            if (map.ContainsKey(level))
            {
                count = map[level];
            }

            return count;
        }

        private void NodeCountAtLevel(Node<T> root, int level, Dictionary<int, int> map)
        {

            if (root == null)
            {
                return;
            }

            if (map.ContainsKey(level))
            {
                map[level] = map[level] + 1;
            }
            else
            {
                map[level] = 1;
            }


            NodeCountAtLevel(root.Left, level + 1, map);
            NodeCountAtLevel(root.Right, level + 1, map);

        }


        public void PrintNodesAtLevel(Node<int> root, int level, int d)
        {

            if (root == null)
            {
                return;
            }

            if (level == d)
            {
                Console.WriteLine(root.Value);
                return;
            }

            PrintNodesAtLevel(root.Left, level + 1, d);
            PrintNodesAtLevel(root.Left, level + 1, d);
        }

        public void PrintNodesAtLevel(Node<int> root, int d)
        {

            PrintNodesAtLevel(root, 0, d);

        }
      
    }
}
