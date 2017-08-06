using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    public class Node<T> : IComparable<Node<T>>
    {
            private T data;                // references the item.
            
            public Node() { }

            public Node(T data) : this(data,null,null) { }

            public Node(T data, Node<T> left, Node<T> right)
            {
                this.data = data;
                this.Left = left;
                this.Right = right;
            }

            public Node<T> Left { get; set; }
            
            public Node<T> Right {get; set;}

            public int Level { get; set; }
            public T Value
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

            /// <summary>

            public int CompareTo(Node<T> other)
            {
                return this.data.ToString().CompareTo(other.Value);
            }

            
      }
}
