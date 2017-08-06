using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{
    public class Node<T> : IComparable<Node<T>>
    {
        private T data;
        public Node<T> Next { get; set; }

        public Node() { }

        public Node(T data) : this(data, null) { }

        public Node(T data, Node<T> newNode)
        {
            this.data = data;
            this.Next = newNode;
        }

        public T Item
        {
            get
            {
                return data;
            }
            set
            {
                this.data = value;
            }
        }

        public int CompareTo(Node<T> other)
        {
            return this.data.ToString().CompareTo(other.Item);
        }
    }
}
