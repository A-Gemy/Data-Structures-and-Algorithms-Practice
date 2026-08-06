using System;

namespace Daily_Products_Sales
{
    class Program
    {
        private static void DisplayProductSales(int[][] productSales)
        {
            if (productSales == null || productSales.Length == 0)
            {
                Console.WriteLine("No product sales data available.");
                return;
            }

            Console.WriteLine("Sales Data:");
            Console.WriteLine("------------");

            for (int i = 0; i < productSales.Length; i++)
            {
                Console.WriteLine($"Product {i + 1} daily sales:");

                for (int j = 0; j < productSales[i].Length; j++)
                {
                    Console.WriteLine($" - Day {j + 1}: {productSales[i][j]}");
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[][] productSales =
            {
                new int[] { 100, 120, 90 },
                new int[] { 200, 180 },
                new int[] { 75, 80, 85, 95 }
            };

            DisplayProductSales(productSales);


            Console.ReadKey();
        }
    }
}
