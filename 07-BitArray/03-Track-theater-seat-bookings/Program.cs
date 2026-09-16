using System;
using System.Collections;

namespace Track_theater_seat_bookings
{
    class Program
    {
        private static bool IsValidSeatNumber(BitArray seats, int seatNumber)
        {
            return seats != null && seatNumber >= 1 && seatNumber <= seats.Length;
        }

        private static void BookSeat(BitArray seats, int seatNumber)
        {
            if (!IsValidSeatNumber(seats, seatNumber))
            {
                Console.WriteLine($"Invalid seat number: {seatNumber}");
                return;
            }

            seats.Set(seatNumber - 1, true);
            Console.WriteLine($"Seat {seatNumber} has been booked.");
        }

        private static void CancelBooking(BitArray seats, int seatNumber)
        {
            if (!IsValidSeatNumber(seats, seatNumber))
            {
                Console.WriteLine($"Invalid seat number: {seatNumber}");
                return;
            }

            seats.Set(seatNumber - 1, false);
            Console.WriteLine($"Booking for seat {seatNumber} has been cancelled.");
        }

        private static void DisplaySeatStatus(BitArray seats, int seatNumber)
        {
            if (!IsValidSeatNumber(seats, seatNumber))
            {
                Console.WriteLine($"Invalid seat number: {seatNumber}");
                return;
            }

            string status = seats[seatNumber - 1] ? "Booked" : "Available";

            Console.WriteLine($"Seat {seatNumber}: {status}");
        }

        private static int CountBookedSeats(BitArray seats)
        {
            if (seats == null || seats.Length == 0)
                return 0;

            int bookedSeats = 0;

            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i])
                    bookedSeats++;
            }

            return bookedSeats;
        }

        private static void DisplayBookingSummary(BitArray seats)
        {
            if (seats == null || seats.Length == 0)
            {
                Console.WriteLine("No seats available.");
                return;
            }

            int bookedSeats = CountBookedSeats(seats);
            int availableSeats = seats.Length - bookedSeats;

            Console.WriteLine($"Booked seats: {bookedSeats}");
            Console.WriteLine($"Available seats: {availableSeats}");
            Console.WriteLine($"Total seats: {seats.Length}");
        }
        
        static void Main()
        {
            BitArray seats = new BitArray(1000);

            BookSeat(seats, 10);
            BookSeat(seats, 250);
            BookSeat(seats, 999);

            Console.WriteLine();

            DisplaySeatStatus(seats, 10);
            DisplaySeatStatus(seats, 100);
            DisplaySeatStatus(seats, 250);
            DisplaySeatStatus(seats, 999);

            Console.WriteLine();
            DisplayBookingSummary(seats);

            Console.WriteLine();

            CancelBooking(seats, 10);

            Console.WriteLine();

            DisplaySeatStatus(seats, 10);

            Console.WriteLine();
            DisplayBookingSummary(seats);


            Console.ReadKey();
        }
    }
}
