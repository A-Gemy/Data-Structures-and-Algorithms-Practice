using System;
using System.Collections.Generic;

namespace Find_Missing_Numbers
{
    class Program
    {
        private static List<int> FindMissingNumbers(SortedSet<int> numbers)
        {
            var missingNumbers = new List<int>();

            if (numbers == null || numbers.Count == 0)
                return missingNumbers;

            for (int i = numbers.Min; i <= numbers.Max; i++)
            {
                if (!numbers.Contains(i))
                {
                    missingNumbers.Add(i);
                }
            }

            return missingNumbers;
        }

        static void Main()
        {
            SortedSet<int> numbers = new SortedSet<int>
            {
                1, 2, 4, 5, 7, 10
            };
            Console.WriteLine("Original numbers:");
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            var missingNumbers = FindMissingNumbers(numbers);

            Console.WriteLine("Missing numbers:");
            foreach (var item in missingNumbers)
            {
                Console.Write($"{item} ");
            }


            Console.ReadKey();
        }
    }
}
