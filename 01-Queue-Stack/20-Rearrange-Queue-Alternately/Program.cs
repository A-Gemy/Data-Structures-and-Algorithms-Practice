using System;
using System.Collections.Generic;

namespace Rearrange_Queue_Alternately
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

        private static bool RearrangeAlternately<T>(Queue<T> queue)
        {
            if (queue.Count % 2 != 0)
            {
                Console.WriteLine("Cannot rearrange an odd-sized queue alternately.");
                return false;
            }

            int halfSize = queue.Count / 2;
            Queue<T> firstHalf = new Queue<T>();
            Stack<T> stack = new Stack<T>();
            Queue<T> secondHalf = new Queue<T>();

            // Move the first half into a separate queue.
            for (int i = 0; i < halfSize; i++)
            {
                firstHalf.Enqueue(queue.Dequeue());
            }

            // Move the second half into a stack to reverse its order.
            for (int i = 0; i < halfSize; i++)
            {
                stack.Push(queue.Dequeue());
            }

            // Move the reversed second half into another queue.
            while (stack.Count > 0)
            {
                secondHalf.Enqueue(stack.Pop());
            }

            // Merge the two halves alternately back into the original queue.
            while (firstHalf.Count > 0)
            {
                queue.Enqueue(firstHalf.Dequeue());
                queue.Enqueue(secondHalf.Dequeue());
            }

            return true;
        }

        static void Main()
        {
            Queue<int> queue = BuildQueue(1, 6);
            Console.WriteLine("Original Queue: " + string.Join(", ", queue));

            if (RearrangeAlternately(queue))
            {
                Console.WriteLine("Rearranged Queue: " + string.Join(", ", queue));
            }


            Console.ReadKey();
        }
    }
}
