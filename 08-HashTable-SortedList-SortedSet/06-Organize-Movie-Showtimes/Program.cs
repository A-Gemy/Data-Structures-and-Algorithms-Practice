using System;
using System.Collections.Generic;

namespace Organize_Movie_Showtimes
{
    class Program
    {
        private static DateTime? GetNextShowtime(SortedList<DateTime, string> showtimes, DateTime currentTime)
        {
            foreach (var showtime in showtimes)
            {
                if (showtime.Key > currentTime)
                    return showtime.Key;
            }

            return null;
        }

        static void Main()
        {
            SortedList<DateTime, string> showtimes = new SortedList<DateTime, string>
            {
                { new DateTime(2026, 10, 2, 20, 30, 0), "Interstellar" },
                { new DateTime(2026, 10, 2, 15, 0, 0), "The Dark Knight" },
                { new DateTime(2026, 10, 2, 18, 15, 0), "Inception" },
                { new DateTime(2026, 10, 2, 22, 0, 0), "The Matrix" }
            };

            Console.WriteLine("Movie Showtimes:");

            foreach (var showtime in showtimes)
            {
                Console.WriteLine($"{showtime.Key:dd/MM/yyyy HH:mm} - {showtime.Value}");
            }

            DateTime currentTime = new DateTime(2026, 10, 2, 17, 0, 0);
            DateTime? nextShowtime = GetNextShowtime(showtimes, currentTime);

            Console.WriteLine();
            Console.WriteLine($"Current time: {currentTime:dd/MM/yyyy HH:mm}");

            if (nextShowtime.HasValue)
                Console.WriteLine($"Next available slot: {nextShowtime.Value:dd/MM/yyyy HH:mm}");
            else
                Console.WriteLine("No upcoming showtimes.");


            Console.ReadKey();
        }
    }
}
