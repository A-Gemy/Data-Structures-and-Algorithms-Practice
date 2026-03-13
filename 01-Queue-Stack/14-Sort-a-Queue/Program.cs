using System;
using System.Collections.Generic;

namespace Sort_a_Queue
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

        static void SortQueue(Queue<int> queue)
        {
            List<int> list = new List<int>(queue);

            list.Sort();
            queue.Clear();

            foreach (int n in list)
                queue.Enqueue(n);
        }


        static void Main()
        {
            Queue<int> queue = BuildQueue(5, 1, 3, 2, 4);
            Console.WriteLine("Original Queue: " + string.Join(", ", queue));

            SortQueue(queue);
            Console.WriteLine("\nSorted Queue: " + string.Join(", ", queue));


            Console.ReadKey();
        }
    }
}
