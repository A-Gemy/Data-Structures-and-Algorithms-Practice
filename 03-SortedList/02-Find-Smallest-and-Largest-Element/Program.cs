using System;
using System.Collections.Generic;

namespace Find_Smallest_and_Largest_Element
{
    class Program
    {
        private static (int smallest, int largest) FindSmallestAndLargest(SortedSet<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                return (0, 0);

            return (numbers.Min, numbers.Max);
        }

        static void Main()
        {
            SortedSet<int> numbers = new SortedSet<int> { 4, 2, 5, 1, 3 };
            var result = FindSmallestAndLargest(numbers);

            Console.WriteLine($"Smallest: {result.smallest}, Largest: {result.largest}");


            Console.ReadKey();
        }
    }
}
