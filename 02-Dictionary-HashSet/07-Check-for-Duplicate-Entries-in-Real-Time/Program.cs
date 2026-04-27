using System;
using System.Collections.Generic;

namespace Check_for_Duplicate_Entries_in_Real_Time
{
    class Program
    {
        static void Main()
        {
            HashSet<string> dataSet = new HashSet<string>();
            string[] entries = { "apple", "banana", "orange", "apple", "grape", "banana" };

            foreach (string item in entries)
            {
                if (dataSet.Add(item))
                    Console.WriteLine($"{item} added successfully.");
                else
                    Console.WriteLine($"{item} is a duplicate.");
            }

            Console.WriteLine("\nFinal Unique Data:");
            foreach (string item in dataSet)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
