using System;
using System.Collections.Generic;
using System.Linq;

namespace Implement_a_Priority_Queue
{
    class PriorityQueue
    {
        private readonly SortedDictionary<int, Queue<string>> PQ = new SortedDictionary<int, Queue<string>>();

        public int Count
        {
            get
            {
                int count = 0;

                foreach (var item in PQ)
                {
                    count += item.Value.Count;
                }

                return count;
            }
        }

        public bool IsEmpty()
        {
            return PQ.Count == 0;
        }

        public void Enqueue(int priority, string value)
        {
            if (!PQ.ContainsKey(priority))
            {
                PQ[priority] = new Queue<string>();
            }

            PQ[priority].Enqueue(value);
        }

        public string Dequeue()
        {
            if (PQ.Count == 0) return null;

            int highestPriority = PQ.Keys.First();
            string value = PQ[highestPriority].Dequeue();

            if (PQ[highestPriority].Count == 0)
            {
                PQ.Remove(highestPriority);
            }

            return value;
        }

        public string Peek()
        {
            if (PQ.Count == 0)
                return null;

            int highestPriority = PQ.Keys.First();
            return PQ[highestPriority].Peek();
        }

    }



    class Program
    {
        static void Main()
        {
            PriorityQueue pq = new PriorityQueue();

            Console.WriteLine("Is Empty: " + pq.IsEmpty());
            Console.WriteLine("Count: " + pq.Count);

            pq.Enqueue(1, "Task A");
            pq.Enqueue(3, "Task C");
            pq.Enqueue(2, "Task B");
            pq.Enqueue(1, "Task D");

            Console.WriteLine("Is Empty: " + pq.IsEmpty());
            Console.WriteLine("Count: " + pq.Count);
            Console.WriteLine("Peek: " + pq.Peek());

            Console.WriteLine("Dequeue: " + pq.Dequeue());
            Console.WriteLine("Dequeue: " + pq.Dequeue());
            Console.WriteLine("Count: " + pq.Count);
            Console.WriteLine("Peek: " + pq.Peek());

            Console.WriteLine("Dequeue: " + pq.Dequeue());
            Console.WriteLine("Dequeue: " + pq.Dequeue());

            Console.WriteLine("Is Empty: " + pq.IsEmpty());
            Console.WriteLine("Count: " + pq.Count);
            Console.WriteLine("Peek: " + pq.Peek());
            Console.WriteLine("Dequeue: " + pq.Dequeue());


            Console.ReadKey();
        }
    }
}
