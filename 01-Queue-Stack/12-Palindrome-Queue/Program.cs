using System;
using System.Collections.Generic;

namespace Palindrome_Queue
{
    class Program
    {
        static private bool IsPalindromeQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            foreach (var item in queue)
            {
                stack.Push(item);
            }

            Queue<int> copy = new Queue<int>(queue);

            while (copy.Count > 0)
            {
                if (copy.Dequeue() != stack.Pop())
                    return false;
            }

            return true;
        }

        private static Queue<int> BuildQueue(params int[] numbers)
        {
            Queue<int> queue = new Queue<int>();

            foreach (var n in numbers)
                queue.Enqueue(n);

            return queue;
        }


        static void Main()
        {
            Queue<int> queue1 = BuildQueue(1, 2, 3, 2, 1);
            Console.WriteLine("Queue1: " + string.Join(", ", queue1));
            Console.WriteLine("Is Palindrome Queue: " + IsPalindromeQueue(queue1));

            Console.WriteLine();

            Queue<int> queue2 = BuildQueue(1, 2, 3, 4, 5);
            Console.WriteLine("Queue2: " + string.Join(", ", queue2));
            Console.WriteLine("Is Palindrome Queue: " + IsPalindromeQueue(queue2));


            Console.ReadKey();
        }
    }
}
