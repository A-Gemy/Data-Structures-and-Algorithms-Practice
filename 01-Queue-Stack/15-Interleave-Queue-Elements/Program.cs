using System;
using System.Collections.Generic;
using System.Linq;

namespace Interleave_Queue_Elements
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

        static bool InterleaveQueue(Queue<int> queue)
        {
            // Interleaving requires the queue to have an even number of elements.
            if (queue.Count % 2 != 0)
            {
                Console.WriteLine("Cannot interleave a queue with an odd number of elements.");
                return false;
            }

            int halfSize = queue.Count / 2;
            Stack<int> stack = new Stack<int>();

            // Step 1:
            // Move the first half of the queue into the stack.
            // Example:
            // Queue: [1, 2, 3, 4, 5, 6] -> Stack: [1, 2, 3], Queue: [4, 5, 6]
            for (int i = 0; i < halfSize; i++)
            {
                stack.Push(queue.Dequeue());
            }

            // Step 2:
            // Pop all stack elements back into the queue.
            // This reverses the first half and places it at the back.
            // Queue becomes: [4, 5, 6, 3, 2, 1]
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            // Step 3:
            // Rotate the first half of the queue to the back.
            // Queue becomes: [3, 2, 1, 4, 5, 6]
            for (int i = 0; i < halfSize; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            // Step 4:
            // Move the first half into the stack again.
            // Stack will now allow us to pop in the correct order: 1, 2, 3
            // Queue remains with the second half: [4, 5, 6]
            for (int i = 0; i < halfSize; i++)
            {
                stack.Push(queue.Dequeue());
            }

            // Step 5:
            // Interleave one element from the stack (first half)
            // with one element from the queue (second half).
            // Final result: [1, 4, 2, 5, 3, 6]
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
                queue.Enqueue(queue.Dequeue());
            }

            return true;
        }

        static Queue<int> InterleaveQueueWithStacks(Queue<int> queue)
        {
            if (queue.Count % 2 != 0)
            {
                Console.WriteLine("Cannot interleave a queue with an odd number of elements.");
                return queue;
            }


            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();

            int count = queue.Count / 2;

            // Move first half into stack1
            for (int i = 0; i < count; i++)
            {
                stack1.Push(queue.Dequeue());
            }

            // Move second half into stack2
            for (int i = 0; i < count; i++)
            {
                stack2.Push(queue.Dequeue());
            }

            // Build the interleaving in reverse order
            for (var i = 0; i < count; i++)
            {
                queue.Enqueue(stack2.Pop());
                queue.Enqueue(stack1.Pop());
            }

            // Reverse the whole result to restore the correct order
            return new Queue<int>(queue.Reverse());
        }

        static void Main()
        {
            Queue<int> queue = BuildQueue(1, 6);
            Console.WriteLine("Original Queue: " + string.Join(", ", queue));


            if (InterleaveQueue(queue))
            {
                Console.WriteLine("Interleaved Queue: " + string.Join(", ", queue));
            }



            Console.ReadKey();
        }
    }
}
