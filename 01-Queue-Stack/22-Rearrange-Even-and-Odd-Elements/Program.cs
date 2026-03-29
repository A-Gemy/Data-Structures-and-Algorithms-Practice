using System;
using System.Collections.Generic;

namespace Rearrange_Even_and_Odd_Elements
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

        private static void RearrangeEvenAndOdd(Queue<int> queue)
        {
            Queue<int> evenQueue = new Queue<int>();
            Queue<int> oddQueue = new Queue<int>();

            while (queue.Count > 0)
            {
                int number = queue.Dequeue();

                if (number % 2 == 0)
                    evenQueue.Enqueue(number);
                else
                    oddQueue.Enqueue(number);
            }

            while (evenQueue.Count > 0)
            {
                queue.Enqueue(evenQueue.Dequeue());
            }

            while (oddQueue.Count > 0)
            {
                queue.Enqueue(oddQueue.Dequeue());
            }
        }


        static void Main()
        {
            Queue<int> queue = BuildQueue(1, 6);
            Console.WriteLine("Original Queue: " + string.Join(", ", queue));

            RearrangeEvenAndOdd(queue);
            Console.WriteLine("Rearranged Queue: " + string.Join(", ", queue));


            Console.ReadKey();
        }
    }
}
