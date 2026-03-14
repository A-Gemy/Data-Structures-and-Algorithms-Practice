using System;
using System.Collections.Generic;

namespace Rotate_a_Queue
{
    class Program
    {
        static Queue<int> BuildQueue(int from, int to)
        {
            Queue<int> queue = new Queue<int>();

            for (int i = from; i <= to; i++)
            {
                queue.Enqueue(i);
            }

            return queue;
        }

        static void RotateQueue(Queue<int> queue, int number)
        {
            if (queue.Count == 0)
                return;

            number %= queue.Count;

            if (number == 0)
                return;

            for (int i = 0; i < number; i++)
            {
                int item = queue.Dequeue();
                queue.Enqueue(item);
            }
        }

        static void Main()
        {
            Queue<int> queue = BuildQueue(1, 5);
            Console.WriteLine("Queue: " + string.Join(", ", queue));
            int k = 2;

            RotateQueue(queue, k);
            Console.WriteLine("After rotation: " + string.Join(", ", queue));


            Console.ReadKey();
        }
    }
}
