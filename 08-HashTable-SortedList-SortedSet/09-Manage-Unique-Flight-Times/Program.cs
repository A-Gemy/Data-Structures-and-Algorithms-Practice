using System;
using System.Collections.Generic;

namespace Manage_Unique_Flight_Times
{
    class Program
    {
        static void Main()
        {
            SortedSet<DateTime> flightTimes = new SortedSet<DateTime>
            {
                new DateTime(2026, 10, 11, 14, 0, 0),
                new DateTime(2026, 10, 11, 8, 30, 0),
                new DateTime(2026, 10, 11, 12, 15, 0),
                new DateTime(2026, 10, 11, 8, 30, 0), // Duplicate
                new DateTime(2026, 10, 11, 10, 0, 0)
            };

            Console.WriteLine("Flight times (sorted):");
            foreach (var time in flightTimes)
            {
                Console.WriteLine(time.ToShortTimeString());
            }


            Console.ReadKey();
        }
    }
}
