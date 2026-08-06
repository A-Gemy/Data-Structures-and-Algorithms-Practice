using System;

namespace City_Temperature
{
    class Program
    {
        private static void DisplayCityTemperatures(int[][] cityTemperatures)
        {
            if (cityTemperatures == null || cityTemperatures.Length == 0)
            {
                Console.WriteLine("No city temperature data available.");
                return;
            }

            for (int i = 0; i < cityTemperatures.Length; i++)
            {
                if (cityTemperatures[i] == null || cityTemperatures[i].Length == 0)
                {
                    Console.WriteLine($"City {i + 1} has no temperature data.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine($"City {i + 1} temperature readings:");

                for (int j = 0; j < cityTemperatures[i].Length; j++)
                {
                    Console.WriteLine($" - Day {j + 1}: {cityTemperatures[i][j]}°C");
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[][] cityTemperatures =
            {
                new int[] { 30, 32, 31 },
                new int[] { 28, 29 },
                new int[] { 35, 36, 34, 33 }
            };

            DisplayCityTemperatures(cityTemperatures);


            Console.ReadKey();
        }
    }
}
