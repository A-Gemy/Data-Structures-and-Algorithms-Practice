using System;

namespace Store_Sales
{
    class Program
    {
        private static void DisplayQuarterlySales(int[][] salesData)
        {
            if (salesData == null || salesData.Length == 0)
            {
                Console.WriteLine("No sales data available.");
                return;
            }

            int totalSales = 0;

            for (int i = 0; i < salesData.Length; i++)
            {
                int regionTotalSales = 0;

                Console.WriteLine($"Region {i + 1} quarterly sales:");

                for (int j = 0; j < salesData[i].Length; j++)
                {
                    Console.WriteLine($" - Quarter {j + 1}: ${salesData[i][j]}");

                    regionTotalSales += salesData[i][j];
                    totalSales += salesData[i][j];
                }

                Console.WriteLine("-------------------");
                Console.WriteLine($"Total sales for Region {i + 1}: ${regionTotalSales}");
                Console.WriteLine();
            }

            Console.WriteLine($"Total sales for all regions: ${totalSales}");
        }

        static void Main()
        {
            int[][] salesData =
            {
                new int[] { 10000, 12000, 11000 },
                new int[] { 15000, 16000 },
                new int[] { 9000, 9500, 9800, 10200 }
            };

            DisplayQuarterlySales(salesData);

            Console.ReadKey();
        }
    }
}
