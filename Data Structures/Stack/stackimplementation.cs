// Implementing Stack in C#
// Stack is a linear data structure. It follows LIFO (Last In First Out) pattern for Input/output.
// Following three basic operations are performed in the stack:
// 1.Push: Adds an item in the stack. If the stack is full, then it is said to be a stack Overflow condition.
// 2.Pop: Removes an item from the stack. The items are popped in the reversed order in which they are pushed.If the stack is empty, then it is said to be a stack Underflow condition.
// 3.Peek: Return the topmost element of stack.
// Study in-depth about stack data structure and operations using resources available online, and then implement stack and it's 3 basic operations listed above using arrays in C#.

using System;

namespace stackimplementation 
{
    internal class Stack 
    {
        int i;
        static readonly int max = 100;
        int top;
        int[] stack = new int[max];

        bool IsEmpty () 
        {
            return (top < 0);
        }
        public Stack () 
        {
            top = -1;
        }
        internal bool Push (int data) 
        {
            if (top >= max) 
            {
                Console.WriteLine ("Stack Overflow");
                return false;
            } else 
            {
                top = top + 1;
                stack[top] = data;
                return true;
            }
        }

        internal int Pop () 
        {
            if (top < 0) 
            {
                Console.WriteLine ("Stack Underflow");
                return 0;
            } 
            else 
            {
                 int value = stack[top];
                 top = top - 1;
                 return value;
            }
        }

        internal void Peek () 
        {
            if (top < 0) 
            {
                Console.WriteLine ("Stack Underflow");
                return;
            } else
                Console.WriteLine ("\n=> The Topmost Element of Stack is : {0}", stack[top]);
        }

        internal void PrintStack () 
        {
            if (top < 0) 
            {
                Console.WriteLine ("Stack Underflow");
                return;
            } 
            else 
            {
                Console.WriteLine ("\nItems in the Stack are :");
                Console.WriteLine ("------------------------");
                for (i = top; i >= 0; i--) 
                {
                    Console.WriteLine (stack[i]);
                }
            }
        }
    }
    public class Program 
    {
        public static void Main (string[] args) 
        {
            Stack myStack = new Stack ();
            myStack.Push (12);
            myStack.Push (21);
            myStack.Push (34);
            myStack.Push (43);
            myStack.Push (56);
            myStack.Push (65);
            myStack.PrintStack ();
            myStack.Peek ();
            Console.WriteLine ("\n=> Item Popped from Stack : {0}", myStack.Pop ());
            myStack.PrintStack ();
        }
    }
}