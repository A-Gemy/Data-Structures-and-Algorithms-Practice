using System;
using System.Collections.Generic;

namespace Simple_Backtracking
{
    class Program
    {
        static void Main()
        {
            Stack<string> path = new Stack<string>();

            string[] steps =
            {
                "Start",
                "Go to Gaz Station",
                "Go to Super Market",
                "Go To Work",
                "Go to Cafe",
                "Go Home"
            };

            // Print the forward path from the same data we will push to the stack
            Console.WriteLine(string.Join(" -> ", steps) + ".\n");

            // Simulate My Day (push in order)
            foreach (var step in steps)
                path.Push(step);

            // Backtracking
            Console.WriteLine("Backtracking...\n");
            while (path.Count > 0)
            {
                Console.WriteLine($"Back to: {path.Pop()}");
            }


            Console.ReadKey();
        }
    }
}
