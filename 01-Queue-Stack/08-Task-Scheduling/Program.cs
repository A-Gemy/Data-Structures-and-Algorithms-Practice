using System;
using System.Collections.Generic;

namespace Task_Scheduling
{
    class Program
    {
        static void Main()
        {
            // Initialize a queue to hold the tasks
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Task1");
            tasks.Enqueue("Task2");
            tasks.Enqueue("Task3");
            tasks.Enqueue("Task4");


            Console.WriteLine("Executing tasks:");
            // Process tasks in the order they were added
            while (tasks.Count > 0)
            {
                // Dequeue the task at the front of the queue
                string currentTask = tasks.Dequeue();
                Console.WriteLine($"Processing: {currentTask}");
            }


            Console.ReadKey();
        }
    }
}
