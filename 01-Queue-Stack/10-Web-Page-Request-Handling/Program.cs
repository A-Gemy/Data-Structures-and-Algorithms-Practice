using System;
using System.Collections.Generic;

namespace Web_Page_Request_Handling
{
    class Program
    {
        static void Main()
        {
            Queue<string> requests = new Queue<string>();

            // Web-like requests (still simple strings)
            requests.Enqueue("GET /");
            requests.Enqueue("GET /products");
            requests.Enqueue("POST /login");
            requests.Enqueue("GET /profile");


            Console.WriteLine("Processing web requests:\n");

            while (requests.Count > 0)
            {
                string currentRequest = requests.Dequeue();
                Console.WriteLine($"Processed: {currentRequest}");
            }

            Console.ReadKey();
        }
    }
}
