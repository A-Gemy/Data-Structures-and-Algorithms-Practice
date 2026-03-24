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

        private static Queue<T> RearrangeAlternatelyWithList<T>(Queue<T> queue)
        {
            List<T> list = new List<T>(queue);
            Queue<T> result = new Queue<T>();
            int count = list.Count;

            // Take one element from the beginning, then one from the end.
            for (int i = 0; i < count / 2; i++)
            {
                result.Enqueue(list[i]);
                result.Enqueue(list[count - i - 1]);
            }

            // If the queue has an odd number of elements, add the middle one at the end.
            if (count % 2 != 0)
            {
                result.Enqueue(list[count / 2]);
            }

            return result;
        }


        static void Main()
        {
            Queue<int> queue = BuildQueue(1, 6);
            Console.WriteLine("Original Queue: " + string.Join(", ", queue));

            if (RearrangeAlternately(queue))
            {
                Console.WriteLine("Rearranged Queue using Queue and Stack: " + string.Join(", ", queue));
            }

            Queue<int> queue2 = BuildQueue(1, 6);
            Queue<int> rearrangedQueue = RearrangeAlternatelyWithList(queue2);
            Console.WriteLine("Rearranged Queue using List: " + string.Join(", ", rearrangedQueue));


            Console.ReadKey();
        }
    }
}
