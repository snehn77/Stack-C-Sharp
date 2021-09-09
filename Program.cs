using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a stack of size 10. (Note - You can change the size of stack as per your need)
            // For this question have taken a stack that can take only integers.
            MyStack myStack = new MyStack(10);
            int flag = 0,element;

        redo:
            Console.Clear();
            ShowOptions();
            int choice = Choice();
            while (flag == 0)
            {
                switch (choice)
                {
                    case 1:
                        element = GetValue();
                        myStack.Push(element);
                        PressToContinue();
                        goto redo;

                    case 2:
                        myStack.Pop();
                        PressToContinue();
                        goto redo;

                    case 3:
                        myStack.Peek();
                        PressToContinue();
                        goto redo;

                    case 4:
                        element = GetValue();
                        Console.WriteLine(myStack.Contains(element));
                        PressToContinue();
                        goto redo;

                    case 5:
                        Console.WriteLine("\nSize is: " + myStack.Size());
                        PressToContinue();
                        goto redo;

                    case 6:
                        myStack.Reverse();
                        PressToContinue();
                        goto redo;

                    case 7:
                        myStack.Iterator();
                        PressToContinue();
                        goto redo;

                    case 8:

                        myStack.Print();
                        PressToContinue();
                        goto redo;
                    // Case to exit the application
                    case 0:
                        flag = 1;
                        break;
                }
            }
        }
        // Displaying operations
        public static void ShowOptions()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 0 ---> Exit");
            Console.WriteLine("Press 1 ---> Push Element");
            Console.WriteLine("Press 2 ---> Pop Element");
            Console.WriteLine("Press 3 ---> Peek");
            Console.WriteLine("Press 4 ---> Contains");
            Console.WriteLine("Press 5 ---> Size");
            Console.WriteLine("Press 6 ---> Reverse");
            Console.WriteLine("Press 7 ---> Iterator");
            Console.WriteLine("Press 8 ---> Print");
        }
        // To get choice of operation
        public static int Choice()
        {
        redo:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter Choice of Operation: ");
            int choice;
            try
            {
                choice = int.Parse(Console.ReadLine());
                while (choice < 0 || choice > 8)
                {
                    Console.Write("Please enter valid choice: ");
                    choice = int.Parse(Console.ReadLine());
                }
                return choice;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError Message: Invalid Type. Please enter a valid choice");
                Console.ForegroundColor = ConsoleColor.White;
                goto redo;
            }
        }
        // To get value
        public static int GetValue()
        {
        redo:
            try
            {
                Console.Write("\nEnter Value : ");
                int value = int.Parse(Console.ReadLine());
                return value;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid Type. Please enter a integer");
                Console.ForegroundColor = ConsoleColor.White;
                goto redo;
            }
        }

        public static void PressToContinue()
        {
            Console.WriteLine("\nPress Any Key to continue: ");
            Console.ReadKey();
        }
    }
}
