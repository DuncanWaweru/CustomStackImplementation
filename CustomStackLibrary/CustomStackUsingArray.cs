using CustomStackLibrary.interfaces;
using System;

namespace CustomStackLibrary
{
    public  class CustomStackUsingArray : ICustomStackUsingArray
    {
        //has the limititon of the need to define the size of the array
        readonly int MAX;//= 1000; //holds the size of the array/stack for now I have limited it to 1000.
        int top = -1;//this helps in identifying the latest item. -1 means the stack is empty. 
        object[] stack; //= new object[1000];//meant to hold all the data in the array/ Stack
        public  bool IsEmpty()
        {
            return (top < 0);
        }

        public int Size()
        {
            Console.WriteLine($"Stack has {top + 1} items.");
            return top + 1;
        }
        public CustomStackUsingArray(int v) //default constructor
        {
            top = -1;
            MAX = v;
            stack= new object[v];
        }
        public bool Push(object  data)
        {
            if ((top+1)>= MAX)
            {
                Console.WriteLine("Stack is full.");
                return false;
            }
            else
            {
                stack[++top] = data;
                Console.WriteLine($"{data} added to stack.");
                return true;
            }
        }


        public object Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return null;//throw new Exception("Stack is empty.");
            }
            else
            {
               
                var data = stack[top--];
                Console.WriteLine($"{data} removed from stack.");
                return data;
               
            }
        }

        public object Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return null;//throw new Exception("Stack is empty.");
            }
            else
            {
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
                return stack[top];
            }
                
           // return null;//throw new Exception("Stack is empty.");
        }

        public void Clear()
        {
            Array.Clear(stack, 0, stack.Length);
            top = -1;
            Console.WriteLine("Stack has been cleared");
            PrintStack();
        }
        public void PrintStack()
        {

            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
