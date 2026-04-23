using System;
using System.Collections.Generic;

namespace Phonebook_Application
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            {
                { "Alice", "123-456-7890" },
                { "Bob", "987-654-3210" }
            };

            Console.WriteLine($"Alice's Phone: {phoneBook["Alice"]}");
            Console.WriteLine($"Bob's Phone: {phoneBook["Bob"]}");


            Console.ReadKey();
        }
    }
}
