using System;

namespace Flight_Seat_Reservations
{
    class Program
    {
        private static void DisplayFlightSeatReservations(bool[][] flightSeats)
        {
            if (flightSeats == null || flightSeats.Length == 0)
            {
                Console.WriteLine("No flight seat data available.");
                return;
            }

            for (int i = 0; i < flightSeats.Length; i++)
            {
                Console.WriteLine($"Flight {i + 1} seats:");

                for (int j = 0; j < flightSeats[i].Length; j++)
                {
                    string status = flightSeats[i][j] ? "Available" : "Reserved";
                    Console.WriteLine($" - Seat {j + 1}: {status}");
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            bool[][] flightSeats =
            {
                new bool[] { true, false, true },
                new bool[] { true, true },
                new bool[] { false, true, true, false }
            };

            DisplayFlightSeatReservations(flightSeats);


            Console.ReadKey();
        }
    }
}
