using System;
using System.Collections.Generic;

namespace Generate_Binary_Numbers
{
    class Program
    {
        static List<string> GenerateBinaryNumbers(int n)
        {
            List<string> result = new List<string>();
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");

            for (int i = 0; i < n; i++)
            {
                string current = queue.Dequeue();
                result.Add(current);

                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }

            return result;
        }

        static List<string> GenerateBinaryNumbersWithTrace(int n)
        {
            List<string> result = new List<string>();
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("1");

            Console.WriteLine($"N = {n}");
            Console.WriteLine($"Initial Queue: [{string.Join(", ", queue)}]");
            Console.WriteLine(new string('-', 50));

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Step {i}");

                string current = queue.Dequeue();
                Console.WriteLine($"Dequeue -> current = {current}");

                result.Add(current);
                Console.WriteLine($"Result  -> [{string.Join(", ", result)}]");

                string left = current + "0";
                string right = current + "1";

                queue.Enqueue(left);
                queue.Enqueue(right);

                Console.WriteLine($"Enqueue -> {left}, {right}");
                Console.WriteLine($"Queue   -> [{string.Join(", ", queue)}]");
                Console.WriteLine(new string('-', 50));
            }

            return result;
        }


        static void Main()
        {
            int n = 5;

            var binaries = GenerateBinaryNumbers(n);
            Console.WriteLine($"N = {n}");
            Console.WriteLine("Binary Numbers: " + string.Join(", ", binaries));

            Console.ReadKey();
        }
    }
}
