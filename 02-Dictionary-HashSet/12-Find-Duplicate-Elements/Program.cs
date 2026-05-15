using System;
using System.Collections.Generic;

namespace Find_Duplicate_Elements
{
    class Program
    {
        static List<int> FindDuplicateElements(int[] numbers)
        {
            List<int> duplicates = new List<int>();

            if (numbers == null || numbers.Length == 0)
                return duplicates;

            Dictionary<int, int> counts = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!counts.ContainsKey(numbers[i]))
                    counts[numbers[i]] = 0;

                counts[numbers[i]]++;

                if (counts[numbers[i]] == 2)
                    duplicates.Add(numbers[i]);
            }

            return duplicates;
        }

        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 2, 5, 6, 1 };

            List<int> duplicates = FindDuplicateElements(numbers);
            Console.WriteLine("Duplicate Elements: " + string.Join(", ", duplicates));


            Console.ReadKey();
        }

    }
}
