using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProblemSets
{

    public class StackMax {

        int top =-1;
        int size;
        Item[] stack;
                
        public StackMax (int capacity) {
            stack = new Item[capacity];                
            size = capacity;
        }
                
        public void push (Item newItem) {

            if (isEmpty())
            {
                stack[++top] = newItem;
        
            }
            else if(!isFull()) 
            {
                Item item = peek();
                                                
                if(item.Max < newItem.Data) 
                {
                    newItem.Max = newItem.Data;
                }
                else 
                {
                    newItem.Max = item.Max;
                }
                stack[++top] = newItem;
                                
            }
            else {
                throw new Exception("Stack is full !");
            }
        }
                
        public Item peek() {
                
            if(!isEmpty()) 
            {
                return stack[top];
                                
            }
            else 
            {
                throw new Exception("Stack is Empty");
            }
               
        }

        public Item pop() {
                
            if(!isEmpty()) 
            {
                return stack[top--];
            }
            else 
            {
                throw new Exception("Stack is Empty");
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

    }
}

