using System;
using System.Collections.Generic;

namespace Event_Timeline
{
    class Program
    {
        static void Main()
        {
            SortedList<DateTime, string> events = new SortedList<DateTime, string>
            {
                { new DateTime(2026, 10, 5, 18, 0, 0), "Football Match" },
                { new DateTime(2026, 10, 2, 9, 30, 0), "Team Meeting" },
                { new DateTime(2026, 10, 4, 14, 0, 0), "Project Review" },
                { new DateTime(2026, 10, 3, 11, 0, 0), "Doctor Appointment" }
            };

            foreach (var e in events)
            {
                Console.WriteLine($"{e.Key:dd/MM/yyyy HH:mm} - {e.Value}");
            }


            Console.ReadKey();
        }
    }
}
