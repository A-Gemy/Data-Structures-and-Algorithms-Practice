using System;
using System.Collections.Generic;

namespace Merge_Two_Sorted_Queues
{
    class Program
    {
        static Queue<int> BuildQueue(params int[] numbers)
        {
            Queue<int> queue = new Queue<int>();

            foreach (var n in numbers)
                queue.Enqueue(n);

            return queue;
        }

        static Queue<int> MergeQueues(Queue<int> queue1, Queue<int> queue2)
        {
            Queue<int> mergedQueue = new Queue<int>();
            Queue<int> q1 = new Queue<int>(queue1);
            Queue<int> q2 = new Queue<int>(queue2);

            while (q1.Count > 0 && q2.Count > 0)
            {
                if (q1.Peek() <= q2.Peek())
                    mergedQueue.Enqueue(q1.Dequeue());
                else
                    mergedQueue.Enqueue(q2.Dequeue());
            }

            while (q1.Count > 0)
            {
                mergedQueue.Enqueue(q1.Dequeue());
            }

            while (q2.Count > 0)
            {
                mergedQueue.Enqueue(q2.Dequeue());
            }

            return mergedQueue;
        }

        // Alternative approach for learning purposes only.
        // This works, but it does not take advantage of the fact that both queues are already sorted.
        static Queue<int> MergeQueuesWithList(Queue<int> queue1, Queue<int> queue2)
        {
            List<int> list = new List<int>(queue1);

            //foreach (var item in queue2)
            //{
            //    list.Add(item);
            //}
            list.AddRange(queue2);

            list.Sort();

            return new Queue<int>(list);
        }


        static void Main()
        {
            Queue<int> queue1 = BuildQueue(1, 3, 5);
            Console.WriteLine("Queue1: " + string.Join(", ", queue1));

            Queue<int> queue2 = BuildQueue(2, 4, 6);
            Console.WriteLine("Queue2: " + string.Join(", ", queue2));

            Queue<int> mergedQueue = MergeQueues(queue1, queue2);
            Console.WriteLine("Merged Queue: " + string.Join(", ", mergedQueue));


            Console.ReadKey();
        }
    }
}
