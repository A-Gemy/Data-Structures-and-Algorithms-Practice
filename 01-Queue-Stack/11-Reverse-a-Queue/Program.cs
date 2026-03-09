using System;
using System.Collections.Generic;

namespace Reverse_a_Queue
{
    class Program
    {
        private static Queue<int> BuildQueue(int from, int to)
        {
            Queue<int> queue = new Queue<int>();

            for (int i = from; i <= to; i++)
            {
                queue.Enqueue(i);
            }

            return queue;
        }

        private static void ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }


        static void Main()
        {
            Queue<int> queue = BuildQueue(1, 5);
            Console.WriteLine("Original Queue: " + string.Join(", ", queue));

            ReverseQueue(queue);
            Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));


            Console.ReadKey();
        }

    }
}
