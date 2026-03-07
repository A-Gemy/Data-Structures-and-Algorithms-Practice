using System;
using System.Collections.Generic;

namespace Customer_Service
{
    class Program
    {
        static void Main()
        {
            // Initialize a queue to simulate customer arrivals
            Queue<string> customers = new Queue<string>();
            customers.Enqueue("Ahmed");
            customers.Enqueue("Sara");
            customers.Enqueue("Omar");
            customers.Enqueue("Mona");

            Console.WriteLine("Serving customers:\n");

            // Serve customers in the order they arrived
            while (customers.Count > 0)
            {
                string currentCustomer = customers.Dequeue();
                Console.WriteLine($"Serving: {currentCustomer}");
            }


            Console.ReadKey();
        }
    }
}