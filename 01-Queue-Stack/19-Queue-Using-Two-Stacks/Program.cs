using System;
using System.Collections.Generic;

namespace Queue_Using_Two_Stacks
{
    class MyQueue
    {
        private Stack<int> inputStack = new Stack<int>();
        private Stack<int> outputStack = new Stack<int>();

        public int Count
        {
            get { return inputStack.Count + outputStack.Count; }
        }

        private void MoveInputToOutputStack()
        {
            while (inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }

        public void Enqueue(int value)
        {
            inputStack.Push(value);
        }

        public int Dequeue()
        {
            if (outputStack.Count == 0)
            {
                MoveInputToOutputStack();
            }

            if (outputStack.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return outputStack.Pop();
        }

        public int Peek()
        {
            if (outputStack.Count == 0)
            {
                MoveInputToOutputStack();
            }

            if (outputStack.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return outputStack.Peek();
        }

        public bool IsEmpty()
        {
            return inputStack.Count == 0 && outputStack.Count == 0;
        }

    }

    class Program
    {

        static void Main()
        {
            MyQueue queue = new MyQueue();

            Console.WriteLine("Is Empty: " + queue.IsEmpty());

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Is Empty: " + queue.IsEmpty());
            Console.WriteLine("Count: " + queue.Count);
            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Count: " + queue.Count);
            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Count: " + queue.Count);
            Console.WriteLine("Is Empty: " + queue.IsEmpty());

            // This will throw an exception
            try
            {
                Console.WriteLine("Dequeue: " + queue.Dequeue());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadKey();
        }
    }
}

