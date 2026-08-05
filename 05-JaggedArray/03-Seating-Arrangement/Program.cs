using System;

namespace Seating_Arrangement
{
    class Program
    {
        private static void DisplaySeatingArrangement(int[][] classroomSeats)
        {
            if (classroomSeats == null || classroomSeats.Length == 0)
            {
                Console.WriteLine("No classroom seats available.");
                return;
            }

            for (int i = 0; i < classroomSeats.Length; i++)
            {
                Console.Write($"Row {i + 1} seats: ");

                for (int j = 0; j < classroomSeats[i].Length; j++)
                {
                    Console.Write(classroomSeats[i][j]);

                    if (j < classroomSeats[i].Length - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[][] classroomSeats =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 }
            };

            DisplaySeatingArrangement(classroomSeats);


            Console.ReadKey();
        }
    }
}
