using System;
using System.Collections;

namespace Scheduling_Tasks
{
    class Program
    {
        private static void AddTask(BitArray schedule, int dayIndex)
        {
            if (schedule == null || dayIndex < 0 || dayIndex >= schedule.Length)
                return;

            schedule.Set(dayIndex, true);
        }

        private static void DisplayWeeklySchedule(BitArray schedule, string[] days)
        {
            if (schedule == null || days == null || schedule.Length != days.Length)
            {
                Console.WriteLine("Invalid schedule data.");
                return;
            }

            Console.WriteLine("Weekly Schedule:");

            for (int i = 0; i < schedule.Length; i++)
            {
                string status = schedule[i] ? "Busy" : "Free";

                Console.WriteLine($"{days[i]}: {status}");
            }
        }

        static void Main()
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            BitArray schedule = new BitArray(7);

            AddTask(schedule, 0); // Monday
            AddTask(schedule, 2); // Wednesday
            AddTask(schedule, 5); // Saturday

            DisplayWeeklySchedule(schedule, days);


            Console.ReadKey();
        }
    }
}
