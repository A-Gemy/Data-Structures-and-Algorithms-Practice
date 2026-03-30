using System;
using System.Collections.Generic;

namespace Clone_a_Queue_Without_Extra_Space
{
    class Program
    {
        private static Queue<int> BuildQueue(params int[] numbers)
        {
            Queue<int> queue = new Queue<int>();

            foreach (int number in numbers)
            {
                queue.Enqueue(number);
            }

            return queue;
        }

        private static void CloneQueueRecursive(Queue<int> originalQueue, Queue<int> cloneQueue, int count)
        {
            if (count == 0)
                return;

            int front = originalQueue.Dequeue();

            cloneQueue.Enqueue(front);
            originalQueue.Enqueue(front);

            CloneQueueRecursive(originalQueue, cloneQueue, count - 1);
        }

        private static Queue<int> CloneQueue(Queue<int> originalQueue)
        {
            Queue<int> cloneQueue = new Queue<int>();

            CloneQueueRecursive(originalQueue, cloneQueue, originalQueue.Count);

            return cloneQueue;
        }


        static void Main()
        {
            Queue<int> originalQueue = BuildQueue(1, 2, 3, 4);
            Console.WriteLine("Original Queue: " + string.Join(", ", originalQueue));

            Queue<int> clonedQueue = CloneQueue(originalQueue);
            Console.WriteLine("Cloned Queue: " + string.Join(", ", clonedQueue));


            Console.ReadKey();
        }

    }
}
