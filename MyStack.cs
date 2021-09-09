using System;
using System.Collections.Generic;

namespace Stack
{
    class MyStack
    {
        private int StackSize;    
        public int top;
        // Implementing stack using Array
        Object[] stack;

        // Default constructor is called taking in the size of stack as parameter
        public MyStack(int SizeOfStack)
        {
            stack = new Object[SizeOfStack];
            StackSize = SizeOfStack;
            top = -1;
        }


        public void Push(object element)
        {
            // Condition for if stack is full
            if (top == (StackSize - 1))
            {
                Console.WriteLine("\nStack Overflow");
            }
            // If not full insert
            else
            {
                stack[++top] = element;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nItem pushed successfully!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Pop()
        {
            // Check if stack is empty
            if (top == -1)
            {
                Console.WriteLine("\nStack is empty!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nItem Poped successfully!");
                stack[top--] = null;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Peek()
        {
            // Check if Stack is empty
            if (top == -1)
            {
                Console.WriteLine("\nStack is empty!");
            }
            // If not empty return the top element
            else
            {
                Console.WriteLine("\nTop Element is: "+ stack[top]); 
            }
        }

        public int Size()
        {
            int count = 0;
            // If Stack is empty return size = 0
            if (top == -1)
            {
                return 0;
            }
            for (int i = top; i > -1; i--)
            {
                count = count + 1;
            }
            return count;
        }

        public bool Contains(object element)
        {
            Console.WriteLine();
            // Is Stack empty return false
            if (top == -1)
            {
                return false;
            }
            // If element in stack return true
            for (int i = top; i > -1; i--)
            {
                if (stack[i].Equals(element))
                {
                    return true;
                }
            }
            // For all other conditions return false
            return false;
        }

        public void Reverse()
        {
            // Stack is empty
            if (top == -1)
            {
                Console.WriteLine("\nStack is empty!");
                return ;
            }

            object[] reverseStack = new Object[Size()];
            int count = 0;
            for (int i = top; i > -1; i--)
            {
                reverseStack[count] = stack[i];
                count += 1;
            }
            for(int i = 0; i < Size(); i++)
            {
                stack[i] = reverseStack[i];
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nStack Reversed Successfully!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // This method gives Iterated List form the starting index of element using IEnumerable and yeild return
        public void Iterator()
        {
            
            if (top == -1)
            {
                Console.WriteLine("\nStack is empty!");
                return;
            }


            IEnumerable<object> myStack = GetIteratedStack();
            Console.WriteLine("\nIterated Stack is: ");
            foreach (var i in myStack)
            {
                if (i != null)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public IEnumerable<object> GetIteratedStack()
        {
            foreach (var items in stack)
            {
                // Returning the element after every iteration
                yield return items;
            }
        }

        public void Print()
        {
            Console.WriteLine();
            if (top == -1)
            {
                Console.WriteLine("\nStack is Empty");
                return ;
            }
            for (int i = top; i > -1; i--)
            {                
              Console.WriteLine("Item {0}: {1}", (i + 1), stack[i]);                
            }
        }
    }


    
}
