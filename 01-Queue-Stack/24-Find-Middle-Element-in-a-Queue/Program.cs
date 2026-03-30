using System;
using System.Collections.Generic;

namespace Find_Middle_Element_in_a_Queue
{
    class Program
    {
        static int FindMiddle(Queue<int> queue)
        {
            if (queue.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            List<int> list = new List<int>(queue);
            return list[list.Count / 2];
        }


        static void Main()
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Middle Element: " + FindMiddle(queue));


            Console.ReadKey();
        }
    }
}
