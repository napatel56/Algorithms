using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{

    public class Stack
    {
        int top = -1;
        int size;
        int[] stack;

        public Stack(int capacity)
        {

            this.stack = new int[capacity];
            this.size = capacity;
        }

        public void push(int value) 
	    {
		    if(!isFull()) {
		
			    stack[++top] = value;
		
		    }
		    else
		    {
                throw new Exception("Stack is Full !");
		    }
	    }

        public int pop() 
	    {
            if(!isEmpty()) 
		    {
			    return stack[top--];
		
		    }
		    else
		    {
                throw new Exception("Stack is Empty !");
		    }
	    }

        public bool isEmpty()
        {
            return top == -1;
        }

        public bool isFull()
        {
            return top == size;
        }

        public int peek()
        {

            return stack[top];

        }

    }


}

