using System;
using System.Collections.Generic;

namespace Find_Majority_Element
{
    class Program
    {
        private static int FindMajorityElement(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return -1;

            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (!counts.ContainsKey(number))
                    counts[number] = 0;

                counts[number]++;

                if (counts[number] > numbers.Length / 2)
                    return number;
            }

            return -1;
        }

        static void Main()
        {
            int[] numbers = { 3, 2, 3 };

            Console.WriteLine($"Majority Element: {FindMajorityElement(numbers)}");


            Console.ReadKey();
        }
    }
}
