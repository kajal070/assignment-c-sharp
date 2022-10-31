using System;

     public class StackException
    {
        public void full()
        {
            throw new StackOverflowException ("Stack is full.");
        }
        public void empty()
        {
            throw new InvalidOperationException ("The stack is empty");
        }
    }

    class Stack:StackException
    {
        private int[] ele;
        private int top;
        private int max;
        public Stack(int size)
        {
            ele = new int[size];
            top  = -1;
            max  = size;
        }

        public void push(int item)
        {
            if (top == max-1)
            {
               full();
                return;
            }
            else
            {
                ele[++top] = item;
            }
        }

        public int pop()
        { 
            if(top == -1)
            {
                empty();
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + ele[top]);
                return ele[top--];
            }
        }

        public void printStack()
        {
            if (top == -1)
            {
                empty();
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Stack S = new Stack(5);
            Console.WriteLine("Items are : ");
            S.push(23);
            S.printStack();

            S.pop();
            S.pop();
            S.pop();
        }
    }
            
            
            