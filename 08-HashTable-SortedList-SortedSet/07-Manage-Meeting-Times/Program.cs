using System;
using System.Collections.Generic;

namespace Manage_Meeting_Times
{
    class Program
    {
        static void Main()
        {
            SortedList<DateTime, string> meetings = new SortedList<DateTime, string>
            {
                { new DateTime(2026, 10, 7, 15, 0, 0), "Project Review" },
                { new DateTime(2026, 10, 7, 9, 30, 0), "Daily Standup" },
                { new DateTime(2026, 10, 7, 13, 0, 0), "Client Meeting" },
                { new DateTime(2026, 10, 7, 11, 0, 0), "Backend Team Meeting" }
            };

            Console.WriteLine("Meeting Times:");

            foreach (var meeting in meetings)
            {
                Console.WriteLine($"{meeting.Key:dd/MM/yyyy HH:mm} - {meeting.Value}");
            }


            Console.ReadKey();
        }
    }
}
